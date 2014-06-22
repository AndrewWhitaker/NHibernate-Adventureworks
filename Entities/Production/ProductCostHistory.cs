namespace AdventureWorks.Entities.Production
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class ProductCostHistory : Entity
    {
        public virtual Product Product { get; set; }

        public virtual DateTime StartDate { get; set; }

        public virtual DateTime? EndDate { get; set; }

        public virtual decimal StandardCost { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var history = obj as ProductCostHistory;

            if (obj == null)
            {
                return false;
            }

            return history.StartDate == this.StartDate &&
                history.Product == this.Product;
        }

        public override int GetHashCode()
        {
            return (this.StartDate.Ticks.ToString() + "|" + this.Product.Id.ToString()).GetHashCode();
        }
    }
}
