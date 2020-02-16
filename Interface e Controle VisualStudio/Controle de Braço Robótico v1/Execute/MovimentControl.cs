using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Braço_Robótico_v1.Execute
{
    public static class MovimentControl
    {
        //Concat all servo positions 
        public static string Concat(int[] position)
        {
            string moviment;

            moviment =
                "[" +
                Convert.ToString(position[0]) + "|" +
                Convert.ToString(position[1]) + "|" +
                Convert.ToString(position[2]) + "|" +
                Convert.ToString(position[3]) + "|" +
                Convert.ToString(position[4]) + "|" +
                Convert.ToString(position[5]) + "|" +
                Convert.ToString(position[6]) + "|"
                + "]";

            return moviment;
        }

        public static void Move(int[] position)
        {
            string moviment = Concat(position);

            SendData.SerialWrite(moviment);
        }
    }
}
