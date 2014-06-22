namespace AdventureWorks.Entities.Production
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductCategory : Entity
    {
        private IList<ProductSubcategory> _subcategories = new List<ProductSubcategory>();

        public virtual string Name { get; set; }

        public virtual IEnumerable<ProductSubcategory> Subcategories 
        { 
            get 
            {
                return this._subcategories;
            } 
        }
    }
}
