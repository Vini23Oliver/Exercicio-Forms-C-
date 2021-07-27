using CalculoData.Formularios;
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

namespace CalculoData
{
    public partial class FrmCalculoPorSegundos : Form
    {
        public FrmCalculoPorSegundos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tempo;
            int resultado,resto,h,m,s;
            string opcao;

            tempo = Convert.ToInt32(txtSegundos.Text);
            opcao = this.cboxConverterPara.Text;

            switch (opcao)
            {
                case "Segundos":
                    string resposta = $"O tempo de evento é: {this.txtSegundos.Text} seg";
                    this.lblResposta.Text = resposta;
                    break;

                case "Minutos":
                    resultado = tempo / 60;
                    string resposta2 = $"O tempo de evento é {resultado} min";
                    this.lblResposta.Text = resposta2;
                    break;

                case "Horas":
                    resultado = (tempo / 60) / 60;
                    string resposta3 = $"O tempo de evento é {resultado} Horas";
                    this.lblResposta.Text = resposta3;
                    break;

                case "Horas/Min/Seg":
                    h = tempo / 3600;
                    resto = tempo % 3600;
                    m = resto / 60;
                    s = resto % 60;
                    this.lblResposta.Text = $"O tempo é de {h}:{m}:{s}";
                    break;                    

                default:
                    MessageBox.Show("Ocorreu um erro, tente novamente!");
                    break;                    
            }
        }

        // criando conexão de telas
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

        // criando conexão para ferramentas
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
    }
}
