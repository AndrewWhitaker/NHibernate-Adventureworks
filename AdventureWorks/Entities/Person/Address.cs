namespace AdventureWorks.Entities.Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Address : Entity
    {
        public virtual string AddressLine1 { get; set; }

        public virtual string AddressLine2 { get; set; }

        public virtual string City { get; set; }

        public virtual string PostalCode { get; set; }
    }
}
