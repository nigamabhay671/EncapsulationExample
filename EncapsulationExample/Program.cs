using System;

namespace EncapsulationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetName("Abhay");
            emp.SetHours(8);

            Console.WriteLine("The Salary For:-" + emp.GetName() + "=" + emp.CalculateSalary());
        }
    }
}
