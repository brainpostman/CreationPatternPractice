namespace CreationPatternPractice
{
    /// <summary>
    /// Под мостом тоже живут
    /// </summary>
    public class Underpass : LivingSpace, IMyCloneable<Underpass>
    {
        public uint NumberOfTrolls { get; protected set; }

        public Underpass(uint trolls, string country, uint area, uint maxTenants) : base(country, area, maxTenants, false)
        {
            NumberOfTrolls = trolls;
        }

        public Underpass(Underpass source) : base(source)
        {
            NumberOfTrolls = source.NumberOfTrolls;
        }

        public Underpass CloneThis()
        {
            return new Underpass(this);
        }

        public override object Clone()
        {
            return CloneThis();
        }
    }
}
