using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace PIDPositionDemo
{
    public partial class frmMain : Form
    {
        private int isPause = 0;
        private int blinkToggle = 0;
        private int connectedTrigger = 0;
        private int setPointPublic = 0;

        public frmMain()
        {
            InitializeComponent();
            try
            {
                string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
                cbxBaudRate.Items.AddRange(BaudRate);
                cbxBaudRate.SelectedIndex = 7;
            }
            catch { }
            finally { }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                cbxCOM.DataSource = SerialPort.GetPortNames();
                if (cbxCOM.Items.Count > 0) cbxCOM.SelectedIndex = 0;
            }
            catch { }
            finally { }
        }

        private void tmrMonitoring_Tick(object sender, EventArgs e)
        {
            try
            {
                if (cbxCOM.Items.Count > 0)
                {
                    if (!serCOM.IsOpen)
                    {
                        lblStatus.Text = ("Chưa kết nối!");
                        lblStatus.ForeColor = Color.Red;
                        cbxCOM.Enabled = true;
                        cbxBaudRate.Enabled = true;
                        btnRefesh.Enabled = true;
                        btnConnect.Enabled = true;
                        btnDisconnect.Enabled = false;
                    }
                    else
                    {
                        if (connectedTrigger == 1)
                        {
                            connectedTrigger = 0;
                            trbSetpoint.Value = setPointPublic;
                        }

                        lblStatus.Text = ("Đã kết nối!");
                        lblStatus.ForeColor = Color.Green;
                        cbxCOM.Enabled = false;
                        cbxBaudRate.Enabled = false;
                        btnRefesh.Enabled = false;
                        btnConnect.Enabled = false;
                        btnDisconnect.Enabled = true;
                    }
                }
                else
                {
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = false;
                }
            }
            catch { }
            finally { }
        }

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            try
            {
                string text = serCOM.ReadLine();

                this.Invoke((MethodInvoker)delegate
                {
                    txtRaw.AppendText(text.ToString());

                    string[] textArr = text.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    int setpoint = (textArr[0] != null ? int.Parse(textArr[0]) : 0);
                    setPointPublic = setpoint;
                    int input = (textArr[1] != null ? int.Parse(textArr[1]) : 0);
                    decimal kp = (textArr[2] != null ? decimal.Parse(textArr[2]) : 0);
                    decimal ki = (textArr[3] != null ? decimal.Parse(textArr[3]) : 0);
                    decimal kd = (textArr[4] != null ? decimal.Parse(textArr[4]) : 0);

                    chtGraph.Series[0].Points.AddXY(DateTime.Now.ToString("hh:mm:ss.fff"), setpoint);
                    chtGraph.Series[1].Points.AddY(input);

                    if (chtGraph.Series[0].Points.Count > 20)
                    {
                        chtGraph.Series[0].Points.RemoveAt(0);
                    }

                    if (chtGraph.Series[1].Points.Count > 20)
                    {
                        chtGraph.Series[1].Points.RemoveAt(0);
                    }

                    lblSetpoint.Text = setpoint.ToString();
                    lblKp.Text = kp.ToString();
                    lblKi.Text = ki.ToString();
                    lblKd.Text = kd.ToString();
                });
            }
            catch { }
            finally { }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serCOM.Dispose();
                serCOM.PortName = cbxCOM.Text;
                serCOM.BaudRate = Convert.ToInt32(cbxBaudRate.Text);
                serCOM.Open();
                cbxCOM.Enabled = false;
                cbxBaudRate.Enabled = false;
                btnRefesh.Enabled = false;
                connectedTrigger = 1;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới cổng " + cbxCOM.Text + ". Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serCOM.Dispose();
                txtRaw.Clear();
                chtGraph.Series[0].Points.Clear();
                chtGraph.Series[1].Points.Clear();
                lblKp.Text = "0";
                lblKi.Text = "0";
                lblKd.Text = "0";
                serCOM.WriteLine("\n");
                cbxCOM.Enabled = true;
                cbxBaudRate.Enabled = true;
                btnRefesh.Enabled = true;
            }
            catch { }
            finally { }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serCOM.IsOpen)
                {
                    e.Cancel = true;
                    Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnExit));
                    CloseDown.Start();
                }
            }
            catch { }
            finally { }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            try
            {
                cbxCOM.DataSource = SerialPort.GetPortNames();
            }
            catch { }
            finally { }
        }

        private void llbHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://phatvu1294.blogspot.com");
            }
            catch { }
            finally { }
        }

        private void CloseSerialOnExit()
        {
            try
            {
                serCOM.Close();
                serCOM.Dispose();
                this.Invoke(new EventHandler(NowClose));
            }
            catch { }
            finally { }
        }

        private void NowClose(object sender, EventArgs e)
        {
            try
            {
                tmrMonitoring.Dispose();
                this.Close();
            }
            catch { }
            finally { }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "PID Demo\r\n";
                text += "Phiên bản 1.0\r\n";
                text += "Bản quyền © 2020 Vũ Phát\r\n";
                MessageBox.Show(text, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
            finally { }
        }

        private void trbSetpoint_Scroll(object sender, EventArgs e)
        {
            try
            {
                if (serCOM.IsOpen)
                {
                    string text = trbSetpoint.Value.ToString();
                    serCOM.WriteLine(text);
                }
            }
            catch { }
            finally { }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Space))
            {
                if (isPause == 0)
                {
                    isPause = 1;
                    serCOM.DataReceived -= new SerialDataReceivedEventHandler(DataReceive);
                }
                else if (isPause == 1)
                {
                    isPause = 0;
                    serCOM.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tmrBlinkText_Tick(object sender, EventArgs e)
        {
            try
            {
                if (blinkToggle == 0) blinkToggle = 1;
                else blinkToggle = 0;
                lblHomepage.Font = new Font(lblNoteInfo.Font, (blinkToggle == 1 ? FontStyle.Regular : FontStyle.Bold));
            }
            catch { }
            finally { }
        }
    }
}
