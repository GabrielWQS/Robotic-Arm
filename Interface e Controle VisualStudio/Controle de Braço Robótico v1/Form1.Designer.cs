namespace Controle_de_Braço_Robótico_v1
{
    partial class Form1
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
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btt_PosicaoInicial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.numUpDown_Velocidade = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btt_Limpar = new System.Windows.Forms.Button();
            this.Btt_DesligarServo = new System.Windows.Forms.Button();
            this.groupBox_Serial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Velocidade)).BeginInit();
            this.groupBox9.SuspendLayout();
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
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 20);
            this.trackBar2.Maximum = 150;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(358, 45);
            this.trackBar2.SmallChange = 2;
            this.trackBar2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Location = new System.Drawing.Point(449, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 75);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GARRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "150";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Location = new System.Drawing.Point(449, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 75);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PULSO ROTAÇÃO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "150";
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Maximum = 150;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(358, 45);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 3;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(6, 19);
            this.trackBar3.Maximum = 150;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(358, 45);
            this.trackBar3.SmallChange = 2;
            this.trackBar3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Location = new System.Drawing.Point(449, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PULSO ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "150";
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
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(6, 19);
            this.trackBar4.Maximum = 150;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(358, 45);
            this.trackBar4.SmallChange = 2;
            this.trackBar4.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.trackBar4);
            this.groupBox4.Location = new System.Drawing.Point(449, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 75);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "COTOVELO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "150";
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
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(6, 19);
            this.trackBar5.Maximum = 150;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(358, 45);
            this.trackBar5.SmallChange = 2;
            this.trackBar5.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.trackBar5);
            this.groupBox5.Location = new System.Drawing.Point(449, 365);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(418, 75);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OMBRO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "150";
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
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(6, 19);
            this.trackBar6.Maximum = 150;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(358, 45);
            this.trackBar6.SmallChange = 2;
            this.trackBar6.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.trackBar6);
            this.groupBox6.Location = new System.Drawing.Point(449, 446);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(418, 75);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TRONCO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "150";
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btt_PosicaoInicial);
            this.groupBox7.Location = new System.Drawing.Point(198, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(245, 450);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "POSIÇÕES SALVAS";
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
            this.label1.Location = new System.Drawing.Point(873, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "INFO";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(876, 66);
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
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.numUpDown_Velocidade);
            this.groupBox9.Location = new System.Drawing.Point(15, 192);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(177, 108);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "VELOCIDADE";
            // 
            // btt_Limpar
            // 
            this.btt_Limpar.Location = new System.Drawing.Point(1147, 29);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 537);
            this.Controls.Add(this.Btt_DesligarServo);
            this.Controls.Add(this.btt_Limpar);
            this.Controls.Add(this.btt_LigarServo);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_Serial);
            this.MaximumSize = new System.Drawing.Size(1250, 576);
            this.MinimumSize = new System.Drawing.Size(1250, 576);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox_Serial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Velocidade)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox_Serial;
        private System.Windows.Forms.ComboBox cBox_BaudRate;
        private System.Windows.Forms.ComboBox cBox_COM;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btt_LigarServo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.NumericUpDown numUpDown_Velocidade;
        private System.Windows.Forms.GroupBox groupBox9;
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
    }
}

