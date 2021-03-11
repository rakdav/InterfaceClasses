﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfaceClasses
{
    class People : Persons, IEnumerator
    {
        private int position = -1;

        public People(int size) : base(size) { }
        public People(Person[] people) : base(people) { }

        public object Current
        {
            get 
            { 
                try 
                {
                    return container[position];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
            set 
            {
                try
                {
                    container[position]=(Person)value;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            if(position<size) position++;
            return (position < size);
        }

        public void Reset()
        {
            position=-1;
        }
    }
}
