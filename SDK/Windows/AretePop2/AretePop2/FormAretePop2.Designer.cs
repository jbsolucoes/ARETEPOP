namespace Phychips.Arete
{
    partial class FormAretePop2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAretePop2));
            this.listViewEPC = new System.Windows.Forms.ListView();
            this.cPC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEPC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonMore = new System.Windows.Forms.Button();
            this.labelBattery = new System.Windows.Forms.Label();
            this.labelPlug = new System.Windows.Forms.Label();
            this.labelTags = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toggleButton = new Phychips.Arete.CustToggleButton();
            this.SuspendLayout();
            // 
            // listViewEPC
            // 
            this.listViewEPC.AutoArrange = false;
            this.listViewEPC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cPC,
            this.cEPC,
            this.cCnt});
            this.listViewEPC.Font = new System.Drawing.Font("Arial", 9F);
            this.listViewEPC.FullRowSelect = true;
            this.listViewEPC.GridLines = true;
            this.listViewEPC.Location = new System.Drawing.Point(0, 81);
            this.listViewEPC.MultiSelect = false;
            this.listViewEPC.Name = "listViewEPC";
            this.listViewEPC.Size = new System.Drawing.Size(355, 353);
            this.listViewEPC.TabIndex = 88;
            this.listViewEPC.UseCompatibleStateImageBehavior = false;
            this.listViewEPC.View = System.Windows.Forms.View.Details;
            this.listViewEPC.SelectedIndexChanged += new System.EventHandler(this.listViewEPC_SelectedIndexChanged);
            // 
            // cPC
            // 
            this.cPC.Text = "PC";
            this.cPC.Width = 50;
            // 
            // cEPC
            // 
            this.cEPC.Text = "EPC";
            this.cEPC.Width = 230;
            // 
            // cCnt
            // 
            this.cCnt.Text = "";
            this.cCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonRead
            // 
            this.buttonRead.FlatAppearance.BorderSize = 0;
            this.buttonRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRead.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.buttonRead.Location = new System.Drawing.Point(72, 440);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(81, 30);
            this.buttonRead.TabIndex = 89;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonMore
            // 
            this.buttonMore.FlatAppearance.BorderSize = 0;
            this.buttonMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.buttonMore.Location = new System.Drawing.Point(270, 5);
            this.buttonMore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(81, 30);
            this.buttonMore.TabIndex = 97;
            this.buttonMore.Text = "More";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // labelBattery
            // 
            this.labelBattery.BackColor = System.Drawing.Color.Silver;
            this.labelBattery.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattery.Location = new System.Drawing.Point(254, 52);
            this.labelBattery.Name = "labelBattery";
            this.labelBattery.Size = new System.Drawing.Size(95, 24);
            this.labelBattery.TabIndex = 96;
            this.labelBattery.Text = "0%";
            this.labelBattery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlug
            // 
            this.labelPlug.BackColor = System.Drawing.Color.Silver;
            this.labelPlug.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlug.Location = new System.Drawing.Point(131, 52);
            this.labelPlug.Name = "labelPlug";
            this.labelPlug.Size = new System.Drawing.Size(95, 24);
            this.labelPlug.TabIndex = 95;
            this.labelPlug.Text = "Unplugged";
            this.labelPlug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTags
            // 
            this.labelTags.BackColor = System.Drawing.Color.Silver;
            this.labelTags.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTags.Location = new System.Drawing.Point(6, 52);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(95, 24);
            this.labelTags.TabIndex = 94;
            this.labelTags.Text = "0 tags";
            this.labelTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 92;
            this.label1.Text = "ARETE POP2";
            // 
            // buttonStop
            // 
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.buttonStop.Location = new System.Drawing.Point(270, 440);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(81, 30);
            this.buttonStop.TabIndex = 91;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.buttonClear.Location = new System.Drawing.Point(171, 440);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(81, 30);
            this.buttonClear.TabIndex = 90;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 35);
            this.panel1.TabIndex = 133;
            // 
            // toggleButton
            // 
            this.toggleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleButton.BackgroundImage")));
            this.toggleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toggleButton.Checked = false;
            this.toggleButton.FlatAppearance.BorderSize = 0;
            this.toggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButton.Location = new System.Drawing.Point(2, 435);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(45, 32);
            this.toggleButton.TabIndex = 98;
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // FormAretePop2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(355, 476);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.listViewEPC);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.labelBattery);
            this.Controls.Add(this.labelPlug);
            this.Controls.Add(this.labelTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAretePop2";
            this.ShowIcon = false;
            this.Text = "ARETE POP2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAretePop2_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.VisibleChanged += new System.EventHandler(this.Form_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustToggleButton toggleButton;
        private System.Windows.Forms.ListView listViewEPC;
        private System.Windows.Forms.ColumnHeader cPC;
        private System.Windows.Forms.ColumnHeader cEPC;
        private System.Windows.Forms.ColumnHeader cCnt;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.Label labelBattery;
        private System.Windows.Forms.Label labelPlug;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panel1;
    }
}