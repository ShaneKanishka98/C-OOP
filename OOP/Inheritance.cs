using DocumentFormat.OpenXml.Wordprocessing;
using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Inheritance
    {
        public static void main(string[] args)
        {
            Employee e1 = new Employee();

            Manager m = new Manager();
            m.validate();
            m.validate(5);
            m.validate(0, true);

            Employee e2 = new Manager();
            e2 = new Supervisor();
        }
    }

    public class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }

        public virtual void validate() { }
    }

    public class Manager : Employee
{ 
        public void management() { }

        public override void validate()
        {
            // re use the logic here 
        }

        public void validate(int num) { }

        public void validate(int num, bool val) { }

    }

    public class Supervisor : Employee
    {

    }
}     
