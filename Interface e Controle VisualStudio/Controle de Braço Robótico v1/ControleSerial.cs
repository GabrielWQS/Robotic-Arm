using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;//necessário incluir para acessar os periféricos = SerialPort

namespace Controle_de_Braço_Robótico_v1 
{
    class ControleSerial
    {
        SerialPort SerialComPort = new SerialPort();//Cria classe SerialPort
        Mensagem Msg = new Mensagem();
        Conexão Conn = new Conexão();

        public string LigarServos(int baud, String COM)
        {
            string result = "";

            try
            {
                this.SerialComPort = Conn.Conectar(baud, COM);
                SerialComPort.WriteLine("START");  //Linha para envio de informação pela Serial
                SerialComPort.Close(); //Fecha Porta Serial
                Conn.Encerrar();

                result = Msg.MensagemSucesso(101);
            }
            catch
            {
                result = Msg.MensagemErro(101);
            }

            return result + "START";
        }

        public string DesligarServos(int baud, String COM)
        {
            string result = "";

            try
            {
                this.SerialComPort = Conn.Conectar(baud, COM);
                SerialComPort.WriteLine("STOP");  //Linha para envio de informação pela Serial
                SerialComPort.Close(); //Fecha Porta Serial
                Conn.Encerrar();

                result = Msg.MensagemSucesso(101);
            }
            catch
            {
                result = Msg.MensagemErro(101);
            }

            return result + "STOP";
        }

        public void EnviarDados(int baud, String COM, String movimento)
        {

        }

        public void Velocidade(int baud, String COM, int v)
        {

        }

        
       
    }
}

