using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssigment.Decorators
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "String is returned as professor instructed";
        }
    }
}
