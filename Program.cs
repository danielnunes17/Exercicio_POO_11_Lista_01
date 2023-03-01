using Exercicio_POO_11_Lista_01;
using System.Globalization;

Console.Write("How many employees will be registered? ");
int employeesN = int.Parse(Console.ReadLine());

List<Employee> list = new List<Employee>();

for (int i = 1; i <= employeesN; i++)
{
    Console.WriteLine("Emplyoee #" + i + ":");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    list.Add(new Employee(id, name, salary));
    Console.WriteLine();
}
Console.Write("Enter the employee id that will have salary increase: ");
int searchId = int.Parse(Console.ReadLine());

Employee employee = list.Find(x => x.Id == searchId);
if (employee != null)
{
    Console.Write("Enter the percentage: ");
    double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    employee.IncreaseSalary(percent);
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach (Employee obj in list)
    Console.WriteLine(obj);


