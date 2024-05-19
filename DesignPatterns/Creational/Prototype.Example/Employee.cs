namespace Prototype.Example
{
    public class Employee : IEmployeePrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, string department, decimal salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public IEmployeePrototype Clone()
        {
            return (IEmployeePrototype)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Employee: {Id}, {Name}, {Department}, ${Salary}";
        }
    }
}
