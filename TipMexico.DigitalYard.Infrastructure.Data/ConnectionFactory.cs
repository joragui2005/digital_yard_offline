using Microsoft.Extensions.Configuration;
using System.Data;
using TipMexico.DigitalYard.Transversal.Common;
using Oracle.ManagedDataAccess.Client;

namespace TipMexico.DigitalYard.Infrastructure.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string ConnectionString;
        private readonly IConfiguration Configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = Configuration.GetConnectionString("DefaultConnection") ?? "";
        }

        public IDbConnection GetConnection
        {
            get
            {
                var connection = new OracleConnection(ConnectionString);
                if (connection == null)
                    return null;

                connection.ConnectionString = ConnectionString;
                connection.Open();

                return connection;
            }
        }
    }
}
