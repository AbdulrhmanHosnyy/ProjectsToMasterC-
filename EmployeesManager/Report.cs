using System;

namespace EmployeesManager
{
    public class Report
    {
        public delegate bool IllegibleSales(Employee e);
        public void ProcessEmployee(Employee[] employees, string title, IllegibleSales isIllegible)
        {
            Console.WriteLine(title);
            Console.WriteLine("---------------------------------------");
            foreach (var e in employees)
            {
                if(isIllegible(e))
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales}");
            }
            Console.WriteLine("\n\n");
        }
       
    }
}
