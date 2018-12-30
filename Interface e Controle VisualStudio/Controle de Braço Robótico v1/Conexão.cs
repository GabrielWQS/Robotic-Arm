using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Braço_Robótico_v1
{
    class Conexão
    {
        SerialPort SerialComPort = new SerialPort();//Cria classe SerialPort
        Mensagem Msg = new Mensagem();

        public SerialPort Conectar(int baud, String COM)
        {
            try
            {
                SerialComPort.PortName = COM;//Definindo a porta e os parâmetros para ela, no caso a porta COM1
                SerialComPort.BaudRate = baud; //Velocidade de transmissão de dados

                SerialComPort.Parity = Parity.None; //Sem paridade alguma
                SerialComPort.StopBits = StopBits.One; //Usado para comparação de dados
                SerialComPort.ReadTimeout = 500;   //Usado para um limite de leitura de dado
                SerialComPort.Open(); //Abre Porta Serial*/

                return SerialComPort;
            }
            catch
            {
                return SerialComPort;
            }
        }

        public SerialPort Encerrar()
        {
            SerialComPort.Close();//Fecha Porta Serial

            return SerialComPort;
        }
    }
}
