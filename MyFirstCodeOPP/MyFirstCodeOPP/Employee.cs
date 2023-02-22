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
        public Date HirigDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region
        public Employee(){}

        public abstract decimal GetValuetTopay();
        public override string ToString()
        {
            return String.Format("----Employee---- \n\t ID:{0} \n\t Firsthname : {1} \n\t BirthDay : {4}  \n\t LastName : {2}" + "\n\t HiringDate : {3}" + "\n\t isActive : {5}",
                Id,
                Firstname,
                Lastname,
                HirigDate,
                BirthDay,
                IsActive);

            //return $"----Employee---- \n\t ID:{Id} \n\t Firsthname : {Firstname}  \n\t LastName : {Lastname}"+
            //    $"\n\t HiringDate : {HirigDate}" +
            //    $"\n\t isActive : {IsActive}";
        }
        #endregion



    }
}
