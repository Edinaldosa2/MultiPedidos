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
    public partial class CadastroPorcoes : Form
    {
        private TextBox txtNome9CadastroPorcoes;
        private TextBox txtPreco9CadastroPorcoes;
        private TextBox txtCusto9CadastroPorcoes;
        private TextBox txtPreco8CadastroPorcoes;
        private TextBox txtCusto8CadastroPorcoes;
        private TextBox txtPreco7CadastroPorcoes;
        private TextBox txtCusto7CadastroPorcoes;
        private TextBox txtPreco10CadastroPorcoes;
        private TextBox txtCusto10CadastroPorcoes;
        private TextBox txtNome10CadastroPorcoes;
        private TextBox txtPreco4CadastroPorcoes;
        private TextBox txtCusto4CadastroPorcoes;
        private TextBox txtPreco3CadastroPorcoes;
        private TextBox txtCusto3CadastroPorcoes;
        private TextBox txtPreco2CadastroPorcoes;
        private TextBox txtCusto2CadastroPorcoes;
        private TextBox txtPreco5CadastroPorcoes;
        private TextBox txtCusto5CadastroPorcoes;
        private TextBox txtNome5CadastroPorcoes;
        private TextBox txtPreco6CadastroPorcoes;
        private TextBox txtCusto6CadastroPorcoes;
        private Label lblNome2CadastroPorcoes;
        private Label lblPreco2CadastroPorcoes;
        private Label lblCusto2CadastroPorcoes;
        private Label lblImagem2CadastroPorcoes;
        private Label lblNome1CadastroPorcoes;
        private Label lblPreco1CadastroPorcoes;
        private TextBox txtPreco1CadastroPorcoes;
        private Label lblCusto1CadastroPorcoes;
        private TextBox txtCusto1CadastroPorcoes;
        private Label lblImagem1CadastroPorcoes;
        private TextBox txtNome8CadastroPorcoes;
        private TextBox txtNome4CadastroPorcoes;
        private TextBox txtNome7CadastroPorcoes;
        private TextBox txtNome3CadastroPorcoes;
        private TextBox txtNome6CadastroPorcoes;
        private TextBox txtNome2CadastroPorcoes;
        private Button btnSalvarCadastroPorcoes;
        private TextBox txtNome1CadastroPorcoes;
        private OpenFileDialog openFileCadastroPorcao1;
        private OpenFileDialog openFileCadastroPorcao2;
        private OpenFileDialog openFileCadastroPorcao3;
        private OpenFileDialog openFileCadastroPorcao4;
        private OpenFileDialog openFileCadastroPorcao5;
        private OpenFileDialog openFileCadastroPorcao6;
        private OpenFileDialog openFileCadastroPorcao7;
        private OpenFileDialog openFileCadastroPorcao8;
        private OpenFileDialog openFileCadastroPorcao9;
        private OpenFileDialog openFileCadastroPorcao10;
        private Button btnUploadImagem1CadastroPorcao;
        private Button btnUploadImagem2CadastroPorcao;
        private Button btnUploadImagem4CadastroPorcao;
        private Button btnUploadImagem3CadastroPorcao;
        private Button btnUploadImagem5CadastroPorcao;
        private Button btnUploadImagem10CadastroPorcao;
        private Button btnUploadImagem9CadastroPorcao;
        private Button btnUploadImagem8CadastroPorcao;
        private Button btnUploadImagem7CadastroPorcao;
        private Button btnUploadImagem6CadastroPorcao;
        private Label lblTituloCadastroPorcoes;

        public CadastroPorcoes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtNome9CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtPreco9CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtCusto9CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtPreco8CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtCusto8CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtPreco7CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtCusto7CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtPreco10CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtCusto10CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtNome10CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtPreco4CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtCusto4CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtPreco3CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtCusto3CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtPreco2CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtCusto2CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtPreco5CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtCusto5CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtNome5CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtPreco6CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtCusto6CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.lblNome2CadastroPorcoes = new System.Windows.Forms.Label();
            this.lblPreco2CadastroPorcoes = new System.Windows.Forms.Label();
            this.lblCusto2CadastroPorcoes = new System.Windows.Forms.Label();
            this.lblImagem2CadastroPorcoes = new System.Windows.Forms.Label();
            this.lblNome1CadastroPorcoes = new System.Windows.Forms.Label();
            this.lblPreco1CadastroPorcoes = new System.Windows.Forms.Label();
            this.txtPreco1CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.lblCusto1CadastroPorcoes = new System.Windows.Forms.Label();
            this.txtCusto1CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.lblImagem1CadastroPorcoes = new System.Windows.Forms.Label();
            this.txtNome8CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtNome4CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtNome7CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtNome3CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtNome6CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.txtNome2CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroPorcoes = new System.Windows.Forms.Button();
            this.txtNome1CadastroPorcoes = new System.Windows.Forms.TextBox();
            this.lblTituloCadastroPorcoes = new System.Windows.Forms.Label();
            this.openFileCadastroPorcao1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroPorcao2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroPorcao3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroPorcao4 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroPorcao5 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroPorcao6 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroPorcao7 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroPorcao8 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroPorcao9 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroPorcao10 = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadImagem1CadastroPorcao = new System.Windows.Forms.Button();
            this.btnUploadImagem2CadastroPorcao = new System.Windows.Forms.Button();
            this.btnUploadImagem4CadastroPorcao = new System.Windows.Forms.Button();
            this.btnUploadImagem3CadastroPorcao = new System.Windows.Forms.Button();
            this.btnUploadImagem5CadastroPorcao = new System.Windows.Forms.Button();
            this.btnUploadImagem10CadastroPorcao = new System.Windows.Forms.Button();
            this.btnUploadImagem9CadastroPorcao = new System.Windows.Forms.Button();
            this.btnUploadImagem8CadastroPorcao = new System.Windows.Forms.Button();
            this.btnUploadImagem7CadastroPorcao = new System.Windows.Forms.Button();
            this.btnUploadImagem6CadastroPorcao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome9CadastroPorcoes
            // 
            this.txtNome9CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome9CadastroPorcoes.Location = new System.Drawing.Point(643, 363);
            this.txtNome9CadastroPorcoes.Name = "txtNome9CadastroPorcoes";
            this.txtNome9CadastroPorcoes.Size = new System.Drawing.Size(168, 30);
            this.txtNome9CadastroPorcoes.TabIndex = 331;
            // 
            // txtPreco9CadastroPorcoes
            // 
            this.txtPreco9CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco9CadastroPorcoes.Location = new System.Drawing.Point(1085, 366);
            this.txtPreco9CadastroPorcoes.Name = "txtPreco9CadastroPorcoes";
            this.txtPreco9CadastroPorcoes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco9CadastroPorcoes.TabIndex = 330;
            // 
            // txtCusto9CadastroPorcoes
            // 
            this.txtCusto9CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto9CadastroPorcoes.Location = new System.Drawing.Point(975, 366);
            this.txtCusto9CadastroPorcoes.Name = "txtCusto9CadastroPorcoes";
            this.txtCusto9CadastroPorcoes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto9CadastroPorcoes.TabIndex = 329;
            // 
            // txtPreco8CadastroPorcoes
            // 
            this.txtPreco8CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco8CadastroPorcoes.Location = new System.Drawing.Point(1085, 283);
            this.txtPreco8CadastroPorcoes.Name = "txtPreco8CadastroPorcoes";
            this.txtPreco8CadastroPorcoes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco8CadastroPorcoes.TabIndex = 328;
            // 
            // txtCusto8CadastroPorcoes
            // 
            this.txtCusto8CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto8CadastroPorcoes.Location = new System.Drawing.Point(975, 283);
            this.txtCusto8CadastroPorcoes.Name = "txtCusto8CadastroPorcoes";
            this.txtCusto8CadastroPorcoes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto8CadastroPorcoes.TabIndex = 327;
            // 
            // txtPreco7CadastroPorcoes
            // 
            this.txtPreco7CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco7CadastroPorcoes.Location = new System.Drawing.Point(1085, 199);
            this.txtPreco7CadastroPorcoes.Name = "txtPreco7CadastroPorcoes";
            this.txtPreco7CadastroPorcoes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco7CadastroPorcoes.TabIndex = 326;
            // 
            // txtCusto7CadastroPorcoes
            // 
            this.txtCusto7CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto7CadastroPorcoes.Location = new System.Drawing.Point(975, 199);
            this.txtCusto7CadastroPorcoes.Name = "txtCusto7CadastroPorcoes";
            this.txtCusto7CadastroPorcoes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto7CadastroPorcoes.TabIndex = 325;
            // 
            // txtPreco10CadastroPorcoes
            // 
            this.txtPreco10CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco10CadastroPorcoes.Location = new System.Drawing.Point(1087, 448);
            this.txtPreco10CadastroPorcoes.Name = "txtPreco10CadastroPorcoes";
            this.txtPreco10CadastroPorcoes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco10CadastroPorcoes.TabIndex = 324;
            // 
            // txtCusto10CadastroPorcoes
            // 
            this.txtCusto10CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto10CadastroPorcoes.Location = new System.Drawing.Point(977, 448);
            this.txtCusto10CadastroPorcoes.Name = "txtCusto10CadastroPorcoes";
            this.txtCusto10CadastroPorcoes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto10CadastroPorcoes.TabIndex = 323;
            // 
            // txtNome10CadastroPorcoes
            // 
            this.txtNome10CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome10CadastroPorcoes.Location = new System.Drawing.Point(643, 448);
            this.txtNome10CadastroPorcoes.Name = "txtNome10CadastroPorcoes";
            this.txtNome10CadastroPorcoes.Size = new System.Drawing.Size(168, 30);
            this.txtNome10CadastroPorcoes.TabIndex = 320;
            // 
            // txtPreco4CadastroPorcoes
            // 
            this.txtPreco4CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco4CadastroPorcoes.Location = new System.Drawing.Point(480, 366);
            this.txtPreco4CadastroPorcoes.Name = "txtPreco4CadastroPorcoes";
            this.txtPreco4CadastroPorcoes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco4CadastroPorcoes.TabIndex = 319;
            // 
            // txtCusto4CadastroPorcoes
            // 
            this.txtCusto4CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto4CadastroPorcoes.Location = new System.Drawing.Point(370, 366);
            this.txtCusto4CadastroPorcoes.Name = "txtCusto4CadastroPorcoes";
            this.txtCusto4CadastroPorcoes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto4CadastroPorcoes.TabIndex = 318;
            // 
            // txtPreco3CadastroPorcoes
            // 
            this.txtPreco3CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco3CadastroPorcoes.Location = new System.Drawing.Point(480, 283);
            this.txtPreco3CadastroPorcoes.Name = "txtPreco3CadastroPorcoes";
            this.txtPreco3CadastroPorcoes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco3CadastroPorcoes.TabIndex = 317;
            // 
            // txtCusto3CadastroPorcoes
            // 
            this.txtCusto3CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto3CadastroPorcoes.Location = new System.Drawing.Point(370, 283);
            this.txtCusto3CadastroPorcoes.Name = "txtCusto3CadastroPorcoes";
            this.txtCusto3CadastroPorcoes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto3CadastroPorcoes.TabIndex = 316;
            // 
            // txtPreco2CadastroPorcoes
            // 
            this.txtPreco2CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco2CadastroPorcoes.Location = new System.Drawing.Point(480, 199);
            this.txtPreco2CadastroPorcoes.Name = "txtPreco2CadastroPorcoes";
            this.txtPreco2CadastroPorcoes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco2CadastroPorcoes.TabIndex = 315;
            // 
            // txtCusto2CadastroPorcoes
            // 
            this.txtCusto2CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto2CadastroPorcoes.Location = new System.Drawing.Point(370, 199);
            this.txtCusto2CadastroPorcoes.Name = "txtCusto2CadastroPorcoes";
            this.txtCusto2CadastroPorcoes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto2CadastroPorcoes.TabIndex = 314;
            // 
            // txtPreco5CadastroPorcoes
            // 
            this.txtPreco5CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco5CadastroPorcoes.Location = new System.Drawing.Point(480, 448);
            this.txtPreco5CadastroPorcoes.Name = "txtPreco5CadastroPorcoes";
            this.txtPreco5CadastroPorcoes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco5CadastroPorcoes.TabIndex = 313;
            // 
            // txtCusto5CadastroPorcoes
            // 
            this.txtCusto5CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto5CadastroPorcoes.Location = new System.Drawing.Point(370, 448);
            this.txtCusto5CadastroPorcoes.Name = "txtCusto5CadastroPorcoes";
            this.txtCusto5CadastroPorcoes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto5CadastroPorcoes.TabIndex = 312;
            // 
            // txtNome5CadastroPorcoes
            // 
            this.txtNome5CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome5CadastroPorcoes.Location = new System.Drawing.Point(36, 448);
            this.txtNome5CadastroPorcoes.Name = "txtNome5CadastroPorcoes";
            this.txtNome5CadastroPorcoes.Size = new System.Drawing.Size(168, 30);
            this.txtNome5CadastroPorcoes.TabIndex = 309;
            // 
            // txtPreco6CadastroPorcoes
            // 
            this.txtPreco6CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco6CadastroPorcoes.Location = new System.Drawing.Point(1087, 116);
            this.txtPreco6CadastroPorcoes.Name = "txtPreco6CadastroPorcoes";
            this.txtPreco6CadastroPorcoes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco6CadastroPorcoes.TabIndex = 305;
            // 
            // txtCusto6CadastroPorcoes
            // 
            this.txtCusto6CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto6CadastroPorcoes.Location = new System.Drawing.Point(977, 116);
            this.txtCusto6CadastroPorcoes.Name = "txtCusto6CadastroPorcoes";
            this.txtCusto6CadastroPorcoes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto6CadastroPorcoes.TabIndex = 304;
            // 
            // lblNome2CadastroPorcoes
            // 
            this.lblNome2CadastroPorcoes.AutoSize = true;
            this.lblNome2CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2CadastroPorcoes.Location = new System.Drawing.Point(694, 76);
            this.lblNome2CadastroPorcoes.Name = "lblNome2CadastroPorcoes";
            this.lblNome2CadastroPorcoes.Size = new System.Drawing.Size(60, 24);
            this.lblNome2CadastroPorcoes.TabIndex = 302;
            this.lblNome2CadastroPorcoes.Text = "Nome";
            // 
            // lblPreco2CadastroPorcoes
            // 
            this.lblPreco2CadastroPorcoes.AutoSize = true;
            this.lblPreco2CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco2CadastroPorcoes.Location = new System.Drawing.Point(1081, 76);
            this.lblPreco2CadastroPorcoes.Name = "lblPreco2CadastroPorcoes";
            this.lblPreco2CadastroPorcoes.Size = new System.Drawing.Size(82, 24);
            this.lblPreco2CadastroPorcoes.TabIndex = 301;
            this.lblPreco2CadastroPorcoes.Text = "Preço ($)";
            // 
            // lblCusto2CadastroPorcoes
            // 
            this.lblCusto2CadastroPorcoes.AutoSize = true;
            this.lblCusto2CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto2CadastroPorcoes.Location = new System.Drawing.Point(971, 76);
            this.lblCusto2CadastroPorcoes.Name = "lblCusto2CadastroPorcoes";
            this.lblCusto2CadastroPorcoes.Size = new System.Drawing.Size(86, 24);
            this.lblCusto2CadastroPorcoes.TabIndex = 300;
            this.lblCusto2CadastroPorcoes.Text = "Custo ($)";
            // 
            // lblImagem2CadastroPorcoes
            // 
            this.lblImagem2CadastroPorcoes.AutoSize = true;
            this.lblImagem2CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem2CadastroPorcoes.Location = new System.Drawing.Point(850, 76);
            this.lblImagem2CadastroPorcoes.Name = "lblImagem2CadastroPorcoes";
            this.lblImagem2CadastroPorcoes.Size = new System.Drawing.Size(77, 24);
            this.lblImagem2CadastroPorcoes.TabIndex = 299;
            this.lblImagem2CadastroPorcoes.Text = "Imagem";
            // 
            // lblNome1CadastroPorcoes
            // 
            this.lblNome1CadastroPorcoes.AutoSize = true;
            this.lblNome1CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1CadastroPorcoes.Location = new System.Drawing.Point(95, 76);
            this.lblNome1CadastroPorcoes.Name = "lblNome1CadastroPorcoes";
            this.lblNome1CadastroPorcoes.Size = new System.Drawing.Size(60, 24);
            this.lblNome1CadastroPorcoes.TabIndex = 295;
            this.lblNome1CadastroPorcoes.Text = "Nome";
            // 
            // lblPreco1CadastroPorcoes
            // 
            this.lblPreco1CadastroPorcoes.AutoSize = true;
            this.lblPreco1CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco1CadastroPorcoes.Location = new System.Drawing.Point(476, 76);
            this.lblPreco1CadastroPorcoes.Name = "lblPreco1CadastroPorcoes";
            this.lblPreco1CadastroPorcoes.Size = new System.Drawing.Size(82, 24);
            this.lblPreco1CadastroPorcoes.TabIndex = 294;
            this.lblPreco1CadastroPorcoes.Text = "Preço ($)";
            // 
            // txtPreco1CadastroPorcoes
            // 
            this.txtPreco1CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco1CadastroPorcoes.Location = new System.Drawing.Point(480, 116);
            this.txtPreco1CadastroPorcoes.Name = "txtPreco1CadastroPorcoes";
            this.txtPreco1CadastroPorcoes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco1CadastroPorcoes.TabIndex = 293;
            // 
            // lblCusto1CadastroPorcoes
            // 
            this.lblCusto1CadastroPorcoes.AutoSize = true;
            this.lblCusto1CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto1CadastroPorcoes.Location = new System.Drawing.Point(366, 76);
            this.lblCusto1CadastroPorcoes.Name = "lblCusto1CadastroPorcoes";
            this.lblCusto1CadastroPorcoes.Size = new System.Drawing.Size(86, 24);
            this.lblCusto1CadastroPorcoes.TabIndex = 292;
            this.lblCusto1CadastroPorcoes.Text = "Custo ($)";
            // 
            // txtCusto1CadastroPorcoes
            // 
            this.txtCusto1CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto1CadastroPorcoes.Location = new System.Drawing.Point(370, 116);
            this.txtCusto1CadastroPorcoes.Name = "txtCusto1CadastroPorcoes";
            this.txtCusto1CadastroPorcoes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto1CadastroPorcoes.TabIndex = 291;
            // 
            // lblImagem1CadastroPorcoes
            // 
            this.lblImagem1CadastroPorcoes.AutoSize = true;
            this.lblImagem1CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem1CadastroPorcoes.Location = new System.Drawing.Point(245, 76);
            this.lblImagem1CadastroPorcoes.Name = "lblImagem1CadastroPorcoes";
            this.lblImagem1CadastroPorcoes.Size = new System.Drawing.Size(77, 24);
            this.lblImagem1CadastroPorcoes.TabIndex = 290;
            this.lblImagem1CadastroPorcoes.Text = "Imagem";
            // 
            // txtNome8CadastroPorcoes
            // 
            this.txtNome8CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome8CadastroPorcoes.Location = new System.Drawing.Point(643, 280);
            this.txtNome8CadastroPorcoes.Name = "txtNome8CadastroPorcoes";
            this.txtNome8CadastroPorcoes.Size = new System.Drawing.Size(168, 30);
            this.txtNome8CadastroPorcoes.TabIndex = 287;
            // 
            // txtNome4CadastroPorcoes
            // 
            this.txtNome4CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome4CadastroPorcoes.Location = new System.Drawing.Point(36, 365);
            this.txtNome4CadastroPorcoes.Name = "txtNome4CadastroPorcoes";
            this.txtNome4CadastroPorcoes.Size = new System.Drawing.Size(168, 30);
            this.txtNome4CadastroPorcoes.TabIndex = 285;
            // 
            // txtNome7CadastroPorcoes
            // 
            this.txtNome7CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome7CadastroPorcoes.Location = new System.Drawing.Point(643, 203);
            this.txtNome7CadastroPorcoes.Name = "txtNome7CadastroPorcoes";
            this.txtNome7CadastroPorcoes.Size = new System.Drawing.Size(168, 30);
            this.txtNome7CadastroPorcoes.TabIndex = 283;
            // 
            // txtNome3CadastroPorcoes
            // 
            this.txtNome3CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome3CadastroPorcoes.Location = new System.Drawing.Point(36, 283);
            this.txtNome3CadastroPorcoes.Name = "txtNome3CadastroPorcoes";
            this.txtNome3CadastroPorcoes.Size = new System.Drawing.Size(168, 30);
            this.txtNome3CadastroPorcoes.TabIndex = 281;
            // 
            // txtNome6CadastroPorcoes
            // 
            this.txtNome6CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome6CadastroPorcoes.Location = new System.Drawing.Point(643, 116);
            this.txtNome6CadastroPorcoes.Name = "txtNome6CadastroPorcoes";
            this.txtNome6CadastroPorcoes.Size = new System.Drawing.Size(168, 30);
            this.txtNome6CadastroPorcoes.TabIndex = 279;
            // 
            // txtNome2CadastroPorcoes
            // 
            this.txtNome2CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome2CadastroPorcoes.Location = new System.Drawing.Point(36, 199);
            this.txtNome2CadastroPorcoes.Name = "txtNome2CadastroPorcoes";
            this.txtNome2CadastroPorcoes.Size = new System.Drawing.Size(168, 30);
            this.txtNome2CadastroPorcoes.TabIndex = 277;
            // 
            // btnSalvarCadastroPorcoes
            // 
            this.btnSalvarCadastroPorcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarCadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroPorcoes.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSalvarCadastroPorcoes.Location = new System.Drawing.Point(975, 544);
            this.btnSalvarCadastroPorcoes.Name = "btnSalvarCadastroPorcoes";
            this.btnSalvarCadastroPorcoes.Size = new System.Drawing.Size(167, 55);
            this.btnSalvarCadastroPorcoes.TabIndex = 276;
            this.btnSalvarCadastroPorcoes.Text = "Salvar";
            this.btnSalvarCadastroPorcoes.UseVisualStyleBackColor = false;
            // 
            // txtNome1CadastroPorcoes
            // 
            this.txtNome1CadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome1CadastroPorcoes.Location = new System.Drawing.Point(36, 116);
            this.txtNome1CadastroPorcoes.Name = "txtNome1CadastroPorcoes";
            this.txtNome1CadastroPorcoes.Size = new System.Drawing.Size(168, 30);
            this.txtNome1CadastroPorcoes.TabIndex = 274;
            // 
            // lblTituloCadastroPorcoes
            // 
            this.lblTituloCadastroPorcoes.AutoSize = true;
            this.lblTituloCadastroPorcoes.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroPorcoes.Location = new System.Drawing.Point(486, 17);
            this.lblTituloCadastroPorcoes.Name = "lblTituloCadastroPorcoes";
            this.lblTituloCadastroPorcoes.Size = new System.Drawing.Size(228, 31);
            this.lblTituloCadastroPorcoes.TabIndex = 273;
            this.lblTituloCadastroPorcoes.Text = "Cadastro de Porções";
            // 
            // openFileCadastroPorcao1
            // 
            this.openFileCadastroPorcao1.FileName = "openFileCadastroPorcao1";
            // 
            // openFileCadastroPorcao2
            // 
            this.openFileCadastroPorcao2.FileName = "openFileCadastroPorcao2";
            // 
            // openFileCadastroPorcao3
            // 
            this.openFileCadastroPorcao3.FileName = "openFileCadastroPorcao3";
            // 
            // openFileCadastroPorcao4
            // 
            this.openFileCadastroPorcao4.FileName = "openFileCadastroPorcao4";
            // 
            // openFileCadastroPorcao5
            // 
            this.openFileCadastroPorcao5.FileName = "openFileCadastroPorcao5";
            // 
            // openFileCadastroPorcao6
            // 
            this.openFileCadastroPorcao6.FileName = "openFileCadastroPorcao6";
            // 
            // openFileCadastroPorcao7
            // 
            this.openFileCadastroPorcao7.FileName = "openFileCadastroPorcao7";
            // 
            // openFileCadastroPorcao8
            // 
            this.openFileCadastroPorcao8.FileName = "openFileCadastroPorcao8";
            // 
            // openFileCadastroPorcao9
            // 
            this.openFileCadastroPorcao9.FileName = "openFileCadastroPorcao9";
            // 
            // openFileCadastroPorcao10
            // 
            this.openFileCadastroPorcao10.FileName = "openFileCadastroPorcao10";
            // 
            // btnUploadImagem1CadastroPorcao
            // 
            this.btnUploadImagem1CadastroPorcao.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem1CadastroPorcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem1CadastroPorcao.Location = new System.Drawing.Point(225, 115);
            this.btnUploadImagem1CadastroPorcao.Name = "btnUploadImagem1CadastroPorcao";
            this.btnUploadImagem1CadastroPorcao.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem1CadastroPorcao.TabIndex = 333;
            this.btnUploadImagem1CadastroPorcao.Text = "Upload";
            this.btnUploadImagem1CadastroPorcao.UseVisualStyleBackColor = true;
            this.btnUploadImagem1CadastroPorcao.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao1_Click);
            // 
            // btnUploadImagem2CadastroPorcao
            // 
            this.btnUploadImagem2CadastroPorcao.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem2CadastroPorcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem2CadastroPorcao.Location = new System.Drawing.Point(225, 199);
            this.btnUploadImagem2CadastroPorcao.Name = "btnUploadImagem2CadastroPorcao";
            this.btnUploadImagem2CadastroPorcao.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem2CadastroPorcao.TabIndex = 334;
            this.btnUploadImagem2CadastroPorcao.Text = "Upload";
            this.btnUploadImagem2CadastroPorcao.UseVisualStyleBackColor = true;
            this.btnUploadImagem2CadastroPorcao.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao2_Click);
            // 
            // btnUploadImagem4CadastroPorcao
            // 
            this.btnUploadImagem4CadastroPorcao.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem4CadastroPorcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem4CadastroPorcao.Location = new System.Drawing.Point(225, 366);
            this.btnUploadImagem4CadastroPorcao.Name = "btnUploadImagem4CadastroPorcao";
            this.btnUploadImagem4CadastroPorcao.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem4CadastroPorcao.TabIndex = 336;
            this.btnUploadImagem4CadastroPorcao.Text = "Upload";
            this.btnUploadImagem4CadastroPorcao.UseVisualStyleBackColor = true;
            this.btnUploadImagem4CadastroPorcao.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao4_Click);
            // 
            // btnUploadImagem3CadastroPorcao
            // 
            this.btnUploadImagem3CadastroPorcao.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem3CadastroPorcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem3CadastroPorcao.Location = new System.Drawing.Point(225, 283);
            this.btnUploadImagem3CadastroPorcao.Name = "btnUploadImagem3CadastroPorcao";
            this.btnUploadImagem3CadastroPorcao.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem3CadastroPorcao.TabIndex = 335;
            this.btnUploadImagem3CadastroPorcao.Text = "Upload";
            this.btnUploadImagem3CadastroPorcao.UseVisualStyleBackColor = true;
            this.btnUploadImagem3CadastroPorcao.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao3_Click);
            // 
            // btnUploadImagem5CadastroPorcao
            // 
            this.btnUploadImagem5CadastroPorcao.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem5CadastroPorcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem5CadastroPorcao.Location = new System.Drawing.Point(225, 448);
            this.btnUploadImagem5CadastroPorcao.Name = "btnUploadImagem5CadastroPorcao";
            this.btnUploadImagem5CadastroPorcao.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem5CadastroPorcao.TabIndex = 337;
            this.btnUploadImagem5CadastroPorcao.Text = "Upload";
            this.btnUploadImagem5CadastroPorcao.UseVisualStyleBackColor = true;
            this.btnUploadImagem5CadastroPorcao.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao5_Click);
            // 
            // btnUploadImagem10CadastroPorcao
            // 
            this.btnUploadImagem10CadastroPorcao.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem10CadastroPorcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem10CadastroPorcao.Location = new System.Drawing.Point(832, 449);
            this.btnUploadImagem10CadastroPorcao.Name = "btnUploadImagem10CadastroPorcao";
            this.btnUploadImagem10CadastroPorcao.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem10CadastroPorcao.TabIndex = 342;
            this.btnUploadImagem10CadastroPorcao.Text = "Upload";
            this.btnUploadImagem10CadastroPorcao.UseVisualStyleBackColor = true;
            this.btnUploadImagem10CadastroPorcao.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao10_Click);
            // 
            // btnUploadImagem9CadastroPorcao
            // 
            this.btnUploadImagem9CadastroPorcao.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem9CadastroPorcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem9CadastroPorcao.Location = new System.Drawing.Point(832, 367);
            this.btnUploadImagem9CadastroPorcao.Name = "btnUploadImagem9CadastroPorcao";
            this.btnUploadImagem9CadastroPorcao.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem9CadastroPorcao.TabIndex = 341;
            this.btnUploadImagem9CadastroPorcao.Text = "Upload";
            this.btnUploadImagem9CadastroPorcao.UseVisualStyleBackColor = true;
            this.btnUploadImagem9CadastroPorcao.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao9_Click);
            // 
            // btnUploadImagem8CadastroPorcao
            // 
            this.btnUploadImagem8CadastroPorcao.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem8CadastroPorcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem8CadastroPorcao.Location = new System.Drawing.Point(832, 284);
            this.btnUploadImagem8CadastroPorcao.Name = "btnUploadImagem8CadastroPorcao";
            this.btnUploadImagem8CadastroPorcao.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem8CadastroPorcao.TabIndex = 340;
            this.btnUploadImagem8CadastroPorcao.Text = "Upload";
            this.btnUploadImagem8CadastroPorcao.UseVisualStyleBackColor = true;
            this.btnUploadImagem8CadastroPorcao.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao8_Click);
            // 
            // btnUploadImagem7CadastroPorcao
            // 
            this.btnUploadImagem7CadastroPorcao.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem7CadastroPorcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem7CadastroPorcao.Location = new System.Drawing.Point(832, 200);
            this.btnUploadImagem7CadastroPorcao.Name = "btnUploadImagem7CadastroPorcao";
            this.btnUploadImagem7CadastroPorcao.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem7CadastroPorcao.TabIndex = 339;
            this.btnUploadImagem7CadastroPorcao.Text = "Upload";
            this.btnUploadImagem7CadastroPorcao.UseVisualStyleBackColor = true;
            this.btnUploadImagem7CadastroPorcao.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao7_Click);
            // 
            // btnUploadImagem6CadastroPorcao
            // 
            this.btnUploadImagem6CadastroPorcao.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem6CadastroPorcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem6CadastroPorcao.Location = new System.Drawing.Point(832, 116);
            this.btnUploadImagem6CadastroPorcao.Name = "btnUploadImagem6CadastroPorcao";
            this.btnUploadImagem6CadastroPorcao.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem6CadastroPorcao.TabIndex = 338;
            this.btnUploadImagem6CadastroPorcao.Text = "Upload";
            this.btnUploadImagem6CadastroPorcao.UseVisualStyleBackColor = true;
            this.btnUploadImagem6CadastroPorcao.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao6_Click);
            // 
            // CadastroPorcoes
            // 
            this.ClientSize = new System.Drawing.Size(1177, 617);
            this.Controls.Add(this.btnUploadImagem10CadastroPorcao);
            this.Controls.Add(this.btnUploadImagem9CadastroPorcao);
            this.Controls.Add(this.btnUploadImagem8CadastroPorcao);
            this.Controls.Add(this.btnUploadImagem7CadastroPorcao);
            this.Controls.Add(this.btnUploadImagem6CadastroPorcao);
            this.Controls.Add(this.btnUploadImagem5CadastroPorcao);
            this.Controls.Add(this.btnUploadImagem4CadastroPorcao);
            this.Controls.Add(this.btnUploadImagem3CadastroPorcao);
            this.Controls.Add(this.btnUploadImagem2CadastroPorcao);
            this.Controls.Add(this.btnUploadImagem1CadastroPorcao);
            this.Controls.Add(this.txtNome9CadastroPorcoes);
            this.Controls.Add(this.txtPreco9CadastroPorcoes);
            this.Controls.Add(this.txtCusto9CadastroPorcoes);
            this.Controls.Add(this.txtPreco8CadastroPorcoes);
            this.Controls.Add(this.txtCusto8CadastroPorcoes);
            this.Controls.Add(this.txtPreco7CadastroPorcoes);
            this.Controls.Add(this.txtCusto7CadastroPorcoes);
            this.Controls.Add(this.txtPreco10CadastroPorcoes);
            this.Controls.Add(this.txtCusto10CadastroPorcoes);
            this.Controls.Add(this.txtNome10CadastroPorcoes);
            this.Controls.Add(this.txtPreco4CadastroPorcoes);
            this.Controls.Add(this.txtCusto4CadastroPorcoes);
            this.Controls.Add(this.txtPreco3CadastroPorcoes);
            this.Controls.Add(this.txtCusto3CadastroPorcoes);
            this.Controls.Add(this.txtPreco2CadastroPorcoes);
            this.Controls.Add(this.txtCusto2CadastroPorcoes);
            this.Controls.Add(this.txtPreco5CadastroPorcoes);
            this.Controls.Add(this.txtCusto5CadastroPorcoes);
            this.Controls.Add(this.txtNome5CadastroPorcoes);
            this.Controls.Add(this.txtPreco6CadastroPorcoes);
            this.Controls.Add(this.txtCusto6CadastroPorcoes);
            this.Controls.Add(this.lblNome2CadastroPorcoes);
            this.Controls.Add(this.lblPreco2CadastroPorcoes);
            this.Controls.Add(this.lblCusto2CadastroPorcoes);
            this.Controls.Add(this.lblImagem2CadastroPorcoes);
            this.Controls.Add(this.lblNome1CadastroPorcoes);
            this.Controls.Add(this.lblPreco1CadastroPorcoes);
            this.Controls.Add(this.txtPreco1CadastroPorcoes);
            this.Controls.Add(this.lblCusto1CadastroPorcoes);
            this.Controls.Add(this.txtCusto1CadastroPorcoes);
            this.Controls.Add(this.lblImagem1CadastroPorcoes);
            this.Controls.Add(this.txtNome8CadastroPorcoes);
            this.Controls.Add(this.txtNome4CadastroPorcoes);
            this.Controls.Add(this.txtNome7CadastroPorcoes);
            this.Controls.Add(this.txtNome3CadastroPorcoes);
            this.Controls.Add(this.txtNome6CadastroPorcoes);
            this.Controls.Add(this.txtNome2CadastroPorcoes);
            this.Controls.Add(this.btnSalvarCadastroPorcoes);
            this.Controls.Add(this.txtNome1CadastroPorcoes);
            this.Controls.Add(this.lblTituloCadastroPorcoes);
            this.Name = "CadastroPorcoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnUploadImagemCadastroPorcao1_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroPorcao1.InitialDirectory = "c:\\";
            openFileCadastroPorcao1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroPorcao1.FilterIndex = 1;
            openFileCadastroPorcao1.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroPorcao1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroPorcao1.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroPorcao2_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroPorcao2.InitialDirectory = "c:\\";
            openFileCadastroPorcao2.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroPorcao2.FilterIndex = 1;
            openFileCadastroPorcao2.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroPorcao2.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroPorcao2.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroPorcao3_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroPorcao3.InitialDirectory = "c:\\";
            openFileCadastroPorcao3.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroPorcao3.FilterIndex = 1;
            openFileCadastroPorcao3.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroPorcao3.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroPorcao3.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroPorcao4_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroPorcao4.InitialDirectory = "c:\\";
            openFileCadastroPorcao4.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroPorcao4.FilterIndex = 1;
            openFileCadastroPorcao4.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroPorcao4.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroPorcao4.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroPorcao5_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroPorcao5.InitialDirectory = "c:\\";
            openFileCadastroPorcao5.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroPorcao5.FilterIndex = 1;
            openFileCadastroPorcao5.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroPorcao5.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroPorcao5.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroPorcao6_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroPorcao6.InitialDirectory = "c:\\";
            openFileCadastroPorcao6.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroPorcao6.FilterIndex = 1;
            openFileCadastroPorcao6.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroPorcao6.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroPorcao6.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroPorcao7_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroPorcao7.InitialDirectory = "c:\\";
            openFileCadastroPorcao7.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroPorcao7.FilterIndex = 1;
            openFileCadastroPorcao7.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroPorcao7.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroPorcao7.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroPorcao8_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroPorcao8.InitialDirectory = "c:\\";
            openFileCadastroPorcao8.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroPorcao8.FilterIndex = 1;
            openFileCadastroPorcao8.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroPorcao8.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroPorcao8.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroPorcao9_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroPorcao9.InitialDirectory = "c:\\";
            openFileCadastroPorcao9.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroPorcao9.FilterIndex = 1;
            openFileCadastroPorcao9.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroPorcao9.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroPorcao9.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroPorcao10_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroPorcao10.InitialDirectory = "c:\\";
            openFileCadastroPorcao10.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroPorcao10.FilterIndex = 1;
            openFileCadastroPorcao10.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroPorcao10.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroPorcao10.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        
    }
}
