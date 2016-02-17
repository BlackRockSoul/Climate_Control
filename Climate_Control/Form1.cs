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
                label15.Text = args[0].Substring(args[0].IndexOf(":") + 2);
                label5.Text = args[1].Substring(args[1].IndexOf(":") + 2);
                label10.Text = args[4].Substring(8);
                label12.Text = args[5].Substring(args[5].IndexOf(":") + 2);
                label7.Text = args[2];
                label6.Text = args[3];
                label17.Text = args[6];
                label20.Text = args[7].Substring(args[7].IndexOf(":") + 2);
                label21.Text = args[8];
                stroka = "";
                if (label12.Text == "true" && label10.Text == "180")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
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
            label15.Text = "null";
            label5.Text = "null";
            label10.Text = "null";
            label12.Text = "null";
            label7.Text = "null";
            label6.Text = "null";
            label17.Text = "null";
            label20.Text = "null";
            label21.Text = "null";
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
