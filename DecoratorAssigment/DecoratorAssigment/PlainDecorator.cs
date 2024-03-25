using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssigment
{
    public class PlainDecorator: Decorator<string>
    {
        public PlainDecorator(IComponent<string> _component) : base(_component)
        {
        }

        public override string GetText()
        {
            return string.Concat("The prefix", base.GetText());
        }
    }
}
