using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    abstract class OperatingSystem
    {
        string _type = "";
        public string Type 
        { 
            get => _type;
            set => _type = value; 
        }

    }
}
