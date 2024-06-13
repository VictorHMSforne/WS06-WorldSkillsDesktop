using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class FrmPrincipal : Form
    {

        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Por favor preencha os campos!", "Campo Vazio");
                return;
            }
            Pesquisa pesquisa = new Pesquisa();
            int soma = tcbResp1.Value + tcbResp2.Value + tcbResp3.Value;
            double resultado = (((Convert.ToDouble(soma) / 3) - 1) / 9) * 100;
            pesquisa.Inserir(txtNome.Text, tcbResp1.Value, tcbResp2.Value, tcbResp3.Value,resultado.ToString("F"));
            //lblResult.Text = resultado.ToString("F");
            //lblPorcentagem.Visible = true;
            FrmResult result = new FrmResult();
            result.Show();


        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblResp1.Text = Convert.ToString(tcbResp1.Value);
            lblResp2.Text = Convert.ToString(tcbResp2.Value);
            lblResp3.Text = Convert.ToString(tcbResp3.Value);

        }

        private void tcbResp1_ValueChanged(object sender, EventArgs e)
        {
            lblResp1.Text = Convert.ToString(tcbResp1.Value);
        }

        private void tcbResp2_ValueChanged(object sender, EventArgs e)
        {
            lblResp2.Text = Convert.ToString(tcbResp2.Value);
        }

        private void tcbResp3_ValueChanged(object sender, EventArgs e)
        {
            lblResp3.Text = Convert.ToString(tcbResp3.Value);
        }
    }
}
