using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2010
{
    class Employee
    {
        public string Name { get; set; }
        int age;
        public bool Workable { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 14 & value < 99)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст должен быть в диапазоне от 14 до 99");
                }
            }
        }
        public int Salary { get; set; }


        public Employee(string name, int age, int salary)
        {
            this.Name = name;
            if (age > 14 & age < 99)
            {
                this.age = age;
                Workable = true;
            }
            else
            {
                Console.WriteLine("    (Возраст продавца должен быть в диапазоне от 14 до 99)");
                this.age = 0;
                Workable = false;
            }
            this.Salary = salary;
        }
        public void PrintEmployeeData()
        {
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст {age}");
            Console.WriteLine($"Зарплата {Salary}");
        }
    }
}
