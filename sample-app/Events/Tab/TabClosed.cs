using Edument.CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events.Cafe
{
    public class TabClosed : IEvent
    {
        public Guid Id { get; set; }
        public decimal AmountPaid;
        public decimal OrderValue;
        public decimal TipValue;
    }
}
