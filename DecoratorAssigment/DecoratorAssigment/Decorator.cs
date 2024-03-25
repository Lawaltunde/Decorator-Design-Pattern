using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssigment
{
    public abstract class Decorator<T> : IComponent<T>
    {
       protected IComponent<T> component;

        public Decorator(IComponent<T> _component)
        {
            component = _component;
        }

        public virtual T GetText()
        {
            return component.GetText();
        }
    }
}
