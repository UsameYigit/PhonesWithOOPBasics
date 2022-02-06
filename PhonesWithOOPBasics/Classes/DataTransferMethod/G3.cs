using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class G3 : DataTransferMethod
    {
        public G3()
        {
            DataType = "3G";
        }
        public sealed override object SendData()
        {
            string data3G = "This data is for 3G";
            return data3G;
        }
    }
}
