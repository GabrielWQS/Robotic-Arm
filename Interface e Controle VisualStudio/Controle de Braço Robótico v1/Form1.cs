using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO.Ports; //necessário incluir para acessar os periféricos = SerialPort


namespace Controle_de_Braço_Robótico_v1
{
    public partial class Form1 : Form
    {
        ControleSerial Comununicacao = new ControleSerial();//Instanciando a classe para comunicação serial

        int BaudRate = 0;
        string ComPort = "";
        int numPos = 6;
        string retorno = "";

        public Form1()
        {
            InitializeComponent();

            Config();

            CarregaBaudRate();
            CarregaComPort();    
        }

        public void CarregaComPort()                        //Identifica todos os dispositivos fisicos do seu hardware
        {
            //region - limitador para simplificar visualização

            String[] ListCom = SerialPort.GetPortNames();   //Retorna todas as portas disponíveis e armazena na variável
            int c = 0;
            for (int i = 0; i < ListCom.Length; i++)
            {
                cBox_COM.Items.Add(ListCom[i]);           //Insere os items ao combo box
                c = 0;                                      //Escolhe o ultimo elemento }(x = i);
            }
            if (ListCom.Length > 0)
            {
                cBox_COM.SelectedIndex = c;               /*Caso não haja porta apresenta zero no combo box
                                                             colocar try/catch para tratar excessões*/
            }
        }

        public void CarregaBaudRate()
        {
            Int32[] BaudRateValores = { 100, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200, 128000, 256000 };

            for (int i = 0; i < BaudRateValores.Length; i++)
            {
                cBox_BaudRate.Items.Add(BaudRateValores[i].ToString());
            }
            cBox_BaudRate.SelectedIndex = 6; //9600bps         
        }

        public void Config()
        {
            listBox.ClearSelected();
            listBox.Items.Add("\t\t\t Bem Vindo!");
            Btt_DesligarServo.Enabled = false;
        }

        private void Btt_LigarServo_Click(object sender, EventArgs e)
        {
            BaudRate = Convert.ToInt32(cBox_BaudRate.Text);//Valor da comboBox de BaudRate
            ComPort = cBox_COM.Text;//Porta COM

            retorno = Comununicacao.LigarServos(BaudRate, ComPort);
            btt_LigarServo.Enabled = false; Btt_DesligarServo.Enabled = true;
            listBox.Items.Add(retorno);
        }

        private void Btt_Desligar_Click(object sender, EventArgs e)
        {
            BaudRate = Convert.ToInt32(cBox_BaudRate.Text);//Valor da comboBox de BaudRate
            ComPort = cBox_COM.Text;//Porta COM

            retorno = Comununicacao.DesligarServos(BaudRate, ComPort);
            btt_LigarServo.Enabled = true; Btt_DesligarServo.Enabled = false;
            listBox.Items.Add(retorno);
        }

        private void Btt_Velocidade_Click(object sender, EventArgs e)
        {

        }

        private void Btt_PosicaoInicial_Click(object sender, EventArgs e)
        {

        }

        private void Btt_Limpar_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void Btt_Mover_Click(object sender, EventArgs e)
        {
            int[] posicao = new int[numPos];

            posicao[0] = tb_Garra.Value;
            posicao[1] = tb_Pulso_Rotacao.Value;
            posicao[2] = tb_Pulso.Value;
            posicao[3] = tb_Cotovelo.Value;
            posicao[4] = tb_Ombro.Value;
            posicao[5] = tb_Tronco.Value;

            if (cb_Mover.Checked)
            {
                Controle controle = new Controle();
                controle.Move_Arm(posicao);
            }
        }

        private void cb_Mover_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] posicao = new int[numPos];

            posicao[0] = tb_Garra.Value;
            posicao[1] = tb_Pulso_Rotacao.Value;
            posicao[2] = tb_Pulso.Value;
            posicao[3] = tb_Cotovelo.Value;
            posicao[4] = tb_Ombro.Value;
            posicao[5] = tb_Tronco.Value;

            if (!cb_Mover.Checked)
            {
                Controle controle = new Controle();
                //controle.Concat(posicao);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            retorno = Comununicacao.DesligarServos(BaudRate, ComPort);
        }
    }
}
