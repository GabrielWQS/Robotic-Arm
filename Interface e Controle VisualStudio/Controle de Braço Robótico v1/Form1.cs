using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO.Ports; //necessário incluir para acessar os periféricos = SerialPort


namespace Controle_de_Braço_Robótico_v1
{
    public partial class RoboticArm : Form
    {
        SendData sendData = new SendData();
        SerialPort SerialPortCom = new SerialPort();

        int BaudRate = 0;
        string ComPort = "";
        int numPos = 6;
        string retorno = "";

        public RoboticArm()
        {
            InitializeComponent();

            Config();

            LoadBaudRate();
            LoadComPort();    
        }

        public void LoadComPort()
        {
            String[] ListCom = SerialPort.GetPortNames();   
            int c = 0;
            for (int i = 0; i < ListCom.Length; i++)
            {
                cBox_COM.Items.Add(ListCom[i]);           
                c = 0;                                     
            }
            if (ListCom.Length > 0)
            {
                cBox_COM.SelectedIndex = c;               
            }
        }

        public void LoadBaudRate()
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
            BTT_STOP_SERVO.Enabled = false;
        }

        private void Btt_StartServo_Click(object sender, EventArgs e)
        {
            BaudRate = Convert.ToInt32(cBox_BaudRate.Text);
            ComPort = cBox_COM.Text;

            SerialPortCom = new SerialPort(ComPort, BaudRate);
            sendData.StartServos(SerialPortCom);

            BTT_START_SERVO.Enabled = false;
            BTT_STOP_SERVO.Enabled = true;

            listBox.Items.Add(retorno);
        }

        private void Btt_StopServo_Click(object sender, EventArgs e)
        {
            BaudRate = Convert.ToInt32(cBox_BaudRate.Text);//Valor da comboBox de BaudRate
            ComPort = cBox_COM.Text;//Porta COM

            sendData.StopServos();
            BTT_START_SERVO.Enabled = true;
            BTT_STOP_SERVO.Enabled = false;
            listBox.Items.Add(retorno);
        }

        private void Btt_Limpar_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
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
                SendData controle = new SendData();
                //controle.Concat(posicao);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sendData.StopServos();
        }

        private void Btt_InitialPosition_Click(object sender, EventArgs e)
        {

        }

        private void Btt_Move_Click(object sender, EventArgs e)
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
                SendData controle = new SendData();
                controle.Move_Arm(SerialPortCom, posicao);//TODO enviar conexão
            }
        }
    }
}
