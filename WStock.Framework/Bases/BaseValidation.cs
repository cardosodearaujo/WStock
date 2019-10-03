using WStock.Framework.Models;
using WStock.Framework.Resources;

namespace WStock.Framework.Bases
{
    public abstract class BaseValidation<T>
    {
        public Messages Messages { get; set; }

        public BaseValidation()
        {
            Messages = new Messages();
        }

        protected void AddMessage(string code, string title, string description)
        {
            Messages.Add(code, title, description);
        }

        protected void AddMessage(string description)
        {
            Messages.Add(description);
        }

        protected void AddError(string description)
        {
            Messages.Add(ReturnStatusResources.CodeMessageError, ReturnMessagesResources.MessageError, description);
        }

        protected void AddAlert(string description)
        {
            Messages.Add(ReturnStatusResources.CodeMessageAlert, ReturnMessagesResources.MessageAlert, description);
        }

        protected void AddSucess(string description)
        {
            Messages.Add(ReturnStatusResources.CodeMessageSucess, ReturnMessagesResources.MessageSucess, description);
        }

        public abstract void Validate(T objeto);
    }
}
