namespace CreationPatternPractice
{
    /// <summary>
    /// Многоэтажный пентхаус
    /// </summary>
    public class Penthouse : Flat, IMyCloneable<Penthouse>
    {
        public uint NumberOfFloors { get; set; }

        public Penthouse(uint floors, string city, string street, uint house, uint apartment, string country, uint area, uint maxTenants) : base(city, street, house, apartment, country, area, maxTenants)
        {
            NumberOfFloors = floors;
        }

        public Penthouse(Penthouse source) : base(source)
        {
            NumberOfFloors = source.NumberOfFloors;
        }

        public new Penthouse CloneThis()
        {
            return new Penthouse(this);
        }
    }
}
