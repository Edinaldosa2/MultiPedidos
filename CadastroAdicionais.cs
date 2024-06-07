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
        private Label lblAdicional9;
        private TextBox txtAdicional9;
        private TextBox txtPrecoAdicional9;
        private TextBox txtCustoAdicional9;
        private TextBox txtPrecoAdicional8;
        private TextBox txtCustoAdicional8;
        private TextBox txtPrecoAdicional7;
        private TextBox txtCustoAdicional7;
        private TextBox txtPrecoAdicional10;
        private TextBox txtCustoAdicional10;
        private PictureBox imgAdicional10;
        private Label lblAdicional10;
        private TextBox txtAdicional10;
        private TextBox txtPrecoAdicional4;
        private TextBox txtCustoAdicional4;
        private TextBox txtPrecoAdicional3;
        private TextBox txtCustoAdicional3;
        private TextBox txtPrecoAdicional2;
        private TextBox txtCustoAdicional2;
        private TextBox txtPrecoAdicional5;
        private TextBox txtCustoAdicional5;
        private PictureBox imgAdicional5;
        private Label lblAdicional5;
        private TextBox txtAdicional5;
        private PictureBox imgAdicional9;
        private PictureBox imgAdicional8;
        private PictureBox imgAdicional7;
        private TextBox txtPrecoAdicional6;
        private TextBox txtCustoAdicional6;
        private PictureBox imgAdicional6;
        private Label lblAdicionais2;
        private Label lblPrecoAdicionais2;
        private Label lblCustoAdicionais2;
        private Label lblImagemAdicionais2;
        private PictureBox imgAdicional4;
        private PictureBox imgAdicional3;
        private PictureBox imgAdicional2;
        private Label lblAdicionais1;
        private Label lblPrecoAdicionais1;
        private TextBox txtPrecoAdicional1;
        private Label lblCustoAdicionais1;
        private TextBox txtCustoAdicional1;
        private Label lblImagemAdicionais1;
        private PictureBox imgAdicional1;
        private Label lblAdicional8;
        private TextBox txtAdicional8;
        private Label lblAdicional4;
        private TextBox txtAdicional4;
        private Label lblAdicional7;
        private TextBox txtAdicional7;
        private Label lblAdicional3;
        private TextBox txtAdicional3;
        private Label lblAdicional6;
        private TextBox txtAdicional6;
        private Label lblAdicional2;
        private TextBox txtAdicional2;
        private Button btnSalvarCadastroAdicionais;
        private Label lblAdicional1;
        private TextBox txtAdicional1;
        private Label lblTituloCadastroAdicionais;

        public CadastroAdicionais()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblAdicional9 = new System.Windows.Forms.Label();
            this.txtAdicional9 = new System.Windows.Forms.TextBox();
            this.txtPrecoAdicional9 = new System.Windows.Forms.TextBox();
            this.txtCustoAdicional9 = new System.Windows.Forms.TextBox();
            this.txtPrecoAdicional8 = new System.Windows.Forms.TextBox();
            this.txtCustoAdicional8 = new System.Windows.Forms.TextBox();
            this.txtPrecoAdicional7 = new System.Windows.Forms.TextBox();
            this.txtCustoAdicional7 = new System.Windows.Forms.TextBox();
            this.txtPrecoAdicional10 = new System.Windows.Forms.TextBox();
            this.txtCustoAdicional10 = new System.Windows.Forms.TextBox();
            this.imgAdicional10 = new System.Windows.Forms.PictureBox();
            this.lblAdicional10 = new System.Windows.Forms.Label();
            this.txtAdicional10 = new System.Windows.Forms.TextBox();
            this.txtPrecoAdicional4 = new System.Windows.Forms.TextBox();
            this.txtCustoAdicional4 = new System.Windows.Forms.TextBox();
            this.txtPrecoAdicional3 = new System.Windows.Forms.TextBox();
            this.txtCustoAdicional3 = new System.Windows.Forms.TextBox();
            this.txtPrecoAdicional2 = new System.Windows.Forms.TextBox();
            this.txtCustoAdicional2 = new System.Windows.Forms.TextBox();
            this.txtPrecoAdicional5 = new System.Windows.Forms.TextBox();
            this.txtCustoAdicional5 = new System.Windows.Forms.TextBox();
            this.imgAdicional5 = new System.Windows.Forms.PictureBox();
            this.lblAdicional5 = new System.Windows.Forms.Label();
            this.txtAdicional5 = new System.Windows.Forms.TextBox();
            this.imgAdicional9 = new System.Windows.Forms.PictureBox();
            this.imgAdicional8 = new System.Windows.Forms.PictureBox();
            this.imgAdicional7 = new System.Windows.Forms.PictureBox();
            this.txtPrecoAdicional6 = new System.Windows.Forms.TextBox();
            this.txtCustoAdicional6 = new System.Windows.Forms.TextBox();
            this.imgAdicional6 = new System.Windows.Forms.PictureBox();
            this.lblAdicionais2 = new System.Windows.Forms.Label();
            this.lblPrecoAdicionais2 = new System.Windows.Forms.Label();
            this.lblCustoAdicionais2 = new System.Windows.Forms.Label();
            this.lblImagemAdicionais2 = new System.Windows.Forms.Label();
            this.imgAdicional4 = new System.Windows.Forms.PictureBox();
            this.imgAdicional3 = new System.Windows.Forms.PictureBox();
            this.imgAdicional2 = new System.Windows.Forms.PictureBox();
            this.lblAdicionais1 = new System.Windows.Forms.Label();
            this.lblPrecoAdicionais1 = new System.Windows.Forms.Label();
            this.txtPrecoAdicional1 = new System.Windows.Forms.TextBox();
            this.lblCustoAdicionais1 = new System.Windows.Forms.Label();
            this.txtCustoAdicional1 = new System.Windows.Forms.TextBox();
            this.lblImagemAdicionais1 = new System.Windows.Forms.Label();
            this.imgAdicional1 = new System.Windows.Forms.PictureBox();
            this.lblAdicional8 = new System.Windows.Forms.Label();
            this.txtAdicional8 = new System.Windows.Forms.TextBox();
            this.lblAdicional4 = new System.Windows.Forms.Label();
            this.txtAdicional4 = new System.Windows.Forms.TextBox();
            this.lblAdicional7 = new System.Windows.Forms.Label();
            this.txtAdicional7 = new System.Windows.Forms.TextBox();
            this.lblAdicional3 = new System.Windows.Forms.Label();
            this.txtAdicional3 = new System.Windows.Forms.TextBox();
            this.lblAdicional6 = new System.Windows.Forms.Label();
            this.txtAdicional6 = new System.Windows.Forms.TextBox();
            this.lblAdicional2 = new System.Windows.Forms.Label();
            this.txtAdicional2 = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroAdicionais = new System.Windows.Forms.Button();
            this.lblAdicional1 = new System.Windows.Forms.Label();
            this.txtAdicional1 = new System.Windows.Forms.TextBox();
            this.lblTituloCadastroAdicionais = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdicional9
            // 
            this.lblAdicional9.AutoSize = true;
            this.lblAdicional9.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional9.Location = new System.Drawing.Point(624, 363);
            this.lblAdicional9.Name = "lblAdicional9";
            this.lblAdicional9.Size = new System.Drawing.Size(19, 24);
            this.lblAdicional9.TabIndex = 272;
            this.lblAdicional9.Text = "9";
            // 
            // txtAdicional9
            // 
            this.txtAdicional9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional9.Location = new System.Drawing.Point(649, 363);
            this.txtAdicional9.Name = "txtAdicional9";
            this.txtAdicional9.Size = new System.Drawing.Size(168, 30);
            this.txtAdicional9.TabIndex = 271;
            // 
            // txtPrecoAdicional9
            // 
            this.txtPrecoAdicional9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAdicional9.Location = new System.Drawing.Point(1091, 366);
            this.txtPrecoAdicional9.Name = "txtPrecoAdicional9";
            this.txtPrecoAdicional9.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoAdicional9.TabIndex = 270;
            // 
            // txtCustoAdicional9
            // 
            this.txtCustoAdicional9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAdicional9.Location = new System.Drawing.Point(981, 366);
            this.txtCustoAdicional9.Name = "txtCustoAdicional9";
            this.txtCustoAdicional9.Size = new System.Drawing.Size(82, 30);
            this.txtCustoAdicional9.TabIndex = 269;
            // 
            // txtPrecoAdicional8
            // 
            this.txtPrecoAdicional8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAdicional8.Location = new System.Drawing.Point(1091, 283);
            this.txtPrecoAdicional8.Name = "txtPrecoAdicional8";
            this.txtPrecoAdicional8.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoAdicional8.TabIndex = 268;
            // 
            // txtCustoAdicional8
            // 
            this.txtCustoAdicional8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAdicional8.Location = new System.Drawing.Point(981, 283);
            this.txtCustoAdicional8.Name = "txtCustoAdicional8";
            this.txtCustoAdicional8.Size = new System.Drawing.Size(82, 30);
            this.txtCustoAdicional8.TabIndex = 267;
            // 
            // txtPrecoAdicional7
            // 
            this.txtPrecoAdicional7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAdicional7.Location = new System.Drawing.Point(1091, 199);
            this.txtPrecoAdicional7.Name = "txtPrecoAdicional7";
            this.txtPrecoAdicional7.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoAdicional7.TabIndex = 266;
            // 
            // txtCustoAdicional7
            // 
            this.txtCustoAdicional7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAdicional7.Location = new System.Drawing.Point(981, 199);
            this.txtCustoAdicional7.Name = "txtCustoAdicional7";
            this.txtCustoAdicional7.Size = new System.Drawing.Size(82, 30);
            this.txtCustoAdicional7.TabIndex = 265;
            // 
            // txtPrecoAdicional10
            // 
            this.txtPrecoAdicional10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAdicional10.Location = new System.Drawing.Point(1093, 448);
            this.txtPrecoAdicional10.Name = "txtPrecoAdicional10";
            this.txtPrecoAdicional10.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoAdicional10.TabIndex = 264;
            // 
            // txtCustoAdicional10
            // 
            this.txtCustoAdicional10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAdicional10.Location = new System.Drawing.Point(983, 448);
            this.txtCustoAdicional10.Name = "txtCustoAdicional10";
            this.txtCustoAdicional10.Size = new System.Drawing.Size(82, 30);
            this.txtCustoAdicional10.TabIndex = 263;
            // 
            // imgAdicional10
            // 
            this.imgAdicional10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicional10.Location = new System.Drawing.Point(838, 448);
            this.imgAdicional10.Name = "imgAdicional10";
            this.imgAdicional10.Size = new System.Drawing.Size(114, 77);
            this.imgAdicional10.TabIndex = 262;
            this.imgAdicional10.TabStop = false;
            // 
            // lblAdicional10
            // 
            this.lblAdicional10.AutoSize = true;
            this.lblAdicional10.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional10.Location = new System.Drawing.Point(615, 448);
            this.lblAdicional10.Name = "lblAdicional10";
            this.lblAdicional10.Size = new System.Drawing.Size(28, 24);
            this.lblAdicional10.TabIndex = 261;
            this.lblAdicional10.Text = "10";
            // 
            // txtAdicional10
            // 
            this.txtAdicional10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional10.Location = new System.Drawing.Point(649, 448);
            this.txtAdicional10.Name = "txtAdicional10";
            this.txtAdicional10.Size = new System.Drawing.Size(168, 30);
            this.txtAdicional10.TabIndex = 260;
            // 
            // txtPrecoAdicional4
            // 
            this.txtPrecoAdicional4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAdicional4.Location = new System.Drawing.Point(486, 366);
            this.txtPrecoAdicional4.Name = "txtPrecoAdicional4";
            this.txtPrecoAdicional4.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoAdicional4.TabIndex = 259;
            // 
            // txtCustoAdicional4
            // 
            this.txtCustoAdicional4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAdicional4.Location = new System.Drawing.Point(376, 366);
            this.txtCustoAdicional4.Name = "txtCustoAdicional4";
            this.txtCustoAdicional4.Size = new System.Drawing.Size(82, 30);
            this.txtCustoAdicional4.TabIndex = 258;
            // 
            // txtPrecoAdicional3
            // 
            this.txtPrecoAdicional3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAdicional3.Location = new System.Drawing.Point(486, 283);
            this.txtPrecoAdicional3.Name = "txtPrecoAdicional3";
            this.txtPrecoAdicional3.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoAdicional3.TabIndex = 257;
            // 
            // txtCustoAdicional3
            // 
            this.txtCustoAdicional3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAdicional3.Location = new System.Drawing.Point(376, 283);
            this.txtCustoAdicional3.Name = "txtCustoAdicional3";
            this.txtCustoAdicional3.Size = new System.Drawing.Size(82, 30);
            this.txtCustoAdicional3.TabIndex = 256;
            // 
            // txtPrecoAdicional2
            // 
            this.txtPrecoAdicional2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAdicional2.Location = new System.Drawing.Point(486, 199);
            this.txtPrecoAdicional2.Name = "txtPrecoAdicional2";
            this.txtPrecoAdicional2.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoAdicional2.TabIndex = 255;
            // 
            // txtCustoAdicional2
            // 
            this.txtCustoAdicional2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAdicional2.Location = new System.Drawing.Point(376, 199);
            this.txtCustoAdicional2.Name = "txtCustoAdicional2";
            this.txtCustoAdicional2.Size = new System.Drawing.Size(82, 30);
            this.txtCustoAdicional2.TabIndex = 254;
            // 
            // txtPrecoAdicional5
            // 
            this.txtPrecoAdicional5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAdicional5.Location = new System.Drawing.Point(486, 448);
            this.txtPrecoAdicional5.Name = "txtPrecoAdicional5";
            this.txtPrecoAdicional5.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoAdicional5.TabIndex = 253;
            // 
            // txtCustoAdicional5
            // 
            this.txtCustoAdicional5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAdicional5.Location = new System.Drawing.Point(376, 448);
            this.txtCustoAdicional5.Name = "txtCustoAdicional5";
            this.txtCustoAdicional5.Size = new System.Drawing.Size(82, 30);
            this.txtCustoAdicional5.TabIndex = 252;
            // 
            // imgAdicional5
            // 
            this.imgAdicional5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicional5.Location = new System.Drawing.Point(231, 448);
            this.imgAdicional5.Name = "imgAdicional5";
            this.imgAdicional5.Size = new System.Drawing.Size(114, 77);
            this.imgAdicional5.TabIndex = 251;
            this.imgAdicional5.TabStop = false;
            // 
            // lblAdicional5
            // 
            this.lblAdicional5.AutoSize = true;
            this.lblAdicional5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional5.Location = new System.Drawing.Point(17, 448);
            this.lblAdicional5.Name = "lblAdicional5";
            this.lblAdicional5.Size = new System.Drawing.Size(19, 24);
            this.lblAdicional5.TabIndex = 250;
            this.lblAdicional5.Text = "5";
            // 
            // txtAdicional5
            // 
            this.txtAdicional5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional5.Location = new System.Drawing.Point(42, 448);
            this.txtAdicional5.Name = "txtAdicional5";
            this.txtAdicional5.Size = new System.Drawing.Size(168, 30);
            this.txtAdicional5.TabIndex = 249;
            // 
            // imgAdicional9
            // 
            this.imgAdicional9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicional9.Location = new System.Drawing.Point(838, 365);
            this.imgAdicional9.Name = "imgAdicional9";
            this.imgAdicional9.Size = new System.Drawing.Size(114, 77);
            this.imgAdicional9.TabIndex = 248;
            this.imgAdicional9.TabStop = false;
            // 
            // imgAdicional8
            // 
            this.imgAdicional8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicional8.Location = new System.Drawing.Point(838, 282);
            this.imgAdicional8.Name = "imgAdicional8";
            this.imgAdicional8.Size = new System.Drawing.Size(114, 77);
            this.imgAdicional8.TabIndex = 247;
            this.imgAdicional8.TabStop = false;
            // 
            // imgAdicional7
            // 
            this.imgAdicional7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicional7.Location = new System.Drawing.Point(838, 199);
            this.imgAdicional7.Name = "imgAdicional7";
            this.imgAdicional7.Size = new System.Drawing.Size(114, 77);
            this.imgAdicional7.TabIndex = 246;
            this.imgAdicional7.TabStop = false;
            // 
            // txtPrecoAdicional6
            // 
            this.txtPrecoAdicional6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAdicional6.Location = new System.Drawing.Point(1093, 116);
            this.txtPrecoAdicional6.Name = "txtPrecoAdicional6";
            this.txtPrecoAdicional6.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoAdicional6.TabIndex = 245;
            // 
            // txtCustoAdicional6
            // 
            this.txtCustoAdicional6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAdicional6.Location = new System.Drawing.Point(983, 116);
            this.txtCustoAdicional6.Name = "txtCustoAdicional6";
            this.txtCustoAdicional6.Size = new System.Drawing.Size(82, 30);
            this.txtCustoAdicional6.TabIndex = 244;
            // 
            // imgAdicional6
            // 
            this.imgAdicional6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicional6.Location = new System.Drawing.Point(838, 116);
            this.imgAdicional6.Name = "imgAdicional6";
            this.imgAdicional6.Size = new System.Drawing.Size(114, 77);
            this.imgAdicional6.TabIndex = 243;
            this.imgAdicional6.TabStop = false;
            // 
            // lblAdicionais2
            // 
            this.lblAdicionais2.AutoSize = true;
            this.lblAdicionais2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionais2.Location = new System.Drawing.Point(685, 76);
            this.lblAdicionais2.Name = "lblAdicionais2";
            this.lblAdicionais2.Size = new System.Drawing.Size(100, 24);
            this.lblAdicionais2.TabIndex = 242;
            this.lblAdicionais2.Text = "Adicionais";
            // 
            // lblPrecoAdicionais2
            // 
            this.lblPrecoAdicionais2.AutoSize = true;
            this.lblPrecoAdicionais2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoAdicionais2.Location = new System.Drawing.Point(1087, 76);
            this.lblPrecoAdicionais2.Name = "lblPrecoAdicionais2";
            this.lblPrecoAdicionais2.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoAdicionais2.TabIndex = 241;
            this.lblPrecoAdicionais2.Text = "Preço ($)";
            // 
            // lblCustoAdicionais2
            // 
            this.lblCustoAdicionais2.AutoSize = true;
            this.lblCustoAdicionais2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoAdicionais2.Location = new System.Drawing.Point(977, 76);
            this.lblCustoAdicionais2.Name = "lblCustoAdicionais2";
            this.lblCustoAdicionais2.Size = new System.Drawing.Size(86, 24);
            this.lblCustoAdicionais2.TabIndex = 240;
            this.lblCustoAdicionais2.Text = "Custo ($)";
            // 
            // lblImagemAdicionais2
            // 
            this.lblImagemAdicionais2.AutoSize = true;
            this.lblImagemAdicionais2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemAdicionais2.Location = new System.Drawing.Point(856, 76);
            this.lblImagemAdicionais2.Name = "lblImagemAdicionais2";
            this.lblImagemAdicionais2.Size = new System.Drawing.Size(77, 24);
            this.lblImagemAdicionais2.TabIndex = 239;
            this.lblImagemAdicionais2.Text = "Imagem";
            // 
            // imgAdicional4
            // 
            this.imgAdicional4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicional4.Location = new System.Drawing.Point(231, 365);
            this.imgAdicional4.Name = "imgAdicional4";
            this.imgAdicional4.Size = new System.Drawing.Size(114, 77);
            this.imgAdicional4.TabIndex = 238;
            this.imgAdicional4.TabStop = false;
            // 
            // imgAdicional3
            // 
            this.imgAdicional3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicional3.Location = new System.Drawing.Point(231, 282);
            this.imgAdicional3.Name = "imgAdicional3";
            this.imgAdicional3.Size = new System.Drawing.Size(114, 77);
            this.imgAdicional3.TabIndex = 237;
            this.imgAdicional3.TabStop = false;
            // 
            // imgAdicional2
            // 
            this.imgAdicional2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicional2.Location = new System.Drawing.Point(231, 199);
            this.imgAdicional2.Name = "imgAdicional2";
            this.imgAdicional2.Size = new System.Drawing.Size(114, 77);
            this.imgAdicional2.TabIndex = 236;
            this.imgAdicional2.TabStop = false;
            // 
            // lblAdicionais1
            // 
            this.lblAdicionais1.AutoSize = true;
            this.lblAdicionais1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionais1.Location = new System.Drawing.Point(80, 76);
            this.lblAdicionais1.Name = "lblAdicionais1";
            this.lblAdicionais1.Size = new System.Drawing.Size(100, 24);
            this.lblAdicionais1.TabIndex = 235;
            this.lblAdicionais1.Text = "Adicionais";
            // 
            // lblPrecoAdicionais1
            // 
            this.lblPrecoAdicionais1.AutoSize = true;
            this.lblPrecoAdicionais1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoAdicionais1.Location = new System.Drawing.Point(482, 76);
            this.lblPrecoAdicionais1.Name = "lblPrecoAdicionais1";
            this.lblPrecoAdicionais1.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoAdicionais1.TabIndex = 234;
            this.lblPrecoAdicionais1.Text = "Preço ($)";
            // 
            // txtPrecoAdicional1
            // 
            this.txtPrecoAdicional1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoAdicional1.Location = new System.Drawing.Point(486, 116);
            this.txtPrecoAdicional1.Name = "txtPrecoAdicional1";
            this.txtPrecoAdicional1.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoAdicional1.TabIndex = 233;
            // 
            // lblCustoAdicionais1
            // 
            this.lblCustoAdicionais1.AutoSize = true;
            this.lblCustoAdicionais1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoAdicionais1.Location = new System.Drawing.Point(372, 76);
            this.lblCustoAdicionais1.Name = "lblCustoAdicionais1";
            this.lblCustoAdicionais1.Size = new System.Drawing.Size(86, 24);
            this.lblCustoAdicionais1.TabIndex = 232;
            this.lblCustoAdicionais1.Text = "Custo ($)";
            // 
            // txtCustoAdicional1
            // 
            this.txtCustoAdicional1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoAdicional1.Location = new System.Drawing.Point(376, 116);
            this.txtCustoAdicional1.Name = "txtCustoAdicional1";
            this.txtCustoAdicional1.Size = new System.Drawing.Size(82, 30);
            this.txtCustoAdicional1.TabIndex = 231;
            // 
            // lblImagemAdicionais1
            // 
            this.lblImagemAdicionais1.AutoSize = true;
            this.lblImagemAdicionais1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemAdicionais1.Location = new System.Drawing.Point(251, 76);
            this.lblImagemAdicionais1.Name = "lblImagemAdicionais1";
            this.lblImagemAdicionais1.Size = new System.Drawing.Size(77, 24);
            this.lblImagemAdicionais1.TabIndex = 230;
            this.lblImagemAdicionais1.Text = "Imagem";
            // 
            // imgAdicional1
            // 
            this.imgAdicional1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicional1.Location = new System.Drawing.Point(231, 116);
            this.imgAdicional1.Name = "imgAdicional1";
            this.imgAdicional1.Size = new System.Drawing.Size(114, 77);
            this.imgAdicional1.TabIndex = 229;
            this.imgAdicional1.TabStop = false;
            // 
            // lblAdicional8
            // 
            this.lblAdicional8.AutoSize = true;
            this.lblAdicional8.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional8.Location = new System.Drawing.Point(624, 280);
            this.lblAdicional8.Name = "lblAdicional8";
            this.lblAdicional8.Size = new System.Drawing.Size(19, 24);
            this.lblAdicional8.TabIndex = 228;
            this.lblAdicional8.Text = "8";
            // 
            // txtAdicional8
            // 
            this.txtAdicional8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional8.Location = new System.Drawing.Point(649, 280);
            this.txtAdicional8.Name = "txtAdicional8";
            this.txtAdicional8.Size = new System.Drawing.Size(168, 30);
            this.txtAdicional8.TabIndex = 227;
            // 
            // lblAdicional4
            // 
            this.lblAdicional4.AutoSize = true;
            this.lblAdicional4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional4.Location = new System.Drawing.Point(17, 365);
            this.lblAdicional4.Name = "lblAdicional4";
            this.lblAdicional4.Size = new System.Drawing.Size(19, 24);
            this.lblAdicional4.TabIndex = 226;
            this.lblAdicional4.Text = "4";
            // 
            // txtAdicional4
            // 
            this.txtAdicional4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional4.Location = new System.Drawing.Point(42, 365);
            this.txtAdicional4.Name = "txtAdicional4";
            this.txtAdicional4.Size = new System.Drawing.Size(168, 30);
            this.txtAdicional4.TabIndex = 225;
            // 
            // lblAdicional7
            // 
            this.lblAdicional7.AutoSize = true;
            this.lblAdicional7.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional7.Location = new System.Drawing.Point(624, 203);
            this.lblAdicional7.Name = "lblAdicional7";
            this.lblAdicional7.Size = new System.Drawing.Size(19, 24);
            this.lblAdicional7.TabIndex = 224;
            this.lblAdicional7.Text = "7";
            // 
            // txtAdicional7
            // 
            this.txtAdicional7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional7.Location = new System.Drawing.Point(649, 203);
            this.txtAdicional7.Name = "txtAdicional7";
            this.txtAdicional7.Size = new System.Drawing.Size(168, 30);
            this.txtAdicional7.TabIndex = 223;
            // 
            // lblAdicional3
            // 
            this.lblAdicional3.AutoSize = true;
            this.lblAdicional3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional3.Location = new System.Drawing.Point(17, 283);
            this.lblAdicional3.Name = "lblAdicional3";
            this.lblAdicional3.Size = new System.Drawing.Size(19, 24);
            this.lblAdicional3.TabIndex = 222;
            this.lblAdicional3.Text = "3";
            // 
            // txtAdicional3
            // 
            this.txtAdicional3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional3.Location = new System.Drawing.Point(42, 283);
            this.txtAdicional3.Name = "txtAdicional3";
            this.txtAdicional3.Size = new System.Drawing.Size(168, 30);
            this.txtAdicional3.TabIndex = 221;
            // 
            // lblAdicional6
            // 
            this.lblAdicional6.AutoSize = true;
            this.lblAdicional6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional6.Location = new System.Drawing.Point(624, 116);
            this.lblAdicional6.Name = "lblAdicional6";
            this.lblAdicional6.Size = new System.Drawing.Size(19, 24);
            this.lblAdicional6.TabIndex = 220;
            this.lblAdicional6.Text = "6";
            // 
            // txtAdicional6
            // 
            this.txtAdicional6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional6.Location = new System.Drawing.Point(649, 116);
            this.txtAdicional6.Name = "txtAdicional6";
            this.txtAdicional6.Size = new System.Drawing.Size(168, 30);
            this.txtAdicional6.TabIndex = 219;
            // 
            // lblAdicional2
            // 
            this.lblAdicional2.AutoSize = true;
            this.lblAdicional2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional2.Location = new System.Drawing.Point(17, 199);
            this.lblAdicional2.Name = "lblAdicional2";
            this.lblAdicional2.Size = new System.Drawing.Size(19, 24);
            this.lblAdicional2.TabIndex = 218;
            this.lblAdicional2.Text = "2";
            // 
            // txtAdicional2
            // 
            this.txtAdicional2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional2.Location = new System.Drawing.Point(42, 199);
            this.txtAdicional2.Name = "txtAdicional2";
            this.txtAdicional2.Size = new System.Drawing.Size(168, 30);
            this.txtAdicional2.TabIndex = 217;
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
            // lblAdicional1
            // 
            this.lblAdicional1.AutoSize = true;
            this.lblAdicional1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional1.Location = new System.Drawing.Point(17, 116);
            this.lblAdicional1.Name = "lblAdicional1";
            this.lblAdicional1.Size = new System.Drawing.Size(19, 24);
            this.lblAdicional1.TabIndex = 215;
            this.lblAdicional1.Text = "1";
            // 
            // txtAdicional1
            // 
            this.txtAdicional1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional1.Location = new System.Drawing.Point(42, 116);
            this.txtAdicional1.Name = "txtAdicional1";
            this.txtAdicional1.Size = new System.Drawing.Size(168, 30);
            this.txtAdicional1.TabIndex = 214;
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
            // CadastroAdicionais
            // 
            this.ClientSize = new System.Drawing.Size(1188, 617);
            this.Controls.Add(this.lblAdicional9);
            this.Controls.Add(this.txtAdicional9);
            this.Controls.Add(this.txtPrecoAdicional9);
            this.Controls.Add(this.txtCustoAdicional9);
            this.Controls.Add(this.txtPrecoAdicional8);
            this.Controls.Add(this.txtCustoAdicional8);
            this.Controls.Add(this.txtPrecoAdicional7);
            this.Controls.Add(this.txtCustoAdicional7);
            this.Controls.Add(this.txtPrecoAdicional10);
            this.Controls.Add(this.txtCustoAdicional10);
            this.Controls.Add(this.imgAdicional10);
            this.Controls.Add(this.lblAdicional10);
            this.Controls.Add(this.txtAdicional10);
            this.Controls.Add(this.txtPrecoAdicional4);
            this.Controls.Add(this.txtCustoAdicional4);
            this.Controls.Add(this.txtPrecoAdicional3);
            this.Controls.Add(this.txtCustoAdicional3);
            this.Controls.Add(this.txtPrecoAdicional2);
            this.Controls.Add(this.txtCustoAdicional2);
            this.Controls.Add(this.txtPrecoAdicional5);
            this.Controls.Add(this.txtCustoAdicional5);
            this.Controls.Add(this.imgAdicional5);
            this.Controls.Add(this.lblAdicional5);
            this.Controls.Add(this.txtAdicional5);
            this.Controls.Add(this.imgAdicional9);
            this.Controls.Add(this.imgAdicional8);
            this.Controls.Add(this.imgAdicional7);
            this.Controls.Add(this.txtPrecoAdicional6);
            this.Controls.Add(this.txtCustoAdicional6);
            this.Controls.Add(this.imgAdicional6);
            this.Controls.Add(this.lblAdicionais2);
            this.Controls.Add(this.lblPrecoAdicionais2);
            this.Controls.Add(this.lblCustoAdicionais2);
            this.Controls.Add(this.lblImagemAdicionais2);
            this.Controls.Add(this.imgAdicional4);
            this.Controls.Add(this.imgAdicional3);
            this.Controls.Add(this.imgAdicional2);
            this.Controls.Add(this.lblAdicionais1);
            this.Controls.Add(this.lblPrecoAdicionais1);
            this.Controls.Add(this.txtPrecoAdicional1);
            this.Controls.Add(this.lblCustoAdicionais1);
            this.Controls.Add(this.txtCustoAdicional1);
            this.Controls.Add(this.lblImagemAdicionais1);
            this.Controls.Add(this.imgAdicional1);
            this.Controls.Add(this.lblAdicional8);
            this.Controls.Add(this.txtAdicional8);
            this.Controls.Add(this.lblAdicional4);
            this.Controls.Add(this.txtAdicional4);
            this.Controls.Add(this.lblAdicional7);
            this.Controls.Add(this.txtAdicional7);
            this.Controls.Add(this.lblAdicional3);
            this.Controls.Add(this.txtAdicional3);
            this.Controls.Add(this.lblAdicional6);
            this.Controls.Add(this.txtAdicional6);
            this.Controls.Add(this.lblAdicional2);
            this.Controls.Add(this.txtAdicional2);
            this.Controls.Add(this.btnSalvarCadastroAdicionais);
            this.Controls.Add(this.lblAdicional1);
            this.Controls.Add(this.txtAdicional1);
            this.Controls.Add(this.lblTituloCadastroAdicionais);
            this.Name = "CadastroAdicionais";
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicional1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
