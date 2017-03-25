using System;
using System.Threading;
using System.Windows.Forms;

namespace FordHome
{
    public partial class MainForm : Form
    {
        public ArduinoSerialPort m_arduino;
        delegate void UpdateTempTextCallback(string temp);
        private Thread updateDataThread;
        private static bool m_continue;

        // darksky api key
        // 68d9378644b9e4c410a00a6280be6976

//        https://api.darksky.net/forecast/68d9378644b9e4c410a00a6280be6976/42.0897,-75.9291
        public void UpdateTempText(string temp)
        {
            if (outdoorTempTextBox.InvokeRequired)
            {
                UpdateTempTextCallback u = new UpdateTempTextCallback(UpdateTempText);
                Invoke(u, new object[] { temp });
            }
            else
            {
                outdoorTempTextBox.Text = temp;
            }
        }
        public MainForm(ArduinoSerialPort m_arduinoIn)
        {
            m_arduino = m_arduinoIn;
            InitializeComponent();

            updateDataThread = new Thread(UpdateData);
            m_continue = true;
            updateDataThread.Start();

        }
        private void UpdateData()
        {
            string temp = string.Empty;
            string humidity = string.Empty;

            while (m_continue)
            {
                try
                {
                    m_arduino.ReadData(out temp, out humidity);
                    UpdateTempText(temp);
                }

                catch (Exception ex)
                {

                }
                Thread.Sleep(1000);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            m_continue = false;
            m_arduino.Exit();
            updateDataThread.Abort();
            Application.Exit();
        }
    }
}
