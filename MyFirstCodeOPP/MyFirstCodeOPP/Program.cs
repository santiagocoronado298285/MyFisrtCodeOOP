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
                Console.Write("ingresa el ID\n\n");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("ingresa el nombre\n");
                string nombre = Console.ReadLine();

                Employee salaryemployeed = new SalaryEmployeed()
                {
                    Id= id,
                    Firstname= nombre,
                    Lastname = "Coronado",
                    BirthDate = new Date(2000, 5, 12),
                    HirigDate = new Date(2019,8,12),
                    IsActive= true,
                    Salary = 2000000.34m

                };
                Console.WriteLine(salaryemployeed.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
