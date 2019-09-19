using System;
using NUnit.Framework;
using PaymentDateCheck;

namespace BillOne
{
    public class TestFour
    {
        [Test]
        public void IfHolidayReturnWeekday()
        {
            var holiday = new HolidayService<IHolidayService>();
            DateTime holidate = new DateTime(2018, 12, 25);
            var check = holiday.isHoliday(holidate);
            bool weekday = false;
            
            if(check == true)
            {
                DateTime nextDay = holidate.AddDays(1);

                if (holidate.DayOfWeek != DayOfWeek.Saturday || holidate.DayOfWeek != DayOfWeek.Sunday)
                {
                    weekday = true;
                }
                else
                {
                    holidate.AddDays(1);
                }
            }

            Assert.AreEqual(check, weekday);
                
        }
    }
}


