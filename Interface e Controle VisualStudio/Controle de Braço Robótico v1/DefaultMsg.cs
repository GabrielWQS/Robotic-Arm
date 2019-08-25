using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Braço_Robótico_v1
{
    public class DefaultMsg
    {
        string result = "";
        public string retonaMensagem(int msgID)
        {
            switch (msgID)
            {
                //*********** Sucesso
                case 100:
                    result = "Conexão serial definida";
                    break;
                case 101:
                    result = "Envio executado com sucesso - WriteLine: ";
                    break;
                case 102:
                    result = "Conexão serial encerrada";
                    break;

                //*********** Erro
                case 200:
                    result = "Ocorreu um erro ao abrir a configuração serial";
                    break;
                case 201:
                    result = "Ocorreu um erro no envio pela serial - WriteLine: ";
                    break;
                case 202:
                    result = "Ocorreu um erro ao encerrar a conexão serial";
                    break;

                default:
                    result = "Erro não definido";
                    break;
            }

            return result;
        }
    }
}
