using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    abstract class VoiceTransferMethod
    {
        string _method;
        public string Method
        {
            get => _method;
            set => _method = value;
        }
        public abstract object TransferVoice();
    }
}
