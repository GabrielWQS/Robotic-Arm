﻿using System;
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

        public string LigarServos(int baud, string COM)
        {
            string result = "";

            try
            {
                this.SerialComPort = Conn.Conectar(baud, COM);
                SerialComPort.WriteLine("START\n");  //Linha para envio de informação pela Serial
                SerialComPort.Close(); //Fecha Porta Serial
                Conn.Encerrar();

                result = Msg.retonaMensagem(101);
            }
            catch
            {
                result = Msg.retonaMensagem(201);
            }

            return result + " [START]";
        }

        public string DesligarServos(int baud, string COM)
        {
            string result = "";

            try
            {
                this.SerialComPort = Conn.Conectar(baud, COM);
                SerialComPort.WriteLine("STOP\n");  //Linha para envio de informação pela Serial
                SerialComPort.Close(); //Fecha Porta Serial
                Conn.Encerrar();

                result = Msg.retonaMensagem(101);
            }
            catch
            {
                result = Msg.retonaMensagem(201);
            }

            return result + " [STOP]";
        }

        public void EnviarDados()
        {
            EnviarDados(1, "", "");
        }

        public void EnviarDados(int baud, string COM, string movimento)
        {

        }

        public void Velocidade(int baud, string COM, int v)
        {

        }

        
       
    }
}

