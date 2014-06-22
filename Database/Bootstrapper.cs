namespace AdventureWorks.Database
{
    using AdventureWorks.Database.Conventions;
    using AdventureWorks.Database.Mapping;
    using AdventureWorks.Entities;
    using AdventureWorks.Entities.Production;
    using NHibernate;
    using NHibernate.Cfg;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    
    public class Bootstrapper
    {
        public void Initialize()
        {
            var mapper = new AdventureWorksModelMapper(typeof(Entity));

            var entities = Assembly.GetExecutingAssembly()
                .GetExportedTypes()
                .Where(t => typeof(Entity).IsAssignableFrom(t) && t != typeof(Entity));

            mapper.AddMappings(Assembly.GetExecutingAssembly().GetExportedTypes());

            var mappings = mapper.CompileMappingFor(entities);

            var cfg = new Configuration()
                .Configure()
                .DataBaseIntegration(db =>
                {
                    db.LogSqlInConsole = true;
                    db.LogFormattedSql = true;
                });

            cfg.AddMapping(mappings);

            this.SessionFactory = cfg.BuildSessionFactory();
        }

        public ISessionFactory SessionFactory { get; private set; }
    }
}
