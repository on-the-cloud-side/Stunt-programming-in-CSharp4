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
             * This is the comment I have added while in 'branch_1'
             */
        }
    }
}
