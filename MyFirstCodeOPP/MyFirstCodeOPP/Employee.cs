using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOPP
{
    public abstract class Employee
    {
        #region properties
        public int Id { get; set; }
        public Date BirthDay { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Date HirihgDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region
        public Employee(){}

        public abstract decimal GetValuetTopay();
        public override string ToString()
        {
            return $"----Employee---- \n\t ID:{Id} \n\t Firsthname : {Firstname}  \n\t LastName : {Lastname}"+
                $"\n\t HiringDate : {HirihgDate}";
        }
        #endregion



    }
}
