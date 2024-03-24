using System.Data;

namespace TipMexico.DigitalYard.Transversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
