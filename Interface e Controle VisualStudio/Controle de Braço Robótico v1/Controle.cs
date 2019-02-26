using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Braço_Robótico_v1
{
    class Controle
    {
        int[] servo = { 0, 1, 2, 3, 4, 5, 6 };
        int[] posicao = new int[6];
        int tempo = 10;

        ControleSerial NovaComunicacao = new ControleSerial();

        //seta valor de posição inicial
        public string InicialPosition()
        {          
            posicao[0] = 50;    //Tronco
            posicao[1] = 40;    //Ombro
            posicao[3] = 0;     //Cotovelo
            posicao[4] = 170;   //Pulso
            posicao[5] = 10;    //Rotação Pulso
            posicao[6] = 0;     //Garra

            String movimento = Concat(posicao);

            return movimento;
        }

        //concatena as posições a serem enviadas pela serial
        public string Concat(int [] posicao)
        {
            string movimento;

            movimento = "M " + 
                Convert.ToString(posicao[0]) + "|" +
                Convert.ToString(posicao[1]) + "|" +
                Convert.ToString(posicao[2]) + "|" +
                Convert.ToString(posicao[3]) + "|" +
                Convert.ToString(posicao[4]) + "|" +
                Convert.ToString(posicao[5]);

            return movimento;
        }

        //Método que chama a comunicação serial para realizar o movimento dos servos
        public void Move_Arm(int [] posicao)
        {
            string movimentString = Concat(posicao);


        }

    }
}
