using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edument.CQRS
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}
