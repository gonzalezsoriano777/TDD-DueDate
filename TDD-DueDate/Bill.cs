using System;

namespace PaymentDateCheck
{
    public class Bill
    {

        public Bill(IHolidayService service)
        {
            
        }

        //bring in holiday service to check for holidays
        //use dependency injection
        public DateTime CheckDate (DateTime dueDate)
        {

            return dueDate;
        }
    }

}

