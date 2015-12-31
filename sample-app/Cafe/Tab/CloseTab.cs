using Edument.CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cafe.Tab
{
    public class CloseTab : ICommand
    {
        public Guid Id { get; set; }
        public decimal AmountPaid;
    }
}
