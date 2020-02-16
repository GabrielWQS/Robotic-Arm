using Controle_de_Braço_Robótico_v1.Util;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Braço_Robótico_v1
{
    public static class SendData
    {
        public static void SerialWrite(string write)
        {
            SerialPort SerialComPort = Config.GetSerialPort();

            try
            {
                SerialComPort.Open();
                SerialComPort.WriteLine(write);
                SerialComPort.Close();
            }
            catch (Exception e)
            {
                //TODO tratar exceção
                throw new Exception(e.Message, e);
            }
        }
    }
}
