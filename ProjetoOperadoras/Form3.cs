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
    public partial class Frm_03 : Form
    {
        public Frm_03()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_02 Chametela02 = new Frm_02();
            Chametela02.Show();
            this.Close();
        }

        private void Btn_tela03_recebe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_recebeoperadora_Click(object sender, EventArgs e)
        {

         
        }

        private void Lbl_txtdaoperadora_Click(object sender, EventArgs e)
        {

        }

        private void Btn_novocliente_Click(object sender, EventArgs e)
        {
            Frm_01 tela01 = new Frm_01(); // (Certifique-se de que o nome da classe da sua tela 1 é Frm_01)

            // 2. Mostra a Tela 01
            tela01.Show();

            // 3. Fecha ou esconde a Tela 03 atual
            this.Close(); // ou this.Hide(); se preferir apenas oculta
        }
    }
}
