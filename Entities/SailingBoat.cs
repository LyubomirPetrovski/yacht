namespace Yacht.Entities
{
    internal class SailingBoat
    {
        public string Id { get; set; }

        /// <summary>
        /// Boat ID comming from the provider
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// Boat name unique by registration authority
        /// </summary>
        public string Name { get; set; }
        public string Alias { get; set; }
        public Model Model { get; set; }
        public BoatType BoatType { get; set; }
        public int Year { get; set; }
        public int Berths { get; set; }
        public Cabins Cabins { get; set; }
        public int WC { get; set; }

        /// <summary>
        /// Lenght in meters
        /// </summary>
        public double Lenght { get; set; }

        public string Hash { get; set; }
    }

    internal class Source
    {
        public string Id { get; set; }
        public string Provider { get; set; }
    }

    internal class Model
    {
        public string Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
    }

    internal class Cabins
    {
        public int Single { get; set; }
        public int Double { get; set; }
        public int DoubleBunkCabins { get; set; }
        public int Total { get; set; }
    }

    internal enum BoatType
    { 
        None,

        Monohul,
        Catamaran,
        Motorboat
    }
}
