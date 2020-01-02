using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DesignPatternPractice._DB;

namespace DesignPatternPractice.Interator
{
    public class OrignalQuery
    {
        private NW_Entities nw;

        public OrignalQuery()
        {
            nw = new NW_Entities();
        }

        public double Query()
        {
            double t;
            Stopwatch timer = new Stopwatch();
            OrderList temp = null;
            timer.Reset();

            var list_linq = nw.Orders.Select(_o => new OrderList { OrderID = _o.OrderID, CustomerID = _o.CustomerID });

            timer.Start();
            foreach (OrderList item in list_linq)
            {
                temp = item;
            }
            timer.Stop();


            t = timer.Elapsed.TotalMilliseconds;

            return t;
        }
    }
}
