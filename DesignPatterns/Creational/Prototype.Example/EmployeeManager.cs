﻿namespace Prototype.Example
{
    public static class EmployeeManager
    {
        private static Dictionary<string, IEmployeePrototype> _prototypes = new Dictionary<string, IEmployeePrototype>();

        public static void AddPrototype(Employee employee)
        {
            _prototypes.Add(employee.Department, employee);
        }

        public static Employee GetPrototype(string department)
        {
            return _prototypes[department].Clone() as Employee;
        }
    }
}
