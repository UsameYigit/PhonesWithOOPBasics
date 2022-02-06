using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class Signal : VoiceTransferMethod
    {
        int _signalQuality;
        public int SignalQuality
        {
            get => _signalQuality;
            set => _signalQuality = value;
        }
        public Signal()
        {
            this.Method = "Signal";
            this.SignalQuality = 100;
        }
        public Signal(int SignalQuality)
        {
            this.Method = "Signal";
            this.SignalQuality = SignalQuality;
        }
        public override object TransferVoice()
        {
            string data = (SignalQuality * 3) + " is the data.";
            return data;
        }
    }
}
