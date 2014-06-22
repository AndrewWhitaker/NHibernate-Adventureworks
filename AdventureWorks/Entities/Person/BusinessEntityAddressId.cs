namespace AdventureWorks.Entities.Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class BusinessEntityAddressId
    {
        public virtual BusinessEntity BusinessEntity { get; set; }

        public virtual Address Address { get; set; }

        public virtual AddressType AddressType { get; set; }

        public override int GetHashCode()
        {
            return BusinessEntity.GetHashCode() ^ AddressType.GetHashCode() ^ Address.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var otherId = obj as BusinessEntityAddressId;

            if (otherId == null)
            {
                return false;
            }

            return this.Address.Equals(otherId.Address) &&
                this.AddressType.Equals(otherId.AddressType) &&
                this.BusinessEntity.Equals(otherId.BusinessEntity);
        }
    }
}
