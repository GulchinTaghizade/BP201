using EntitityFramework.Dataaccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitityFramework.Controllers
{
    class EmployeeController
    {
        private readonly AppDBContext _context;

        public EmployeeController()
        {
            _context = new AppDBContext();
        }

        public void GetEmployeeById(int id)
        {
            Employee employee = _context.Employees.Find(id);
            Console.WriteLine(employee.Fullname); 
            
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();


        }

        public void AddEmployee(string fullname)
        {
            Employee emp1 = new Employee {Fullname=fullname};
            _context.Employees.Add(emp1);
            _context.SaveChanges();
            Console.WriteLine($"{fullname} was added to Employees table");
        }

        public void DeleteEmployee(int id)
        {
            Employee emp1 = _context.Employees.Find(id);
            _context.Employees.Remove(emp1);
            _context.SaveChanges();
            Console.WriteLine($"{id}th data was deleted");
        }

        public void FilterByName(string search)
        {
            List<Employee> emplist = _context.Employees.ToList();

            foreach (var item in emplist)
            {
                if (item.Fullname.Contains(search))
                {
                    Console.WriteLine(item.Fullname);
                }  
            }

            
        }
    }

   

}
