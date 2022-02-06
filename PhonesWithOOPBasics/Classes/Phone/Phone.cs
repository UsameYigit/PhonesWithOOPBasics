using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonesWithOOPBasics
{
    abstract class Phone
    {
        static int _counter = 0;
        int _id = 0;
        public int ID
        {
            get => _id;
        }
        string _brand = "";
        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }
        string _model = "";
        public string Model
        {
            get => _model;
            set => _model = value;
        }
        VoiceTransferMethod _voiceTransferMethod;
        public VoiceTransferMethod VoiceTransferMethod
        { 
          get => _voiceTransferMethod; 
          set => _voiceTransferMethod = value; 
        }



        public Phone()
        {
            _id = _counter;
            _counter++;
        }

        public Phone(string Brand, string Model)
        {
            this.Brand = Brand;
            this.Model = Model;

            _id = _counter;
            _counter++;
        }

        public Phone(string Brand, string Model, VoiceTransferMethod VoiceTransferMethod)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.VoiceTransferMethod = VoiceTransferMethod;

            _id = _counter;
            _counter++;
        }

        public abstract string MakeCall();

        public virtual char[] ButtonSetup()
        {
            char[] buttonSet = {'1', '2','3','4','5','6','7','8','9','0','*','.'};
            return buttonSet;
        }
    }
}
