using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTask1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started..");
            Method1();
            Console.WriteLine("Main Method Ended");
            Console.ReadKey();
        }
        public async static void Method1()
        {
            Employee emp =await getEmpDetails();
            await Task.Delay(5000);
            Console.WriteLine($"Id :{emp.Id},Name: {emp.Name},Salary: {emp.Salary}");
        }
        public static async Task<Employee> getEmpDetails()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Manideep",
                Salary = 100000
            };
            return emp;
        }
    }
}
