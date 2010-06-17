/*
 * 2010-06-16   dbj.org      Created
 *                           git: branch_2 came out as a 'winner'  and was merged 'into' this 
 *                           branch which is 'master'
 *                           Therefore! From this git point, we can proceed with 'master'
 *                           in github.com network view, observe the graph, on commit a9e9904
 *                           where we are now back to single 'thread of development'
 */
using System;

namespace GITEST1
{
    class Program
    {
        static readonly System.Globalization.CultureInfo cc_ = System.Globalization.CultureInfo.CurrentCulture;

        static void Main(string[] args)
        {

            Console.WriteLine(string.Format(cc_, resources.s01,
                AppDomain.CurrentDomain.FriendlyName));
            Console.WriteLine(string.Format(cc_, resources.s02,
                AppDomain.CurrentDomain.DomainManager.EntryAssembly.FullName));
            Console.WriteLine(string.Format(cc_, resources.s03 ,
                AppDomain.CurrentDomain.Id));
            Console.WriteLine(string.Format( cc_, resources.s04 ,
                System.Security.Principal.WindowsIdentity.GetCurrent().Name));
        }
    }
}
