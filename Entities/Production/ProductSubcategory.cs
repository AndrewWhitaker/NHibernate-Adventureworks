namespace AdventureWorks.Entities.Production
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductSubcategory : Entity
    {
        public virtual string Name { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}
