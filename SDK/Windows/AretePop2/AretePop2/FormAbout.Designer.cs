namespace Phychips.Arete
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelPid = new System.Windows.Forms.Label();
            this.labelFid = new System.Windows.Forms.Label();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelBattery = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 92;
            this.label1.Text = "About";
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
            this.buttonBack.TabIndex = 100;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(0, 126);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(355, 36);
            this.buttonExport.TabIndex = 105;
            this.buttonExport.Text = "PID";
            this.buttonExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(0, 91);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(355, 36);
            this.buttonAbout.TabIndex = 104;
            this.buttonAbout.Text = "Model";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(0, 56);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(355, 36);
            this.buttonSettings.TabIndex = 103;
            this.buttonSettings.Text = "App Version";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 437);
            this.label2.TabIndex = 106;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 36);
            this.button1.TabIndex = 107;
            this.button1.Text = "FID";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 36);
            this.button2.TabIndex = 108;
            this.button2.Text = "Region";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(355, 36);
            this.button3.TabIndex = 109;
            this.button3.Text = "Battery";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelAppVersion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppVersion.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelAppVersion.Location = new System.Drawing.Point(201, 62);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(150, 25);
            this.labelAppVersion.TabIndex = 110;
            this.labelAppVersion.Text = "-";
            this.labelAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelModel
            // 
            this.labelModel.BackColor = System.Drawing.Color.Transparent;
            this.labelModel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelModel.Location = new System.Drawing.Point(201, 97);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(150, 25);
            this.labelModel.TabIndex = 111;
            this.labelModel.Text = "-";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPid
            // 
            this.labelPid.BackColor = System.Drawing.Color.Transparent;
            this.labelPid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPid.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPid.Location = new System.Drawing.Point(201, 132);
            this.labelPid.Name = "labelPid";
            this.labelPid.Size = new System.Drawing.Size(150, 25);
            this.labelPid.TabIndex = 112;
            this.labelPid.Text = "-";
            this.labelPid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFid
            // 
            this.labelFid.BackColor = System.Drawing.Color.Transparent;
            this.labelFid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFid.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelFid.Location = new System.Drawing.Point(201, 167);
            this.labelFid.Name = "labelFid";
            this.labelFid.Size = new System.Drawing.Size(150, 25);
            this.labelFid.TabIndex = 113;
            this.labelFid.Text = "-";
            this.labelFid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRegion
            // 
            this.labelRegion.BackColor = System.Drawing.Color.Transparent;
            this.labelRegion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegion.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelRegion.Location = new System.Drawing.Point(201, 202);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(150, 25);
            this.labelRegion.TabIndex = 114;
            this.labelRegion.Text = "-";
            this.labelRegion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBattery
            // 
            this.labelBattery.BackColor = System.Drawing.Color.Transparent;
            this.labelBattery.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattery.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelBattery.Location = new System.Drawing.Point(201, 237);
            this.labelBattery.Name = "labelBattery";
            this.labelBattery.Size = new System.Drawing.Size(150, 25);
            this.labelBattery.TabIndex = 115;
            this.labelBattery.Text = "-";
            this.labelBattery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormAbout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(355, 476);
            this.Controls.Add(this.labelBattery);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.labelFid);
            this.Controls.Add(this.labelPid);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelAppVersion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbout";
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
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelAppVersion;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelPid;
        private System.Windows.Forms.Label labelFid;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelBattery;
    }
}