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


        //public int Count
        //{
        //    get and/or set 'count'
        //}

        //constructor (Spawn) (Set Value)
        public CusomtList() 
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        
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
