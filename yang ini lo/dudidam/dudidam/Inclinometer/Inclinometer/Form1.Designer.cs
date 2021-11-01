namespace Inclinometer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.magicButton1 = new MagicUI.MagicControl.MagicButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaCircleButton2 = new Guna.UI.WinForms.GunaCircleButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.magicButton3 = new MagicUI.MagicControl.MagicButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbox_c1xmax = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_c1ymax = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_c2ymax = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_c2xmax = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonsetx_c1 = new MagicUI.MagicControl.MagicButton();
            this.buttonsety_c1 = new MagicUI.MagicControl.MagicButton();
            this.buttonsety_c2 = new MagicUI.MagicControl.MagicButton();
            this.buttonsetx_c2 = new MagicUI.MagicControl.MagicButton();
            this.Indikator = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.magicButton2 = new MagicUI.MagicControl.MagicButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.magicButton4 = new MagicUI.MagicControl.MagicButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allC1 = new MagicUI.MagicControl.MagicButton();
            this.allC2 = new MagicUI.MagicControl.MagicButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.kuning = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.biru = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.kuning.SuspendLayout();
            this.biru.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(15, 16);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Y-Z";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(440, 354);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // magicButton1
            // 
            this.magicButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.magicButton1.BackColor = System.Drawing.Color.Green;
            this.magicButton1.BackgroundColor = System.Drawing.Color.Green;
            this.magicButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.magicButton1.BorderRadius = 8;
            this.magicButton1.BorderSize = 0;
            this.magicButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton1.FlatAppearance.BorderSize = 0;
            this.magicButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicButton1.ForeColor = System.Drawing.Color.White;
            this.magicButton1.Location = new System.Drawing.Point(1253, 565);
            this.magicButton1.Name = "magicButton1";
            this.magicButton1.Size = new System.Drawing.Size(101, 28);
            this.magicButton1.TabIndex = 13;
            this.magicButton1.Text = "Exit";
            this.magicButton1.TextColor = System.Drawing.Color.White;
            this.magicButton1.UseVisualStyleBackColor = false;
            this.magicButton1.Click += new System.EventHandler(this.magicButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(458, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 78);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inclinometer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1262, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1224, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.Green;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.White;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Quality = 100;
            this.gunaGradientPanel1.Size = new System.Drawing.Size(107, 606);
            this.gunaGradientPanel1.TabIndex = 21;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(162, 44);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 8;
            this.gunaComboBox1.Size = new System.Drawing.Size(100, 26);
            this.gunaComboBox1.TabIndex = 22;
            this.gunaComboBox1.DropDown += new System.EventHandler(this.gunaComboBox1_DropDown);
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.Image = null;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(268, 46);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(24, 24);
            this.gunaCircleButton1.TabIndex = 23;
            this.gunaCircleButton1.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // gunaCircleButton2
            // 
            this.gunaCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton2.AnimationSpeed = 0.03F;
            this.gunaCircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton2.ForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton2.Image = null;
            this.gunaCircleButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton2.Location = new System.Drawing.Point(298, 46);
            this.gunaCircleButton2.Name = "gunaCircleButton2";
            this.gunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton2.OnHoverImage = null;
            this.gunaCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton2.Size = new System.Drawing.Size(24, 24);
            this.gunaCircleButton2.TabIndex = 24;
            this.gunaCircleButton2.Click += new System.EventHandler(this.gunaCircleButton2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(158, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Connection";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(482, 509);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 78);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // magicButton3
            // 
            this.magicButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.magicButton3.BackColor = System.Drawing.Color.Green;
            this.magicButton3.BackgroundColor = System.Drawing.Color.Green;
            this.magicButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.magicButton3.BorderRadius = 8;
            this.magicButton3.BorderSize = 0;
            this.magicButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton3.FlatAppearance.BorderSize = 0;
            this.magicButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.magicButton3.ForeColor = System.Drawing.Color.White;
            this.magicButton3.Location = new System.Drawing.Point(1137, 482);
            this.magicButton3.Name = "magicButton3";
            this.magicButton3.Size = new System.Drawing.Size(52, 22);
            this.magicButton3.TabIndex = 45;
            this.magicButton3.Text = "Clear";
            this.magicButton3.TextColor = System.Drawing.Color.White;
            this.magicButton3.UseVisualStyleBackColor = false;
            this.magicButton3.Click += new System.EventHandler(this.magicButton3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(965, 571);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 46;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_c1xmax
            // 
            this.tbox_c1xmax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbox_c1xmax.BorderRadius = 15;
            this.tbox_c1xmax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_c1xmax.DefaultText = "";
            this.tbox_c1xmax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_c1xmax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_c1xmax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c1xmax.DisabledState.Parent = this.tbox_c1xmax;
            this.tbox_c1xmax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c1xmax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c1xmax.FocusedState.Parent = this.tbox_c1xmax;
            this.tbox_c1xmax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_c1xmax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c1xmax.HoverState.Parent = this.tbox_c1xmax;
            this.tbox_c1xmax.Location = new System.Drawing.Point(218, 500);
            this.tbox_c1xmax.Name = "tbox_c1xmax";
            this.tbox_c1xmax.PasswordChar = '\0';
            this.tbox_c1xmax.PlaceholderText = "";
            this.tbox_c1xmax.SelectedText = "";
            this.tbox_c1xmax.ShadowDecoration.Parent = this.tbox_c1xmax;
            this.tbox_c1xmax.Size = new System.Drawing.Size(110, 33);
            this.tbox_c1xmax.TabIndex = 48;
            this.tbox_c1xmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_c1ymax
            // 
            this.tbox_c1ymax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbox_c1ymax.BorderRadius = 15;
            this.tbox_c1ymax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_c1ymax.DefaultText = "";
            this.tbox_c1ymax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_c1ymax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_c1ymax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c1ymax.DisabledState.Parent = this.tbox_c1ymax;
            this.tbox_c1ymax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c1ymax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c1ymax.FocusedState.Parent = this.tbox_c1ymax;
            this.tbox_c1ymax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_c1ymax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c1ymax.HoverState.Parent = this.tbox_c1ymax;
            this.tbox_c1ymax.Location = new System.Drawing.Point(218, 539);
            this.tbox_c1ymax.Name = "tbox_c1ymax";
            this.tbox_c1ymax.PasswordChar = '\0';
            this.tbox_c1ymax.PlaceholderText = "";
            this.tbox_c1ymax.SelectedText = "";
            this.tbox_c1ymax.ShadowDecoration.Parent = this.tbox_c1ymax;
            this.tbox_c1ymax.Size = new System.Drawing.Size(110, 33);
            this.tbox_c1ymax.TabIndex = 49;
            this.tbox_c1ymax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_c2ymax
            // 
            this.tbox_c2ymax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbox_c2ymax.BorderRadius = 15;
            this.tbox_c2ymax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_c2ymax.DefaultText = "";
            this.tbox_c2ymax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_c2ymax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_c2ymax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c2ymax.DisabledState.Parent = this.tbox_c2ymax;
            this.tbox_c2ymax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c2ymax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c2ymax.FocusedState.Parent = this.tbox_c2ymax;
            this.tbox_c2ymax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_c2ymax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c2ymax.HoverState.Parent = this.tbox_c2ymax;
            this.tbox_c2ymax.Location = new System.Drawing.Point(671, 539);
            this.tbox_c2ymax.Name = "tbox_c2ymax";
            this.tbox_c2ymax.PasswordChar = '\0';
            this.tbox_c2ymax.PlaceholderText = "";
            this.tbox_c2ymax.SelectedText = "";
            this.tbox_c2ymax.ShadowDecoration.Parent = this.tbox_c2ymax;
            this.tbox_c2ymax.Size = new System.Drawing.Size(110, 33);
            this.tbox_c2ymax.TabIndex = 51;
            this.tbox_c2ymax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_c2xmax
            // 
            this.tbox_c2xmax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbox_c2xmax.BorderRadius = 15;
            this.tbox_c2xmax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_c2xmax.DefaultText = "";
            this.tbox_c2xmax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_c2xmax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_c2xmax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c2xmax.DisabledState.Parent = this.tbox_c2xmax;
            this.tbox_c2xmax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c2xmax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c2xmax.FocusedState.Parent = this.tbox_c2xmax;
            this.tbox_c2xmax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_c2xmax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c2xmax.HoverState.Parent = this.tbox_c2xmax;
            this.tbox_c2xmax.Location = new System.Drawing.Point(671, 500);
            this.tbox_c2xmax.Name = "tbox_c2xmax";
            this.tbox_c2xmax.PasswordChar = '\0';
            this.tbox_c2xmax.PlaceholderText = "";
            this.tbox_c2xmax.SelectedText = "";
            this.tbox_c2xmax.ShadowDecoration.Parent = this.tbox_c2xmax;
            this.tbox_c2xmax.Size = new System.Drawing.Size(110, 33);
            this.tbox_c2xmax.TabIndex = 50;
            this.tbox_c2xmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Chart1 Xmax";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Chart1 Ymax";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Chart1 Ymax";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Chart1 Xmax";
            // 
            // buttonsetx_c1
            // 
            this.buttonsetx_c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonsetx_c1.BackColor = System.Drawing.Color.Green;
            this.buttonsetx_c1.BackgroundColor = System.Drawing.Color.Green;
            this.buttonsetx_c1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsetx_c1.BorderRadius = 8;
            this.buttonsetx_c1.BorderSize = 0;
            this.buttonsetx_c1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsetx_c1.FlatAppearance.BorderSize = 0;
            this.buttonsetx_c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsetx_c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.buttonsetx_c1.ForeColor = System.Drawing.Color.White;
            this.buttonsetx_c1.Location = new System.Drawing.Point(334, 505);
            this.buttonsetx_c1.Name = "buttonsetx_c1";
            this.buttonsetx_c1.Size = new System.Drawing.Size(52, 22);
            this.buttonsetx_c1.TabIndex = 56;
            this.buttonsetx_c1.Text = "set";
            this.buttonsetx_c1.TextColor = System.Drawing.Color.White;
            this.buttonsetx_c1.UseVisualStyleBackColor = false;
            this.buttonsetx_c1.Click += new System.EventHandler(this.buttonsetx_c1_Click);
            // 
            // buttonsety_c1
            // 
            this.buttonsety_c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonsety_c1.BackColor = System.Drawing.Color.Green;
            this.buttonsety_c1.BackgroundColor = System.Drawing.Color.Green;
            this.buttonsety_c1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsety_c1.BorderRadius = 8;
            this.buttonsety_c1.BorderSize = 0;
            this.buttonsety_c1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsety_c1.FlatAppearance.BorderSize = 0;
            this.buttonsety_c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsety_c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.buttonsety_c1.ForeColor = System.Drawing.Color.White;
            this.buttonsety_c1.Location = new System.Drawing.Point(334, 544);
            this.buttonsety_c1.Name = "buttonsety_c1";
            this.buttonsety_c1.Size = new System.Drawing.Size(52, 22);
            this.buttonsety_c1.TabIndex = 57;
            this.buttonsety_c1.Text = "set";
            this.buttonsety_c1.TextColor = System.Drawing.Color.White;
            this.buttonsety_c1.UseVisualStyleBackColor = false;
            this.buttonsety_c1.Click += new System.EventHandler(this.buttonsety_c1_Click);
            // 
            // buttonsety_c2
            // 
            this.buttonsety_c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonsety_c2.BackColor = System.Drawing.Color.Green;
            this.buttonsety_c2.BackgroundColor = System.Drawing.Color.Green;
            this.buttonsety_c2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsety_c2.BorderRadius = 8;
            this.buttonsety_c2.BorderSize = 0;
            this.buttonsety_c2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsety_c2.FlatAppearance.BorderSize = 0;
            this.buttonsety_c2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsety_c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.buttonsety_c2.ForeColor = System.Drawing.Color.White;
            this.buttonsety_c2.Location = new System.Drawing.Point(787, 544);
            this.buttonsety_c2.Name = "buttonsety_c2";
            this.buttonsety_c2.Size = new System.Drawing.Size(52, 22);
            this.buttonsety_c2.TabIndex = 59;
            this.buttonsety_c2.Text = "set";
            this.buttonsety_c2.TextColor = System.Drawing.Color.White;
            this.buttonsety_c2.UseVisualStyleBackColor = false;
            this.buttonsety_c2.Click += new System.EventHandler(this.buttonsety_c2_Click);
            // 
            // buttonsetx_c2
            // 
            this.buttonsetx_c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonsetx_c2.BackColor = System.Drawing.Color.Green;
            this.buttonsetx_c2.BackgroundColor = System.Drawing.Color.Green;
            this.buttonsetx_c2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsetx_c2.BorderRadius = 8;
            this.buttonsetx_c2.BorderSize = 0;
            this.buttonsetx_c2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsetx_c2.FlatAppearance.BorderSize = 0;
            this.buttonsetx_c2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsetx_c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.buttonsetx_c2.ForeColor = System.Drawing.Color.White;
            this.buttonsetx_c2.Location = new System.Drawing.Point(787, 505);
            this.buttonsetx_c2.Name = "buttonsetx_c2";
            this.buttonsetx_c2.Size = new System.Drawing.Size(52, 22);
            this.buttonsetx_c2.TabIndex = 58;
            this.buttonsetx_c2.Text = "set";
            this.buttonsetx_c2.TextColor = System.Drawing.Color.White;
            this.buttonsetx_c2.UseVisualStyleBackColor = false;
            this.buttonsetx_c2.Click += new System.EventHandler(this.buttonsetx_c2_Click);
            // 
            // Indikator
            // 
            this.Indikator.BackColor = System.Drawing.Color.Transparent;
            this.Indikator.BorderColor = System.Drawing.Color.Transparent;
            this.Indikator.BorderRadius = 5;
            this.Indikator.FillColor = System.Drawing.Color.DarkGray;
            this.Indikator.Location = new System.Drawing.Point(126, 46);
            this.Indikator.Name = "Indikator";
            this.Indikator.ProgressColor = System.Drawing.Color.Lime;
            this.Indikator.ProgressColor2 = System.Drawing.Color.Lime;
            this.Indikator.ShadowDecoration.Parent = this.Indikator;
            this.Indikator.Size = new System.Drawing.Size(30, 22);
            this.Indikator.TabIndex = 60;
            this.Indikator.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // magicButton2
            // 
            this.magicButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.magicButton2.BackColor = System.Drawing.Color.Green;
            this.magicButton2.BackgroundColor = System.Drawing.Color.Green;
            this.magicButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.magicButton2.BorderRadius = 8;
            this.magicButton2.BorderSize = 0;
            this.magicButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton2.FlatAppearance.BorderSize = 0;
            this.magicButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.magicButton2.ForeColor = System.Drawing.Color.White;
            this.magicButton2.Location = new System.Drawing.Point(1137, 509);
            this.magicButton2.Name = "magicButton2";
            this.magicButton2.Size = new System.Drawing.Size(52, 22);
            this.magicButton2.TabIndex = 61;
            this.magicButton2.Text = "Export";
            this.magicButton2.TextColor = System.Drawing.Color.White;
            this.magicButton2.UseVisualStyleBackColor = false;
            this.magicButton2.Click += new System.EventHandler(this.magicButton2_Click);
            // 
            // magicButton4
            // 
            this.magicButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.magicButton4.BackColor = System.Drawing.Color.Green;
            this.magicButton4.BackgroundColor = System.Drawing.Color.Green;
            this.magicButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.magicButton4.BorderRadius = 8;
            this.magicButton4.BorderSize = 0;
            this.magicButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton4.FlatAppearance.BorderSize = 0;
            this.magicButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.magicButton4.ForeColor = System.Drawing.Color.White;
            this.magicButton4.Location = new System.Drawing.Point(1096, 567);
            this.magicButton4.Name = "magicButton4";
            this.magicButton4.Size = new System.Drawing.Size(52, 22);
            this.magicButton4.TabIndex = 62;
            this.magicButton4.Text = "dum";
            this.magicButton4.TextColor = System.Drawing.Color.White;
            this.magicButton4.UseVisualStyleBackColor = false;
            this.magicButton4.Click += new System.EventHandler(this.magicButton4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.Location = new System.Drawing.Point(884, 571);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 63;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 21;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(1093, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(256, 308);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ZX";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Y";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ZY";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DX";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DY";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DZ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Time";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // allC1
            // 
            this.allC1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.allC1.BackColor = System.Drawing.Color.Green;
            this.allC1.BackgroundColor = System.Drawing.Color.Green;
            this.allC1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.allC1.BorderRadius = 8;
            this.allC1.BorderSize = 0;
            this.allC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allC1.FlatAppearance.BorderSize = 0;
            this.allC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.allC1.ForeColor = System.Drawing.Color.White;
            this.allC1.Location = new System.Drawing.Point(392, 505);
            this.allC1.Name = "allC1";
            this.allC1.Size = new System.Drawing.Size(84, 22);
            this.allC1.TabIndex = 64;
            this.allC1.Text = "Set All Chart 1";
            this.allC1.TextColor = System.Drawing.Color.White;
            this.allC1.UseVisualStyleBackColor = false;
            this.allC1.Click += new System.EventHandler(this.magicButton5_Click);
            // 
            // allC2
            // 
            this.allC2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.allC2.BackColor = System.Drawing.Color.Green;
            this.allC2.BackgroundColor = System.Drawing.Color.Green;
            this.allC2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.allC2.BorderRadius = 8;
            this.allC2.BorderSize = 0;
            this.allC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allC2.FlatAppearance.BorderSize = 0;
            this.allC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.allC2.ForeColor = System.Drawing.Color.White;
            this.allC2.Location = new System.Drawing.Point(845, 505);
            this.allC2.Name = "allC2";
            this.allC2.Size = new System.Drawing.Size(84, 22);
            this.allC2.TabIndex = 65;
            this.allC2.Text = "Set All Chart 2";
            this.allC2.TextColor = System.Drawing.Color.White;
            this.allC2.UseVisualStyleBackColor = false;
            this.allC2.Click += new System.EventHandler(this.allC2_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(18, 16);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "X-Z";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(440, 354);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // kuning
            // 
            this.kuning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kuning.AutoSize = true;
            this.kuning.BackColor = System.Drawing.Color.Transparent;
            this.kuning.Controls.Add(this.chart1);
            this.kuning.FillColor = System.Drawing.Color.White;
            this.kuning.Location = new System.Drawing.Point(116, 97);
            this.kuning.Name = "kuning";
            this.kuning.Radius = 10;
            this.kuning.ShadowColor = System.Drawing.Color.Yellow;
            this.kuning.ShadowDepth = 130;
            this.kuning.ShadowShift = 11;
            this.kuning.Size = new System.Drawing.Size(475, 386);
            this.kuning.TabIndex = 66;
            // 
            // biru
            // 
            this.biru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.biru.AutoSize = true;
            this.biru.BackColor = System.Drawing.Color.Transparent;
            this.biru.Controls.Add(this.chart2);
            this.biru.FillColor = System.Drawing.Color.White;
            this.biru.Location = new System.Drawing.Point(597, 97);
            this.biru.Name = "biru";
            this.biru.Radius = 10;
            this.biru.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.biru.ShadowDepth = 130;
            this.biru.ShadowShift = 11;
            this.biru.Size = new System.Drawing.Size(475, 386);
            this.biru.TabIndex = 67;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Yellow;
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.BorderThickness = 7;
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(6);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(116, 97);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(475, 383);
            this.guna2GradientPanel1.TabIndex = 68;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 606);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.biru);
            this.Controls.Add(this.kuning);
            this.Controls.Add(this.allC2);
            this.Controls.Add(this.allC1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.magicButton4);
            this.Controls.Add(this.magicButton2);
            this.Controls.Add(this.Indikator);
            this.Controls.Add(this.buttonsety_c2);
            this.Controls.Add(this.buttonsetx_c2);
            this.Controls.Add(this.buttonsety_c1);
            this.Controls.Add(this.buttonsetx_c1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_c2ymax);
            this.Controls.Add(this.tbox_c2xmax);
            this.Controls.Add(this.tbox_c1ymax);
            this.Controls.Add(this.tbox_c1xmax);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.magicButton3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gunaCircleButton2);
            this.Controls.Add(this.gunaCircleButton1);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.magicButton1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.kuning.ResumeLayout(false);
            this.biru.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private MagicUI.MagicControl.MagicButton magicButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton2;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MagicUI.MagicControl.MagicButton magicButton3;
        private System.Windows.Forms.TextBox textBox1;
        private MagicUI.MagicControl.MagicButton buttonsety_c2;
        private MagicUI.MagicControl.MagicButton buttonsetx_c2;
        private MagicUI.MagicControl.MagicButton buttonsety_c1;
        private MagicUI.MagicControl.MagicButton buttonsetx_c1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbox_c2ymax;
        private Guna.UI2.WinForms.Guna2TextBox tbox_c2xmax;
        private Guna.UI2.WinForms.Guna2TextBox tbox_c1ymax;
        private Guna.UI2.WinForms.Guna2TextBox tbox_c1xmax;
        private Guna.UI2.WinForms.Guna2ProgressBar Indikator;
        private MagicUI.MagicControl.MagicButton magicButton2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MagicUI.MagicControl.MagicButton magicButton4;
        private System.Windows.Forms.TextBox textBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private MagicUI.MagicControl.MagicButton allC2;
        private MagicUI.MagicControl.MagicButton allC1;
        private Guna.UI2.WinForms.Guna2ShadowPanel biru;
        private Guna.UI2.WinForms.Guna2ShadowPanel kuning;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}

