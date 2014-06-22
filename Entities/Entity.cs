namespace AdventureWorks.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Entity
    {
        public virtual int Id { get; set; }

        public virtual DateTime ModifiedDate { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Entity o = obj as Entity;

            if (o == null)
            {
                return false;
            }

            return o.Id == this.Id;
        }
    }
}
