using WStock.Framework.Bases;
using WStock.Framework.Resources;
using WStock.Framework.Specifications;
using System;

namespace WStock.Framework.Validations
{
    public class ObjectValidation : BaseValidation<Object>
    {
        public override void Validate(object objeto)
        {
            if (new ObjectNullSpecification().IsSatisfiedBy(objeto))
            {
                Messages.Add(ReturnMessagesResources.MessageObjectNull);
            }
            else if (typeof(String) == objeto.GetType())
            {
                if (String.IsNullOrEmpty(objeto.ToString()))
                {
                    Messages.Add(ReturnMessagesResources.MessageIdEmpty);
                }
            }
            else if (typeof(Int32) == objeto.GetType())
            {
                if (Int32.Parse(objeto.ToString()) <= 0)
                {
                    Messages.Add(ReturnMessagesResources.MessageIdMinorOrZero);
                }
            }
            else if (typeof(Int64) == objeto.GetType())
            {
                if (Int64.Parse(objeto.ToString()) <= 0)
                {
                    Messages.Add(ReturnMessagesResources.MessageIdMinorOrZero);
                }
            }
            else if (typeof(DateTime) == objeto.GetType())
            {
                if (!new DateValidSpecification().IsSatisfiedBy(DateTime.Parse(objeto.ToString())))
                {
                    Messages.Add(ReturnMessagesResources.MessageDateInvalid);
                }                
            }
        }
    }
}
