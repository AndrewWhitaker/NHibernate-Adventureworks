namespace AdventureWorks.Entities.Production
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class ProductModel : Entity
    {
        public virtual string Name { get; set; }

        public virtual string CatalogDescription { get; set; }

        public virtual string Instructions { get; set; }
    }
}
