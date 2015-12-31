using Edument.CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events.Cafe
{
    public class FoodServed : IEvent
    {
        public Guid Id { get; set; }
        public List<int> MenuNumbers;
    }
}
