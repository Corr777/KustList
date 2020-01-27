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
        readonly T[] instruments;
        private int count;
        private int capacity;
        public List<>

        
       

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
            get { return instruments[i]; }
            set { instruments[i] = value; }

        }

      
        //constructor (Spawn) (Set Value)
        public CusomtList() 
        {
            count = 0;
            capacity = 4;
            instruments = new T[capacity];
            instruments = new T[count];
        }

        //memeber methods (CAN DO)
        public void Add(T itemToAdd) 
        {
          

            for (int i = 0; i < instruments.Length; i++)
            {
                instruments[0] = itemToAdd;
                instruments[1] = itemToAdd;
                instruments[2] = itemToAdd;
                instruments[3] = itemToAdd;

            }
           

            //should add a value to our list (to the end)
            //increment count


        }


        public void Remove(T itemToRemove) 
        {

            instruments[0] = itemToRemove;
            instruments[1] = itemToRemove;
            instruments[2] = itemToRemove;
            instruments[3] = itemToRemove;

            for (int i = 0; i < instruments.Length; i--)
            {
                                                            //decrement count

            }


        }

        public void ExtendList() 
        {
                                                                    //add maxed out array
                                                                   //add new items to increase the capacity to array
        
        
        
        
        }
















    }
}
