using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class ExcluirModalidade : Form
    {
        public ExcluirModalidade()
        {
            InitializeComponent();
        }

        private void btnExcluirMod_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cmbDescExcluiMod.Text);
            if (mod.consultarModalidade()) // resolver consultarModalidade
            {
                if (mod.excluirModalidade())
                {
                    MessageBox.Show("Modalidade excluída com sucesso!");
                }
            }
        }
    }
}
