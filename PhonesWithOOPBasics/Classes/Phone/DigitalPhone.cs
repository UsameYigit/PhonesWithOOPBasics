using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class DigitalPhone : AnalogPhone
    {
        public DigitalPhone()
        {
        }

        public DigitalPhone(string Brand, string Model) : base(Brand, Model)
        {
        }

        public DigitalPhone(string Brand, string Model, int CallRange) : base(Brand, Model)
        {
            this.CallRange = CallRange;
        }

        public DigitalPhone(string Brand, string Model, VoiceTransferMethod VoiceTransferMethod) : base(Brand, Model, VoiceTransferMethod)
        {
        }

        public override string MakeCall()
        {
            return "Hi there I'm calling you via landlinePhone and this is a Digital one";
        }

        public override string Recall()
        {
            return "I'm recalling you via Digital Phone";
        }

        public override char[] ButtonSetup()
        {
            char[] buttonSet = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '*', '.', 'r' };
            return buttonSet;
        }
    }
}
