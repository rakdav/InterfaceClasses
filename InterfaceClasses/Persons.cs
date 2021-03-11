using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfaceClasses
{
    class Persons : IEnumerable
    {
        protected int size;
        protected Person[] container;

        public Persons(int size)
        {
            this.size = size;
            container = new Person[size];
        }

        public Persons(Person[] container)
        {
            this.container = container;
            this.size = container.Length;
        }

        public IEnumerator GetEnumerator()
        {
            return container.GetEnumerator();
        }

        public IEnumerable ReverseIterator()
        {
            for(int i=container.Length-1;i>=0;i--)
            {
                yield return container[i];
            }
        }
    }
}
