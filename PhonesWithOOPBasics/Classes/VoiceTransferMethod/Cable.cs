using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class Cable : VoiceTransferMethod
    {
        int _cableQuality;
        public int CableQuality
        {
            get => _cableQuality;
            set => _cableQuality = value;
        }
        public Cable()
        {
            this.Method = "Cable";
            this.CableQuality = 100;
        }
        public Cable(int CableQuality)
        {
            this.Method = "Cable";
            this.CableQuality = CableQuality;
        }
        public override object TransferVoice()
        {
            string data = (CableQuality * 12) + " is the data.";
            return data;
        }
    }
}
