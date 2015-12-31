using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events.Cafe;
using Edument.CQRS;

namespace Cafe.Tab
{
    public class PlaceOrder : ICommand
    {
        public Guid Id { get; set; }
        public List<OrderedItem> Items;
    }
}
