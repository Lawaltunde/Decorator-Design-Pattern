using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssigment
{
    public class UpperCaseDecorator: Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> _component):base(_component) { }

        public override string GetText()
        {
            return (base.GetText()).ToUpper();
        }
    }
}
