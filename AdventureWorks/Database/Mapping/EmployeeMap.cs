namespace AdventureWorks.Database.Mapping
{
    using AdventureWorks.Entities.HumanResources;
    using NHibernate.Mapping.ByCode.Conformist;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EmployeeMap : JoinedSubclassMapping<Employee>
    {
        public EmployeeMap()
        {
            Key(km =>
            {
                km.Column("BusinessEntityID");
            });
        }
    }
}
