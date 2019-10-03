using WStock.Framework.Models;

namespace WStock.Framework.Bases
{
    public class BaseService
    {
        public Messages Messages { get; set; }

        public BaseService()
        {
            this.Messages = new Messages();
        }        
    }
}
