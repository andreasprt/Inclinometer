using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO.Ports;
using System.IO;

namespace Inclinometer
{
    public partial class Form1 : Form
    {
        string serialDataIn;
        int indexOfX, indexOfY, indexOfP, indexOfR, indexOfS;
        string dataSensor1, dataSensor2, dataSensor3, dataSensor4, dataSensor5;

        Double zx1 = 0, x1 = 0, zy1 = 0, y1 = 0;
        Double zx2, x2, zy2, y2;
        private void magicButton3_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0,0);
            this.Size = new Size(w, h);
            gunaCircleButton1.Enabled = true;
            gunaCircleButton2.Enabled = false;
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = gunaComboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32("9600");
                serialPort1.Open();

                gunaCircleButton1.Enabled = false;
                gunaCircleButton2.Enabled = true;
                magicButton3.Enabled = true;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                gunaCircleButton1.Enabled = true;
                gunaCircleButton2.Enabled = false;
                
                magicButton3.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void gunaComboBox1_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            gunaComboBox1.Items.Clear();
            gunaComboBox1.Items.AddRange(portLists);
        }

        private void magicButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            serialPort1.Close();
        }
        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indexOfX = Convert.ToSByte(serialDataIn.IndexOf("X"));
                indexOfY = Convert.ToSByte(serialDataIn.IndexOf("Y"));
                indexOfR = Convert.ToSByte(serialDataIn.IndexOf("R"));
                indexOfP = Convert.ToSByte(serialDataIn.IndexOf("P"));
                indexOfS = Convert.ToSByte(serialDataIn.IndexOf("SetA"));

                dataSensor1 = serialDataIn.Substring(0, indexOfX);
                dataSensor2 = serialDataIn.Substring(indexOfX + 1, (indexOfY - indexOfX) - 1);
                dataSensor3 = serialDataIn.Substring(indexOfY + 1, (indexOfR - indexOfY) - 1);
                dataSensor4 = serialDataIn.Substring(indexOfR + 1, (indexOfP - indexOfR) - 1);
                dataSensor5 = serialDataIn.Substring(indexOfP + 1, (indexOfS - indexOfP) - 1);

                zx2 = zx1 - (Double.Parse(dataSensor5) * Math.Sin((Double.Parse(dataSensor2) + 90) * 3.14 / 180));
                x2 = x1 - (Double.Parse(dataSensor5) * Math.Cos((Double.Parse(dataSensor2) + 90) * 3.14 / 180));
                zx1 = zx2;
                x1 = x2;

                zy2 = zy1 - (Double.Parse(dataSensor5) * Math.Sin((Double.Parse(dataSensor3) + 90) * 3.14 / 180));
                y2 = y1 - (Double.Parse(dataSensor5) * Math.Cos((Double.Parse(dataSensor3) + 90) * 3.14 / 180));
                zy1 = zy2;
                y1 = y2;

                chart1.Series["X-Z"].Points.AddXY(x2, zx2);
                chart2.Series["Y-Z"].Points.AddXY(y2, zy2);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
