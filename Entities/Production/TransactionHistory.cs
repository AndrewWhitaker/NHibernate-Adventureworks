﻿namespace AdventureWorks.Entities.Production
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class TransactionHistory : Entity
    {
        public virtual Product Product { get; set; }

        public virtual int ReferenceOrderID { get; set; }

        public virtual int ReferenceOrderLineID { get; set; }

        public virtual DateTime TransactionDate { get; set; }

        public virtual char TransactionType { get; set; }

        public virtual int Quantity { get; set; }

        public virtual decimal ActualCost { get; set; }
    }
}
