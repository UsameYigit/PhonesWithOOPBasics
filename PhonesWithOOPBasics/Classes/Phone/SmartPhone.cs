using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class SmartPhone : MobilePhone
    {
        OperatingSystem _operatingSystem;
        public OperatingSystem OperatingSystem
        {
            get => _operatingSystem;
            set => _operatingSystem = value;
        }

        public SmartPhone()
        {
        }

        public SmartPhone(string Brand, string Model) : base(Brand, Model)
        {
        }

        public SmartPhone(string Brand, string Model, VoiceTransferMethod VoiceTransferMethod) : base(Brand, Model, VoiceTransferMethod)
        {
        }

        public string StartPhone()
        {
            return "This phone uses " + OperatingSystem.Type;
        }
        public override string TransferData()
        {
            return this.DataTransformMethod[0].DataType + " is reached by Smart";
        }

        public override string MakeCall()
        {
            return "Hi there I'm calling you via SmartPhone and this is a Smart one";
        }

        public override string SendMessage()
        {
            return "Hi there I'm sending message you via SmartPhone and this is an Smart one";
        }
    }
}
