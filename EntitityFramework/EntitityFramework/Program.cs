using EntitityFramework.Controllers;
using System;

namespace EntitityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeController emp1 = new EmployeeController();
            // emp1.GetEmployeeById(1);

            //foreach (var item in emp1.GetAllEmployees())
            //{
            //    Console.WriteLine(item.Fullname);
            //}

            //emp1.AddEmployee("Eliyev Samir");
            //emp1.DeleteEmployee(4);
            //emp1.FilterByName("i");
        }
    }
}
