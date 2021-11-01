namespace INCgui
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.magicButton1 = new MagicUI.MagicControl.MagicButton();
            this.magicButton2 = new MagicUI.MagicControl.MagicButton();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magicButton3 = new MagicUI.MagicControl.MagicButton();
            this.buttonsety_c2 = new MagicUI.MagicControl.MagicButton();
            this.buttonsetx_c2 = new MagicUI.MagicControl.MagicButton();
            this.buttonsety_c1 = new MagicUI.MagicControl.MagicButton();
            this.buttonsetx_c1 = new MagicUI.MagicControl.MagicButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_c2ymax = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_c2xmax = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_c1ymin = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_c1xmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.magicButton4 = new MagicUI.MagicControl.MagicButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.magicButton6 = new MagicUI.MagicControl.MagicButton();
            this.magicButton5 = new MagicUI.MagicControl.MagicButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Indikator = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtf1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(23, 6);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series9.BorderWidth = 5;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Legend = "Legend1";
            series9.Name = "X";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series10.Legend = "Legend1";
            series10.Name = "Y";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(568, 314);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 35F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(378, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 62);
            this.label1.TabIndex = 34;
            this.label1.Text = "Inclinometer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(93, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Connection";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // magicButton1
            // 
            this.magicButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.magicButton1.BackColor = System.Drawing.Color.Lime;
            this.magicButton1.BackgroundColor = System.Drawing.Color.Lime;
            this.magicButton1.BorderColor = System.Drawing.Color.Transparent;
            this.magicButton1.BorderRadius = 12;
            this.magicButton1.BorderSize = 0;
            this.magicButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton1.FlatAppearance.BorderSize = 0;
            this.magicButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.magicButton1.ForeColor = System.Drawing.Color.White;
            this.magicButton1.Location = new System.Drawing.Point(39, 494);
            this.magicButton1.Name = "magicButton1";
            this.magicButton1.Size = new System.Drawing.Size(48, 30);
            this.magicButton1.TabIndex = 36;
            this.magicButton1.TextColor = System.Drawing.Color.White;
            this.magicButton1.UseVisualStyleBackColor = false;
            this.magicButton1.Click += new System.EventHandler(this.magicButton1_Click);
            // 
            // magicButton2
            // 
            this.magicButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.magicButton2.BackColor = System.Drawing.Color.Firebrick;
            this.magicButton2.BackgroundColor = System.Drawing.Color.Firebrick;
            this.magicButton2.BorderColor = System.Drawing.Color.Transparent;
            this.magicButton2.BorderRadius = 12;
            this.magicButton2.BorderSize = 0;
            this.magicButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton2.FlatAppearance.BorderSize = 0;
            this.magicButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.magicButton2.ForeColor = System.Drawing.Color.White;
            this.magicButton2.Location = new System.Drawing.Point(39, 526);
            this.magicButton2.Name = "magicButton2";
            this.magicButton2.Size = new System.Drawing.Size(48, 30);
            this.magicButton2.TabIndex = 37;
            this.magicButton2.TextColor = System.Drawing.Color.White;
            this.magicButton2.UseVisualStyleBackColor = false;
            this.magicButton2.Click += new System.EventHandler(this.magicButton2_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(93, 520);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(125, 36);
            this.guna2ComboBox1.TabIndex = 38;
            this.guna2ComboBox1.DropDown += new System.EventHandler(this.guna2ComboBox1_DropDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(771, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(285, 286);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Black;
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
            this.magicButton3.Location = new System.Drawing.Point(129, 471);
            this.magicButton3.Name = "magicButton3";
            this.magicButton3.Size = new System.Drawing.Size(81, 35);
            this.magicButton3.TabIndex = 77;
            this.magicButton3.Text = "Export";
            this.magicButton3.TextColor = System.Drawing.Color.White;
            this.magicButton3.UseVisualStyleBackColor = false;
            this.magicButton3.Click += new System.EventHandler(this.magicButton3_Click);
            // 
            // buttonsety_c2
            // 
            this.buttonsety_c2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonsety_c2.BackColor = System.Drawing.Color.Green;
            this.buttonsety_c2.BackgroundColor = System.Drawing.Color.Green;
            this.buttonsety_c2.BorderColor = System.Drawing.Color.Transparent;
            this.buttonsety_c2.BorderRadius = 8;
            this.buttonsety_c2.BorderSize = 0;
            this.buttonsety_c2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsety_c2.FlatAppearance.BorderSize = 0;
            this.buttonsety_c2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsety_c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonsety_c2.ForeColor = System.Drawing.Color.White;
            this.buttonsety_c2.Location = new System.Drawing.Point(677, 532);
            this.buttonsety_c2.Name = "buttonsety_c2";
            this.buttonsety_c2.Size = new System.Drawing.Size(70, 28);
            this.buttonsety_c2.TabIndex = 76;
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
            this.buttonsetx_c2.BorderColor = System.Drawing.Color.Transparent;
            this.buttonsetx_c2.BorderRadius = 8;
            this.buttonsetx_c2.BorderSize = 0;
            this.buttonsetx_c2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsetx_c2.FlatAppearance.BorderSize = 0;
            this.buttonsetx_c2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsetx_c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonsetx_c2.ForeColor = System.Drawing.Color.White;
            this.buttonsetx_c2.Location = new System.Drawing.Point(677, 473);
            this.buttonsetx_c2.Name = "buttonsetx_c2";
            this.buttonsetx_c2.Size = new System.Drawing.Size(70, 28);
            this.buttonsetx_c2.TabIndex = 75;
            this.buttonsetx_c2.Text = "set";
            this.buttonsetx_c2.TextColor = System.Drawing.Color.White;
            this.buttonsetx_c2.UseVisualStyleBackColor = false;
            this.buttonsetx_c2.Click += new System.EventHandler(this.buttonsetx_c2_Click);
            // 
            // buttonsety_c1
            // 
            this.buttonsety_c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonsety_c1.BackColor = System.Drawing.Color.Green;
            this.buttonsety_c1.BackgroundColor = System.Drawing.Color.Green;
            this.buttonsety_c1.BorderColor = System.Drawing.Color.Transparent;
            this.buttonsety_c1.BorderRadius = 8;
            this.buttonsety_c1.BorderSize = 0;
            this.buttonsety_c1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsety_c1.FlatAppearance.BorderSize = 0;
            this.buttonsety_c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsety_c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonsety_c1.ForeColor = System.Drawing.Color.White;
            this.buttonsety_c1.Location = new System.Drawing.Point(411, 532);
            this.buttonsety_c1.Name = "buttonsety_c1";
            this.buttonsety_c1.Size = new System.Drawing.Size(70, 28);
            this.buttonsety_c1.TabIndex = 74;
            this.buttonsety_c1.Text = "set";
            this.buttonsety_c1.TextColor = System.Drawing.Color.White;
            this.buttonsety_c1.UseVisualStyleBackColor = false;
            this.buttonsety_c1.Click += new System.EventHandler(this.buttonsety_c1_Click);
            // 
            // buttonsetx_c1
            // 
            this.buttonsetx_c1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonsetx_c1.BackColor = System.Drawing.Color.Green;
            this.buttonsetx_c1.BackgroundColor = System.Drawing.Color.Green;
            this.buttonsetx_c1.BorderColor = System.Drawing.Color.Transparent;
            this.buttonsetx_c1.BorderRadius = 8;
            this.buttonsetx_c1.BorderSize = 0;
            this.buttonsetx_c1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsetx_c1.FlatAppearance.BorderSize = 0;
            this.buttonsetx_c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsetx_c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonsetx_c1.ForeColor = System.Drawing.Color.White;
            this.buttonsetx_c1.Location = new System.Drawing.Point(411, 473);
            this.buttonsetx_c1.Name = "buttonsetx_c1";
            this.buttonsetx_c1.Size = new System.Drawing.Size(70, 28);
            this.buttonsetx_c1.TabIndex = 73;
            this.buttonsetx_c1.Text = "set";
            this.buttonsetx_c1.TextColor = System.Drawing.Color.White;
            this.buttonsetx_c1.UseVisualStyleBackColor = false;
            this.buttonsetx_c1.Click += new System.EventHandler(this.buttonsetx_c1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(509, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "Y maximum";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(509, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "X maximum";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(239, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Y minimum";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(239, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "X minimum";
            // 
            // tbox_c2ymax
            // 
            this.tbox_c2ymax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbox_c2ymax.BackColor = System.Drawing.Color.Transparent;
            this.tbox_c2ymax.BorderColor = System.Drawing.Color.Silver;
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
            this.tbox_c2ymax.Location = new System.Drawing.Point(561, 529);
            this.tbox_c2ymax.Name = "tbox_c2ymax";
            this.tbox_c2ymax.PasswordChar = '\0';
            this.tbox_c2ymax.PlaceholderText = "";
            this.tbox_c2ymax.SelectedText = "";
            this.tbox_c2ymax.ShadowDecoration.Parent = this.tbox_c2ymax;
            this.tbox_c2ymax.Size = new System.Drawing.Size(110, 33);
            this.tbox_c2ymax.TabIndex = 68;
            this.tbox_c2ymax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_c2xmax
            // 
            this.tbox_c2xmax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbox_c2xmax.BackColor = System.Drawing.Color.Transparent;
            this.tbox_c2xmax.BorderColor = System.Drawing.Color.Silver;
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
            this.tbox_c2xmax.Location = new System.Drawing.Point(561, 473);
            this.tbox_c2xmax.Name = "tbox_c2xmax";
            this.tbox_c2xmax.PasswordChar = '\0';
            this.tbox_c2xmax.PlaceholderText = "";
            this.tbox_c2xmax.SelectedText = "";
            this.tbox_c2xmax.ShadowDecoration.Parent = this.tbox_c2xmax;
            this.tbox_c2xmax.Size = new System.Drawing.Size(110, 33);
            this.tbox_c2xmax.TabIndex = 67;
            this.tbox_c2xmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_c1ymin
            // 
            this.tbox_c1ymin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbox_c1ymin.BackColor = System.Drawing.Color.Transparent;
            this.tbox_c1ymin.BorderColor = System.Drawing.Color.Silver;
            this.tbox_c1ymin.BorderRadius = 15;
            this.tbox_c1ymin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_c1ymin.DefaultText = "";
            this.tbox_c1ymin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_c1ymin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_c1ymin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c1ymin.DisabledState.Parent = this.tbox_c1ymin;
            this.tbox_c1ymin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c1ymin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c1ymin.FocusedState.Parent = this.tbox_c1ymin;
            this.tbox_c1ymin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_c1ymin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c1ymin.HoverState.Parent = this.tbox_c1ymin;
            this.tbox_c1ymin.Location = new System.Drawing.Point(295, 529);
            this.tbox_c1ymin.Name = "tbox_c1ymin";
            this.tbox_c1ymin.PasswordChar = '\0';
            this.tbox_c1ymin.PlaceholderText = "";
            this.tbox_c1ymin.SelectedText = "";
            this.tbox_c1ymin.ShadowDecoration.Parent = this.tbox_c1ymin;
            this.tbox_c1ymin.Size = new System.Drawing.Size(110, 33);
            this.tbox_c1ymin.TabIndex = 66;
            this.tbox_c1ymin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_c1xmin
            // 
            this.tbox_c1xmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbox_c1xmin.BackColor = System.Drawing.Color.Transparent;
            this.tbox_c1xmin.BorderColor = System.Drawing.Color.Silver;
            this.tbox_c1xmin.BorderRadius = 15;
            this.tbox_c1xmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_c1xmin.DefaultText = "";
            this.tbox_c1xmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_c1xmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_c1xmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c1xmin.DisabledState.Parent = this.tbox_c1xmin;
            this.tbox_c1xmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_c1xmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c1xmin.FocusedState.Parent = this.tbox_c1xmin;
            this.tbox_c1xmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_c1xmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_c1xmin.HoverState.Parent = this.tbox_c1xmin;
            this.tbox_c1xmin.Location = new System.Drawing.Point(295, 473);
            this.tbox_c1xmin.Name = "tbox_c1xmin";
            this.tbox_c1xmin.PasswordChar = '\0';
            this.tbox_c1xmin.PlaceholderText = "";
            this.tbox_c1xmin.SelectedText = "";
            this.tbox_c1xmin.ShadowDecoration.Parent = this.tbox_c1xmin;
            this.tbox_c1xmin.Size = new System.Drawing.Size(110, 33);
            this.tbox_c1xmin.TabIndex = 65;
            this.tbox_c1xmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.magicButton4.Location = new System.Drawing.Point(227, 471);
            this.magicButton4.Name = "magicButton4";
            this.magicButton4.Size = new System.Drawing.Size(81, 35);
            this.magicButton4.TabIndex = 64;
            this.magicButton4.Text = "Clear";
            this.magicButton4.TextColor = System.Drawing.Color.White;
            this.magicButton4.UseVisualStyleBackColor = false;
            this.magicButton4.Click += new System.EventHandler(this.magicButton4_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // magicButton6
            // 
            this.magicButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.magicButton6.BackColor = System.Drawing.Color.Green;
            this.magicButton6.BackgroundColor = System.Drawing.Color.Green;
            this.magicButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.magicButton6.BorderRadius = 8;
            this.magicButton6.BorderSize = 0;
            this.magicButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton6.FlatAppearance.BorderSize = 0;
            this.magicButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicButton6.ForeColor = System.Drawing.Color.White;
            this.magicButton6.Location = new System.Drawing.Point(207, 33);
            this.magicButton6.Name = "magicButton6";
            this.magicButton6.Size = new System.Drawing.Size(101, 28);
            this.magicButton6.TabIndex = 81;
            this.magicButton6.Text = "Minimize";
            this.magicButton6.TextColor = System.Drawing.Color.White;
            this.magicButton6.UseVisualStyleBackColor = false;
            this.magicButton6.Click += new System.EventHandler(this.magicButton6_Click);
            // 
            // magicButton5
            // 
            this.magicButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.magicButton5.BackColor = System.Drawing.Color.Green;
            this.magicButton5.BackgroundColor = System.Drawing.Color.Green;
            this.magicButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.magicButton5.BorderRadius = 8;
            this.magicButton5.BorderSize = 0;
            this.magicButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton5.FlatAppearance.BorderSize = 0;
            this.magicButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicButton5.ForeColor = System.Drawing.Color.White;
            this.magicButton5.Location = new System.Drawing.Point(100, 33);
            this.magicButton5.Name = "magicButton5";
            this.magicButton5.Size = new System.Drawing.Size(101, 28);
            this.magicButton5.TabIndex = 80;
            this.magicButton5.Text = "Exit";
            this.magicButton5.TextColor = System.Drawing.Color.White;
            this.magicButton5.UseVisualStyleBackColor = false;
            this.magicButton5.Click += new System.EventHandler(this.magicButton5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // Indikator
            // 
            this.Indikator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Indikator.BackColor = System.Drawing.Color.Transparent;
            this.Indikator.BorderColor = System.Drawing.Color.Transparent;
            this.Indikator.BorderRadius = 5;
            this.Indikator.FillColor = System.Drawing.Color.DarkGray;
            this.Indikator.Location = new System.Drawing.Point(12, 496);
            this.Indikator.Name = "Indikator";
            this.Indikator.ProgressColor = System.Drawing.Color.Lime;
            this.Indikator.ProgressColor2 = System.Drawing.Color.Lime;
            this.Indikator.ShadowDecoration.Parent = this.Indikator;
            this.Indikator.Size = new System.Drawing.Size(21, 60);
            this.Indikator.TabIndex = 84;
            this.Indikator.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel1.Controls.Add(this.magicButton3);
            this.guna2GradientPanel1.Controls.Add(this.magicButton6);
            this.guna2GradientPanel1.Controls.Add(this.magicButton5);
            this.guna2GradientPanel1.Controls.Add(this.magicButton4);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Green;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(748, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(338, 580);
            this.guna2GradientPanel1.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(95, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 86;
            this.label7.Text = "Sumbu X dan Y";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(8, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 251);
            this.label8.TabIndex = 87;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Paint += new System.Windows.Forms.PaintEventHandler(this.label8_Paint);
            // 
            // rtf1
            // 
            this.rtf1.Location = new System.Drawing.Point(55, 33);
            this.rtf1.Name = "rtf1";
            this.rtf1.Size = new System.Drawing.Size(32, 21);
            this.rtf1.TabIndex = 88;
            this.rtf1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(331, 481);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 89;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GradientPanel2.Controls.Add(this.label8);
            this.guna2GradientPanel2.Controls.Add(this.label7);
            this.guna2GradientPanel2.Controls.Add(this.chart1);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(93, 80);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(613, 323);
            this.guna2GradientPanel2.TabIndex = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 576);
            this.ControlBox = false;
            this.Controls.Add(this.tbox_c1xmin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsety_c2);
            this.Controls.Add(this.Indikator);
            this.Controls.Add(this.buttonsetx_c2);
            this.Controls.Add(this.tbox_c2ymax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_c1ymin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonsety_c1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.magicButton2);
            this.Controls.Add(this.buttonsetx_c1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.magicButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.rtf1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.tbox_c2xmax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MagicUI.MagicControl.MagicButton magicButton1;
        private MagicUI.MagicControl.MagicButton magicButton2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private MagicUI.MagicControl.MagicButton magicButton3;
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
        private Guna.UI2.WinForms.Guna2TextBox tbox_c1ymin;
        private Guna.UI2.WinForms.Guna2TextBox tbox_c1xmin;
        private MagicUI.MagicControl.MagicButton magicButton4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MagicUI.MagicControl.MagicButton magicButton6;
        private MagicUI.MagicControl.MagicButton magicButton5;
        private Guna.UI2.WinForms.Guna2ProgressBar Indikator;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtf1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
    }
}

