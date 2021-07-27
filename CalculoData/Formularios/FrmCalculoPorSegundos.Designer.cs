
namespace CalculoData
{
    partial class FrmCalculoPorSegundos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.cboxConverterPara = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 43);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calcular Tempo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Digite o Tempo em segundos:";
            // 
            // txtSegundos
            // 
            this.txtSegundos.Location = new System.Drawing.Point(229, 29);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(117, 20);
            this.txtSegundos.TabIndex = 11;
            // 
            // cboxConverterPara
            // 
            this.cboxConverterPara.FormattingEnabled = true;
            this.cboxConverterPara.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas",
            "Horas/Min/Seg"});
            this.cboxConverterPara.Location = new System.Drawing.Point(229, 76);
            this.cboxConverterPara.Name = "cboxConverterPara";
            this.cboxConverterPara.Size = new System.Drawing.Size(117, 21);
            this.cboxConverterPara.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Converter para:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(148, 135);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.BackColor = System.Drawing.Color.Transparent;
            this.lblResposta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(112, 355);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(19, 23);
            this.lblResposta.TabIndex = 15;
            this.lblResposta.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Resultado:";
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
            this.menuStrip1.TabIndex = 18;
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSegundos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxConverterPara);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Location = new System.Drawing.Point(60, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 164);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // FrmCalculoPorSegundos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.IsMdiContainer = true;
            this.Name = "FrmCalculoPorSegundos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Por Segundos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.ComboBox cboxConverterPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularNumerosInteirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoPorSegundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}