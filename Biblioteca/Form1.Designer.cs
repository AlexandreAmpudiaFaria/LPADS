namespace Biblioteca
{
    partial class Form1
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
            this.btnMenuCadastroProdutos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEfetuarLoc = new System.Windows.Forms.Button();
            this.btnMenuCadastrarCli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEfetuarDevolucao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenuCadastroProdutos
            // 
            this.btnMenuCadastroProdutos.Location = new System.Drawing.Point(196, 207);
            this.btnMenuCadastroProdutos.Name = "btnMenuCadastroProdutos";
            this.btnMenuCadastroProdutos.Size = new System.Drawing.Size(130, 109);
            this.btnMenuCadastroProdutos.TabIndex = 0;
            this.btnMenuCadastroProdutos.Text = "Cadastrar Produtos";
            this.btnMenuCadastroProdutos.UseVisualStyleBackColor = true;
            this.btnMenuCadastroProdutos.Click += new System.EventHandler(this.btnMenuCadastroProdutos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 109);
            this.button2.TabIndex = 1;
            this.button2.Text = "Relatorios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEfetuarLoc
            // 
            this.btnEfetuarLoc.Location = new System.Drawing.Point(29, 48);
            this.btnEfetuarLoc.Name = "btnEfetuarLoc";
            this.btnEfetuarLoc.Size = new System.Drawing.Size(130, 109);
            this.btnEfetuarLoc.TabIndex = 2;
            this.btnEfetuarLoc.Text = "Efetuar Locação";
            this.btnEfetuarLoc.UseVisualStyleBackColor = true;
            this.btnEfetuarLoc.Click += new System.EventHandler(this.btnEfetuarLoc_Click);
            // 
            // btnMenuCadastrarCli
            // 
            this.btnMenuCadastrarCli.Location = new System.Drawing.Point(29, 207);
            this.btnMenuCadastrarCli.Name = "btnMenuCadastrarCli";
            this.btnMenuCadastrarCli.Size = new System.Drawing.Size(130, 109);
            this.btnMenuCadastrarCli.TabIndex = 3;
            this.btnMenuCadastrarCli.Text = "Cadastrar Cliente";
            this.btnMenuCadastrarCli.UseVisualStyleBackColor = true;
            this.btnMenuCadastrarCli.Click += new System.EventHandler(this.btnMenuCadastrarCli_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 109);
            this.button1.TabIndex = 4;
            this.button1.Text = "Função Desativada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEfetuarDevolucao
            // 
            this.btnEfetuarDevolucao.Location = new System.Drawing.Point(196, 48);
            this.btnEfetuarDevolucao.Name = "btnEfetuarDevolucao";
            this.btnEfetuarDevolucao.Size = new System.Drawing.Size(130, 109);
            this.btnEfetuarDevolucao.TabIndex = 5;
            this.btnEfetuarDevolucao.Text = "Efetuar Devolução";
            this.btnEfetuarDevolucao.UseVisualStyleBackColor = true;
            this.btnEfetuarDevolucao.Click += new System.EventHandler(this.btnEfetuarDevolucao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEfetuarDevolucao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMenuCadastrarCli);
            this.Controls.Add(this.btnEfetuarLoc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMenuCadastroProdutos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuCadastroProdutos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEfetuarLoc;
        private System.Windows.Forms.Button btnMenuCadastrarCli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEfetuarDevolucao;
        private System.Windows.Forms.Label label1;
    }
}

