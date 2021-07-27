
namespace CalculoData.Formularios
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculoPorSegundo = new System.Windows.Forms.Button();
            this.btnCalcularNumeros = new System.Windows.Forms.Button();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.btnCalcularData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 43);
            this.label4.TabIndex = 5;
            this.label4.Text = "Escolha um programa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCalculoPorSegundo);
            this.groupBox1.Controls.Add(this.btnCalcularNumeros);
            this.groupBox1.Controls.Add(this.btnCalcularMedia);
            this.groupBox1.Controls.Add(this.btnCalcularData);
            this.groupBox1.Location = new System.Drawing.Point(126, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnCalculoPorSegundo
            // 
            this.btnCalculoPorSegundo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCalculoPorSegundo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCalculoPorSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculoPorSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculoPorSegundo.Location = new System.Drawing.Point(36, 108);
            this.btnCalculoPorSegundo.Name = "btnCalculoPorSegundo";
            this.btnCalculoPorSegundo.Size = new System.Drawing.Size(169, 28);
            this.btnCalculoPorSegundo.TabIndex = 3;
            this.btnCalculoPorSegundo.Text = "Calculo por segundo";
            this.btnCalculoPorSegundo.UseVisualStyleBackColor = true;
            this.btnCalculoPorSegundo.Click += new System.EventHandler(this.btnCalculoPorSegundo_Click);
            // 
            // btnCalcularNumeros
            // 
            this.btnCalcularNumeros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCalcularNumeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCalcularNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularNumeros.Location = new System.Drawing.Point(36, 46);
            this.btnCalcularNumeros.Name = "btnCalcularNumeros";
            this.btnCalcularNumeros.Size = new System.Drawing.Size(169, 28);
            this.btnCalcularNumeros.TabIndex = 2;
            this.btnCalcularNumeros.Text = "Calcular Numeros inteiros";
            this.btnCalcularNumeros.UseVisualStyleBackColor = true;
            this.btnCalcularNumeros.Click += new System.EventHandler(this.btnCalcularNumeros_Click);
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCalcularMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCalcularMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularMedia.Location = new System.Drawing.Point(36, 76);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(169, 28);
            this.btnCalcularMedia.TabIndex = 1;
            this.btnCalcularMedia.Text = "Calcular media";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // btnCalcularData
            // 
            this.btnCalcularData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCalcularData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCalcularData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularData.Location = new System.Drawing.Point(36, 16);
            this.btnCalcularData.Name = "btnCalcularData";
            this.btnCalcularData.Size = new System.Drawing.Size(169, 28);
            this.btnCalcularData.TabIndex = 0;
            this.btnCalcularData.Text = "Calcular data";
            this.btnCalcularData.UseVisualStyleBackColor = true;
            this.btnCalcularData.Click += new System.EventHandler(this.btnCalcularData_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculoPorSegundo;
        private System.Windows.Forms.Button btnCalcularNumeros;
        private System.Windows.Forms.Button btnCalcularMedia;
        private System.Windows.Forms.Button btnCalcularData;
    }
}