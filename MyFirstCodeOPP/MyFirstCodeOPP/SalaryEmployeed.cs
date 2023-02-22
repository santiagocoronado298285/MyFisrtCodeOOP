using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public class SalaryEmployeed : Employee
    {

        #region properties
        public decimal Salary { get; set; }

        #endregion


        #region metodos
        public override decimal GetValuetTopay()
        {
            return Salary;
        }

        #endregion

    }
}
