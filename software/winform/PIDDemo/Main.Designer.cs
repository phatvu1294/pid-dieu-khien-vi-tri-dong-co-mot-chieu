namespace PIDPositionDemo
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpMainCell1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxCOM = new System.Windows.Forms.ComboBox();
            this.lblBaudrate = new System.Windows.Forms.Label();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblCOM = new System.Windows.Forms.Label();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblHomepage = new System.Windows.Forms.LinkLabel();
            this.lblNoteInfo = new System.Windows.Forms.Label();
            this.tmrMonitoring = new System.Windows.Forms.Timer(this.components);
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.chtGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.tlpMainCell3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainCell3Cell1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainCell3Cell1Cell1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblKp = new System.Windows.Forms.Label();
            this.lblKi = new System.Windows.Forms.Label();
            this.lblKd = new System.Windows.Forms.Label();
            this.lblKpInfo = new System.Windows.Forms.Label();
            this.lblKiInfo = new System.Windows.Forms.Label();
            this.lblKdInfo = new System.Windows.Forms.Label();
            this.tlpMainCell3Cell1Cell2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSetpoint = new System.Windows.Forms.Label();
            this.lblSetpointInfo = new System.Windows.Forms.Label();
            this.trbSetpoint = new System.Windows.Forms.TrackBar();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainCell2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRaw = new System.Windows.Forms.Label();
            this.txtRaw = new System.Windows.Forms.RichTextBox();
            this.tmrBlinkText = new System.Windows.Forms.Timer(this.components);
            this.tlpMainCell1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.tlpMainCell3.SuspendLayout();
            this.tlpMainCell3Cell1.SuspendLayout();
            this.tlpMainCell3Cell1Cell1.SuspendLayout();
            this.tlpMainCell3Cell1Cell2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSetpoint)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.tlpMainCell2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainCell1
            // 
            this.tlpMainCell1.ColumnCount = 2;
            this.tlpMainCell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainCell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpMainCell1.Controls.Add(this.cbxCOM, 0, 2);
            this.tlpMainCell1.Controls.Add(this.lblBaudrate, 0, 4);
            this.tlpMainCell1.Controls.Add(this.cbxBaudRate, 0, 5);
            this.tlpMainCell1.Controls.Add(this.btnConnect, 0, 7);
            this.tlpMainCell1.Controls.Add(this.btnDisconnect, 0, 8);
            this.tlpMainCell1.Controls.Add(this.lblCOM, 0, 1);
            this.tlpMainCell1.Controls.Add(this.btnRefesh, 1, 2);
            this.tlpMainCell1.Controls.Add(this.lblStatus, 0, 10);
            this.tlpMainCell1.Controls.Add(this.btnAbout, 1, 12);
            this.tlpMainCell1.Controls.Add(this.lblHomepage, 0, 12);
            this.tlpMainCell1.Controls.Add(this.lblNoteInfo, 0, 14);
            this.tlpMainCell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainCell1.Location = new System.Drawing.Point(3, 3);
            this.tlpMainCell1.Name = "tlpMainCell1";
            this.tlpMainCell1.RowCount = 15;
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainCell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpMainCell1.Size = new System.Drawing.Size(246, 294);
            this.tlpMainCell1.TabIndex = 11;
            // 
            // cbxCOM
            // 
            this.cbxCOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCOM.FormattingEnabled = true;
            this.cbxCOM.Location = new System.Drawing.Point(3, 28);
            this.cbxCOM.Name = "cbxCOM";
            this.cbxCOM.Size = new System.Drawing.Size(170, 21);
            this.cbxCOM.TabIndex = 0;
            // 
            // lblBaudrate
            // 
            this.tlpMainCell1.SetColumnSpan(this.lblBaudrate, 2);
            this.lblBaudrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaudrate.Location = new System.Drawing.Point(3, 58);
            this.lblBaudrate.Name = "lblBaudrate";
            this.lblBaudrate.Size = new System.Drawing.Size(240, 19);
            this.lblBaudrate.TabIndex = 2;
            this.lblBaudrate.Text = "Tốc độ Baud:";
            this.lblBaudrate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbxBaudRate
            // 
            this.tlpMainCell1.SetColumnSpan(this.cbxBaudRate, 2);
            this.cbxBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(3, 80);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(240, 21);
            this.cbxBaudRate.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.tlpMainCell1.SetColumnSpan(this.btnConnect, 2);
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(3, 113);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(240, 24);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.tlpMainCell1.SetColumnSpan(this.btnDisconnect, 2);
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisconnect.Location = new System.Drawing.Point(3, 143);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(240, 24);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Ngắt kết nối";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblCOM
            // 
            this.tlpMainCell1.SetColumnSpan(this.lblCOM, 2);
            this.lblCOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCOM.Location = new System.Drawing.Point(3, 6);
            this.lblCOM.Name = "lblCOM";
            this.lblCOM.Size = new System.Drawing.Size(240, 19);
            this.lblCOM.TabIndex = 1;
            this.lblCOM.Text = "Cổng kết nối:";
            this.lblCOM.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnRefesh
            // 
            this.btnRefesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefesh.Location = new System.Drawing.Point(179, 28);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(64, 21);
            this.btnRefesh.TabIndex = 8;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // lblStatus
            // 
            this.tlpMainCell1.SetColumnSpan(this.lblStatus, 2);
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(3, 189);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(240, 19);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Chưa kết nối!";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbout.Location = new System.Drawing.Point(179, 231);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(64, 21);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "Thông tin";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblHomepage
            // 
            this.lblHomepage.AutoSize = true;
            this.lblHomepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHomepage.Location = new System.Drawing.Point(3, 228);
            this.lblHomepage.Name = "lblHomepage";
            this.lblHomepage.Size = new System.Drawing.Size(170, 27);
            this.lblHomepage.TabIndex = 10;
            this.lblHomepage.TabStop = true;
            this.lblHomepage.Text = "phatvu1294";
            this.lblHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbHomepage_LinkClicked);
            // 
            // lblNoteInfo
            // 
            this.tlpMainCell1.SetColumnSpan(this.lblNoteInfo, 2);
            this.lblNoteInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoteInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNoteInfo.Location = new System.Drawing.Point(3, 275);
            this.lblNoteInfo.Name = "lblNoteInfo";
            this.lblNoteInfo.Size = new System.Drawing.Size(240, 19);
            this.lblNoteInfo.TabIndex = 11;
            this.lblNoteInfo.Text = "Ctrl+Space: Tạm dừng / Tiếp tục";
            this.lblNoteInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tmrMonitoring
            // 
            this.tmrMonitoring.Enabled = true;
            this.tmrMonitoring.Interval = 10;
            this.tmrMonitoring.Tick += new System.EventHandler(this.tmrMonitoring_Tick);
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceive);
            // 
            // chtGraph
            // 
            this.chtGraph.BackColor = System.Drawing.SystemColors.Control;
            this.chtGraph.BorderlineColor = System.Drawing.SystemColors.Control;
            this.chtGraph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chtGraph.BorderSkin.PageColor = System.Drawing.Color.Empty;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.Maximum = 250D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY2.Maximum = 250D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chtGraph.ChartAreas.Add(chartArea1);
            this.chtGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chtGraph.Legends.Add(legend1);
            this.chtGraph.Location = new System.Drawing.Point(3, 103);
            this.chtGraph.Name = "chtGraph";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Vị trí đặt";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.MarkerSize = 7;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Vị trí hiện hành";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chtGraph.Series.Add(series1);
            this.chtGraph.Series.Add(series2);
            this.chtGraph.Size = new System.Drawing.Size(1002, 575);
            this.chtGraph.TabIndex = 7;
            this.chtGraph.Text = "chtGraph";
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.tlpMainCell3);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.tlpMain);
            this.spcMain.Size = new System.Drawing.Size(1264, 681);
            this.spcMain.SplitterDistance = 1008;
            this.spcMain.TabIndex = 11;
            // 
            // tlpMainCell3
            // 
            this.tlpMainCell3.ColumnCount = 1;
            this.tlpMainCell3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainCell3.Controls.Add(this.chtGraph, 0, 1);
            this.tlpMainCell3.Controls.Add(this.tlpMainCell3Cell1, 0, 0);
            this.tlpMainCell3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainCell3.Location = new System.Drawing.Point(0, 0);
            this.tlpMainCell3.Name = "tlpMainCell3";
            this.tlpMainCell3.RowCount = 2;
            this.tlpMainCell3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMainCell3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainCell3.Size = new System.Drawing.Size(1008, 681);
            this.tlpMainCell3.TabIndex = 8;
            // 
            // tlpMainCell3Cell1
            // 
            this.tlpMainCell3Cell1.ColumnCount = 1;
            this.tlpMainCell3Cell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainCell3Cell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainCell3Cell1.Controls.Add(this.tlpMainCell3Cell1Cell1, 0, 0);
            this.tlpMainCell3Cell1.Controls.Add(this.tlpMainCell3Cell1Cell2, 0, 1);
            this.tlpMainCell3Cell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainCell3Cell1.Location = new System.Drawing.Point(3, 3);
            this.tlpMainCell3Cell1.Name = "tlpMainCell3Cell1";
            this.tlpMainCell3Cell1.RowCount = 2;
            this.tlpMainCell3Cell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainCell3Cell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainCell3Cell1.Size = new System.Drawing.Size(1002, 94);
            this.tlpMainCell3Cell1.TabIndex = 8;
            // 
            // tlpMainCell3Cell1Cell1
            // 
            this.tlpMainCell3Cell1Cell1.ColumnCount = 8;
            this.tlpMainCell3Cell1Cell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMainCell3Cell1Cell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMainCell3Cell1Cell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainCell3Cell1Cell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMainCell3Cell1Cell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMainCell3Cell1Cell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainCell3Cell1Cell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMainCell3Cell1Cell1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMainCell3Cell1Cell1.Controls.Add(this.lblKp, 1, 0);
            this.tlpMainCell3Cell1Cell1.Controls.Add(this.lblKi, 4, 0);
            this.tlpMainCell3Cell1Cell1.Controls.Add(this.lblKd, 7, 0);
            this.tlpMainCell3Cell1Cell1.Controls.Add(this.lblKpInfo, 0, 0);
            this.tlpMainCell3Cell1Cell1.Controls.Add(this.lblKiInfo, 3, 0);
            this.tlpMainCell3Cell1Cell1.Controls.Add(this.lblKdInfo, 6, 0);
            this.tlpMainCell3Cell1Cell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainCell3Cell1Cell1.Location = new System.Drawing.Point(3, 3);
            this.tlpMainCell3Cell1Cell1.Name = "tlpMainCell3Cell1Cell1";
            this.tlpMainCell3Cell1Cell1.RowCount = 1;
            this.tlpMainCell3Cell1Cell1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainCell3Cell1Cell1.Size = new System.Drawing.Size(996, 41);
            this.tlpMainCell3Cell1Cell1.TabIndex = 0;
            // 
            // lblKp
            // 
            this.lblKp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKp.Location = new System.Drawing.Point(83, 0);
            this.lblKp.Name = "lblKp";
            this.lblKp.Size = new System.Drawing.Size(144, 41);
            this.lblKp.TabIndex = 0;
            this.lblKp.Text = "0";
            this.lblKp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKi
            // 
            this.lblKi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKi.Location = new System.Drawing.Point(466, 0);
            this.lblKi.Name = "lblKi";
            this.lblKi.Size = new System.Drawing.Size(144, 41);
            this.lblKi.TabIndex = 1;
            this.lblKi.Text = "0";
            this.lblKi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKd
            // 
            this.lblKd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKd.Location = new System.Drawing.Point(849, 0);
            this.lblKd.Name = "lblKd";
            this.lblKd.Size = new System.Drawing.Size(144, 41);
            this.lblKd.TabIndex = 2;
            this.lblKd.Text = "0";
            this.lblKd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKpInfo
            // 
            this.lblKpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpInfo.Location = new System.Drawing.Point(3, 0);
            this.lblKpInfo.Name = "lblKpInfo";
            this.lblKpInfo.Size = new System.Drawing.Size(74, 41);
            this.lblKpInfo.TabIndex = 3;
            this.lblKpInfo.Text = "Hằng số Kp:";
            this.lblKpInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKiInfo
            // 
            this.lblKiInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKiInfo.Location = new System.Drawing.Point(386, 0);
            this.lblKiInfo.Name = "lblKiInfo";
            this.lblKiInfo.Size = new System.Drawing.Size(74, 41);
            this.lblKiInfo.TabIndex = 4;
            this.lblKiInfo.Text = "Hàng số Ki:";
            this.lblKiInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKdInfo
            // 
            this.lblKdInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKdInfo.Location = new System.Drawing.Point(769, 0);
            this.lblKdInfo.Name = "lblKdInfo";
            this.lblKdInfo.Size = new System.Drawing.Size(74, 41);
            this.lblKdInfo.TabIndex = 5;
            this.lblKdInfo.Text = "Hằng số Kd:";
            this.lblKdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpMainCell3Cell1Cell2
            // 
            this.tlpMainCell3Cell1Cell2.ColumnCount = 4;
            this.tlpMainCell3Cell1Cell2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMainCell3Cell1Cell2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMainCell3Cell1Cell2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainCell3Cell1Cell2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainCell3Cell1Cell2.Controls.Add(this.lblSetpoint, 1, 0);
            this.tlpMainCell3Cell1Cell2.Controls.Add(this.lblSetpointInfo, 0, 0);
            this.tlpMainCell3Cell1Cell2.Controls.Add(this.trbSetpoint, 3, 0);
            this.tlpMainCell3Cell1Cell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainCell3Cell1Cell2.Location = new System.Drawing.Point(3, 50);
            this.tlpMainCell3Cell1Cell2.Name = "tlpMainCell3Cell1Cell2";
            this.tlpMainCell3Cell1Cell2.RowCount = 1;
            this.tlpMainCell3Cell1Cell2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainCell3Cell1Cell2.Size = new System.Drawing.Size(996, 41);
            this.tlpMainCell3Cell1Cell2.TabIndex = 1;
            // 
            // lblSetpoint
            // 
            this.lblSetpoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSetpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetpoint.Location = new System.Drawing.Point(83, 0);
            this.lblSetpoint.Name = "lblSetpoint";
            this.lblSetpoint.Size = new System.Drawing.Size(144, 41);
            this.lblSetpoint.TabIndex = 5;
            this.lblSetpoint.Text = "0";
            this.lblSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetpointInfo
            // 
            this.lblSetpointInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSetpointInfo.Location = new System.Drawing.Point(3, 0);
            this.lblSetpointInfo.Name = "lblSetpointInfo";
            this.lblSetpointInfo.Size = new System.Drawing.Size(74, 41);
            this.lblSetpointInfo.TabIndex = 4;
            this.lblSetpointInfo.Text = "Vị trí đặt:";
            this.lblSetpointInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trbSetpoint
            // 
            this.trbSetpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbSetpoint.LargeChange = 10;
            this.trbSetpoint.Location = new System.Drawing.Point(253, 3);
            this.trbSetpoint.Maximum = 200;
            this.trbSetpoint.Name = "trbSetpoint";
            this.trbSetpoint.Size = new System.Drawing.Size(740, 35);
            this.trbSetpoint.SmallChange = 5;
            this.trbSetpoint.TabIndex = 0;
            this.trbSetpoint.TickFrequency = 5;
            this.trbSetpoint.Scroll += new System.EventHandler(this.trbSetpoint_Scroll);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpMainCell1, 0, 0);
            this.tlpMain.Controls.Add(this.tlpMainCell2, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(252, 681);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpMainCell2
            // 
            this.tlpMainCell2.ColumnCount = 1;
            this.tlpMainCell2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainCell2.Controls.Add(this.lblRaw, 0, 0);
            this.tlpMainCell2.Controls.Add(this.txtRaw, 0, 1);
            this.tlpMainCell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainCell2.Location = new System.Drawing.Point(3, 303);
            this.tlpMainCell2.Name = "tlpMainCell2";
            this.tlpMainCell2.RowCount = 2;
            this.tlpMainCell2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpMainCell2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainCell2.Size = new System.Drawing.Size(246, 375);
            this.tlpMainCell2.TabIndex = 12;
            // 
            // lblRaw
            // 
            this.lblRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRaw.Location = new System.Drawing.Point(3, 0);
            this.lblRaw.Name = "lblRaw";
            this.lblRaw.Size = new System.Drawing.Size(240, 19);
            this.lblRaw.TabIndex = 0;
            this.lblRaw.Text = "Dữ liệu thô:";
            this.lblRaw.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtRaw
            // 
            this.txtRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRaw.Location = new System.Drawing.Point(3, 22);
            this.txtRaw.Name = "txtRaw";
            this.txtRaw.ReadOnly = true;
            this.txtRaw.Size = new System.Drawing.Size(240, 350);
            this.txtRaw.TabIndex = 1;
            this.txtRaw.Text = "";
            // 
            // tmrBlinkText
            // 
            this.tmrBlinkText.Enabled = true;
            this.tmrBlinkText.Interval = 250;
            this.tmrBlinkText.Tick += new System.EventHandler(this.tmrBlinkText_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.spcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PID Position Demo v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpMainCell1.ResumeLayout(false);
            this.tlpMainCell1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraph)).EndInit();
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.tlpMainCell3.ResumeLayout(false);
            this.tlpMainCell3Cell1.ResumeLayout(false);
            this.tlpMainCell3Cell1Cell1.ResumeLayout(false);
            this.tlpMainCell3Cell1Cell2.ResumeLayout(false);
            this.tlpMainCell3Cell1Cell2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSetpoint)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMainCell2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxCOM;
        private System.Windows.Forms.Label lblCOM;
        private System.Windows.Forms.Label lblBaudrate;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrMonitoring;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraph;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.TableLayoutPanel tlpMainCell1;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMainCell2;
        private System.Windows.Forms.Label lblRaw;
        private System.Windows.Forms.RichTextBox txtRaw;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.LinkLabel lblHomepage;
        private System.Windows.Forms.TableLayoutPanel tlpMainCell3;
        private System.Windows.Forms.TableLayoutPanel tlpMainCell3Cell1;
        private System.Windows.Forms.TableLayoutPanel tlpMainCell3Cell1Cell1;
        private System.Windows.Forms.TrackBar trbSetpoint;
        private System.Windows.Forms.Label lblKp;
        private System.Windows.Forms.Label lblKi;
        private System.Windows.Forms.Label lblKd;
        private System.Windows.Forms.Label lblKpInfo;
        private System.Windows.Forms.Label lblKiInfo;
        private System.Windows.Forms.Label lblKdInfo;
        private System.Windows.Forms.TableLayoutPanel tlpMainCell3Cell1Cell2;
        private System.Windows.Forms.Label lblSetpointInfo;
        private System.Windows.Forms.Label lblSetpoint;
        private System.Windows.Forms.Label lblNoteInfo;
        private System.Windows.Forms.Timer tmrBlinkText;
    }
}

