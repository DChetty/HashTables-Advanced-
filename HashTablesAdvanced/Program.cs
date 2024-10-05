using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesAdvanced
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomHash ch = new CustomHash();
            //add values 
            ch.Add(56581, "Nashy");
            ch.Add(56484, "Xavier");
            ch.Add(56393, "Mikey");
            ch.Add(56583, "Jake"); 

            Console.WriteLine(ch.GetHashTable());

            Console.ReadLine();
        }
    }
}
