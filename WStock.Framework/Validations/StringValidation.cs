using WStock.Framework.Models;
using WStock.Framework.Bases;
using WStock.Framework.Resources;
using System;

namespace EveraldoCardoso.ITIX.Domain.Validations
{
    public class StringValidation : BaseValidation<String>
    {
        public override void Validate(string objeto)
        {
            if (objeto == null)
            {
                Messages.Add(ReturnMessagesResources.MessageObjectNull);
            }
            else if (String.IsNullOrEmpty(objeto))
            {
                Messages.Add(ReturnMessagesResources.MessageObjectEmpty);
            }
        }
    }
}
