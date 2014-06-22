namespace AdventureWorks.Entities.Production
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductReview : Entity
    {
        public virtual Product Product { get; set; }

        public virtual string ReviewerName { get; set; }

        public virtual DateTime ReviewDate { get; set; }

        public virtual string EmailAddress { get; set; }

        public virtual int Rating { get; set; }

        public virtual string Comments { get; set; }
    }
}
