using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Decorator_Pattern
{
    public class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<string> component) : base(component) { }
        public override string GetText()
        {
            return String.Concat("Here is the Prefix " , component.GetText());
        }
    }
}
