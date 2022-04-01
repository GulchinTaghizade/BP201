using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int SalaryLimit { get; set; }

        Employee[] array = new Employee[] { };
        public void AddEmployee(Employee employer)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length - 1] = employer;
            Console.WriteLine(employer.Name);
        }
    }
}
