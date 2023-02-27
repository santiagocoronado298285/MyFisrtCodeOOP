using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public class BaseCommission : CommissionEmployeed
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion


        #region methods

        public override decimal GetValuetTopay()
        {
            return ((Sales * (decimal)ConvertParcentage(CommissionPorcentage)) + Base);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                 $"Salary Base{Base:c2}" +
                $"\n\t Commission .................... {ConvertParcentage(CommissionPorcentage):c2}" +
                 $"\n\t Value to pay .................... {GetValuetTopay():c2}"; ;
        }
        #endregion 
    }
}
