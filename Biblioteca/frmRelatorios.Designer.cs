namespace Biblioteca
{
    partial class frmRelatorios
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRelatorioProd = new System.Windows.Forms.DataGridView();
            this.btnExibirClientes = new System.Windows.Forms.Button();
            this.dgvRelatorioCli = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbLocadosFiltro = new System.Windows.Forms.RadioButton();
            this.rdbLivresFiltro = new System.Windows.Forms.RadioButton();
            this.rdbTodosFiltro = new System.Windows.Forms.RadioButton();
            this.dgvRelatorioVendas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVendasRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatorios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clientes:";
            // 
            // dgvRelatorioProd
            // 
            this.dgvRelatorioProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioProd.Location = new System.Drawing.Point(12, 138);
            this.dgvRelatorioProd.Name = "dgvRelatorioProd";
            this.dgvRelatorioProd.Size = new System.Drawing.Size(346, 297);
            this.dgvRelatorioProd.TabIndex = 4;
            // 
            // btnExibirClientes
            // 
            this.btnExibirClientes.Location = new System.Drawing.Point(451, 109);
            this.btnExibirClientes.Name = "btnExibirClientes";
            this.btnExibirClientes.Size = new System.Drawing.Size(75, 23);
            this.btnExibirClientes.TabIndex = 9;
            this.btnExibirClientes.Text = "Exibir";
            this.btnExibirClientes.UseVisualStyleBackColor = true;
            this.btnExibirClientes.Click += new System.EventHandler(this.btnExibirClientes_Click);
            // 
            // dgvRelatorioCli
            // 
            this.dgvRelatorioCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioCli.Location = new System.Drawing.Point(372, 137);
            this.dgvRelatorioCli.Name = "dgvRelatorioCli";
            this.dgvRelatorioCli.Size = new System.Drawing.Size(250, 300);
            this.dgvRelatorioCli.TabIndex = 8;
            this.dgvRelatorioCli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelatorioCli_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produtos:";
            // 
            // rdbLocadosFiltro
            // 
            this.rdbLocadosFiltro.AutoSize = true;
            this.rdbLocadosFiltro.Location = new System.Drawing.Point(156, 111);
            this.rdbLocadosFiltro.Name = "rdbLocadosFiltro";
            this.rdbLocadosFiltro.Size = new System.Drawing.Size(66, 17);
            this.rdbLocadosFiltro.TabIndex = 14;
            this.rdbLocadosFiltro.Text = "Locados";
            this.rdbLocadosFiltro.UseVisualStyleBackColor = true;
            this.rdbLocadosFiltro.CheckedChanged += new System.EventHandler(this.rdbLocadosFiltro_CheckedChanged);
            // 
            // rdbLivresFiltro
            // 
            this.rdbLivresFiltro.AutoSize = true;
            this.rdbLivresFiltro.Location = new System.Drawing.Point(271, 111);
            this.rdbLivresFiltro.Name = "rdbLivresFiltro";
            this.rdbLivresFiltro.Size = new System.Drawing.Size(53, 17);
            this.rdbLivresFiltro.TabIndex = 15;
            this.rdbLivresFiltro.Text = "Livres";
            this.rdbLivresFiltro.UseVisualStyleBackColor = true;
            this.rdbLivresFiltro.CheckedChanged += new System.EventHandler(this.rdbLivresFiltro_CheckedChanged);
            // 
            // rdbTodosFiltro
            // 
            this.rdbTodosFiltro.AutoSize = true;
            this.rdbTodosFiltro.Location = new System.Drawing.Point(48, 112);
            this.rdbTodosFiltro.Name = "rdbTodosFiltro";
            this.rdbTodosFiltro.Size = new System.Drawing.Size(55, 17);
            this.rdbTodosFiltro.TabIndex = 16;
            this.rdbTodosFiltro.Text = "Todos";
            this.rdbTodosFiltro.UseVisualStyleBackColor = true;
            this.rdbTodosFiltro.CheckedChanged += new System.EventHandler(this.rdbTodosFiltro_CheckedChanged);
            // 
            // dgvRelatorioVendas
            // 
            this.dgvRelatorioVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioVendas.Location = new System.Drawing.Point(641, 137);
            this.dgvRelatorioVendas.Name = "dgvRelatorioVendas";
            this.dgvRelatorioVendas.Size = new System.Drawing.Size(516, 300);
            this.dgvRelatorioVendas.TabIndex = 18;
            this.dgvRelatorioVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelatorioVendas_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(879, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Vendas";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnVendasRelatorio
            // 
            this.btnVendasRelatorio.Location = new System.Drawing.Point(1042, 109);
            this.btnVendasRelatorio.Name = "btnVendasRelatorio";
            this.btnVendasRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btnVendasRelatorio.TabIndex = 19;
            this.btnVendasRelatorio.Text = "Mostrar";
            this.btnVendasRelatorio.UseVisualStyleBackColor = true;
            this.btnVendasRelatorio.Click += new System.EventHandler(this.btnVendasRelatorio_Click);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 450);
            this.Controls.Add(this.btnVendasRelatorio);
            this.Controls.Add(this.dgvRelatorioVendas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdbTodosFiltro);
            this.Controls.Add(this.rdbLivresFiltro);
            this.Controls.Add(this.rdbLocadosFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnExibirClientes);
            this.Controls.Add(this.dgvRelatorioCli);
            this.Controls.Add(this.dgvRelatorioProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRelatorioProd;
        private System.Windows.Forms.Button btnExibirClientes;
        private System.Windows.Forms.DataGridView dgvRelatorioCli;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbLocadosFiltro;
        private System.Windows.Forms.RadioButton rdbLivresFiltro;
        private System.Windows.Forms.RadioButton rdbTodosFiltro;
        private System.Windows.Forms.DataGridView dgvRelatorioVendas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVendasRelatorio;
    }
}