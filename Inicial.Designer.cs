namespace MultPedidos
{
    partial class Tela_Inicial
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
            this.btnTelaInicialPesquisarCliente = new System.Windows.Forms.Button();
            this.btnTelaInicialCadastroCliente = new System.Windows.Forms.Button();
            this.btnTelaInicialCadastroProduto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnTelaInicialPesquisarCliente
            // 
            this.btnTelaInicialPesquisarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelaInicialPesquisarCliente.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaInicialPesquisarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelaInicialPesquisarCliente.Location = new System.Drawing.Point(113, 205);
            this.btnTelaInicialPesquisarCliente.Name = "btnTelaInicialPesquisarCliente";
            this.btnTelaInicialPesquisarCliente.Size = new System.Drawing.Size(181, 79);
            this.btnTelaInicialPesquisarCliente.TabIndex = 1;
            this.btnTelaInicialPesquisarCliente.Text = "Pesquisar Cliente";
            this.btnTelaInicialPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnTelaInicialPesquisarCliente.Click += new System.EventHandler(this.buttonTelaInicialPesquisarCliente_Click);
            // 
            // btnTelaInicialCadastroCliente
            // 
            this.btnTelaInicialCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelaInicialCadastroCliente.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaInicialCadastroCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelaInicialCadastroCliente.Location = new System.Drawing.Point(113, 82);
            this.btnTelaInicialCadastroCliente.Name = "btnTelaInicialCadastroCliente";
            this.btnTelaInicialCadastroCliente.Size = new System.Drawing.Size(181, 79);
            this.btnTelaInicialCadastroCliente.TabIndex = 0;
            this.btnTelaInicialCadastroCliente.Text = "Cadastrar Cliente";
            this.btnTelaInicialCadastroCliente.UseVisualStyleBackColor = false;
            this.btnTelaInicialCadastroCliente.Click += new System.EventHandler(this.CadastroCliente_Click);
            // 
            // btnTelaInicialCadastroProduto
            // 
            this.btnTelaInicialCadastroProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelaInicialCadastroProduto.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaInicialCadastroProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelaInicialCadastroProduto.Location = new System.Drawing.Point(461, 82);
            this.btnTelaInicialCadastroProduto.Name = "btnTelaInicialCadastroProduto";
            this.btnTelaInicialCadastroProduto.Size = new System.Drawing.Size(181, 79);
            this.btnTelaInicialCadastroProduto.TabIndex = 2;
            this.btnTelaInicialCadastroProduto.Text = "Cadastrar Produto";
            this.btnTelaInicialCadastroProduto.UseVisualStyleBackColor = false;
            this.btnTelaInicialCadastroProduto.Click += new System.EventHandler(this.btnTelaInicialCadastroProduto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTelaInicialCadastroProduto);
            this.Controls.Add(this.btnTelaInicialPesquisarCliente);
            this.Controls.Add(this.btnTelaInicialCadastroCliente);
            this.Name = "Tela_Inicial";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTelaInicialPesquisarCliente;
        private System.Windows.Forms.Button btnTelaInicialCadastroCliente;
        private System.Windows.Forms.Button btnTelaInicialCadastroProduto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

