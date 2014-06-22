namespace AdventureWorks.Mapping
{
    using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

    public class SessionBuilder
    {
        public 
        var cfg = new Configuration()
            .Configure()
            .DataBaseIntegration(db =>
            {
                db.LogFormattedSql = true;
                db.LogSqlInConsole = true;
            })
            .AddAssembly(Assembly.GetExecutingAssembly());
    }
}
