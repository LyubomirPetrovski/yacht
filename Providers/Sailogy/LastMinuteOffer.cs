using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yacht.Providers.Sailogy
{
    internal class LastMinuteOffer
    {
        public int id { get; set; }
        public Boat boat { get; set; }
        public MarinaDeparture marina_departure { get; set; }
        public MarinaArrival marina_arrival { get; set; }
        public string start_date { get; set; }
        public int weeks_count { get; set; }
        public bool is_skippered { get; set; }
        public double final_price { get; set; }
        public double min_bundle_price { get; set; }
        public double original_price { get; set; }
        public int discount_percentage { get; set; }
        public List<Feature> features { get; set; }
        public object special_condition { get; set; }
        public Extras extras { get; set; }
        public string custom_equipments { get; set; }
        public string checkin_time { get; set; }
        public string checkout_time { get; set; }
        public string safety_checkout_time { get; set; }
        public bool is_optioned { get; set; }
        public bool is_blocked { get; set; }
        public bool is_real_time { get; set; }
        public object is_optioned_till { get; set; }
        public bool is_available { get; set; }
        public bool is_easy_cancellation_available { get; set; }
        public EasyCancellation easy_cancellation { get; set; }
        public int option_duration { get; set; }
        public int reserve_amount { get; set; }
        public string downpayment_deadline { get; set; }
        public string full_payment_deadline { get; set; }
        public int downpayment_amount { get; set; }
        public int downpayment_percentage { get; set; }
        public double balance_except_downpayment { get; set; }
        public int onsite_extras_sum { get; set; }
        public InsuranceInfo insurance_info { get; set; }
        public Quote quote { get; set; }
        public bool is_last_minute { get; set; }
        public bool is_skipper_price_confirmed { get; set; }
        public bool is_boat_owner { get; set; }
        public List<object> broadcast_messages { get; set; }
        public string end_date { get; set; }
        public List<RoundWeek> round_weeks { get; set; }
        public bool is_skipper_compulsory { get; set; }
        public bool is_skipper_optional { get; set; }
        public string departure_date { get; set; }
        public string arrival_date { get; set; }
        public List<object> attachments { get; set; }
        public List<DepositInfo> deposit_info { get; set; }
        public List<Bundle> bundles { get; set; }

        public class Boat
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public Type type { get; set; }
            public int year { get; set; }
            public int wc { get; set; }
            public List<Gallery> gallery { get; set; }
            public object refit_year { get; set; }
            public double length { get; set; }
            public Cabins cabins { get; set; }
            public int berths { get; set; }
            public object boat_class { get; set; }
            public Model model { get; set; }
            public Manufacturer manufacturer { get; set; }
            public Badges badges { get; set; }
            public List<List<object>> equipments { get; set; }
            public string description { get; set; }
            public string layout_image { get; set; }
            public Rating rating { get; set; }
        }

        public class Badges
        {
            public bool sailogy_choice { get; set; }
            public bool best_quality { get; set; }
            public bool black_friday { get; set; }
        }

        public class Bundle
        {
            public string name { get; set; }
            public string excerpt { get; set; }
            public string slug { get; set; }
            public double price { get; set; }
            public double online_amount { get; set; }
            public List<Pillar> pillars { get; set; }
            public string theme { get; set; }
            public int min_payment_amount { get; set; }
            public int ticket_response_days { get; set; }
            public LateCheckin late_checkin { get; set; }
            public bool professional_crew_allowed { get; set; }
            public bool shared_payments_allowed { get; set; }
            public bool tickets_allowed { get; set; }
            public bool emails_allowed { get; set; }
            public bool calls_allowed { get; set; }
            public bool coupons_allowed { get; set; }
            public bool on_vacation_assistance_allowed { get; set; }
            public List<DetailedQuote> detailed_quote { get; set; }
            public int downpayment_amount { get; set; }
            public string downpayment_deadline { get; set; }
            public int downpayment_percentage { get; set; }
            public string full_payment_deadline { get; set; }
            public double balance_except_downpayment { get; set; }
            public CancellationInsurance cancellation_insurance { get; set; }
            public List<DepositInfo> deposit_info { get; set; }
            public int check_in_deadline_days { get; set; }
            public bool is_recommended { get; set; }
        }

        public class Cabins
        {
            public int single { get; set; }
            public int @double { get; set; }
            public int double_bunk_cabins { get; set; }
            public int total { get; set; }
        }

        public class CancellationInsurance
        {
            public int total { get; set; }
            public double percentage { get; set; }
            public int downpayment { get; set; }
            public int fullpayment { get; set; }
        }

        public class Compulsory
        {
            public string name { get; set; }
            public string description { get; set; }
            public int final_price { get; set; }
            public bool is_skipper_service { get; set; }
            public bool is_hostess_service { get; set; }
            public bool payment_per_person { get; set; }
            public bool is_compulsory { get; set; }
            public bool is_confirmable { get; set; }
            public object is_confirmed { get; set; }
            public bool is_active { get; set; }
        }

        public class DepositInfo
        {
            public string slug { get; set; }
            public double deposit_amount { get; set; }
            public double deposit_insurance_amount { get; set; }
        }

        public class DetailedQuote
        {
            public string label { get; set; }
            public double price { get; set; }
        }

        public class EasyCancellation
        {
            public bool is_available { get; set; }
            public string deadline { get; set; }
            public int percentage { get; set; }
            public int days { get; set; }
        }

        public class Extras
        {
            public List<Compulsory> compulsory { get; set; }
            public List<Optional> optional { get; set; }
        }

        public class Feature
        {
            public string title { get; set; }
            public string icon_class { get; set; }
        }

        public class Gallery
        {
            public string url { get; set; }
            public string type { get; set; }
        }

        public class InsuranceInfo
        {
            public bool has_multiple_insurances { get; set; }
            public double deposit { get; set; }
            public double insurance { get; set; }
            public string insurance_description { get; set; }
            public double small_deposit { get; set; }
            public List<List<string>> deposit_payment_methods { get; set; }
            public string deposit_description { get; set; }
        }

        public class LateCheckin
        {
            public bool available { get; set; }
            public double? amount { get; set; }
            public DateTime? deadline { get; set; }
        }

        public class Manufacturer
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class MarinaArrival
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public List<double> coords { get; set; }
            public string image { get; set; }
            public string country { get; set; }
            public string country_code { get; set; }
        }

        public class MarinaDeparture
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public List<double> coords { get; set; }
            public string image { get; set; }
            public string country { get; set; }
            public string country_code { get; set; }
        }

        public class Model
        {
            public int id { get; set; }
            public string slug { get; set; }
        }

        public class OnsiteExtra
        {
            public string name { get; set; }
            public string description { get; set; }
            public int final_price { get; set; }
            public bool is_skipper_service { get; set; }
            public bool is_hostess_service { get; set; }
            public bool payment_per_person { get; set; }
            public bool is_compulsory { get; set; }
            public bool is_confirmable { get; set; }
            public object is_confirmed { get; set; }
            public bool is_active { get; set; }
        }

        public class Optional
        {
            public string name { get; set; }
            public string description { get; set; }
            public int final_price { get; set; }
            public bool is_skipper_service { get; set; }
            public bool is_hostess_service { get; set; }
            public bool payment_per_person { get; set; }
            public bool is_compulsory { get; set; }
            public bool is_confirmable { get; set; }
            public object is_confirmed { get; set; }
            public bool is_active { get; set; }
        }

        public class Pillar
        {
            public string label { get; set; }
            public bool? included { get; set; }
        }

        public class Quote
        {
            public List<object> online_extras { get; set; }
            public List<OnsiteExtra> onsite_extras { get; set; }
            public List<DetailedQuote> detailed_quote { get; set; }
            public double online_amount { get; set; }
            public double paid_amount { get; set; }
        }

        public class Rating
        {
            public int best { get; set; }
            public double score { get; set; }
            public int count { get; set; }
        }

        public class RoundWeek
        {
            public int id { get; set; }
            public string start_date { get; set; }
            public int weeks_count { get; set; }
            public double final_price { get; set; }
            public double min_bundle_price { get; set; }
            public double original_price { get; set; }
            public int discount_percentage { get; set; }
            public bool is_available { get; set; }
            public bool is_optioned { get; set; }
            public bool is_blocked { get; set; }
        }
        public class Type
        {
            public string label { get; set; }
            public int value { get; set; }
        }
    }
}
