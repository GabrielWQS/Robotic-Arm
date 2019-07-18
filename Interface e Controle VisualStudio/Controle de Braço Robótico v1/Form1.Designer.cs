namespace Controle_de_Braço_Robótico_v1
{
    partial class RoboticArm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_Serial = new System.Windows.Forms.GroupBox();
            this.cBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.cBox_COM = new System.Windows.Forms.ComboBox();
            this.btt_LigarServo = new System.Windows.Forms.Button();
            this.tb_Garra = new System.Windows.Forms.TrackBar();
            this.groupBox_Garra = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_Pulso_Rotacao = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Pulso_Rotacao = new System.Windows.Forms.TrackBar();
            this.tb_Pulso = new System.Windows.Forms.TrackBar();
            this.groupBox_Pulso = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Cotovelo = new System.Windows.Forms.TrackBar();
            this.groupBox_Cotovelo = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Ombro = new System.Windows.Forms.TrackBar();
            this.groupBox_Ombro = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Tronco = new System.Windows.Forms.TrackBar();
            this.groupBox_Tronco = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_Posicoes_Salva = new System.Windows.Forms.GroupBox();
            this.btt_PosicaoInicial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.numUpDown_Velocidade = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Velocidade = new System.Windows.Forms.GroupBox();
            this.btt_Limpar = new System.Windows.Forms.Button();
            this.Btt_DesligarServo = new System.Windows.Forms.Button();
            this.btt_Mover = new System.Windows.Forms.Button();
            this.cb_Mover = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Serial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Garra)).BeginInit();
            this.groupBox_Garra.SuspendLayout();
            this.groupBox_Pulso_Rotacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Pulso_Rotacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Pulso)).BeginInit();
            this.groupBox_Pulso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Cotovelo)).BeginInit();
            this.groupBox_Cotovelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Ombro)).BeginInit();
            this.groupBox_Ombro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Tronco)).BeginInit();
            this.groupBox_Tronco.SuspendLayout();
            this.groupBox_Posicoes_Salva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Velocidade)).BeginInit();
            this.groupBox_Velocidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Serial
            // 
            this.groupBox_Serial.Controls.Add(this.cBox_BaudRate);
            this.groupBox_Serial.Controls.Add(this.cBox_COM);
            this.groupBox_Serial.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Serial.Name = "groupBox_Serial";
            this.groupBox_Serial.Size = new System.Drawing.Size(180, 104);
            this.groupBox_Serial.TabIndex = 0;
            this.groupBox_Serial.TabStop = false;
            this.groupBox_Serial.Text = "Comunicação Serial";
            // 
            // cBox_BaudRate
            // 
            this.cBox_BaudRate.FormattingEnabled = true;
            this.cBox_BaudRate.Location = new System.Drawing.Point(17, 68);
            this.cBox_BaudRate.Name = "cBox_BaudRate";
            this.cBox_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.cBox_BaudRate.TabIndex = 1;
            // 
            // cBox_COM
            // 
            this.cBox_COM.FormattingEnabled = true;
            this.cBox_COM.Location = new System.Drawing.Point(17, 41);
            this.cBox_COM.Name = "cBox_COM";
            this.cBox_COM.Size = new System.Drawing.Size(121, 21);
            this.cBox_COM.TabIndex = 0;
            // 
            // btt_LigarServo
            // 
            this.btt_LigarServo.Location = new System.Drawing.Point(29, 122);
            this.btt_LigarServo.Name = "btt_LigarServo";
            this.btt_LigarServo.Size = new System.Drawing.Size(134, 23);
            this.btt_LigarServo.TabIndex = 4;
            this.btt_LigarServo.Text = "LIGAR SERVOS";
            this.btt_LigarServo.UseVisualStyleBackColor = true;
            this.btt_LigarServo.Click += new System.EventHandler(this.Btt_LigarServo_Click);
            // 
            // tb_Garra
            // 
            this.tb_Garra.Location = new System.Drawing.Point(6, 20);
            this.tb_Garra.Maximum = 150;
            this.tb_Garra.Name = "tb_Garra";
            this.tb_Garra.Size = new System.Drawing.Size(358, 45);
            this.tb_Garra.SmallChange = 2;
            this.tb_Garra.TabIndex = 3;
            // 
            // groupBox_Garra
            // 
            this.groupBox_Garra.Controls.Add(this.label4);
            this.groupBox_Garra.Controls.Add(this.label3);
            this.groupBox_Garra.Controls.Add(this.tb_Garra);
            this.groupBox_Garra.Location = new System.Drawing.Point(198, 12);
            this.groupBox_Garra.Name = "groupBox_Garra";
            this.groupBox_Garra.Size = new System.Drawing.Size(418, 75);
            this.groupBox_Garra.TabIndex = 10;
            this.groupBox_Garra.TabStop = false;
            this.groupBox_Garra.Text = "GARRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "180";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // groupBox_Pulso_Rotacao
            // 
            this.groupBox_Pulso_Rotacao.Controls.Add(this.label10);
            this.groupBox_Pulso_Rotacao.Controls.Add(this.label5);
            this.groupBox_Pulso_Rotacao.Controls.Add(this.tb_Pulso_Rotacao);
            this.groupBox_Pulso_Rotacao.Location = new System.Drawing.Point(198, 93);
            this.groupBox_Pulso_Rotacao.Name = "groupBox_Pulso_Rotacao";
            this.groupBox_Pulso_Rotacao.Size = new System.Drawing.Size(418, 75);
            this.groupBox_Pulso_Rotacao.TabIndex = 11;
            this.groupBox_Pulso_Rotacao.TabStop = false;
            this.groupBox_Pulso_Rotacao.Text = "PULSO ROTAÇÃO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "180";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            // 
            // tb_Pulso_Rotacao
            // 
            this.tb_Pulso_Rotacao.Location = new System.Drawing.Point(6, 19);
            this.tb_Pulso_Rotacao.Maximum = 150;
            this.tb_Pulso_Rotacao.Name = "tb_Pulso_Rotacao";
            this.tb_Pulso_Rotacao.Size = new System.Drawing.Size(358, 45);
            this.tb_Pulso_Rotacao.SmallChange = 2;
            this.tb_Pulso_Rotacao.TabIndex = 3;
            // 
            // tb_Pulso
            // 
            this.tb_Pulso.Location = new System.Drawing.Point(6, 18);
            this.tb_Pulso.Maximum = 150;
            this.tb_Pulso.Name = "tb_Pulso";
            this.tb_Pulso.Size = new System.Drawing.Size(358, 45);
            this.tb_Pulso.SmallChange = 2;
            this.tb_Pulso.TabIndex = 3;
            // 
            // groupBox_Pulso
            // 
            this.groupBox_Pulso.Controls.Add(this.label11);
            this.groupBox_Pulso.Controls.Add(this.label8);
            this.groupBox_Pulso.Controls.Add(this.tb_Pulso);
            this.groupBox_Pulso.Location = new System.Drawing.Point(198, 174);
            this.groupBox_Pulso.Name = "groupBox_Pulso";
            this.groupBox_Pulso.Size = new System.Drawing.Size(418, 75);
            this.groupBox_Pulso.TabIndex = 12;
            this.groupBox_Pulso.TabStop = false;
            this.groupBox_Pulso.Text = "PULSO ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "180";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "0";
            // 
            // tb_Cotovelo
            // 
            this.tb_Cotovelo.Location = new System.Drawing.Point(6, 19);
            this.tb_Cotovelo.Maximum = 150;
            this.tb_Cotovelo.Name = "tb_Cotovelo";
            this.tb_Cotovelo.Size = new System.Drawing.Size(358, 45);
            this.tb_Cotovelo.SmallChange = 2;
            this.tb_Cotovelo.TabIndex = 3;
            // 
            // groupBox_Cotovelo
            // 
            this.groupBox_Cotovelo.Controls.Add(this.label12);
            this.groupBox_Cotovelo.Controls.Add(this.label6);
            this.groupBox_Cotovelo.Controls.Add(this.tb_Cotovelo);
            this.groupBox_Cotovelo.Location = new System.Drawing.Point(198, 255);
            this.groupBox_Cotovelo.Name = "groupBox_Cotovelo";
            this.groupBox_Cotovelo.Size = new System.Drawing.Size(418, 75);
            this.groupBox_Cotovelo.TabIndex = 12;
            this.groupBox_Cotovelo.TabStop = false;
            this.groupBox_Cotovelo.Text = "COTOVELO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "180";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "0";
            // 
            // tb_Ombro
            // 
            this.tb_Ombro.Location = new System.Drawing.Point(6, 19);
            this.tb_Ombro.Maximum = 150;
            this.tb_Ombro.Name = "tb_Ombro";
            this.tb_Ombro.Size = new System.Drawing.Size(358, 45);
            this.tb_Ombro.SmallChange = 2;
            this.tb_Ombro.TabIndex = 3;
            // 
            // groupBox_Ombro
            // 
            this.groupBox_Ombro.Controls.Add(this.label13);
            this.groupBox_Ombro.Controls.Add(this.label7);
            this.groupBox_Ombro.Controls.Add(this.tb_Ombro);
            this.groupBox_Ombro.Location = new System.Drawing.Point(198, 336);
            this.groupBox_Ombro.Name = "groupBox_Ombro";
            this.groupBox_Ombro.Size = new System.Drawing.Size(418, 75);
            this.groupBox_Ombro.TabIndex = 12;
            this.groupBox_Ombro.TabStop = false;
            this.groupBox_Ombro.Text = "OMBRO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "180";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "0";
            // 
            // tb_Tronco
            // 
            this.tb_Tronco.Location = new System.Drawing.Point(6, 19);
            this.tb_Tronco.Maximum = 150;
            this.tb_Tronco.Name = "tb_Tronco";
            this.tb_Tronco.Size = new System.Drawing.Size(358, 45);
            this.tb_Tronco.SmallChange = 2;
            this.tb_Tronco.TabIndex = 3;
            // 
            // groupBox_Tronco
            // 
            this.groupBox_Tronco.Controls.Add(this.label14);
            this.groupBox_Tronco.Controls.Add(this.label9);
            this.groupBox_Tronco.Controls.Add(this.tb_Tronco);
            this.groupBox_Tronco.Location = new System.Drawing.Point(198, 417);
            this.groupBox_Tronco.Name = "groupBox_Tronco";
            this.groupBox_Tronco.Size = new System.Drawing.Size(418, 75);
            this.groupBox_Tronco.TabIndex = 12;
            this.groupBox_Tronco.TabStop = false;
            this.groupBox_Tronco.Text = "TRONCO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "180";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "0";
            // 
            // groupBox_Posicoes_Salva
            // 
            this.groupBox_Posicoes_Salva.Controls.Add(this.btt_PosicaoInicial);
            this.groupBox_Posicoes_Salva.Location = new System.Drawing.Point(15, 306);
            this.groupBox_Posicoes_Salva.Name = "groupBox_Posicoes_Salva";
            this.groupBox_Posicoes_Salva.Size = new System.Drawing.Size(177, 215);
            this.groupBox_Posicoes_Salva.TabIndex = 15;
            this.groupBox_Posicoes_Salva.TabStop = false;
            this.groupBox_Posicoes_Salva.Text = "POSIÇÕES SALVAS";
            // 
            // btt_PosicaoInicial
            // 
            this.btt_PosicaoInicial.Location = new System.Drawing.Point(6, 29);
            this.btt_PosicaoInicial.Name = "btt_PosicaoInicial";
            this.btt_PosicaoInicial.Size = new System.Drawing.Size(95, 23);
            this.btt_PosicaoInicial.TabIndex = 0;
            this.btt_PosicaoInicial.Text = "Posição Inicial";
            this.btt_PosicaoInicial.UseVisualStyleBackColor = true;
            this.btt_PosicaoInicial.Click += new System.EventHandler(this.Btt_PosicaoInicial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "INFO";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(625, 66);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(346, 459);
            this.listBox.TabIndex = 18;
            // 
            // numUpDown_Velocidade
            // 
            this.numUpDown_Velocidade.Location = new System.Drawing.Point(17, 25);
            this.numUpDown_Velocidade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDown_Velocidade.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numUpDown_Velocidade.Name = "numUpDown_Velocidade";
            this.numUpDown_Velocidade.Size = new System.Drawing.Size(120, 20);
            this.numUpDown_Velocidade.TabIndex = 9;
            this.numUpDown_Velocidade.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox_Velocidade
            // 
            this.groupBox_Velocidade.Controls.Add(this.numUpDown_Velocidade);
            this.groupBox_Velocidade.Location = new System.Drawing.Point(15, 192);
            this.groupBox_Velocidade.Name = "groupBox_Velocidade";
            this.groupBox_Velocidade.Size = new System.Drawing.Size(177, 108);
            this.groupBox_Velocidade.TabIndex = 11;
            this.groupBox_Velocidade.TabStop = false;
            this.groupBox_Velocidade.Text = "VELOCIDADE";
            // 
            // btt_Limpar
            // 
            this.btt_Limpar.Location = new System.Drawing.Point(896, 29);
            this.btt_Limpar.Name = "btt_Limpar";
            this.btt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btt_Limpar.TabIndex = 22;
            this.btt_Limpar.Text = "LIMPAR";
            this.btt_Limpar.UseVisualStyleBackColor = true;
            this.btt_Limpar.Click += new System.EventHandler(this.Btt_Limpar_Click);
            // 
            // Btt_DesligarServo
            // 
            this.Btt_DesligarServo.Location = new System.Drawing.Point(29, 151);
            this.Btt_DesligarServo.Name = "Btt_DesligarServo";
            this.Btt_DesligarServo.Size = new System.Drawing.Size(134, 23);
            this.Btt_DesligarServo.TabIndex = 23;
            this.Btt_DesligarServo.Text = "DESLIGAR SERVOS";
            this.Btt_DesligarServo.UseVisualStyleBackColor = true;
            this.Btt_DesligarServo.Click += new System.EventHandler(this.Btt_Desligar_Click);
            // 
            // btt_Mover
            // 
            this.btt_Mover.Location = new System.Drawing.Point(402, 498);
            this.btt_Mover.Name = "btt_Mover";
            this.btt_Mover.Size = new System.Drawing.Size(82, 23);
            this.btt_Mover.TabIndex = 24;
            this.btt_Mover.Text = "Mover";
            this.btt_Mover.UseVisualStyleBackColor = true;
            this.btt_Mover.Click += new System.EventHandler(this.Btt_Mover_Click);
            // 
            // cb_Mover
            // 
            this.cb_Mover.AutoSize = true;
            this.cb_Mover.Location = new System.Drawing.Point(249, 502);
            this.cb_Mover.Name = "cb_Mover";
            this.cb_Mover.Size = new System.Drawing.Size(147, 17);
            this.cb_Mover.TabIndex = 25;
            this.cb_Mover.Text = "Movimentar ao pressionar";
            this.cb_Mover.UseVisualStyleBackColor = true;
            this.cb_Mover.CheckedChanged += new System.EventHandler(this.cb_Mover_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RoboticArm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 537);
            this.Controls.Add(this.cb_Mover);
            this.Controls.Add(this.btt_Mover);
            this.Controls.Add(this.Btt_DesligarServo);
            this.Controls.Add(this.btt_Limpar);
            this.Controls.Add(this.btt_LigarServo);
            this.Controls.Add(this.groupBox_Velocidade);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_Posicoes_Salva);
            this.Controls.Add(this.groupBox_Tronco);
            this.Controls.Add(this.groupBox_Ombro);
            this.Controls.Add(this.groupBox_Cotovelo);
            this.Controls.Add(this.groupBox_Pulso);
            this.Controls.Add(this.groupBox_Pulso_Rotacao);
            this.Controls.Add(this.groupBox_Garra);
            this.Controls.Add(this.groupBox_Serial);
            this.MaximumSize = new System.Drawing.Size(1000, 576);
            this.MinimumSize = new System.Drawing.Size(1000, 576);
            this.Name = "RoboticArm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox_Serial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Garra)).EndInit();
            this.groupBox_Garra.ResumeLayout(false);
            this.groupBox_Garra.PerformLayout();
            this.groupBox_Pulso_Rotacao.ResumeLayout(false);
            this.groupBox_Pulso_Rotacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Pulso_Rotacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Pulso)).EndInit();
            this.groupBox_Pulso.ResumeLayout(false);
            this.groupBox_Pulso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Cotovelo)).EndInit();
            this.groupBox_Cotovelo.ResumeLayout(false);
            this.groupBox_Cotovelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Ombro)).EndInit();
            this.groupBox_Ombro.ResumeLayout(false);
            this.groupBox_Ombro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Tronco)).EndInit();
            this.groupBox_Tronco.ResumeLayout(false);
            this.groupBox_Tronco.PerformLayout();
            this.groupBox_Posicoes_Salva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Velocidade)).EndInit();
            this.groupBox_Velocidade.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox_Serial;
        private System.Windows.Forms.ComboBox cBox_BaudRate;
        private System.Windows.Forms.ComboBox cBox_COM;
        private System.Windows.Forms.TrackBar tb_Garra;
        private System.Windows.Forms.GroupBox groupBox_Garra;
        private System.Windows.Forms.GroupBox groupBox_Pulso_Rotacao;
        private System.Windows.Forms.TrackBar tb_Pulso_Rotacao;
        private System.Windows.Forms.TrackBar tb_Pulso;
        private System.Windows.Forms.GroupBox groupBox_Pulso;
        private System.Windows.Forms.TrackBar tb_Cotovelo;
        private System.Windows.Forms.GroupBox groupBox_Cotovelo;
        private System.Windows.Forms.TrackBar tb_Ombro;
        private System.Windows.Forms.GroupBox groupBox_Ombro;
        private System.Windows.Forms.TrackBar tb_Tronco;
        private System.Windows.Forms.GroupBox groupBox_Tronco;
        private System.Windows.Forms.GroupBox groupBox_Posicoes_Salva;
        private System.Windows.Forms.Button btt_LigarServo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.NumericUpDown numUpDown_Velocidade;
        private System.Windows.Forms.GroupBox groupBox_Velocidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btt_Limpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btt_PosicaoInicial;
        private System.Windows.Forms.Button Btt_DesligarServo;
        private System.Windows.Forms.Button btt_Mover;
        private System.Windows.Forms.CheckBox cb_Mover;
        private System.Windows.Forms.Timer timer1;
    }
}

