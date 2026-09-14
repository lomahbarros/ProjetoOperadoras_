using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (Cmb_regiao_selecionada.Text == "Norte")
            {
                Btn_Acre.Visible = true;
                Btn_Amapa.Visible = true;
                Btn_Amazonas.Visible = true;
                Btn_Para.Visible = true;
                Btn_Rondonia.Visible = true;
                Btn_Roraima.Visible = true;
                Btn_Tocantins.Visible = true;
                Grp_Escolha_Estado.Enabled = true;
                Pic_Bandeiras.Enabled = true;
            }
            else if (Cmb_regiao_selecionada.Text == "Nordeste")
            {
                Btn_Alagoas.Visible = true;
                Btn_Bahia.Visible = true;
                Btn_Ceara.Visible = true;
                Btn_Maranhao.Visible = true;
                Btn_Paraiba.Visible = true;
                Btn_Pernambuco.Visible = true;
                Btn_Piaui.Visible = true;
                Btn_RioGrandeNorte.Visible = true;
                Btn_Sergipe.Visible = true;
                Grp_Escolha_Estado.Enabled = true;
                Pic_Bandeiras.Enabled = true;
            }
            else if (Cmb_regiao_selecionada.Text == "Sudeste")
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



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Bandeiras.Image = Properties.Resources.ap;
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
            Pic_Bandeiras.Image = Properties.Resources.mg;        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Estado_Click(object sender, EventArgs e)
        {

        }

        private void Btn_RioJaneiro_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Bandeiras.Image = Properties.Resources.rj;
        }

        private void Btn_SaoPaulo_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Bandeiras.Image = Properties.Resources.sp;
        }

        private void Btn_Acre_CheckedChanged(object sender, EventArgs e)
        {
            Pic_Bandeiras.Image = Properties.Resources.ac;
        }
    }
}
