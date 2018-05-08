using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IComparableT
{
    public class Example
    {
        class Employee : IComparable<Employee>
        {
            // properties
            public int Salary { get; set; }
            public string Name { get; set; }

            public int CompareTo(Employee other)
            {
                if (this.Salary == other.Salary)
                {
                    return this.Name.CompareTo(other.Name);
                }
                return other.Salary.CompareTo(this.Salary);
            }
        }

        class Program
        {
            public void Main()
            {
                List<Employee> list = new List<Employee>();
                list.Add(new Employee(){ Name = "Steve", Salary = 10000});
                list.Add(new Employee() { Name = "Janet", Salary = 10000 });
                list.Add(new Employee() { Name = "Andrew", Salary = 10000 });
                list.Add(new Employee() { Name = "Bill", Salary = 500000 });
                list.Add(new Employee() { Name = "Lucy", Salary = 8000 });

                // Uses Icomparable.CompareTo()
                list.Sort();

                // Uses Employee.ToString
                foreach (Employee employee in list)
                {
                    Console.WriteLine(employee);
                }
                //Output

                //500000,Bill
                //10000,Andrew
                //10000,Janet
                //10000,Steve
                //8000,Lucy
            }
        }
    }
}
