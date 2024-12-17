namespace CreationPatternPractice
{
    /// <summary>
    /// Жилое пространтсво, абстракция
    /// </summary>
    public abstract class LivingSpace : ICloneable
    {
        public string Country { get; protected set; }

        public uint AreaInSqMeters { get; protected set; }

        public uint LivableAreaInSqMeters { get; protected set; }

        public uint MaxTenants { get; protected set; }

        public uint CurrentTenants { get; protected set; }

        public bool Occupied { get; protected set; }

        public bool Sheltered { get; protected set; }

        public LivingSpace(string country, uint area, uint maxTenants, bool sheltered)
        {
            Country = country;
            AreaInSqMeters = area;
            MaxTenants = maxTenants;
            Sheltered = sheltered;
            CurrentTenants = 0;
            Occupied = false;
        }

        public LivingSpace(LivingSpace source)
        {
            Country = source.Country;
            AreaInSqMeters = source.AreaInSqMeters;
            MaxTenants = source.MaxTenants;
            Sheltered = source.Sheltered;
            CurrentTenants = source.CurrentTenants;
            Occupied = source.Occupied;
        }

        public void SettleTenantsIn(uint newTenantCount)
        {
            if (CurrentTenants == MaxTenants)
            {
                throw new ArgumentOutOfRangeException("Living space is at max tenant capacity");
            }
            else if (CurrentTenants + newTenantCount > MaxTenants)
            {
                throw new ArgumentOutOfRangeException("Settling in tenant count exceeds max tenant count");
            }
            CurrentTenants += newTenantCount;
            Occupied = true;
        }

        public void KickTenantsOut(uint movingTenants)
        {
            if (CurrentTenants == 0)
            {
                throw new ArgumentOutOfRangeException("No tenants to move out");
            }
            else if (movingTenants > CurrentTenants)
            {
                throw new ArgumentOutOfRangeException("Kicked out tenant count exceeds current tenant count");
            }
            CurrentTenants -= movingTenants;
            if (CurrentTenants == 0) Occupied = false;
        }

        public abstract object Clone();
    }
}
