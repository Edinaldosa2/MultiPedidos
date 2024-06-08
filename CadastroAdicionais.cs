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
        private Label lblAdicional5;
        private TextBox txtAdicional5;
        private TextBox txtPrecoAdicional6;
        private TextBox txtCustoAdicional6;
        private Label lblAdicionais2;
        private Label lblPrecoAdicionais2;
        private Label lblCustoAdicionais2;
        private Label lblImagemAdicionais2;
        private Label lblAdicionais1;
        private Label lblPrecoAdicionais1;
        private TextBox txtPrecoAdicional1;
        private Label lblCustoAdicionais1;
        private TextBox txtCustoAdicional1;
        private Label lblImagemAdicionais1;
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
        private Button btnUploadImagemCadastroAdicional1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
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
            this.lblAdicional5 = new System.Windows.Forms.Label();
            this.txtAdicional5 = new System.Windows.Forms.TextBox();
            this.txtPrecoAdicional6 = new System.Windows.Forms.TextBox();
            this.txtCustoAdicional6 = new System.Windows.Forms.TextBox();
            this.lblAdicionais2 = new System.Windows.Forms.Label();
            this.lblPrecoAdicionais2 = new System.Windows.Forms.Label();
            this.lblCustoAdicionais2 = new System.Windows.Forms.Label();
            this.lblImagemAdicionais2 = new System.Windows.Forms.Label();
            this.lblAdicionais1 = new System.Windows.Forms.Label();
            this.lblPrecoAdicionais1 = new System.Windows.Forms.Label();
            this.txtPrecoAdicional1 = new System.Windows.Forms.TextBox();
            this.lblCustoAdicionais1 = new System.Windows.Forms.Label();
            this.txtCustoAdicional1 = new System.Windows.Forms.TextBox();
            this.lblImagemAdicionais1 = new System.Windows.Forms.Label();
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
            this.btnUploadImagemCadastroAdicional1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
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
            // btnUploadImagemCadastroAdicional1
            // 
            this.btnUploadImagemCadastroAdicional1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroAdicional1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroAdicional1.Location = new System.Drawing.Point(228, 115);
            this.btnUploadImagemCadastroAdicional1.Name = "btnUploadImagemCadastroAdicional1";
            this.btnUploadImagemCadastroAdicional1.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroAdicional1.TabIndex = 334;
            this.btnUploadImagemCadastroAdicional1.Text = "Upload";
            this.btnUploadImagemCadastroAdicional1.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroAdicional1.Click += new System.EventHandler(this.btnUploadImagemCadastroAdicional1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(228, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 335;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(228, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 30);
            this.button2.TabIndex = 336;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(228, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 30);
            this.button3.TabIndex = 337;
            this.button3.Text = "Upload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(228, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 30);
            this.button4.TabIndex = 338;
            this.button4.Text = "Upload";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(837, 443);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 30);
            this.button5.TabIndex = 343;
            this.button5.Text = "Upload";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(837, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 30);
            this.button6.TabIndex = 342;
            this.button6.Text = "Upload";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(837, 284);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 30);
            this.button7.TabIndex = 341;
            this.button7.Text = "Upload";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(837, 200);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 30);
            this.button8.TabIndex = 340;
            this.button8.Text = "Upload";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(837, 116);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(127, 30);
            this.button9.TabIndex = 339;
            this.button9.Text = "Upload";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // CadastroAdicionais
            // 
            this.ClientSize = new System.Drawing.Size(1188, 617);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUploadImagemCadastroAdicional1);
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
            this.Controls.Add(this.lblAdicional5);
            this.Controls.Add(this.txtAdicional5);
            this.Controls.Add(this.txtPrecoAdicional6);
            this.Controls.Add(this.txtCustoAdicional6);
            this.Controls.Add(this.lblAdicionais2);
            this.Controls.Add(this.lblPrecoAdicionais2);
            this.Controls.Add(this.lblCustoAdicionais2);
            this.Controls.Add(this.lblImagemAdicionais2);
            this.Controls.Add(this.lblAdicionais1);
            this.Controls.Add(this.lblPrecoAdicionais1);
            this.Controls.Add(this.txtPrecoAdicional1);
            this.Controls.Add(this.lblCustoAdicionais1);
            this.Controls.Add(this.txtCustoAdicional1);
            this.Controls.Add(this.lblImagemAdicionais1);
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
