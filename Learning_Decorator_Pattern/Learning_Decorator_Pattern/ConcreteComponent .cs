using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Decorator_Pattern
{
    public class ConcreteComponent:IComponent<string>
    {
        public string GetText()
        {
            return "This is the returning string";
        }
    }
}
