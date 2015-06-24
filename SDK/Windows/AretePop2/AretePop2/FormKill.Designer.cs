namespace Phychips.Arete
{
    partial class FormKill
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
            this.textBoxAccessPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.textBoxAccessPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTarget);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 437);
            this.panel1.TabIndex = 109;
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
            this.label1.Size = new System.Drawing.Size(139, 14);
            this.label1.TabIndex = 111;
            this.label1.Text = "Kill Password (HEX)";
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
            // FormKill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(355, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.labelMode);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Name = "FormKill";
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
        private System.Windows.Forms.TextBox textBoxAccessPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTarget;
    }
}