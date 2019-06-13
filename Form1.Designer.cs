namespace CS204
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.rdMan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAuto = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PingHistory = new System.Windows.Forms.ListBox();
            this.IpLable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OldJitter = new System.Windows.Forms.Label();
            this.OldDropPcklbl = new System.Windows.Forms.Label();
            this.OldPingTimelbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OptionList = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdMan
            // 
            this.rdMan.AutoSize = true;
            this.rdMan.Location = new System.Drawing.Point(12, 33);
            this.rdMan.Margin = new System.Windows.Forms.Padding(6);
            this.rdMan.Name = "rdMan";
            this.rdMan.Size = new System.Drawing.Size(114, 29);
            this.rdMan.TabIndex = 1;
            this.rdMan.TabStop = true;
            this.rdMan.Text = "Manual";
            this.rdMan.UseVisualStyleBackColor = true;
            this.rdMan.CheckedChanged += new System.EventHandler(this.RdMan_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAuto);
            this.groupBox1.Controls.Add(this.rdMan);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(220, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // rdAuto
            // 
            this.rdAuto.AutoSize = true;
            this.rdAuto.Location = new System.Drawing.Point(12, 66);
            this.rdAuto.Margin = new System.Windows.Forms.Padding(6);
            this.rdAuto.Name = "rdAuto";
            this.rdAuto.Size = new System.Drawing.Size(138, 29);
            this.rdAuto.TabIndex = 0;
            this.rdAuto.TabStop = true;
            this.rdAuto.Text = "Automatic";
            this.rdAuto.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(992, 60);
            this.btnApply.Margin = new System.Windows.Forms.Padding(6);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(150, 44);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.IpLable);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(24, 331);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1561, 512);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ping Results";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PingHistory);
            this.groupBox4.Location = new System.Drawing.Point(375, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1177, 404);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result History";
            // 
            // PingHistory
            // 
            this.PingHistory.BackColor = System.Drawing.SystemColors.Control;
            this.PingHistory.FormattingEnabled = true;
            this.PingHistory.ItemHeight = 25;
            this.PingHistory.Location = new System.Drawing.Point(6, 45);
            this.PingHistory.Name = "PingHistory";
            this.PingHistory.Size = new System.Drawing.Size(1165, 329);
            this.PingHistory.TabIndex = 8;
            // 
            // IpLable
            // 
            this.IpLable.AutoSize = true;
            this.IpLable.Location = new System.Drawing.Point(496, 60);
            this.IpLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IpLable.Name = "IpLable";
            this.IpLable.Size = new System.Drawing.Size(0, 25);
            this.IpLable.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Your IP address:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OldJitter);
            this.groupBox3.Controls.Add(this.OldDropPcklbl);
            this.groupBox3.Controls.Add(this.OldPingTimelbl);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 96);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(340, 404);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Results";
            // 
            // OldJitter
            // 
            this.OldJitter.AutoSize = true;
            this.OldJitter.Location = new System.Drawing.Point(214, 162);
            this.OldJitter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OldJitter.Name = "OldJitter";
            this.OldJitter.Size = new System.Drawing.Size(24, 25);
            this.OldJitter.TabIndex = 5;
            this.OldJitter.Text = "0";
            // 
            // OldDropPcklbl
            // 
            this.OldDropPcklbl.AutoSize = true;
            this.OldDropPcklbl.Location = new System.Drawing.Point(214, 112);
            this.OldDropPcklbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OldDropPcklbl.Name = "OldDropPcklbl";
            this.OldDropPcklbl.Size = new System.Drawing.Size(24, 25);
            this.OldDropPcklbl.TabIndex = 4;
            this.OldDropPcklbl.Text = "0";
            // 
            // OldPingTimelbl
            // 
            this.OldPingTimelbl.AutoSize = true;
            this.OldPingTimelbl.Location = new System.Drawing.Point(214, 60);
            this.OldPingTimelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OldPingTimelbl.Name = "OldPingTimelbl";
            this.OldPingTimelbl.Size = new System.Drawing.Size(113, 25);
            this.OldPingTimelbl.TabIndex = 3;
            this.OldPingTimelbl.Text = "Loading ...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Jitter: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Droped Packets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ping: ";
            // 
            // OptionList
            // 
            this.OptionList.CheckOnClick = true;
            this.OptionList.FormattingEnabled = true;
            this.OptionList.Items.AddRange(new object[] {
            "TCP No Delay",
            "TCP Window Size",
            "IRP Stack Size",
            "Local Priority",
            "Max Connect Back Log",
            "Max Free TCB",
            "Max User Ports",
            "Network Throttling",
            "Non Best Effort Limit",
            "TCP OPT",
            "TCP Ack Frequency",
            "TCP Timed Wait Delay"});
            this.OptionList.Location = new System.Drawing.Point(12, 33);
            this.OptionList.Margin = new System.Windows.Forms.Padding(6);
            this.OptionList.Name = "OptionList";
            this.OptionList.Size = new System.Drawing.Size(450, 200);
            this.OptionList.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.OptionList);
            this.groupBox5.Location = new System.Drawing.Point(300, 23);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(478, 267);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Options";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(787, 113);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(548, 47);
            this.progressBar1.TabIndex = 7;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 865);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainScreen";
            this.Text = "Better Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdMan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAuto;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox OptionList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label OldPingTimelbl;
        private System.Windows.Forms.Label OldDropPcklbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label IpLable;
        private System.Windows.Forms.Label OldJitter;
        private System.Windows.Forms.ListBox PingHistory;
    }
}

