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
        int pos_0, pos_1_2, pos_3, pos_4, pos_5, pos_6;
        int tempo = 10;

        ControleSerial novaComunicacao = new ControleSerial();

        public String posicaoInicial()
        {
            

            pos_0 = 50;//Tronco
            pos_1_2 = 40;//Ombro
            pos_3 = 0;//Cotovelo
            pos_4 = 170;//Pulso
            pos_5 = 10;//Rotação Pulso
            pos_6 = 0;//Garra

            String movimento = concatenar(pos_0, pos_1_2, pos_3, pos_4, pos_5, pos_6);

            return movimento;
        }

        public String concatenar(int pos_0, int pos_1_2, int pos_3, int pos_4, int pos_5, int pos_6)
        {
            String movimento;

            movimento = "M " + Convert.ToString(pos_0) + " " +
                Convert.ToString(pos_1_2) + " " +
                Convert.ToString(pos_3) + " " +
                Convert.ToString(pos_4) + " " +
                Convert.ToString(pos_5) + " " +
                Convert.ToString(pos_6);

            return movimento;
        }


    }
}
