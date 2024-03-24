using Dapper;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Security.Policy;
using TipMexico.DigitalYard.Domain.Entity;
using TipMexico.DigitalYard.Infrastructure.Data;
using TipMexico.DigitalYard.Infrastructure.Interface;
using TipMexico.DigitalYard.Transversal.Common;
using static TipMexico.DigitalYard.Transversal.Common.Enums;

namespace TipMexico.DigitalYard.Infrastructure.Repository
{
    public class InspectionProcessRepository : IInspectionProcessRepository
    {
        private readonly IConnectionFactory ConnectionFactory;
        private readonly DigitalYardContext _context;

        public InspectionProcessRepository(IConnectionFactory connectionFactory,DigitalYardContext context)
        {
            ConnectionFactory = connectionFactory;
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<int> InspectionProcessStartAsync(int headerId, int userId)
        {
            using var con = ConnectionFactory.GetConnection;
            var query = "SELECT HEADER_ID, BRANCH_ID, INSPECTION_FOLIO  FROM YARD.XXDY_INS_HEADERS WHERE HEADER_ID = :headerId";
            var header = await con.QueryFirstOrDefaultAsync<InsHeaders>(query, new { headerId });

            // var p = new OracleDynamicParameters();
            // p.Add("HEADER_ID", headerId);
            // p.Add("USER_ID", userId);
            // p.Add("P_HEADER_ID", OracleDbType.RefCursor, ParameterDirection.Output);
            // p.Add("P_MENSAJE", string.Empty, OracleDbType.Varchar2, ParameterDirection.Output, 2000);
            // p.Add("P_RET_CODE", string.Empty, OracleDbType.Varchar2, ParameterDirection.Output, 2000);
            // var id = await con.QueryFirstOrDefaultAsync<int>(query, commandType: CommandType.StoredProcedure);
            // var getResult = p.Get<OracleString>("P_RET_CODE").Value;
            // var message = p.Get<OracleString>("P_MENSAJE").IsNull ? string.Empty : p.Get<OracleString>("P_MENSAJE").Value;

            // CREATE SEQUENCE header_id_auto
            // START WITH 1000
            // INCREMENT BY 1;
            // se usa header_id_auto.nextval, para obtener el siguiente valor de la secuencia.

            return header is null ? 0 :  header.HEADER_ID;
        }

        public async Task<decimal> InspectionProcessStartEntityAsync(int headerId, int userId, CancellationToken cancellationToken)
        {
            var header =  await _context.XxdyInsHeaders.FirstOrDefaultAsync(x => x.HeaderId == headerId, cancellationToken);
            return header is null ? 0 : header.HeaderId;
        }
         
    }
}
