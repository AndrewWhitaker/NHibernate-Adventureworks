namespace AdventureWorks.Database.Mapping
{
    using AdventureWorks.Entities.Person;
    using NHibernate.Mapping.ByCode;
    using NHibernate.Mapping.ByCode.Conformist;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PersonMap : ClassMapping<Person>
    {
        public PersonMap()
        {
            OneToOne(p => p.Password, m =>
            {
                m.Cascade(NHibernate.Mapping.ByCode.Cascade.All);
            });
        }
    }
}
