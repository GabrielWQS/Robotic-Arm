using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Braço_Robótico_v1.Util
{
    public static class Config
    {
        private static SerialPort SerialPort;

        public static int BaudRate;
        public static string ComPort;
        
        
        public static void SetSerialPortConfig(int BaudRate, string ComPort)
        {
            Config.BaudRate = BaudRate;
            Config.ComPort = ComPort;

            SerialPort.BaudRate = BaudRate;
            SerialPort.PortName = ComPort;
        }

        public static int GetBaudRate()
        {
            return Config.BaudRate;
        }

        public static string GetComPort()
        {
            return Config.ComPort;
        }

        public static SerialPort GetSerialPort()
        {
            return Config.SerialPort;
        }

    }
}
