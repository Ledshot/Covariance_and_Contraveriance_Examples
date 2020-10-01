using System;
using System.Collections.Generic;
using System.Text;

namespace QueryIt
{
    public interface IEntity
    {
        bool IsValid();
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class Employee : Person  , IEntity
    {
        public int Id { get; set; }

        public bool IsValid()
        {
            return true;
        }

        public virtual void DoWork()
        {
            Console.WriteLine("Doing real work");
        }
    }

    public class Manager : Employee
    {
        public virtual void DoWork()
        {
            Console.WriteLine("Creating a meeting");
        }
    }
}
