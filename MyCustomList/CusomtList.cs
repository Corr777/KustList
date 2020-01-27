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
            get { return count; } set { count = 0;}

        }

        public int Capicity 
        {
            get { return capacity; }
            set { count = 8; }

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
            for (int i = 0; i < length; i++)
            {

            }

            
            
            
            
            
            
            items[0] = itemToAdd;
            //should add a value to our list (to the end)
            //increment count
        
        
        }








    }
}
