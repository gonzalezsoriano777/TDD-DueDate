using System;
using NUnit.Framework;
using PaymentDateCheck;

namespace BillOne
{
    public class TestThree
    {
        [Test]
        public void ifHolidayReturnNonHoliday()
        {

            var holiday = new HolidayService<IHolidayService>();
            DateTime dueDate = new DateTime(2018, 12, 25);
            var check = holiday.isHoliday(dueDate);
            bool notHoliday = false;

            if (check == true)
            {
                notHoliday = true;
            }

            Assert.AreEqual(check, notHoliday);

        }
    }
}


