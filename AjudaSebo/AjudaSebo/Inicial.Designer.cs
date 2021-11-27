namespace AjudaSebo
{
    partial class Inicial
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
            this.cadInicial = new System.Windows.Forms.Button();
            this.conInicial = new System.Windows.Forms.Button();
            this.bttConsultarVendas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadInicial
            // 
            this.cadInicial.BackColor = System.Drawing.Color.GreenYellow;
            this.cadInicial.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadInicial.Location = new System.Drawing.Point(12, 179);
            this.cadInicial.Name = "cadInicial";
            this.cadInicial.Size = new System.Drawing.Size(123, 39);
            this.cadInicial.TabIndex = 0;
            this.cadInicial.Text = "Cadastrar";
            this.cadInicial.UseVisualStyleBackColor = false;
            this.cadInicial.Click += new System.EventHandler(this.cadInicial_Click);
            // 
            // conInicial
            // 
            this.conInicial.BackColor = System.Drawing.Color.GreenYellow;
            this.conInicial.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conInicial.Location = new System.Drawing.Point(520, 179);
            this.conInicial.Name = "conInicial";
            this.conInicial.Size = new System.Drawing.Size(123, 36);
            this.conInicial.TabIndex = 1;
            this.conInicial.Text = "Consultar";
            this.conInicial.UseVisualStyleBackColor = false;
            this.conInicial.Click += new System.EventHandler(this.conInicial_Click);
            // 
            // bttConsultarVendas
            // 
            this.bttConsultarVendas.BackColor = System.Drawing.Color.GreenYellow;
            this.bttConsultarVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttConsultarVendas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttConsultarVendas.Location = new System.Drawing.Point(217, 29);
            this.bttConsultarVendas.Name = "bttConsultarVendas";
            this.bttConsultarVendas.Size = new System.Drawing.Size(186, 34);
            this.bttConsultarVendas.TabIndex = 3;
            this.bttConsultarVendas.Text = "Consultar Venda";
            this.bttConsultarVendas.UseVisualStyleBackColor = false;
            this.bttConsultarVendas.Click += new System.EventHandler(this.bttConsultarVendas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(250, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::AjudaSebo.Properties.Resources.Logo_AjudaSEBO1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(655, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttConsultarVendas);
            this.Controls.Add(this.conInicial);
            this.Controls.Add(this.cadInicial);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Inicial";
            this.Text = "AjudaSebo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadInicial;
        private System.Windows.Forms.Button conInicial;
        private System.Windows.Forms.Button bttConsultarVendas;
        private System.Windows.Forms.Button button1;
    }
}

