using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.EmployeesApplication.Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }

        public Contractor() { }
        public Contractor(double workHours, int payPerHour)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
        }

        public override double GetSalary()
        {
         
            Salary = WorkHours * PayPerHour;

            return Salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Salary}");
        }
    }
}
