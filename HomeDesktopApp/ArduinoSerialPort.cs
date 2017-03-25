using System
    ;
using System.IO.Ports;
using System.Threading;

namespace FordHome
{
    public class ArduinoSerialPort
    {
        private static SerialPort m_serialPort;
 

        public ArduinoSerialPort()
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            
            // Create a new SerialPort object with default settings.
            m_serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            m_serialPort.PortName = "COM3";
            m_serialPort.BaudRate = 9600;
            m_serialPort.Parity = Parity.None;
            m_serialPort.DataBits = 8;
            m_serialPort.StopBits = StopBits.One;
            m_serialPort.Handshake = Handshake.XOnXOff;

            // Set the read/write timeouts
            m_serialPort.ReadTimeout = 5000;
            m_serialPort.WriteTimeout = 5000;

            m_serialPort.Open();
        
        }

        public void ReadData(out string temp, out string humidity)
        {
            temp = string.Empty;
            humidity = string.Empty;

            try
            {
                string message = m_serialPort.ReadLine();

                // 
                char[] arduinoOutput = { ':', ' ', ',' };
                string[] splitString = message.Split(arduinoOutput);
                humidity = splitString[2];
                temp = splitString[7];
            }

            catch (TimeoutException)
            {

            }
        }

        public void Exit()
        {
            m_serialPort.Close();
        }
        ~ArduinoSerialPort()
        {
            m_serialPort.Close();
        }
    }
}
