using System;

namespace PaymentDateCheck
{
    public class Bill
    {

        public Bill(HolidayService service)
        {
            
        }

        public Bill(DateTime dueDate)
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

