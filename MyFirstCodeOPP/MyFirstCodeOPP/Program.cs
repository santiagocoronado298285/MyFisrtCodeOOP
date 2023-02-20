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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
