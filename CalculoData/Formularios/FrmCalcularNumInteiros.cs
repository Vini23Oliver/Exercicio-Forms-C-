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
    public partial class FrmCalcularNumInteiros : Form
    {
        public FrmCalcularNumInteiros()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Criar um programa para calcular números inteiros utilizando a fórmula D = (R + S) / 2, onde R = (a + b) ^ 2 e S = (b + c) ^ 2; 
            int a, b, c;

            a = Convert.ToInt32(this.txtValor1.Text);
            b = Convert.ToInt32(this.txtValor2.Text);
            c = Convert.ToInt32(this.txtValor3.Text);

            int R = (a + b) * (a + b);
            int S = (b + c) * (b + c);

            int D = (R + S) / 2;

            this.lblResposta.Text = Convert.ToString(D);
        }


        // Criando conexão de telas
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

        // Criando conexão de ferramentas
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

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Dispose(); //Dispose() destrói o formulário, tira da memória ram.
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
