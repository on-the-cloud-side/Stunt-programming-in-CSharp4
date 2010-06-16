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
            Console.WriteLine( string.Format("Hi, my friendly name is: {0}",
                AppDomain.CurrentDomain.FriendlyName));
            Console.WriteLine(string.Format("My 'DomainManager' says the EntryAssembly full name is: {0}",
                AppDomain.CurrentDomain.DomainManager.EntryAssembly.FullName));
            Console.WriteLine(string.Format("And, my id is: {0}",
                AppDomain.CurrentDomain.Id));
            Console.WriteLine(string.Format("I think this is enough info for you: {0}",
                System.Security.Principal.WindowsIdentity.GetCurrent().Name));
        }
    }
}
