namespace AdventureWorks.Entities.Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class BusinessEntity : Entity
    {
        protected IList<BusinessEntityAddress> _addresses = new List<BusinessEntityAddress>();
        protected IList<BusinessEntityContact> _contacts = new List<BusinessEntityContact>();

        public virtual IEnumerable<BusinessEntityAddress> Addresses
        {
            get { return this._addresses; }
        }

        public virtual IEnumerable<BusinessEntityContact> Contacts
        {
            get { return this._contacts; }
        }
    }
}
