using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Braço_Robótico_v1
{
    class Mensagem
    {
        string result = "";
        public string MensagemErro(int msgID)
        {
            switch (msgID)
            {
                case 100:
                    result = "Ocorreu um erro na configuração serial";
                    break;
                case 101:
                    result = "Ocorreu um erro no envio pela serial - WriteLine: ";
                    break;
                case 102:
                    result = "Ocorreu um erro ao encerrar a conexão serial";
                    break;

                default:
                    result = "Erro não definido";
                    break;
            }

            return result;
        }

        public string MensagemSucesso(int msgID)
        {
            switch (msgID)
            {
                case 100:
                    result = "Conexão serial definida";
                    break;
                case 101:
                    result = "Envio executado com sucesso - WriteLine: ";
                    break;
                case 102:
                    result = "Conexão serial encerrada";
                    break;

                default:
                    break;
            }

            return result;
        }

        public string MensagemInfo(int msgID)
        {
            switch (msgID)
            {
                case 101:
                    result = "Ocorreu um erro na configuração serial";
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}
