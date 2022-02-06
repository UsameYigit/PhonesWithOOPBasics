using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    abstract class LandlinePhone : Phone
    {
        int _callRange = 0;
        public int CallRange
        {
            get => _callRange;
            set => _callRange = value;
        }

        public LandlinePhone()
        {
        }

        public LandlinePhone(string Brand, string Model) : base(Brand, Model)
        {
        }

        public LandlinePhone(string Brand, string Model, int CallRange) : base(Brand, Model)
        {
            this.CallRange = CallRange;
        }

        public LandlinePhone(string Brand, string Model, VoiceTransferMethod VoiceTransferMethod) : base(Brand, Model, VoiceTransferMethod)
        {
        }

        public override string MakeCall()
        {
            return "Hi there I'm calling you via landlinePhone and you won't see it.";
        }

        public abstract string Recall();
        public abstract string AnalogVoice();
    }
}
