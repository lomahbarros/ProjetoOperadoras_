using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOperadoras
{
    public partial class Frm_01 : Form
    {
        public Frm_01()
        {
            InitializeComponent();
        }

        string regiao_selecionada, nome_operador_var; // Declarando uma variavel para receber a região selecionada

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.tema01;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_regiao_selecionada_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void Cmb_regiao_selecionada_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_regiao_selecionada.Text = Cmb_regiao_selecionada.Text;
            //if (Cmb_regiao_selecionada.Text == "Norte")
            //{
            //    Btn_Acre.Visible = true;
            //    Btn_Amapa.Visible = true;
            //    Btn_Amazonas.Visible = true;
            //    Btn_Para.Visible = true;
            //    Btn_Rondonia.Visible = true;
            //    Btn_Roraima.Visible = true;
            //    Btn_Tocantins.Visible = true;
            //    Grp_Escolha_Estado.Enabled = true;
            //    Pic_Bandeiras.Enabled = true;
            //}
            //else if (Cmb_regiao_selecionada.Text == "Nordeste")
            //{
            //    Btn_Alagoas.Visible = true;
            //    Btn_Bahia.Visible = true;
            //    Btn_Ceara.Visible = true;
            //    Btn_Maranhao.Visible = true;
            //    Btn_Paraiba.Visible = true;
            //    Btn_Pernambuco.Visible = true;
            //    Btn_Piaui.Visible = true;
            //    Btn_RioGrandeNorte.Visible = true;
            //    Btn_Sergipe.Visible = true;
            //    Grp_Escolha_Estado.Enabled = true;
            //    Pic_Bandeiras.Enabled = true;
            //}
            if (Cmb_regiao_selecionada.Text == "Sudeste")
            {
                Btn_EspiritoSanto.Visible = true;
                Btn_MinasGerais.Visible = true;
                Btn_RioJaneiro.Visible = true;
                Btn_SaoPaulo.Visible = true;
                Grp_Escolha_Estado.Enabled = true;
                Pic_Bandeiras.Enabled = true;
            }
            else
            {
                // Se o usuário selecionar qualquer outra região (ex: Sul ou Centro-Oeste)
                MessageBox.Show("As outras regiões estão em implantação!",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void radioButton1_CheckedChanged_3(object sender, EventArgs e)
        {

        }

        private void Btn_Tocantins_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_EspiritoSanto_CheckedChanged(object sender, EventArgs e)
        {
            


            Pic_Bandeiras.Image = Properties.Resources.es;
            Txt_Estado.Text = Btn_EspiritoSanto.Text;
            regiao_selecionada = Btn_EspiritoSanto.Text; // A variável criada recebe a informação do texto 
           

            if (Btn_EspiritoSanto.Checked == true)
            {
                MessageBox.Show(regiao_selecionada, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Pic_Bandeiras_Click(object sender, EventArgs e)
        {

        }

        private void Btn_MinasGerais_CheckedChanged(object sender, EventArgs e)
        {
                     


            Pic_Bandeiras.Image = Properties.Resources.mg;
            Txt_Estado.Text = Btn_MinasGerais.Text;
            regiao_selecionada = Btn_MinasGerais.Text; // A variável criada recebe a informação do texto
            

            if (Btn_MinasGerais.Checked == true)
            {
                MessageBox.Show(regiao_selecionada, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Estado_Click(object sender, EventArgs e)
        {

        }

        private void Btn_RioJaneiro_CheckedChanged(object sender, EventArgs e)
        {         


            Pic_Bandeiras.Image = Properties.Resources.rj;
           Txt_Estado.Text = Btn_RioJaneiro.Text;
            regiao_selecionada = Btn_RioJaneiro.Text;
            

            if (Btn_RioJaneiro.Checked == true)
            {
                MessageBox.Show(regiao_selecionada, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_SaoPaulo_CheckedChanged(object sender, EventArgs e)
        {
            

            Pic_Bandeiras.Image = Properties.Resources.sp;
            Txt_Estado.Text = Btn_SaoPaulo.Text;
            regiao_selecionada = Btn_SaoPaulo.Text;

            if (Btn_SaoPaulo.Checked == true)
            {
                MessageBox.Show(regiao_selecionada, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Txt_Estado_TextChanged(object sender, EventArgs e)
        { if (Txt_Estado.Text == "São Paulo")
                Txt_DDD.Text = "11";
            else if (Txt_Estado.Text == "Rio de Janeiro")
                Txt_DDD.Text = "21";
            else if (Txt_Estado.Text == "Minas Gerais")
                Txt_DDD.Text = "31";
            else if (Txt_Estado.Text == "Espírito Santo")
                Txt_DDD.Text = "27";
            else
            {
                Txt_DDD.Text = "";

            }
        }

        private void Txt_DDD_TextChanged(object sender, EventArgs e)
        {

        }

        bool camposValidos = true;
        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_nomeoperador.Text))
            {
                Txt_nomeoperador.BackColor = Color.LightCoral;
                camposValidos = false;
            }
            else
            {
                Txt_nomeoperador.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(Cmb_regiao_selecionada.Text))
            {
                Cmb_regiao_selecionada.BackColor = Color.LightCoral;
                camposValidos = false;
            }
            else
            {
                Cmb_regiao_selecionada.BackColor = Color.White;
            }

            if (Btn_EspiritoSanto.Checked || Btn_MinasGerais.Checked
                || Btn_RioJaneiro.Checked || Btn_SaoPaulo.Checked)
            {
                if (camposValidos)
                {
                    Frm_02 Chametela02 = new Frm_02();
                    Chametela02.Show();
                    Hide();
                    Chametela02.BackgroundImage = Properties.Resources.Fundo_transp;
                    Chametela02.BackgroundImageLayout = ImageLayout.Stretch;
                    Chametela02.Lbl_nomedooperadortela02.Text = Txt_nomeoperador.Text;
                    Chametela02.Txt_regiaoselecionada.Text = Txt_regiao_selecionada.Text;
                    Chametela02.Txt_DDD.Text = Txt_DDD.Text;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos destacados antes de continuar!");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma região!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            

        private void Txt_nomeoperador_TextChanged(object sender, EventArgs e)
        {
            Txt_nomeoperador.Text = Txt_nomeoperador.Text.TrimStart(); // Retirar os espaços iniciais a esquerda
            nome_operador_var = Txt_nomeoperador.Text; // envio do texto do nome do perador para a variável
            Lbl_caracters.Text = (Txt_nomeoperador.MaxLength - Txt_nomeoperador.TextLength).ToString() + " Caracters restante"; // contar a caracters máximo, menos o tamanho do nome, e converter para srt e formatar a saida da frase

            if (Txt_nomeoperador.TextLength >= 2) //21-	Bloquear para quando digitar o nome o botão vai aparecer, a condição é digitar pelo menos 2 letras 
            {
                Btn_Confirmar.Visible = true;

            }
            else
            {
                Btn_Confirmar.Visible = false;
            }
        }

        private void Txt_nomeoperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar)) // Condição para verificar se digitou somente letras,espaços && as teclas de controle 
            {
                e.Handled = true; // verificando se o texto guardado em e.KeyChar é letra

                MessageBox.Show("Digite somente letras!","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Error); // Configuração da caixa de erro
            }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do aplicativo de recarga de celular?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes) // usando o if com mensagem
            {
                Application.Exit();
            }
            else
            {
             Txt_nomeoperador.Focus(); // chama o cursos para a caixa de texto    
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

