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

        public bool DeleteEmployee(int id)
        {
            employees.RemoveAt(id);
            return true;
        }

        public string SearchEmployee(int id)
        {
            if (employees.Contains(id))
                return "Employee found";
            else
                return "Employee Not found";
            
        }
        /*
        public Employee[] GetAllEmployeesistAll()
        {
           
        }
        */
    }

    class TestProgram
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            EmployeeDAL ed = new EmployeeDAL();
          //  for (int i = 1; i < 10; i++)
            //{
                e.EmployeeName = "Vinay";
                e.EmployeeID = 1;
                e.Salary = 20000;

            if (ed.AddEmployee(e))
                Console.WriteLine("Employee Created");

            e.EmployeeName = "Reshma";
            e.EmployeeID = 2;
            e.Salary = 20000;
            if (ed.AddEmployee(e))
                Console.WriteLine("Employee Created");
            e.EmployeeName = "aeshma";
            e.EmployeeID = 3;
            e.Salary = 20000;
            if (ed.AddEmployee(e))
                Console.WriteLine("Employee Created");
            //            }
            
            if (ed.DeleteEmployee((1)))
                Console.WriteLine("Employee Deleted");
            Console.WriteLine(ed.SearchEmployee());
            Console.ReadKey();
        }
    }
}