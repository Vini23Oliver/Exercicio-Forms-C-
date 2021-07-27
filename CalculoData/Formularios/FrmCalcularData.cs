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
    public partial class FrmCalcularData : Form
    {
        public FrmCalcularData()
        {
            InitializeComponent();
        }        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /* Programando o botão Calcular para mostrar o resultado das datas em 
            dias, mes e anos.*/

            // criando variaveis  
            DateTime data1, data2;
            TimeSpan resultado;
            string opcao;

            // Converção de tipo text para DataTime e alocando nas variaveis descritas acima.
            data1 = DateTime.Parse(mtxtNascimento.Text);
            data2 = DateTime.Parse(mtxtAnoAtual.Text);

            opcao = cboxConverterPara.Text;

            // Teste de caso, utilizando switch..case.
            switch (opcao)
            {
                case "Dias":
                    resultado = data2 - data1;
                    string resposta = $"Você tem {resultado.Days} Dias";
                    lblResposta.Text = resposta;
                    break;

                case "Mes":
                    resultado = data2 - data1;
                    string resposta2 = $"Você tem {resultado.Days / 30} meses";
                    lblResposta.Text = resposta2;
                    break;

                case "Ano":
                    resultado = data2 - data1;
                    string resposta3 = $"Você tem {resultado.Days / 31 / 12} Anos";
                    lblResposta.Text = resposta3;
                    break;

                default:
                    MessageBox.Show("Ocorreu um erro, tente novamente!");
                    break;
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose(); //Dispose() destrói o formulário, tira da memória ram.
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process meuProcesso = System.Diagnostics.Process.Start("notepad.exe");
            meuProcesso.WaitForExit();
        }

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
    }
}
