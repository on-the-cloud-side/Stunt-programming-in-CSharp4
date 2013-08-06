/*
 * 2010-06-16   dbj.org      Created
 *                           git: branch_2 came out as a 'winner'  and was merged 'into' this 
 *                           branch which is 'master'
 *                           Therefore! From this git point, we can proceed with 'master'
 *                           in github.com network view, observe the graph, on commit a9e9904
 *                           where we are now back to single 'thread of development'
 */
using System;
using dbj.mad ;

namespace Stunt_programming_in_CSharp4
{
    class Program
    {
        // static readonly System.Globalization.CultureInfo cc_ = System.Globalization.CultureInfo.CurrentCulture;

        static void Main(/*string[] args*/)
        {
            about();
            dbj.mad.Trivial.test();
        }

        static void about()
        {
// we need 'using dbj.mad' for 'format()' string extension
            Console.WriteLine(resources.s01.format(AppDomain.CurrentDomain.FriendlyName));
            Console.WriteLine(resources.s02.format(
                AppDomain.CurrentDomain.DomainManager != null ? AppDomain.CurrentDomain.DomainManager.EntryAssembly.FullName : " oops, sorry, my DomainManager is absent."
                )
            );
            Console.WriteLine(resources.s03.format(AppDomain.CurrentDomain.Id));
            Console.WriteLine(resources.s04.format(System.Security.Principal.WindowsIdentity.GetCurrent().Name));
        }
    }
}
