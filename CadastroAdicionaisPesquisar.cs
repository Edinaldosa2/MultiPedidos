using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultPedidos
{
    public partial class CadastroAdicionaisPesquisar : Form
    {
        private DataGridView dataGridViewCadastroAdicionaisPesquisar;
        private Button buttonFiltrarPesquisarAdicionais;
        private TextBox txtrecoAdicionaisPesquisar;
        private TextBox txtAdicionaisPesquisar;
        private TextBox txtIDAdicionaisPesquisar;
        private Label lblPrecoAdicionaisPesquisar;
        private Label lblAdicionaisPesquisar;
        private Label lblTelaCadastroAdicionaisPesquisar;
        private Label lblCustoAdicionaisPesquisar;
        private TextBox txtCustoAdicionaisPesquisar;
        private Label lblIDAdicionaisPesquisar;

        public CadastroAdicionaisPesquisar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridViewCadastroAdicionaisPesquisar = new System.Windows.Forms.DataGridView();
            this.buttonFiltrarPesquisarAdicionais = new System.Windows.Forms.Button();
            this.txtrecoAdicionaisPesquisar = new System.Windows.Forms.TextBox();
            this.txtAdicionaisPesquisar = new System.Windows.Forms.TextBox();
            this.txtIDAdicionaisPesquisar = new System.Windows.Forms.TextBox();
            this.lblPrecoAdicionaisPesquisar = new System.Windows.Forms.Label();
            this.lblAdicionaisPesquisar = new System.Windows.Forms.Label();
            this.lblTelaCadastroAdicionaisPesquisar = new System.Windows.Forms.Label();
            this.lblIDAdicionaisPesquisar = new System.Windows.Forms.Label();
            this.lblCustoAdicionaisPesquisar = new System.Windows.Forms.Label();
            this.txtCustoAdicionaisPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadastroAdicionaisPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCadastroAdicionaisPesquisar
            // 
            this.dataGridViewCadastroAdicionaisPesquisar.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewCadastroAdicionaisPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCadastroAdicionaisPesquisar.Location = new System.Drawing.Point(21, 267);
            this.dataGridViewCadastroAdicionaisPesquisar.Name = "dataGridViewCadastroAdicionaisPesquisar";
            this.dataGridViewCadastroAdicionaisPesquisar.RowHeadersWidth = 51;
            this.dataGridViewCadastroAdicionaisPesquisar.RowTemplate.Height = 24;
            this.dataGridViewCadastroAdicionaisPesquisar.Size = new System.Drawing.Size(989, 211);
            this.dataGridViewCadastroAdicionaisPesquisar.TabIndex = 29;
            // 
            // buttonFiltrarPesquisarAdicionais
            // 
            this.buttonFiltrarPesquisarAdicionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFiltrarPesquisarAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrarPesquisarAdicionais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFiltrarPesquisarAdicionais.Location = new System.Drawing.Point(847, 200);
            this.buttonFiltrarPesquisarAdicionais.Name = "buttonFiltrarPesquisarAdicionais";
            this.buttonFiltrarPesquisarAdicionais.Size = new System.Drawing.Size(163, 61);
            this.buttonFiltrarPesquisarAdicionais.TabIndex = 28;
            this.buttonFiltrarPesquisarAdicionais.Text = "Filtrar";
            this.buttonFiltrarPesquisarAdicionais.UseVisualStyleBackColor = false;
            // 
            // txtrecoAdicionaisPesquisar
            // 
            this.txtrecoAdicionaisPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtrecoAdicionaisPesquisar.Location = new System.Drawing.Point(838, 172);
            this.txtrecoAdicionaisPesquisar.Name = "txtrecoAdicionaisPesquisar";
            this.txtrecoAdicionaisPesquisar.Size = new System.Drawing.Size(172, 22);
            this.txtrecoAdicionaisPesquisar.TabIndex = 27;
            // 
            // txtAdicionaisPesquisar
            // 
            this.txtAdicionaisPesquisar.Location = new System.Drawing.Point(169, 172);
            this.txtAdicionaisPesquisar.Name = "txtAdicionaisPesquisar";
            this.txtAdicionaisPesquisar.Size = new System.Drawing.Size(448, 22);
            this.txtAdicionaisPesquisar.TabIndex = 23;
            // 
            // txtIDAdicionaisPesquisar
            // 
            this.txtIDAdicionaisPesquisar.Location = new System.Drawing.Point(21, 172);
            this.txtIDAdicionaisPesquisar.Name = "txtIDAdicionaisPesquisar";
            this.txtIDAdicionaisPesquisar.Size = new System.Drawing.Size(119, 22);
            this.txtIDAdicionaisPesquisar.TabIndex = 22;
            // 
            // lblPrecoAdicionaisPesquisar
            // 
            this.lblPrecoAdicionaisPesquisar.AutoSize = true;
            this.lblPrecoAdicionaisPesquisar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoAdicionaisPesquisar.Location = new System.Drawing.Point(884, 130);
            this.lblPrecoAdicionaisPesquisar.Name = "lblPrecoAdicionaisPesquisar";
            this.lblPrecoAdicionaisPesquisar.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoAdicionaisPesquisar.TabIndex = 21;
            this.lblPrecoAdicionaisPesquisar.Text = "Preço ($)";
            // 
            // lblAdicionaisPesquisar
            // 
            this.lblAdicionaisPesquisar.AutoSize = true;
            this.lblAdicionaisPesquisar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionaisPesquisar.Location = new System.Drawing.Point(350, 130);
            this.lblAdicionaisPesquisar.Name = "lblAdicionaisPesquisar";
            this.lblAdicionaisPesquisar.Size = new System.Drawing.Size(60, 24);
            this.lblAdicionaisPesquisar.TabIndex = 17;
            this.lblAdicionaisPesquisar.Text = "Nome";
            // 
            // lblTelaCadastroAdicionaisPesquisar
            // 
            this.lblTelaCadastroAdicionaisPesquisar.AutoSize = true;
            this.lblTelaCadastroAdicionaisPesquisar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaCadastroAdicionaisPesquisar.Location = new System.Drawing.Point(419, 19);
            this.lblTelaCadastroAdicionaisPesquisar.Name = "lblTelaCadastroAdicionaisPesquisar";
            this.lblTelaCadastroAdicionaisPesquisar.Size = new System.Drawing.Size(232, 31);
            this.lblTelaCadastroAdicionaisPesquisar.TabIndex = 16;
            this.lblTelaCadastroAdicionaisPesquisar.Text = "Pesquisar Adicionais";
            // 
            // lblIDAdicionaisPesquisar
            // 
            this.lblIDAdicionaisPesquisar.AutoSize = true;
            this.lblIDAdicionaisPesquisar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAdicionaisPesquisar.Location = new System.Drawing.Point(22, 130);
            this.lblIDAdicionaisPesquisar.Name = "lblIDAdicionaisPesquisar";
            this.lblIDAdicionaisPesquisar.Size = new System.Drawing.Size(118, 24);
            this.lblIDAdicionaisPesquisar.TabIndex = 15;
            this.lblIDAdicionaisPesquisar.Text = "ID Adicional";
            // 
            // lblCustoAdicionaisPesquisar
            // 
            this.lblCustoAdicionaisPesquisar.AutoSize = true;
            this.lblCustoAdicionaisPesquisar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoAdicionaisPesquisar.Location = new System.Drawing.Point(687, 130);
            this.lblCustoAdicionaisPesquisar.Name = "lblCustoAdicionaisPesquisar";
            this.lblCustoAdicionaisPesquisar.Size = new System.Drawing.Size(86, 24);
            this.lblCustoAdicionaisPesquisar.TabIndex = 20;
            this.lblCustoAdicionaisPesquisar.Text = "Custo ($)";
            // 
            // txtCustoAdicionaisPesquisar
            // 
            this.txtCustoAdicionaisPesquisar.Location = new System.Drawing.Point(654, 172);
            this.txtCustoAdicionaisPesquisar.Name = "txtCustoAdicionaisPesquisar";
            this.txtCustoAdicionaisPesquisar.Size = new System.Drawing.Size(159, 22);
            this.txtCustoAdicionaisPesquisar.TabIndex = 26;
            // 
            // CadastroAdicionaisPesquisar
            // 
            this.ClientSize = new System.Drawing.Size(1030, 503);
            this.Controls.Add(this.dataGridViewCadastroAdicionaisPesquisar);
            this.Controls.Add(this.buttonFiltrarPesquisarAdicionais);
            this.Controls.Add(this.txtrecoAdicionaisPesquisar);
            this.Controls.Add(this.txtCustoAdicionaisPesquisar);
            this.Controls.Add(this.txtAdicionaisPesquisar);
            this.Controls.Add(this.txtIDAdicionaisPesquisar);
            this.Controls.Add(this.lblPrecoAdicionaisPesquisar);
            this.Controls.Add(this.lblCustoAdicionaisPesquisar);
            this.Controls.Add(this.lblAdicionaisPesquisar);
            this.Controls.Add(this.lblTelaCadastroAdicionaisPesquisar);
            this.Controls.Add(this.lblIDAdicionaisPesquisar);
            this.Name = "CadastroAdicionaisPesquisar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadastroAdicionaisPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
