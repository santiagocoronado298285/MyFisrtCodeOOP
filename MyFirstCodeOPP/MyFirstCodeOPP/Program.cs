using System;

namespace MyFirstCodeOPP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dateobject = new Date(2023, 1, 30);


                //var fecha = new Date(2000,2,31);
                Console.WriteLine(dateobject.ToString());
                Console.WriteLine("Hello World!");


                Console.WriteLine("*----------------------------");
                Console.Write("Enter to ID\n\n");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter the Name\n");
                string name = Console.ReadLine();

                Console.Write("\nEnter the Lastname\n");
                string lastname = Console.ReadLine();

                Console.WriteLine("\nYou must enter the employee's date of birth, starting with year, month and day ");

                var year = Convert.ToInt32(Console.ReadLine());
                var month = Convert.ToInt32(Console.ReadLine());
                var day = Convert.ToInt32(Console.ReadLine());

                Date birth = new Date(year, month, day);


                Console.Write("\n Is the employee active?\n\n" + "true or false\n\n");
                bool isactive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("enter the number of hours worked by the employee");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the value of hours ");
                decimal valueH = Convert.ToDecimal(Console.ReadLine());

                //Employee salaryemployeed = new SalaryEmployeed()
                //{
                //    Id = id,
                //    Firstname = nombre,
                //    Lastname = apellido,
                //    BirthDate = new Date(2000, 5, 12),
                //    HirigDate = new Date(2019, 8, 12),
                //    IsActive = isactive,
                //    Salary = 2000000.34m

                //};
                //Console.WriteLine(salaryemployeed.ToString());



                //Console.WriteLine("----------------Commision Employeed-------------------");

                //CommissionEmployeed commissionEmployeed = new CommissionEmployeed();

                //commissionEmployeed.Id= id;
                //commissionEmployeed.Firstname = name;
                //commissionEmployeed.Lastname= lastname;
                //commissionEmployeed.BirthDate= birth;
                //commissionEmployeed.IsActive= isactive;
                //commissionEmployeed.CommissionPorcentage = (float)commissionE;
                //commissionEmployeed.Sales = SalesE;
                //Console.WriteLine(commissionEmployeed);


                Console.WriteLine("----------------Commision Employeed-------------------");

                ContratorEmployeed EmployyedContrator = new ContratorEmployeed();

                EmployyedContrator.Id = id;
                EmployyedContrator.Firstname = name;
                EmployyedContrator.Lastname = lastname;
                EmployyedContrator.BirthDate = birth;
                EmployyedContrator.IsActive = isactive;
                EmployyedContrator.Hours = hours;
                EmployyedContrator.ValueHour  = valueH;
                Console.WriteLine(EmployyedContrator);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
