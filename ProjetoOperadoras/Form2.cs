using ProjetoOperadoras;
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
    public partial class Frm_02 : Form
    {
        // Campo da classe para guardar o botão escolhido
        private Button botaoSelecionado;

        private void CopiarPropriedades(Button origem, Button destino)
        {
            destino.Text = origem.Text;
            destino.BackgroundImage = origem.BackgroundImage;
            destino.BackgroundImageLayout = origem.BackgroundImageLayout;
            destino.ForeColor = origem.ForeColor;
            destino.Font = origem.Font;
            destino.Size = origem.Size;
        }


        public Frm_02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_tela02_Claro_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.claro;
            BackgroundImageLayout = ImageLayout.Stretch;

            Btn_recarga12.BackgroundImage = Properties.Resources._12_claro;
            Btn_recarga12.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga15.BackgroundImage = Properties.Resources._15_claro;
            Btn_recarga15.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga20.BackgroundImage = Properties.Resources._20_claro;
            Btn_recarga20.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga30.BackgroundImage = Properties.Resources._30_claro;
            Btn_recarga30.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga35.BackgroundImage = Properties.Resources._35_claro;
            Btn_recarga35.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga40.BackgroundImage = Properties.Resources._40_claro;
            Btn_recarga40.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga100.BackgroundImage = Properties.Resources._100_claro;
            Btn_recarga100.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga200.BackgroundImage = Properties.Resources._200_claro;
            Btn_recarga200.BackgroundImageLayout = ImageLayout.Stretch;

            Txt_operadoraselecionada.Text = Btn_tela02_Claro.Text;
        }

        private void Btn_tela02_Vivo_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.vivo;
            BackgroundImageLayout = ImageLayout.Stretch;

            Btn_recarga12.BackgroundImage = Properties.Resources._12_vivo;
            Btn_recarga12.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga15.BackgroundImage = Properties.Resources._15_vivo;
            Btn_recarga15.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga20.BackgroundImage = Properties.Resources._20_vivo;
            Btn_recarga20.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga30.BackgroundImage = Properties.Resources._30_vivo;
            Btn_recarga30.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga35.BackgroundImage = Properties.Resources._35_vivo;
            Btn_recarga35.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga40.BackgroundImage = Properties.Resources._40_vivo;
            Btn_recarga40.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga100.BackgroundImage = Properties.Resources._100_vivo;
            Btn_recarga100.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga200.BackgroundImage = Properties.Resources._200_vivo;
            Btn_recarga200.BackgroundImageLayout = ImageLayout.Stretch;

            Txt_operadoraselecionada.Text = Btn_tela02_Vivo.Text;
        }

        private void Btn_tela02_Tim_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.tim;
            BackgroundImageLayout = ImageLayout.Stretch;

            Btn_recarga12.BackgroundImage = Properties.Resources._12_tim;
            Btn_recarga12.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga15.BackgroundImage = Properties.Resources._15_tim;
            Btn_recarga15.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga20.BackgroundImage = Properties.Resources._20_tim;
            Btn_recarga20.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga30.BackgroundImage = Properties.Resources._30_tim;
            Btn_recarga30.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga35.BackgroundImage = Properties.Resources._35_tim;
            Btn_recarga35.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga40.BackgroundImage = Properties.Resources._40_tim;
            Btn_recarga40.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga100.BackgroundImage = Properties.Resources._100_tim;
            Btn_recarga100.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga200.BackgroundImage = Properties.Resources._200_tim;
            Btn_recarga200.BackgroundImageLayout = ImageLayout.Stretch;

            Txt_operadoraselecionada.Text = Btn_tela02_Tim.Text;
        }

        private void Btn_tela02_Oi_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.oi;
            BackgroundImageLayout = ImageLayout.Stretch;

            Btn_recarga12.BackgroundImage = Properties.Resources._12_oi;
            Btn_recarga12.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga15.BackgroundImage = Properties.Resources._15_oi;
            Btn_recarga15.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga20.BackgroundImage = Properties.Resources._20_oi;
            Btn_recarga20.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga30.BackgroundImage = Properties.Resources._30_oi;
            Btn_recarga30.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga35.BackgroundImage = Properties.Resources._35_oi;
            Btn_recarga35.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga40.BackgroundImage = Properties.Resources._40_oi;
            Btn_recarga40.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga100.BackgroundImage = Properties.Resources._100_oi;
            Btn_recarga100.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_recarga200.BackgroundImage = Properties.Resources._200_oi;
            Btn_recarga200.BackgroundImageLayout = ImageLayout.Stretch;

            Txt_operadoraselecionada.Text = Btn_tela02_Oi.Text;
        }

        private void Btn_recarga01_Click(object sender, EventArgs e)
        {
            botaoSelecionado = (Button)sender; // guarda o botão clicado
        }

        private void Lbl_nomedooperadortela02_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_conf_tema02_Click(object sender, EventArgs e)
        {
            if (botaoSelecionado != null)
            {
             Frm_03 Chametela03 = new Frm_03(); // Instancia
             Chametela03.Show();
            

             //Copia a imagem do botão selecionado para o botão da tela 03
             Chametela03.Btn_ima_tema03.BackgroundImage = botaoSelecionado.BackgroundImage;
             Chametela03.Btn_ima_tema03.BackgroundImageLayout = ImageLayout.Stretch;
                Chametela03.Lbl_linhatxt.Text = Txt_DDD.Text + " - " + Msk_cel.Text;
             Hide();
            }
            else
            {
                MessageBox.Show("Selecione um botão antes de confirmar!");
            }
        }

        
        private void Btn_recarga15_Click(object sender, EventArgs e)
        {
            botaoSelecionado = (Button)sender; // guarda o botão clicado
        }

        private void Btn_recarga20_Click(object sender, EventArgs e)
        {
            botaoSelecionado = (Button)sender; // guarda o botão clicado
        }

        private void Btn_recarga30_Click(object sender, EventArgs e)
        {
            botaoSelecionado = (Button)sender; // guarda o botão clicado
        }

        private void Btn_recarga35_Click(object sender, EventArgs e)
        {
            botaoSelecionado = (Button)sender; // guarda o botão clicado
        }

        private void Btn_recarga40_Click(object sender, EventArgs e)
        {
            botaoSelecionado = (Button)sender; // guarda o botão clicado
        }

        private void Btn_recarga100_Click(object sender, EventArgs e)
        {
            botaoSelecionado = (Button)sender; // guarda o botão clicado
        }

        private void Btn_recarga200_Click(object sender, EventArgs e)
        {
            botaoSelecionado = (Button)sender; // guarda o botão clicado
        }

        private void Lbl_Operadoraselecionada_Click(object sender, EventArgs e)
        {

        }
    }
}