
namespace PhonesWithOOPBasics
{
    partial class Phones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPhone = new System.Windows.Forms.Button();
            this.btnLandlinePhone = new System.Windows.Forms.Button();
            this.btnAnalogPhone = new System.Windows.Forms.Button();
            this.btnSmartPhone = new System.Windows.Forms.Button();
            this.btnMobilePhone = new System.Windows.Forms.Button();
            this.btnCordlessPhone = new System.Windows.Forms.Button();
            this.btnDigitalPhone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNotesLearned = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(184, 38);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(108, 23);
            this.btnPhone.TabIndex = 0;
            this.btnPhone.Text = "Phone";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // btnLandlinePhone
            // 
            this.btnLandlinePhone.Location = new System.Drawing.Point(72, 78);
            this.btnLandlinePhone.Name = "btnLandlinePhone";
            this.btnLandlinePhone.Size = new System.Drawing.Size(108, 23);
            this.btnLandlinePhone.TabIndex = 1;
            this.btnLandlinePhone.Text = "Landline Phone";
            this.btnLandlinePhone.UseVisualStyleBackColor = true;
            this.btnLandlinePhone.Click += new System.EventHandler(this.btnLandlinePhone_Click);
            // 
            // btnAnalogPhone
            // 
            this.btnAnalogPhone.Location = new System.Drawing.Point(72, 119);
            this.btnAnalogPhone.Name = "btnAnalogPhone";
            this.btnAnalogPhone.Size = new System.Drawing.Size(108, 23);
            this.btnAnalogPhone.TabIndex = 2;
            this.btnAnalogPhone.Text = "Analog Phone";
            this.btnAnalogPhone.UseVisualStyleBackColor = true;
            this.btnAnalogPhone.Click += new System.EventHandler(this.btnAnalogPhone_Click);
            // 
            // btnSmartPhone
            // 
            this.btnSmartPhone.Location = new System.Drawing.Point(296, 119);
            this.btnSmartPhone.Name = "btnSmartPhone";
            this.btnSmartPhone.Size = new System.Drawing.Size(108, 23);
            this.btnSmartPhone.TabIndex = 3;
            this.btnSmartPhone.Text = "Smart Phone";
            this.btnSmartPhone.UseVisualStyleBackColor = true;
            this.btnSmartPhone.Click += new System.EventHandler(this.btnSmartPhone_Click);
            // 
            // btnMobilePhone
            // 
            this.btnMobilePhone.Location = new System.Drawing.Point(296, 78);
            this.btnMobilePhone.Name = "btnMobilePhone";
            this.btnMobilePhone.Size = new System.Drawing.Size(108, 23);
            this.btnMobilePhone.TabIndex = 4;
            this.btnMobilePhone.Text = "Mobile Phone";
            this.btnMobilePhone.UseVisualStyleBackColor = true;
            this.btnMobilePhone.Click += new System.EventHandler(this.btnMobilePhone_Click);
            // 
            // btnCordlessPhone
            // 
            this.btnCordlessPhone.Location = new System.Drawing.Point(11, 158);
            this.btnCordlessPhone.Name = "btnCordlessPhone";
            this.btnCordlessPhone.Size = new System.Drawing.Size(108, 23);
            this.btnCordlessPhone.TabIndex = 5;
            this.btnCordlessPhone.Text = "Cordless Phone";
            this.btnCordlessPhone.UseVisualStyleBackColor = true;
            this.btnCordlessPhone.Click += new System.EventHandler(this.btnCordlessPhone_Click);
            // 
            // btnDigitalPhone
            // 
            this.btnDigitalPhone.Location = new System.Drawing.Point(133, 158);
            this.btnDigitalPhone.Name = "btnDigitalPhone";
            this.btnDigitalPhone.Size = new System.Drawing.Size(108, 23);
            this.btnDigitalPhone.TabIndex = 6;
            this.btnDigitalPhone.Text = "Digital Phone";
            this.btnDigitalPhone.UseVisualStyleBackColor = true;
            this.btnDigitalPhone.Click += new System.EventHandler(this.btnDigitalPhone_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPhone);
            this.groupBox1.Controls.Add(this.btnLandlinePhone);
            this.groupBox1.Controls.Add(this.btnAnalogPhone);
            this.groupBox1.Controls.Add(this.btnSmartPhone);
            this.groupBox1.Controls.Add(this.btnMobilePhone);
            this.groupBox1.Controls.Add(this.btnCordlessPhone);
            this.groupBox1.Controls.Add(this.btnDigitalPhone);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 209);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phone Class Design";
            // 
            // btnNotesLearned
            // 
            this.btnNotesLearned.Location = new System.Drawing.Point(187, 253);
            this.btnNotesLearned.Name = "btnNotesLearned";
            this.btnNotesLearned.Size = new System.Drawing.Size(119, 23);
            this.btnNotesLearned.TabIndex = 18;
            this.btnNotesLearned.Text = "Notes Learned";
            this.btnNotesLearned.UseVisualStyleBackColor = true;
            this.btnNotesLearned.Click += new System.EventHandler(this.btnNotesLearned_Click);
            // 
            // Phones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 344);
            this.Controls.Add(this.btnNotesLearned);
            this.Controls.Add(this.groupBox1);
            this.Name = "Phones";
            this.Text = "Phones";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Button btnLandlinePhone;
        private System.Windows.Forms.Button btnAnalogPhone;
        private System.Windows.Forms.Button btnSmartPhone;
        private System.Windows.Forms.Button btnMobilePhone;
        private System.Windows.Forms.Button btnCordlessPhone;
        private System.Windows.Forms.Button btnDigitalPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNotesLearned;
    }
}

