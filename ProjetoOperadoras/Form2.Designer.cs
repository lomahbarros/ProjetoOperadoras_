namespace ProjetoOperadoras
{
    partial class Frm_02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker9 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker10 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker11 = new System.ComponentModel.BackgroundWorker();
            this.Grp_tela02_geral = new System.Windows.Forms.GroupBox();
            this.Msk_cel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_DDD = new System.Windows.Forms.TextBox();
            this.Lbl_DDD = new System.Windows.Forms.Label();
            this.Txt_operadoraselecionada = new System.Windows.Forms.TextBox();
            this.Txt_regiaoselecionada = new System.Windows.Forms.TextBox();
            this.Lbl_Operadoraselecionada = new System.Windows.Forms.Label();
            this.Lbl_regiao = new System.Windows.Forms.Label();
            this.Lbl_nomedooperadortela02 = new System.Windows.Forms.Label();
            this.Lbl_sejabemvindo = new System.Windows.Forms.Label();
            this.Grp_tela02_operadoras = new System.Windows.Forms.GroupBox();
            this.Btn_tela02_Oi = new System.Windows.Forms.RadioButton();
            this.Btn_tela02_Tim = new System.Windows.Forms.RadioButton();
            this.Btn_tela02_Vivo = new System.Windows.Forms.RadioButton();
            this.Btn_tela02_Claro = new System.Windows.Forms.RadioButton();
            this.Grp_tela02_selecionarrecarga = new System.Windows.Forms.GroupBox();
            this.Btn_recarga200 = new System.Windows.Forms.Button();
            this.Btn_recarga100 = new System.Windows.Forms.Button();
            this.Btn_recarga40 = new System.Windows.Forms.Button();
            this.Btn_recarga35 = new System.Windows.Forms.Button();
            this.Btn_recarga30 = new System.Windows.Forms.Button();
            this.Btn_recarga20 = new System.Windows.Forms.Button();
            this.Btn_recarga15 = new System.Windows.Forms.Button();
            this.Btn_recarga12 = new System.Windows.Forms.Button();
            this.Btn_conf_tema02 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Grp_tela02_geral.SuspendLayout();
            this.Grp_tela02_operadoras.SuspendLayout();
            this.Grp_tela02_selecionarrecarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_tela02_geral
            // 
            this.Grp_tela02_geral.BackColor = System.Drawing.Color.Transparent;
            this.Grp_tela02_geral.Controls.Add(this.Btn_conf_tema02);
            this.Grp_tela02_geral.Controls.Add(this.Grp_tela02_selecionarrecarga);
            this.Grp_tela02_geral.Controls.Add(this.pictureBox1);
            this.Grp_tela02_geral.Controls.Add(this.Msk_cel);
            this.Grp_tela02_geral.Controls.Add(this.label1);
            this.Grp_tela02_geral.Controls.Add(this.Txt_DDD);
            this.Grp_tela02_geral.Controls.Add(this.Lbl_DDD);
            this.Grp_tela02_geral.Controls.Add(this.Txt_operadoraselecionada);
            this.Grp_tela02_geral.Controls.Add(this.Txt_regiaoselecionada);
            this.Grp_tela02_geral.Controls.Add(this.Lbl_Operadoraselecionada);
            this.Grp_tela02_geral.Controls.Add(this.Lbl_regiao);
            this.Grp_tela02_geral.Controls.Add(this.Lbl_nomedooperadortela02);
            this.Grp_tela02_geral.Controls.Add(this.Lbl_sejabemvindo);
            this.Grp_tela02_geral.Controls.Add(this.Grp_tela02_operadoras);
            this.Grp_tela02_geral.Location = new System.Drawing.Point(12, 12);
            this.Grp_tela02_geral.Name = "Grp_tela02_geral";
            this.Grp_tela02_geral.Size = new System.Drawing.Size(1094, 548);
            this.Grp_tela02_geral.TabIndex = 0;
            this.Grp_tela02_geral.TabStop = false;
            this.Grp_tela02_geral.Text = "Dados da Recarga";
            // 
            // Msk_cel
            // 
            this.Msk_cel.Location = new System.Drawing.Point(463, 204);
            this.Msk_cel.Mask = "(0) 0000-0000 ";
            this.Msk_cel.Name = "Msk_cel";
            this.Msk_cel.Size = new System.Drawing.Size(122, 20);
            this.Msk_cel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Número do Celular";
            // 
            // Txt_DDD
            // 
            this.Txt_DDD.Enabled = false;
            this.Txt_DDD.Location = new System.Drawing.Point(302, 201);
            this.Txt_DDD.Name = "Txt_DDD";
            this.Txt_DDD.Size = new System.Drawing.Size(100, 20);
            this.Txt_DDD.TabIndex = 9;
            // 
            // Lbl_DDD
            // 
            this.Lbl_DDD.AutoSize = true;
            this.Lbl_DDD.Location = new System.Drawing.Point(310, 176);
            this.Lbl_DDD.Name = "Lbl_DDD";
            this.Lbl_DDD.Size = new System.Drawing.Size(31, 13);
            this.Lbl_DDD.TabIndex = 8;
            this.Lbl_DDD.Text = "DDD";
            // 
            // Txt_operadoraselecionada
            // 
            this.Txt_operadoraselecionada.Enabled = false;
            this.Txt_operadoraselecionada.Location = new System.Drawing.Point(490, 124);
            this.Txt_operadoraselecionada.Name = "Txt_operadoraselecionada";
            this.Txt_operadoraselecionada.Size = new System.Drawing.Size(154, 20);
            this.Txt_operadoraselecionada.TabIndex = 7;
            // 
            // Txt_regiaoselecionada
            // 
            this.Txt_regiaoselecionada.Enabled = false;
            this.Txt_regiaoselecionada.Location = new System.Drawing.Point(302, 124);
            this.Txt_regiaoselecionada.Name = "Txt_regiaoselecionada";
            this.Txt_regiaoselecionada.Size = new System.Drawing.Size(100, 20);
            this.Txt_regiaoselecionada.TabIndex = 6;
            // 
            // Lbl_Operadoraselecionada
            // 
            this.Lbl_Operadoraselecionada.AutoSize = true;
            this.Lbl_Operadoraselecionada.Location = new System.Drawing.Point(496, 108);
            this.Lbl_Operadoraselecionada.Name = "Lbl_Operadoraselecionada";
            this.Lbl_Operadoraselecionada.Size = new System.Drawing.Size(119, 13);
            this.Lbl_Operadoraselecionada.TabIndex = 5;
            this.Lbl_Operadoraselecionada.Text = "Operadora Selecionada";
            // 
            // Lbl_regiao
            // 
            this.Lbl_regiao.AutoSize = true;
            this.Lbl_regiao.Location = new System.Drawing.Point(310, 108);
            this.Lbl_regiao.Name = "Lbl_regiao";
            this.Lbl_regiao.Size = new System.Drawing.Size(41, 13);
            this.Lbl_regiao.TabIndex = 4;
            this.Lbl_regiao.Text = "Região";
            // 
            // Lbl_nomedooperadortela02
            // 
            this.Lbl_nomedooperadortela02.AutoSize = true;
            this.Lbl_nomedooperadortela02.Font = new System.Drawing.Font("Kunstler Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nomedooperadortela02.ForeColor = System.Drawing.Color.Black;
            this.Lbl_nomedooperadortela02.Location = new System.Drawing.Point(512, 64);
            this.Lbl_nomedooperadortela02.Name = "Lbl_nomedooperadortela02";
            this.Lbl_nomedooperadortela02.Size = new System.Drawing.Size(99, 35);
            this.Lbl_nomedooperadortela02.TabIndex = 3;
            this.Lbl_nomedooperadortela02.Text = "nomerecebe";
            this.Lbl_nomedooperadortela02.Click += new System.EventHandler(this.Lbl_nomedooperadortela02_Click);
            // 
            // Lbl_sejabemvindo
            // 
            this.Lbl_sejabemvindo.AutoSize = true;
            this.Lbl_sejabemvindo.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sejabemvindo.Location = new System.Drawing.Point(429, 16);
            this.Lbl_sejabemvindo.Name = "Lbl_sejabemvindo";
            this.Lbl_sejabemvindo.Size = new System.Drawing.Size(355, 48);
            this.Lbl_sejabemvindo.TabIndex = 2;
            this.Lbl_sejabemvindo.Text = "Seja bem Vindo (a)";
            this.Lbl_sejabemvindo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Grp_tela02_operadoras
            // 
            this.Grp_tela02_operadoras.Controls.Add(this.Btn_tela02_Oi);
            this.Grp_tela02_operadoras.Controls.Add(this.Btn_tela02_Tim);
            this.Grp_tela02_operadoras.Controls.Add(this.Btn_tela02_Vivo);
            this.Grp_tela02_operadoras.Controls.Add(this.Btn_tela02_Claro);
            this.Grp_tela02_operadoras.Location = new System.Drawing.Point(22, 31);
            this.Grp_tela02_operadoras.Name = "Grp_tela02_operadoras";
            this.Grp_tela02_operadoras.Size = new System.Drawing.Size(199, 242);
            this.Grp_tela02_operadoras.TabIndex = 1;
            this.Grp_tela02_operadoras.TabStop = false;
            this.Grp_tela02_operadoras.Text = "Operadoras";
            // 
            // Btn_tela02_Oi
            // 
            this.Btn_tela02_Oi.AutoSize = true;
            this.Btn_tela02_Oi.Location = new System.Drawing.Point(23, 200);
            this.Btn_tela02_Oi.Name = "Btn_tela02_Oi";
            this.Btn_tela02_Oi.Size = new System.Drawing.Size(35, 17);
            this.Btn_tela02_Oi.TabIndex = 26;
            this.Btn_tela02_Oi.Text = "Oi";
            this.Btn_tela02_Oi.UseVisualStyleBackColor = true;
            this.Btn_tela02_Oi.CheckedChanged += new System.EventHandler(this.Btn_tela02_Oi_CheckedChanged);
            // 
            // Btn_tela02_Tim
            // 
            this.Btn_tela02_Tim.AutoSize = true;
            this.Btn_tela02_Tim.Location = new System.Drawing.Point(23, 141);
            this.Btn_tela02_Tim.Name = "Btn_tela02_Tim";
            this.Btn_tela02_Tim.Size = new System.Drawing.Size(42, 17);
            this.Btn_tela02_Tim.TabIndex = 25;
            this.Btn_tela02_Tim.Text = "Tim";
            this.Btn_tela02_Tim.UseVisualStyleBackColor = true;
            this.Btn_tela02_Tim.CheckedChanged += new System.EventHandler(this.Btn_tela02_Tim_CheckedChanged);
            // 
            // Btn_tela02_Vivo
            // 
            this.Btn_tela02_Vivo.AutoSize = true;
            this.Btn_tela02_Vivo.Location = new System.Drawing.Point(23, 89);
            this.Btn_tela02_Vivo.Name = "Btn_tela02_Vivo";
            this.Btn_tela02_Vivo.Size = new System.Drawing.Size(46, 17);
            this.Btn_tela02_Vivo.TabIndex = 24;
            this.Btn_tela02_Vivo.Text = "Vivo";
            this.Btn_tela02_Vivo.UseVisualStyleBackColor = true;
            this.Btn_tela02_Vivo.CheckedChanged += new System.EventHandler(this.Btn_tela02_Vivo_CheckedChanged);
            // 
            // Btn_tela02_Claro
            // 
            this.Btn_tela02_Claro.AutoSize = true;
            this.Btn_tela02_Claro.Location = new System.Drawing.Point(23, 35);
            this.Btn_tela02_Claro.Name = "Btn_tela02_Claro";
            this.Btn_tela02_Claro.Size = new System.Drawing.Size(49, 17);
            this.Btn_tela02_Claro.TabIndex = 23;
            this.Btn_tela02_Claro.Text = "Claro";
            this.Btn_tela02_Claro.UseVisualStyleBackColor = true;
            this.Btn_tela02_Claro.CheckedChanged += new System.EventHandler(this.Btn_tela02_Claro_CheckedChanged);
            // 
            // Grp_tela02_selecionarrecarga
            // 
            this.Grp_tela02_selecionarrecarga.Controls.Add(this.Btn_recarga200);
            this.Grp_tela02_selecionarrecarga.Controls.Add(this.Btn_recarga100);
            this.Grp_tela02_selecionarrecarga.Controls.Add(this.Btn_recarga40);
            this.Grp_tela02_selecionarrecarga.Controls.Add(this.Btn_recarga35);
            this.Grp_tela02_selecionarrecarga.Controls.Add(this.Btn_recarga30);
            this.Grp_tela02_selecionarrecarga.Controls.Add(this.Btn_recarga20);
            this.Grp_tela02_selecionarrecarga.Controls.Add(this.Btn_recarga15);
            this.Grp_tela02_selecionarrecarga.Controls.Add(this.Btn_recarga12);
            this.Grp_tela02_selecionarrecarga.Location = new System.Drawing.Point(288, 276);
            this.Grp_tela02_selecionarrecarga.Name = "Grp_tela02_selecionarrecarga";
            this.Grp_tela02_selecionarrecarga.Size = new System.Drawing.Size(739, 271);
            this.Grp_tela02_selecionarrecarga.TabIndex = 31;
            this.Grp_tela02_selecionarrecarga.TabStop = false;
            this.Grp_tela02_selecionarrecarga.Text = "Selecione o Valor da Recarga";
            // 
            // Btn_recarga200
            // 
            this.Btn_recarga200.BackColor = System.Drawing.Color.Transparent;
            this.Btn_recarga200.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_recarga200.Location = new System.Drawing.Point(572, 155);
            this.Btn_recarga200.Name = "Btn_recarga200";
            this.Btn_recarga200.Size = new System.Drawing.Size(146, 113);
            this.Btn_recarga200.TabIndex = 30;
            this.Btn_recarga200.UseVisualStyleBackColor = false;
            this.Btn_recarga200.Click += new System.EventHandler(this.Btn_recarga200_Click);
            // 
            // Btn_recarga100
            // 
            this.Btn_recarga100.BackColor = System.Drawing.Color.Transparent;
            this.Btn_recarga100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_recarga100.Location = new System.Drawing.Point(387, 155);
            this.Btn_recarga100.Name = "Btn_recarga100";
            this.Btn_recarga100.Size = new System.Drawing.Size(146, 113);
            this.Btn_recarga100.TabIndex = 29;
            this.Btn_recarga100.UseVisualStyleBackColor = false;
            this.Btn_recarga100.Click += new System.EventHandler(this.Btn_recarga100_Click);
            // 
            // Btn_recarga40
            // 
            this.Btn_recarga40.BackColor = System.Drawing.Color.Transparent;
            this.Btn_recarga40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_recarga40.Location = new System.Drawing.Point(202, 155);
            this.Btn_recarga40.Name = "Btn_recarga40";
            this.Btn_recarga40.Size = new System.Drawing.Size(146, 113);
            this.Btn_recarga40.TabIndex = 28;
            this.Btn_recarga40.UseVisualStyleBackColor = false;
            this.Btn_recarga40.Click += new System.EventHandler(this.Btn_recarga40_Click);
            // 
            // Btn_recarga35
            // 
            this.Btn_recarga35.BackColor = System.Drawing.Color.Transparent;
            this.Btn_recarga35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_recarga35.Location = new System.Drawing.Point(17, 155);
            this.Btn_recarga35.Name = "Btn_recarga35";
            this.Btn_recarga35.Size = new System.Drawing.Size(146, 113);
            this.Btn_recarga35.TabIndex = 27;
            this.Btn_recarga35.UseVisualStyleBackColor = false;
            this.Btn_recarga35.Click += new System.EventHandler(this.Btn_recarga35_Click);
            // 
            // Btn_recarga30
            // 
            this.Btn_recarga30.BackColor = System.Drawing.Color.Transparent;
            this.Btn_recarga30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_recarga30.Location = new System.Drawing.Point(572, 36);
            this.Btn_recarga30.Name = "Btn_recarga30";
            this.Btn_recarga30.Size = new System.Drawing.Size(146, 113);
            this.Btn_recarga30.TabIndex = 26;
            this.Btn_recarga30.UseVisualStyleBackColor = false;
            this.Btn_recarga30.Click += new System.EventHandler(this.Btn_recarga30_Click);
            // 
            // Btn_recarga20
            // 
            this.Btn_recarga20.BackColor = System.Drawing.Color.Transparent;
            this.Btn_recarga20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_recarga20.Location = new System.Drawing.Point(387, 36);
            this.Btn_recarga20.Name = "Btn_recarga20";
            this.Btn_recarga20.Size = new System.Drawing.Size(146, 113);
            this.Btn_recarga20.TabIndex = 25;
            this.Btn_recarga20.UseVisualStyleBackColor = false;
            this.Btn_recarga20.Click += new System.EventHandler(this.Btn_recarga20_Click);
            // 
            // Btn_recarga15
            // 
            this.Btn_recarga15.BackColor = System.Drawing.Color.Transparent;
            this.Btn_recarga15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_recarga15.Location = new System.Drawing.Point(202, 36);
            this.Btn_recarga15.Name = "Btn_recarga15";
            this.Btn_recarga15.Size = new System.Drawing.Size(146, 113);
            this.Btn_recarga15.TabIndex = 24;
            this.Btn_recarga15.UseVisualStyleBackColor = false;
            this.Btn_recarga15.Click += new System.EventHandler(this.Btn_recarga15_Click);
            // 
            // Btn_recarga12
            // 
            this.Btn_recarga12.BackColor = System.Drawing.Color.Transparent;
            this.Btn_recarga12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_recarga12.Location = new System.Drawing.Point(17, 36);
            this.Btn_recarga12.Name = "Btn_recarga12";
            this.Btn_recarga12.Size = new System.Drawing.Size(146, 113);
            this.Btn_recarga12.TabIndex = 15;
            this.Btn_recarga12.UseVisualStyleBackColor = false;
            this.Btn_recarga12.Click += new System.EventHandler(this.Btn_recarga01_Click);
            // 
            // Btn_conf_tema02
            // 
            this.Btn_conf_tema02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_conf_tema02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_conf_tema02.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_conf_tema02.Location = new System.Drawing.Point(860, 226);
            this.Btn_conf_tema02.Name = "Btn_conf_tema02";
            this.Btn_conf_tema02.Size = new System.Drawing.Size(170, 47);
            this.Btn_conf_tema02.TabIndex = 32;
            this.Btn_conf_tema02.Text = "Confirmar";
            this.Btn_conf_tema02.UseVisualStyleBackColor = false;
            this.Btn_conf_tema02.Click += new System.EventHandler(this.Btn_conf_tema02_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjetoOperadoras.Properties.Resources.recargadecell;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 584);
            this.Controls.Add(this.Grp_tela02_geral);
            this.Name = "Frm_02";
            this.Text = "Form2";
            this.Grp_tela02_geral.ResumeLayout(false);
            this.Grp_tela02_geral.PerformLayout();
            this.Grp_tela02_operadoras.ResumeLayout(false);
            this.Grp_tela02_operadoras.PerformLayout();
            this.Grp_tela02_selecionarrecarga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
        private System.ComponentModel.BackgroundWorker backgroundWorker8;
        private System.ComponentModel.BackgroundWorker backgroundWorker9;
        private System.ComponentModel.BackgroundWorker backgroundWorker10;
        private System.ComponentModel.BackgroundWorker backgroundWorker11;
        public System.Windows.Forms.GroupBox Grp_tela02_geral;
        public System.Windows.Forms.MaskedTextBox Msk_cel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Txt_DDD;
        public System.Windows.Forms.Label Lbl_DDD;
        public System.Windows.Forms.Button Btn_recarga12;
        public System.Windows.Forms.RadioButton Btn_tela02_Oi;
        public System.Windows.Forms.RadioButton Btn_tela02_Tim;
        public System.Windows.Forms.RadioButton Btn_tela02_Vivo;
        public System.Windows.Forms.RadioButton Btn_tela02_Claro;
        public System.Windows.Forms.Label Lbl_nomedooperadortela02;
        public System.Windows.Forms.Label Lbl_sejabemvindo;
        public System.Windows.Forms.GroupBox Grp_tela02_operadoras;
        public System.Windows.Forms.Label Lbl_Operadoraselecionada;
        public System.Windows.Forms.Label Lbl_regiao;
        public System.Windows.Forms.TextBox Txt_operadoraselecionada;
        public System.Windows.Forms.TextBox Txt_regiaoselecionada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Grp_tela02_selecionarrecarga;
        public System.Windows.Forms.Button Btn_recarga200;
        public System.Windows.Forms.Button Btn_recarga100;
        public System.Windows.Forms.Button Btn_recarga40;
        public System.Windows.Forms.Button Btn_recarga35;
        public System.Windows.Forms.Button Btn_recarga30;
        public System.Windows.Forms.Button Btn_recarga20;
        public System.Windows.Forms.Button Btn_recarga15;
        private System.Windows.Forms.Button Btn_conf_tema02;
    }
}