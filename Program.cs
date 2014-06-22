namespace AdventureWorks
{
    using AdventureWorks.Database;
    using AdventureWorks.Entities.Person;
    using AdventureWorks.Entities.Production;
    using NHibernate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NHibernate.Linq;
    using NHibernate.Criterion;
    using NHibernate.Criterion.Lambda;
    using NHibernate.Transform;
    using System.Collections;
    using AdventureWorks.Entities.HumanResources;

    public class Program
    {
        public static void Main(string[] args)
        {
            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Initialize();

            using (var session = bootstrapper.SessionFactory.OpenSession())
            {
                Query(session);
                Console.ReadKey();
            }
        }

        public static void Query(ISession session)
        {
        }
    }
}
