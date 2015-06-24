namespace Phychips.Arete
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStopConditions = new System.Windows.Forms.Button();
            this.buttonOnOffTime = new System.Windows.Forms.Button();
            this.buttonOutputPower = new System.Windows.Forms.Button();
            this.buttonSession = new System.Windows.Forms.Button();
            this.buttonBeep = new System.Windows.Forms.Button();
            this.buttonSpeakerBeep = new System.Windows.Forms.Button();
            this.buttonReadAfterPlugging = new System.Windows.Forms.Button();
            this.buttonRssi = new System.Windows.Forms.Button();
            this.buttonEncoding = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEncodingType = new Phychips.Arete.CustLabel();
            this.labelSession = new Phychips.Arete.CustLabel();
            this.labelStopCondition = new Phychips.Arete.CustLabel();
            this.labelOnOffTime = new Phychips.Arete.CustLabel();
            this.labelOutputPower = new Phychips.Arete.CustLabel();
            this.toggleButtonReadAfterPlugging = new Phychips.Arete.CustToggleButton();
            this.toggleButtonRssi = new Phychips.Arete.CustToggleButton();
            this.toggleButtonSpeakerBeep = new Phychips.Arete.CustToggleButton();
            this.toggleButtonBeep = new Phychips.Arete.CustToggleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 92;
            this.label1.Text = "Settings";
            // 
            // buttonStopConditions
            // 
            this.buttonStopConditions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonStopConditions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStopConditions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStopConditions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopConditions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopConditions.Location = new System.Drawing.Point(0, 145);
            this.buttonStopConditions.Name = "buttonStopConditions";
            this.buttonStopConditions.Size = new System.Drawing.Size(355, 36);
            this.buttonStopConditions.TabIndex = 105;
            this.buttonStopConditions.Text = "Stop Conditions";
            this.buttonStopConditions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStopConditions.UseVisualStyleBackColor = true;
            this.buttonStopConditions.Click += new System.EventHandler(this.buttonStopConditions_Click);
            // 
            // buttonOnOffTime
            // 
            this.buttonOnOffTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonOnOffTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOnOffTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOnOffTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOnOffTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOnOffTime.Location = new System.Drawing.Point(0, 91);
            this.buttonOnOffTime.Name = "buttonOnOffTime";
            this.buttonOnOffTime.Size = new System.Drawing.Size(355, 36);
            this.buttonOnOffTime.TabIndex = 104;
            this.buttonOnOffTime.Text = "On/Off Time (ms)";
            this.buttonOnOffTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOnOffTime.UseVisualStyleBackColor = true;
            this.buttonOnOffTime.Click += new System.EventHandler(this.buttonOnOffTime_Click);
            // 
            // buttonOutputPower
            // 
            this.buttonOutputPower.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonOutputPower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOutputPower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOutputPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutputPower.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOutputPower.Location = new System.Drawing.Point(0, 56);
            this.buttonOutputPower.Name = "buttonOutputPower";
            this.buttonOutputPower.Size = new System.Drawing.Size(355, 36);
            this.buttonOutputPower.TabIndex = 103;
            this.buttonOutputPower.Text = "Output Power";
            this.buttonOutputPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOutputPower.UseVisualStyleBackColor = true;
            this.buttonOutputPower.Click += new System.EventHandler(this.buttonOutputPower_Click);
            // 
            // buttonSession
            // 
            this.buttonSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSession.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSession.Location = new System.Drawing.Point(0, 180);
            this.buttonSession.Name = "buttonSession";
            this.buttonSession.Size = new System.Drawing.Size(355, 36);
            this.buttonSession.TabIndex = 107;
            this.buttonSession.Text = "Session";
            this.buttonSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSession.UseVisualStyleBackColor = true;
            this.buttonSession.Click += new System.EventHandler(this.buttonSession_Click);
            // 
            // buttonBeep
            // 
            this.buttonBeep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonBeep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBeep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBeep.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeep.Location = new System.Drawing.Point(0, 235);
            this.buttonBeep.Name = "buttonBeep";
            this.buttonBeep.Size = new System.Drawing.Size(355, 36);
            this.buttonBeep.TabIndex = 108;
            this.buttonBeep.Text = "Beep";
            this.buttonBeep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBeep.UseVisualStyleBackColor = true;
            this.buttonBeep.Click += new System.EventHandler(this.buttonBeep_Click);
            // 
            // buttonSpeakerBeep
            // 
            this.buttonSpeakerBeep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSpeakerBeep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSpeakerBeep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSpeakerBeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeakerBeep.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeakerBeep.Location = new System.Drawing.Point(0, 270);
            this.buttonSpeakerBeep.Name = "buttonSpeakerBeep";
            this.buttonSpeakerBeep.Size = new System.Drawing.Size(355, 36);
            this.buttonSpeakerBeep.TabIndex = 109;
            this.buttonSpeakerBeep.Text = "Speaker Beep";
            this.buttonSpeakerBeep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSpeakerBeep.UseVisualStyleBackColor = true;
            this.buttonSpeakerBeep.Click += new System.EventHandler(this.buttonSpeakerBeep_Click);
            // 
            // buttonReadAfterPlugging
            // 
            this.buttonReadAfterPlugging.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonReadAfterPlugging.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonReadAfterPlugging.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonReadAfterPlugging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadAfterPlugging.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadAfterPlugging.Location = new System.Drawing.Point(0, 340);
            this.buttonReadAfterPlugging.Name = "buttonReadAfterPlugging";
            this.buttonReadAfterPlugging.Size = new System.Drawing.Size(355, 36);
            this.buttonReadAfterPlugging.TabIndex = 117;
            this.buttonReadAfterPlugging.Text = "Read After Plugging";
            this.buttonReadAfterPlugging.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReadAfterPlugging.UseVisualStyleBackColor = true;
            this.buttonReadAfterPlugging.Click += new System.EventHandler(this.buttonReadAfterPlugging_Click);
            // 
            // buttonRssi
            // 
            this.buttonRssi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRssi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRssi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRssi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRssi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRssi.Location = new System.Drawing.Point(0, 305);
            this.buttonRssi.Name = "buttonRssi";
            this.buttonRssi.Size = new System.Drawing.Size(355, 36);
            this.buttonRssi.TabIndex = 116;
            this.buttonRssi.Text = "Display Tag RSSI";
            this.buttonRssi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRssi.UseVisualStyleBackColor = true;
            this.buttonRssi.Click += new System.EventHandler(this.buttonRssi_Click);
            // 
            // buttonEncoding
            // 
            this.buttonEncoding.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEncoding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEncoding.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEncoding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncoding.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncoding.Location = new System.Drawing.Point(0, 375);
            this.buttonEncoding.Name = "buttonEncoding";
            this.buttonEncoding.Size = new System.Drawing.Size(355, 36);
            this.buttonEncoding.TabIndex = 120;
            this.buttonEncoding.Text = "Encoding Type";
            this.buttonEncoding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEncoding.UseVisualStyleBackColor = true;
            this.buttonEncoding.Click += new System.EventHandler(this.buttonEncoding_Click);
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
            this.buttonBack.Text = "More";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 437);
            this.panel1.TabIndex = 132;
            // 
            // labelEncodingType
            // 
            this.labelEncodingType.BackColor = System.Drawing.Color.Transparent;
            this.labelEncodingType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEncodingType.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelEncodingType.Image = ((System.Drawing.Image)(resources.GetObject("labelEncodingType.Image")));
            this.labelEncodingType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEncodingType.Location = new System.Drawing.Point(201, 381);
            this.labelEncodingType.Name = "labelEncodingType";
            this.labelEncodingType.Size = new System.Drawing.Size(150, 25);
            this.labelEncodingType.TabIndex = 131;
            this.labelEncodingType.Text = "-  ";
            this.labelEncodingType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEncodingType.Click += new System.EventHandler(this.labelEncodingType_Click);
            // 
            // labelSession
            // 
            this.labelSession.BackColor = System.Drawing.Color.Transparent;
            this.labelSession.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSession.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelSession.Image = ((System.Drawing.Image)(resources.GetObject("labelSession.Image")));
            this.labelSession.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSession.Location = new System.Drawing.Point(201, 186);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(150, 25);
            this.labelSession.TabIndex = 130;
            this.labelSession.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSession.Click += new System.EventHandler(this.labelSession_Click);
            // 
            // labelStopCondition
            // 
            this.labelStopCondition.BackColor = System.Drawing.Color.Transparent;
            this.labelStopCondition.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelStopCondition.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelStopCondition.Image = ((System.Drawing.Image)(resources.GetObject("labelStopCondition.Image")));
            this.labelStopCondition.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelStopCondition.Location = new System.Drawing.Point(201, 151);
            this.labelStopCondition.Name = "labelStopCondition";
            this.labelStopCondition.Size = new System.Drawing.Size(150, 25);
            this.labelStopCondition.TabIndex = 129;
            this.labelStopCondition.Text = "-  ";
            this.labelStopCondition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelStopCondition.Click += new System.EventHandler(this.labelStopCondition_Click);
            // 
            // labelOnOffTime
            // 
            this.labelOnOffTime.BackColor = System.Drawing.Color.Transparent;
            this.labelOnOffTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelOnOffTime.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelOnOffTime.Image = ((System.Drawing.Image)(resources.GetObject("labelOnOffTime.Image")));
            this.labelOnOffTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelOnOffTime.Location = new System.Drawing.Point(201, 97);
            this.labelOnOffTime.Name = "labelOnOffTime";
            this.labelOnOffTime.Size = new System.Drawing.Size(150, 25);
            this.labelOnOffTime.TabIndex = 127;
            this.labelOnOffTime.Text = "-  ";
            this.labelOnOffTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelOnOffTime.Click += new System.EventHandler(this.labelOnOffTime_Click);
            // 
            // labelOutputPower
            // 
            this.labelOutputPower.BackColor = System.Drawing.Color.Transparent;
            this.labelOutputPower.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelOutputPower.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelOutputPower.Image = ((System.Drawing.Image)(resources.GetObject("labelOutputPower.Image")));
            this.labelOutputPower.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelOutputPower.Location = new System.Drawing.Point(201, 62);
            this.labelOutputPower.Name = "labelOutputPower";
            this.labelOutputPower.Size = new System.Drawing.Size(150, 25);
            this.labelOutputPower.TabIndex = 126;
            this.labelOutputPower.Text = "-  ";
            this.labelOutputPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelOutputPower.Click += new System.EventHandler(this.labelOutputPower_Click);
            // 
            // toggleButtonReadAfterPlugging
            // 
            this.toggleButtonReadAfterPlugging.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleButtonReadAfterPlugging.BackgroundImage")));
            this.toggleButtonReadAfterPlugging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toggleButtonReadAfterPlugging.Checked = false;
            this.toggleButtonReadAfterPlugging.FlatAppearance.BorderSize = 0;
            this.toggleButtonReadAfterPlugging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButtonReadAfterPlugging.Location = new System.Drawing.Point(301, 342);
            this.toggleButtonReadAfterPlugging.Name = "toggleButtonReadAfterPlugging";
            this.toggleButtonReadAfterPlugging.Size = new System.Drawing.Size(45, 32);
            this.toggleButtonReadAfterPlugging.TabIndex = 125;
            this.toggleButtonReadAfterPlugging.UseVisualStyleBackColor = true;
            this.toggleButtonReadAfterPlugging.Click += new System.EventHandler(this.toggleButtonReadAfterPlugging_Click);
            // 
            // toggleButtonRssi
            // 
            this.toggleButtonRssi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleButtonRssi.BackgroundImage")));
            this.toggleButtonRssi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toggleButtonRssi.Checked = false;
            this.toggleButtonRssi.FlatAppearance.BorderSize = 0;
            this.toggleButtonRssi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButtonRssi.Location = new System.Drawing.Point(301, 307);
            this.toggleButtonRssi.Name = "toggleButtonRssi";
            this.toggleButtonRssi.Size = new System.Drawing.Size(45, 32);
            this.toggleButtonRssi.TabIndex = 124;
            this.toggleButtonRssi.UseVisualStyleBackColor = true;
            this.toggleButtonRssi.Click += new System.EventHandler(this.toggleButtonRssi_Click);
            // 
            // toggleButtonSpeakerBeep
            // 
            this.toggleButtonSpeakerBeep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleButtonSpeakerBeep.BackgroundImage")));
            this.toggleButtonSpeakerBeep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toggleButtonSpeakerBeep.Checked = false;
            this.toggleButtonSpeakerBeep.FlatAppearance.BorderSize = 0;
            this.toggleButtonSpeakerBeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButtonSpeakerBeep.Location = new System.Drawing.Point(301, 272);
            this.toggleButtonSpeakerBeep.Name = "toggleButtonSpeakerBeep";
            this.toggleButtonSpeakerBeep.Size = new System.Drawing.Size(45, 32);
            this.toggleButtonSpeakerBeep.TabIndex = 123;
            this.toggleButtonSpeakerBeep.UseVisualStyleBackColor = true;
            this.toggleButtonSpeakerBeep.Click += new System.EventHandler(this.toggleButtonSpeakerBeep_Click);
            // 
            // toggleButtonBeep
            // 
            this.toggleButtonBeep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleButtonBeep.BackgroundImage")));
            this.toggleButtonBeep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toggleButtonBeep.Checked = false;
            this.toggleButtonBeep.FlatAppearance.BorderSize = 0;
            this.toggleButtonBeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButtonBeep.Location = new System.Drawing.Point(301, 237);
            this.toggleButtonBeep.Name = "toggleButtonBeep";
            this.toggleButtonBeep.Size = new System.Drawing.Size(45, 32);
            this.toggleButtonBeep.TabIndex = 122;
            this.toggleButtonBeep.UseVisualStyleBackColor = true;
            this.toggleButtonBeep.Click += new System.EventHandler(this.toggleButtonBeep_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(355, 476);
            this.Controls.Add(this.labelEncodingType);
            this.Controls.Add(this.labelSession);
            this.Controls.Add(this.labelStopCondition);
            this.Controls.Add(this.labelOnOffTime);
            this.Controls.Add(this.labelOutputPower);
            this.Controls.Add(this.toggleButtonReadAfterPlugging);
            this.Controls.Add(this.toggleButtonRssi);
            this.Controls.Add(this.toggleButtonSpeakerBeep);
            this.Controls.Add(this.toggleButtonBeep);
            this.Controls.Add(this.buttonEncoding);
            this.Controls.Add(this.buttonReadAfterPlugging);
            this.Controls.Add(this.buttonRssi);
            this.Controls.Add(this.buttonSpeakerBeep);
            this.Controls.Add(this.buttonBeep);
            this.Controls.Add(this.buttonSession);
            this.Controls.Add(this.buttonStopConditions);
            this.Controls.Add(this.buttonOnOffTime);
            this.Controls.Add(this.buttonOutputPower);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormSettings";
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
        private System.Windows.Forms.Button buttonStopConditions;
        private System.Windows.Forms.Button buttonOnOffTime;
        private System.Windows.Forms.Button buttonOutputPower;
        private System.Windows.Forms.Button buttonSession;
        private System.Windows.Forms.Button buttonBeep;
        private System.Windows.Forms.Button buttonSpeakerBeep;
        private System.Windows.Forms.Button buttonReadAfterPlugging;
        private System.Windows.Forms.Button buttonRssi;
        private System.Windows.Forms.Button buttonEncoding;
        private CustToggleButton toggleButtonBeep;
        private CustToggleButton toggleButtonSpeakerBeep;
        private CustToggleButton toggleButtonRssi;
        private CustToggleButton toggleButtonReadAfterPlugging;
        private CustLabel labelOutputPower;
        private CustLabel labelOnOffTime;
        private CustLabel labelStopCondition;
        private CustLabel labelSession;
        private CustLabel labelEncodingType;
        private System.Windows.Forms.Panel panel1;
    }
}