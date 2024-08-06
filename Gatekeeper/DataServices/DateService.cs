using Gatekeeper.Interfaces;
using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Gatekeeper.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Gatekeeper.DataServices
{
    public class DateService : IDateService
    {
        private string? oDuedate = string.Empty;
        
        public async System.Threading.Tasks.Task SetDuedate(Requestfile requestfile, List<Extension> extensions, List<Holiday>? holidays)
        {
            List<DateTime> dateRange1 = new List<DateTime>();
            List<DateTime> dateRange2 = new List<DateTime>();

            DateTime dueDate = (DateTime)requestfile.Receivedate;
            DateTime setDate;

            // add extensions            
            int extDays = 0;
            foreach (var item in extensions)
            {
                if (item.Dayamount != null && item.Dayamount != 0)
                {
                    extDays = (int)(extDays + item.Dayamount);
                }
            }

            oDuedate = ((DateTime)requestfile.Receivedate).AddDays(30).ToString();
            dueDate = ((DateTime)requestfile.Receivedate).AddDays(30 + extDays);

            // remove weekends
            for (int i = 0; i < 11; i++)
            {
                setDate = dueDate.AddDays(i);
                if (setDate.DayOfWeek != 0 && (int)setDate.DayOfWeek != 6)
                {
                    dateRange1.Add(setDate);
                    dateRange2.Add(setDate);
                }
            }

            // remove holidays
            var thisYearHolidays = holidays.Where(x => ((DateTime)x.Holidaydate).Year == ((DateTime)requestfile.Receivedate).Year);

            foreach (var item in thisYearHolidays)
            {
                foreach (var dt in dateRange1)
                {
                    int y = dateRange1.IndexOf(dt);
                    if (dt.Date.ToString() == ((DateTime)item.Holidaydate).Date.ToString())
                    {
                        dateRange2.RemoveAt(y);
                    }
                }

            }
            requestfile.Requestduedate = dateRange2.FirstOrDefault();
        }


        public async System.Threading.Tasks.Task SetDuedate(AccessRequestForm accessRequestForm, List<Extension> extensions, List<Holiday>? holidays)
        {
            List<DateTime> dateRange1 = new List<DateTime>();
            List<DateTime> dateRange2 = new List<DateTime>();

            DateTime dueDate = (DateTime)accessRequestForm.Receivedate;
            DateTime setDate;

            // add extensions            
            int extDays = 0;
            foreach (var item in extensions)
            {
                if (item.Dayamount != null && item.Dayamount != 0)
                {
                    extDays = (int)(extDays + item.Dayamount);
                }
            }

            oDuedate = ((DateTime)accessRequestForm.Receivedate).AddDays(30).ToString();
            dueDate = ((DateTime)accessRequestForm.Receivedate).AddDays(30 + extDays);

            // remove weekends
            for (int i = 0; i < 11; i++)
            {
                setDate = dueDate.AddDays(i);
                if (setDate.DayOfWeek != 0 && (int)setDate.DayOfWeek != 6)
                {
                    dateRange1.Add(setDate);
                    dateRange2.Add(setDate);
                }
            }

            // remove holidays
            var thisYearHolidays = holidays.Where(x => ((DateTime)x.Holidaydate).Year == ((DateTime)accessRequestForm.Receivedate).Year);

            foreach (var item in thisYearHolidays)
            {
                foreach (var dt in dateRange1)
                {
                    int y = dateRange1.IndexOf(dt);
                    if (dt.Date.ToString() == ((DateTime)item.Holidaydate).Date.ToString())
                    {
                        dateRange2.RemoveAt(y);
                    }
                }

            }
            accessRequestForm.Requestduedate = dateRange2.FirstOrDefault();
        }
    }


}

