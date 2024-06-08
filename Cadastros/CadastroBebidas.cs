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
    public partial class CadastroBebidas : Form
    {
        private TextBox txtNome9CadastroBebidas;
        private TextBox txtPreco9CadastroBebidas;
        private TextBox txtCusto9CadastroBebidas;
        private TextBox txtPreco8CadastroBebidas;
        private TextBox txtCusto8CadastroBebidas;
        private TextBox txtPreco7CadastroBebidas;
        private TextBox txtCusto7CadastroBebidas;
        private TextBox txtPreco10CadastroBebidas;
        private TextBox txtCusto10CadastroBebidas;
        private TextBox txtNome10CadastroBebidas;
        private TextBox txtPreco4CadastroBebidas;
        private TextBox txtCusto4CadastroBebidas;
        private TextBox txtPreco3CadastroBebidas;
        private TextBox txtCusto3CadastroBebidas;
        private TextBox txtPreco2CadastroBebidas;
        private TextBox txtCusto2CadastroBebidas;
        private TextBox txtPreco5CadastroBebidas;
        private TextBox txtCusto5CadastroBebidas;
        private TextBox txtNome5CadastroBebidas;
        private TextBox txtPreco6CadastroBebidas;
        private TextBox txtCusto6CadastroBebidas;
        private Label lblNome2CadastroBebidas;
        private Label lblPreco2CadastroBebidas;
        private Label lblCusto2CadastroBebidas;
        private Label lblImagem2CadastroBebidas;
        private Label lblNome1CadastroBebidas;
        private Label lblPreco1CadastroBebidas;
        private TextBox txtPreco1CadastroBebidas;
        private Label lblCusto1CadastroBebidas;
        private TextBox txtCusto1CadastroBebidas;
        private Label lblImagem1CadastroBebidas;
        private TextBox txtNome8CadastroBebidas;
        private TextBox txtNome4CadastroBebidas;
        private TextBox txtNome7CadastroBebidas;
        private TextBox txtNome3CadastroBebidas;
        private TextBox txtNome6CadastroBebidas;
        private TextBox txtNome2CadastroBebidas;
        private Button btnSalvarCadastroBebidas;
        private TextBox txtNome1CadastroBebidas;
        private OpenFileDialog openFileCadastroBebida1;
        private OpenFileDialog openFileCadastroBebida2;
        private OpenFileDialog openFileCadastroBebida3;
        private OpenFileDialog openFileCadastroBebida4;
        private OpenFileDialog openFileCadastroBebida5;
        private OpenFileDialog openFileCadastroBebida6;
        private OpenFileDialog openFileCadastroBebida7;
        private OpenFileDialog openFileCadastroBebida8;
        private OpenFileDialog openFileCadastroBebida9;
        private OpenFileDialog openFileCadastroBebida10;
        private Button btnUploadImagem1CadastroBebidas;
        private Button btnUploadImagem2CadastroBebidas;
        private Button btnUploadImagem3CadastroBebidas;
        private Button btnUploadImagem4CadastroBebidas;
        private Button btnUploadImagem5CadastroBebidas;
        private Button btnUploadImagem10CadastroBebidas;
        private Button btnUploadImage91CadastroBebidas;
        private Button btnUploadImagem8CadastroBebidas;
        private Button btnUploadImagem7CadastroBebidas;
        private Button btnUploadImagem6CadastroBebidas;
        private Label lblTituloCadastroBebidas;

        public CadastroBebidas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtNome9CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtPreco9CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtCusto9CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtPreco8CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtCusto8CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtPreco7CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtCusto7CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtPreco10CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtCusto10CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtNome10CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtPreco4CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtCusto4CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtPreco3CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtCusto3CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtPreco2CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtCusto2CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtPreco5CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtCusto5CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtNome5CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtPreco6CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtCusto6CadastroBebidas = new System.Windows.Forms.TextBox();
            this.lblNome2CadastroBebidas = new System.Windows.Forms.Label();
            this.lblPreco2CadastroBebidas = new System.Windows.Forms.Label();
            this.lblCusto2CadastroBebidas = new System.Windows.Forms.Label();
            this.lblImagem2CadastroBebidas = new System.Windows.Forms.Label();
            this.lblNome1CadastroBebidas = new System.Windows.Forms.Label();
            this.lblPreco1CadastroBebidas = new System.Windows.Forms.Label();
            this.txtPreco1CadastroBebidas = new System.Windows.Forms.TextBox();
            this.lblCusto1CadastroBebidas = new System.Windows.Forms.Label();
            this.txtCusto1CadastroBebidas = new System.Windows.Forms.TextBox();
            this.lblImagem1CadastroBebidas = new System.Windows.Forms.Label();
            this.txtNome8CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtNome4CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtNome7CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtNome3CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtNome6CadastroBebidas = new System.Windows.Forms.TextBox();
            this.txtNome2CadastroBebidas = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroBebidas = new System.Windows.Forms.Button();
            this.txtNome1CadastroBebidas = new System.Windows.Forms.TextBox();
            this.lblTituloCadastroBebidas = new System.Windows.Forms.Label();
            this.openFileCadastroBebida1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroBebida2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroBebida3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroBebida4 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroBebida5 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroBebida6 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroBebida7 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroBebida8 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroBebida9 = new System.Windows.Forms.OpenFileDialog();
            this.openFileCadastroBebida10 = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadImagem1CadastroBebidas = new System.Windows.Forms.Button();
            this.btnUploadImagem2CadastroBebidas = new System.Windows.Forms.Button();
            this.btnUploadImagem3CadastroBebidas = new System.Windows.Forms.Button();
            this.btnUploadImagem4CadastroBebidas = new System.Windows.Forms.Button();
            this.btnUploadImagem5CadastroBebidas = new System.Windows.Forms.Button();
            this.btnUploadImagem10CadastroBebidas = new System.Windows.Forms.Button();
            this.btnUploadImage91CadastroBebidas = new System.Windows.Forms.Button();
            this.btnUploadImagem8CadastroBebidas = new System.Windows.Forms.Button();
            this.btnUploadImagem7CadastroBebidas = new System.Windows.Forms.Button();
            this.btnUploadImagem6CadastroBebidas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome9CadastroBebidas
            // 
            this.txtNome9CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome9CadastroBebidas.Location = new System.Drawing.Point(647, 366);
            this.txtNome9CadastroBebidas.Name = "txtNome9CadastroBebidas";
            this.txtNome9CadastroBebidas.Size = new System.Drawing.Size(168, 30);
            this.txtNome9CadastroBebidas.TabIndex = 391;
            // 
            // txtPreco9CadastroBebidas
            // 
            this.txtPreco9CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco9CadastroBebidas.Location = new System.Drawing.Point(1089, 369);
            this.txtPreco9CadastroBebidas.Name = "txtPreco9CadastroBebidas";
            this.txtPreco9CadastroBebidas.Size = new System.Drawing.Size(78, 30);
            this.txtPreco9CadastroBebidas.TabIndex = 390;
            // 
            // txtCusto9CadastroBebidas
            // 
            this.txtCusto9CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto9CadastroBebidas.Location = new System.Drawing.Point(979, 369);
            this.txtCusto9CadastroBebidas.Name = "txtCusto9CadastroBebidas";
            this.txtCusto9CadastroBebidas.Size = new System.Drawing.Size(82, 30);
            this.txtCusto9CadastroBebidas.TabIndex = 389;
            // 
            // txtPreco8CadastroBebidas
            // 
            this.txtPreco8CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco8CadastroBebidas.Location = new System.Drawing.Point(1089, 286);
            this.txtPreco8CadastroBebidas.Name = "txtPreco8CadastroBebidas";
            this.txtPreco8CadastroBebidas.Size = new System.Drawing.Size(78, 30);
            this.txtPreco8CadastroBebidas.TabIndex = 388;
            // 
            // txtCusto8CadastroBebidas
            // 
            this.txtCusto8CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto8CadastroBebidas.Location = new System.Drawing.Point(979, 286);
            this.txtCusto8CadastroBebidas.Name = "txtCusto8CadastroBebidas";
            this.txtCusto8CadastroBebidas.Size = new System.Drawing.Size(82, 30);
            this.txtCusto8CadastroBebidas.TabIndex = 387;
            // 
            // txtPreco7CadastroBebidas
            // 
            this.txtPreco7CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco7CadastroBebidas.Location = new System.Drawing.Point(1089, 202);
            this.txtPreco7CadastroBebidas.Name = "txtPreco7CadastroBebidas";
            this.txtPreco7CadastroBebidas.Size = new System.Drawing.Size(78, 30);
            this.txtPreco7CadastroBebidas.TabIndex = 386;
            // 
            // txtCusto7CadastroBebidas
            // 
            this.txtCusto7CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto7CadastroBebidas.Location = new System.Drawing.Point(979, 202);
            this.txtCusto7CadastroBebidas.Name = "txtCusto7CadastroBebidas";
            this.txtCusto7CadastroBebidas.Size = new System.Drawing.Size(82, 30);
            this.txtCusto7CadastroBebidas.TabIndex = 385;
            // 
            // txtPreco10CadastroBebidas
            // 
            this.txtPreco10CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco10CadastroBebidas.Location = new System.Drawing.Point(1091, 451);
            this.txtPreco10CadastroBebidas.Name = "txtPreco10CadastroBebidas";
            this.txtPreco10CadastroBebidas.Size = new System.Drawing.Size(78, 30);
            this.txtPreco10CadastroBebidas.TabIndex = 384;
            // 
            // txtCusto10CadastroBebidas
            // 
            this.txtCusto10CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto10CadastroBebidas.Location = new System.Drawing.Point(981, 451);
            this.txtCusto10CadastroBebidas.Name = "txtCusto10CadastroBebidas";
            this.txtCusto10CadastroBebidas.Size = new System.Drawing.Size(82, 30);
            this.txtCusto10CadastroBebidas.TabIndex = 383;
            // 
            // txtNome10CadastroBebidas
            // 
            this.txtNome10CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome10CadastroBebidas.Location = new System.Drawing.Point(647, 451);
            this.txtNome10CadastroBebidas.Name = "txtNome10CadastroBebidas";
            this.txtNome10CadastroBebidas.Size = new System.Drawing.Size(168, 30);
            this.txtNome10CadastroBebidas.TabIndex = 380;
            // 
            // txtPreco4CadastroBebidas
            // 
            this.txtPreco4CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco4CadastroBebidas.Location = new System.Drawing.Point(484, 369);
            this.txtPreco4CadastroBebidas.Name = "txtPreco4CadastroBebidas";
            this.txtPreco4CadastroBebidas.Size = new System.Drawing.Size(78, 30);
            this.txtPreco4CadastroBebidas.TabIndex = 379;
            // 
            // txtCusto4CadastroBebidas
            // 
            this.txtCusto4CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto4CadastroBebidas.Location = new System.Drawing.Point(374, 369);
            this.txtCusto4CadastroBebidas.Name = "txtCusto4CadastroBebidas";
            this.txtCusto4CadastroBebidas.Size = new System.Drawing.Size(82, 30);
            this.txtCusto4CadastroBebidas.TabIndex = 378;
            // 
            // txtPreco3CadastroBebidas
            // 
            this.txtPreco3CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco3CadastroBebidas.Location = new System.Drawing.Point(484, 286);
            this.txtPreco3CadastroBebidas.Name = "txtPreco3CadastroBebidas";
            this.txtPreco3CadastroBebidas.Size = new System.Drawing.Size(78, 30);
            this.txtPreco3CadastroBebidas.TabIndex = 377;
            // 
            // txtCusto3CadastroBebidas
            // 
            this.txtCusto3CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto3CadastroBebidas.Location = new System.Drawing.Point(374, 286);
            this.txtCusto3CadastroBebidas.Name = "txtCusto3CadastroBebidas";
            this.txtCusto3CadastroBebidas.Size = new System.Drawing.Size(82, 30);
            this.txtCusto3CadastroBebidas.TabIndex = 376;
            // 
            // txtPreco2CadastroBebidas
            // 
            this.txtPreco2CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco2CadastroBebidas.Location = new System.Drawing.Point(484, 202);
            this.txtPreco2CadastroBebidas.Name = "txtPreco2CadastroBebidas";
            this.txtPreco2CadastroBebidas.Size = new System.Drawing.Size(78, 30);
            this.txtPreco2CadastroBebidas.TabIndex = 375;
            // 
            // txtCusto2CadastroBebidas
            // 
            this.txtCusto2CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto2CadastroBebidas.Location = new System.Drawing.Point(374, 202);
            this.txtCusto2CadastroBebidas.Name = "txtCusto2CadastroBebidas";
            this.txtCusto2CadastroBebidas.Size = new System.Drawing.Size(82, 30);
            this.txtCusto2CadastroBebidas.TabIndex = 374;
            // 
            // txtPreco5CadastroBebidas
            // 
            this.txtPreco5CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco5CadastroBebidas.Location = new System.Drawing.Point(484, 451);
            this.txtPreco5CadastroBebidas.Name = "txtPreco5CadastroBebidas";
            this.txtPreco5CadastroBebidas.Size = new System.Drawing.Size(78, 30);
            this.txtPreco5CadastroBebidas.TabIndex = 373;
            // 
            // txtCusto5CadastroBebidas
            // 
            this.txtCusto5CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto5CadastroBebidas.Location = new System.Drawing.Point(374, 451);
            this.txtCusto5CadastroBebidas.Name = "txtCusto5CadastroBebidas";
            this.txtCusto5CadastroBebidas.Size = new System.Drawing.Size(82, 30);
            this.txtCusto5CadastroBebidas.TabIndex = 372;
            // 
            // txtNome5CadastroBebidas
            // 
            this.txtNome5CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome5CadastroBebidas.Location = new System.Drawing.Point(40, 451);
            this.txtNome5CadastroBebidas.Name = "txtNome5CadastroBebidas";
            this.txtNome5CadastroBebidas.Size = new System.Drawing.Size(168, 30);
            this.txtNome5CadastroBebidas.TabIndex = 369;
            // 
            // txtPreco6CadastroBebidas
            // 
            this.txtPreco6CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco6CadastroBebidas.Location = new System.Drawing.Point(1091, 119);
            this.txtPreco6CadastroBebidas.Name = "txtPreco6CadastroBebidas";
            this.txtPreco6CadastroBebidas.Size = new System.Drawing.Size(78, 30);
            this.txtPreco6CadastroBebidas.TabIndex = 365;
            // 
            // txtCusto6CadastroBebidas
            // 
            this.txtCusto6CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto6CadastroBebidas.Location = new System.Drawing.Point(981, 119);
            this.txtCusto6CadastroBebidas.Name = "txtCusto6CadastroBebidas";
            this.txtCusto6CadastroBebidas.Size = new System.Drawing.Size(82, 30);
            this.txtCusto6CadastroBebidas.TabIndex = 364;
            // 
            // lblNome2CadastroBebidas
            // 
            this.lblNome2CadastroBebidas.AutoSize = true;
            this.lblNome2CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2CadastroBebidas.Location = new System.Drawing.Point(698, 79);
            this.lblNome2CadastroBebidas.Name = "lblNome2CadastroBebidas";
            this.lblNome2CadastroBebidas.Size = new System.Drawing.Size(60, 24);
            this.lblNome2CadastroBebidas.TabIndex = 362;
            this.lblNome2CadastroBebidas.Text = "Nome";
            // 
            // lblPreco2CadastroBebidas
            // 
            this.lblPreco2CadastroBebidas.AutoSize = true;
            this.lblPreco2CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco2CadastroBebidas.Location = new System.Drawing.Point(1085, 79);
            this.lblPreco2CadastroBebidas.Name = "lblPreco2CadastroBebidas";
            this.lblPreco2CadastroBebidas.Size = new System.Drawing.Size(82, 24);
            this.lblPreco2CadastroBebidas.TabIndex = 361;
            this.lblPreco2CadastroBebidas.Text = "Preço ($)";
            // 
            // lblCusto2CadastroBebidas
            // 
            this.lblCusto2CadastroBebidas.AutoSize = true;
            this.lblCusto2CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto2CadastroBebidas.Location = new System.Drawing.Point(975, 79);
            this.lblCusto2CadastroBebidas.Name = "lblCusto2CadastroBebidas";
            this.lblCusto2CadastroBebidas.Size = new System.Drawing.Size(86, 24);
            this.lblCusto2CadastroBebidas.TabIndex = 360;
            this.lblCusto2CadastroBebidas.Text = "Custo ($)";
            // 
            // lblImagem2CadastroBebidas
            // 
            this.lblImagem2CadastroBebidas.AutoSize = true;
            this.lblImagem2CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem2CadastroBebidas.Location = new System.Drawing.Point(854, 79);
            this.lblImagem2CadastroBebidas.Name = "lblImagem2CadastroBebidas";
            this.lblImagem2CadastroBebidas.Size = new System.Drawing.Size(77, 24);
            this.lblImagem2CadastroBebidas.TabIndex = 359;
            this.lblImagem2CadastroBebidas.Text = "Imagem";
            // 
            // lblNome1CadastroBebidas
            // 
            this.lblNome1CadastroBebidas.AutoSize = true;
            this.lblNome1CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1CadastroBebidas.Location = new System.Drawing.Point(99, 79);
            this.lblNome1CadastroBebidas.Name = "lblNome1CadastroBebidas";
            this.lblNome1CadastroBebidas.Size = new System.Drawing.Size(60, 24);
            this.lblNome1CadastroBebidas.TabIndex = 355;
            this.lblNome1CadastroBebidas.Text = "Nome";
            // 
            // lblPreco1CadastroBebidas
            // 
            this.lblPreco1CadastroBebidas.AutoSize = true;
            this.lblPreco1CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco1CadastroBebidas.Location = new System.Drawing.Point(480, 79);
            this.lblPreco1CadastroBebidas.Name = "lblPreco1CadastroBebidas";
            this.lblPreco1CadastroBebidas.Size = new System.Drawing.Size(82, 24);
            this.lblPreco1CadastroBebidas.TabIndex = 354;
            this.lblPreco1CadastroBebidas.Text = "Preço ($)";
            // 
            // txtPreco1CadastroBebidas
            // 
            this.txtPreco1CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco1CadastroBebidas.Location = new System.Drawing.Point(484, 119);
            this.txtPreco1CadastroBebidas.Name = "txtPreco1CadastroBebidas";
            this.txtPreco1CadastroBebidas.Size = new System.Drawing.Size(78, 30);
            this.txtPreco1CadastroBebidas.TabIndex = 353;
            // 
            // lblCusto1CadastroBebidas
            // 
            this.lblCusto1CadastroBebidas.AutoSize = true;
            this.lblCusto1CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto1CadastroBebidas.Location = new System.Drawing.Point(370, 79);
            this.lblCusto1CadastroBebidas.Name = "lblCusto1CadastroBebidas";
            this.lblCusto1CadastroBebidas.Size = new System.Drawing.Size(86, 24);
            this.lblCusto1CadastroBebidas.TabIndex = 352;
            this.lblCusto1CadastroBebidas.Text = "Custo ($)";
            // 
            // txtCusto1CadastroBebidas
            // 
            this.txtCusto1CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto1CadastroBebidas.Location = new System.Drawing.Point(374, 119);
            this.txtCusto1CadastroBebidas.Name = "txtCusto1CadastroBebidas";
            this.txtCusto1CadastroBebidas.Size = new System.Drawing.Size(82, 30);
            this.txtCusto1CadastroBebidas.TabIndex = 351;
            // 
            // lblImagem1CadastroBebidas
            // 
            this.lblImagem1CadastroBebidas.AutoSize = true;
            this.lblImagem1CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem1CadastroBebidas.Location = new System.Drawing.Point(249, 79);
            this.lblImagem1CadastroBebidas.Name = "lblImagem1CadastroBebidas";
            this.lblImagem1CadastroBebidas.Size = new System.Drawing.Size(77, 24);
            this.lblImagem1CadastroBebidas.TabIndex = 350;
            this.lblImagem1CadastroBebidas.Text = "Imagem";
            // 
            // txtNome8CadastroBebidas
            // 
            this.txtNome8CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome8CadastroBebidas.Location = new System.Drawing.Point(647, 283);
            this.txtNome8CadastroBebidas.Name = "txtNome8CadastroBebidas";
            this.txtNome8CadastroBebidas.Size = new System.Drawing.Size(168, 30);
            this.txtNome8CadastroBebidas.TabIndex = 347;
            // 
            // txtNome4CadastroBebidas
            // 
            this.txtNome4CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome4CadastroBebidas.Location = new System.Drawing.Point(40, 368);
            this.txtNome4CadastroBebidas.Name = "txtNome4CadastroBebidas";
            this.txtNome4CadastroBebidas.Size = new System.Drawing.Size(168, 30);
            this.txtNome4CadastroBebidas.TabIndex = 345;
            // 
            // txtNome7CadastroBebidas
            // 
            this.txtNome7CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome7CadastroBebidas.Location = new System.Drawing.Point(647, 206);
            this.txtNome7CadastroBebidas.Name = "txtNome7CadastroBebidas";
            this.txtNome7CadastroBebidas.Size = new System.Drawing.Size(168, 30);
            this.txtNome7CadastroBebidas.TabIndex = 343;
            // 
            // txtNome3CadastroBebidas
            // 
            this.txtNome3CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome3CadastroBebidas.Location = new System.Drawing.Point(40, 286);
            this.txtNome3CadastroBebidas.Name = "txtNome3CadastroBebidas";
            this.txtNome3CadastroBebidas.Size = new System.Drawing.Size(168, 30);
            this.txtNome3CadastroBebidas.TabIndex = 341;
            // 
            // txtNome6CadastroBebidas
            // 
            this.txtNome6CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome6CadastroBebidas.Location = new System.Drawing.Point(647, 119);
            this.txtNome6CadastroBebidas.Name = "txtNome6CadastroBebidas";
            this.txtNome6CadastroBebidas.Size = new System.Drawing.Size(168, 30);
            this.txtNome6CadastroBebidas.TabIndex = 339;
            // 
            // txtNome2CadastroBebidas
            // 
            this.txtNome2CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome2CadastroBebidas.Location = new System.Drawing.Point(40, 202);
            this.txtNome2CadastroBebidas.Name = "txtNome2CadastroBebidas";
            this.txtNome2CadastroBebidas.Size = new System.Drawing.Size(168, 30);
            this.txtNome2CadastroBebidas.TabIndex = 337;
            // 
            // btnSalvarCadastroBebidas
            // 
            this.btnSalvarCadastroBebidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarCadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroBebidas.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSalvarCadastroBebidas.Location = new System.Drawing.Point(979, 547);
            this.btnSalvarCadastroBebidas.Name = "btnSalvarCadastroBebidas";
            this.btnSalvarCadastroBebidas.Size = new System.Drawing.Size(167, 55);
            this.btnSalvarCadastroBebidas.TabIndex = 336;
            this.btnSalvarCadastroBebidas.Text = "Salvar";
            this.btnSalvarCadastroBebidas.UseVisualStyleBackColor = false;
            // 
            // txtNome1CadastroBebidas
            // 
            this.txtNome1CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome1CadastroBebidas.Location = new System.Drawing.Point(40, 119);
            this.txtNome1CadastroBebidas.Name = "txtNome1CadastroBebidas";
            this.txtNome1CadastroBebidas.Size = new System.Drawing.Size(168, 30);
            this.txtNome1CadastroBebidas.TabIndex = 334;
            // 
            // lblTituloCadastroBebidas
            // 
            this.lblTituloCadastroBebidas.AutoSize = true;
            this.lblTituloCadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroBebidas.Location = new System.Drawing.Point(490, 20);
            this.lblTituloCadastroBebidas.Name = "lblTituloCadastroBebidas";
            this.lblTituloCadastroBebidas.Size = new System.Drawing.Size(231, 31);
            this.lblTituloCadastroBebidas.TabIndex = 333;
            this.lblTituloCadastroBebidas.Text = "Cadastro de Bebidas";
            // 
            // openFileCadastroBebida1
            // 
            this.openFileCadastroBebida1.FileName = "openFileCadastroBebida1";
            // 
            // openFileCadastroBebida2
            // 
            this.openFileCadastroBebida2.FileName = "openFileCadastroBebida2";
            // 
            // openFileCadastroBebida3
            // 
            this.openFileCadastroBebida3.FileName = "openFileCadastroBebida3";
            // 
            // openFileCadastroBebida4
            // 
            this.openFileCadastroBebida4.FileName = "openFileCadastroBebida4";
            // 
            // openFileCadastroBebida5
            // 
            this.openFileCadastroBebida5.FileName = "openFileCadastroBebida5";
            // 
            // openFileCadastroBebida6
            // 
            this.openFileCadastroBebida6.FileName = "openFileCadastroBebida6";
            // 
            // openFileCadastroBebida7
            // 
            this.openFileCadastroBebida7.FileName = "openFileCadastroBebida7";
            // 
            // openFileCadastroBebida8
            // 
            this.openFileCadastroBebida8.FileName = "openFileCadastroBebida8";
            // 
            // openFileCadastroBebida9
            // 
            this.openFileCadastroBebida9.FileName = "openFileCadastroBebida9";
            // 
            // openFileCadastroBebida10
            // 
            this.openFileCadastroBebida10.FileName = "openFileCadastroBebida10";
            // 
            // btnUploadImagem1CadastroBebidas
            // 
            this.btnUploadImagem1CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem1CadastroBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem1CadastroBebidas.Location = new System.Drawing.Point(229, 119);
            this.btnUploadImagem1CadastroBebidas.Name = "btnUploadImagem1CadastroBebidas";
            this.btnUploadImagem1CadastroBebidas.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem1CadastroBebidas.TabIndex = 392;
            this.btnUploadImagem1CadastroBebidas.Text = "Upload";
            this.btnUploadImagem1CadastroBebidas.UseVisualStyleBackColor = true;
            this.btnUploadImagem1CadastroBebidas.Click += new System.EventHandler(this.btnUploadImagemCadastroBebida1_Click);
            // 
            // btnUploadImagem2CadastroBebidas
            // 
            this.btnUploadImagem2CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem2CadastroBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem2CadastroBebidas.Location = new System.Drawing.Point(229, 200);
            this.btnUploadImagem2CadastroBebidas.Name = "btnUploadImagem2CadastroBebidas";
            this.btnUploadImagem2CadastroBebidas.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem2CadastroBebidas.TabIndex = 393;
            this.btnUploadImagem2CadastroBebidas.Text = "Upload";
            this.btnUploadImagem2CadastroBebidas.UseVisualStyleBackColor = true;
            this.btnUploadImagem2CadastroBebidas.Click += new System.EventHandler(this.btnUploadImagemCadastroBebida2_Click);
            // 
            // btnUploadImagem3CadastroBebidas
            // 
            this.btnUploadImagem3CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem3CadastroBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem3CadastroBebidas.Location = new System.Drawing.Point(229, 286);
            this.btnUploadImagem3CadastroBebidas.Name = "btnUploadImagem3CadastroBebidas";
            this.btnUploadImagem3CadastroBebidas.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem3CadastroBebidas.TabIndex = 394;
            this.btnUploadImagem3CadastroBebidas.Text = "Upload";
            this.btnUploadImagem3CadastroBebidas.UseVisualStyleBackColor = true;
            this.btnUploadImagem3CadastroBebidas.Click += new System.EventHandler(this.btnUploadImagemCadastroBebida3_Click);
            // 
            // btnUploadImagem4CadastroBebidas
            // 
            this.btnUploadImagem4CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem4CadastroBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem4CadastroBebidas.Location = new System.Drawing.Point(229, 368);
            this.btnUploadImagem4CadastroBebidas.Name = "btnUploadImagem4CadastroBebidas";
            this.btnUploadImagem4CadastroBebidas.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem4CadastroBebidas.TabIndex = 395;
            this.btnUploadImagem4CadastroBebidas.Text = "Upload";
            this.btnUploadImagem4CadastroBebidas.UseVisualStyleBackColor = true;
            this.btnUploadImagem4CadastroBebidas.Click += new System.EventHandler(this.btnUploadImagemCadastroBebida4_Click);
            // 
            // btnUploadImagem5CadastroBebidas
            // 
            this.btnUploadImagem5CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem5CadastroBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem5CadastroBebidas.Location = new System.Drawing.Point(229, 450);
            this.btnUploadImagem5CadastroBebidas.Name = "btnUploadImagem5CadastroBebidas";
            this.btnUploadImagem5CadastroBebidas.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem5CadastroBebidas.TabIndex = 396;
            this.btnUploadImagem5CadastroBebidas.Text = "Upload";
            this.btnUploadImagem5CadastroBebidas.UseVisualStyleBackColor = true;
            this.btnUploadImagem5CadastroBebidas.Click += new System.EventHandler(this.btnUploadImagemCadastroBebida5_Click);
            // 
            // btnUploadImagem10CadastroBebidas
            // 
            this.btnUploadImagem10CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem10CadastroBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem10CadastroBebidas.Location = new System.Drawing.Point(837, 450);
            this.btnUploadImagem10CadastroBebidas.Name = "btnUploadImagem10CadastroBebidas";
            this.btnUploadImagem10CadastroBebidas.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem10CadastroBebidas.TabIndex = 401;
            this.btnUploadImagem10CadastroBebidas.Text = "Upload";
            this.btnUploadImagem10CadastroBebidas.UseVisualStyleBackColor = true;
            this.btnUploadImagem10CadastroBebidas.Click += new System.EventHandler(this.btnUploadImagemCadastroBebida10_Click);
            // 
            // btnUploadImage91CadastroBebidas
            // 
            this.btnUploadImage91CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage91CadastroBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImage91CadastroBebidas.Location = new System.Drawing.Point(837, 368);
            this.btnUploadImage91CadastroBebidas.Name = "btnUploadImage91CadastroBebidas";
            this.btnUploadImage91CadastroBebidas.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImage91CadastroBebidas.TabIndex = 400;
            this.btnUploadImage91CadastroBebidas.Text = "Upload";
            this.btnUploadImage91CadastroBebidas.UseVisualStyleBackColor = true;
            this.btnUploadImage91CadastroBebidas.Click += new System.EventHandler(this.btnUploadImagemCadastroBebida9_Click);
            // 
            // btnUploadImagem8CadastroBebidas
            // 
            this.btnUploadImagem8CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem8CadastroBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem8CadastroBebidas.Location = new System.Drawing.Point(837, 286);
            this.btnUploadImagem8CadastroBebidas.Name = "btnUploadImagem8CadastroBebidas";
            this.btnUploadImagem8CadastroBebidas.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem8CadastroBebidas.TabIndex = 399;
            this.btnUploadImagem8CadastroBebidas.Text = "Upload";
            this.btnUploadImagem8CadastroBebidas.UseVisualStyleBackColor = true;
            this.btnUploadImagem8CadastroBebidas.Click += new System.EventHandler(this.btnUploadImagemCadastroBebida8_Click);
            // 
            // btnUploadImagem7CadastroBebidas
            // 
            this.btnUploadImagem7CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem7CadastroBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem7CadastroBebidas.Location = new System.Drawing.Point(837, 200);
            this.btnUploadImagem7CadastroBebidas.Name = "btnUploadImagem7CadastroBebidas";
            this.btnUploadImagem7CadastroBebidas.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem7CadastroBebidas.TabIndex = 398;
            this.btnUploadImagem7CadastroBebidas.Text = "Upload";
            this.btnUploadImagem7CadastroBebidas.UseVisualStyleBackColor = true;
            this.btnUploadImagem7CadastroBebidas.Click += new System.EventHandler(this.btnUploadImagemCadastroBebida7_Click);
            // 
            // btnUploadImagem6CadastroBebidas
            // 
            this.btnUploadImagem6CadastroBebidas.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagem6CadastroBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagem6CadastroBebidas.Location = new System.Drawing.Point(837, 119);
            this.btnUploadImagem6CadastroBebidas.Name = "btnUploadImagem6CadastroBebidas";
            this.btnUploadImagem6CadastroBebidas.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagem6CadastroBebidas.TabIndex = 397;
            this.btnUploadImagem6CadastroBebidas.Text = "Upload";
            this.btnUploadImagem6CadastroBebidas.UseVisualStyleBackColor = true;
            this.btnUploadImagem6CadastroBebidas.Click += new System.EventHandler(this.btnUploadImagemCadastroBebida6_Click);
            // 
            // CadastroBebidas
            // 
            this.ClientSize = new System.Drawing.Size(1185, 617);
            this.Controls.Add(this.btnUploadImagem10CadastroBebidas);
            this.Controls.Add(this.btnUploadImage91CadastroBebidas);
            this.Controls.Add(this.btnUploadImagem8CadastroBebidas);
            this.Controls.Add(this.btnUploadImagem7CadastroBebidas);
            this.Controls.Add(this.btnUploadImagem6CadastroBebidas);
            this.Controls.Add(this.btnUploadImagem5CadastroBebidas);
            this.Controls.Add(this.btnUploadImagem4CadastroBebidas);
            this.Controls.Add(this.btnUploadImagem3CadastroBebidas);
            this.Controls.Add(this.btnUploadImagem2CadastroBebidas);
            this.Controls.Add(this.btnUploadImagem1CadastroBebidas);
            this.Controls.Add(this.txtNome9CadastroBebidas);
            this.Controls.Add(this.txtPreco9CadastroBebidas);
            this.Controls.Add(this.txtCusto9CadastroBebidas);
            this.Controls.Add(this.txtPreco8CadastroBebidas);
            this.Controls.Add(this.txtCusto8CadastroBebidas);
            this.Controls.Add(this.txtPreco7CadastroBebidas);
            this.Controls.Add(this.txtCusto7CadastroBebidas);
            this.Controls.Add(this.txtPreco10CadastroBebidas);
            this.Controls.Add(this.txtCusto10CadastroBebidas);
            this.Controls.Add(this.txtNome10CadastroBebidas);
            this.Controls.Add(this.txtPreco4CadastroBebidas);
            this.Controls.Add(this.txtCusto4CadastroBebidas);
            this.Controls.Add(this.txtPreco3CadastroBebidas);
            this.Controls.Add(this.txtCusto3CadastroBebidas);
            this.Controls.Add(this.txtPreco2CadastroBebidas);
            this.Controls.Add(this.txtCusto2CadastroBebidas);
            this.Controls.Add(this.txtPreco5CadastroBebidas);
            this.Controls.Add(this.txtCusto5CadastroBebidas);
            this.Controls.Add(this.txtNome5CadastroBebidas);
            this.Controls.Add(this.txtPreco6CadastroBebidas);
            this.Controls.Add(this.txtCusto6CadastroBebidas);
            this.Controls.Add(this.lblNome2CadastroBebidas);
            this.Controls.Add(this.lblPreco2CadastroBebidas);
            this.Controls.Add(this.lblCusto2CadastroBebidas);
            this.Controls.Add(this.lblImagem2CadastroBebidas);
            this.Controls.Add(this.lblNome1CadastroBebidas);
            this.Controls.Add(this.lblPreco1CadastroBebidas);
            this.Controls.Add(this.txtPreco1CadastroBebidas);
            this.Controls.Add(this.lblCusto1CadastroBebidas);
            this.Controls.Add(this.txtCusto1CadastroBebidas);
            this.Controls.Add(this.lblImagem1CadastroBebidas);
            this.Controls.Add(this.txtNome8CadastroBebidas);
            this.Controls.Add(this.txtNome4CadastroBebidas);
            this.Controls.Add(this.txtNome7CadastroBebidas);
            this.Controls.Add(this.txtNome3CadastroBebidas);
            this.Controls.Add(this.txtNome6CadastroBebidas);
            this.Controls.Add(this.txtNome2CadastroBebidas);
            this.Controls.Add(this.btnSalvarCadastroBebidas);
            this.Controls.Add(this.txtNome1CadastroBebidas);
            this.Controls.Add(this.lblTituloCadastroBebidas);
            this.Name = "CadastroBebidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnUploadImagemCadastroBebida1_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroBebida1.InitialDirectory = "c:\\";
            openFileCadastroBebida1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroBebida1.FilterIndex = 1;
            openFileCadastroBebida1.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroBebida1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroBebida1.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroBebida2_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroBebida2.InitialDirectory = "c:\\";
            openFileCadastroBebida2.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroBebida2.FilterIndex = 1;
            openFileCadastroBebida2.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroBebida2.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroBebida2.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroBebida3_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroBebida3.InitialDirectory = "c:\\";
            openFileCadastroBebida3.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroBebida3.FilterIndex = 1;
            openFileCadastroBebida3.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroBebida3.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroBebida3.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroBebida4_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroBebida4.InitialDirectory = "c:\\";
            openFileCadastroBebida4.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroBebida4.FilterIndex = 1;
            openFileCadastroBebida4.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroBebida4.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroBebida4.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroBebida5_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroBebida5.InitialDirectory = "c:\\";
            openFileCadastroBebida5.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroBebida5.FilterIndex = 1;
            openFileCadastroBebida5.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroBebida5.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroBebida5.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroBebida6_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroBebida6.InitialDirectory = "c:\\";
            openFileCadastroBebida6.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroBebida6.FilterIndex = 1;
            openFileCadastroBebida6.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroBebida6.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroBebida6.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroBebida7_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroBebida7.InitialDirectory = "c:\\";
            openFileCadastroBebida7.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroBebida7.FilterIndex = 1;
            openFileCadastroBebida7.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroBebida7.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroBebida7.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroBebida8_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroBebida8.InitialDirectory = "c:\\";
            openFileCadastroBebida8.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroBebida8.FilterIndex = 1;
            openFileCadastroBebida8.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroBebida8.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroBebida8.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroBebida9_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroBebida9.InitialDirectory = "c:\\";
            openFileCadastroBebida9.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroBebida9.FilterIndex = 1;
            openFileCadastroBebida9.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroBebida9.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroBebida9.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        private void btnUploadImagemCadastroBebida10_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroBebida10.InitialDirectory = "c:\\";
            openFileCadastroBebida10.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroBebida10.FilterIndex = 1;
            openFileCadastroBebida10.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroBebida10.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroBebida10.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

       
    }
}
