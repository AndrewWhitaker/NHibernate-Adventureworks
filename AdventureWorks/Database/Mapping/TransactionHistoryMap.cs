namespace AdventureWorks.Database.Mapping
{
    using AdventureWorks.Entities.Production;
    using NHibernate.Mapping.ByCode.Conformist;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TransactionHistoryMap : ClassMapping<TransactionHistory>
    {
        public TransactionHistoryMap()
        {
            Id(tx => tx.Id, m => m.Column("TransactionID"));
        }
    }
}
