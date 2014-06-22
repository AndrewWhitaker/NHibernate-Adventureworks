namespace AdventureWorks.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
