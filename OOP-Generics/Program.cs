using System.Collections;

namespace OOP_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiating 5 employees
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
            //creating stack with the 5 objects
            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            //prints all object in stack
            foreach (Employee employee in employeeStack)
            {
                Console.WriteLine($"Id: {employee.Id}\r\nName: {employee.Name}\r\nGender: {employee.Gender}\r\nSalary: {employee.Salary}");
                Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            }
            //takes out each object from stack
            Console.WriteLine("\r\nPop method\r\n");
            while (employeeStack.Count > 0)
            {
                Employee employee = employeeStack.Pop();
                Console.WriteLine($"Id: {employee.Id}\r\nName: {employee.Name}\r\nGender: {employee.Gender}\r\nSalary: {employee.Salary}");
                Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            }

            //adds objects to stack again
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            //peeks at last/top object in stack
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
            // checks if object is in stack
            if (employeeStack.Contains(employee3))
            {
                Console.WriteLine("employee3 is in stack");
            }
            else
            {
                Console.WriteLine("employee3 is not in stack");
            }

            //Part 2

            //contains
            List<Employee> employeeList = new List<Employee>
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
            };
            if (employeeList.Contains(employee4))
            {
                Console.WriteLine("employee4 object exists in the list");
            }
            else
            {
                Console.WriteLine("employee4 object does not exist in the list");
            }

            //find
            Employee maleEmployee = employeeList.Find(maleEmployee => maleEmployee.Gender == "Male");
            Console.WriteLine($"Id: {maleEmployee.Id}\r\nName: {maleEmployee.Name}\r\nGender: {maleEmployee.Gender}\r\nSalary: {maleEmployee.Salary}");
            Console.WriteLine();

            //findall
            List<Employee> maleEmployees = employeeList.FindAll(maleEmployees => maleEmployees.Gender == "Male");
            foreach (Employee employee in maleEmployees) 
            {
                Console.WriteLine($"Id: {employee.Id}\r\nName: {employee.Name}\r\nGender: {employee.Gender}\r\nSalary: {employee.Salary}");
            }

        }
    }
}