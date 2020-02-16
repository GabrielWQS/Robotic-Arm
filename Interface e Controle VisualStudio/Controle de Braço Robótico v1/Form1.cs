using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO.Ports; //necessário incluir para acessar os periféricos = SerialPortusigin 
using Controle_de_Braço_Robótico_v1.Util;
using Controle_de_Braço_Robótico_v1.Execute;

namespace Controle_de_Braço_Robótico_v1
{
    public partial class RoboticArm : Form
    {
        SerialPort SerialPortCom = new SerialPort();

        int BaudRate = 0;
        string ComPort = "";

        public RoboticArm()
        {
            InitializeComponent();

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


        private void Btt_StartServo_Click(object sender, EventArgs e)
        {
            SendData.SerialWrite(Constants.START);

            BTN_START_SERVO.Enabled = false;
            BTT_STOP_SERVO.Enabled = true;

            listBox.Items.Add(Constants.START);
        }

        private void Btt_StopServo_Click(object sender, EventArgs e)
        {
            SendData.SerialWrite(Constants.STOP);

            BTN_START_SERVO.Enabled = true;
            BTT_STOP_SERVO.Enabled = false;

            listBox.Items.Add(Constants.STOP);
        }

        private void Btt_Limpar_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] posicao = new int[Constants.NUMOFSERVOS];

            posicao[0] = tb_Garra.Value;
            posicao[1] = tb_Pulso_Rotacao.Value;
            posicao[2] = tb_Pulso.Value;
            posicao[3] = tb_Cotovelo.Value;
            posicao[4] = tb_Ombro.Value;
            posicao[5] = tb_Tronco.Value;

            if (!cb_Mover.Checked)
            {
                //SendData controle = new SendData();
                //controle.Concat(posicao);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SendData.SerialWrite(Constants.STOP);
        }

        private void Btt_InitialPosition_Click(object sender, EventArgs e)
        {

        }

        private void Btt_Move_Click(object sender, EventArgs e)
        {
            int[] position = new int[Constants.NUMOFSERVOS];

            position[0] = tb_Garra.Value;
            position[1] = tb_Pulso_Rotacao.Value;
            position[2] = tb_Pulso.Value;
            position[3] = tb_Cotovelo.Value;
            position[4] = tb_Ombro.Value;
            position[5] = tb_Tronco.Value;

            if (cb_Mover.Checked)
            {
                string moviment = MovimentControl.Concat(position);
                SendData.SerialWrite(moviment);
            }
                
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            BaudRate = Convert.ToInt32(cBox_BaudRate.Text);
            ComPort = cBox_COM.Text;

            Config.SetSerialPortConfig(BaudRate, ComPort);

            //testar conexão
            //sucesso
            //listBox.ClearSelected();
            //listBox.Items.Add("\t\t\t Bem Vindo!");
            //BTT_STOP_SERVO.Enabled = false;
        }
    }
}
