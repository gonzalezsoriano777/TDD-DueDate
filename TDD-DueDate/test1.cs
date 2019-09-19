using System;
using NUnit.Framework;
using PaymentDateCheck;

namespace BillOne
{
    public class TestOne
    {
        [Test]
        public void IfSaturdayReturnMonday()
        {
            DateTime billDate = new DateTime(2019, 9, 21);
            DateTime expectedDueDate = new DateTime(2019, 9, 23);

            if(billDate.DayOfWeek == DayOfWeek.Saturday)
            {
                DateTime monday = billDate.AddDays(2);
                billDate = monday;
            }

            Assert.AreEqual(billDate, expectedDueDate);

        }
    }
}


