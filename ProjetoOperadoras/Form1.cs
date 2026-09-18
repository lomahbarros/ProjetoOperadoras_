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

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
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
            
        }

        private void Pic_Bandeiras_Click(object sender, EventArgs e)
        {

        }

        private void Btn_MinasGerais_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Bandeiras.Image = Properties.Resources.mg;
            Txt_Estado.Text = Btn_MinasGerais.Text;
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
        }

        private void Btn_SaoPaulo_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Bandeiras.Image = Properties.Resources.sp;
            Txt_Estado.Text = Btn_SaoPaulo.Text;
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

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            Frm_02 Chametela02 = new Frm_02(); // instanciar o objeto para chamar a tela02
            Chametela02.Show();
            Hide();
            Chametela02.BackgroundImage = Properties.Resources.Fundo_transp;
            Chametela02.BackgroundImageLayout = ImageLayout.Stretch;
            Chametela02.Lbl_nomedooperadortela02.Text = Txt_nomeoperador.Text;
            Chametela02.Txt_regiaoselecionada.Text = Txt_regiao_selecionada.Text;
            Chametela02.Txt_DDD.Text=Txt_DDD.Text;
                }
    }
}
