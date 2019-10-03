using WStock.Framework.Models;

namespace WStock.Framework.Extensions
{
    public static class MessageErrosExtension
    {
        public static bool HasErrors(this Messages messages)
        {
            return messages != null && messages.Count() > 0 ? true : false;
        }
    }
}
