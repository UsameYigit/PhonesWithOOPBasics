using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class G1 : DataTransferMethod
    {
        public G1()
        {
            DataType = "1G";
        }
        public sealed override object SendData()
        {
            string data1G = "This data is for 1G";
            return data1G;
        }
    }
}
