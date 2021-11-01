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

namespace Inclinometer
{
    public partial class Form1 : Form
    {
        string serialDataIn;
        int indexOfX, indexOfY, indexOfZ, indexOfS;
        string dataSensor1, dataSensor2, dataSensor3, set;
        
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
            chart1.ChartAreas[0].AxisY.IsReversed = true;
            chart2.ChartAreas[0].AxisY.IsReversed = true;
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
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            serialDataIn = textBox3.Text;
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indexOfX = Convert.ToSByte(serialDataIn.IndexOf("X"));
                indexOfY = Convert.ToSByte(serialDataIn.IndexOf("Y"));
                indexOfZ = Convert.ToSByte(serialDataIn.IndexOf("Z"));
                indexOfS = Convert.ToSByte(serialDataIn.IndexOf("Set"));

                dataSensor1 = serialDataIn.Substring(0, indexOfX);
                dataSensor2 = serialDataIn.Substring(indexOfX + 1, (indexOfY - indexOfX) - 1);
                dataSensor3 = serialDataIn.Substring(indexOfY + 1, (indexOfZ - indexOfY) - 1);
                set = serialDataIn.Substring(indexOfZ + 1, (indexOfS - indexOfZ) - 1);

                gunatextBox1.Text = dataSensor2;
                gunatextBox2.Text = dataSensor3;
                gunatextBox3.Text = set;
                //textBox5.Text = Convert.ToString (indexOfS);

                chart1.Series["X-Z"].Points.AddXY(int.Parse(gunatextBox3.Text), int.Parse(gunatextBox1.Text));
                chart2.Series["Y-Z"].Points.AddXY(int.Parse(gunatextBox3.Text), int.Parse(gunatextBox2.Text));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
