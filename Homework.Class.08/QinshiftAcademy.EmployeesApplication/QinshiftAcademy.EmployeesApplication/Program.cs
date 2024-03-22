using QinshiftAcademy.EmployeesApplication.Domain.Enums;
using QinshiftAcademy.EmployeesApplication.Domain.Models;

Employee employee = new Employee();

Employee secondEmployee = new Employee("Kate", "Katesky", 1000, EmployeeRole.Manager);
secondEmployee.PrintInfo();
Console.WriteLine("\nEmployee: " + secondEmployee);
double secondEmployeeSalary = secondEmployee.GetSalary();

Manager manager = new Manager("Paul", "Paulsky", 1000);
manager.AddBonus(200);
Console.WriteLine("\nManager: "+manager);
secondEmployee.PrintInfo();

double managerSalary = manager.GetSalary();
Console.WriteLine(managerSalary);


Contractor contractor = new Contractor(40,200);
Console.WriteLine("\ncontractor: " + contractor);
contractor.PrintInfo();


