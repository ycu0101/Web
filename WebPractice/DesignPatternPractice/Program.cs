using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternPractice._DB;
using DesignPatternPractice.Interator;

namespace DesignPatternPractice
{
    class Program
    {
        private static NW_Entities _nw = new NW_Entities();
        private static System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        static void Main(string[] args)
        {
            timer.Start();
            //InteratorQuery q1 = new InteratorQuery();
            //Console.WriteLine("TimeQ1 : {0}", q1.Query());
            timer.Stop();

            var k = timer.Elapsed.TotalMilliseconds;

            timer.Reset();

            //OrignalQuery q2 = new OrignalQuery();
            //Console.WriteLine("TimeQ2 : {0}", q2.Query());

            List<string> list1 = new List<string>();
            List<string> list2 = null;

            Console.WriteLine("List1 => Count : {0}\tAny : {1}", list1.Count, list1.Any());
            //發生 null Exception，只要沒有實體就無法使用這些 function
            //Console.WriteLine("List2 => Count : {0}\tAny : {1}", list2.Count(), list2.Any());

            Console.Write("\nOver...");
            Console.ReadKey();
        }

        public class DicClass
        {
            public string xx1;
            public string xx2;
        }
    }


}
