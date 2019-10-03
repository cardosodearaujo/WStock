using WStock.Framework.Bases;
using WStock.Framework.Resources;

namespace EveraldoCardoso.ITIX.Domain.Validations
{
    public class ValueValidation : BaseValidation<object>
    {
        public override void Validate(object objeto)
        {
            if (objeto == null)
            {
                Messages.Add(ReturnMessagesResources.MessageObjectNull);
            }
        }
    }
}
