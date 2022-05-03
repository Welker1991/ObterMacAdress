namespace MacAdress
{
    partial class Frm_ObtendoMacAdress
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
            this.Lb_Resultado = new System.Windows.Forms.ListBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Resultado
            // 
            this.Lb_Resultado.FormattingEnabled = true;
            this.Lb_Resultado.Location = new System.Drawing.Point(58, 38);
            this.Lb_Resultado.Name = "Lb_Resultado";
            this.Lb_Resultado.Size = new System.Drawing.Size(230, 95);
            this.Lb_Resultado.TabIndex = 0;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(58, 161);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(120, 23);
            this.Btn_Buscar.TabIndex = 1;
            this.Btn_Buscar.Text = "Obter endereço MAC";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(213, 161);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 2;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Frm_ObtendoMacAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 283);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lb_Resultado);
            this.Name = "Frm_ObtendoMacAdress";
            this.Text = "Obtendo Endereço MAC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_Resultado;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Limpar;
    }
}

