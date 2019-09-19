using System;
using NUnit.Framework;
using PaymentDateCheck;

namespace BillOne
{
    public class TestTwo
    {
        [Test]
        public void IfSundayReturnMonday()
        {
            DateTime billDate = new DateTime(2019, 9, 22);
            DateTime expectedDueDate = new DateTime(2019, 9, 23);

            if (billDate.DayOfWeek == DayOfWeek.Sunday)
            {
                DateTime monday = billDate.AddDays(1);
                billDate = monday;
            }

            Assert.AreEqual(billDate, expectedDueDate);
        }
    }
}

