namespace AdventureWorks.Database.Mapping
{
    using AdventureWorks.Entities.Production;
    using NHibernate.Mapping.ByCode.Conformist;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductCostHistoryMap : ClassMapping<ProductCostHistory>
    {
        public ProductCostHistoryMap()
        {
            ComposedId(opt =>
            {
                opt.Property(pch => pch.StartDate);
                opt.ManyToOne(pch => pch.Product);
            });
        }
    }
}
