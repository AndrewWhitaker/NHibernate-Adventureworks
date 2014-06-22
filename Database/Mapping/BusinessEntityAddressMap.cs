namespace AdventureWorks.Database.Mapping
{
    using AdventureWorks.Entities.Person;
    using NHibernate.Mapping.ByCode.Conformist;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BusinessEntityAddressMap : ClassMapping<BusinessEntityAddress>
    {
        public BusinessEntityAddressMap()
        {
            ComponentAsId(p => p.Id, m =>
            {
                m.ManyToOne(id => id.Address);
                m.ManyToOne(id => id.AddressType);
                m.ManyToOne(id => id.BusinessEntity);
            });
        }
    }
}
