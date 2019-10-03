using NHibernate;
using NHibernate.Cfg;

namespace WStock.Framework.NHibernate
{
    public class NHibernateGetSession
    {
        public NHibernateGetSession()
        {
        }

        public static ISession Session()
        {
            lock (typeof(NHibernateGetSession))
            {
                var cfg = new Configuration()
                    .SetProperty("dialect", NHibernateConfigurationData.Dialect)
                    .SetProperty("connection.driver_class", NHibernateConfigurationData.Driver)
                    .SetProperty("connection.provider", NHibernateConfigurationData.Provider)                             
                    .SetProperty("connection.connection_string", NHibernateConfigurationData.Connection.getConnectionMySql())
                    .AddAssembly(NHibernateConfigurationData.Assembly);
                var session = cfg.BuildSessionFactory();
                return session.OpenSession();
            }
        }
    }
}
