/*
 * $Revision: $
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GITEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( string.Format(
                "Hi, my friendly name is: {0}",
                AppDomain.CurrentDomain.FriendlyName
            ));
            /*
             * Here I started additions while in 'branch_1'
             */
            Console.WriteLine(string.Format(
                "And, my id is: {0}",
                AppDomain.CurrentDomain.Id
            ));
        }
    }
}
