/*
 * 2010-06-16   dbj.org      Created
 */
using System;

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
             * Here I know I am "back" to branch "master"
             */
            Console.WriteLine(string.Format(
            /* I am now in branch_4 
             * In git please observe the POINT at which I have decided to create this branch
             * which is 'way back' in time
             */
                "My 'DomainManager' says the EntryAssembly full name is: {0}",
                AppDomain.CurrentDomain.DomainManager.EntryAssembly.FullName
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
