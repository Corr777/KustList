using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> testlist = new CustomList<int>();

            //testlist.Add(10);
            //testlist.Add(11);

            testlist.Remove(1);
            testlist.Remove(2);

            //CustomList<string> customList2 = new CustomList<string>();

            //List<int> numbers = new List<int>();

            //numbers.Add(1);
            //numbers.Add(10);
            //numbers.Add(15);
            //numbers.Add(20);

        }



    }
}
