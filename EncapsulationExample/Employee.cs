using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExample
{
    class Employee
    {
        private int salary;
        private string name;
        private int workingHours;
        private int perhourSalary = 100;

        public string GetName()
        {
            return name;
        }
        public void SetName(string Name)
        {
            name = Name;
        }
        public int GetHours()
        {
            return workingHours;
        }
        public void SetHours(int WorkingHours)
        {
            workingHours = WorkingHours;
        }
        public int CalculateSalary()
        {
            return workingHours * perhourSalary;
        }
    }
}
