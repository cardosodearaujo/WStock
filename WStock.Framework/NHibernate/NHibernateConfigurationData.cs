using WStock.Framework.Models;

namespace WStock.Framework.NHibernate
{
    public static class NHibernateConfigurationData
    {
        public static string Dialect { get; set; }
        public static string Driver { get; set; }
        public static string Provider { get; set; }             
        public static ConnectionData Connection { get; set; }
        public static string Assembly { get; set; }
    }
}
    