using System.Globalization;

namespace Exercicio_POO_11_Lista_01
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double porcent)
        {
            Salary += Salary * porcent / 100.0;
        }

        public override string ToString()
        {
            return "Id: " + Id +
                    ", " +
                   "Name: " + Name +
                   ", " +
                   "Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
