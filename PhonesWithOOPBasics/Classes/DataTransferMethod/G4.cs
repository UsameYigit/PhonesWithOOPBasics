using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class G4 : DataTransferMethod
    {
        public G4()
        {
            DataType = "4G";
        }
        public sealed override object SendData()
        {
            string data4G = "This data is for 4G";
            return data4G;
        }
    }
}
