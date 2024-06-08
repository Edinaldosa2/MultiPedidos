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
    public partial class CadastroProdutos : Form
    {
        private Button btnTelaCadastroProdutosAdicionais;
        private Button btnTelaCadastroProdutosPorcoes;
        private Button btnTelaCadastroProdutosBebidas;
        private Button btnTelaCadastroProdutosCombos;
        private Button btnTelaCadastroProdutosIngredientes;
        private Button btnTelaCadastroProdutosLanches;

        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnTelaCadastroProdutosLanches = new System.Windows.Forms.Button();
            this.btnTelaCadastroProdutosAdicionais = new System.Windows.Forms.Button();
            this.btnTelaCadastroProdutosPorcoes = new System.Windows.Forms.Button();
            this.btnTelaCadastroProdutosBebidas = new System.Windows.Forms.Button();
            this.btnTelaCadastroProdutosCombos = new System.Windows.Forms.Button();
            this.btnTelaCadastroProdutosIngredientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTelaCadastroProdutosLanches
            // 
            this.btnTelaCadastroProdutosLanches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelaCadastroProdutosLanches.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastroProdutosLanches.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelaCadastroProdutosLanches.Location = new System.Drawing.Point(128, 83);
            this.btnTelaCadastroProdutosLanches.Name = "btnTelaCadastroProdutosLanches";
            this.btnTelaCadastroProdutosLanches.Size = new System.Drawing.Size(181, 79);
            this.btnTelaCadastroProdutosLanches.TabIndex = 1;
            this.btnTelaCadastroProdutosLanches.Text = "Cadastrar Lanches";
            this.btnTelaCadastroProdutosLanches.UseVisualStyleBackColor = false;
            this.btnTelaCadastroProdutosLanches.Click += new System.EventHandler(this.btnTelaCadastroProdutosLanches_Click);
            // 
            // btnTelaCadastroProdutosAdicionais
            // 
            this.btnTelaCadastroProdutosAdicionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelaCadastroProdutosAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastroProdutosAdicionais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelaCadastroProdutosAdicionais.Location = new System.Drawing.Point(699, 83);
            this.btnTelaCadastroProdutosAdicionais.Name = "btnTelaCadastroProdutosAdicionais";
            this.btnTelaCadastroProdutosAdicionais.Size = new System.Drawing.Size(181, 79);
            this.btnTelaCadastroProdutosAdicionais.TabIndex = 2;
            this.btnTelaCadastroProdutosAdicionais.Text = "Cadastrar Adicionais";
            this.btnTelaCadastroProdutosAdicionais.UseVisualStyleBackColor = false;
            this.btnTelaCadastroProdutosAdicionais.Click += new System.EventHandler(this.btnTelaCadastroProdutosAdicionais_Click);
            // 
            // btnTelaCadastroProdutosPorcoes
            // 
            this.btnTelaCadastroProdutosPorcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelaCadastroProdutosPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastroProdutosPorcoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelaCadastroProdutosPorcoes.Location = new System.Drawing.Point(128, 230);
            this.btnTelaCadastroProdutosPorcoes.Name = "btnTelaCadastroProdutosPorcoes";
            this.btnTelaCadastroProdutosPorcoes.Size = new System.Drawing.Size(181, 79);
            this.btnTelaCadastroProdutosPorcoes.TabIndex = 3;
            this.btnTelaCadastroProdutosPorcoes.Text = "Cadastrar Porções";
            this.btnTelaCadastroProdutosPorcoes.UseVisualStyleBackColor = false;
            this.btnTelaCadastroProdutosPorcoes.Click += new System.EventHandler(this.btnTelaCadastroProdutosPorcoes_Click);
            // 
            // btnTelaCadastroProdutosBebidas
            // 
            this.btnTelaCadastroProdutosBebidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelaCadastroProdutosBebidas.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastroProdutosBebidas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelaCadastroProdutosBebidas.Location = new System.Drawing.Point(416, 230);
            this.btnTelaCadastroProdutosBebidas.Name = "btnTelaCadastroProdutosBebidas";
            this.btnTelaCadastroProdutosBebidas.Size = new System.Drawing.Size(181, 79);
            this.btnTelaCadastroProdutosBebidas.TabIndex = 4;
            this.btnTelaCadastroProdutosBebidas.Text = "Cadastrar Bebidas";
            this.btnTelaCadastroProdutosBebidas.UseVisualStyleBackColor = false;
            this.btnTelaCadastroProdutosBebidas.Click += new System.EventHandler(this.btnTelaCadastroProdutosBebidas_Click);
            // 
            // btnTelaCadastroProdutosCombos
            // 
            this.btnTelaCadastroProdutosCombos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelaCadastroProdutosCombos.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastroProdutosCombos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelaCadastroProdutosCombos.Location = new System.Drawing.Point(699, 230);
            this.btnTelaCadastroProdutosCombos.Name = "btnTelaCadastroProdutosCombos";
            this.btnTelaCadastroProdutosCombos.Size = new System.Drawing.Size(181, 79);
            this.btnTelaCadastroProdutosCombos.TabIndex = 5;
            this.btnTelaCadastroProdutosCombos.Text = "Cadastrar Combos";
            this.btnTelaCadastroProdutosCombos.UseVisualStyleBackColor = false;
            this.btnTelaCadastroProdutosCombos.Click += new System.EventHandler(this.btnTelaCadastroProdutosCombos_Click);
            // 
            // btnTelaCadastroProdutosIngredientes
            // 
            this.btnTelaCadastroProdutosIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTelaCadastroProdutosIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastroProdutosIngredientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelaCadastroProdutosIngredientes.Location = new System.Drawing.Point(416, 83);
            this.btnTelaCadastroProdutosIngredientes.Name = "btnTelaCadastroProdutosIngredientes";
            this.btnTelaCadastroProdutosIngredientes.Size = new System.Drawing.Size(181, 79);
            this.btnTelaCadastroProdutosIngredientes.TabIndex = 6;
            this.btnTelaCadastroProdutosIngredientes.Text = "Cadastrar Ingredientes";
            this.btnTelaCadastroProdutosIngredientes.UseVisualStyleBackColor = false;
            this.btnTelaCadastroProdutosIngredientes.Click += new System.EventHandler(this.btnTelaCadastroProdutosIngredientes_Click);
            // 
            // CadastroProdutos
            // 
            this.ClientSize = new System.Drawing.Size(1010, 559);
            this.Controls.Add(this.btnTelaCadastroProdutosIngredientes);
            this.Controls.Add(this.btnTelaCadastroProdutosCombos);
            this.Controls.Add(this.btnTelaCadastroProdutosBebidas);
            this.Controls.Add(this.btnTelaCadastroProdutosPorcoes);
            this.Controls.Add(this.btnTelaCadastroProdutosAdicionais);
            this.Controls.Add(this.btnTelaCadastroProdutosLanches);
            this.Name = "CadastroProdutos";
            this.ResumeLayout(false);

        }

        private void btnTelaCadastroProdutosLanches_Click(object sender, EventArgs e)
        {
            CadastroLanches cad = new CadastroLanches();
            cad.Show();
        }

        private void btnTelaCadastroProdutosAdicionais_Click(object sender, EventArgs e)
        {
            CadastroAdicionais cad2 = new CadastroAdicionais();
            cad2.Show();
        }

        private void btnTelaCadastroProdutosPorcoes_Click(object sender, EventArgs e)
        {
            CadastroPorcoes cad3 = new CadastroPorcoes();
            cad3.Show();
        }

        private void btnTelaCadastroProdutosBebidas_Click(object sender, EventArgs e)
        {
            CadastroBebidas cad4 = new CadastroBebidas();
            cad4.Show();
        }

        private void btnTelaCadastroProdutosCombos_Click(object sender, EventArgs e)
        {
            CadastroCombos cad5 = new CadastroCombos();
            cad5.Show();
        }

        private void btnTelaCadastroProdutosIngredientes_Click(object sender, EventArgs e)
        {
            CadastroIngredientes cad6 = new CadastroIngredientes();
            cad6.Show();
        }
    }
}
