/*
 * 2010-06-16   dbj.org      Created
 */
using System;
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
            /* I am now in branch_4 
             * In git please observe the POINT at which I have decided to create this branch
             * which is 'way back' in time
             */
        }
    }
}
