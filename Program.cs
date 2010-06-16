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
             * Here I know I am "back" to branch "master"
             */
            Console.WriteLine(string.Format(
                "My 'DomainManager' says the EntryAssembly full name is: {0}",
                AppDomain.CurrentDomain.DomainManager.EntryAssembly.FullName
            ));

            /* now I am in branch_2 */
            Console.WriteLine(string.Format(
                "I think this is enough info for you: {0}",
                System.Security.Principal.WindowsIdentity.GetCurrent().Name
                ));
        }
    }
}
