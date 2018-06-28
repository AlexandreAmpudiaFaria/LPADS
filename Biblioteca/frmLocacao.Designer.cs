namespace Biblioteca
{
    partial class frmLocacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClientesLocacao = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvLocacaoProdutos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCarrinhovenda = new System.Windows.Forms.DataGridView();
            this.dgvCabecalho = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoverProdutoCarrinho = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLocar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesLocacao)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacaoProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhovenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabecalho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Locação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clientes:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvClientesLocacao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 399);
            this.panel1.TabIndex = 6;
            // 
            // dgvClientesLocacao
            // 
            this.dgvClientesLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesLocacao.Location = new System.Drawing.Point(16, 117);
            this.dgvClientesLocacao.Name = "dgvClientesLocacao";
            this.dgvClientesLocacao.Size = new System.Drawing.Size(199, 262);
            this.dgvClientesLocacao.TabIndex = 6;
            this.dgvClientesLocacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesLocacao_CellContentClick);
            this.dgvClientesLocacao.DoubleClick += new System.EventHandler(this.dgvClientesLocacao_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.dgvLocacaoProdutos);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(252, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 399);
            this.panel2.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(264, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "-----";
            // 
            // dgvLocacaoProdutos
            // 
            this.dgvLocacaoProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocacaoProdutos.Location = new System.Drawing.Point(16, 117);
            this.dgvLocacaoProdutos.Name = "dgvLocacaoProdutos";
            this.dgvLocacaoProdutos.Size = new System.Drawing.Size(286, 262);
            this.dgvLocacaoProdutos.TabIndex = 6;
            this.dgvLocacaoProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocacaoProdutos_CellContentClick);
            this.dgvLocacaoProdutos.DoubleClick += new System.EventHandler(this.dgvLocacaoProdutos_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Produtos:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvCarrinhovenda);
            this.panel3.Controls.Add(this.dgvCabecalho);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnRemoverProdutoCarrinho);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.btnLocar);
            this.panel3.Location = new System.Drawing.Point(580, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 399);
            this.panel3.TabIndex = 8;
            // 
            // dgvCarrinhovenda
            // 
            this.dgvCarrinhovenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinhovenda.Location = new System.Drawing.Point(17, 187);
            this.dgvCarrinhovenda.Name = "dgvCarrinhovenda";
            this.dgvCarrinhovenda.Size = new System.Drawing.Size(306, 147);
            this.dgvCarrinhovenda.TabIndex = 12;
            this.dgvCarrinhovenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinhovenda_CellContentClick);
            // 
            // dgvCabecalho
            // 
            this.dgvCabecalho.AllowUserToOrderColumns = true;
            this.dgvCabecalho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabecalho.Location = new System.Drawing.Point(17, 60);
            this.dgvCabecalho.Name = "dgvCabecalho";
            this.dgvCabecalho.Size = new System.Drawing.Size(306, 64);
            this.dgvCabecalho.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "Dados do cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dados do produto:";
            // 
            // btnRemoverProdutoCarrinho
            // 
            this.btnRemoverProdutoCarrinho.Location = new System.Drawing.Point(121, 340);
            this.btnRemoverProdutoCarrinho.Name = "btnRemoverProdutoCarrinho";
            this.btnRemoverProdutoCarrinho.Size = new System.Drawing.Size(98, 38);
            this.btnRemoverProdutoCarrinho.TabIndex = 12;
            this.btnRemoverProdutoCarrinho.Text = "Remover";
            this.btnRemoverProdutoCarrinho.UseVisualStyleBackColor = true;
            this.btnRemoverProdutoCarrinho.Click += new System.EventHandler(this.btnRemoverProdutoCarrinho_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(237, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 38);
            this.button4.TabIndex = 11;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLocar
            // 
            this.btnLocar.Location = new System.Drawing.Point(17, 341);
            this.btnLocar.Name = "btnLocar";
            this.btnLocar.Size = new System.Drawing.Size(98, 38);
            this.btnLocar.TabIndex = 7;
            this.btnLocar.Text = "Locar";
            this.btnLocar.UseVisualStyleBackColor = true;
            this.btnLocar.Click += new System.EventHandler(this.btnLocar_Click);
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmLocacao";
            this.Text = "frmLocacao";
            this.Load += new System.EventHandler(this.frmLocacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesLocacao)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacaoProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhovenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabecalho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClientesLocacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLocacaoProdutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLocar;
        private System.Windows.Forms.Button btnRemoverProdutoCarrinho;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvCarrinhovenda;
        private System.Windows.Forms.DataGridView dgvCabecalho;
    }
}