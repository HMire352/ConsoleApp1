using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace upp1
{
    class program
    {
        static void Main(string[] args)
        {

            Add(12, 12, 12);
            Console.WriteLine(Add(12, 12, 12));
        }

        static int Add(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }

    }
   
    
}