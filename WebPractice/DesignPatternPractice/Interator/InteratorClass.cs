using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DesignPatternPractice.Interator
{
    public interface IneratorInterface
    {
        object First();
        object Next();
        bool isDone();
        object CurrectItem();
    }

    public class InteratorClass : IneratorInterface
    {
        public object CurrectItem()
        {
            throw new NotImplementedException();
        }

        public object First()
        {
            throw new NotImplementedException();
        }

        public bool isDone()
        {
            throw new NotImplementedException();
        }

        public object Next()
        {
            throw new NotImplementedException();
        }



    }
}
