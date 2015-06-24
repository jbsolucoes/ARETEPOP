namespace Phychips.Arete
{
    partial class FormOutputPower
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.custListViewImage1 = new Phychips.Arete.CustListViewImage();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 92;
            this.label1.Text = "Output Power";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.buttonDone.Click += new System.EventHandler(this.buttonMore_Click);
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
            this.buttonBack.Size = new System.Drawing.Size(90, 30);
            this.buttonBack.TabIndex = 100;
            this.buttonBack.Text = "Settings";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 437);
            this.label2.TabIndex = 107;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custListViewImage1
            // 
            this.custListViewImage1.CheckBoxes = true;
            this.custListViewImage1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custListViewImage1.FullRowSelect = true;
            this.custListViewImage1.GridLines = true;
            this.custListViewImage1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.custListViewImage1.Image = global::Phychips.Arete.Properties.Resources.checked_mark;
            this.custListViewImage1.Location = new System.Drawing.Point(0, 60);
            this.custListViewImage1.Name = "custListViewImage1";
            this.custListViewImage1.RowHeight = 36;
            this.custListViewImage1.Scrollable = false;
            this.custListViewImage1.Size = new System.Drawing.Size(355, 416);
            this.custListViewImage1.TabIndex = 101;
            this.custListViewImage1.UseCompatibleStateImageBehavior = false;
            this.custListViewImage1.View = System.Windows.Forms.View.Details;
            // 
            // FormOutputPower
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(355, 476);
            this.Controls.Add(this.custListViewImage1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormOutputPower";
            this.ShowIcon = false;
            this.Text = "ARETE POP2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDone;
        private CustListViewImage custListViewImage1;
        private System.Windows.Forms.Label label2;
    }
}