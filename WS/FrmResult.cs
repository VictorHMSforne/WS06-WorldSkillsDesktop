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
    public partial class FrmResult : Form
    {
        
        public FrmResult()
        {
            InitializeComponent();
            
        }

        private void FrmResult_Load(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa();
            pesquisa.Exibir();
            lblNome.Text = pesquisa.Nome.ToString();
            lblResult.Text = pesquisa.Resposta.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
