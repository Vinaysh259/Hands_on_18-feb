using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        public double Salary { get; set; }

    }

    class EmployeeDAL
    {
    

        ArrayList employees = new ArrayList();
        public bool AddEmployee(Employee e)
        {
            employees.Add(e);
            return true;
        }

        public bool DeleteEmployee(Employee e)
        {
            employees.Remove(e);
            return true;
        }

        public string SearchEmployee(Employee e)
        {
            if (employees.Contains(e))
                return "Employee found";
            else
                return "Employee Not found";

        }
        
        public Employee[] GetAllEmployeesistAll()
        {
            Employee[] employees = new Employee[3];
            foreach (var val in employees)
            {
                return employees;
            }
        }
        
    }

    class TestProgram
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            EmployeeDAL ed = new EmployeeDAL();
            //  for (int i = 1; i < 10; i++)
            //{
            e1.EmployeeName = "Vinay";
            e1.EmployeeID = 1;
            e1.Salary = 20000;

            if (ed.AddEmployee(e1))
                Console.WriteLine("Employee Created");

            e2.EmployeeName = "Reshma";
            e2.EmployeeID = 2;
            e2.Salary = 20000;
            if (ed.AddEmployee(e2))
                Console.WriteLine("Employee Created");

            e3.EmployeeName = "aeshma";
            e3.EmployeeID = 3;
            e3.Salary = 20000;
            if (ed.AddEmployee(e3))
                Console.WriteLine("Employee Created");
            //            }

            if (ed.DeleteEmployee(e2))
                Console.WriteLine("Employee Deleted");
            Console.WriteLine(ed.SearchEmployee(e1));
            Console.WriteLine(ed.GetAllEmployeesistAll());
            Console.ReadKey();
        }
    }
}