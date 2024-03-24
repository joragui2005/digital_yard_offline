using Dapper;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace TipMexico.DigitalYard.Infrastructure.Repository
{
    public class OracleDynamicParameters : SqlMapper.IDynamicParameters
    {
        private readonly DynamicParameters dynamicParameters = new DynamicParameters();

        private readonly List<OracleParameter> oracleParameters = new List<OracleParameter>();

        private Dictionary<string, ParamInfo> parameters = new Dictionary<string, ParamInfo>();

        private class ParamInfo
        {

            public string Name { get; set; }

            public object Value { get; set; }

            public ParameterDirection ParameterDirection { get; set; }

            public OracleDbType? DbType { get; set; }

            public int? Size { get; set; }

            public IDbDataParameter AttachedParam { get; set; }
        }

        public void Add(string name, object value = null, DbType? dbType = null, ParameterDirection?
                                                                  direction = null, int? size = null)
        {
            dynamicParameters.Add(name, value, dbType, direction, size);
        }

        public void Add(string name, OracleDbType oracleDbType, ParameterDirection direction)
        {
            var oracleParameter = new OracleParameter(name, oracleDbType, direction);
            oracleParameters.Add(oracleParameter);
        }

        public void Add(string name, object value, OracleDbType oracleDbType, ParameterDirection direction, int size)
        {
            var oracleParameter = new OracleParameter(name, oracleDbType, size, value, direction);
            oracleParameters.Add(oracleParameter);
        }

        public void AddParameters(IDbCommand command, SqlMapper.Identity identity)
        {
            ((SqlMapper.IDynamicParameters)dynamicParameters).AddParameters(command, identity);

            var oracleCommand = command as OracleCommand;

            if (oracleCommand != null)
            {
                oracleCommand.Parameters.AddRange(oracleParameters.ToArray());
            }
        }

        public T Get<T>(string name)
        {
            object val = DBNull.Value;

            if (parameters.Any())
                val = parameters[Clean(name)].AttachedParam.Value;

            if (oracleParameters.Any())
                val = oracleParameters.FirstOrDefault(p => p.ParameterName == name).Value;

            if (val == DBNull.Value)
            {
                if (default(T) != null)
                {
                    throw new ApplicationException("Attempting to cast a DBNull to a non nullable type!");
                }
                return default(T);
            }
            return (T)val;
        }

        private static string Clean(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                switch (name[0])
                {
                    case '@':
                    case ':':
                    case '?':
                        return name.Substring(1);
                }
            }
            return name;
        }
    }
}
