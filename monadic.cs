/*
 (c) DBJ.ORG 2010
 */
using System;

namespace dbj.mad
{
     static class Trivial
    {
         public delegate TResult TheMethod<T, TResult>(T argument, Func<T, TResult> operation);

         static object initial_state_ = null;
         //static object state_ = null;

         static public 
             System.Collections.Generic.List<object> 
             State = new System.Collections.Generic.List<object>();

        public static
            TheMethod<T, TResult> 
            Begin<T, TResult> 
            (this T argument,Func<T, TResult> operation)
        {
            var my_method = new TheMethod<T,TResult>(
                            (arg,op) => { 
                                var result = op(arg);
                                Trivial.State.Add(result);
                                return result ;
                            }
                );
            Trivial.initial_state_ = my_method(argument, operation);
            return  my_method; // (argument, operation);
        }

        public static void test() {
           var result = "some string"
                    .Begin(s => s + " processed by trivial proto-monad.")
                    ("another", s => s + " And it's chainable!");
            // 2010 06 17 15:43:13  DBJ     Stunt programming in C#4

          result = result.each(
               (c, i) => { return '#'; }
               );
        }
    }

    /// <summary>
    /// DBJ string extensions
    /// </summary>
    static class str
    {
        static readonly System.Globalization.CultureInfo cc_ = System.Globalization.CultureInfo.CurrentCulture;
        
        public static string format(this string argument, params object[] args)
        {
            return string.Format(str.cc_, argument, args);
        }

        public static string each
            (this string argument, Func<char, int, char > operation, params object[] args)
        {
            int idx = 0;
            var copy = new System.Text.StringBuilder() ;
            foreach (char c in argument )
            {
                    copy.Append(operation(c, idx++));
                    continue;
            }
            return copy.ToString() ;
        }
    }
}