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
        private Label lblPorcao9;
        private TextBox txtPorcao9;
        private TextBox txtPrecoPorcao9;
        private TextBox txtCustoPorcao9;
        private TextBox txtPrecoPorcao8;
        private TextBox txtCustoPorcao8;
        private TextBox txtPrecoPorcao7;
        private TextBox txtCustoPorcao7;
        private TextBox txtPrecoPorcao10;
        private TextBox txtCustoPorcao10;
        private Label lblPorcao10;
        private TextBox txtPorcao10;
        private TextBox txtPrecoPorcao4;
        private TextBox txtCustoPorcao4;
        private TextBox txtPrecoPorcao3;
        private TextBox txtCustoPorcao3;
        private TextBox txtPrecoPorcao2;
        private TextBox txtCustoPorcao2;
        private TextBox txtPrecoPorcao5;
        private TextBox txtCustoPorcao5;
        private Label lblPorcao5;
        private TextBox txtPorcao5;
        private TextBox txtPrecoPorcao6;
        private TextBox txtCustoPorcao6;
        private Label lblPorcoes2;
        private Label lblPrecoPorcoes2;
        private Label lblCustoPorcoes2;
        private Label lblImagemPorcoes2;
        private Label lblPorcoes1;
        private Label lblPrecoPorcoes1;
        private TextBox txtPrecoPorcao1;
        private Label lblCustoPorcoes1;
        private TextBox txtCustoPorcao1;
        private Label lblImagemPorcoes1;
        private Label lblPorcao8;
        private TextBox txtPorcao8;
        private Label lblPorcao4;
        private TextBox txtPorcao4;
        private Label lblPorcao7;
        private TextBox txtPorcao7;
        private Label lblPorcao3;
        private TextBox txtPorcao3;
        private Label lblPorcao6;
        private TextBox txtPorcao6;
        private Label lblPorcao2;
        private TextBox txtPorcao2;
        private Button btnSalvarCadastroPorcoes;
        private Label lblPorcao1;
        private TextBox txtPorcao1;
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
        private Button btnUploadImagemCadastroPorcao1;
        private Button btnUploadImagemCadastroPorcao2;
        private Button btnUploadImagemCadastroPorcao4;
        private Button btnUploadImagemCadastroPorcao3;
        private Button btnUploadImagemCadastroPorcao5;
        private Button btnUploadImagemCadastroPorcao10;
        private Button btnUploadImagemCadastroPorcao9;
        private Button btnUploadImagemCadastroPorcao8;
        private Button btnUploadImagemCadastroPorcao7;
        private Button btnUploadImagemCadastroPorcao6;
        private Label lblTituloCadastroPorcoes;

        public CadastroPorcoes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblPorcao9 = new System.Windows.Forms.Label();
            this.txtPorcao9 = new System.Windows.Forms.TextBox();
            this.txtPrecoPorcao9 = new System.Windows.Forms.TextBox();
            this.txtCustoPorcao9 = new System.Windows.Forms.TextBox();
            this.txtPrecoPorcao8 = new System.Windows.Forms.TextBox();
            this.txtCustoPorcao8 = new System.Windows.Forms.TextBox();
            this.txtPrecoPorcao7 = new System.Windows.Forms.TextBox();
            this.txtCustoPorcao7 = new System.Windows.Forms.TextBox();
            this.txtPrecoPorcao10 = new System.Windows.Forms.TextBox();
            this.txtCustoPorcao10 = new System.Windows.Forms.TextBox();
            this.lblPorcao10 = new System.Windows.Forms.Label();
            this.txtPorcao10 = new System.Windows.Forms.TextBox();
            this.txtPrecoPorcao4 = new System.Windows.Forms.TextBox();
            this.txtCustoPorcao4 = new System.Windows.Forms.TextBox();
            this.txtPrecoPorcao3 = new System.Windows.Forms.TextBox();
            this.txtCustoPorcao3 = new System.Windows.Forms.TextBox();
            this.txtPrecoPorcao2 = new System.Windows.Forms.TextBox();
            this.txtCustoPorcao2 = new System.Windows.Forms.TextBox();
            this.txtPrecoPorcao5 = new System.Windows.Forms.TextBox();
            this.txtCustoPorcao5 = new System.Windows.Forms.TextBox();
            this.lblPorcao5 = new System.Windows.Forms.Label();
            this.txtPorcao5 = new System.Windows.Forms.TextBox();
            this.txtPrecoPorcao6 = new System.Windows.Forms.TextBox();
            this.txtCustoPorcao6 = new System.Windows.Forms.TextBox();
            this.lblPorcoes2 = new System.Windows.Forms.Label();
            this.lblPrecoPorcoes2 = new System.Windows.Forms.Label();
            this.lblCustoPorcoes2 = new System.Windows.Forms.Label();
            this.lblImagemPorcoes2 = new System.Windows.Forms.Label();
            this.lblPorcoes1 = new System.Windows.Forms.Label();
            this.lblPrecoPorcoes1 = new System.Windows.Forms.Label();
            this.txtPrecoPorcao1 = new System.Windows.Forms.TextBox();
            this.lblCustoPorcoes1 = new System.Windows.Forms.Label();
            this.txtCustoPorcao1 = new System.Windows.Forms.TextBox();
            this.lblImagemPorcoes1 = new System.Windows.Forms.Label();
            this.lblPorcao8 = new System.Windows.Forms.Label();
            this.txtPorcao8 = new System.Windows.Forms.TextBox();
            this.lblPorcao4 = new System.Windows.Forms.Label();
            this.txtPorcao4 = new System.Windows.Forms.TextBox();
            this.lblPorcao7 = new System.Windows.Forms.Label();
            this.txtPorcao7 = new System.Windows.Forms.TextBox();
            this.lblPorcao3 = new System.Windows.Forms.Label();
            this.txtPorcao3 = new System.Windows.Forms.TextBox();
            this.lblPorcao6 = new System.Windows.Forms.Label();
            this.txtPorcao6 = new System.Windows.Forms.TextBox();
            this.lblPorcao2 = new System.Windows.Forms.Label();
            this.txtPorcao2 = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroPorcoes = new System.Windows.Forms.Button();
            this.lblPorcao1 = new System.Windows.Forms.Label();
            this.txtPorcao1 = new System.Windows.Forms.TextBox();
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
            this.btnUploadImagemCadastroPorcao1 = new System.Windows.Forms.Button();
            this.btnUploadImagemCadastroPorcao2 = new System.Windows.Forms.Button();
            this.btnUploadImagemCadastroPorcao4 = new System.Windows.Forms.Button();
            this.btnUploadImagemCadastroPorcao3 = new System.Windows.Forms.Button();
            this.btnUploadImagemCadastroPorcao5 = new System.Windows.Forms.Button();
            this.btnUploadImagemCadastroPorcao10 = new System.Windows.Forms.Button();
            this.btnUploadImagemCadastroPorcao9 = new System.Windows.Forms.Button();
            this.btnUploadImagemCadastroPorcao8 = new System.Windows.Forms.Button();
            this.btnUploadImagemCadastroPorcao7 = new System.Windows.Forms.Button();
            this.btnUploadImagemCadastroPorcao6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPorcao9
            // 
            this.lblPorcao9.AutoSize = true;
            this.lblPorcao9.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcao9.Location = new System.Drawing.Point(618, 363);
            this.lblPorcao9.Name = "lblPorcao9";
            this.lblPorcao9.Size = new System.Drawing.Size(19, 24);
            this.lblPorcao9.TabIndex = 332;
            this.lblPorcao9.Text = "9";
            // 
            // txtPorcao9
            // 
            this.txtPorcao9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcao9.Location = new System.Drawing.Point(643, 363);
            this.txtPorcao9.Name = "txtPorcao9";
            this.txtPorcao9.Size = new System.Drawing.Size(168, 30);
            this.txtPorcao9.TabIndex = 331;
            // 
            // txtPrecoPorcao9
            // 
            this.txtPrecoPorcao9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPorcao9.Location = new System.Drawing.Point(1085, 366);
            this.txtPrecoPorcao9.Name = "txtPrecoPorcao9";
            this.txtPrecoPorcao9.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoPorcao9.TabIndex = 330;
            // 
            // txtCustoPorcao9
            // 
            this.txtCustoPorcao9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorcao9.Location = new System.Drawing.Point(975, 366);
            this.txtCustoPorcao9.Name = "txtCustoPorcao9";
            this.txtCustoPorcao9.Size = new System.Drawing.Size(82, 30);
            this.txtCustoPorcao9.TabIndex = 329;
            // 
            // txtPrecoPorcao8
            // 
            this.txtPrecoPorcao8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPorcao8.Location = new System.Drawing.Point(1085, 283);
            this.txtPrecoPorcao8.Name = "txtPrecoPorcao8";
            this.txtPrecoPorcao8.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoPorcao8.TabIndex = 328;
            // 
            // txtCustoPorcao8
            // 
            this.txtCustoPorcao8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorcao8.Location = new System.Drawing.Point(975, 283);
            this.txtCustoPorcao8.Name = "txtCustoPorcao8";
            this.txtCustoPorcao8.Size = new System.Drawing.Size(82, 30);
            this.txtCustoPorcao8.TabIndex = 327;
            // 
            // txtPrecoPorcao7
            // 
            this.txtPrecoPorcao7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPorcao7.Location = new System.Drawing.Point(1085, 199);
            this.txtPrecoPorcao7.Name = "txtPrecoPorcao7";
            this.txtPrecoPorcao7.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoPorcao7.TabIndex = 326;
            // 
            // txtCustoPorcao7
            // 
            this.txtCustoPorcao7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorcao7.Location = new System.Drawing.Point(975, 199);
            this.txtCustoPorcao7.Name = "txtCustoPorcao7";
            this.txtCustoPorcao7.Size = new System.Drawing.Size(82, 30);
            this.txtCustoPorcao7.TabIndex = 325;
            // 
            // txtPrecoPorcao10
            // 
            this.txtPrecoPorcao10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPorcao10.Location = new System.Drawing.Point(1087, 448);
            this.txtPrecoPorcao10.Name = "txtPrecoPorcao10";
            this.txtPrecoPorcao10.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoPorcao10.TabIndex = 324;
            // 
            // txtCustoPorcao10
            // 
            this.txtCustoPorcao10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorcao10.Location = new System.Drawing.Point(977, 448);
            this.txtCustoPorcao10.Name = "txtCustoPorcao10";
            this.txtCustoPorcao10.Size = new System.Drawing.Size(82, 30);
            this.txtCustoPorcao10.TabIndex = 323;
            // 
            // lblPorcao10
            // 
            this.lblPorcao10.AutoSize = true;
            this.lblPorcao10.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcao10.Location = new System.Drawing.Point(609, 448);
            this.lblPorcao10.Name = "lblPorcao10";
            this.lblPorcao10.Size = new System.Drawing.Size(28, 24);
            this.lblPorcao10.TabIndex = 321;
            this.lblPorcao10.Text = "10";
            // 
            // txtPorcao10
            // 
            this.txtPorcao10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcao10.Location = new System.Drawing.Point(643, 448);
            this.txtPorcao10.Name = "txtPorcao10";
            this.txtPorcao10.Size = new System.Drawing.Size(168, 30);
            this.txtPorcao10.TabIndex = 320;
            // 
            // txtPrecoPorcao4
            // 
            this.txtPrecoPorcao4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPorcao4.Location = new System.Drawing.Point(480, 366);
            this.txtPrecoPorcao4.Name = "txtPrecoPorcao4";
            this.txtPrecoPorcao4.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoPorcao4.TabIndex = 319;
            // 
            // txtCustoPorcao4
            // 
            this.txtCustoPorcao4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorcao4.Location = new System.Drawing.Point(370, 366);
            this.txtCustoPorcao4.Name = "txtCustoPorcao4";
            this.txtCustoPorcao4.Size = new System.Drawing.Size(82, 30);
            this.txtCustoPorcao4.TabIndex = 318;
            // 
            // txtPrecoPorcao3
            // 
            this.txtPrecoPorcao3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPorcao3.Location = new System.Drawing.Point(480, 283);
            this.txtPrecoPorcao3.Name = "txtPrecoPorcao3";
            this.txtPrecoPorcao3.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoPorcao3.TabIndex = 317;
            // 
            // txtCustoPorcao3
            // 
            this.txtCustoPorcao3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorcao3.Location = new System.Drawing.Point(370, 283);
            this.txtCustoPorcao3.Name = "txtCustoPorcao3";
            this.txtCustoPorcao3.Size = new System.Drawing.Size(82, 30);
            this.txtCustoPorcao3.TabIndex = 316;
            // 
            // txtPrecoPorcao2
            // 
            this.txtPrecoPorcao2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPorcao2.Location = new System.Drawing.Point(480, 199);
            this.txtPrecoPorcao2.Name = "txtPrecoPorcao2";
            this.txtPrecoPorcao2.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoPorcao2.TabIndex = 315;
            // 
            // txtCustoPorcao2
            // 
            this.txtCustoPorcao2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorcao2.Location = new System.Drawing.Point(370, 199);
            this.txtCustoPorcao2.Name = "txtCustoPorcao2";
            this.txtCustoPorcao2.Size = new System.Drawing.Size(82, 30);
            this.txtCustoPorcao2.TabIndex = 314;
            // 
            // txtPrecoPorcao5
            // 
            this.txtPrecoPorcao5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPorcao5.Location = new System.Drawing.Point(480, 448);
            this.txtPrecoPorcao5.Name = "txtPrecoPorcao5";
            this.txtPrecoPorcao5.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoPorcao5.TabIndex = 313;
            // 
            // txtCustoPorcao5
            // 
            this.txtCustoPorcao5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorcao5.Location = new System.Drawing.Point(370, 448);
            this.txtCustoPorcao5.Name = "txtCustoPorcao5";
            this.txtCustoPorcao5.Size = new System.Drawing.Size(82, 30);
            this.txtCustoPorcao5.TabIndex = 312;
            // 
            // lblPorcao5
            // 
            this.lblPorcao5.AutoSize = true;
            this.lblPorcao5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcao5.Location = new System.Drawing.Point(11, 448);
            this.lblPorcao5.Name = "lblPorcao5";
            this.lblPorcao5.Size = new System.Drawing.Size(19, 24);
            this.lblPorcao5.TabIndex = 310;
            this.lblPorcao5.Text = "5";
            // 
            // txtPorcao5
            // 
            this.txtPorcao5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcao5.Location = new System.Drawing.Point(36, 448);
            this.txtPorcao5.Name = "txtPorcao5";
            this.txtPorcao5.Size = new System.Drawing.Size(168, 30);
            this.txtPorcao5.TabIndex = 309;
            // 
            // txtPrecoPorcao6
            // 
            this.txtPrecoPorcao6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPorcao6.Location = new System.Drawing.Point(1087, 116);
            this.txtPrecoPorcao6.Name = "txtPrecoPorcao6";
            this.txtPrecoPorcao6.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoPorcao6.TabIndex = 305;
            // 
            // txtCustoPorcao6
            // 
            this.txtCustoPorcao6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorcao6.Location = new System.Drawing.Point(977, 116);
            this.txtCustoPorcao6.Name = "txtCustoPorcao6";
            this.txtCustoPorcao6.Size = new System.Drawing.Size(82, 30);
            this.txtCustoPorcao6.TabIndex = 304;
            // 
            // lblPorcoes2
            // 
            this.lblPorcoes2.AutoSize = true;
            this.lblPorcoes2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcoes2.Location = new System.Drawing.Point(694, 76);
            this.lblPorcoes2.Name = "lblPorcoes2";
            this.lblPorcoes2.Size = new System.Drawing.Size(74, 24);
            this.lblPorcoes2.TabIndex = 302;
            this.lblPorcoes2.Text = "Porções";
            // 
            // lblPrecoPorcoes2
            // 
            this.lblPrecoPorcoes2.AutoSize = true;
            this.lblPrecoPorcoes2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcoes2.Location = new System.Drawing.Point(1081, 76);
            this.lblPrecoPorcoes2.Name = "lblPrecoPorcoes2";
            this.lblPrecoPorcoes2.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoPorcoes2.TabIndex = 301;
            this.lblPrecoPorcoes2.Text = "Preço ($)";
            // 
            // lblCustoPorcoes2
            // 
            this.lblCustoPorcoes2.AutoSize = true;
            this.lblCustoPorcoes2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcoes2.Location = new System.Drawing.Point(971, 76);
            this.lblCustoPorcoes2.Name = "lblCustoPorcoes2";
            this.lblCustoPorcoes2.Size = new System.Drawing.Size(86, 24);
            this.lblCustoPorcoes2.TabIndex = 300;
            this.lblCustoPorcoes2.Text = "Custo ($)";
            // 
            // lblImagemPorcoes2
            // 
            this.lblImagemPorcoes2.AutoSize = true;
            this.lblImagemPorcoes2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemPorcoes2.Location = new System.Drawing.Point(850, 76);
            this.lblImagemPorcoes2.Name = "lblImagemPorcoes2";
            this.lblImagemPorcoes2.Size = new System.Drawing.Size(77, 24);
            this.lblImagemPorcoes2.TabIndex = 299;
            this.lblImagemPorcoes2.Text = "Imagem";
            // 
            // lblPorcoes1
            // 
            this.lblPorcoes1.AutoSize = true;
            this.lblPorcoes1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcoes1.Location = new System.Drawing.Point(95, 76);
            this.lblPorcoes1.Name = "lblPorcoes1";
            this.lblPorcoes1.Size = new System.Drawing.Size(74, 24);
            this.lblPorcoes1.TabIndex = 295;
            this.lblPorcoes1.Text = "Porções";
            // 
            // lblPrecoPorcoes1
            // 
            this.lblPrecoPorcoes1.AutoSize = true;
            this.lblPrecoPorcoes1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcoes1.Location = new System.Drawing.Point(476, 76);
            this.lblPrecoPorcoes1.Name = "lblPrecoPorcoes1";
            this.lblPrecoPorcoes1.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoPorcoes1.TabIndex = 294;
            this.lblPrecoPorcoes1.Text = "Preço ($)";
            // 
            // txtPrecoPorcao1
            // 
            this.txtPrecoPorcao1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPorcao1.Location = new System.Drawing.Point(480, 116);
            this.txtPrecoPorcao1.Name = "txtPrecoPorcao1";
            this.txtPrecoPorcao1.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoPorcao1.TabIndex = 293;
            // 
            // lblCustoPorcoes1
            // 
            this.lblCustoPorcoes1.AutoSize = true;
            this.lblCustoPorcoes1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcoes1.Location = new System.Drawing.Point(366, 76);
            this.lblCustoPorcoes1.Name = "lblCustoPorcoes1";
            this.lblCustoPorcoes1.Size = new System.Drawing.Size(86, 24);
            this.lblCustoPorcoes1.TabIndex = 292;
            this.lblCustoPorcoes1.Text = "Custo ($)";
            // 
            // txtCustoPorcao1
            // 
            this.txtCustoPorcao1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoPorcao1.Location = new System.Drawing.Point(370, 116);
            this.txtCustoPorcao1.Name = "txtCustoPorcao1";
            this.txtCustoPorcao1.Size = new System.Drawing.Size(82, 30);
            this.txtCustoPorcao1.TabIndex = 291;
            // 
            // lblImagemPorcoes1
            // 
            this.lblImagemPorcoes1.AutoSize = true;
            this.lblImagemPorcoes1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemPorcoes1.Location = new System.Drawing.Point(245, 76);
            this.lblImagemPorcoes1.Name = "lblImagemPorcoes1";
            this.lblImagemPorcoes1.Size = new System.Drawing.Size(77, 24);
            this.lblImagemPorcoes1.TabIndex = 290;
            this.lblImagemPorcoes1.Text = "Imagem";
            // 
            // lblPorcao8
            // 
            this.lblPorcao8.AutoSize = true;
            this.lblPorcao8.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcao8.Location = new System.Drawing.Point(618, 280);
            this.lblPorcao8.Name = "lblPorcao8";
            this.lblPorcao8.Size = new System.Drawing.Size(19, 24);
            this.lblPorcao8.TabIndex = 288;
            this.lblPorcao8.Text = "8";
            // 
            // txtPorcao8
            // 
            this.txtPorcao8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcao8.Location = new System.Drawing.Point(643, 280);
            this.txtPorcao8.Name = "txtPorcao8";
            this.txtPorcao8.Size = new System.Drawing.Size(168, 30);
            this.txtPorcao8.TabIndex = 287;
            // 
            // lblPorcao4
            // 
            this.lblPorcao4.AutoSize = true;
            this.lblPorcao4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcao4.Location = new System.Drawing.Point(11, 365);
            this.lblPorcao4.Name = "lblPorcao4";
            this.lblPorcao4.Size = new System.Drawing.Size(19, 24);
            this.lblPorcao4.TabIndex = 286;
            this.lblPorcao4.Text = "4";
            // 
            // txtPorcao4
            // 
            this.txtPorcao4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcao4.Location = new System.Drawing.Point(36, 365);
            this.txtPorcao4.Name = "txtPorcao4";
            this.txtPorcao4.Size = new System.Drawing.Size(168, 30);
            this.txtPorcao4.TabIndex = 285;
            // 
            // lblPorcao7
            // 
            this.lblPorcao7.AutoSize = true;
            this.lblPorcao7.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcao7.Location = new System.Drawing.Point(618, 203);
            this.lblPorcao7.Name = "lblPorcao7";
            this.lblPorcao7.Size = new System.Drawing.Size(19, 24);
            this.lblPorcao7.TabIndex = 284;
            this.lblPorcao7.Text = "7";
            // 
            // txtPorcao7
            // 
            this.txtPorcao7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcao7.Location = new System.Drawing.Point(643, 203);
            this.txtPorcao7.Name = "txtPorcao7";
            this.txtPorcao7.Size = new System.Drawing.Size(168, 30);
            this.txtPorcao7.TabIndex = 283;
            // 
            // lblPorcao3
            // 
            this.lblPorcao3.AutoSize = true;
            this.lblPorcao3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcao3.Location = new System.Drawing.Point(11, 283);
            this.lblPorcao3.Name = "lblPorcao3";
            this.lblPorcao3.Size = new System.Drawing.Size(19, 24);
            this.lblPorcao3.TabIndex = 282;
            this.lblPorcao3.Text = "3";
            // 
            // txtPorcao3
            // 
            this.txtPorcao3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcao3.Location = new System.Drawing.Point(36, 283);
            this.txtPorcao3.Name = "txtPorcao3";
            this.txtPorcao3.Size = new System.Drawing.Size(168, 30);
            this.txtPorcao3.TabIndex = 281;
            // 
            // lblPorcao6
            // 
            this.lblPorcao6.AutoSize = true;
            this.lblPorcao6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcao6.Location = new System.Drawing.Point(618, 116);
            this.lblPorcao6.Name = "lblPorcao6";
            this.lblPorcao6.Size = new System.Drawing.Size(19, 24);
            this.lblPorcao6.TabIndex = 280;
            this.lblPorcao6.Text = "6";
            // 
            // txtPorcao6
            // 
            this.txtPorcao6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcao6.Location = new System.Drawing.Point(643, 116);
            this.txtPorcao6.Name = "txtPorcao6";
            this.txtPorcao6.Size = new System.Drawing.Size(168, 30);
            this.txtPorcao6.TabIndex = 279;
            // 
            // lblPorcao2
            // 
            this.lblPorcao2.AutoSize = true;
            this.lblPorcao2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcao2.Location = new System.Drawing.Point(11, 199);
            this.lblPorcao2.Name = "lblPorcao2";
            this.lblPorcao2.Size = new System.Drawing.Size(19, 24);
            this.lblPorcao2.TabIndex = 278;
            this.lblPorcao2.Text = "2";
            // 
            // txtPorcao2
            // 
            this.txtPorcao2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcao2.Location = new System.Drawing.Point(36, 199);
            this.txtPorcao2.Name = "txtPorcao2";
            this.txtPorcao2.Size = new System.Drawing.Size(168, 30);
            this.txtPorcao2.TabIndex = 277;
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
            // lblPorcao1
            // 
            this.lblPorcao1.AutoSize = true;
            this.lblPorcao1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcao1.Location = new System.Drawing.Point(11, 116);
            this.lblPorcao1.Name = "lblPorcao1";
            this.lblPorcao1.Size = new System.Drawing.Size(19, 24);
            this.lblPorcao1.TabIndex = 275;
            this.lblPorcao1.Text = "1";
            // 
            // txtPorcao1
            // 
            this.txtPorcao1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcao1.Location = new System.Drawing.Point(36, 116);
            this.txtPorcao1.Name = "txtPorcao1";
            this.txtPorcao1.Size = new System.Drawing.Size(168, 30);
            this.txtPorcao1.TabIndex = 274;
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
            // btnUploadImagemCadastroPorcao1
            // 
            this.btnUploadImagemCadastroPorcao1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroPorcao1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroPorcao1.Location = new System.Drawing.Point(225, 115);
            this.btnUploadImagemCadastroPorcao1.Name = "btnUploadImagemCadastroPorcao1";
            this.btnUploadImagemCadastroPorcao1.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroPorcao1.TabIndex = 333;
            this.btnUploadImagemCadastroPorcao1.Text = "Upload";
            this.btnUploadImagemCadastroPorcao1.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroPorcao1.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao1_Click);
            // 
            // btnUploadImagemCadastroPorcao2
            // 
            this.btnUploadImagemCadastroPorcao2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroPorcao2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroPorcao2.Location = new System.Drawing.Point(225, 199);
            this.btnUploadImagemCadastroPorcao2.Name = "btnUploadImagemCadastroPorcao2";
            this.btnUploadImagemCadastroPorcao2.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroPorcao2.TabIndex = 334;
            this.btnUploadImagemCadastroPorcao2.Text = "Upload";
            this.btnUploadImagemCadastroPorcao2.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroPorcao2.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao2_Click);
            // 
            // btnUploadImagemCadastroPorcao4
            // 
            this.btnUploadImagemCadastroPorcao4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroPorcao4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroPorcao4.Location = new System.Drawing.Point(225, 366);
            this.btnUploadImagemCadastroPorcao4.Name = "btnUploadImagemCadastroPorcao4";
            this.btnUploadImagemCadastroPorcao4.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroPorcao4.TabIndex = 336;
            this.btnUploadImagemCadastroPorcao4.Text = "Upload";
            this.btnUploadImagemCadastroPorcao4.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroPorcao4.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao4_Click);
            // 
            // btnUploadImagemCadastroPorcao3
            // 
            this.btnUploadImagemCadastroPorcao3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroPorcao3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroPorcao3.Location = new System.Drawing.Point(225, 283);
            this.btnUploadImagemCadastroPorcao3.Name = "btnUploadImagemCadastroPorcao3";
            this.btnUploadImagemCadastroPorcao3.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroPorcao3.TabIndex = 335;
            this.btnUploadImagemCadastroPorcao3.Text = "Upload";
            this.btnUploadImagemCadastroPorcao3.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroPorcao3.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao3_Click);
            // 
            // btnUploadImagemCadastroPorcao5
            // 
            this.btnUploadImagemCadastroPorcao5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroPorcao5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroPorcao5.Location = new System.Drawing.Point(225, 448);
            this.btnUploadImagemCadastroPorcao5.Name = "btnUploadImagemCadastroPorcao5";
            this.btnUploadImagemCadastroPorcao5.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroPorcao5.TabIndex = 337;
            this.btnUploadImagemCadastroPorcao5.Text = "Upload";
            this.btnUploadImagemCadastroPorcao5.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroPorcao5.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao5_Click);
            // 
            // btnUploadImagemCadastroPorcao10
            // 
            this.btnUploadImagemCadastroPorcao10.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroPorcao10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroPorcao10.Location = new System.Drawing.Point(832, 449);
            this.btnUploadImagemCadastroPorcao10.Name = "btnUploadImagemCadastroPorcao10";
            this.btnUploadImagemCadastroPorcao10.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroPorcao10.TabIndex = 342;
            this.btnUploadImagemCadastroPorcao10.Text = "Upload";
            this.btnUploadImagemCadastroPorcao10.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroPorcao10.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao10_Click);
            // 
            // btnUploadImagemCadastroPorcao9
            // 
            this.btnUploadImagemCadastroPorcao9.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroPorcao9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroPorcao9.Location = new System.Drawing.Point(832, 367);
            this.btnUploadImagemCadastroPorcao9.Name = "btnUploadImagemCadastroPorcao9";
            this.btnUploadImagemCadastroPorcao9.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroPorcao9.TabIndex = 341;
            this.btnUploadImagemCadastroPorcao9.Text = "Upload";
            this.btnUploadImagemCadastroPorcao9.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroPorcao9.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao9_Click);
            // 
            // btnUploadImagemCadastroPorcao8
            // 
            this.btnUploadImagemCadastroPorcao8.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroPorcao8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroPorcao8.Location = new System.Drawing.Point(832, 284);
            this.btnUploadImagemCadastroPorcao8.Name = "btnUploadImagemCadastroPorcao8";
            this.btnUploadImagemCadastroPorcao8.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroPorcao8.TabIndex = 340;
            this.btnUploadImagemCadastroPorcao8.Text = "Upload";
            this.btnUploadImagemCadastroPorcao8.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroPorcao8.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao8_Click);
            // 
            // btnUploadImagemCadastroPorcao7
            // 
            this.btnUploadImagemCadastroPorcao7.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroPorcao7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroPorcao7.Location = new System.Drawing.Point(832, 200);
            this.btnUploadImagemCadastroPorcao7.Name = "btnUploadImagemCadastroPorcao7";
            this.btnUploadImagemCadastroPorcao7.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroPorcao7.TabIndex = 339;
            this.btnUploadImagemCadastroPorcao7.Text = "Upload";
            this.btnUploadImagemCadastroPorcao7.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroPorcao7.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao7_Click);
            // 
            // btnUploadImagemCadastroPorcao6
            // 
            this.btnUploadImagemCadastroPorcao6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroPorcao6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroPorcao6.Location = new System.Drawing.Point(832, 116);
            this.btnUploadImagemCadastroPorcao6.Name = "btnUploadImagemCadastroPorcao6";
            this.btnUploadImagemCadastroPorcao6.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroPorcao6.TabIndex = 338;
            this.btnUploadImagemCadastroPorcao6.Text = "Upload";
            this.btnUploadImagemCadastroPorcao6.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroPorcao6.Click += new System.EventHandler(this.btnUploadImagemCadastroPorcao6_Click);
            // 
            // CadastroPorcoes
            // 
            this.ClientSize = new System.Drawing.Size(1177, 617);
            this.Controls.Add(this.btnUploadImagemCadastroPorcao10);
            this.Controls.Add(this.btnUploadImagemCadastroPorcao9);
            this.Controls.Add(this.btnUploadImagemCadastroPorcao8);
            this.Controls.Add(this.btnUploadImagemCadastroPorcao7);
            this.Controls.Add(this.btnUploadImagemCadastroPorcao6);
            this.Controls.Add(this.btnUploadImagemCadastroPorcao5);
            this.Controls.Add(this.btnUploadImagemCadastroPorcao4);
            this.Controls.Add(this.btnUploadImagemCadastroPorcao3);
            this.Controls.Add(this.btnUploadImagemCadastroPorcao2);
            this.Controls.Add(this.btnUploadImagemCadastroPorcao1);
            this.Controls.Add(this.lblPorcao9);
            this.Controls.Add(this.txtPorcao9);
            this.Controls.Add(this.txtPrecoPorcao9);
            this.Controls.Add(this.txtCustoPorcao9);
            this.Controls.Add(this.txtPrecoPorcao8);
            this.Controls.Add(this.txtCustoPorcao8);
            this.Controls.Add(this.txtPrecoPorcao7);
            this.Controls.Add(this.txtCustoPorcao7);
            this.Controls.Add(this.txtPrecoPorcao10);
            this.Controls.Add(this.txtCustoPorcao10);
            this.Controls.Add(this.lblPorcao10);
            this.Controls.Add(this.txtPorcao10);
            this.Controls.Add(this.txtPrecoPorcao4);
            this.Controls.Add(this.txtCustoPorcao4);
            this.Controls.Add(this.txtPrecoPorcao3);
            this.Controls.Add(this.txtCustoPorcao3);
            this.Controls.Add(this.txtPrecoPorcao2);
            this.Controls.Add(this.txtCustoPorcao2);
            this.Controls.Add(this.txtPrecoPorcao5);
            this.Controls.Add(this.txtCustoPorcao5);
            this.Controls.Add(this.lblPorcao5);
            this.Controls.Add(this.txtPorcao5);
            this.Controls.Add(this.txtPrecoPorcao6);
            this.Controls.Add(this.txtCustoPorcao6);
            this.Controls.Add(this.lblPorcoes2);
            this.Controls.Add(this.lblPrecoPorcoes2);
            this.Controls.Add(this.lblCustoPorcoes2);
            this.Controls.Add(this.lblImagemPorcoes2);
            this.Controls.Add(this.lblPorcoes1);
            this.Controls.Add(this.lblPrecoPorcoes1);
            this.Controls.Add(this.txtPrecoPorcao1);
            this.Controls.Add(this.lblCustoPorcoes1);
            this.Controls.Add(this.txtCustoPorcao1);
            this.Controls.Add(this.lblImagemPorcoes1);
            this.Controls.Add(this.lblPorcao8);
            this.Controls.Add(this.txtPorcao8);
            this.Controls.Add(this.lblPorcao4);
            this.Controls.Add(this.txtPorcao4);
            this.Controls.Add(this.lblPorcao7);
            this.Controls.Add(this.txtPorcao7);
            this.Controls.Add(this.lblPorcao3);
            this.Controls.Add(this.txtPorcao3);
            this.Controls.Add(this.lblPorcao6);
            this.Controls.Add(this.txtPorcao6);
            this.Controls.Add(this.lblPorcao2);
            this.Controls.Add(this.txtPorcao2);
            this.Controls.Add(this.btnSalvarCadastroPorcoes);
            this.Controls.Add(this.lblPorcao1);
            this.Controls.Add(this.txtPorcao1);
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
