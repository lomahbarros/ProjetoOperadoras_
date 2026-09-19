namespace ProjetoOperadoras
{
    partial class Frm_03
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ima_tema03 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_linhatxt = new System.Windows.Forms.Label();
            this.Btn_tela03_recebe = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Você escolheu a recarga";
            // 
            // Btn_ima_tema03
            // 
            this.Btn_ima_tema03.Location = new System.Drawing.Point(72, 124);
            this.Btn_ima_tema03.Name = "Btn_ima_tema03";
            this.Btn_ima_tema03.Size = new System.Drawing.Size(170, 113);
            this.Btn_ima_tema03.TabIndex = 1;
            this.Btn_ima_tema03.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(89, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Voltar.Location = new System.Drawing.Point(89, 399);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(170, 47);
            this.Btn_Voltar.TabIndex = 3;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para a linha";
            // 
            // Lbl_linhatxt
            // 
            this.Lbl_linhatxt.AutoSize = true;
            this.Lbl_linhatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_linhatxt.Location = new System.Drawing.Point(160, 240);
            this.Lbl_linhatxt.Name = "Lbl_linhatxt";
            this.Lbl_linhatxt.Size = new System.Drawing.Size(130, 29);
            this.Lbl_linhatxt.TabIndex = 5;
            this.Lbl_linhatxt.Text = "000000000";
            // 
            // Btn_tela03_recebe
            // 
            this.Btn_tela03_recebe.AutoSize = true;
            this.Btn_tela03_recebe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_tela03_recebe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_tela03_recebe.Location = new System.Drawing.Point(115, 28);
            this.Btn_tela03_recebe.Name = "Btn_tela03_recebe";
            this.Btn_tela03_recebe.Size = new System.Drawing.Size(99, 24);
            this.Btn_tela03_recebe.TabIndex = 24;
            this.Btn_tela03_recebe.Text = "recebetexto";
            this.Btn_tela03_recebe.UseVisualStyleBackColor = true;
            this.Btn_tela03_recebe.CheckedChanged += new System.EventHandler(this.Btn_tela03_recebe_CheckedChanged);
            // 
            // Frm_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 458);
            this.Controls.Add(this.Btn_tela03_recebe);
            this.Controls.Add(this.Lbl_linhatxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_ima_tema03);
            this.Controls.Add(this.label1);
            this.Name = "Frm_03";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button Btn_ima_tema03;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Lbl_linhatxt;
        public System.Windows.Forms.RadioButton Btn_tela03_recebe;
    }
}