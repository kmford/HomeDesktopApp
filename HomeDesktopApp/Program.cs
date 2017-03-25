using System;
using System.Windows.Forms;

namespace FordHome
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ArduinoSerialPort m_arduino = new ArduinoSerialPort();
            Application.Run(new MainForm(m_arduino));
        }
    }
}
