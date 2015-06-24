namespace Phychips.Arete
{
    partial class FormAccess
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKill = new System.Windows.Forms.Button();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonReadWrite = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 92;
            this.label1.Text = "Tag Access";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 437);
            this.label2.TabIndex = 99;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKill
            // 
            this.buttonKill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKill.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKill.Image = global::Phychips.Arete.Properties.Resources.disclosure;
            this.buttonKill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKill.Location = new System.Drawing.Point(0, 141);
            this.buttonKill.Name = "buttonKill";
            this.buttonKill.Size = new System.Drawing.Size(355, 36);
            this.buttonKill.TabIndex = 106;
            this.buttonKill.Text = "Kill";
            this.buttonKill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKill.UseVisualStyleBackColor = true;
            this.buttonKill.Click += new System.EventHandler(this.buttonKill_Click);
            // 
            // buttonLock
            // 
            this.buttonLock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLock.Image = global::Phychips.Arete.Properties.Resources.disclosure;
            this.buttonLock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLock.Location = new System.Drawing.Point(0, 106);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(355, 36);
            this.buttonLock.TabIndex = 105;
            this.buttonLock.Text = "Lock";
            this.buttonLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // buttonReadWrite
            // 
            this.buttonReadWrite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReadWrite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonReadWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadWrite.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadWrite.Image = global::Phychips.Arete.Properties.Resources.disclosure;
            this.buttonReadWrite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReadWrite.Location = new System.Drawing.Point(0, 71);
            this.buttonReadWrite.Name = "buttonReadWrite";
            this.buttonReadWrite.Size = new System.Drawing.Size(355, 36);
            this.buttonReadWrite.TabIndex = 104;
            this.buttonReadWrite.Text = "Read / Write";
            this.buttonReadWrite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReadWrite.UseVisualStyleBackColor = false;
            this.buttonReadWrite.Click += new System.EventHandler(this.buttonReadWrite_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::Phychips.Arete.Properties.Resources.nav_btn_back;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.buttonBack.Location = new System.Drawing.Point(5, 5);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(81, 30);
            this.buttonBack.TabIndex = 98;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormAccess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(355, 476);
            this.Controls.Add(this.buttonKill);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.buttonReadWrite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Name = "FormAccess";
            this.ShowIcon = false;
            this.Text = "ARETE POP2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMore_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReadWrite;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonKill;
    }
}