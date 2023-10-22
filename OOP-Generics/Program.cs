using System.Collections;

namespace OOP_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                Id = 1,
                Name = "Adam",
                Gender = "Male",
                Salary = 52000,
            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                Name = "Bella",
                Gender = "Female",
                Salary = 51000,
            };
            Employee employee3 = new Employee()
            {
                Id = 3,
                Name = "Curtis",
                Gender = "Male",
                Salary = 50000,
            };
            Employee employee4 = new Employee()
            {
                Id = 4,
                Name = "Dina",
                Gender = "Female",
                Salary = 48000,
            };
            Employee employee5 = new Employee()
            {
                Id = 5,
                Name = "Ed",
                Gender = "Male",
                Salary = 40000,
            };

            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            foreach (Employee employee in employeeStack)
            {
                Console.WriteLine($"Id: {employee.Id}\r\nName: {employee.Name}\r\nGender: {employee.Gender}\r\nSalary: {employee.Salary}");
                Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            }

            Console.WriteLine("\r\nPop method\r\n");
            while (employeeStack.Count > 0)
            {
               Employee employee = employeeStack.Pop();
               Console.WriteLine($"Id: {employee.Id}\r\nName: {employee.Name}\r\nGender: {employee.Gender}\r\nSalary: {employee.Salary}");
            }

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("\r\nPeek method\r\n");
            {
                Employee employee = employeeStack.Peek();
                Console.WriteLine($"Id: {employee.Id}\r\nName: {employee.Name}\r\nGender: {employee.Gender}\r\nSalary: {employee.Salary}");
                Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            }
            {
                Employee employee = employeeStack.Peek();
                Console.WriteLine($"Id: {employee.Id}\r\nName: {employee.Name}\r\nGender: {employee.Gender}\r\nSalary: {employee.Salary}");
                Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            }
            Console.WriteLine();
            if (employeeStack.Contains(employee3))
            {
                Console.WriteLine("employee3 is in stack");
            }
            else
            {
                Console.WriteLine("employee3 is not in stack");
            }
        }
    }
}