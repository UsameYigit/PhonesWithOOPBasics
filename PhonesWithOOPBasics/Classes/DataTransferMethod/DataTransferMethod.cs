using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    abstract class DataTransferMethod
    {
        string _dataType;
        public string DataType
        {
            get => _dataType;
            set => _dataType = value;
        }

        public abstract object SendData();


    }
}
