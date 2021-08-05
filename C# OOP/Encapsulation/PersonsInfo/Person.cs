using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName 
        { get
            {
                return this.firstName;
            }
            private set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be zaro or negative integer!");
                }
            }
        }

    public decimal Salary 
        { 
            get
            {
                return this.salary;
            }
            private set 
            {
                if (value < 460)
{
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
            } 
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else 
            {
                this.salary += this.salary * percentage / 200;
            }
        }
    }
}
