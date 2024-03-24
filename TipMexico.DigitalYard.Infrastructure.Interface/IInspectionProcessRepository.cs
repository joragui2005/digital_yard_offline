namespace TipMexico.DigitalYard.Infrastructure.Interface
{
    public interface IInspectionProcessRepository
    {
        Task<int> InspectionProcessStartAsync(int headerId, int userId);
        Task<decimal> InspectionProcessStartEntityAsync(int headerId, int userId, CancellationToken cancellationToken);
    }
}
