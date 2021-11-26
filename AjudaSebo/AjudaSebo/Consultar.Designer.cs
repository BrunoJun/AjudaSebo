namespace AjudaSebo
{
    partial class Consultar
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.textEditora = new System.Windows.Forms.TextBox();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.lbnCon5 = new System.Windows.Forms.Label();
            this.lbnAutor = new System.Windows.Forms.Label();
            this.lbnEditora = new System.Windows.Forms.Label();
            this.lbnGenero = new System.Windows.Forms.Label();
            this.lbnCon1 = new System.Windows.Forms.Label();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.bttAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(97, 304);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(134, 41);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnConVoltar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(435, 304);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 41);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConTela_Click);
            // 
            // textEditora
            // 
            this.textEditora.Location = new System.Drawing.Point(201, 124);
            this.textEditora.Multiline = true;
            this.textEditora.Name = "textEditora";
            this.textEditora.Size = new System.Drawing.Size(321, 25);
            this.textEditora.TabIndex = 19;
            this.textEditora.Visible = false;
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(201, 67);
            this.textISBN.Multiline = true;
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(321, 25);
            this.textISBN.TabIndex = 18;
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(201, 13);
            this.textTitulo.Multiline = true;
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(321, 25);
            this.textTitulo.TabIndex = 17;
            // 
            // lbnCon5
            // 
            this.lbnCon5.AutoSize = true;
            this.lbnCon5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbnCon5.Location = new System.Drawing.Point(114, 67);
            this.lbnCon5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbnCon5.Name = "lbnCon5";
            this.lbnCon5.Size = new System.Drawing.Size(62, 22);
            this.lbnCon5.TabIndex = 16;
            this.lbnCon5.Text = "ISBN:";
            // 
            // lbnAutor
            // 
            this.lbnAutor.AutoSize = true;
            this.lbnAutor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbnAutor.Location = new System.Drawing.Point(112, 181);
            this.lbnAutor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbnAutor.Name = "lbnAutor";
            this.lbnAutor.Size = new System.Drawing.Size(68, 22);
            this.lbnAutor.TabIndex = 15;
            this.lbnAutor.Text = "Autor:";
            this.lbnAutor.Visible = false;
            // 
            // lbnEditora
            // 
            this.lbnEditora.AutoSize = true;
            this.lbnEditora.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbnEditora.Location = new System.Drawing.Point(93, 124);
            this.lbnEditora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbnEditora.Name = "lbnEditora";
            this.lbnEditora.Size = new System.Drawing.Size(84, 22);
            this.lbnEditora.TabIndex = 14;
            this.lbnEditora.Text = "Editora:";
            this.lbnEditora.Visible = false;
            // 
            // lbnGenero
            // 
            this.lbnGenero.AutoSize = true;
            this.lbnGenero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbnGenero.Location = new System.Drawing.Point(92, 241);
            this.lbnGenero.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbnGenero.Name = "lbnGenero";
            this.lbnGenero.Size = new System.Drawing.Size(86, 22);
            this.lbnGenero.TabIndex = 13;
            this.lbnGenero.Text = "Gênero:";
            this.lbnGenero.Visible = false;
            // 
            // lbnCon1
            // 
            this.lbnCon1.AutoSize = true;
            this.lbnCon1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbnCon1.Location = new System.Drawing.Point(105, 13);
            this.lbnCon1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbnCon1.Name = "lbnCon1";
            this.lbnCon1.Size = new System.Drawing.Size(70, 22);
            this.lbnCon1.TabIndex = 12;
            this.lbnCon1.Text = "Título:";
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(201, 181);
            this.textAutor.Multiline = true;
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(321, 25);
            this.textAutor.TabIndex = 24;
            this.textAutor.Visible = false;
            // 
            // textGenero
            // 
            this.textGenero.Location = new System.Drawing.Point(201, 241);
            this.textGenero.Multiline = true;
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(321, 25);
            this.textGenero.TabIndex = 25;
            this.textGenero.Visible = false;
            // 
            // bttAlterar
            // 
            this.bttAlterar.BackColor = System.Drawing.Color.YellowGreen;
            this.bttAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttAlterar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAlterar.ForeColor = System.Drawing.Color.Black;
            this.bttAlterar.Location = new System.Drawing.Point(270, 304);
            this.bttAlterar.Name = "bttAlterar";
            this.bttAlterar.Size = new System.Drawing.Size(125, 41);
            this.bttAlterar.TabIndex = 26;
            this.bttAlterar.Text = "Alterar";
            this.bttAlterar.UseVisualStyleBackColor = false;
            this.bttAlterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(636, 357);
            this.Controls.Add(this.bttAlterar);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.textAutor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.textEditora);
            this.Controls.Add(this.textISBN);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.lbnCon5);
            this.Controls.Add(this.lbnAutor);
            this.Controls.Add(this.lbnEditora);
            this.Controls.Add(this.lbnGenero);
            this.Controls.Add(this.lbnCon1);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox textEditora;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Label lbnCon5;
        private System.Windows.Forms.Label lbnAutor;
        private System.Windows.Forms.Label lbnEditora;
        private System.Windows.Forms.Label lbnGenero;
        private System.Windows.Forms.Label lbnCon1;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.Button bttAlterar;
    }
}