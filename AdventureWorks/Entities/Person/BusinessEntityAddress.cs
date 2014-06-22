namespace AdventureWorks.Entities.Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BusinessEntityAddress : Entity
    {
        public virtual BusinessEntityAddressId Id { get; set; }
    }
}
