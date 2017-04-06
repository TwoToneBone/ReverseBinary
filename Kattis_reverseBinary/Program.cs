using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Kattis_ReverseBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Convert.ToUInt32(new string(Convert.ToString(uint.Parse(Console.ReadLine()), 2).Reverse().ToArray()), 2));
            }
            catch (Exception e)
            {

                Debug.WriteLine(e.Message);
            }               
        }
    }
}