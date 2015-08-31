using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class DataHelper
    {
        private Object _lockObj = new object();
        private DataHelper _instance = null;

        public bool IsFriday()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataHelper GetImpl()
        {
            

        }

    }
}
