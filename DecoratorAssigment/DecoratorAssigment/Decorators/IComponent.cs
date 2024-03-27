using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssigment.Decorators
{
    public interface IComponent<T>
    {
        T GetText();
    }
}
