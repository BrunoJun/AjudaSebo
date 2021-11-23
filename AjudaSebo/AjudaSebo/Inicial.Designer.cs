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
            this.AltInicial = new System.Windows.Forms.Button();
            this.RegInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadInicial
            // 
            this.cadInicial.BackColor = System.Drawing.Color.GreenYellow;
            this.cadInicial.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadInicial.Location = new System.Drawing.Point(251, 12);
            this.cadInicial.Name = "cadInicial";
            this.cadInicial.Size = new System.Drawing.Size(123, 39);
            this.cadInicial.TabIndex = 0;
            this.cadInicial.Text = "Cadastrar";
            this.cadInicial.UseVisualStyleBackColor = false;
            // 
            // conInicial
            // 
            this.conInicial.BackColor = System.Drawing.Color.GreenYellow;
            this.conInicial.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conInicial.Location = new System.Drawing.Point(29, 179);
            this.conInicial.Name = "conInicial";
            this.conInicial.Size = new System.Drawing.Size(123, 36);
            this.conInicial.TabIndex = 1;
            this.conInicial.Text = "Consultar";
            this.conInicial.UseVisualStyleBackColor = false;
            // 
            // AltInicial
            // 
            this.AltInicial.BackColor = System.Drawing.Color.GreenYellow;
            this.AltInicial.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltInicial.ForeColor = System.Drawing.Color.Black;
            this.AltInicial.Location = new System.Drawing.Point(461, 179);
            this.AltInicial.Name = "AltInicial";
            this.AltInicial.Size = new System.Drawing.Size(126, 36);
            this.AltInicial.TabIndex = 2;
            this.AltInicial.Text = "Alterar";
            this.AltInicial.UseVisualStyleBackColor = false;
            // 
            // RegInicial
            // 
            this.RegInicial.BackColor = System.Drawing.Color.GreenYellow;
            this.RegInicial.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegInicial.Location = new System.Drawing.Point(189, 326);
            this.RegInicial.Name = "RegInicial";
            this.RegInicial.Size = new System.Drawing.Size(249, 34);
            this.RegInicial.TabIndex = 3;
            this.RegInicial.Text = "Registrar Venda";
            this.RegInicial.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::AjudaSebo.Properties.Resources.Logo_AjudaSEBO1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(647, 363);
            this.Controls.Add(this.RegInicial);
            this.Controls.Add(this.AltInicial);
            this.Controls.Add(this.conInicial);
            this.Controls.Add(this.cadInicial);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "AjudaSebo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadInicial;
        private System.Windows.Forms.Button conInicial;
        private System.Windows.Forms.Button AltInicial;
        private System.Windows.Forms.Button RegInicial;
    }
}

