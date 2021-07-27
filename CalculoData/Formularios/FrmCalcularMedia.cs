using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoData.Formularios
{
    public partial class FrmCalcularMedia : Form
    {
        public FrmCalcularMedia()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtPeso1.Clear();
            txtPeso2.Clear();
            txtPeso3.Clear();
            lblResultado.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            double mp;

            double N1 = Convert.ToDouble(this.txtNota1.Text);
            double N2 = Convert.ToDouble(this.txtNota2.Text);
            double N3 = Convert.ToDouble(this.txtNota3.Text);

            double P1 = Convert.ToDouble(this.txtPeso1.Text);
            double P2 = Convert.ToDouble(this.txtPeso2.Text);
            double P3 = Convert.ToDouble(this.txtPeso3.Text);

            mp = ((N1 * P1) + (N2 * P2) + (N3 * P3)) / (P1 + P2 + P3);

            lblResultado.Text = $"{nome}, sua nota é {mp}";


        }

        // Conexão de telas
        private void calcularDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmCalcularData data = new FrmCalcularData();
            data.ShowDialog();
        }

        private void calcularMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmCalcularMedia media = new FrmCalcularMedia();
            media.ShowDialog();
        }

        private void calcularNumerosInteirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmCalcularNumInteiros inteiros = new FrmCalcularNumInteiros();
            inteiros.ShowDialog();
        }

        private void calculoPorSegundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmCalculoPorSegundos segundos = new FrmCalculoPorSegundos();
            segundos.ShowDialog();
        }

        //conexão das ferramentas
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process meuProcesso = System.Diagnostics.Process.Start("calc.exe");
            meuProcesso.WaitForExit();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process meuProcesso = System.Diagnostics.Process.Start("mspaint.exe");
            meuProcesso.WaitForExit();
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process meuProcesso = System.Diagnostics.Process.Start("notepad.exe");
            meuProcesso.WaitForExit();
        }

        private void opçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Dispose(); //Dispose() destrói o formulário, tira da memória ram.
            }
        }
    }
}
