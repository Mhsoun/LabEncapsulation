using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrease
{
    class Person
    {

        private string firstname;
        public string FirstName { get; set; }

        private string lastName;
        public string LastName { get; set; }

        private int age;
        public int Age { get; set; }

        private decimal salary;
        public Decimal Salary { get; set; }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public void IncreaseSalary (decimal percentage)

        {
            if (age>30)
            {
                this.Salary = Salary * percentage / 100;
            }
            else
            {
                this.Salary = Salary * percentage / 200;
            }

        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary} dollars. ";
        }



    }
}
