using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class G5 : DataTransferMethod
    {
        public G5()
        {
            DataType = "5G";
        }
        public sealed override object SendData()
        {
            string data5G = "This data is for 5G";
            return data5G;
        }

    }
}
