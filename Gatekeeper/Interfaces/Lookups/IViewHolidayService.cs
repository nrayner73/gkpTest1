using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface IViewHolidayService
    {
        List<HolidayView> GetHolidayList(string year);
    }
}
