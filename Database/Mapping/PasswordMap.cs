namespace AdventureWorks.Database.Mapping
{
    using AdventureWorks.Entities.Person;
    using NHibernate.Mapping.ByCode.Conformist;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PasswordMap : ClassMapping<Password>
    {
        public PasswordMap()
        {
            Id(pwd => pwd.Id, m => m.Column("BusinessEntityID"));
            ManyToOne(pwd => pwd.Person, m => m.Column("BusinessEntityID"));
        }
    }
}
