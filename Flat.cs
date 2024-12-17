namespace CreationPatternPractice
{
    /// <summary>
    /// Обычная квартира в жилом доме
    /// </summary>
    public class Flat : LivingSpace, IMyCloneable<Flat>
    {

        public string City { get; protected set; }

        public string StreetName { get; protected set; }

        public uint HouseNum { get; protected set; }

        public uint ApartmentNum { get; protected set; }

        public uint BalconyArea { get; protected set; }

        public uint LivableArea { get; protected set; }

        public Flat(string city, string street, uint house, uint apartment, string country, uint area, uint maxTenants) : base(country, area, maxTenants, true)
        {
            City = city;
            StreetName = street;
            HouseNum = house;
            ApartmentNum = apartment;
            BalconyArea = area / 2 * 10;
            LivableArea = area - BalconyArea;
        }

        public Flat(Flat source) : base(source)
        {
            City = source.City;
            StreetName = source.StreetName;
            HouseNum = source.HouseNum;
            ApartmentNum = source.ApartmentNum;
            BalconyArea = source.BalconyArea;
            LivableArea = source.LivableArea;
        }

        public Flat CloneThis()
        {
            return new Flat(this);
        }

        public override object Clone()
        {
            return CloneThis();
        }
    }
}
