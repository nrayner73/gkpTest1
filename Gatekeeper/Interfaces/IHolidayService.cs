using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IHolidayService
    {
        Task<IEnumerable<Holiday>> GetHolidayList(int year);
        Task<IEnumerable<Holiday>> CopyLastYearHoliday(string regno);
        Task<Holiday> GetHolidayById(int id);
        Task<Holiday> CreateHoliday(Holiday holiday);
        Task UpdateHoliday(Holiday holiday);
        Task DeleteHoliday(Holiday holiday);
    }
}
