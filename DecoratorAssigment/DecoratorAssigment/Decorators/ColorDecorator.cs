using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssigment.Decorators
{
    public class ColorDecorator : Decorator<string>
    {
        public ColorDecorator(IComponent<string> _component) : base(_component) { }

        public override string GetText()
        {
            return $"\u001b[31m{base.GetText()}\u001b[0m";
        }
    }
}
