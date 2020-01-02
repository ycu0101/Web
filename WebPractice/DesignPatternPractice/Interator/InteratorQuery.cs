using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DesignPatternPractice._DB;

namespace DesignPatternPractice.Interator
{
    public class InteratorQuery
    {
        private NW_Entities nw;
        public InteratorQuery()
        {
            nw = new NW_Entities();
        }

        public double Query()
        {
            double t;
            Stopwatch timer = new Stopwatch();
            OrderList temp = null;
            timer.Reset();

            IEnumerable<OrderList> list_linq2 = nw.Orders.Select(_o => new OrderList { OrderID = _o.OrderID, CustomerID = _o.CustomerID });

            timer.Start();
            foreach (OrderList item in new InteratorTest(list_linq2))
            {
                temp = item;
            }
            timer.Stop();


            t = timer.Elapsed.TotalMilliseconds;

            return t;
        }
    }
}
