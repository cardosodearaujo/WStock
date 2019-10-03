using WStock.Framework.Interfaces;
using WStock.Framework.Models;
using WStock.Framework.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace WStock.Framework.Specifications
{
    public class DateValidSpecification : ISpecification<DateTime>
    {
        public bool IsSatisfiedBy(DateTime objeto)
        {
            if (DateTime.Parse(objeto.ToString()) == null)
            {
                return false;
            }
            else if (DateTime.Parse(objeto.ToString()) == DateTime.MinValue)
            {
                return false;   
            }
            else if ((DateTime.Parse(objeto.ToString()) == DateTime.MaxValue))
            {
                return false;
            }
            return true;
        }
    }
}
