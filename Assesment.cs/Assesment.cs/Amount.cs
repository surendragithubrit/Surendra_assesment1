using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.cs
{
    internal class Amount
    {
       

        static void Main(string[] args) {
            
            Console.WriteLine("enter the amount:");
            double amount = int.Parse(Console.ReadLine());
            double balance = amount * 0.05;
            Console.WriteLine(balance);
            double total=amount+balance;
            Console.WriteLine(total);
            
        }
    }
}
