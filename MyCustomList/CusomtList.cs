using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustList
{
    class CusomtList<T>
    {
        //member variable (HAS A)
        T[] items;
        private int count;
        private int capacity;
        
        public int Count
        {
            get { return count; } set { count = value; }

        }

        public int Capacity
        {
            get { return capacity; }
            set { count = value; }

        }

        //constructor (Spawn) (Set Value)
        public CusomtList() 
        {
            count = 0;
            capacity = 8;
            items = new T[capacity];
            items = new T[count];
        
        }


        //memeber methods (CAN DO)
        public void Add(T itemToAdd) 
        {
            items[0] = itemToAdd;
            
            //should add a value to our list (to the end)
            //increment count
        
        
        }








    }
}
