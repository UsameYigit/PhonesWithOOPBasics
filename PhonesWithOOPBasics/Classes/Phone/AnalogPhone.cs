using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class AnalogPhone : LandlinePhone
    {

        public AnalogPhone()
        {
        }

        public AnalogPhone(string Brand, string Model) : base(Brand, Model)
        {
        }

        public AnalogPhone(string Brand, string Model, int CallRange) : base(Brand, Model)
        {
            this.CallRange = CallRange;
        }

        public AnalogPhone(string Brand, string Model, VoiceTransferMethod VoiceTransferMethod) : base(Brand, Model, VoiceTransferMethod)
        {
        }

        public override string MakeCall()
        {
            return "Hi there I'm calling you via landlinePhone and this is a Analog one";
        }

        public override string Recall()
        {
            return "I'm recalling you via Analog Phone";
        }

        public sealed override string AnalogVoice()
        {
            return "This is Analog voice and it cannot be inherited.";
        }
    }
}
