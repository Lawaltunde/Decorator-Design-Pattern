using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Decorator_Pattern
{
    abstract class Decorator<T>:IComponent<T>
    {
        protected IComponent<T> component;

        public Decorator(IComponent<T> _component)
        {
            component = _component;
        }

        public T GetText()
        {
            return component.GetText();
        }
    }
}
