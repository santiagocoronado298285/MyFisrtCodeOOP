using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    internal class CommissionEmployeed : Employee
    {
        #region Properties

        public float CommissionPorcentage { get; set; }
        public decimal Sales { get; set; }
        #endregion


        #region methods
        public override decimal GetValuetTopay()
        {
            return (Sales* (decimal)ConvertParcentage(CommissionPorcentage))+Sales;
        }

        public override string ToString()
        {
            return $"{ base.ToString()} \n\t Commission Percentage ......."
                + $"{ConvertParcentage(CommissionPorcentage):p2}"+
                $"\n\t Sales .................... {Sales:c2}"+
                 $"\n\t Value to pay .................... {GetValuetTopay():c2}";
        }


        public float ConvertParcentage (float commissionparcentage)
        {
            return (commissionparcentage / 100);

        } 
        #endregion
    }
}
