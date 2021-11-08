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

namespace INCgui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        StringBuilder sb = new StringBuilder();

        public bool TextWasChanged = false;
        string[] portNames = System.IO.Ports.SerialPort.GetPortNames();
        string serial1poll, serialraw;
        string dtraw, dtx, dty, dtz, dtr;
        int zaxis, panjangdata;

        public delegate void transfer();
        char linefeed = (char)10;
        byte[] terima;
        double disX = 0, disY = 0, disX_lama = 0, disY_lama = 0;
        double phi = Math.PI;

        Double z1, z2, x, y;

        Double z_axis, x_axis, y_axis;

        Double zx1 = 0, x1 = 0, zy1 = 0, y1 = 0;

        private void magicButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "TGU (*.tgu)|*.tgu";
                sfd.FileName = "INC1.tgu";
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
                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Sukses Di Eksport");
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
                MessageBox.Show("No Data");
            }
        }

        private void magicButton4_Click(object sender, EventArgs e)
        {
            //tbox_c1xmin.Text = " ";
            //tbox_c2xmax.Text = " ";
            //tbox_c1ymin.Text = " ";
            //tbox_c2ymax.Text = " ";
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

           // chart2.Series[0].Points.Clear();
           // chart2.Series[1].Points.Clear();

            //chart3.Series[0].Points.Clear();
            //chart3.Series[1].Points.Clear();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            disX_lama = disX = disY_lama = disY =0;
        }

        private void buttonsetx_c1_Click(object sender, EventArgs e)
        {
            try
            {

                chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(tbox_c1xmin.Text);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonsetx_c2_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(tbox_c1xmin.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text != "")
            {
                int a = Convert.ToInt32(textBox4.Text);

                double angle = (a * (Math.PI)) / 180;

                textBox2.Text = (Math.Cos(angle)).ToString();
                textBox3.Text = (Math.Sin(angle)).ToString();
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void chart2_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonsety_c1_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(tbox_c1ymin.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonsety_c2_Click(object sender, EventArgs e)
        {
            try 
            {
                chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(tbox_c2ymax.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextWasChanged = true;
        }

        Double zx2, x2, zy2, y2;
        private void Form1_Load(object sender, EventArgs e)
        {
            magicButton1.Enabled = true;
            magicButton2.Enabled = false;
            Indikator.Value = 0;
            zaxis = 0;
            serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);
            //serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(bw_DoWork);

            for (int i = 0; i <= portNames.Length - 1; i++)
            {

                guna2ComboBox1.Items.Add(portNames[i]);
            }

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            chart1.ChartAreas[0].AxisY.IsReversed = true;

            //0chart1.Series["X"].Points.AddXY(0, 3);
            //chart1.Series["Y"].Points.AddXY(4, 8);

            textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        }
        private void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            zaxis++;
            rtf1.BeginInvoke(new transfer(Proses));

        }

        private void magicButton1_Click(object sender, EventArgs e)
        {

            try
            {

                serial.PortName = guna2ComboBox1.Text;
                serial.BaudRate = Convert.ToInt32("9600");
                serial.Open();

                magicButton1.Enabled = false;
                magicButton2.Enabled = true;

                /*while (serial.IsOpen == false)
                {
                    MessageBox.Show("ENTENONO ");
                }
                MessageBox.Show("WES MARI LOADING, SOK GAS");*/
                Indikator.Value = 100;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void magicButton2_Click(object sender, EventArgs e)
        {
            try
            {

                serial.Close();
                magicButton1.Enabled = true;
                magicButton2.Enabled = false;
                Indikator.Value = 0;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            serial.Close();
        }

        private void guna2ComboBox1_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.AddRange(portLists);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void magicButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            serial.Close();
        }

        private void magicButton6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label8_Paint(object sender, PaintEventArgs e)
        {
            Font myFont = new Font("Microsoft Sans Serif", 11);
            Brush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            e.Graphics.TranslateTransform(30, 170);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Sumbu Z (cm)", myFont, myBrush, 0, 0);
        }


        private void Proses()
        {
            try
            {
                serial1poll = serial.ReadExisting();
                olah_str();
            }
            catch { }

        }
        
        public void olah_str()
        {
            foreach (char c in serial1poll)
            {
                if (c == linefeed)
                {
                    


                    sb.Append(c);

                    dtraw = sb.ToString();
                    sb.Clear();

                    try
                    {
                        string[] dtbuff = dtraw.Split('#', '\n');

                        dtx = dtbuff[0]; // x
                        dty = dtbuff[1]; // 
                        dtz = dtbuff[2]; // y
                        dtr = dtbuff[3]; // encoder
                       // int kedalaman = Convert.ToInt32(dtbuff[3]);


                        int probe = 1; // panjang probe 1 cm
                       // double angleX = (Convert.ToInt32(dtbuff[1]) * (Math.PI)) / 180;
                        //double angleY = (Convert.ToInt32(dtbuff[2]) * (Math.PI)) / 180;

                        disX = disX_lama + (probe * Math.Sin((Convert.ToInt32(dtbuff[1]) * phi) / 180));
                        disX_lama = disX;

                        disY = disY_lama + (probe * Math.Sin((Convert.ToInt32(dtbuff[2]) * phi) / 180));
                        disY_lama = disY;


                        double kedalaman = Double.Parse(dtbuff[3]);

                        textBox4.Text = kedalaman.ToString();
                        textBox2.Text = disX_lama.ToString();
                        textBox3.Text = disY_lama.ToString();

                        if (disX_lama == 0 || disY_lama == 0)
                        {
                            chart1.Series["X"].Points.AddXY(0.000000001, kedalaman);
                            chart1.Series["Y"].Points.AddXY(0.000000001, kedalaman);
                        }
                        else
                        {
                            chart1.Series["X"].Points.AddXY(disX_lama, kedalaman);
                            chart1.Series["Y"].Points.AddXY(disY_lama, kedalaman);
                        }
                        

                        /*
                       zx2 = zx1 - (Double.Parse(dtbuff[3]) * Math.Sin((Double.Parse(dtbuff[0]) + 90) * 3.14 / 180));
                       x2 = x1 - (Double.Parse(dtbuff[3]) * Math.Cos((Double.Parse(dtbuff[0]) + 90) * 3.14 / 180));

                       zx1 = zx2;
                       x1 = x2;

                       zy2 = zy1 - (Double.Parse(dtbuff[3]) * Math.Sin((Double.Parse(dtbuff[2]) + 90) * 3.14 / 180));
                       y2 = y1 - (Double.Parse(dtbuff[3]) * Math.Cos((Double.Parse(dtbuff[2]) + 90) * 3.14 / 180));
                       zy1 = zy2;
                       y1 = y2;

                        chart1.Series["X"].Points.AddXY(zx2, x2);
                       chart1.Series["Y"].Points.AddXY(zx2, y2);
                        */



                        if (TextWasChanged)
                       {
                            int no = 0;
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataGridView1);
                            newRow.Cells[0].Value = "X " + disX;
                            newRow.Cells[1].Value = "ZX " + disX_lama;//1
                            newRow.Cells[2].Value = "Y " + disY;
                            newRow.Cells[3].Value = "ZY " + disY_lama;//2
                            newRow.Cells[4].Value = "DX " + dtbuff[1];
                            newRow.Cells[5].Value = "DY " + dtbuff[2];
                            newRow.Cells[6].Value = "DZ " + dtbuff[3];
                            newRow.Cells[7].Value = "Time " + (DateTime.Now.ToLongDateString() + ", Pukul " + DateTime.Now.ToString("HH:mm:ss:ff"));
                            dataGridView1.Rows.Add(newRow);

                        }



                        /*zx2 = zx1 - (Double.Parse(dtbuff[3]) * Math.Sin((Double.Parse(dtbuff[0]) + 90) * 3.14 / 180));
                        x2 = x1 - (Double.Parse(dtbuff[3]) * Math.Cos((Double.Parse(dtbuff[0]) + 90) * 3.14 / 180));

                        zx1 = zx2;
                        x1 = x2;

                        zy2 = zy1 - (Double.Parse(dtbuff[3]) * Math.Sin((Double.Parse(dtbuff[2]) + 90) * 3.14 / 180));
                        y2 = y1 - (Double.Parse(dtbuff[3]) * Math.Cos((Double.Parse(dtbuff[2]) + 90) * 3.14 / 180));
                        zy1 = zy2;
                        y1 = y2;

                        chart1.Series["X"].Points.AddXY(zx2, x2);
                        chart1.Series["Y"].Points.AddXY(zx2, y2);

                        if (TextWasChanged)
                        {
                            int no = 0;
                            DataGridViewRow newRow = new DataGridViewRow();
                            newRow.CreateCells(dataGridView1);
                            newRow.Cells[0].Value = "X " + x2;
                            newRow.Cells[1].Value = "ZX " + zx2;
                            newRow.Cells[2].Value = "Y " + y2;
                            newRow.Cells[3].Value = "ZY " + zy2;
                            newRow.Cells[4].Value = "DX " + dtbuff[0];
                            newRow.Cells[5].Value = "DY " + dtbuff[2];
                            newRow.Cells[6].Value = "DZ " + dtbuff[3];
                            newRow.Cells[7].Value = "Time " + (DateTime.Now.ToLongDateString() + ", Pukul " + DateTime.Now.ToString("HH:mm:ss:ff"));
                            dataGridView1.Rows.Add(newRow);
                        }*/

                    }
                    catch { }


                }
                else
                {
                    sb.Append(c);
                }
            }
        }

    }
}
