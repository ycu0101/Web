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
            double t1;

            #region Interator vs Normal Query
            //timer.Reset();
            ////Normal Query
            //var list_linq = _nw.Orders.Select(_o => new OrderList { OrderID = _o.OrderID, CustomerID = _o.CustomerID });
            //timer.Start();
            //foreach (var item in list_linq)
            //{
            //    Console.WriteLine("OrderID : {0}, Customer : {1}\t||\t", item.OrderID, item.CustomerID);
            //}
            //timer.Stop();
            //t1 = timer.Elapsed.TotalMilliseconds;

            //Console.WriteLine("\n========================================\n");

            timer.Reset();
            //Use Interator
            IEnumerable<OrderList> list_linq2 = _nw.Orders.Select(_o => new OrderList { OrderID = _o.OrderID, CustomerID = _o.CustomerID });
            timer.Start();
            //IEnumerator<Order> list_interator = list_linq2.GetEnumerator();
            foreach (OrderList item in new InteratorTest(list_linq2))
            {
                Console.WriteLine("OrderID : {0}, Customer : {1}\t||\t", item.OrderID, item.CustomerID);
            }
            timer.Stop();
            t1 = timer.Elapsed.TotalMilliseconds;
            #endregion



            Console.WriteLine("Time1 : {0}", t1);
            Console.Write("\nOver...");
            Console.ReadKey();
        }
    }


}
