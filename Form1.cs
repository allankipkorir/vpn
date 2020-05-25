using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace vpn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Server" && udp_radiobtn.Checked)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = "--config LondonUDP.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("Connected to server with UDP");
            } 
            else if (comboBox1.Text == "Server" && tcp_radiobtn.Checked)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"C:\Program Files\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = "--config LondonTCP.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("Connected to server with TCP");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disconnect();
            MessageBox.Show("You've disconnected from the server");
        }

        private void disconnect()
        {
            Process.Start(new ProcessStartInfo 
            { 
                FileName = "taskkill",
                Arguments = $"/f /im openvpn.exe",
                CreateNoWindow = true,
                UseShellExecute = false

            }).WaitForExit();
        }
    }
}
