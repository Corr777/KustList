using DocumentFormat.OpenXml.Spreadsheet;
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
        private int  count;
        private int capacity;
       
        
        public int Count
        {
            get { return count; } set { count = value;}

        }

        public int Capicity 
        {
            get { return capacity; }
            set { capacity = value; }

        }

        public T this[int i] 
        {

            get { return items[0]; }
            set { Items[] = value; }

        
        }

      
        //constructor (Spawn) (Set Value)
        public CusomtList() 
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
            items = new T[count];
            
        }


        //memeber methods (CAN DO)
        public void Add(T itemToAdd) 
        {
            //items[1] = itemToAdd;
            //items[2] = itemToAdd;
            //items[3] = itemToAdd;
            

            for (int i = 0; i < length; i++)
            {


            }

            
            
            
            
            
            
            
            //should add a value to our list (to the end)
            //increment count
        
        
        }


        public void Remove(T itemToRemove) 
        {
            items[0] item<int>.ToArray<int>();
            items[1] = itemToRemove;





        }





    }
}
