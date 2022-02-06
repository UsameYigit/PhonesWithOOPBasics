using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class CordlessPhone : AnalogPhone
    {
        public CordlessPhone()
        {
        }

        public CordlessPhone(string Brand, string Model) : base(Brand, Model)
        {
        }

        public CordlessPhone(string Brand, string Model, int CallRange) : base(Brand, Model)
        {
            this.CallRange = CallRange;
        }

        public CordlessPhone(string Brand, string Model, VoiceTransferMethod VoiceTransferMethod) : base(Brand, Model, VoiceTransferMethod)
        {
        }

        public override string MakeCall()
        {
            return "Hi there I'm calling you via landlinePhone and this is a Cordless one";
        }

        public override string Recall()
        {
            return "I'm recalling you via Cordless Phone";
        }

        public override char[] ButtonSetup()
        {
            char[] buttonSet = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '*', '.', 'r' };
            return buttonSet;
        }

    }
}
