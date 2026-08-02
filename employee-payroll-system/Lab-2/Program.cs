using System;

namespace EmployeePayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Employee Payroll System";

            Console.WriteLine("=====================================");
            Console.WriteLine("      EMPLOYEE PAYROLL SYSTEM");
            Console.WriteLine("=====================================\n");

            Console.WriteLine("Select Employee Type");
            Console.WriteLine("1. Part-Time Employee");
            Console.WriteLine("2. Full-Time Employee");
            Console.Write("Enter your choice: ");

            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.Write("Invalid choice! Enter 1 or 2: ");
            }

            Employee employee;

            if (choice == 1)
                employee = new PartTimeEmployee();
            else
                employee = new FullTimeEmployee();

            employee.AcceptDetails();
            employee.ShowDetails();

            IPayRoll payroll = employee as IPayRoll;

            if (payroll != null)
            {
                payroll.CalculateSalary();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    //===================== INTERFACE =====================

    interface IPayRoll
    {
        void CalculateSalary();
    }

    //===================== ABSTRACT CLASS =====================

    abstract class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public decimal BaseSalary { get; set; }

        public virtual void AcceptDetails()
        {
            Console.Write("\nEnter Employee ID: ");

            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Invalid ID! Enter again: ");
            }
            EmployeeID = id;

            Console.Write("Enter Employee Name: ");
            while (true)
            {
                EmployeeName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(EmployeeName))
                    break;

                Console.Write("Name cannot be empty! Enter again: ");
            }

            Console.Write("Enter Base Salary: ");

            decimal salary;
            while (!decimal.TryParse(Console.ReadLine(), out salary) || salary <= 0)
            {
                Console.Write("Invalid Salary! Enter again: ");
            }

            BaseSalary = salary;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("\n=====================================");
            Console.WriteLine("Employee Details");
            Console.WriteLine("=====================================");
            Console.WriteLine($"Employee ID   : {EmployeeID}");
            Console.WriteLine($"Employee Name : {EmployeeName}");
            Console.WriteLine($"Base Salary   : Rs. {BaseSalary:F2}");
        }
    }

    //===================== PART-TIME EMPLOYEE =====================

    class PartTimeEmployee : Employee, IPayRoll
    {
        public void CalculateSalary()
        {
            decimal netSalary = BaseSalary;

            Console.WriteLine("\n=====================================");
            Console.WriteLine("          SALARY SLIP");
            Console.WriteLine("=====================================");
            Console.WriteLine($"Employee Type : Part-Time");
            Console.WriteLine($"Employee ID   : {EmployeeID}");
            Console.WriteLine($"Employee Name : {EmployeeName}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Base Salary   : Rs. {BaseSalary:F2}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Net Salary    : Rs. {netSalary:F2}");
            Console.WriteLine("=====================================");
        }
    }

    //===================== FULL-TIME EMPLOYEE =====================

    class FullTimeEmployee : Employee, IPayRoll
    {
        public void CalculateSalary()
        {
            decimal da = BaseSalary * 0.20m;
            decimal medical = BaseSalary * 0.10m;
            decimal hra = BaseSalary * 0.15m;
            decimal pf = BaseSalary * 0.12m;

            decimal netSalary = BaseSalary + da + medical + hra - pf;

            Console.WriteLine("\n=====================================");
            Console.WriteLine("          SALARY SLIP");
            Console.WriteLine("=====================================");
            Console.WriteLine($"Employee Type : Full-Time");
            Console.WriteLine($"Employee ID   : {EmployeeID}");
            Console.WriteLine($"Employee Name : {EmployeeName}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Base Salary   : Rs. {BaseSalary:F2}");
            Console.WriteLine($"DA (20%)      : Rs. {da:F2}");
            Console.WriteLine($"Medical (10%) : Rs. {medical:F2}");
            Console.WriteLine($"HRA (15%)     : Rs. {hra:F2}");
            Console.WriteLine($"PF (12%)      : Rs. {pf:F2}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Net Salary    : Rs. {netSalary:F2}");
            Console.WriteLine("=====================================");
        }
    }
}