using WStock.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace WStock.Framework.Specifications
{
    public class ObjectNullSpecification : ISpecification<object>
    {
        public bool IsSatisfiedBy(object objeto)
        {
            return (objeto == null ? true : false);            
        }
    }
}
