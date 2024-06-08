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
    public partial class CadastroIngredientes : Form
    {
        private TextBox txtNome9CadastroIngredientes;
        private TextBox txtPreco9CadastroIngredientes;
        private TextBox txtCusto9CadastroIngredientes;
        private TextBox txtPreco8CadastroIngredientes;
        private TextBox txtCusto8CadastroIngredientes;
        private TextBox txtPreco7CadastroIngredientes;
        private TextBox txtCusto7CadastroIngredientes;
        private TextBox txtPreco10CadastroIngredientes;
        private TextBox txtCusto10CadastroIngredientes;
        private TextBox txtNome10CadastroIngredientes;
        private TextBox txtPreco4CadastroIngredientes;
        private TextBox txtCusto4CadastroIngredientes;
        private TextBox txtPreco3CadastroIngredientes;
        private TextBox txtCusto3CadastroIngredientes;
        private TextBox txtPreco2CadastroIngredientes;
        private TextBox txtCusto2CadastroIngredientes;
        private TextBox txtPreco5CadastroIngredientes;
        private TextBox txtCusto5CadastroIngredientes;
        private TextBox txtNome5CadastroIngredientes;
        private TextBox txtPreco6CadastroIngredientes;
        private TextBox txtCusto6CadastroIngredientes;
        private Label lblNome2CadastroIngredientes;
        private Label lblPreco2CadastroIngredientes;
        private Label lblCusto2CadastroIngredientes;
        private Label lblNome1CadastroIngredientes;
        private Label lblPreco1CadastroIngredientes;
        private TextBox txtPreco1CadastroIngredientes;
        private Label lblCusto1CadastroIngredientes;
        private TextBox txtCusto1CadastroIngredientes;
        private TextBox txtNome8CadastroIngredientes;
        private TextBox txtNome4CadastroIngredientes;
        private TextBox txtNome7CadastroIngredientes;
        private TextBox txtNome3CadastroIngredientes;
        private TextBox txtNome6CadastroIngredientes;
        private TextBox txtNome2CadastroIngredientes;
        private Button btnSalvarCadastroIngredientes;
        private TextBox txtNomel1CadastroIngredientes;
        private TextBox txtNome19CadastroIngredientesv;
        private TextBox txtPreco19CadastroIngredientes;
        private TextBox txtCusto19CadastroIngredientes;
        private TextBox txtPreco18CadastroIngredientes;
        private TextBox txtCusto18CadastroIngredientes;
        private TextBox txtPreco17CadastroIngredientes;
        private TextBox txtCusto17CadastroIngredientes;
        private TextBox txtPreco20CadastroIngredientes;
        private TextBox txtCusto20CadastroIngredientes;
        private TextBox txtNome20CadastroIngredientes;
        private TextBox txtPreco14CadastroIngredientes;
        private TextBox txtCusto14CadastroIngredientes;
        private TextBox txtPreco13CadastroIngredientes;
        private TextBox txtCusto13CadastroIngredientes;
        private TextBox txtPreco12CadastroIngredientes;
        private TextBox txtCusto12CadastroIngredientes;
        private TextBox txtPreco15CadastroIngredientes;
        private TextBox txtCusto15CadastroIngredientes;
        private TextBox txtNome15CadastroIngredientes;
        private TextBox txtPreco16CadastroIngredientes;
        private TextBox txtCusto16CadastroIngredientes;
        private TextBox txtPreco11CadastroIngredientes;
        private TextBox txtCusto11CadastroIngredientes;
        private TextBox txtNome18CadastroIngredientes;
        private TextBox txtNome14CadastroIngredientes;
        private TextBox txtNome17CadastroIngredientes;
        private TextBox txtNome13CadastroIngredientes;
        private TextBox txtNome16CadastroIngredientes;
        private TextBox txtNome12CadastroIngredientes;
        private TextBox txtNome11CadastroIngredientes;
        private Label lblTituloCadastroAdicionais;

        public CadastroIngredientes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtNome9CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco9CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto9CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco8CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto8CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco7CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto7CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco10CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto10CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome10CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco4CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto4CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco3CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto3CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco2CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto2CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco5CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto5CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome5CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco6CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto6CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.lblNome2CadastroIngredientes = new System.Windows.Forms.Label();
            this.lblPreco2CadastroIngredientes = new System.Windows.Forms.Label();
            this.lblCusto2CadastroIngredientes = new System.Windows.Forms.Label();
            this.lblNome1CadastroIngredientes = new System.Windows.Forms.Label();
            this.lblPreco1CadastroIngredientes = new System.Windows.Forms.Label();
            this.txtPreco1CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.lblCusto1CadastroIngredientes = new System.Windows.Forms.Label();
            this.txtCusto1CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome8CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome4CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome7CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome3CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome6CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome2CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroIngredientes = new System.Windows.Forms.Button();
            this.txtNomel1CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.lblTituloCadastroAdicionais = new System.Windows.Forms.Label();
            this.txtNome19CadastroIngredientesv = new System.Windows.Forms.TextBox();
            this.txtPreco19CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto19CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco18CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto18CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco17CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto17CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco20CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto20CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome20CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco14CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto14CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco13CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto13CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco12CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto12CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco15CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto15CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome15CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco16CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto16CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtPreco11CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtCusto11CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome18CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome14CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome17CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome13CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome16CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome12CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.txtNome11CadastroIngredientes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome9CadastroIngredientes
            // 
            this.txtNome9CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome9CadastroIngredientes.Location = new System.Drawing.Point(21, 495);
            this.txtNome9CadastroIngredientes.Name = "txtNome9CadastroIngredientes";
            this.txtNome9CadastroIngredientes.Size = new System.Drawing.Size(314, 30);
            this.txtNome9CadastroIngredientes.TabIndex = 383;
            // 
            // txtPreco9CadastroIngredientes
            // 
            this.txtPreco9CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco9CadastroIngredientes.Location = new System.Drawing.Point(465, 495);
            this.txtPreco9CadastroIngredientes.Name = "txtPreco9CadastroIngredientes";
            this.txtPreco9CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco9CadastroIngredientes.TabIndex = 382;
            // 
            // txtCusto9CadastroIngredientes
            // 
            this.txtCusto9CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto9CadastroIngredientes.Location = new System.Drawing.Point(355, 495);
            this.txtCusto9CadastroIngredientes.Name = "txtCusto9CadastroIngredientes";
            this.txtCusto9CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto9CadastroIngredientes.TabIndex = 381;
            // 
            // txtPreco8CadastroIngredientes
            // 
            this.txtPreco8CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco8CadastroIngredientes.Location = new System.Drawing.Point(465, 452);
            this.txtPreco8CadastroIngredientes.Name = "txtPreco8CadastroIngredientes";
            this.txtPreco8CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco8CadastroIngredientes.TabIndex = 380;
            // 
            // txtCusto8CadastroIngredientes
            // 
            this.txtCusto8CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto8CadastroIngredientes.Location = new System.Drawing.Point(355, 452);
            this.txtCusto8CadastroIngredientes.Name = "txtCusto8CadastroIngredientes";
            this.txtCusto8CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto8CadastroIngredientes.TabIndex = 379;
            // 
            // txtPreco7CadastroIngredientes
            // 
            this.txtPreco7CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco7CadastroIngredientes.Location = new System.Drawing.Point(465, 403);
            this.txtPreco7CadastroIngredientes.Name = "txtPreco7CadastroIngredientes";
            this.txtPreco7CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco7CadastroIngredientes.TabIndex = 378;
            // 
            // txtCusto7CadastroIngredientes
            // 
            this.txtCusto7CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto7CadastroIngredientes.Location = new System.Drawing.Point(355, 403);
            this.txtCusto7CadastroIngredientes.Name = "txtCusto7CadastroIngredientes";
            this.txtCusto7CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto7CadastroIngredientes.TabIndex = 377;
            // 
            // txtPreco10CadastroIngredientes
            // 
            this.txtPreco10CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco10CadastroIngredientes.Location = new System.Drawing.Point(465, 548);
            this.txtPreco10CadastroIngredientes.Name = "txtPreco10CadastroIngredientes";
            this.txtPreco10CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco10CadastroIngredientes.TabIndex = 376;
            // 
            // txtCusto10CadastroIngredientes
            // 
            this.txtCusto10CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto10CadastroIngredientes.Location = new System.Drawing.Point(355, 548);
            this.txtCusto10CadastroIngredientes.Name = "txtCusto10CadastroIngredientes";
            this.txtCusto10CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto10CadastroIngredientes.TabIndex = 375;
            // 
            // txtNome10CadastroIngredientes
            // 
            this.txtNome10CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome10CadastroIngredientes.Location = new System.Drawing.Point(21, 548);
            this.txtNome10CadastroIngredientes.Name = "txtNome10CadastroIngredientes";
            this.txtNome10CadastroIngredientes.Size = new System.Drawing.Size(314, 30);
            this.txtNome10CadastroIngredientes.TabIndex = 374;
            // 
            // txtPreco4CadastroIngredientes
            // 
            this.txtPreco4CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco4CadastroIngredientes.Location = new System.Drawing.Point(465, 265);
            this.txtPreco4CadastroIngredientes.Name = "txtPreco4CadastroIngredientes";
            this.txtPreco4CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco4CadastroIngredientes.TabIndex = 373;
            // 
            // txtCusto4CadastroIngredientes
            // 
            this.txtCusto4CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto4CadastroIngredientes.Location = new System.Drawing.Point(355, 265);
            this.txtCusto4CadastroIngredientes.Name = "txtCusto4CadastroIngredientes";
            this.txtCusto4CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto4CadastroIngredientes.TabIndex = 372;
            // 
            // txtPreco3CadastroIngredientes
            // 
            this.txtPreco3CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco3CadastroIngredientes.Location = new System.Drawing.Point(465, 216);
            this.txtPreco3CadastroIngredientes.Name = "txtPreco3CadastroIngredientes";
            this.txtPreco3CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco3CadastroIngredientes.TabIndex = 371;
            // 
            // txtCusto3CadastroIngredientes
            // 
            this.txtCusto3CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto3CadastroIngredientes.Location = new System.Drawing.Point(355, 216);
            this.txtCusto3CadastroIngredientes.Name = "txtCusto3CadastroIngredientes";
            this.txtCusto3CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto3CadastroIngredientes.TabIndex = 370;
            // 
            // txtPreco2CadastroIngredientes
            // 
            this.txtPreco2CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco2CadastroIngredientes.Location = new System.Drawing.Point(465, 167);
            this.txtPreco2CadastroIngredientes.Name = "txtPreco2CadastroIngredientes";
            this.txtPreco2CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco2CadastroIngredientes.TabIndex = 369;
            // 
            // txtCusto2CadastroIngredientes
            // 
            this.txtCusto2CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto2CadastroIngredientes.Location = new System.Drawing.Point(355, 167);
            this.txtCusto2CadastroIngredientes.Name = "txtCusto2CadastroIngredientes";
            this.txtCusto2CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto2CadastroIngredientes.TabIndex = 368;
            // 
            // txtPreco5CadastroIngredientes
            // 
            this.txtPreco5CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco5CadastroIngredientes.Location = new System.Drawing.Point(465, 312);
            this.txtPreco5CadastroIngredientes.Name = "txtPreco5CadastroIngredientes";
            this.txtPreco5CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco5CadastroIngredientes.TabIndex = 367;
            // 
            // txtCusto5CadastroIngredientes
            // 
            this.txtCusto5CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto5CadastroIngredientes.Location = new System.Drawing.Point(355, 312);
            this.txtCusto5CadastroIngredientes.Name = "txtCusto5CadastroIngredientes";
            this.txtCusto5CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto5CadastroIngredientes.TabIndex = 366;
            // 
            // txtNome5CadastroIngredientes
            // 
            this.txtNome5CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome5CadastroIngredientes.Location = new System.Drawing.Point(21, 312);
            this.txtNome5CadastroIngredientes.Name = "txtNome5CadastroIngredientes";
            this.txtNome5CadastroIngredientes.Size = new System.Drawing.Size(316, 30);
            this.txtNome5CadastroIngredientes.TabIndex = 365;
            // 
            // txtPreco6CadastroIngredientes
            // 
            this.txtPreco6CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco6CadastroIngredientes.Location = new System.Drawing.Point(465, 360);
            this.txtPreco6CadastroIngredientes.Name = "txtPreco6CadastroIngredientes";
            this.txtPreco6CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco6CadastroIngredientes.TabIndex = 364;
            // 
            // txtCusto6CadastroIngredientes
            // 
            this.txtCusto6CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto6CadastroIngredientes.Location = new System.Drawing.Point(355, 360);
            this.txtCusto6CadastroIngredientes.Name = "txtCusto6CadastroIngredientes";
            this.txtCusto6CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto6CadastroIngredientes.TabIndex = 363;
            // 
            // lblNome2CadastroIngredientes
            // 
            this.lblNome2CadastroIngredientes.AutoSize = true;
            this.lblNome2CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2CadastroIngredientes.Location = new System.Drawing.Point(761, 80);
            this.lblNome2CadastroIngredientes.Name = "lblNome2CadastroIngredientes";
            this.lblNome2CadastroIngredientes.Size = new System.Drawing.Size(60, 24);
            this.lblNome2CadastroIngredientes.TabIndex = 362;
            this.lblNome2CadastroIngredientes.Text = "Nome";
            // 
            // lblPreco2CadastroIngredientes
            // 
            this.lblPreco2CadastroIngredientes.AutoSize = true;
            this.lblPreco2CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco2CadastroIngredientes.Location = new System.Drawing.Point(1066, 80);
            this.lblPreco2CadastroIngredientes.Name = "lblPreco2CadastroIngredientes";
            this.lblPreco2CadastroIngredientes.Size = new System.Drawing.Size(82, 24);
            this.lblPreco2CadastroIngredientes.TabIndex = 361;
            this.lblPreco2CadastroIngredientes.Text = "Preço ($)";
            // 
            // lblCusto2CadastroIngredientes
            // 
            this.lblCusto2CadastroIngredientes.AutoSize = true;
            this.lblCusto2CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto2CadastroIngredientes.Location = new System.Drawing.Point(956, 80);
            this.lblCusto2CadastroIngredientes.Name = "lblCusto2CadastroIngredientes";
            this.lblCusto2CadastroIngredientes.Size = new System.Drawing.Size(86, 24);
            this.lblCusto2CadastroIngredientes.TabIndex = 360;
            this.lblCusto2CadastroIngredientes.Text = "Custo ($)";
            // 
            // lblNome1CadastroIngredientes
            // 
            this.lblNome1CadastroIngredientes.AutoSize = true;
            this.lblNome1CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1CadastroIngredientes.Location = new System.Drawing.Point(143, 80);
            this.lblNome1CadastroIngredientes.Name = "lblNome1CadastroIngredientes";
            this.lblNome1CadastroIngredientes.Size = new System.Drawing.Size(60, 24);
            this.lblNome1CadastroIngredientes.TabIndex = 358;
            this.lblNome1CadastroIngredientes.Text = "Nome";
            // 
            // lblPreco1CadastroIngredientes
            // 
            this.lblPreco1CadastroIngredientes.AutoSize = true;
            this.lblPreco1CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco1CadastroIngredientes.Location = new System.Drawing.Point(461, 80);
            this.lblPreco1CadastroIngredientes.Name = "lblPreco1CadastroIngredientes";
            this.lblPreco1CadastroIngredientes.Size = new System.Drawing.Size(82, 24);
            this.lblPreco1CadastroIngredientes.TabIndex = 357;
            this.lblPreco1CadastroIngredientes.Text = "Preço ($)";
            // 
            // txtPreco1CadastroIngredientes
            // 
            this.txtPreco1CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco1CadastroIngredientes.Location = new System.Drawing.Point(465, 120);
            this.txtPreco1CadastroIngredientes.Name = "txtPreco1CadastroIngredientes";
            this.txtPreco1CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco1CadastroIngredientes.TabIndex = 356;
            // 
            // lblCusto1CadastroIngredientes
            // 
            this.lblCusto1CadastroIngredientes.AutoSize = true;
            this.lblCusto1CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto1CadastroIngredientes.Location = new System.Drawing.Point(351, 80);
            this.lblCusto1CadastroIngredientes.Name = "lblCusto1CadastroIngredientes";
            this.lblCusto1CadastroIngredientes.Size = new System.Drawing.Size(86, 24);
            this.lblCusto1CadastroIngredientes.TabIndex = 355;
            this.lblCusto1CadastroIngredientes.Text = "Custo ($)";
            // 
            // txtCusto1CadastroIngredientes
            // 
            this.txtCusto1CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto1CadastroIngredientes.Location = new System.Drawing.Point(355, 120);
            this.txtCusto1CadastroIngredientes.Name = "txtCusto1CadastroIngredientes";
            this.txtCusto1CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto1CadastroIngredientes.TabIndex = 354;
            // 
            // txtNome8CadastroIngredientes
            // 
            this.txtNome8CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome8CadastroIngredientes.Location = new System.Drawing.Point(21, 449);
            this.txtNome8CadastroIngredientes.Name = "txtNome8CadastroIngredientes";
            this.txtNome8CadastroIngredientes.Size = new System.Drawing.Size(314, 30);
            this.txtNome8CadastroIngredientes.TabIndex = 352;
            // 
            // txtNome4CadastroIngredientes
            // 
            this.txtNome4CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome4CadastroIngredientes.Location = new System.Drawing.Point(21, 264);
            this.txtNome4CadastroIngredientes.Name = "txtNome4CadastroIngredientes";
            this.txtNome4CadastroIngredientes.Size = new System.Drawing.Size(316, 30);
            this.txtNome4CadastroIngredientes.TabIndex = 351;
            // 
            // txtNome7CadastroIngredientes
            // 
            this.txtNome7CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome7CadastroIngredientes.Location = new System.Drawing.Point(21, 407);
            this.txtNome7CadastroIngredientes.Name = "txtNome7CadastroIngredientes";
            this.txtNome7CadastroIngredientes.Size = new System.Drawing.Size(314, 30);
            this.txtNome7CadastroIngredientes.TabIndex = 350;
            // 
            // txtNome3CadastroIngredientes
            // 
            this.txtNome3CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome3CadastroIngredientes.Location = new System.Drawing.Point(21, 216);
            this.txtNome3CadastroIngredientes.Name = "txtNome3CadastroIngredientes";
            this.txtNome3CadastroIngredientes.Size = new System.Drawing.Size(316, 30);
            this.txtNome3CadastroIngredientes.TabIndex = 349;
            // 
            // txtNome6CadastroIngredientes
            // 
            this.txtNome6CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome6CadastroIngredientes.Location = new System.Drawing.Point(21, 360);
            this.txtNome6CadastroIngredientes.Name = "txtNome6CadastroIngredientes";
            this.txtNome6CadastroIngredientes.Size = new System.Drawing.Size(314, 30);
            this.txtNome6CadastroIngredientes.TabIndex = 348;
            // 
            // txtNome2CadastroIngredientes
            // 
            this.txtNome2CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome2CadastroIngredientes.Location = new System.Drawing.Point(21, 167);
            this.txtNome2CadastroIngredientes.Name = "txtNome2CadastroIngredientes";
            this.txtNome2CadastroIngredientes.Size = new System.Drawing.Size(316, 30);
            this.txtNome2CadastroIngredientes.TabIndex = 347;
            // 
            // btnSalvarCadastroIngredientes
            // 
            this.btnSalvarCadastroIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarCadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroIngredientes.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSalvarCadastroIngredientes.Location = new System.Drawing.Point(981, 606);
            this.btnSalvarCadastroIngredientes.Name = "btnSalvarCadastroIngredientes";
            this.btnSalvarCadastroIngredientes.Size = new System.Drawing.Size(167, 55);
            this.btnSalvarCadastroIngredientes.TabIndex = 346;
            this.btnSalvarCadastroIngredientes.Text = "Salvar";
            this.btnSalvarCadastroIngredientes.UseVisualStyleBackColor = false;
            // 
            // txtNomel1CadastroIngredientes
            // 
            this.txtNomel1CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomel1CadastroIngredientes.Location = new System.Drawing.Point(21, 120);
            this.txtNomel1CadastroIngredientes.Name = "txtNomel1CadastroIngredientes";
            this.txtNomel1CadastroIngredientes.Size = new System.Drawing.Size(316, 30);
            this.txtNomel1CadastroIngredientes.TabIndex = 345;
            // 
            // lblTituloCadastroAdicionais
            // 
            this.lblTituloCadastroAdicionais.AutoSize = true;
            this.lblTituloCadastroAdicionais.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroAdicionais.Location = new System.Drawing.Point(471, 21);
            this.lblTituloCadastroAdicionais.Name = "lblTituloCadastroAdicionais";
            this.lblTituloCadastroAdicionais.Size = new System.Drawing.Size(281, 31);
            this.lblTituloCadastroAdicionais.TabIndex = 344;
            this.lblTituloCadastroAdicionais.Text = "Cadastro de Ingredientes";
            // 
            // txtNome19CadastroIngredientesv
            // 
            this.txtNome19CadastroIngredientesv.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome19CadastroIngredientesv.Location = new System.Drawing.Point(622, 495);
            this.txtNome19CadastroIngredientesv.Name = "txtNome19CadastroIngredientesv";
            this.txtNome19CadastroIngredientesv.Size = new System.Drawing.Size(314, 30);
            this.txtNome19CadastroIngredientesv.TabIndex = 413;
            // 
            // txtPreco19CadastroIngredientes
            // 
            this.txtPreco19CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco19CadastroIngredientes.Location = new System.Drawing.Point(1066, 495);
            this.txtPreco19CadastroIngredientes.Name = "txtPreco19CadastroIngredientes";
            this.txtPreco19CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco19CadastroIngredientes.TabIndex = 412;
            // 
            // txtCusto19CadastroIngredientes
            // 
            this.txtCusto19CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto19CadastroIngredientes.Location = new System.Drawing.Point(956, 495);
            this.txtCusto19CadastroIngredientes.Name = "txtCusto19CadastroIngredientes";
            this.txtCusto19CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto19CadastroIngredientes.TabIndex = 411;
            // 
            // txtPreco18CadastroIngredientes
            // 
            this.txtPreco18CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco18CadastroIngredientes.Location = new System.Drawing.Point(1066, 452);
            this.txtPreco18CadastroIngredientes.Name = "txtPreco18CadastroIngredientes";
            this.txtPreco18CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco18CadastroIngredientes.TabIndex = 410;
            // 
            // txtCusto18CadastroIngredientes
            // 
            this.txtCusto18CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto18CadastroIngredientes.Location = new System.Drawing.Point(956, 452);
            this.txtCusto18CadastroIngredientes.Name = "txtCusto18CadastroIngredientes";
            this.txtCusto18CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto18CadastroIngredientes.TabIndex = 409;
            // 
            // txtPreco17CadastroIngredientes
            // 
            this.txtPreco17CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco17CadastroIngredientes.Location = new System.Drawing.Point(1066, 403);
            this.txtPreco17CadastroIngredientes.Name = "txtPreco17CadastroIngredientes";
            this.txtPreco17CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco17CadastroIngredientes.TabIndex = 408;
            // 
            // txtCusto17CadastroIngredientes
            // 
            this.txtCusto17CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto17CadastroIngredientes.Location = new System.Drawing.Point(956, 403);
            this.txtCusto17CadastroIngredientes.Name = "txtCusto17CadastroIngredientes";
            this.txtCusto17CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto17CadastroIngredientes.TabIndex = 407;
            // 
            // txtPreco20CadastroIngredientes
            // 
            this.txtPreco20CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco20CadastroIngredientes.Location = new System.Drawing.Point(1066, 548);
            this.txtPreco20CadastroIngredientes.Name = "txtPreco20CadastroIngredientes";
            this.txtPreco20CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco20CadastroIngredientes.TabIndex = 406;
            // 
            // txtCusto20CadastroIngredientes
            // 
            this.txtCusto20CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto20CadastroIngredientes.Location = new System.Drawing.Point(956, 548);
            this.txtCusto20CadastroIngredientes.Name = "txtCusto20CadastroIngredientes";
            this.txtCusto20CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto20CadastroIngredientes.TabIndex = 405;
            // 
            // txtNome20CadastroIngredientes
            // 
            this.txtNome20CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome20CadastroIngredientes.Location = new System.Drawing.Point(622, 548);
            this.txtNome20CadastroIngredientes.Name = "txtNome20CadastroIngredientes";
            this.txtNome20CadastroIngredientes.Size = new System.Drawing.Size(314, 30);
            this.txtNome20CadastroIngredientes.TabIndex = 404;
            // 
            // txtPreco14CadastroIngredientes
            // 
            this.txtPreco14CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco14CadastroIngredientes.Location = new System.Drawing.Point(1066, 265);
            this.txtPreco14CadastroIngredientes.Name = "txtPreco14CadastroIngredientes";
            this.txtPreco14CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco14CadastroIngredientes.TabIndex = 403;
            // 
            // txtCusto14CadastroIngredientes
            // 
            this.txtCusto14CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto14CadastroIngredientes.Location = new System.Drawing.Point(956, 265);
            this.txtCusto14CadastroIngredientes.Name = "txtCusto14CadastroIngredientes";
            this.txtCusto14CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto14CadastroIngredientes.TabIndex = 402;
            // 
            // txtPreco13CadastroIngredientes
            // 
            this.txtPreco13CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco13CadastroIngredientes.Location = new System.Drawing.Point(1066, 216);
            this.txtPreco13CadastroIngredientes.Name = "txtPreco13CadastroIngredientes";
            this.txtPreco13CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco13CadastroIngredientes.TabIndex = 401;
            // 
            // txtCusto13CadastroIngredientes
            // 
            this.txtCusto13CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto13CadastroIngredientes.Location = new System.Drawing.Point(956, 216);
            this.txtCusto13CadastroIngredientes.Name = "txtCusto13CadastroIngredientes";
            this.txtCusto13CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto13CadastroIngredientes.TabIndex = 400;
            // 
            // txtPreco12CadastroIngredientes
            // 
            this.txtPreco12CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco12CadastroIngredientes.Location = new System.Drawing.Point(1066, 167);
            this.txtPreco12CadastroIngredientes.Name = "txtPreco12CadastroIngredientes";
            this.txtPreco12CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco12CadastroIngredientes.TabIndex = 399;
            // 
            // txtCusto12CadastroIngredientes
            // 
            this.txtCusto12CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto12CadastroIngredientes.Location = new System.Drawing.Point(956, 167);
            this.txtCusto12CadastroIngredientes.Name = "txtCusto12CadastroIngredientes";
            this.txtCusto12CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto12CadastroIngredientes.TabIndex = 398;
            // 
            // txtPreco15CadastroIngredientes
            // 
            this.txtPreco15CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco15CadastroIngredientes.Location = new System.Drawing.Point(1066, 312);
            this.txtPreco15CadastroIngredientes.Name = "txtPreco15CadastroIngredientes";
            this.txtPreco15CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco15CadastroIngredientes.TabIndex = 397;
            // 
            // txtCusto15CadastroIngredientes
            // 
            this.txtCusto15CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto15CadastroIngredientes.Location = new System.Drawing.Point(956, 312);
            this.txtCusto15CadastroIngredientes.Name = "txtCusto15CadastroIngredientes";
            this.txtCusto15CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto15CadastroIngredientes.TabIndex = 396;
            // 
            // txtNome15CadastroIngredientes
            // 
            this.txtNome15CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome15CadastroIngredientes.Location = new System.Drawing.Point(622, 312);
            this.txtNome15CadastroIngredientes.Name = "txtNome15CadastroIngredientes";
            this.txtNome15CadastroIngredientes.Size = new System.Drawing.Size(316, 30);
            this.txtNome15CadastroIngredientes.TabIndex = 395;
            // 
            // txtPreco16CadastroIngredientes
            // 
            this.txtPreco16CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco16CadastroIngredientes.Location = new System.Drawing.Point(1066, 360);
            this.txtPreco16CadastroIngredientes.Name = "txtPreco16CadastroIngredientes";
            this.txtPreco16CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco16CadastroIngredientes.TabIndex = 394;
            // 
            // txtCusto16CadastroIngredientes
            // 
            this.txtCusto16CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto16CadastroIngredientes.Location = new System.Drawing.Point(956, 360);
            this.txtCusto16CadastroIngredientes.Name = "txtCusto16CadastroIngredientes";
            this.txtCusto16CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto16CadastroIngredientes.TabIndex = 393;
            // 
            // txtPreco11CadastroIngredientes
            // 
            this.txtPreco11CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco11CadastroIngredientes.Location = new System.Drawing.Point(1066, 120);
            this.txtPreco11CadastroIngredientes.Name = "txtPreco11CadastroIngredientes";
            this.txtPreco11CadastroIngredientes.Size = new System.Drawing.Size(78, 30);
            this.txtPreco11CadastroIngredientes.TabIndex = 392;
            // 
            // txtCusto11CadastroIngredientes
            // 
            this.txtCusto11CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto11CadastroIngredientes.Location = new System.Drawing.Point(956, 120);
            this.txtCusto11CadastroIngredientes.Name = "txtCusto11CadastroIngredientes";
            this.txtCusto11CadastroIngredientes.Size = new System.Drawing.Size(82, 30);
            this.txtCusto11CadastroIngredientes.TabIndex = 391;
            // 
            // txtNome18CadastroIngredientes
            // 
            this.txtNome18CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome18CadastroIngredientes.Location = new System.Drawing.Point(622, 449);
            this.txtNome18CadastroIngredientes.Name = "txtNome18CadastroIngredientes";
            this.txtNome18CadastroIngredientes.Size = new System.Drawing.Size(314, 30);
            this.txtNome18CadastroIngredientes.TabIndex = 390;
            // 
            // txtNome14CadastroIngredientes
            // 
            this.txtNome14CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome14CadastroIngredientes.Location = new System.Drawing.Point(622, 264);
            this.txtNome14CadastroIngredientes.Name = "txtNome14CadastroIngredientes";
            this.txtNome14CadastroIngredientes.Size = new System.Drawing.Size(316, 30);
            this.txtNome14CadastroIngredientes.TabIndex = 389;
            // 
            // txtNome17CadastroIngredientes
            // 
            this.txtNome17CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome17CadastroIngredientes.Location = new System.Drawing.Point(622, 407);
            this.txtNome17CadastroIngredientes.Name = "txtNome17CadastroIngredientes";
            this.txtNome17CadastroIngredientes.Size = new System.Drawing.Size(314, 30);
            this.txtNome17CadastroIngredientes.TabIndex = 388;
            // 
            // txtNome13CadastroIngredientes
            // 
            this.txtNome13CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome13CadastroIngredientes.Location = new System.Drawing.Point(622, 216);
            this.txtNome13CadastroIngredientes.Name = "txtNome13CadastroIngredientes";
            this.txtNome13CadastroIngredientes.Size = new System.Drawing.Size(316, 30);
            this.txtNome13CadastroIngredientes.TabIndex = 387;
            // 
            // txtNome16CadastroIngredientes
            // 
            this.txtNome16CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome16CadastroIngredientes.Location = new System.Drawing.Point(622, 360);
            this.txtNome16CadastroIngredientes.Name = "txtNome16CadastroIngredientes";
            this.txtNome16CadastroIngredientes.Size = new System.Drawing.Size(314, 30);
            this.txtNome16CadastroIngredientes.TabIndex = 386;
            // 
            // txtNome12CadastroIngredientes
            // 
            this.txtNome12CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome12CadastroIngredientes.Location = new System.Drawing.Point(622, 167);
            this.txtNome12CadastroIngredientes.Name = "txtNome12CadastroIngredientes";
            this.txtNome12CadastroIngredientes.Size = new System.Drawing.Size(316, 30);
            this.txtNome12CadastroIngredientes.TabIndex = 385;
            // 
            // txtNome11CadastroIngredientes
            // 
            this.txtNome11CadastroIngredientes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome11CadastroIngredientes.Location = new System.Drawing.Point(622, 120);
            this.txtNome11CadastroIngredientes.Name = "txtNome11CadastroIngredientes";
            this.txtNome11CadastroIngredientes.Size = new System.Drawing.Size(316, 30);
            this.txtNome11CadastroIngredientes.TabIndex = 384;
            // 
            // CadastroIngredientes
            // 
            this.ClientSize = new System.Drawing.Size(1161, 679);
            this.Controls.Add(this.txtNome19CadastroIngredientesv);
            this.Controls.Add(this.txtPreco19CadastroIngredientes);
            this.Controls.Add(this.txtCusto19CadastroIngredientes);
            this.Controls.Add(this.txtPreco18CadastroIngredientes);
            this.Controls.Add(this.txtCusto18CadastroIngredientes);
            this.Controls.Add(this.txtPreco17CadastroIngredientes);
            this.Controls.Add(this.txtCusto17CadastroIngredientes);
            this.Controls.Add(this.txtPreco20CadastroIngredientes);
            this.Controls.Add(this.txtCusto20CadastroIngredientes);
            this.Controls.Add(this.txtNome20CadastroIngredientes);
            this.Controls.Add(this.txtPreco14CadastroIngredientes);
            this.Controls.Add(this.txtCusto14CadastroIngredientes);
            this.Controls.Add(this.txtPreco13CadastroIngredientes);
            this.Controls.Add(this.txtCusto13CadastroIngredientes);
            this.Controls.Add(this.txtPreco12CadastroIngredientes);
            this.Controls.Add(this.txtCusto12CadastroIngredientes);
            this.Controls.Add(this.txtPreco15CadastroIngredientes);
            this.Controls.Add(this.txtCusto15CadastroIngredientes);
            this.Controls.Add(this.txtNome15CadastroIngredientes);
            this.Controls.Add(this.txtPreco16CadastroIngredientes);
            this.Controls.Add(this.txtCusto16CadastroIngredientes);
            this.Controls.Add(this.txtPreco11CadastroIngredientes);
            this.Controls.Add(this.txtCusto11CadastroIngredientes);
            this.Controls.Add(this.txtNome18CadastroIngredientes);
            this.Controls.Add(this.txtNome14CadastroIngredientes);
            this.Controls.Add(this.txtNome17CadastroIngredientes);
            this.Controls.Add(this.txtNome13CadastroIngredientes);
            this.Controls.Add(this.txtNome16CadastroIngredientes);
            this.Controls.Add(this.txtNome12CadastroIngredientes);
            this.Controls.Add(this.txtNome11CadastroIngredientes);
            this.Controls.Add(this.txtNome9CadastroIngredientes);
            this.Controls.Add(this.txtPreco9CadastroIngredientes);
            this.Controls.Add(this.txtCusto9CadastroIngredientes);
            this.Controls.Add(this.txtPreco8CadastroIngredientes);
            this.Controls.Add(this.txtCusto8CadastroIngredientes);
            this.Controls.Add(this.txtPreco7CadastroIngredientes);
            this.Controls.Add(this.txtCusto7CadastroIngredientes);
            this.Controls.Add(this.txtPreco10CadastroIngredientes);
            this.Controls.Add(this.txtCusto10CadastroIngredientes);
            this.Controls.Add(this.txtNome10CadastroIngredientes);
            this.Controls.Add(this.txtPreco4CadastroIngredientes);
            this.Controls.Add(this.txtCusto4CadastroIngredientes);
            this.Controls.Add(this.txtPreco3CadastroIngredientes);
            this.Controls.Add(this.txtCusto3CadastroIngredientes);
            this.Controls.Add(this.txtPreco2CadastroIngredientes);
            this.Controls.Add(this.txtCusto2CadastroIngredientes);
            this.Controls.Add(this.txtPreco5CadastroIngredientes);
            this.Controls.Add(this.txtCusto5CadastroIngredientes);
            this.Controls.Add(this.txtNome5CadastroIngredientes);
            this.Controls.Add(this.txtPreco6CadastroIngredientes);
            this.Controls.Add(this.txtCusto6CadastroIngredientes);
            this.Controls.Add(this.lblNome2CadastroIngredientes);
            this.Controls.Add(this.lblPreco2CadastroIngredientes);
            this.Controls.Add(this.lblCusto2CadastroIngredientes);
            this.Controls.Add(this.lblNome1CadastroIngredientes);
            this.Controls.Add(this.lblPreco1CadastroIngredientes);
            this.Controls.Add(this.txtPreco1CadastroIngredientes);
            this.Controls.Add(this.lblCusto1CadastroIngredientes);
            this.Controls.Add(this.txtCusto1CadastroIngredientes);
            this.Controls.Add(this.txtNome8CadastroIngredientes);
            this.Controls.Add(this.txtNome4CadastroIngredientes);
            this.Controls.Add(this.txtNome7CadastroIngredientes);
            this.Controls.Add(this.txtNome3CadastroIngredientes);
            this.Controls.Add(this.txtNome6CadastroIngredientes);
            this.Controls.Add(this.txtNome2CadastroIngredientes);
            this.Controls.Add(this.btnSalvarCadastroIngredientes);
            this.Controls.Add(this.txtNomel1CadastroIngredientes);
            this.Controls.Add(this.lblTituloCadastroAdicionais);
            this.Name = "CadastroIngredientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
