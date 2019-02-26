using System;


namespace ConsoleApp5
{
    class Employee
    {
        private string EmployeeName;
        private double BasicSalary;
        private double HRA;
        private double DA;
        private double TAX;
        private double GrossSalary;
        private double NetSalary;

        public Employee(string E_name,double B_salary)
        {
            EmployeeName = E_name;
            BasicSalary = B_salary;
        }

        public void CalculateNetPay()
        {
            HRA = 0.15 * BasicSalary;
            DA = 0.1 * BasicSalary;
            GrossSalary = BasicSalary + HRA + DA;
            TAX = 0.08 * GrossSalary;
            NetSalary = GrossSalary - TAX;
        }

        public void Display()
        {
            Console.WriteLine("Employee Name:{0}\n Basic Salary :{1} \n HRA :{2} \n DA :{3} \n Gross Salary :{4} \n Tax : {5} \n Net Salary :{6}", EmployeeName, BasicSalary, HRA, DA, GrossSalary, TAX, NetSalary);
        }
        static void Main(string[] args)
        {
            string Emp_Name;
            double Base_Salary;
            Console.WriteLine("Give the details of Employee :");
            Console.WriteLine("Employee Name : ");
            Emp_Name = Console.ReadLine();
            Console.WriteLine("Basic Salary: ");
            Base_Salary = double.Parse(Console.ReadLine());
            Employee e1 = new Employee(Emp_Name, Base_Salary);
            e1.CalculateNetPay();
            e1.Display();
            Console.ReadKey();
        }
    }
}
