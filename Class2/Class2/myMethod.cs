using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public class myMethod
    {
        public int mathM(int addNum)
        {
            return addNum + 20;
        }
        public int mathM(decimal divNum)
        {
            return Convert.ToInt32(divNum / 2.5m);
        }
        public int mathM(string nameValue)
        {
            try
            {
                int myNum = Int32.Parse(nameValue);
                return myNum * 45;
            }
            catch(Exception)
            {
                return 0;
            }
        }
    } 
}
