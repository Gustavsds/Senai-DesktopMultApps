using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Client.Windows.Funcionalidades
{
    public partial class frmMatriculaAluno : Form
    {
        public frmMatriculaAluno()
        {
            InitializeComponent();
        }

        private void frmMatriculaAluno_Load(object sender, EventArgs e)
        {

        }
        private void txtAnoUltimoAniversario_Enter(object sender,EventArgs e)
        {
            if (txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ANO DE " +
                "NASCIMENTO com 4 digitos", "Atenção!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
        }
        private void btnIndentificarCategoria_Click(object sender, EventArgs e)
        {
        }
    }
}
