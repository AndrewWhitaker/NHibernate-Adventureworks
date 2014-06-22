namespace AdventureWorks.Entities.Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BusinessEntityContact : Entity
    {
        public virtual Person Person { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}
