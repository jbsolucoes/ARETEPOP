namespace Phychips.Arete
{
    partial class FormLock
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAccessPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custSegButtonEPC = new Phychips.Arete.CustSegButton();
            this.custSegButtonPLock = new Phychips.Arete.CustSegButton();
            this.custSegButtonLock = new Phychips.Arete.CustSegButton();
            this.custSegButtonPUnlock = new Phychips.Arete.CustSegButton();
            this.custSegButtonUnlock = new Phychips.Arete.CustSegButton();
            this.custSegButtonUSER = new Phychips.Arete.CustSegButton();
            this.custSegButtonTID = new Phychips.Arete.CustSegButton();
            this.custSegButtonAcs = new Phychips.Arete.CustSegButton();
            this.custSegButtonKill = new Phychips.Arete.CustSegButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.Location = new System.Drawing.Point(151, 3);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(57, 29);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Lock";
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
            this.panel1.Controls.Add(this.custSegButtonEPC);
            this.panel1.Controls.Add(this.custSegButtonPLock);
            this.panel1.Controls.Add(this.custSegButtonLock);
            this.panel1.Controls.Add(this.custSegButtonPUnlock);
            this.panel1.Controls.Add(this.custSegButtonUnlock);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.custSegButtonUSER);
            this.panel1.Controls.Add(this.custSegButtonTID);
            this.panel1.Controls.Add(this.custSegButtonAcs);
            this.panel1.Controls.Add(this.custSegButtonKill);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxAccessPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTarget);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 437);
            this.panel1.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(7, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 14);
            this.label6.TabIndex = 122;
            this.label6.Text = "Action (P: Permanent)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(7, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 14);
            this.label5.TabIndex = 117;
            this.label5.Text = "Target Memory";
            // 
            // textBoxAccessPassword
            // 
            this.textBoxAccessPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAccessPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxAccessPassword.Location = new System.Drawing.Point(214, 66);
            this.textBoxAccessPassword.Name = "textBoxAccessPassword";
            this.textBoxAccessPassword.Size = new System.Drawing.Size(132, 23);
            this.textBoxAccessPassword.TabIndex = 114;
            this.textBoxAccessPassword.Text = "00000000";
            this.textBoxAccessPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 14);
            this.label1.TabIndex = 111;
            this.label1.Text = "Access Password (HEX)";
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTarget.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxTarget.Location = new System.Drawing.Point(10, 32);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(336, 23);
            this.textBoxTarget.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 109;
            this.label2.Text = "Target Tag";
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
            this.custSegButtonEPC.Location = new System.Drawing.Point(144, 140);
            this.custSegButtonEPC.Name = "custSegButtonEPC";
            this.custSegButtonEPC.Size = new System.Drawing.Size(68, 30);
            this.custSegButtonEPC.TabIndex = 127;
            this.custSegButtonEPC.Text = "EPC";
            this.custSegButtonEPC.UseVisualStyleBackColor = false;
            this.custSegButtonEPC.Click += new System.EventHandler(this.custSegButtonEPC_Click);
            // 
            // custSegButtonPLock
            // 
            this.custSegButtonPLock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonPLock.Checked = false;
            this.custSegButtonPLock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonPLock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonPLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonPLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonPLock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonPLock.Location = new System.Drawing.Point(262, 219);
            this.custSegButtonPLock.Name = "custSegButtonPLock";
            this.custSegButtonPLock.Size = new System.Drawing.Size(84, 30);
            this.custSegButtonPLock.TabIndex = 126;
            this.custSegButtonPLock.Text = "PLock";
            this.custSegButtonPLock.UseVisualStyleBackColor = false;
            this.custSegButtonPLock.Click += new System.EventHandler(this.custSegButtonPLock_Click);
            // 
            // custSegButtonLock
            // 
            this.custSegButtonLock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonLock.Checked = false;
            this.custSegButtonLock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonLock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonLock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonLock.Location = new System.Drawing.Point(178, 219);
            this.custSegButtonLock.Name = "custSegButtonLock";
            this.custSegButtonLock.Size = new System.Drawing.Size(85, 30);
            this.custSegButtonLock.TabIndex = 125;
            this.custSegButtonLock.Text = "Lock";
            this.custSegButtonLock.UseVisualStyleBackColor = false;
            this.custSegButtonLock.Click += new System.EventHandler(this.custSegButtonLock_Click);
            // 
            // custSegButtonPUnlock
            // 
            this.custSegButtonPUnlock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonPUnlock.Checked = false;
            this.custSegButtonPUnlock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonPUnlock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonPUnlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonPUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonPUnlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonPUnlock.Location = new System.Drawing.Point(94, 219);
            this.custSegButtonPUnlock.Name = "custSegButtonPUnlock";
            this.custSegButtonPUnlock.Size = new System.Drawing.Size(85, 30);
            this.custSegButtonPUnlock.TabIndex = 124;
            this.custSegButtonPUnlock.Text = "PUnlock";
            this.custSegButtonPUnlock.UseVisualStyleBackColor = false;
            this.custSegButtonPUnlock.Click += new System.EventHandler(this.custSegButtonPUnlock_Click);
            // 
            // custSegButtonUnlock
            // 
            this.custSegButtonUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonUnlock.Checked = true;
            this.custSegButtonUnlock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonUnlock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonUnlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonUnlock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonUnlock.Location = new System.Drawing.Point(10, 219);
            this.custSegButtonUnlock.Name = "custSegButtonUnlock";
            this.custSegButtonUnlock.Size = new System.Drawing.Size(85, 30);
            this.custSegButtonUnlock.TabIndex = 123;
            this.custSegButtonUnlock.Text = "Unlock";
            this.custSegButtonUnlock.UseVisualStyleBackColor = false;
            this.custSegButtonUnlock.Click += new System.EventHandler(this.custSegButtonUnlock_Click);
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
            this.custSegButtonUSER.Location = new System.Drawing.Point(278, 140);
            this.custSegButtonUSER.Name = "custSegButtonUSER";
            this.custSegButtonUSER.Size = new System.Drawing.Size(68, 30);
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
            this.custSegButtonTID.Location = new System.Drawing.Point(211, 140);
            this.custSegButtonTID.Name = "custSegButtonTID";
            this.custSegButtonTID.Size = new System.Drawing.Size(68, 30);
            this.custSegButtonTID.TabIndex = 120;
            this.custSegButtonTID.Text = "TID";
            this.custSegButtonTID.UseVisualStyleBackColor = false;
            this.custSegButtonTID.Click += new System.EventHandler(this.custSegButtonTID_Click);
            // 
            // custSegButtonAcs
            // 
            this.custSegButtonAcs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonAcs.Checked = false;
            this.custSegButtonAcs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonAcs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonAcs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonAcs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonAcs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonAcs.Location = new System.Drawing.Point(77, 140);
            this.custSegButtonAcs.Name = "custSegButtonAcs";
            this.custSegButtonAcs.Size = new System.Drawing.Size(68, 30);
            this.custSegButtonAcs.TabIndex = 119;
            this.custSegButtonAcs.Text = "Acs";
            this.custSegButtonAcs.UseVisualStyleBackColor = false;
            this.custSegButtonAcs.Click += new System.EventHandler(this.custSegButtonAcs_Click);
            // 
            // custSegButtonKill
            // 
            this.custSegButtonKill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonKill.Checked = true;
            this.custSegButtonKill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.custSegButtonKill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonKill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.custSegButtonKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custSegButtonKill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custSegButtonKill.Location = new System.Drawing.Point(10, 140);
            this.custSegButtonKill.Name = "custSegButtonKill";
            this.custSegButtonKill.Size = new System.Drawing.Size(68, 30);
            this.custSegButtonKill.TabIndex = 118;
            this.custSegButtonKill.Text = "Kill";
            this.custSegButtonKill.UseVisualStyleBackColor = false;
            this.custSegButtonKill.Click += new System.EventHandler(this.custSegButtonKill_Click);
            // 
            // FormLock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(355, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.labelMode);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Name = "FormLock";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private CustSegButton custSegButtonUSER;
        private CustSegButton custSegButtonTID;
        private CustSegButton custSegButtonAcs;
        private CustSegButton custSegButtonKill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAccessPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTarget;
        private CustSegButton custSegButtonPLock;
        private CustSegButton custSegButtonLock;
        private CustSegButton custSegButtonPUnlock;
        private CustSegButton custSegButtonUnlock;
        private CustSegButton custSegButtonEPC;
    }
}