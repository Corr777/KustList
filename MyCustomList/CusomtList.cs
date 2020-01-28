using DocumentFormat.OpenXml.Spreadsheet;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //member variable (HAS A)
        T[] instruments;
        private int count;
        private int capacity;
        private readonly int j;

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
        public CustomList() 
        {
            count = 0;
            capacity = 4;
            instruments = new T[capacity];
           
        }

        //memeber methods (CAN DO)
        public void Add(T itemToAdd) 
        {
            if (count == capacity)
            {
                                        //add statement to duplicate arrray   
                capacity *= 2;
                T[] temporary = new T[capacity];

                for (int i = 0; i < count; i++)
                {

                    temporary[j] = instruments[i];
                                                //add item 

                }

                instruments = temporary;
            }

            instruments[count] = itemToAdd;
            count++;
        }

        public void Remove(T itemToRemove) 
        {
            if (count > capacity)
            {
                T[] temporary = new T[capacity];

                for (int i = 0, j = 0; i < capacity; i++, j++)
                {
                    temporary[j] = instruments[i];

                                                     //decrement count

                }

                instruments[count] = itemToRemove;
                count--;

            }
 
        }

   
  

    }
}



