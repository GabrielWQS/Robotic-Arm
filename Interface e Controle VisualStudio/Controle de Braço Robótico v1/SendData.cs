using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Braço_Robótico_v1
{
    class SendData
    {
        SerialPort SerialComPort = new SerialPort();//Cria classe SerialPort
        DefaultMsg Msg = new DefaultMsg();

        int[] servo = { 0, 1, 2, 3, 4, 5, 6 };
        int[] posicao = new int[7]; //0 até 6

        public void StartServos(SerialPort SerialComPort)
        {
            string result = "";

            try
            {
                SerialComPort.Open();
                SerialComPort.WriteLine("START\n");
                SerialComPort.Close();

                result = Msg.retonaMensagem(101);
            }
            catch
            {
                result = Msg.retonaMensagem(201);
            }
        }

        public void StopServos()
        {
            string result = "";

            try
            {
                SerialComPort.Open();
                SerialComPort.WriteLine("STOP\n");  
                SerialComPort.Close(); 

                result = Msg.retonaMensagem(101);
            }
            catch
            {
                result = Msg.retonaMensagem(201);
            }
        }

        //concatena as posições a serem enviadas pela serial
        public string Concat(int [] posicao)
        {
            string movimento;

            movimento = 
                "[" + 
                Convert.ToString(posicao[0]) + "|" +
                Convert.ToString(posicao[1]) + "|" +
                Convert.ToString(posicao[2]) + "|" +
                Convert.ToString(posicao[3]) + "|" +
                Convert.ToString(posicao[4]) + "|" +
                Convert.ToString(posicao[5]) + "|" +
                Convert.ToString(posicao[6]) + "|"
                + "]" ;

            return movimento;
        }

        //Método que chama a comunicação serial para realizar o movimento dos servos
        public void Move_Arm(SerialPort SerialComPort, int [] posicao)
        {
            string movimentString = Concat(posicao);

            try
            {
                SerialComPort.Open();

            }
            catch(Exception e)
            {
                throw new Exception(e.Message, e);
            }
            

        }

    }
}
