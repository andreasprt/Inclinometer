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
        public bool TextWasChanged = false;
        string serialDataIn, serialDataIn2, serialDataIn3;
        int indexOfX, indexOfY, indexOfZ, indexOfS, indexOfSS, indexOfR, indexOfP;
        string dataSensor1, dataSensor2, dataSensor3, dataSensor4, dataSensor5, R, set, sett;
        char linefeed = (char)10;
        StringBuilder sb = new StringBuilder();
        private SaveFileDialog sfd;

        private SerialPort port;
        private SerialPort port2;
        Double z1, z2, x, y;

        Double z_axis, x_axis, y_axis;

        Double zx1 = 0, x1 = 0, zy1 = 0, y1 = 0;

        private void allC2_Click(object sender, EventArgs e)
        {
            chart2.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(tbox_c2xmax.Text);
            chart2.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(tbox_c2ymax.Text);

        }

        private void magicButton5_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(tbox_c1xmax.Text);
            chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(tbox_c1ymax.Text);

        }

        Double zx2, x2, zy2, y2;


        string dtraw;
        private void magicButton3_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            tbox_c1xmax.Clear();
            tbox_c1ymax.Clear();
            tbox_c2xmax.Clear();
            tbox_c2ymax.Clear();
            dataGridView1.Rows.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(AutoScaleMode);
            chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(AutoScaleMode);
            chart2.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(AutoScaleMode);
            chart2.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(AutoScaleMode);
        }

        private void buttonsetx_c1_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(tbox_c1xmax.Text);
        }

        private void buttonsety_c1_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(tbox_c1ymax.Text);
        }

        private void buttonsetx_c2_Click(object sender, EventArgs e)
        {
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(tbox_c2xmax.Text);
        }

        private void buttonsety_c2_Click(object sender, EventArgs e)
        {
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(tbox_c2ymax.Text);

        }

        private void magicButton2_Click(object sender, EventArgs e)
        {
/*
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            sfd.Title = "Save Data as";
            if (sfd.ShowDialog() == DialogResult.OK)

                // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
              {
                  TextWriter writer = new StreamWriter(sfd.FileName);
                  for (int i = 0; i <= dataGridView1.Rows.Count - 2; i++)
                  {
                      for (int j = 0; j <= dataGridView1.Columns.Count - 1; j++)
                      {

                          writer.Write(('\t' + (dataGridView1.Rows[i].Cells[j].Value.ToString() + ('\t' + "|"))));
                      }

                      writer.WriteLine("");
                  }
                  writer.Close();
                  MessageBox.Show("Berhasil di Export");

              }*/
            


            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];

                            for (int i = 0; i <= dataGridView1.Rows.Count - 2; i++)
                            {
                                for (int j = 0; j <= dataGridView1.Columns.Count - 1; j++)
                                {

                                    outputCsv[i] += '\t' + dataGridView1.Rows[i].Cells[j].Value.ToString() + '\t' + "|";
                                }

                               
                            }

                            /*
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i  < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            */

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }

        private void magicButton4_Click(object sender, EventArgs e)
        {

            serialDataIn3 = textBox1.Text;
            this.BeginInvoke(new EventHandler(ProcessData3));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextWasChanged = true;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn3 = serialPort1.ReadLine();
            //dtraw = serialPort1.ReadExisting();
            this.BeginInvoke(new EventHandler(ProcessData3));
           
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            sfd = new SaveFileDialog();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            gunaCircleButton1.Enabled = true;
            gunaCircleButton2.Enabled = false;
            Indikator.Value = 0;
            if (serialPort1.IsOpen == false)
            {
                chart1.Series["X-Z"].Points.AddXY(0, 0);
                chart2.Series["Y-Z"].Points.AddXY(0, 0);
            }
            textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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

                while (serialPort1.IsOpen == false)
                {
                    MessageBox.Show("ENTENONO ");
                }
                MessageBox.Show("WES MARI LOADING, SOK GAS");
                Indikator.Value = 100;
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
        private void magicButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            serialPort1.Close();
        }

        private void gunaComboBox1_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            gunaComboBox1.Items.Clear();
            gunaComboBox1.Items.AddRange(portLists);
        }
        private void ProcessData3(object sender, EventArgs e)
        {
            
            /*foreach (char c in serialDataIn3)
            {
                if (c == linefeed)
                {
                    sb.Append(c);

                    serialDataIn3 = sb.ToString();
                    sb.Clear();

                }
                else
                {
                    sb.Append(c);
                }
            }*/
            try
            {
                indexOfX = Convert.ToSByte(serialDataIn3.IndexOf("X"));
                indexOfY = Convert.ToSByte(serialDataIn3.IndexOf("Y"));
                indexOfR = Convert.ToSByte(serialDataIn3.IndexOf("R"));
                indexOfP = Convert.ToSByte(serialDataIn3.IndexOf("P"));
                indexOfS = Convert.ToSByte(serialDataIn3.IndexOf("Set"));

                dataSensor1 = serialDataIn3.Substring(0, indexOfX); 
                dataSensor2 = serialDataIn3.Substring(indexOfX + 1, (indexOfY - indexOfX) - 1); // yaw
                dataSensor3 = serialDataIn3.Substring(indexOfY + 1, (indexOfR - indexOfY) - 1); // pitch
                dataSensor4 = serialDataIn3.Substring(indexOfR + 1, (indexOfP - indexOfR) - 1); // roll
                dataSensor5 = serialDataIn3.Substring(indexOfP + 1, (indexOfS - indexOfP) - 1); // encoder

                textBox2.Text = dataSensor5;

                zx2 = zx1 - (Double.Parse(dataSensor5) * Math.Sin((Double.Parse(dataSensor2) + 90) * 3.14 / 180));
                x2 = x1 - (Double.Parse(dataSensor5) * Math.Cos((Double.Parse(dataSensor2) + 90) * 3.14 / 180));
                zx1 = zx2;
                x1 = x2;

                zy2 = zy1 - (Double.Parse(dataSensor5) * Math.Sin((Double.Parse(dataSensor4) + 90) * 3.14 / 180));
                y2 = y1 - (Double.Parse(dataSensor5) * Math.Cos((Double.Parse(dataSensor4) + 90) * 3.14 / 180));
                zy1 = zy2;
                y1 = y2;

                chart1.Series["X-Z"].Points.AddXY(zx2, x2);
                chart2.Series["Y-Z"].Points.AddXY(y2, -zy2);


                if (TextWasChanged)
                {
                    int no = 0;
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = "X " + x2;
                    newRow.Cells[1].Value = "ZX " + zx2;
                    newRow.Cells[2].Value = "Y " + y2;
                    newRow.Cells[3].Value = "ZY " + zy2;
                    newRow.Cells[4].Value = "DX " + dataSensor2;
                    newRow.Cells[5].Value = "DY " + dataSensor4;
                    newRow.Cells[6].Value = "DZ " + dataSensor5;
                    newRow.Cells[7].Value = (DateTime.Now.ToLongDateString() + ", Pukul " + DateTime.Now.ToString("HH:mm"));
                    dataGridView1.Rows.Add(newRow);
                }
                //string timeku = (DateTime.Now.ToLongDateString() + ", Pukul " + DateTime.Now.ToString("HH:mm") + " WIB");
                
                

                //textBox1.Text = "X " + x2 + " ZX " + zx2 + " Y " + y2 + " YX " + zy2;

            }
            catch (Exception error)
            {
               
            }
        }
        
    }
}
