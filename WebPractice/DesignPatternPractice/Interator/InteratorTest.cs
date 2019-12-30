using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Interator
{
    public class InteratorTest : System.Collections.IEnumerable
    {
        private IEnumerable<OrderList> _list;

        /// <summary>
        /// 在建構此類別時必須放入集合
        /// </summary>
        /// <param name="_list">IEnumable<T> 類型的集合</param>
        public InteratorTest(IEnumerable<OrderList> _temp)
        {
            _list = _temp;
        }

        /// <summary>
        /// Enumerator
        /// </summary>
        /// <returns>return: IEnumerator</returns>
        public IEnumerator GetEnumerator()
        {
            foreach (var item in _list)
            {
                yield return item;
            }
        }
    }


    public class OrderList
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
    }
}
