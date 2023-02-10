using EmployeesManager;

class Program
{
    static void Main(string[] args)
    {
        var emps = new Employee[]
        {
            new Employee{Id = 1, Name = "Abdo H", Gender = "M", TotalSales = 65000},
            new Employee{Id = 2, Name = "Salama M", Gender = "F", TotalSales = 50000},
            new Employee{Id = 3, Name = "Sara H", Gender = "F", TotalSales = 65000},
            new Employee{Id = 4, Name = "Nada K", Gender = "F", TotalSales = 40000},
            new Employee{Id = 5, Name = "Youssef A", Gender = "M", TotalSales = 70000},
            new Employee{Id = 6, Name = "Omar H", Gender = "M", TotalSales = 55000},
            new Employee{Id = 7, Name = "Ali S", Gender = "M", TotalSales = 13000},
            new Employee{Id = 8, Name = "Reem J", Gender = "F", TotalSales = 7000},
        };
        var report = new Report();
        report.ProcessEmployee(emps, "Employees with sales greater than or equal $60,000", e => e.TotalSales >= 60000 );
        report.ProcessEmployee(emps, "Employees with sales between 30000 and 59999", e => e.TotalSales >= 30000 && e.TotalSales < 60000);
        report.ProcessEmployee(emps, "Employees with sales less than $30,000", e => e.TotalSales < 30000);
         
         
        Console.ReadKey();
    }
   

}