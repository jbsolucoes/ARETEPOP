namespace Phychips.Arete
{
    partial class FormReadWrite
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
            this.labelMode = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWordLength = new System.Windows.Forms.TextBox();
            this.textBoxStartAddress = new System.Windows.Forms.TextBox();
            this.textBoxAccessPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custSegButtonUSER = new Phychips.Arete.CustSegButton();
            this.custSegButtonTID = new Phychips.Arete.CustSegButton();
            this.custSegButtonEPC = new Phychips.Arete.CustSegButton();
            this.custSegButtonRFU = new Phychips.Arete.CustSegButton();
            this.custSegButtonWrite = new Phychips.Arete.CustSegButton();
            this.custSegButtonRead = new Phychips.Arete.CustSegButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.Location = new System.Drawing.Point(151, 3);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(63, 29);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Read";
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.buttonBack.Image = global::Phychips.Arete.Properties.Resources.nav_btn_back;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(5, 5);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(125, 30);
            this.buttonBack.TabIndex = 100;
            this.buttonBack.Text = " Tag Access";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.buttonDone.Location = new System.Drawing.Point(270, 5);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(81, 30);
            this.buttonDone.TabIndex = 99;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.textBoxData);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.custSegButtonUSER);
            this.panel1.Controls.Add(this.custSegButtonTID);
            this.panel1.Controls.Add(this.custSegButtonEPC);
            this.panel1.Controls.Add(this.custSegButtonRFU);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxWordLength);
            this.panel1.Controls.Add(this.textBoxStartAddress);
            this.panel1.Controls.Add(this.textBoxAccessPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTarget);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.custSegButtonWrite);
            this.panel1.Controls.Add(this.custSegButtonRead);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 437);
            this.panel1.TabIndex = 109;
            // 
            // textBoxData
            // 
            this.textBoxData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxData.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxData.Location = new System.Drawing.Point(9, 316);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(336, 23);
            this.textBoxData.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(7, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 122;
            this.label6.Text = "Data (HEX)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(7, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 14);
            this.label5.TabIndex = 117;
            this.label5.Text = "Target Memory";
            // 
            // textBoxWordLength
            // 
            this.textBoxWordLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWordLength.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxWordLength.Location = new System.Drawing.Point(214, 175);
            this.textBoxWordLength.Name = "textBoxWordLength";
            this.textBoxWordLength.Size = new System.Drawing.Size(132, 23);
            this.textBoxWordLength.TabIndex = 116;
            this.textBoxWordLength.Text = "0";
            this.textBoxWordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStartAddress
            // 
            this.textBoxStartAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStartAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxStartAddress.Location = new System.Drawing.Point(214, 141);
            this.textBoxStartAddress.Name = "textBoxStartAddress";
            this.textBoxStartAddress.Size = new System.Drawing.Size(132, 23);
            this.textBoxStartAddress.TabIndex = 115;
            this.textBoxStartAddress.Text = "0000";
            this.textBoxStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAccessPassword
            // 
            this.textBoxAccessPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAccessPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxAccessPassword.Location = new System.Drawing.Point(214, 107);
            this.textBoxAccessPassword.Name = "textBoxAccessPassword";
            this.textBoxAccessPassword.Size = new System.Drawing.Size(132, 23);
            this.textBoxAccessPassword.TabIndex = 114;
            this.textBoxAccessPassword.Text = "00000000";
            this.textBoxAccessPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 14);
            this.label4.TabIndex = 113;
            this.label4.Text = "Word Length (DEC)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(7, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 14);
            this.label3.TabIndex = 112;
            this.label3.Text = "Start Address (HEX)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 14);
            this.label1.TabIndex = 111;
            this.label1.Text = "Access Password (HEX)";
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTarget.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxTarget.Location = new System.Drawing.Point(10, 73);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(336, 23);
            this.textBoxTarget.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 109;
            this.label2.Text = "Target Tag";
            // 
            // custSegButtonUSER
            // 
            this.custSegButtonUSER.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonUSER.Checked = false;
            this.custSegButtonUSER.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonUSER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonUSER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonUSER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonUSER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonUSER.Location = new System.Drawing.Point(262, 244);
            this.custSegButtonUSER.Name = "custSegButtonUSER";
            this.custSegButtonUSER.Size = new System.Drawing.Size(84, 30);
            this.custSegButtonUSER.TabIndex = 121;
            this.custSegButtonUSER.Text = "USER";
            this.custSegButtonUSER.UseVisualStyleBackColor = false;
            this.custSegButtonUSER.Click += new System.EventHandler(this.custSegButtonUSER_Click);
            // 
            // custSegButtonTID
            // 
            this.custSegButtonTID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonTID.Checked = false;
            this.custSegButtonTID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonTID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonTID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonTID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonTID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonTID.Location = new System.Drawing.Point(178, 244);
            this.custSegButtonTID.Name = "custSegButtonTID";
            this.custSegButtonTID.Size = new System.Drawing.Size(85, 30);
            this.custSegButtonTID.TabIndex = 120;
            this.custSegButtonTID.Text = "TID";
            this.custSegButtonTID.UseVisualStyleBackColor = false;
            this.custSegButtonTID.Click += new System.EventHandler(this.custSegButtonTID_Click);
            // 
            // custSegButtonEPC
            // 
            this.custSegButtonEPC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonEPC.Checked = false;
            this.custSegButtonEPC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonEPC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonEPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonEPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonEPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonEPC.Location = new System.Drawing.Point(94, 244);
            this.custSegButtonEPC.Name = "custSegButtonEPC";
            this.custSegButtonEPC.Size = new System.Drawing.Size(85, 30);
            this.custSegButtonEPC.TabIndex = 119;
            this.custSegButtonEPC.Text = "EPC";
            this.custSegButtonEPC.UseVisualStyleBackColor = false;
            this.custSegButtonEPC.Click += new System.EventHandler(this.custSegButtonEPC_Click);
            // 
            // custSegButtonRFU
            // 
            this.custSegButtonRFU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonRFU.Checked = true;
            this.custSegButtonRFU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonRFU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonRFU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonRFU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonRFU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonRFU.Location = new System.Drawing.Point(10, 244);
            this.custSegButtonRFU.Name = "custSegButtonRFU";
            this.custSegButtonRFU.Size = new System.Drawing.Size(85, 30);
            this.custSegButtonRFU.TabIndex = 118;
            this.custSegButtonRFU.Text = "RFU";
            this.custSegButtonRFU.UseVisualStyleBackColor = false;
            this.custSegButtonRFU.Click += new System.EventHandler(this.custSegButtonRFU_Click);
            // 
            // custSegButtonWrite
            // 
            this.custSegButtonWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonWrite.Checked = false;
            this.custSegButtonWrite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonWrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonWrite.Location = new System.Drawing.Point(178, 15);
            this.custSegButtonWrite.Name = "custSegButtonWrite";
            this.custSegButtonWrite.Size = new System.Drawing.Size(168, 30);
            this.custSegButtonWrite.TabIndex = 1;
            this.custSegButtonWrite.Text = "Write";
            this.custSegButtonWrite.UseVisualStyleBackColor = false;
            this.custSegButtonWrite.Click += new System.EventHandler(this.custSegButtonWrite_Click);
            // 
            // custSegButtonRead
            // 
            this.custSegButtonRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonRead.Checked = true;
            this.custSegButtonRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonRead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonRead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonRead.Location = new System.Drawing.Point(10, 15);
            this.custSegButtonRead.Name = "custSegButtonRead";
            this.custSegButtonRead.Size = new System.Drawing.Size(168, 30);
            this.custSegButtonRead.TabIndex = 0;
            this.custSegButtonRead.Text = "Read";
            this.custSegButtonRead.UseVisualStyleBackColor = false;
            this.custSegButtonRead.Click += new System.EventHandler(this.custSegButtonRead_Click);
            // 
            // FormReadWrite
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(355, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.labelMode);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Name = "FormReadWrite";
            this.ShowIcon = false;
            this.Text = "ARETE POP2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Panel panel1;
        private CustSegButton custSegButtonRead;
        private CustSegButton custSegButtonWrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label label6;
        private CustSegButton custSegButtonUSER;
        private CustSegButton custSegButtonTID;
        private CustSegButton custSegButtonEPC;
        private CustSegButton custSegButtonRFU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWordLength;
        private System.Windows.Forms.TextBox textBoxStartAddress;
        private System.Windows.Forms.TextBox textBoxAccessPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTarget;
    }
}