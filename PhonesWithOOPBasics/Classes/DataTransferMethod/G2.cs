using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class G2 : DataTransferMethod
    {
        public G2()
        {
            DataType = "2G";
        }
        public sealed override object SendData()
        {
            string data2G = "This data is for 2G";
            return data2G;
        }
    }
}
