using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IHolidayService
    {
        Task<IEnumerable<Holiday>> GetHolidayList();
        Task<Holiday> GetHolidayById(int id);
        Task<Holiday> CreateHoliday(Holiday holiday);
        Task UpdateHoliday(Holiday holiday);
        Task DeleteHoliday(Holiday holiday);
    }
}
