using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfaceClasses
{
    class Person:ICloneable,IComparable,IComparer<Person>
    {
        public string Name { get; set; } 
        public int Age{ get; set; }

        public object Clone()
        {
            return new Person() { Age = this.Age, Name = this.Name };
        }

        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                var p = obj as Person;
                return this.Name.CompareTo(p.Name);
            }
            else throw new Exception("Not compare");
        }
        public static bool operator>(Person p1,Person p2)
        {
            return (p1.CompareTo(p2)>0);
        }
        public static bool operator <(Person p1, Person p2)
        {
            return (p1.CompareTo(p2) < 0);
        }
        public static bool operator >=(Person p1, Person p2)
        {
            return (p1.CompareTo(p2) >= 0);
        }
        public static bool operator <=(Person p1, Person p2)
        {
            return (p1.CompareTo(p2) <= 0);
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return (p1.CompareTo(p2) == 0);
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return (p1.CompareTo(p2) != 0);
        }
        public void display()
        {
            Console.WriteLine(Name+" "+Age);
        }

        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            if (x.Age > y.Age) return 1;
            else if(x.Age < y.Age) return -1;
            else return 0;
        }

        public override string ToString()
        {
            return Name+" "+Age;
        }
    }
}
