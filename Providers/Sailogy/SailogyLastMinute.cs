using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Yacht.Entities;

namespace Yacht.Providers.Sailogy
{
    internal class SailogyLastMinute
    {
        private HashSet<string> traversedBoats = new();

        private readonly HttpClient httpClient;

        public SailogyLastMinute(
            IHttpClientFactory httpClientFactory)
        {
            httpClient = httpClientFactory.CreateClient();
        }
        public async Task Scrape()
        {
            uint page = 1;
            while (page == 1)
            {
                var pagedOffers = await ScrappedPagedOffers(page);
                foreach (var offer in pagedOffers.results)
                {
                    var scrappedOfferDetails = await ScrappedOfferDetails(offer.id);
                    if (scrappedOfferDetails == null)
                    {
                        //Log
                        continue;
                    }

                    var boat = ExtractBoatInfo(scrappedOfferDetails!);

                    if (!traversedBoats.Contains(boat.ProviderId))
                    {
                        await UpsertBoat(boat);

                        traversedBoats.Add(boat.ProviderId);
                    }

                    // Check calendar for every round week
                }

                page++;
            }
        }

        private async Task UpsertBoat(SailingBoat boat)
        {
            /* Upsert boat by ProviderId and Hash.   */
        }

        private async Task<LastMinutePagedOffers> ScrappedPagedOffers(uint page)
        {
            var response = await httpClient.GetAsync(string.Format("https://old.sailogy.com/api/v1/offers/last-minute/?page={0}", page));
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsByteArrayAsync();
                return JsonSerializer.Deserialize<LastMinutePagedOffers>(content);
            }

            return null;
        }

        private async Task<LastMinuteOffer> ScrappedOfferDetails(int offerId)
        {
            var response = await httpClient.GetAsync(String.Format("https://fleet.sailogy.rest/v1/cruise/{0}", offerId));
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsByteArrayAsync();
                return JsonSerializer.Deserialize<LastMinuteOffer>(content);
            }

            return null;
        }

        private SailingBoat ExtractBoatInfo(LastMinuteOffer offer)
        {
            return new SailingBoat
            {
                ProviderId = offer.boat.id.ToString(),
                Alias = offer.boat.slug,
                Model = new Model
                {
                    Id = offer.boat.model.id.ToString(),
                    Alias = offer.boat.model.slug,
                    Name = offer.boat.name
                },
                BoatType = GetBoatType(offer.boat.type.value),
                Year = offer.boat.year,
                Berths = offer.boat.berths,
                Cabins = new Cabins
                {
                    Single = offer.boat.cabins.single,
                    Double = offer.boat.cabins.@double,
                    DoubleBunkCabins = offer.boat.cabins.double_bunk_cabins,
                    Total = offer.boat.cabins.total
                },
                WC = offer.boat.wc,
                Lenght = offer.boat.length,
            };
        }

        private BoatType GetBoatType(int boatTypeValue)
        {
            return boatTypeValue switch
            {
                1 => BoatType.Monohul,
                2 => BoatType.Catamaran,
                _ => BoatType.None
            };
        }
    }
}
