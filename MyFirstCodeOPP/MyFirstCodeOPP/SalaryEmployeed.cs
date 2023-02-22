using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public class SalaryEmployeed : Employee
    {

        #region
        public decimal Salary { get; set; }
        #endregion



        public override decimal GetValuetTopay()
        {
            throw new NotImplementedException();
        }
    }
}
