using System;

namespace Logic_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Mark", 4, 400);
            Employee e2 = new Employee("Jhon", 6, 500);
            Employee e3 = new Employee("Dan", 25, 3000);
            Employee e4 = new Employee("Phil", 11, 2000);
            Employee e5 = new Employee("Bob", 15, 1800);
            Employee e6 = new Employee("Rob", 20, 2500);

            Employee[] emp = new Employee[6];
            emp[0] = e1;
            emp[1] = e2;
            emp[2] = e3;
            emp[3] = e4;
            emp[4] = e5;
            emp[5] = e6;

            foreach (Employee e in emp)
            {
                Console.Write(e.ToString());
                Console.Write("Bonus: " + CalcBonus(e) + "\n");
            }
        }

        static double CalcBonus(Employee em)
        {
            if (em.Experience < 5) return em.Salary*0.1;
            else if (em.Experience >= 5 & em.Experience < 10) return em.Salary*0.15;
            else if (em.Experience >= 10 & em.Experience < 15) return em.Salary * 0.25;
            else if (em.Experience >= 15 & em.Experience < 20) return em.Salary * 0.35;
            else if (em.Experience >= 20 & em.Experience < 25) return em.Salary * 0.45;
            else if (em.Experience >= 25) return em.Salary*0.5;
            else
            {
                Console.WriteLine("No bonuses!");
                return 0;
            }
        }
    }

    internal class Employee
    {
        public string Name { get; private set; }
        public int Experience { get; private set; }
        public double Salary { get; private set; }

        Employee this[int index]
        {
            get { return this[index]; }
            set { this[index] = value; }
        }

        public Employee(string name, int experience, int salary)
        {
            this.Name = name;
            this.Experience = experience;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return "name: " + Name + ", experience: " + Experience + ", salary: " + Salary + " ";
        }
    }
}
