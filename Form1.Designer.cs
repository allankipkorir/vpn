namespace vpn
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.udp_radiobtn = new System.Windows.Forms.RadioButton();
            this.connect_btn = new System.Windows.Forms.Button();
            this.tcp_radiobtn = new System.Windows.Forms.RadioButton();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Server"});
            this.comboBox1.Location = new System.Drawing.Point(210, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 39);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select your server";
            // 
            // udp_radiobtn
            // 
            this.udp_radiobtn.AutoSize = true;
            this.udp_radiobtn.Location = new System.Drawing.Point(221, 107);
            this.udp_radiobtn.Name = "udp_radiobtn";
            this.udp_radiobtn.Size = new System.Drawing.Size(111, 36);
            this.udp_radiobtn.TabIndex = 2;
            this.udp_radiobtn.TabStop = true;
            this.udp_radiobtn.Text = "UDP";
            this.udp_radiobtn.UseVisualStyleBackColor = true;
            this.udp_radiobtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(210, 172);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(352, 63);
            this.connect_btn.TabIndex = 3;
            this.connect_btn.Text = "connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // tcp_radiobtn
            // 
            this.tcp_radiobtn.AutoSize = true;
            this.tcp_radiobtn.Location = new System.Drawing.Point(454, 107);
            this.tcp_radiobtn.Name = "tcp_radiobtn";
            this.tcp_radiobtn.Size = new System.Drawing.Size(108, 36);
            this.tcp_radiobtn.TabIndex = 4;
            this.tcp_radiobtn.TabStop = true;
            this.tcp_radiobtn.Text = "TCP";
            this.tcp_radiobtn.UseVisualStyleBackColor = true;
            this.tcp_radiobtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Location = new System.Drawing.Point(210, 264);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(357, 63);
            this.disconnect_btn.TabIndex = 5;
            this.disconnect_btn.Text = "disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.disconnect_btn);
            this.Controls.Add(this.tcp_radiobtn);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.udp_radiobtn);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "vpn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton udp_radiobtn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.RadioButton tcp_radiobtn;
        private System.Windows.Forms.Button disconnect_btn;
    }
}

