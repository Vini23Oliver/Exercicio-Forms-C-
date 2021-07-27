using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoData.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcularData_Click(object sender, EventArgs e)
        {
            FrmCalcularData data = new FrmCalcularData();
            data.ShowDialog();
        }

        private void btnCalcularNumeros_Click(object sender, EventArgs e)
        {
            FrmCalcularNumInteiros inteiros = new FrmCalcularNumInteiros();
            inteiros.ShowDialog();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            FrmCalcularMedia media = new FrmCalcularMedia();
            media.ShowDialog();
        }

        private void btnCalculoPorSegundo_Click(object sender, EventArgs e)
        {
            FrmCalculoPorSegundos segundos = new FrmCalculoPorSegundos();
            segundos.ShowDialog();
        }
    }
}
