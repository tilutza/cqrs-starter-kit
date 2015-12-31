using Edument.CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events.Cafe
{
    public class TabOpened : IEvent
    {
        public Guid Id { get; set; }
        public int TableNumber;
        public string Waiter;
    }
}
