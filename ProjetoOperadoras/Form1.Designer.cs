namespace ProjetoOperadoras
{
    partial class Frm_01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Grp_DadosSelecionados = new System.Windows.Forms.GroupBox();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Txt_DDD = new System.Windows.Forms.TextBox();
            this.Lbl_DDD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_regiao_selecionada = new System.Windows.Forms.TextBox();
            this.Grp_Escolha_Estado = new System.Windows.Forms.GroupBox();
            this.Btn_SaoPaulo = new System.Windows.Forms.RadioButton();
            this.Btn_RioJaneiro = new System.Windows.Forms.RadioButton();
            this.Btn_MinasGerais = new System.Windows.Forms.RadioButton();
            this.Btn_EspiritoSanto = new System.Windows.Forms.RadioButton();
            this.Btn_Sergipe = new System.Windows.Forms.RadioButton();
            this.Btn_RioGrandeNorte = new System.Windows.Forms.RadioButton();
            this.Btn_Piaui = new System.Windows.Forms.RadioButton();
            this.Btn_Pernambuco = new System.Windows.Forms.RadioButton();
            this.Btn_Paraiba = new System.Windows.Forms.RadioButton();
            this.Btn_Maranhao = new System.Windows.Forms.RadioButton();
            this.Btn_Ceara = new System.Windows.Forms.RadioButton();
            this.Btn_Bahia = new System.Windows.Forms.RadioButton();
            this.Btn_Alagoas = new System.Windows.Forms.RadioButton();
            this.Btn_Tocantins = new System.Windows.Forms.RadioButton();
            this.Btn_Roraima = new System.Windows.Forms.RadioButton();
            this.Btn_Amazonas = new System.Windows.Forms.RadioButton();
            this.Btn_Para = new System.Windows.Forms.RadioButton();
            this.Btn_Rondonia = new System.Windows.Forms.RadioButton();
            this.Btn_Amapa = new System.Windows.Forms.RadioButton();
            this.Btn_Acre = new System.Windows.Forms.RadioButton();
            this.Pic_Bandeiras = new System.Windows.Forms.PictureBox();
            this.Cmb_regiao_selecionada = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Grp_DadosSelecionados.SuspendLayout();
            this.Grp_Escolha_Estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Bandeiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(387, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 623);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Recarga";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Grp_DadosSelecionados);
            this.groupBox2.Controls.Add(this.Grp_Escolha_Estado);
            this.groupBox2.Controls.Add(this.Cmb_regiao_selecionada);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.Location = new System.Drawing.Point(220, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 509);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Região";
            // 
            // Grp_DadosSelecionados
            // 
            this.Grp_DadosSelecionados.Controls.Add(this.Txt_Estado);
            this.Grp_DadosSelecionados.Controls.Add(this.Lbl_Estado);
            this.Grp_DadosSelecionados.Controls.Add(this.Txt_DDD);
            this.Grp_DadosSelecionados.Controls.Add(this.Lbl_DDD);
            this.Grp_DadosSelecionados.Controls.Add(this.label2);
            this.Grp_DadosSelecionados.Controls.Add(this.Txt_regiao_selecionada);
            this.Grp_DadosSelecionados.Location = new System.Drawing.Point(6, 415);
            this.Grp_DadosSelecionados.Name = "Grp_DadosSelecionados";
            this.Grp_DadosSelecionados.Size = new System.Drawing.Size(853, 77);
            this.Grp_DadosSelecionados.TabIndex = 5;
            this.Grp_DadosSelecionados.TabStop = false;
            this.Grp_DadosSelecionados.Text = "Dados Selecionados";
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Enabled = false;
            this.Txt_Estado.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Txt_Estado.Location = new System.Drawing.Point(304, 43);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(200, 32);
            this.Txt_Estado.TabIndex = 8;
            this.Txt_Estado.TextChanged += new System.EventHandler(this.Txt_Estado_TextChanged);
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Enabled = false;
            this.Lbl_Estado.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_Estado.Location = new System.Drawing.Point(371, 14);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(76, 26);
            this.Lbl_Estado.TabIndex = 7;
            this.Lbl_Estado.Text = "Estado";
            this.Lbl_Estado.Click += new System.EventHandler(this.Lbl_Estado_Click);
            // 
            // Txt_DDD
            // 
            this.Txt_DDD.Enabled = false;
            this.Txt_DDD.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Txt_DDD.Location = new System.Drawing.Point(629, 43);
            this.Txt_DDD.Name = "Txt_DDD";
            this.Txt_DDD.Size = new System.Drawing.Size(131, 32);
            this.Txt_DDD.TabIndex = 6;
            this.Txt_DDD.TextChanged += new System.EventHandler(this.Txt_DDD_TextChanged);
            // 
            // Lbl_DDD
            // 
            this.Lbl_DDD.AutoSize = true;
            this.Lbl_DDD.Enabled = false;
            this.Lbl_DDD.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl_DDD.Location = new System.Drawing.Point(659, 16);
            this.Lbl_DDD.Name = "Lbl_DDD";
            this.Lbl_DDD.Size = new System.Drawing.Size(57, 26);
            this.Lbl_DDD.TabIndex = 5;
            this.Lbl_DDD.Text = "DDD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Região selecionada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_regiao_selecionada
            // 
            this.Txt_regiao_selecionada.Enabled = false;
            this.Txt_regiao_selecionada.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_regiao_selecionada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Txt_regiao_selecionada.Location = new System.Drawing.Point(11, 43);
            this.Txt_regiao_selecionada.Name = "Txt_regiao_selecionada";
            this.Txt_regiao_selecionada.Size = new System.Drawing.Size(172, 32);
            this.Txt_regiao_selecionada.TabIndex = 4;
            this.Txt_regiao_selecionada.TextChanged += new System.EventHandler(this.Txt_regiao_selecionada_TextChanged);
            // 
            // Grp_Escolha_Estado
            // 
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_SaoPaulo);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_RioJaneiro);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_MinasGerais);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_EspiritoSanto);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Sergipe);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_RioGrandeNorte);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Piaui);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Pernambuco);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Paraiba);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Maranhao);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Ceara);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Bahia);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Alagoas);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Tocantins);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Roraima);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Amazonas);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Para);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Rondonia);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Amapa);
            this.Grp_Escolha_Estado.Controls.Add(this.Btn_Acre);
            this.Grp_Escolha_Estado.Controls.Add(this.Pic_Bandeiras);
            this.Grp_Escolha_Estado.Enabled = false;
            this.Grp_Escolha_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Grp_Escolha_Estado.Location = new System.Drawing.Point(193, 19);
            this.Grp_Escolha_Estado.Name = "Grp_Escolha_Estado";
            this.Grp_Escolha_Estado.Size = new System.Drawing.Size(666, 390);
            this.Grp_Escolha_Estado.TabIndex = 4;
            this.Grp_Escolha_Estado.TabStop = false;
            this.Grp_Escolha_Estado.Text = "Escolha o Estado";
            this.Grp_Escolha_Estado.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Btn_SaoPaulo
            // 
            this.Btn_SaoPaulo.AutoSize = true;
            this.Btn_SaoPaulo.ForeColor = System.Drawing.Color.Navy;
            this.Btn_SaoPaulo.Location = new System.Drawing.Point(389, 325);
            this.Btn_SaoPaulo.Name = "Btn_SaoPaulo";
            this.Btn_SaoPaulo.Size = new System.Drawing.Size(83, 17);
            this.Btn_SaoPaulo.TabIndex = 26;
            this.Btn_SaoPaulo.TabStop = true;
            this.Btn_SaoPaulo.Text = "São Paulo";
            this.Btn_SaoPaulo.UseVisualStyleBackColor = true;
            this.Btn_SaoPaulo.Visible = false;
            this.Btn_SaoPaulo.CheckedChanged += new System.EventHandler(this.Btn_SaoPaulo_CheckedChanged);
            // 
            // Btn_RioJaneiro
            // 
            this.Btn_RioJaneiro.AutoSize = true;
            this.Btn_RioJaneiro.ForeColor = System.Drawing.Color.Navy;
            this.Btn_RioJaneiro.Location = new System.Drawing.Point(258, 325);
            this.Btn_RioJaneiro.Name = "Btn_RioJaneiro";
            this.Btn_RioJaneiro.Size = new System.Drawing.Size(107, 17);
            this.Btn_RioJaneiro.TabIndex = 25;
            this.Btn_RioJaneiro.TabStop = true;
            this.Btn_RioJaneiro.Text = "Rio de Janeiro";
            this.Btn_RioJaneiro.UseVisualStyleBackColor = true;
            this.Btn_RioJaneiro.Visible = false;
            this.Btn_RioJaneiro.CheckedChanged += new System.EventHandler(this.Btn_RioJaneiro_CheckedChanged);
            // 
            // Btn_MinasGerais
            // 
            this.Btn_MinasGerais.AutoSize = true;
            this.Btn_MinasGerais.ForeColor = System.Drawing.Color.Navy;
            this.Btn_MinasGerais.Location = new System.Drawing.Point(136, 325);
            this.Btn_MinasGerais.Name = "Btn_MinasGerais";
            this.Btn_MinasGerais.Size = new System.Drawing.Size(98, 17);
            this.Btn_MinasGerais.TabIndex = 24;
            this.Btn_MinasGerais.TabStop = true;
            this.Btn_MinasGerais.Text = "Minas Gerais";
            this.Btn_MinasGerais.UseVisualStyleBackColor = true;
            this.Btn_MinasGerais.Visible = false;
            this.Btn_MinasGerais.CheckedChanged += new System.EventHandler(this.Btn_MinasGerais_CheckedChanged);
            // 
            // Btn_EspiritoSanto
            // 
            this.Btn_EspiritoSanto.AutoSize = true;
            this.Btn_EspiritoSanto.ForeColor = System.Drawing.Color.Navy;
            this.Btn_EspiritoSanto.Location = new System.Drawing.Point(6, 325);
            this.Btn_EspiritoSanto.Name = "Btn_EspiritoSanto";
            this.Btn_EspiritoSanto.Size = new System.Drawing.Size(106, 17);
            this.Btn_EspiritoSanto.TabIndex = 23;
            this.Btn_EspiritoSanto.TabStop = true;
            this.Btn_EspiritoSanto.Text = "Espírito Santo";
            this.Btn_EspiritoSanto.UseVisualStyleBackColor = true;
            this.Btn_EspiritoSanto.Visible = false;
            this.Btn_EspiritoSanto.CheckedChanged += new System.EventHandler(this.Btn_EspiritoSanto_CheckedChanged);
            // 
            // Btn_Sergipe
            // 
            this.Btn_Sergipe.AutoSize = true;
            this.Btn_Sergipe.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_Sergipe.Location = new System.Drawing.Point(173, 293);
            this.Btn_Sergipe.Name = "Btn_Sergipe";
            this.Btn_Sergipe.Size = new System.Drawing.Size(68, 17);
            this.Btn_Sergipe.TabIndex = 22;
            this.Btn_Sergipe.TabStop = true;
            this.Btn_Sergipe.Text = "Sergipe";
            this.Btn_Sergipe.UseVisualStyleBackColor = true;
            this.Btn_Sergipe.Visible = false;
            // 
            // Btn_RioGrandeNorte
            // 
            this.Btn_RioGrandeNorte.AutoSize = true;
            this.Btn_RioGrandeNorte.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_RioGrandeNorte.Location = new System.Drawing.Point(11, 293);
            this.Btn_RioGrandeNorte.Name = "Btn_RioGrandeNorte";
            this.Btn_RioGrandeNorte.Size = new System.Drawing.Size(142, 17);
            this.Btn_RioGrandeNorte.TabIndex = 21;
            this.Btn_RioGrandeNorte.TabStop = true;
            this.Btn_RioGrandeNorte.Text = "Rio Grande do Norte";
            this.Btn_RioGrandeNorte.UseVisualStyleBackColor = true;
            this.Btn_RioGrandeNorte.Visible = false;
            // 
            // Btn_Piaui
            // 
            this.Btn_Piaui.AutoSize = true;
            this.Btn_Piaui.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_Piaui.Location = new System.Drawing.Point(557, 270);
            this.Btn_Piaui.Name = "Btn_Piaui";
            this.Btn_Piaui.Size = new System.Drawing.Size(55, 17);
            this.Btn_Piaui.TabIndex = 20;
            this.Btn_Piaui.TabStop = true;
            this.Btn_Piaui.Text = "Piauí";
            this.Btn_Piaui.UseVisualStyleBackColor = true;
            this.Btn_Piaui.Visible = false;
            // 
            // Btn_Pernambuco
            // 
            this.Btn_Pernambuco.AutoSize = true;
            this.Btn_Pernambuco.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_Pernambuco.Location = new System.Drawing.Point(442, 270);
            this.Btn_Pernambuco.Name = "Btn_Pernambuco";
            this.Btn_Pernambuco.Size = new System.Drawing.Size(95, 17);
            this.Btn_Pernambuco.TabIndex = 19;
            this.Btn_Pernambuco.TabStop = true;
            this.Btn_Pernambuco.Text = "Pernambuco";
            this.Btn_Pernambuco.UseVisualStyleBackColor = true;
            this.Btn_Pernambuco.Visible = false;
            // 
            // Btn_Paraiba
            // 
            this.Btn_Paraiba.AutoSize = true;
            this.Btn_Paraiba.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_Paraiba.Location = new System.Drawing.Point(352, 270);
            this.Btn_Paraiba.Name = "Btn_Paraiba";
            this.Btn_Paraiba.Size = new System.Drawing.Size(70, 17);
            this.Btn_Paraiba.TabIndex = 18;
            this.Btn_Paraiba.TabStop = true;
            this.Btn_Paraiba.Text = "Paraíba";
            this.Btn_Paraiba.UseVisualStyleBackColor = true;
            this.Btn_Paraiba.Visible = false;
            // 
            // Btn_Maranhao
            // 
            this.Btn_Maranhao.AutoSize = true;
            this.Btn_Maranhao.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_Maranhao.Location = new System.Drawing.Point(251, 270);
            this.Btn_Maranhao.Name = "Btn_Maranhao";
            this.Btn_Maranhao.Size = new System.Drawing.Size(81, 17);
            this.Btn_Maranhao.TabIndex = 17;
            this.Btn_Maranhao.TabStop = true;
            this.Btn_Maranhao.Text = "Maranhão";
            this.Btn_Maranhao.UseVisualStyleBackColor = true;
            this.Btn_Maranhao.Visible = false;
            // 
            // Btn_Ceara
            // 
            this.Btn_Ceara.AutoSize = true;
            this.Btn_Ceara.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_Ceara.Location = new System.Drawing.Point(173, 270);
            this.Btn_Ceara.Name = "Btn_Ceara";
            this.Btn_Ceara.Size = new System.Drawing.Size(58, 17);
            this.Btn_Ceara.TabIndex = 16;
            this.Btn_Ceara.TabStop = true;
            this.Btn_Ceara.Text = "Ceará";
            this.Btn_Ceara.UseVisualStyleBackColor = true;
            this.Btn_Ceara.Visible = false;
            // 
            // Btn_Bahia
            // 
            this.Btn_Bahia.AutoSize = true;
            this.Btn_Bahia.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_Bahia.Location = new System.Drawing.Point(96, 270);
            this.Btn_Bahia.Name = "Btn_Bahia";
            this.Btn_Bahia.Size = new System.Drawing.Size(57, 17);
            this.Btn_Bahia.TabIndex = 15;
            this.Btn_Bahia.TabStop = true;
            this.Btn_Bahia.Text = "Bahia";
            this.Btn_Bahia.UseVisualStyleBackColor = true;
            this.Btn_Bahia.Visible = false;
            // 
            // Btn_Alagoas
            // 
            this.Btn_Alagoas.AutoSize = true;
            this.Btn_Alagoas.ForeColor = System.Drawing.Color.Firebrick;
            this.Btn_Alagoas.Location = new System.Drawing.Point(6, 270);
            this.Btn_Alagoas.Name = "Btn_Alagoas";
            this.Btn_Alagoas.Size = new System.Drawing.Size(70, 17);
            this.Btn_Alagoas.TabIndex = 14;
            this.Btn_Alagoas.TabStop = true;
            this.Btn_Alagoas.Text = "Alagoas";
            this.Btn_Alagoas.UseVisualStyleBackColor = true;
            this.Btn_Alagoas.Visible = false;
            // 
            // Btn_Tocantins
            // 
            this.Btn_Tocantins.AutoSize = true;
            this.Btn_Tocantins.Location = new System.Drawing.Point(577, 247);
            this.Btn_Tocantins.Name = "Btn_Tocantins";
            this.Btn_Tocantins.Size = new System.Drawing.Size(81, 17);
            this.Btn_Tocantins.TabIndex = 13;
            this.Btn_Tocantins.TabStop = true;
            this.Btn_Tocantins.Text = "Tocantins";
            this.Btn_Tocantins.UseVisualStyleBackColor = true;
            this.Btn_Tocantins.Visible = false;
            this.Btn_Tocantins.CheckedChanged += new System.EventHandler(this.Btn_Tocantins_CheckedChanged);
            // 
            // Btn_Roraima
            // 
            this.Btn_Roraima.AutoSize = true;
            this.Btn_Roraima.Location = new System.Drawing.Point(477, 247);
            this.Btn_Roraima.Name = "Btn_Roraima";
            this.Btn_Roraima.Size = new System.Drawing.Size(71, 17);
            this.Btn_Roraima.TabIndex = 12;
            this.Btn_Roraima.TabStop = true;
            this.Btn_Roraima.Text = "Roraima";
            this.Btn_Roraima.UseVisualStyleBackColor = true;
            this.Btn_Roraima.Visible = false;
            this.Btn_Roraima.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // Btn_Amazonas
            // 
            this.Btn_Amazonas.AutoSize = true;
            this.Btn_Amazonas.Location = new System.Drawing.Point(178, 247);
            this.Btn_Amazonas.Name = "Btn_Amazonas";
            this.Btn_Amazonas.Size = new System.Drawing.Size(82, 17);
            this.Btn_Amazonas.TabIndex = 10;
            this.Btn_Amazonas.TabStop = true;
            this.Btn_Amazonas.Text = "Amazonas";
            this.Btn_Amazonas.UseVisualStyleBackColor = true;
            this.Btn_Amazonas.Visible = false;
            // 
            // Btn_Para
            // 
            this.Btn_Para.AutoSize = true;
            this.Btn_Para.Location = new System.Drawing.Point(289, 247);
            this.Btn_Para.Name = "Btn_Para";
            this.Btn_Para.Size = new System.Drawing.Size(51, 17);
            this.Btn_Para.TabIndex = 9;
            this.Btn_Para.TabStop = true;
            this.Btn_Para.Text = "Pará";
            this.Btn_Para.UseVisualStyleBackColor = true;
            this.Btn_Para.Visible = false;
            this.Btn_Para.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // Btn_Rondonia
            // 
            this.Btn_Rondonia.AutoSize = true;
            this.Btn_Rondonia.Location = new System.Drawing.Point(369, 247);
            this.Btn_Rondonia.Name = "Btn_Rondonia";
            this.Btn_Rondonia.Size = new System.Drawing.Size(79, 17);
            this.Btn_Rondonia.TabIndex = 8;
            this.Btn_Rondonia.TabStop = true;
            this.Btn_Rondonia.Text = "Rondônia";
            this.Btn_Rondonia.UseVisualStyleBackColor = true;
            this.Btn_Rondonia.Visible = false;
            this.Btn_Rondonia.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Btn_Amapa
            // 
            this.Btn_Amapa.AutoSize = true;
            this.Btn_Amapa.Location = new System.Drawing.Point(86, 247);
            this.Btn_Amapa.Name = "Btn_Amapa";
            this.Btn_Amapa.Size = new System.Drawing.Size(63, 17);
            this.Btn_Amapa.TabIndex = 6;
            this.Btn_Amapa.TabStop = true;
            this.Btn_Amapa.Text = "Amapá";
            this.Btn_Amapa.UseVisualStyleBackColor = true;
            this.Btn_Amapa.Visible = false;
            this.Btn_Amapa.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Btn_Acre
            // 
            this.Btn_Acre.AutoSize = true;
            this.Btn_Acre.Location = new System.Drawing.Point(6, 247);
            this.Btn_Acre.Name = "Btn_Acre";
            this.Btn_Acre.Size = new System.Drawing.Size(51, 17);
            this.Btn_Acre.TabIndex = 5;
            this.Btn_Acre.TabStop = true;
            this.Btn_Acre.Text = "Acre";
            this.Btn_Acre.UseVisualStyleBackColor = true;
            this.Btn_Acre.Visible = false;
            this.Btn_Acre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // Pic_Bandeiras
            // 
            this.Pic_Bandeiras.Location = new System.Drawing.Point(194, 19);
            this.Pic_Bandeiras.Name = "Pic_Bandeiras";
            this.Pic_Bandeiras.Size = new System.Drawing.Size(314, 204);
            this.Pic_Bandeiras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Bandeiras.TabIndex = 4;
            this.Pic_Bandeiras.TabStop = false;
            this.Pic_Bandeiras.Click += new System.EventHandler(this.Pic_Bandeiras_Click);
            // 
            // Cmb_regiao_selecionada
            // 
            this.Cmb_regiao_selecionada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_regiao_selecionada.FormattingEnabled = true;
            this.Cmb_regiao_selecionada.Items.AddRange(new object[] {
            "Norte",
            "Nordeste",
            "Centro-Oeste",
            "Sudeste",
            "Sul"});
            this.Cmb_regiao_selecionada.Location = new System.Drawing.Point(6, 29);
            this.Cmb_regiao_selecionada.Name = "Cmb_regiao_selecionada";
            this.Cmb_regiao_selecionada.Size = new System.Drawing.Size(121, 21);
            this.Cmb_regiao_selecionada.TabIndex = 0;
            this.Cmb_regiao_selecionada.SelectedIndexChanged += new System.EventHandler(this.Cmb_regiao_selecionada_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoOperadoras.Properties.Resources.aquitem;
            this.pictureBox1.Location = new System.Drawing.Point(6, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // Frm_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_01";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Grp_DadosSelecionados.ResumeLayout(false);
            this.Grp_DadosSelecionados.PerformLayout();
            this.Grp_Escolha_Estado.ResumeLayout(false);
            this.Grp_Escolha_Estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Bandeiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_regiao_selecionada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Grp_Escolha_Estado;
        private System.Windows.Forms.PictureBox Pic_Bandeiras;
        private System.Windows.Forms.ComboBox Cmb_regiao_selecionada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton Btn_Amazonas;
        private System.Windows.Forms.RadioButton Btn_Para;
        private System.Windows.Forms.RadioButton Btn_Rondonia;
        private System.Windows.Forms.RadioButton Btn_Amapa;
        private System.Windows.Forms.RadioButton Btn_Acre;
        private System.Windows.Forms.RadioButton Btn_Roraima;
        private System.Windows.Forms.RadioButton Btn_Tocantins;
        private System.Windows.Forms.RadioButton Btn_Maranhao;
        private System.Windows.Forms.RadioButton Btn_Ceara;
        private System.Windows.Forms.RadioButton Btn_Bahia;
        private System.Windows.Forms.RadioButton Btn_Alagoas;
        private System.Windows.Forms.RadioButton Btn_Sergipe;
        private System.Windows.Forms.RadioButton Btn_RioGrandeNorte;
        private System.Windows.Forms.RadioButton Btn_Piaui;
        private System.Windows.Forms.RadioButton Btn_Pernambuco;
        private System.Windows.Forms.RadioButton Btn_Paraiba;
        private System.Windows.Forms.RadioButton Btn_EspiritoSanto;
        private System.Windows.Forms.RadioButton Btn_SaoPaulo;
        private System.Windows.Forms.RadioButton Btn_RioJaneiro;
        private System.Windows.Forms.RadioButton Btn_MinasGerais;
        private System.Windows.Forms.GroupBox Grp_DadosSelecionados;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.TextBox Txt_DDD;
        private System.Windows.Forms.Label Lbl_DDD;
    }
}

