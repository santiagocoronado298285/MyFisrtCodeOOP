using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public class ContratorEmployeed : Employee
    {

        #region properties

        public int Hours { get; set; }
        public decimal ValueHour { get; set; }

        #endregion
        public override decimal GetValuetTopay()
        {
            return (Hours* ValueHour);
        }

        public override string ToString()
        {
            return $"{base.ToString()}"+
                 $"Number of hours{Hours}" +
                $"\n\t value of hours .................... {ValueHour:c2}" +
                 $"\n\t Value to pay .................... {GetValuetTopay():c2}"; ;
        }
    }
}
