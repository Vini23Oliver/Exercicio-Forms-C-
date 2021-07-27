
namespace CalculoData
{
    partial class FrmCalcularData
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtxtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mtxtAnoAtual = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxConverterPara = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularNumerosInteirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoPorSegundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtNascimento
            // 
            this.mtxtNascimento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNascimento.Location = new System.Drawing.Point(160, 22);
            this.mtxtNascimento.Mask = "00/00/0000";
            this.mtxtNascimento.Name = "mtxtNascimento";
            this.mtxtNascimento.Size = new System.Drawing.Size(101, 26);
            this.mtxtNascimento.TabIndex = 1;
            this.mtxtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtAnoAtual
            // 
            this.mtxtAnoAtual.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtAnoAtual.Location = new System.Drawing.Point(160, 58);
            this.mtxtAnoAtual.Mask = "00/00/0000";
            this.mtxtAnoAtual.Name = "mtxtAnoAtual";
            this.mtxtAnoAtual.Size = new System.Drawing.Size(101, 26);
            this.mtxtAnoAtual.TabIndex = 2;
            this.mtxtAnoAtual.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "Calcular Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data de nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data atual:";
            // 
            // cboxConverterPara
            // 
            this.cboxConverterPara.FormattingEnabled = true;
            this.cboxConverterPara.Items.AddRange(new object[] {
            "Dias",
            "Mes",
            "Ano"});
            this.cboxConverterPara.Location = new System.Drawing.Point(160, 100);
            this.cboxConverterPara.Name = "cboxConverterPara";
            this.cboxConverterPara.Size = new System.Drawing.Size(121, 21);
            this.cboxConverterPara.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Converter para:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(125, 150);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.BackColor = System.Drawing.Color.Transparent;
            this.lblResposta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(162, 352);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(19, 23);
            this.lblResposta.TabIndex = 3;
            this.lblResposta.Text = "?";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciciosToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.opçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exerciciosToolStripMenuItem
            // 
            this.exerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularDataToolStripMenuItem,
            this.calcularMediaToolStripMenuItem,
            this.calcularNumerosInteirosToolStripMenuItem,
            this.calculoPorSegundoToolStripMenuItem});
            this.exerciciosToolStripMenuItem.Name = "exerciciosToolStripMenuItem";
            this.exerciciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exerciciosToolStripMenuItem.Text = "Exercicios";
            // 
            // calcularDataToolStripMenuItem
            // 
            this.calcularDataToolStripMenuItem.Name = "calcularDataToolStripMenuItem";
            this.calcularDataToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calcularDataToolStripMenuItem.Text = "Calcular Data ";
            this.calcularDataToolStripMenuItem.Click += new System.EventHandler(this.calcularDataToolStripMenuItem_Click);
            // 
            // calcularMediaToolStripMenuItem
            // 
            this.calcularMediaToolStripMenuItem.Name = "calcularMediaToolStripMenuItem";
            this.calcularMediaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calcularMediaToolStripMenuItem.Text = "Calcular Media";
            this.calcularMediaToolStripMenuItem.Click += new System.EventHandler(this.calcularMediaToolStripMenuItem_Click);
            // 
            // calcularNumerosInteirosToolStripMenuItem
            // 
            this.calcularNumerosInteirosToolStripMenuItem.Name = "calcularNumerosInteirosToolStripMenuItem";
            this.calcularNumerosInteirosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calcularNumerosInteirosToolStripMenuItem.Text = "Calcular Numeros Inteiros";
            this.calcularNumerosInteirosToolStripMenuItem.Click += new System.EventHandler(this.calcularNumerosInteirosToolStripMenuItem_Click);
            // 
            // calculoPorSegundoToolStripMenuItem
            // 
            this.calculoPorSegundoToolStripMenuItem.Name = "calculoPorSegundoToolStripMenuItem";
            this.calculoPorSegundoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calculoPorSegundoToolStripMenuItem.Text = "Calculo por segundo";
            this.calculoPorSegundoToolStripMenuItem.Click += new System.EventHandler(this.calculoPorSegundoToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas ";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // opçãoToolStripMenuItem
            // 
            this.opçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.opçãoToolStripMenuItem.Name = "opçãoToolStripMenuItem";
            this.opçãoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.opçãoToolStripMenuItem.Text = "Opção";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.mtxtNascimento);
            this.groupBox1.Controls.Add(this.cboxConverterPara);
            this.groupBox1.Controls.Add(this.mtxtAnoAtual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // FrmCalcularData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCalcularData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtNascimento;
        private System.Windows.Forms.MaskedTextBox mtxtAnoAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxConverterPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularNumerosInteirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoPorSegundoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

