
namespace AdventureWorks.Entities.Production
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Product : Entity
    {
        public virtual string Name { get; set; }

        public virtual string ProductNumber { get; set; }

        public virtual bool Make { get; set; }

        public bool FinishedGoods { get; set; }

        public string Color { get; set; }

        public short SafetyStockLevel { get; set; }

        public short ReorderPoint { get; set; }

        public decimal StandardCost { get; set; }

        public decimal ListPrice { get; set; }

        public string Size { get; set; }

        public double Weight { get; set; }

        public int DaysToManufacture { get; set; }

        public string ProductLine { get; set; }

        public string Class { get; set; }

        public string Style { get; set; }

        public DateTime SellStartDate { get; set; }

        public DateTime? SellEndDate { get; set; }

        public DateTime DiscontinuedDate { get; set; }
    }
}
