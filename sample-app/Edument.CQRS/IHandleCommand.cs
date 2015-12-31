using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Edument.CQRS
{
    public interface IHandleCommand<TCommand> where TCommand : ICommand
    {
        IEnumerable<IEvent> Handle(TCommand c);
    }
}
