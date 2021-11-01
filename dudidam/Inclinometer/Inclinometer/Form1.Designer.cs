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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.magicButton1 = new MagicUI.MagicControl.MagicButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea13.AxisX.MajorGrid.Enabled = false;
            chartArea13.AxisY.MajorGrid.Enabled = false;
            chartArea13.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea13);
            this.chart2.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend13.Name = "Legend1";
            this.chart2.Legends.Add(legend13);
            this.chart2.Location = new System.Drawing.Point(0, 7);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series13.BorderWidth = 5;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.Name = "Y-Z";
            this.chart2.Series.Add(series13);
            this.chart2.Size = new System.Drawing.Size(440, 329);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
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
            this.magicButton1.Location = new System.Drawing.Point(900, 520);
            this.magicButton1.Name = "magicButton1";
            this.magicButton1.Size = new System.Drawing.Size(101, 28);
            this.magicButton1.TabIndex = 13;
            this.magicButton1.Text = "Exit";
            this.magicButton1.TextColor = System.Drawing.Color.White;
            this.magicButton1.UseVisualStyleBackColor = false;
            this.magicButton1.Click += new System.EventHandler(this.magicButton1_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea14.AxisX.MajorGrid.Enabled = false;
            chartArea14.AxisY.MajorGrid.Enabled = false;
            chartArea14.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea14);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend14.Name = "Legend1";
            this.chart1.Legends.Add(legend14);
            this.chart1.Location = new System.Drawing.Point(0, 7);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series14.BorderWidth = 5;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Legend1";
            series14.Name = "X-Z";
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(440, 329);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCards2.Controls.Add(this.chart2);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(565, 97);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(440, 336);
            this.bunifuCards2.TabIndex = 16;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Yellow;
            this.bunifuCards1.Controls.Add(this.chart1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(113, 97);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(440, 336);
            this.bunifuCards1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(434, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inclinometer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(909, 9);
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
            this.pictureBox2.Location = new System.Drawing.Point(871, 8);
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
            this.gunaGradientPanel1.Size = new System.Drawing.Size(107, 561);
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
            this.pictureBox3.Location = new System.Drawing.Point(442, 449);
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
            this.magicButton3.Location = new System.Drawing.Point(949, 439);
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
            this.textBox1.Location = new System.Drawing.Point(442, 529);
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
            this.tbox_c1xmax.Location = new System.Drawing.Point(227, 455);
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
            this.tbox_c1ymax.Location = new System.Drawing.Point(227, 494);
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
            this.tbox_c2ymax.Location = new System.Drawing.Point(671, 494);
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
            this.tbox_c2xmax.Location = new System.Drawing.Point(671, 455);
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
            this.label3.Location = new System.Drawing.Point(154, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Chart1 Xmax";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Chart1 Ymax";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Chart1 Ymax";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 464);
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
            this.buttonsetx_c1.Location = new System.Drawing.Point(343, 460);
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
            this.buttonsety_c1.Location = new System.Drawing.Point(343, 499);
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
            this.buttonsety_c2.Location = new System.Drawing.Point(787, 499);
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
            this.buttonsetx_c2.Location = new System.Drawing.Point(787, 460);
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
            this.magicButton2.Location = new System.Drawing.Point(949, 466);
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
            this.magicButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.magicButton4.Location = new System.Drawing.Point(631, 529);
            this.magicButton4.Name = "magicButton4";
            this.magicButton4.Size = new System.Drawing.Size(52, 22);
            this.magicButton4.TabIndex = 62;
            this.magicButton4.Text = "dum";
            this.magicButton4.TextColor = System.Drawing.Color.White;
            this.magicButton4.UseVisualStyleBackColor = false;
            this.magicButton4.Click += new System.EventHandler(this.magicButton4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(161, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 111);
            this.dataGridView1.TabIndex = 63;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ZX";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Y";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ZY";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 561);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.magicButton1);
            this.Controls.Add(this.bunifuCards2);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MagicUI.MagicControl.MagicButton magicButton1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

