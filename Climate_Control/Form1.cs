using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Climate_Control
{
    public partial class Form1 : Form
    {
        String[] args;


        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private string stroka = "";

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(DoUpdate));
        }
        private void DoUpdate(object s, EventArgs e)
        {
            stroka = stroka + serialPort1.ReadLine();
            args = stroka.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                //MessageBox.Show(stroka);
                HumidityV.Text = args[0].Substring(args[0].IndexOf(":") + 2) + "%";
                SrTempV.Text = args[1].Substring(args[1].IndexOf(":") + 2) + "°C";
                AngleV.Text = args[4].Substring(8);
                ClosedV.Text = args[5].Substring(args[5].IndexOf(":") + 2);
                HotTempV.Text = args[2] + "°C";
                WindowTempV.Text = args[3] + "°C";
                CycleV.Text = args[6];
                NeedTempV.Text = args[7].Substring(args[7].IndexOf(":") + 2) + "°C";
                CycleAllV.Text = args[8];
                stroka = "";
                if (ClosedV.Text == "true" && AngleV.Text == "180")
                {
                    CloseWindow.Checked = true;
                }
                else
                {
                    CloseWindow.Checked = false;
                }
            }
            catch
            {
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                serialPort1.PortName = "COM4";
                serialPort1.BaudRate = 9600;
                serialPort1.Open();

                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
            }
            catch
            {
                MessageBox.Show("Что-то тут не так...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            HumidityV.Text = "null";
            SrTempV.Text = "null";
            AngleV.Text = "null";
            ClosedV.Text = "null";
            HotTempV.Text = "null";
            WindowTempV.Text = "null";
            CycleV.Text = "null";
            NeedTempV.Text = "null";
            CycleAllV.Text = "null";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("+");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("-");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("*");
        }
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            serialPort1.WriteLine("1");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.WriteLine("2");
        }
    }
}
