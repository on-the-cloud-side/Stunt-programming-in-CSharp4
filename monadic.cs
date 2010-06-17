/*
 
 */
using System;

namespace dbj.mad
{
     static class Trivial
    {
        public static
            TResult 
            Execute<T, TResult>
            (this T argument,Func<T, TResult> operation)
        {
            return operation(argument);
        }

        public static void test() {
            "some string"
                    .Execute(s => s + " processed by trivial proto-monad.")
                    .Execute(s => s + " And it's chainable!");
        }


    }

    static class lib
    {
        static readonly System.Globalization.CultureInfo cc_ = System.Globalization.CultureInfo.CurrentCulture;

        public static string format(this string argument, params object[] args)
        {
            return string.Format(cc_, argument, args);
        }
    }
}