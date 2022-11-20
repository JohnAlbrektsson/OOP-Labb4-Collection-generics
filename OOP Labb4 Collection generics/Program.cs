using System;
using System.Collections.Generic;

namespace OOP_Labb4_Collection_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee(101, "John", "Male", 23000);

            Employee E2 = new Employee(102, "Hanna", "Female", 21000);

            Employee E3 = new Employee(103, "Ove", "Male", 29000);

            Employee E4 = new Employee(104, "Sven", "Male", 27000);

            Employee E5 = new Employee(105, "Anette", "Female", 35000);

            #region Stack
            Stack<Employee> empstack = new Stack<Employee>();

            empstack.Push(E1);
            empstack.Push(E2);
            empstack.Push(E3);
            empstack.Push(E4);
            empstack.Push(E5);

            foreach(Employee item in empstack)
            {
                Console.WriteLine("ID = {0}\n Namn = {1}\n Gender = {2}\n Salary = {3}", item.ID, item.Name, item.Gender,item.Salary);
                Console.WriteLine($"Objects in stack: {empstack.Count}");
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Pop");
            while (empstack.Count > 0)
            {
               
                Employee e = empstack.Pop();
                Console.WriteLine($" {e.ID}, {e.Name}, {e.Gender}, {e.Salary}");
                
                Console.WriteLine($"Left in stack: {empstack.Count}");
            }
            empstack.Push(E1);
            empstack.Push(E2);
            empstack.Push(E3);
            empstack.Push(E4);
            empstack.Push(E5);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Peek");
            for (int i = 2; i >0; i--)
            {
                Employee e = empstack.Peek();
                Console.WriteLine($"{e.ID}, {e.Name}, {e.Gender}, {e.Salary}");
                Console.WriteLine($"Items left in stack: {empstack.Count}");

            }
            if(empstack.Contains(E3))
            {
                Console.WriteLine("item number 3 is in the stack");
            }
            else Console.WriteLine("item number 3 is not in the stack");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("List");
            #endregion
            #region List
            List<Employee> emplist = new List<Employee>();
            emplist.Add(E1);
            emplist.Add(E2);
            emplist.Add(E3);
            emplist.Add(E4);
            emplist.Add(E5);
            if (emplist.Contains(E2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else Console.WriteLine("Employee2 object does not exist in the list");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("First male employee = {0}, ID: {1}",emplist.Find(e => e.Gender == "Male").Name, emplist.Find(e => e.Gender == "Male").ID);

            Console.WriteLine("----------------------------------");
            foreach(Employee item in emplist.FindAll(item => item.Gender == "Male"))
            {
                Console.WriteLine($"Name: {item.Name}, ID: {item.ID}, Salary: {item.Salary}");
            }
            #endregion
        }
    }
}
