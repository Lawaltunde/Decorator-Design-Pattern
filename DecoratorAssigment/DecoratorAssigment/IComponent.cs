using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorAssigment
{
    public interface IComponent<T>
    {
        protected T textToGet { get; set; }
        T GetText()
        {
            return textToGet;
        }
    }
}
