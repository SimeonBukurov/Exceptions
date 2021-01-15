using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get { return this.firstName; }
            set {this.firstName = value;}
        }
        public string LastName
        {
            get { return this.lastName; }
            set {this.lastName = value;}
          
        }
        public int Age
        {
            get { return this.age; }
            set 
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("value", "Age should be in the range [0....120].");
                }
                this.age = value;
            }
        }
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Ivan", "Marinov", 26);
            try
            {
                Person noName = new Person("Martin", "Sergeev", 75);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            try
            {
                Person noLastName = new Person("James", "Ivanov", 23);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            try
            {
                Person negativeAge = new Person("Dobromir", "Georgiev", -14);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            try
            {
                Person tooOldForThisProgram = new Person("Boiko", "Borisov", 140);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
        }
    }
}
