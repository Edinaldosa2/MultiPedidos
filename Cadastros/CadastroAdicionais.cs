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
    public partial class CadastroAdicionais : Form
    {
        private TextBox txtNome9CadastroAdicionais;
        private TextBox txtPreco9CadastroAdicionais;
        private TextBox txtCusto9CadastroAdicionais;
        private TextBox txtPreco8CadastroAdicionais;
        private TextBox txtCusto8CadastroAdicionais;
        private TextBox txtPreco7CadastroAdicionais;
        private TextBox txtCusto7CadastroAdicionais;
        private TextBox txtPreco10CadastroAdicionais;
        private TextBox txtCusto10CadastroAdicionais;
        private TextBox txtNome10CadastroAdicionais;
        private TextBox txtPreco4CadastroAdicionais;
        private TextBox txtCusto4CadastroAdicionais;
        private TextBox txtPreco3CadastroAdicionais;
        private TextBox txtCusto3CadastroAdicionais;
        private TextBox txtPreco2CadastroAdicionais;
        private TextBox txtCusto2CadastroAdicionais;
        private TextBox txtPreco5CadastroAdicionais;
        private TextBox txtCusto5CadastroAdicionais;
        private TextBox txtNome5CadastroAdicionais;
        private TextBox txtPreco6CadastroAdicionais;
        private TextBox txtCusto6CadastroAdicionais;
        private Label lblNome2CadastroAdicionais;
        private Label lblPreco2CadastroAdicionais;
        private Label lblCusto2CadastroAdicionais;
        private Label lblImagem2CadastroAdicionais;
        private Label lblNome1CadastroAdicionais;
        private Label lblPreco1CadastroAdicionais;
        private TextBox txtPreco1CadastroAdicionais;
        private Label lblCusto1CadastroAdicionais;
        private TextBox txtCusto1CadastroAdicionais;
        private Label lblImagem1CadastroAdicionais;
        private TextBox txtNome8CadastroAdicionais;
        private TextBox txtNome4CadastroAdicionais;
        private TextBox txtNome7CadastroAdicionais;
        private TextBox txtNome3CadastroAdicionais;
        private TextBox txtNome6CadastroAdicionais;
        private TextBox txtNome2CadastroAdicionais;
        private Button btnSalvarCadastroAdicionais;
        private TextBox txtNomel1CadastroAdicionais;
        private OpenFileDialog openFileCadastroAdicionais1;
        private OpenFileDialog openFileCadastroAdicionais2;
        private OpenFileDialog openFileCadastroAdicionais3;
        private OpenFileDialog openFileCadastroAdicionais4;
        private OpenFileDialog openFileCadastroAdicionais5;
        private OpenFileDialog openFileCadastroAdicionais6;
        private OpenFileDialog openFileCadastroAdicionais7;
        private OpenFileDialog openFileCadastroAdicionais8;
        private OpenFileDialog openFileCadastroAdicionais9;
        private OpenFileDialog openFileCadastroAdicionais10;
        private Button btnUploadImagem1CadastroAdicionais;
        private Button btnUploadImagem2CadastroAdicionais;
        private Button btnUploadImagem3CadastroAdicionais;
        private Button btnUploadImagem4CadastroAdicionais;
        private Button btnUploadImagem5CadastroAdicionais;
        private Button btnUploadImagem10CadastroAdicionais;
        private Button btnUploadImagem9CadastroAdicionais;
        private Button btnUploadImagem8CadastroAdicionais;
        private Button btnUploadImagem7CadastroAdicionais;
        private Button btnUploadImagem6CadastroAdicionais;
        private Label lblTituloCadastroAdicionais;

        public CadastroAdicionais()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtNome9CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtPreco9CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtCusto9CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtPreco8CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtCusto8CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtPreco7CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtCusto7CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtPreco10CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtCusto10CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtNome10CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtPreco4CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtCusto4CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtPreco3CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtCusto3CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtPreco2CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtCusto2CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtPreco5CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtCusto5CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtNome5CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtPreco6CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtCusto6CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.lblNome2CadastroAdicionais = new System.Windows.Forms.Label();
            this.lblPreco2CadastroAdicionais = new System.Windows.Forms.Label();
            this.lblCusto2CadastroAdicionais = new System.Windows.Forms.Label();
            this.lblImagem2CadastroAdicionais = new System.Windows.Forms.Label();
            this.lblNome1CadastroAdicionais = new System.Windows.Forms.Label();
            this.lblPreco1CadastroAdicionais = new System.Windows.Forms.Label();
            this.txtPreco1CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.lblCusto1CadastroAdicionais = new System.Windows.Forms.Label();
            this.txtCusto1CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.lblImagem1CadastroAdicionais = new System.Windows.Forms.Label();
            this.txtNome8CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtNome4CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtNome7CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtNome3CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtNome6CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.txtNome2CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroAdicionais = new System.Windows.Forms.Button();
            this.txtNomel1CadastroAdicionais = new System.Windows.Forms.TextBox();
            this.lblTituloCadastroAdicionais = new System.Windows.Forms.Label();
            this.openFileCadastroAdicionais1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroAdicionais2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroAdicionais3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroAdicionais4 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroAdicionais5 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroAdicionais6 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroAdicionais7 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroAdicionais8 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroAdicionais9 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroAdicionais10 = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadImagem1CadastroAdicionais = new System.Windows.Forms.Button();
            this.btnUploadImagem2CadastroAdicionais = new System.Windows.Forms.Button();
            this.btnUploadImagem3CadastroAdicionais = new System.Windows.Forms.Button();
            this.btnUploadImagem4CadastroAdicionais = new System.Windows.Forms.Button();
            this.btnUploadImagem5CadastroAdicionais = new System.Windows.Forms.Button();
            this.btnUploadImagem10CadastroAdicionais = new System.Windows.Forms.Button();
            this.btnUploadImagem9CadastroAdicionais = new System.Windows.Forms.Button();
            this.btnUploadImagem8CadastroAdicionais = new System.Windows.Forms.Button();
            this.btnUploadImagem7CadastroAdicionais = new System.Windows.Forms.Button();
            this.btnUploadImagem6CadastroAdicionais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome9CadastroAdicionais
            // 
            this.txtNome9CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome9CadastroAdicionais.Location = new System.Drawing.Point(649, 363);
            this.txtNome9CadastroAdicionais.Name = "txtNome9CadastroAdicionais";
            this.txtNome9CadastroAdicionais.Size = new System.Drawing.Size(168, 30);
            this.txtNome9CadastroAdicionais.TabIndex = 271;
            // 
            // txtPreco9CadastroAdicionais
            // 
            this.txtPreco9CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco9CadastroAdicionais.Location = new System.Drawing.Point(1091, 366);
            this.txtPreco9CadastroAdicionais.Name = "txtPreco9CadastroAdicionais";
            this.txtPreco9CadastroAdicionais.Size = new System.Drawing.Size(78, 30);
            this.txtPreco9CadastroAdicionais.TabIndex = 270;
            // 
            // txtCusto9CadastroAdicionais
            // 
            this.txtCusto9CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto9CadastroAdicionais.Location = new System.Drawing.Point(981, 366);
            this.txtCusto9CadastroAdicionais.Name = "txtCusto9CadastroAdicionais";
            this.txtCusto9CadastroAdicionais.Size = new System.Drawing.Size(82, 30);
            this.txtCusto9CadastroAdicionais.TabIndex = 269;
            // 
            // txtPreco8CadastroAdicionais
            // 
            this.txtPreco8CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco8CadastroAdicionais.Location = new System.Drawing.Point(1091, 283);
            this.txtPreco8CadastroAdicionais.Name = "txtPreco8CadastroAdicionais";
            this.txtPreco8CadastroAdicionais.Size = new System.Drawing.Size(78, 30);
            this.txtPreco8CadastroAdicionais.TabIndex = 268;
            // 
            // txtCusto8CadastroAdicionais
            // 
            this.txtCusto8CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto8CadastroAdicionais.Location = new System.Drawing.Point(981, 283);
            this.txtCusto8CadastroAdicionais.Name = "txtCusto8CadastroAdicionais";
            this.txtCusto8CadastroAdicionais.Size = new System.Drawing.Size(82, 30);
            this.txtCusto8CadastroAdicionais.TabIndex = 267;
            // 
            // txtPreco7CadastroAdicionais
            // 
            this.txtPreco7CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco7CadastroAdicionais.Location = new System.Drawing.Point(1091, 199);
            this.txtPreco7CadastroAdicionais.Name = "txtPreco7CadastroAdicionais";
            this.txtPreco7CadastroAdicionais.Size = new System.Drawing.Size(78, 30);
            this.txtPreco7CadastroAdicionais.TabIndex = 266;
            // 
            // txtCusto7CadastroAdicionais
            // 
            this.txtCusto7CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto7CadastroAdicionais.Location = new System.Drawing.Point(981, 199);
            this.txtCusto7CadastroAdicionais.Name = "txtCusto7CadastroAdicionais";
            this.txtCusto7CadastroAdicionais.Size = new System.Drawing.Size(82, 30);
            this.txtCusto7CadastroAdicionais.TabIndex = 265;
            // 
            // txtPreco10CadastroAdicionais
            // 
            this.txtPreco10CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco10CadastroAdicionais.Location = new System.Drawing.Point(1093, 448);
            this.txtPreco10CadastroAdicionais.Name = "txtPreco10CadastroAdicionais";
            this.txtPreco10CadastroAdicionais.Size = new System.Drawing.Size(78, 30);
            this.txtPreco10CadastroAdicionais.TabIndex = 264;
            // 
            // txtCusto10CadastroAdicionais
            // 
            this.txtCusto10CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto10CadastroAdicionais.Location = new System.Drawing.Point(983, 448);
            this.txtCusto10CadastroAdicionais.Name = "txtCusto10CadastroAdicionais";
            this.txtCusto10CadastroAdicionais.Size = new System.Drawing.Size(82, 30);
            this.txtCusto10CadastroAdicionais.TabIndex = 263;
            // 
            // txtNome10CadastroAdicionais
            // 
            this.txtNome10CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome10CadastroAdicionais.Location = new System.Drawing.Point(649, 448);
            this.txtNome10CadastroAdicionais.Name = "txtNome10CadastroAdicionais";
            this.txtNome10CadastroAdicionais.Size = new System.Drawing.Size(168, 30);
            this.txtNome10CadastroAdicionais.TabIndex = 260;
            // 
            // txtPreco4CadastroAdicionais
            // 
            this.txtPreco4CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco4CadastroAdicionais.Location = new System.Drawing.Point(486, 366);
            this.txtPreco4CadastroAdicionais.Name = "txtPreco4CadastroAdicionais";
            this.txtPreco4CadastroAdicionais.Size = new System.Drawing.Size(78, 30);
            this.txtPreco4CadastroAdicionais.TabIndex = 259;
            // 
            // txtCusto4CadastroAdicionais
            // 
            this.txtCusto4CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto4CadastroAdicionais.Location = new System.Drawing.Point(376, 366);
            this.txtCusto4CadastroAdicionais.Name = "txtCusto4CadastroAdicionais";
            this.txtCusto4CadastroAdicionais.Size = new System.Drawing.Size(82, 30);
            this.txtCusto4CadastroAdicionais.TabIndex = 258;
            // 
            // txtPreco3CadastroAdicionais
            // 
            this.txtPreco3CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco3CadastroAdicionais.Location = new System.Drawing.Point(486, 283);
            this.txtPreco3CadastroAdicionais.Name = "txtPreco3CadastroAdicionais";
            this.txtPreco3CadastroAdicionais.Size = new System.Drawing.Size(78, 30);
            this.txtPreco3CadastroAdicionais.TabIndex = 257;
            // 
            // txtCusto3CadastroAdicionais
            // 
            this.txtCusto3CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto3CadastroAdicionais.Location = new System.Drawing.Point(376, 283);
            this.txtCusto3CadastroAdicionais.Name = "txtCusto3CadastroAdicionais";
            this.txtCusto3CadastroAdicionais.Size = new System.Drawing.Size(82, 30);
            this.txtCusto3CadastroAdicionais.TabIndex = 256;
            // 
            // txtPreco2CadastroAdicionais
            // 
            this.txtPreco2CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco2CadastroAdicionais.Location = new System.Drawing.Point(486, 199);
            this.txtPreco2CadastroAdicionais.Name = "txtPreco2CadastroAdicionais";
            this.txtPreco2CadastroAdicionais.Size = new System.Drawing.Size(78, 30);
            this.txtPreco2CadastroAdicionais.TabIndex = 255;
            // 
            // txtCusto2CadastroAdicionais
            // 
            this.txtCusto2CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto2CadastroAdicionais.Location = new System.Drawing.Point(376, 199);
            this.txtCusto2CadastroAdicionais.Name = "txtCusto2CadastroAdicionais";
            this.txtCusto2CadastroAdicionais.Size = new System.Drawing.Size(82, 30);
            this.txtCusto2CadastroAdicionais.TabIndex = 254;
            // 
            // txtPreco5CadastroAdicionais
            // 
            this.txtPreco5CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco5CadastroAdicionais.Location = new System.Drawing.Point(486, 448);
            this.txtPreco5CadastroAdicionais.Name = "txtPreco5CadastroAdicionais";
            this.txtPreco5CadastroAdicionais.Size = new System.Drawing.Size(78, 30);
            this.txtPreco5CadastroAdicionais.TabIndex = 253;
            // 
            // txtCusto5CadastroAdicionais
            // 
            this.txtCusto5CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto5CadastroAdicionais.Location = new System.Drawing.Point(376, 448);
            this.txtCusto5CadastroAdicionais.Name = "txtCusto5CadastroAdicionais";
            this.txtCusto5CadastroAdicionais.Size = new System.Drawing.Size(82, 30);
            this.txtCusto5CadastroAdicionais.TabIndex = 252;
            // 
            // txtNome5CadastroAdicionais
            // 
            this.txtNome5CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome5CadastroAdicionais.Location = new System.Drawing.Point(42, 448);
            this.txtNome5CadastroAdicionais.Name = "txtNome5CadastroAdicionais";
            this.txtNome5CadastroAdicionais.Size = new System.Drawing.Size(168, 30);
            this.txtNome5CadastroAdicionais.TabIndex = 249;
            // 
            // txtPreco6CadastroAdicionais
            // 
            this.txtPreco6CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco6CadastroAdicionais.Location = new System.Drawing.Point(1093, 116);
            this.txtPreco6CadastroAdicionais.Name = "txtPreco6CadastroAdicionais";
            this.txtPreco6CadastroAdicionais.Size = new System.Drawing.Size(78, 30);
            this.txtPreco6CadastroAdicionais.TabIndex = 245;
            // 
            // txtCusto6CadastroAdicionais
            // 
            this.txtCusto6CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto6CadastroAdicionais.Location = new System.Drawing.Point(983, 116);
            this.txtCusto6CadastroAdicionais.Name = "txtCusto6CadastroAdicionais";
            this.txtCusto6CadastroAdicionais.Size = new System.Drawing.Size(82, 30);
            this.txtCusto6CadastroAdicionais.TabIndex = 244;
            // 
            // lblNome2CadastroAdicionais
            // 
            this.lblNome2CadastroAdicionais.AutoSize = true;
            this.lblNome2CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2CadastroAdicionais.Location = new System.Drawing.Point(711, 76);
            this.lblNome2CadastroAdicionais.Name = "lblNome2CadastroAdicionais";
            this.lblNome2CadastroAdicionais.Size = new System.Drawing.Size(60, 24);
            this.lblNome2CadastroAdicionais.TabIndex = 242;
            this.lblNome2CadastroAdicionais.Text = "Nome";
            // 
            // lblPreco2CadastroAdicionais
            // 
            this.lblPreco2CadastroAdicionais.AutoSize = true;
            this.lblPreco2CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco2CadastroAdicionais.Location = new System.Drawing.Point(1087, 76);
            this.lblPreco2CadastroAdicionais.Name = "lblPreco2CadastroAdicionais";
            this.lblPreco2CadastroAdicionais.Size = new System.Drawing.Size(82, 24);
            this.lblPreco2CadastroAdicionais.TabIndex = 241;
            this.lblPreco2CadastroAdicionais.Text = "Preço ($)";
            // 
            // lblCusto2CadastroAdicionais
            // 
            this.lblCusto2CadastroAdicionais.AutoSize = true;
            this.lblCusto2CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto2CadastroAdicionais.Location = new System.Drawing.Point(977, 76);
            this.lblCusto2CadastroAdicionais.Name = "lblCusto2CadastroAdicionais";
            this.lblCusto2CadastroAdicionais.Size = new System.Drawing.Size(86, 24);
            this.lblCusto2CadastroAdicionais.TabIndex = 240;
            this.lblCusto2CadastroAdicionais.Text = "Custo ($)";
            // 
            // lblImagem2CadastroAdicionais
            // 
            this.lblImagem2CadastroAdicionais.AutoSize = true;
            this.lblImagem2CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem2CadastroAdicionais.Location = new System.Drawing.Point(856, 76);
            this.lblImagem2CadastroAdicionais.Name = "lblImagem2CadastroAdicionais";
            this.lblImagem2CadastroAdicionais.Size = new System.Drawing.Size(77, 24);
            this.lblImagem2CadastroAdicionais.TabIndex = 239;
            this.lblImagem2CadastroAdicionais.Text = "Imagem";
            // 
            // lblNome1CadastroAdicionais
            // 
            this.lblNome1CadastroAdicionais.AutoSize = true;
            this.lblNome1CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1CadastroAdicionais.Location = new System.Drawing.Point(101, 76);
            this.lblNome1CadastroAdicionais.Name = "lblNome1CadastroAdicionais";
            this.lblNome1CadastroAdicionais.Size = new System.Drawing.Size(60, 24);
            this.lblNome1CadastroAdicionais.TabIndex = 235;
            this.lblNome1CadastroAdicionais.Text = "Nome";
            // 
            // lblPreco1CadastroAdicionais
            // 
            this.lblPreco1CadastroAdicionais.AutoSize = true;
            this.lblPreco1CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco1CadastroAdicionais.Location = new System.Drawing.Point(482, 76);
            this.lblPreco1CadastroAdicionais.Name = "lblPreco1CadastroAdicionais";
            this.lblPreco1CadastroAdicionais.Size = new System.Drawing.Size(82, 24);
            this.lblPreco1CadastroAdicionais.TabIndex = 234;
            this.lblPreco1CadastroAdicionais.Text = "Preço ($)";
            // 
            // txtPreco1CadastroAdicionais
            // 
            this.txtPreco1CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco1CadastroAdicionais.Location = new System.Drawing.Point(486, 116);
            this.txtPreco1CadastroAdicionais.Name = "txtPreco1CadastroAdicionais";
            this.txtPreco1CadastroAdicionais.Size = new System.Drawing.Size(78, 30);
            this.txtPreco1CadastroAdicionais.TabIndex = 233;
            // 
            // lblCusto1CadastroAdicionais
            // 
            this.lblCusto1CadastroAdicionais.AutoSize = true;
            this.lblCusto1CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto1CadastroAdicionais.Location = new System.Drawing.Point(372, 76);
            this.lblCusto1CadastroAdicionais.Name = "lblCusto1CadastroAdicionais";
            this.lblCusto1CadastroAdicionais.Size = new System.Drawing.Size(86, 24);
            this.lblCusto1CadastroAdicionais.TabIndex = 232;
            this.lblCusto1CadastroAdicionais.Text = "Custo ($)";
            // 
            // txtCusto1CadastroAdicionais
            // 
            this.txtCusto1CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto1CadastroAdicionais.Location = new System.Drawing.Point(376, 116);
            this.txtCusto1CadastroAdicionais.Name = "txtCusto1CadastroAdicionais";
            this.txtCusto1CadastroAdicionais.Size = new System.Drawing.Size(82, 30);
            this.txtCusto1CadastroAdicionais.TabIndex = 231;
            // 
            // lblImagem1CadastroAdicionais
            // 
            this.lblImagem1CadastroAdicionais.AutoSize = true;
            this.lblImagem1CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem1CadastroAdicionais.Location = new System.Drawing.Point(251, 76);
            this.lblImagem1CadastroAdicionais.Name = "lblImagem1CadastroAdicionais";
            this.lblImagem1CadastroAdicionais.Size = new System.Drawing.Size(77, 24);
            this.lblImagem1CadastroAdicionais.TabIndex = 230;
            this.lblImagem1CadastroAdicionais.Text = "Imagem";
            // 
            // txtNome8CadastroAdicionais
            // 
            this.txtNome8CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome8CadastroAdicionais.Location = new System.Drawing.Point(649, 280);
            this.txtNome8CadastroAdicionais.Name = "txtNome8CadastroAdicionais";
            this.txtNome8CadastroAdicionais.Size = new System.Drawing.Size(168, 30);
            this.txtNome8CadastroAdicionais.TabIndex = 227;
            // 
            // txtNome4CadastroAdicionais
            // 
            this.txtNome4CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome4CadastroAdicionais.Location = new System.Drawing.Point(42, 365);
            this.txtNome4CadastroAdicionais.Name = "txtNome4CadastroAdicionais";
            this.txtNome4CadastroAdicionais.Size = new System.Drawing.Size(168, 30);
            this.txtNome4CadastroAdicionais.TabIndex = 225;
            // 
            // txtNome7CadastroAdicionais
            // 
            this.txtNome7CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome7CadastroAdicionais.Location = new System.Drawing.Point(649, 203);
            this.txtNome7CadastroAdicionais.Name = "txtNome7CadastroAdicionais";
            this.txtNome7CadastroAdicionais.Size = new System.Drawing.Size(168, 30);
            this.txtNome7CadastroAdicionais.TabIndex = 223;
            // 
            // txtNome3CadastroAdicionais
            // 
            this.txtNome3CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome3CadastroAdicionais.Location = new System.Drawing.Point(42, 283);
            this.txtNome3CadastroAdicionais.Name = "txtNome3CadastroAdicionais";
            this.txtNome3CadastroAdicionais.Size = new System.Drawing.Size(168, 30);
            this.txtNome3CadastroAdicionais.TabIndex = 221;
            // 
            // txtNome6CadastroAdicionais
            // 
            this.txtNome6CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome6CadastroAdicionais.Location = new System.Drawing.Point(649, 116);
            this.txtNome6CadastroAdicionais.Name = "txtNome6CadastroAdicionais";
            this.txtNome6CadastroAdicionais.Size = new System.Drawing.Size(168, 30);
            this.txtNome6CadastroAdicionais.TabIndex = 219;
            // 
            // txtNome2CadastroAdicionais
            // 
            this.txtNome2CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome2CadastroAdicionais.Location = new System.Drawing.Point(42, 199);
            this.txtNome2CadastroAdicionais.Name = "txtNome2CadastroAdicionais";
            this.txtNome2CadastroAdicionais.Size = new System.Drawing.Size(168, 30);
            this.txtNome2CadastroAdicionais.TabIndex = 217;
            // 
            // btnSalvarCadastroAdicionais
            // 
            this.btnSalvarCadastroAdicionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarCadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroAdicionais.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSalvarCadastroAdicionais.Location = new System.Drawing.Point(981, 544);
            this.btnSalvarCadastroAdicionais.Name = "btnSalvarCadastroAdicionais";
            this.btnSalvarCadastroAdicionais.Size = new System.Drawing.Size(167, 55);
            this.btnSalvarCadastroAdicionais.TabIndex = 216;
            this.btnSalvarCadastroAdicionais.Text = "Salvar";
            this.btnSalvarCadastroAdicionais.UseVisualStyleBackColor = false;
            // 
            // txtNomel1CadastroAdicionais
            // 
            this.txtNomel1CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomel1CadastroAdicionais.Location = new System.Drawing.Point(42, 116);
            this.txtNomel1CadastroAdicionais.Name = "txtNomel1CadastroAdicionais";
            this.txtNomel1CadastroAdicionais.Size = new System.Drawing.Size(168, 30);
            this.txtNomel1CadastroAdicionais.TabIndex = 214;
            // 
            // lblTituloCadastroAdicionais
            // 
            this.lblTituloCadastroAdicionais.AutoSize = true;
            this.lblTituloCadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroAdicionais.Location = new System.Drawing.Point(492, 17);
            this.lblTituloCadastroAdicionais.Name = "lblTituloCadastroAdicionais";
            this.lblTituloCadastroAdicionais.Size = new System.Drawing.Size(258, 31);
            this.lblTituloCadastroAdicionais.TabIndex = 213;
            this.lblTituloCadastroAdicionais.Text = "Cadastro de Adicionais";
            // 
            // openFileCadastroAdicionais1
            // 
            this.openFileCadastroAdicionais1.FileName = "openFileCadastroAdicionais1";
            // 
            // openFileCadastroAdicionais2
            // 
            this.openFileCadastroAdicionais2.FileName = "openFileCadastroAdicionais2";
            // 
            // openFileCadastroAdicionais3
            // 
            this.openFileCadastroAdicionais3.FileName = "openFileCadastroAdicionais3";
            // 
            // openFileCadastroAdicionais4
            // 
            this.openFileCadastroAdicionais4.FileName = "openFileCadastroAdicionais4";
            // 
            // openFileCadastroAdicionais5
            // 
            this.openFileCadastroAdicionais5.FileName = "openFileCadastroAdicionais5";
            // 
            // openFileCadastroAdicionais6
            // 
            this.openFileCadastroAdicionais6.FileName = "openFileCadastroAdicionais6";
            // 
            // openFileCadastroAdicionais7
            // 
            this.openFileCadastroAdicionais7.FileName = "openFileCadastroAdicionais7";
            // 
            // openFileCadastroAdicionais8
            // 
            this.openFileCadastroAdicionais8.FileName = "openFileCadastroAdicionais8";
            // 
            // openFileCadastroAdicionais9
            // 
            this.openFileCadastroAdicionais9.FileName = "openFileCadastroAdicionais9";
            // 
            // openFileCadastroAdicionais10
            // 
            this.openFileCadastroAdicionais10.FileName = "openFileCadastroAdicionais10";
            // 
            // btnUploadImagem1CadastroAdicionais
            // 
            this.btnUploadImagem1CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem1CadastroAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem1CadastroAdicionais.Location = new System.Drawing.Point(228, 115);
            this.btnUploadImagem1CadastroAdicionais.Name = "btnUploadImagem1CadastroAdicionais";
            this.btnUploadImagem1CadastroAdicionais.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem1CadastroAdicionais.TabIndex = 334;
            this.btnUploadImagem1CadastroAdicionais.Text = "Upload";
            this.btnUploadImagem1CadastroAdicionais.UseVisualStyleBackColor = true;
            this.btnUploadImagem1CadastroAdicionais.Click += new System.EventHandler(this.btnUploadImagemCadastroAdicional1_Click);
            // 
            // btnUploadImagem2CadastroAdicionais
            // 
            this.btnUploadImagem2CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem2CadastroAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem2CadastroAdicionais.Location = new System.Drawing.Point(228, 199);
            this.btnUploadImagem2CadastroAdicionais.Name = "btnUploadImagem2CadastroAdicionais";
            this.btnUploadImagem2CadastroAdicionais.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem2CadastroAdicionais.TabIndex = 335;
            this.btnUploadImagem2CadastroAdicionais.Text = "Upload";
            this.btnUploadImagem2CadastroAdicionais.UseVisualStyleBackColor = true;
            this.btnUploadImagem2CadastroAdicionais.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUploadImagem3CadastroAdicionais
            // 
            this.btnUploadImagem3CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem3CadastroAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem3CadastroAdicionais.Location = new System.Drawing.Point(228, 283);
            this.btnUploadImagem3CadastroAdicionais.Name = "btnUploadImagem3CadastroAdicionais";
            this.btnUploadImagem3CadastroAdicionais.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem3CadastroAdicionais.TabIndex = 336;
            this.btnUploadImagem3CadastroAdicionais.Text = "Upload";
            this.btnUploadImagem3CadastroAdicionais.UseVisualStyleBackColor = true;
            this.btnUploadImagem3CadastroAdicionais.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUploadImagem4CadastroAdicionais
            // 
            this.btnUploadImagem4CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem4CadastroAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem4CadastroAdicionais.Location = new System.Drawing.Point(228, 366);
            this.btnUploadImagem4CadastroAdicionais.Name = "btnUploadImagem4CadastroAdicionais";
            this.btnUploadImagem4CadastroAdicionais.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem4CadastroAdicionais.TabIndex = 337;
            this.btnUploadImagem4CadastroAdicionais.Text = "Upload";
            this.btnUploadImagem4CadastroAdicionais.UseVisualStyleBackColor = true;
            this.btnUploadImagem4CadastroAdicionais.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUploadImagem5CadastroAdicionais
            // 
            this.btnUploadImagem5CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem5CadastroAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem5CadastroAdicionais.Location = new System.Drawing.Point(228, 442);
            this.btnUploadImagem5CadastroAdicionais.Name = "btnUploadImagem5CadastroAdicionais";
            this.btnUploadImagem5CadastroAdicionais.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem5CadastroAdicionais.TabIndex = 338;
            this.btnUploadImagem5CadastroAdicionais.Text = "Upload";
            this.btnUploadImagem5CadastroAdicionais.UseVisualStyleBackColor = true;
            this.btnUploadImagem5CadastroAdicionais.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUploadImagem10CadastroAdicionais
            // 
            this.btnUploadImagem10CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem10CadastroAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem10CadastroAdicionais.Location = new System.Drawing.Point(837, 443);
            this.btnUploadImagem10CadastroAdicionais.Name = "btnUploadImagem10CadastroAdicionais";
            this.btnUploadImagem10CadastroAdicionais.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem10CadastroAdicionais.TabIndex = 343;
            this.btnUploadImagem10CadastroAdicionais.Text = "Upload";
            this.btnUploadImagem10CadastroAdicionais.UseVisualStyleBackColor = true;
            this.btnUploadImagem10CadastroAdicionais.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnUploadImagem9CadastroAdicionais
            // 
            this.btnUploadImagem9CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem9CadastroAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem9CadastroAdicionais.Location = new System.Drawing.Point(837, 367);
            this.btnUploadImagem9CadastroAdicionais.Name = "btnUploadImagem9CadastroAdicionais";
            this.btnUploadImagem9CadastroAdicionais.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem9CadastroAdicionais.TabIndex = 342;
            this.btnUploadImagem9CadastroAdicionais.Text = "Upload";
            this.btnUploadImagem9CadastroAdicionais.UseVisualStyleBackColor = true;
            this.btnUploadImagem9CadastroAdicionais.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnUploadImagem8CadastroAdicionais
            // 
            this.btnUploadImagem8CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem8CadastroAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem8CadastroAdicionais.Location = new System.Drawing.Point(837, 284);
            this.btnUploadImagem8CadastroAdicionais.Name = "btnUploadImagem8CadastroAdicionais";
            this.btnUploadImagem8CadastroAdicionais.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem8CadastroAdicionais.TabIndex = 341;
            this.btnUploadImagem8CadastroAdicionais.Text = "Upload";
            this.btnUploadImagem8CadastroAdicionais.UseVisualStyleBackColor = true;
            this.btnUploadImagem8CadastroAdicionais.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnUploadImagem7CadastroAdicionais
            // 
            this.btnUploadImagem7CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem7CadastroAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem7CadastroAdicionais.Location = new System.Drawing.Point(837, 200);
            this.btnUploadImagem7CadastroAdicionais.Name = "btnUploadImagem7CadastroAdicionais";
            this.btnUploadImagem7CadastroAdicionais.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem7CadastroAdicionais.TabIndex = 340;
            this.btnUploadImagem7CadastroAdicionais.Text = "Upload";
            this.btnUploadImagem7CadastroAdicionais.UseVisualStyleBackColor = true;
            this.btnUploadImagem7CadastroAdicionais.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnUploadImagem6CadastroAdicionais
            // 
            this.btnUploadImagem6CadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem6CadastroAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem6CadastroAdicionais.Location = new System.Drawing.Point(837, 116);
            this.btnUploadImagem6CadastroAdicionais.Name = "btnUploadImagem6CadastroAdicionais";
            this.btnUploadImagem6CadastroAdicionais.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem6CadastroAdicionais.TabIndex = 339;
            this.btnUploadImagem6CadastroAdicionais.Text = "Upload";
            this.btnUploadImagem6CadastroAdicionais.UseVisualStyleBackColor = true;
            this.btnUploadImagem6CadastroAdicionais.Click += new System.EventHandler(this.button9_Click);
            // 
            // CadastroAdicionais
            // 
            this.ClientSize = new System.Drawing.Size(1188, 617);
            this.Controls.Add(this.btnUploadImagem10CadastroAdicionais);
            this.Controls.Add(this.btnUploadImagem9CadastroAdicionais);
            this.Controls.Add(this.btnUploadImagem8CadastroAdicionais);
            this.Controls.Add(this.btnUploadImagem7CadastroAdicionais);
            this.Controls.Add(this.btnUploadImagem6CadastroAdicionais);
            this.Controls.Add(this.btnUploadImagem5CadastroAdicionais);
            this.Controls.Add(this.btnUploadImagem4CadastroAdicionais);
            this.Controls.Add(this.btnUploadImagem3CadastroAdicionais);
            this.Controls.Add(this.btnUploadImagem2CadastroAdicionais);
            this.Controls.Add(this.btnUploadImagem1CadastroAdicionais);
            this.Controls.Add(this.txtNome9CadastroAdicionais);
            this.Controls.Add(this.txtPreco9CadastroAdicionais);
            this.Controls.Add(this.txtCusto9CadastroAdicionais);
            this.Controls.Add(this.txtPreco8CadastroAdicionais);
            this.Controls.Add(this.txtCusto8CadastroAdicionais);
            this.Controls.Add(this.txtPreco7CadastroAdicionais);
            this.Controls.Add(this.txtCusto7CadastroAdicionais);
            this.Controls.Add(this.txtPreco10CadastroAdicionais);
            this.Controls.Add(this.txtCusto10CadastroAdicionais);
            this.Controls.Add(this.txtNome10CadastroAdicionais);
            this.Controls.Add(this.txtPreco4CadastroAdicionais);
            this.Controls.Add(this.txtCusto4CadastroAdicionais);
            this.Controls.Add(this.txtPreco3CadastroAdicionais);
            this.Controls.Add(this.txtCusto3CadastroAdicionais);
            this.Controls.Add(this.txtPreco2CadastroAdicionais);
            this.Controls.Add(this.txtCusto2CadastroAdicionais);
            this.Controls.Add(this.txtPreco5CadastroAdicionais);
            this.Controls.Add(this.txtCusto5CadastroAdicionais);
            this.Controls.Add(this.txtNome5CadastroAdicionais);
            this.Controls.Add(this.txtPreco6CadastroAdicionais);
            this.Controls.Add(this.txtCusto6CadastroAdicionais);
            this.Controls.Add(this.lblNome2CadastroAdicionais);
            this.Controls.Add(this.lblPreco2CadastroAdicionais);
            this.Controls.Add(this.lblCusto2CadastroAdicionais);
            this.Controls.Add(this.lblImagem2CadastroAdicionais);
            this.Controls.Add(this.lblNome1CadastroAdicionais);
            this.Controls.Add(this.lblPreco1CadastroAdicionais);
            this.Controls.Add(this.txtPreco1CadastroAdicionais);
            this.Controls.Add(this.lblCusto1CadastroAdicionais);
            this.Controls.Add(this.txtCusto1CadastroAdicionais);
            this.Controls.Add(this.lblImagem1CadastroAdicionais);
            this.Controls.Add(this.txtNome8CadastroAdicionais);
            this.Controls.Add(this.txtNome4CadastroAdicionais);
            this.Controls.Add(this.txtNome7CadastroAdicionais);
            this.Controls.Add(this.txtNome3CadastroAdicionais);
            this.Controls.Add(this.txtNome6CadastroAdicionais);
            this.Controls.Add(this.txtNome2CadastroAdicionais);
            this.Controls.Add(this.btnSalvarCadastroAdicionais);
            this.Controls.Add(this.txtNomel1CadastroAdicionais);
            this.Controls.Add(this.lblTituloCadastroAdicionais);
            this.Name = "CadastroAdicionais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnUploadImagemCadastroAdicional1_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroAdicionais1.InitialDirectory = "c:\\";
            openFileCadastroAdicionais1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroAdicionais1.FilterIndex = 1;
            openFileCadastroAdicionais1.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroAdicionais1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroAdicionais1.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroAdicionais2.InitialDirectory = "c:\\";
            openFileCadastroAdicionais2.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroAdicionais2.FilterIndex = 1;
            openFileCadastroAdicionais2.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroAdicionais2.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroAdicionais2.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroAdicionais3.InitialDirectory = "c:\\";
            openFileCadastroAdicionais3.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroAdicionais3.FilterIndex = 1;
            openFileCadastroAdicionais3.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroAdicionais3.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroAdicionais3.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroAdicionais4.InitialDirectory = "c:\\";
            openFileCadastroAdicionais4.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroAdicionais4.FilterIndex = 1;
            openFileCadastroAdicionais4.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroAdicionais4.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroAdicionais4.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroAdicionais5.InitialDirectory = "c:\\";
            openFileCadastroAdicionais5.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroAdicionais5.FilterIndex = 1;
            openFileCadastroAdicionais5.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroAdicionais5.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroAdicionais5.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroAdicionais6.InitialDirectory = "c:\\";
            openFileCadastroAdicionais6.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroAdicionais6.FilterIndex = 1;
            openFileCadastroAdicionais6.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroAdicionais6.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroAdicionais6.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroAdicionais7.InitialDirectory = "c:\\";
            openFileCadastroAdicionais7.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroAdicionais7.FilterIndex = 1;
            openFileCadastroAdicionais7.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroAdicionais7.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroAdicionais7.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroAdicionais8.InitialDirectory = "c:\\";
            openFileCadastroAdicionais8.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroAdicionais8.FilterIndex = 1;
            openFileCadastroAdicionais8.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroAdicionais8.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroAdicionais8.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroAdicionais9.InitialDirectory = "c:\\";
            openFileCadastroAdicionais9.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroAdicionais9.FilterIndex = 1;
            openFileCadastroAdicionais9.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroAdicionais9.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroAdicionais9.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroAdicionais10.InitialDirectory = "c:\\";
            openFileCadastroAdicionais10.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroAdicionais10.FilterIndex = 1;
            openFileCadastroAdicionais10.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroAdicionais10.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroAdicionais10.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        
    }
}
