namespace AdventureWorks.Mapping.Production
{
    using AdventureWorks.Entities.Production;
    using NHibernate.Mapping.ByCode.Conformist;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductMap : ClassMapping<Product>
    {
        public ProductMap()
        {
        }
    }
}
