using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Decorator_Pattern
{
    public class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return  component.GetText().ToUpper();
        }
    }
}
