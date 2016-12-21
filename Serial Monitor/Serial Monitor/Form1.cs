using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;
using System.Threading;

namespace ZKI
{
    public partial class Form1 : Form
    {
        string InputData = String.Empty; 
        delegate void SetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
        }
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadExisting();
            if (InputData != String.Empty)
            {
                if (autoscroll.Checked == false)
                {
                    SetText1(InputData);
                }
                else
                {
                    SetText(InputData);
                }
            }

        }
        private void SetText(string text)
        {
            if (this.text_Receiver.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else this.text_Receiver.AppendText(text);
        }
        private void SetText1(string text)
        {
            if (this.text_Receiver.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText1);
                this.Invoke(d, new object[] { text });
            }
            else this.text_Receiver.Text += text;
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int intlen = 0; // so Port com
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if(intlen!=ports.Length)
            {
                intlen = ports.Length;
                select_com.Items.Clear();
                for(int j=0; j<intlen; j++)
                {
                    select_com.Items.Add(ports[j]);
                }

            }
        }
        private void BT_connect_Click(object sender, EventArgs e)
        {
            if (select_com.Text == "" || BaudRate.Text == "")
            {
                text_send.Text = "Please select Port Name and Baud Rate then Connect";
            }
            else
            {
                if (Status_lable1.Text == "Disconnect")
                {
                    serialPort1.PortName = select_com.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BaudRate.Text);
                    serialPort1.Open();
                    Status.Value = 100;
                    BT_connect.Text = "Disconnect";
                    Status_lable1.Text = "Connect";
                    text_send.Clear();
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    autoscroll.Enabled = true;
                    clearall.Enabled = true;
                    BT_Send.Enabled = true;
                    bt_read.Enabled = true;
                    bt_write.Enabled = true;
                }
                else
                {
                    serialPort1.Close();
                    Status.Value = 0;
                    BT_connect.Text = "Connect";
                    Status_lable1.Text = "Disconnect";
                    groupBox3.Enabled = false;
                    groupBox4.Enabled = false;
                    autoscroll.Enabled = false;
                    clearall.Enabled = false;
                    BT_Send.Enabled = false;
                    bt_read.Enabled = false;
                    bt_write.Enabled = false;
                }
            }
        }
        

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        static string ConvertStringArrayToString(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append("");
            }
            return builder.ToString();
        }
        static string ConvertStringArrayToStringJoin(string[] array)
        {
            string result = string.Join("", array);
            return result;
        }
        private void BT_Send_Click(object sender, EventArgs e)
        {
            string s;
            if(Status_lable1.Text == "Connect")
            {
                s = text_send.Text;
               serialPort1.WriteLine(s);
                text_send.Clear();
            }
            else
            {
                text_send.Text = "Please select Port Name and Baud Rate then Connect";
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Application.Exit();
        }
        private async void opendata_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Document|*.txt", ValidateNames = true, Multiselect=false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        text_send.Text = await sr.ReadToEndAsync();
                    }
                }
            }
        }

        private async void bt_write_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd =new SaveFileDialog() { Filter = "Text Document|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using(StreamWriter sw=new StreamWriter(sfd.FileName))
                    {
                        
                        await sw.WriteLineAsync(text_Receiver.Text);

                        MessageBox.Show("you have ben successfully saved","message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void clearall_Click(object sender, EventArgs e)
        {
            text_Receiver.Clear();
            text_send.Clear();
        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void text_send_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void select_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}