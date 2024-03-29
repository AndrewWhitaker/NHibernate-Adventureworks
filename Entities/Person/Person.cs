﻿namespace AdventureWorks.Entities.Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person : BusinessEntity
    {
        public virtual string PersonType { get; set; }

        public virtual NameStyle NameStyle { get; set; }

        public virtual string Title { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string MiddleName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Suffix { get; set; }

        public virtual int EmailPromotion { get; set; }

        public virtual Password Password { get; set; }
    }
}
