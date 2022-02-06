using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhonesWithOOPBasics
{
    public partial class Phones : Form
    {
        Cable cable = new Cable();
        Signal signal = new Signal(32);
        G1 g1 = new G1();
        G2 g2 = new G2();
        G3 g3 = new G3();
        G4 g4 = new G4();
        G5 g5 = new G5();
        IOS ios = new IOS();
        Android android = new Android();
        Windows windows = new Windows();
        public Phones()
        {
            InitializeComponent();
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abstract Class: \nCannot get instance. Base for all the other phone classes. \nHas 5 field variables one as static and 4 Properties (ID, Brand, Model, VoiceTransferMethod).\n3 Construction methods are created. \nOne abstract MakeCall and one virtual method ButtonSetup is created.");
        }

        private void btnLandlinePhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abstract Class: \nCannot get instance. Base for Analog, Cordless and Digital phone classes. Inherits from Phone Class \nHas 1 field variable and 1 Property (CallRange).\n4 Construction methods are created. 3 of them uses base. \nTwo abstract Recall and VoiceAnalog and one override method MakeCall is created.");
        }

        private void btnAnalogPhone_Click(object sender, EventArgs e)
        {
            AnalogInstance();
        }
        void AnalogInstance()
        {
            AnalogPhone ap = new AnalogPhone();
            ap.Brand = "Old";
            ap.CallRange = 235;
            ap.Model = "o234";
            ap.VoiceTransferMethod = cable;
            MessageBox.Show(ap.Recall());
            MessageBox.Show(ap.MakeCall());
            MessageBox.Show(ap.AnalogVoice());
            MessageBox.Show("Brand: " + ap.Brand + "\nModel: " + ap.Model + "\nCallRange: " + ap.CallRange + "\nVoiceTransferMethod: " + ap.VoiceTransferMethod.Method);
        }

        private void btnCordlessPhone_Click(object sender, EventArgs e)
        {
            CordlessInstance();
        }
        void CordlessInstance()
        {
            CordlessPhone cp = new CordlessPhone();
            cp.Brand = "Cordless";
            cp.CallRange = 23;
            cp.Model = "cordless234";
            cp.VoiceTransferMethod = signal;
            MessageBox.Show(cp.Recall()); 
            MessageBox.Show(cp.MakeCall());
            MessageBox.Show(cp.AnalogVoice());
            MessageBox.Show("Brand: " + cp.Brand + "\nModel: " + cp.Model + "\nCallRange: " + cp.CallRange + "\nVoiceTransferMethod: " + cp.VoiceTransferMethod.Method);
        }

        private void btnDigitalPhone_Click(object sender, EventArgs e)
        {
            DigitalInstance();
        }

        void DigitalInstance()
        {
            DigitalPhone dp = new DigitalPhone();
            dp.Brand = "Digital";
            dp.CallRange = 288;
            dp.Model = "digit134";
            dp.VoiceTransferMethod = cable;
            MessageBox.Show(dp.Recall());
            MessageBox.Show(dp.MakeCall());
            MessageBox.Show(dp.AnalogVoice());
            MessageBox.Show("Brand: " + dp.Brand + "\nModel: " + dp.Model + "\nCallRange: " + dp.CallRange + "\nVoiceTransferMethod: " + dp.VoiceTransferMethod.Method);
        }

        private void btnMobilePhone_Click(object sender, EventArgs e)
        {
            MobileInstance();
        }

        void MobileInstance()
        {
            MobilePhone mp = new MobilePhone("Motorola","g23",signal);
            mp.DataTransformMethod.Add(g1);
            mp.DataTransformMethod.Add(g2);
            MessageBox.Show(mp.TransferData());
            MessageBox.Show(mp.MakeCall());
            MessageBox.Show(mp.SendMessage());
            MessageBox.Show("Brand: " + mp.Brand + "\nModel: " + mp.Model + "\nVoiceTransferMethod: " + mp.VoiceTransferMethod.Method + "\nDataTransformMethod: " + mp.DataTransformMethod[0].DataType +" "+ mp.DataTransformMethod[1].DataType);
        }

        private void btnNotesLearned_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Sealed cannot be inherited but can be used from the inherited class.\n-You cannot use  sub properties if you add sub object as a super object.\n-You can override same method as much as you want and you can do this even if the super you inherit didn't override from its own super.\n-Abstract methods won't need to be overridden by the class inherited the class inherited the abstract class.\n-To invoke construtor with values in a 2nd or 3rd grage inherited class yo need to call base(values) every step to the class you're on.\n-When you don't use base(values) it automatically takes the basic constructor for the inherited class.");
        }

        private void btnSmartPhone_Click(object sender, EventArgs e)
        {
            SmartInstance();
        }
        void SmartInstance()
        {
            SmartPhone sp = new SmartPhone("Iphone", "s4");
            sp.DataTransformMethod.Add(g3);
            sp.DataTransformMethod.Add(g4);
            sp.DataTransformMethod.Add(g5);
            sp.OperatingSystem = ios;
            MessageBox.Show(sp.TransferData());
            MessageBox.Show(sp.MakeCall());
            MessageBox.Show(sp.SendMessage());
            MessageBox.Show(sp.StartPhone());
            MessageBox.Show("Brand: " + sp.Brand + "\nModel: " + sp.Model  + "\nDataTransformMethod: " + sp.DataTransformMethod[0].DataType + " " + sp.DataTransformMethod[1].DataType + " " + sp.DataTransformMethod[2].DataType + "\nOperatingSystem: " + sp.OperatingSystem.Type);
        }
    }
}
