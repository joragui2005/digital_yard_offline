namespace TipMexico.DigitalYard.Infrastructure.Interface
{
    public interface IInspectionProcessRepository
    {
        Task<int> InspectionProcessStartAsync(int headerId, int userId);
    }
}
