using System;

namespace InterfaceClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Vasia", Age = 45 };
            p1.display();
            Person p2 = (Person)p1.Clone();
            p2.Age = 48;
            p2.display();
            p1.display();
            Console.WriteLine("{0}>{1}={2}",p1.Name,p2.Name,p1>p2);
            Console.WriteLine("{0}={1}={2}", p1.Name, p2.Name, p1 == p2);
            Console.WriteLine(p1.Compare(p1,p2));
            Person[] pers = new Person[2];
            pers[0] = p1;
            pers[1] = p2;
            Persons persons = new Persons(pers);
            foreach(Person p in persons)
            {
                Console.WriteLine(p.ToString());
            }
            foreach(Person p in persons.ReverseIterator())
            {
                Console.WriteLine(p.ToString());
            }
            People people = new People(pers);
            try 
            {
                Person p = new Person() { Name = "Alex", Age = 30 };
                people.MoveNext();
                people.Current = p;
                people.Reset();
                while(true)
                {
                    people.MoveNext();
                    p = (Person)people.Current;
                    Console.WriteLine(p.ToString());
                }
            }
            catch(InvalidOperationException)
            {
                people.Reset();
            }
        }
    }
}
