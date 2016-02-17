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
                SrTempV.Text = args[0] + "°С";
                WindowTempV.Text = args[1] + "°С";
                HotTempV.Text = args[2] + "°С";
                NeedTempV.Text = args[3] + "°С";
                HumiditySrV.Text = args[4] + "%";
                HumidityWindowV.Text = args[5] + "%";
                HumidityHotV.Text = args[6] + "%";
                AngleV.Text = args[7] + "°";
                ClosedV.Text = args[8];
                OpenedV.Text = args[9];
                CycleV.Text = args[10];
                CyclesV.Text = args[11];
                CycleComplV.Text = args[12];
                CycleAllV.Text = args[13];

                stroka = "";

                if (ClosedV.Text == "true") CloseWindow.Checked = true; else CloseWindow.Checked = false;
                if (OpenedV.Text == "true") OpenWindow.Checked = true; else OpenWindow.Checked = false;

            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { if (serialPort1.IsOpen) serialPort1.Close(); } catch { }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = "COM4";
                serialPort1.BaudRate = 9600;
                serialPort1.Open();

                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
            }
            catch
            { MessageBox.Show("Что-то сломалось..."); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            SrTempV.Text = "null";
            WindowTempV.Text = "null";
            HotTempV.Text = "null";
            NeedTempV.Text = "null";
            HumiditySrV.Text = "null";
            HumidityWindowV.Text = "null";
            HumidityHotV.Text = "null";
            AngleV.Text = "null";
            ClosedV.Text = "null";
            OpenedV.Text = "null";
            CycleV.Text = "null";
            CyclesV.Text = "null";
            CycleComplV.Text = "null";
            CycleAllV.Text = "null";

            CloseWindow.Checked = false;
            OpenWindow.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("+");
                serialPort1.WriteLine("");
            }
            catch { MessageBox.Show("Ошибка"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("-");
                serialPort1.WriteLine("");
            }
            catch { MessageBox.Show("Ошибка"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("/");
                serialPort1.WriteLine("");
            }
            catch { MessageBox.Show("Ошибка"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("*");
                serialPort1.WriteLine("");
            }
            catch { MessageBox.Show("Ошибка"); }
        }
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("1");
                serialPort1.WriteLine("");
            }
            catch { MessageBox.Show("Ошибка"); }
        }

        private void OpenWindow_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.WriteLine("2");
                serialPort1.WriteLine("");
            }
            catch { MessageBox.Show("Ошибка"); }
        }
    }
}
