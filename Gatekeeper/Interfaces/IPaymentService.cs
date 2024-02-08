using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IPaymentService
    {
        Task<IEnumerable<Payment>> GetPaymentList(int fileid);
        Task<Payment> GetPaymentById(int id);
        Task<Payment> CreatePayment(Payment payment);
        Task UpdatePayment(Payment payment);
        Task DeletePayment(Payment payment);
    }
}
