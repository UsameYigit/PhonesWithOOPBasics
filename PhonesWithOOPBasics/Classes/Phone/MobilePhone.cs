using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    class MobilePhone : Phone
    {
        List<DataTransferMethod> _dataTransformMethods = new List<DataTransferMethod>();
        public List<DataTransferMethod> DataTransformMethod
        {
            get => _dataTransformMethods;
            set => _dataTransformMethods = value;
        }

        public MobilePhone()
        {
        }

        public MobilePhone(string Brand, string Model) : base(Brand, Model)
        {
        }

        public MobilePhone(string Brand, string Model, VoiceTransferMethod VoiceTransferMethod) : base(Brand, Model, VoiceTransferMethod)
        {
        }

        public virtual string TransferData()
        {
            return this.DataTransformMethod[0].DataType + " is reached by Mobile";
        }
        public override string MakeCall()
        {
            return "Hi there I'm calling you via MobilePhone and this is an Mobile one";
        }
        public sealed override char[] ButtonSetup()
        {
            char[] buttonSet = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '*', '.', 'c', 'e' };
            return buttonSet;
        }
        public virtual string SendMessage()
        {
            return "Hi there I'm sending message you via MobilePhone and this is an Mobile one";
        }
    }
}
