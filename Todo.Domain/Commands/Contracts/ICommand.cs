using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flunt.Validations;

namespace Todo.Domain.Commands.Contracts
{
    public interface ICommand
    {
        bool Validate();
    }
}
