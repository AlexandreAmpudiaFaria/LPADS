namespace Biblioteca
{
    partial class frmCadastroProdutos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricaoCadProd = new System.Windows.Forms.TextBox();
            this.txtStatusCadProd = new System.Windows.Forms.TextBox();
            this.txtQuantCadProd = new System.Windows.Forms.TextBox();
            this.dgvCadProdutos = new System.Windows.Forms.DataGridView();
            this.btnInserirCadProd = new System.Windows.Forms.Button();
            this.btnRemoverCadProd = new System.Windows.Forms.Button();
            this.btnEditarCadProd = new System.Windows.Forms.Button();
            this.btnCancelarCadProd = new System.Windows.Forms.Button();
            this.txtIdCadProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade:";
            // 
            // txtDescricaoCadProd
            // 
            this.txtDescricaoCadProd.Location = new System.Drawing.Point(183, 98);
            this.txtDescricaoCadProd.Name = "txtDescricaoCadProd";
            this.txtDescricaoCadProd.Size = new System.Drawing.Size(135, 20);
            this.txtDescricaoCadProd.TabIndex = 6;
            // 
            // txtStatusCadProd
            // 
            this.txtStatusCadProd.Location = new System.Drawing.Point(183, 125);
            this.txtStatusCadProd.Name = "txtStatusCadProd";
            this.txtStatusCadProd.Size = new System.Drawing.Size(135, 20);
            this.txtStatusCadProd.TabIndex = 7;
            // 
            // txtQuantCadProd
            // 
            this.txtQuantCadProd.Location = new System.Drawing.Point(183, 152);
            this.txtQuantCadProd.Name = "txtQuantCadProd";
            this.txtQuantCadProd.Size = new System.Drawing.Size(135, 20);
            this.txtQuantCadProd.TabIndex = 8;
            // 
            // dgvCadProdutos
            // 
            this.dgvCadProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadProdutos.Location = new System.Drawing.Point(36, 198);
            this.dgvCadProdutos.Name = "dgvCadProdutos";
            this.dgvCadProdutos.Size = new System.Drawing.Size(458, 240);
            this.dgvCadProdutos.TabIndex = 9;
            // 
            // btnInserirCadProd
            // 
            this.btnInserirCadProd.Location = new System.Drawing.Point(344, 64);
            this.btnInserirCadProd.Name = "btnInserirCadProd";
            this.btnInserirCadProd.Size = new System.Drawing.Size(75, 23);
            this.btnInserirCadProd.TabIndex = 10;
            this.btnInserirCadProd.Text = "Inserir";
            this.btnInserirCadProd.UseVisualStyleBackColor = true;
            this.btnInserirCadProd.Click += new System.EventHandler(this.btnInserirCadProd_Click);
            // 
            // btnRemoverCadProd
            // 
            this.btnRemoverCadProd.Location = new System.Drawing.Point(344, 93);
            this.btnRemoverCadProd.Name = "btnRemoverCadProd";
            this.btnRemoverCadProd.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverCadProd.TabIndex = 11;
            this.btnRemoverCadProd.Text = "Remover";
            this.btnRemoverCadProd.UseVisualStyleBackColor = true;
            this.btnRemoverCadProd.Click += new System.EventHandler(this.btnRemoverCadProd_Click);
            // 
            // btnEditarCadProd
            // 
            this.btnEditarCadProd.Location = new System.Drawing.Point(344, 123);
            this.btnEditarCadProd.Name = "btnEditarCadProd";
            this.btnEditarCadProd.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCadProd.TabIndex = 12;
            this.btnEditarCadProd.Text = "Editar";
            this.btnEditarCadProd.UseVisualStyleBackColor = true;
            this.btnEditarCadProd.Click += new System.EventHandler(this.btnEditarCadProd_Click);
            // 
            // btnCancelarCadProd
            // 
            this.btnCancelarCadProd.Location = new System.Drawing.Point(344, 152);
            this.btnCancelarCadProd.Name = "btnCancelarCadProd";
            this.btnCancelarCadProd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadProd.TabIndex = 13;
            this.btnCancelarCadProd.Text = "Cancelar";
            this.btnCancelarCadProd.UseVisualStyleBackColor = true;
            this.btnCancelarCadProd.Click += new System.EventHandler(this.btnCancelarCadProd_Click);
            // 
            // txtIdCadProd
            // 
            this.txtIdCadProd.Location = new System.Drawing.Point(183, 72);
            this.txtIdCadProd.Name = "txtIdCadProd";
            this.txtIdCadProd.Size = new System.Drawing.Size(135, 20);
            this.txtIdCadProd.TabIndex = 14;
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.txtIdCadProd);
            this.Controls.Add(this.btnCancelarCadProd);
            this.Controls.Add(this.btnEditarCadProd);
            this.Controls.Add(this.btnRemoverCadProd);
            this.Controls.Add(this.btnInserirCadProd);
            this.Controls.Add(this.dgvCadProdutos);
            this.Controls.Add(this.txtQuantCadProd);
            this.Controls.Add(this.txtStatusCadProd);
            this.Controls.Add(this.txtDescricaoCadProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroProdutos";
            this.Text = "frmCadastroProdutos";
            this.Load += new System.EventHandler(this.frmCadastroProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricaoCadProd;
        private System.Windows.Forms.TextBox txtStatusCadProd;
        private System.Windows.Forms.TextBox txtQuantCadProd;
        private System.Windows.Forms.DataGridView dgvCadProdutos;
        private System.Windows.Forms.Button btnInserirCadProd;
        private System.Windows.Forms.Button btnRemoverCadProd;
        private System.Windows.Forms.Button btnEditarCadProd;
        private System.Windows.Forms.Button btnCancelarCadProd;
        private System.Windows.Forms.TextBox txtIdCadProd;
    }
}