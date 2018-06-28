namespace Biblioteca
{
    partial class frmCadastrarCliente
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
            this.txtNomeCadCli = new System.Windows.Forms.TextBox();
            this.txtIdCadCli = new System.Windows.Forms.TextBox();
            this.btnInserirCadCli = new System.Windows.Forms.Button();
            this.btnCancelarCadCli = new System.Windows.Forms.Button();
            this.btnRemoverCadCli = new System.Windows.Forms.Button();
            this.btnEditarCadCli = new System.Windows.Forms.Button();
            this.dgvCadCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txtNomeCadCli
            // 
            this.txtNomeCadCli.Location = new System.Drawing.Point(81, 81);
            this.txtNomeCadCli.Name = "txtNomeCadCli";
            this.txtNomeCadCli.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCadCli.TabIndex = 3;
            // 
            // txtIdCadCli
            // 
            this.txtIdCadCli.Location = new System.Drawing.Point(81, 48);
            this.txtIdCadCli.Name = "txtIdCadCli";
            this.txtIdCadCli.Size = new System.Drawing.Size(100, 20);
            this.txtIdCadCli.TabIndex = 4;
            this.txtIdCadCli.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnInserirCadCli
            // 
            this.btnInserirCadCli.Location = new System.Drawing.Point(213, 48);
            this.btnInserirCadCli.Name = "btnInserirCadCli";
            this.btnInserirCadCli.Size = new System.Drawing.Size(75, 23);
            this.btnInserirCadCli.TabIndex = 5;
            this.btnInserirCadCli.Text = "Inserir";
            this.btnInserirCadCli.UseVisualStyleBackColor = true;
            this.btnInserirCadCli.Click += new System.EventHandler(this.btnInserirCadCli_Click);
            // 
            // btnCancelarCadCli
            // 
            this.btnCancelarCadCli.Location = new System.Drawing.Point(301, 81);
            this.btnCancelarCadCli.Name = "btnCancelarCadCli";
            this.btnCancelarCadCli.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadCli.TabIndex = 6;
            this.btnCancelarCadCli.Text = "Cancelar";
            this.btnCancelarCadCli.UseVisualStyleBackColor = true;
            this.btnCancelarCadCli.Click += new System.EventHandler(this.btnCancelarCadCli_Click);
            // 
            // btnRemoverCadCli
            // 
            this.btnRemoverCadCli.Location = new System.Drawing.Point(301, 48);
            this.btnRemoverCadCli.Name = "btnRemoverCadCli";
            this.btnRemoverCadCli.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverCadCli.TabIndex = 7;
            this.btnRemoverCadCli.Text = "Remover";
            this.btnRemoverCadCli.UseVisualStyleBackColor = true;
            this.btnRemoverCadCli.Click += new System.EventHandler(this.btnRemoverCadCli_Click);
            // 
            // btnEditarCadCli
            // 
            this.btnEditarCadCli.Location = new System.Drawing.Point(213, 81);
            this.btnEditarCadCli.Name = "btnEditarCadCli";
            this.btnEditarCadCli.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCadCli.TabIndex = 8;
            this.btnEditarCadCli.Text = "Editar";
            this.btnEditarCadCli.UseVisualStyleBackColor = true;
            this.btnEditarCadCli.Click += new System.EventHandler(this.btnEditarCadCli_Click);
            // 
            // dgvCadCliente
            // 
            this.dgvCadCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadCliente.Location = new System.Drawing.Point(107, 134);
            this.dgvCadCliente.Name = "dgvCadCliente";
            this.dgvCadCliente.Size = new System.Drawing.Size(210, 304);
            this.dgvCadCliente.TabIndex = 9;
            this.dgvCadCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadCliente_CellContentClick);
            // 
            // frmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.dgvCadCliente);
            this.Controls.Add(this.btnEditarCadCli);
            this.Controls.Add(this.btnRemoverCadCli);
            this.Controls.Add(this.btnCancelarCadCli);
            this.Controls.Add(this.btnInserirCadCli);
            this.Controls.Add(this.txtIdCadCli);
            this.Controls.Add(this.txtNomeCadCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarCliente";
            this.Load += new System.EventHandler(this.frmCadastrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCadCli;
        private System.Windows.Forms.TextBox txtIdCadCli;
        private System.Windows.Forms.Button btnInserirCadCli;
        private System.Windows.Forms.Button btnCancelarCadCli;
        private System.Windows.Forms.Button btnRemoverCadCli;
        private System.Windows.Forms.Button btnEditarCadCli;
        private System.Windows.Forms.DataGridView dgvCadCliente;
    }
}