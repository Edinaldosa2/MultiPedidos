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
        private Label lblBebida9;
        private TextBox txtBebida9;
        private TextBox txtPrecoBebida9;
        private TextBox txtCustoBebida9;
        private TextBox txtPrecoBebida8;
        private TextBox txtCustoBebida8;
        private TextBox txtPrecoBebida7;
        private TextBox txtCustoBebida7;
        private TextBox txtPrecoBebida10;
        private TextBox txtCustoBebida10;
        private PictureBox imgBebida10;
        private Label lblBebida10;
        private TextBox txtBebida10;
        private TextBox txtPrecoBebida4;
        private TextBox txtCustoBebida4;
        private TextBox txtPrecoBebida3;
        private TextBox txtCustoBebida3;
        private TextBox txtPrecoBebida2;
        private TextBox txtCustoBebida2;
        private TextBox txtPrecoBebida5;
        private TextBox txtCustoBebida5;
        private PictureBox imgBebida5;
        private Label lblBebida5;
        private TextBox txtBebida5;
        private PictureBox imgBebida9;
        private PictureBox imgBebida8;
        private PictureBox imgBebida7;
        private TextBox txtPrecoBebida6;
        private TextBox txtCustoBebida6;
        private PictureBox imgBebida6;
        private Label lblBebidas2;
        private Label lblPrecoBebidas2;
        private Label lblCustoBebidas2;
        private Label lblImagemBebidas2;
        private PictureBox imgBebida4;
        private PictureBox imgBebida3;
        private PictureBox imgBebida2;
        private Label lblBebidas1;
        private Label lblPrecoBebidas1;
        private TextBox txtPrecoBebida1;
        private Label lblCustoBebidas1;
        private TextBox txtCustoBebida1;
        private Label lblImagemBebidas1;
        private PictureBox imgBebida1;
        private Label lblBebida8;
        private TextBox txtBebida8;
        private Label lblBebida4;
        private TextBox txtBebida4;
        private Label lblBebida7;
        private TextBox txtBebida7;
        private Label lblBebida3;
        private TextBox txtBebida3;
        private Label lblBebida6;
        private TextBox txtBebida6;
        private Label lblBebida2;
        private TextBox txtBebida2;
        private Button btnSalvarCadastroBebidas;
        private Label lblBebida1;
        private TextBox txtBebida1;
        private Label lblTituloCadastroBebidas;

        public CadastroBebidas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblBebida9 = new System.Windows.Forms.Label();
            this.txtBebida9 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebida9 = new System.Windows.Forms.TextBox();
            this.txtCustoBebida9 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebida8 = new System.Windows.Forms.TextBox();
            this.txtCustoBebida8 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebida7 = new System.Windows.Forms.TextBox();
            this.txtCustoBebida7 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebida10 = new System.Windows.Forms.TextBox();
            this.txtCustoBebida10 = new System.Windows.Forms.TextBox();
            this.imgBebida10 = new System.Windows.Forms.PictureBox();
            this.lblBebida10 = new System.Windows.Forms.Label();
            this.txtBebida10 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebida4 = new System.Windows.Forms.TextBox();
            this.txtCustoBebida4 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebida3 = new System.Windows.Forms.TextBox();
            this.txtCustoBebida3 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebida2 = new System.Windows.Forms.TextBox();
            this.txtCustoBebida2 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebida5 = new System.Windows.Forms.TextBox();
            this.txtCustoBebida5 = new System.Windows.Forms.TextBox();
            this.imgBebida5 = new System.Windows.Forms.PictureBox();
            this.lblBebida5 = new System.Windows.Forms.Label();
            this.txtBebida5 = new System.Windows.Forms.TextBox();
            this.imgBebida9 = new System.Windows.Forms.PictureBox();
            this.imgBebida8 = new System.Windows.Forms.PictureBox();
            this.imgBebida7 = new System.Windows.Forms.PictureBox();
            this.txtPrecoBebida6 = new System.Windows.Forms.TextBox();
            this.txtCustoBebida6 = new System.Windows.Forms.TextBox();
            this.imgBebida6 = new System.Windows.Forms.PictureBox();
            this.lblBebidas2 = new System.Windows.Forms.Label();
            this.lblPrecoBebidas2 = new System.Windows.Forms.Label();
            this.lblCustoBebidas2 = new System.Windows.Forms.Label();
            this.lblImagemBebidas2 = new System.Windows.Forms.Label();
            this.imgBebida4 = new System.Windows.Forms.PictureBox();
            this.imgBebida3 = new System.Windows.Forms.PictureBox();
            this.imgBebida2 = new System.Windows.Forms.PictureBox();
            this.lblBebidas1 = new System.Windows.Forms.Label();
            this.lblPrecoBebidas1 = new System.Windows.Forms.Label();
            this.txtPrecoBebida1 = new System.Windows.Forms.TextBox();
            this.lblCustoBebidas1 = new System.Windows.Forms.Label();
            this.txtCustoBebida1 = new System.Windows.Forms.TextBox();
            this.lblImagemBebidas1 = new System.Windows.Forms.Label();
            this.imgBebida1 = new System.Windows.Forms.PictureBox();
            this.lblBebida8 = new System.Windows.Forms.Label();
            this.txtBebida8 = new System.Windows.Forms.TextBox();
            this.lblBebida4 = new System.Windows.Forms.Label();
            this.txtBebida4 = new System.Windows.Forms.TextBox();
            this.lblBebida7 = new System.Windows.Forms.Label();
            this.txtBebida7 = new System.Windows.Forms.TextBox();
            this.lblBebida3 = new System.Windows.Forms.Label();
            this.txtBebida3 = new System.Windows.Forms.TextBox();
            this.lblBebida6 = new System.Windows.Forms.Label();
            this.txtBebida6 = new System.Windows.Forms.TextBox();
            this.lblBebida2 = new System.Windows.Forms.Label();
            this.txtBebida2 = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroBebidas = new System.Windows.Forms.Button();
            this.lblBebida1 = new System.Windows.Forms.Label();
            this.txtBebida1 = new System.Windows.Forms.TextBox();
            this.lblTituloCadastroBebidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBebida9
            // 
            this.lblBebida9.AutoSize = true;
            this.lblBebida9.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida9.Location = new System.Drawing.Point(622, 366);
            this.lblBebida9.Name = "lblBebida9";
            this.lblBebida9.Size = new System.Drawing.Size(19, 24);
            this.lblBebida9.TabIndex = 392;
            this.lblBebida9.Text = "9";
            // 
            // txtBebida9
            // 
            this.txtBebida9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebida9.Location = new System.Drawing.Point(647, 366);
            this.txtBebida9.Name = "txtBebida9";
            this.txtBebida9.Size = new System.Drawing.Size(168, 30);
            this.txtBebida9.TabIndex = 391;
            // 
            // txtPrecoBebida9
            // 
            this.txtPrecoBebida9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebida9.Location = new System.Drawing.Point(1089, 369);
            this.txtPrecoBebida9.Name = "txtPrecoBebida9";
            this.txtPrecoBebida9.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebida9.TabIndex = 390;
            // 
            // txtCustoBebida9
            // 
            this.txtCustoBebida9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebida9.Location = new System.Drawing.Point(979, 369);
            this.txtCustoBebida9.Name = "txtCustoBebida9";
            this.txtCustoBebida9.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebida9.TabIndex = 389;
            // 
            // txtPrecoBebida8
            // 
            this.txtPrecoBebida8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebida8.Location = new System.Drawing.Point(1089, 286);
            this.txtPrecoBebida8.Name = "txtPrecoBebida8";
            this.txtPrecoBebida8.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebida8.TabIndex = 388;
            // 
            // txtCustoBebida8
            // 
            this.txtCustoBebida8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebida8.Location = new System.Drawing.Point(979, 286);
            this.txtCustoBebida8.Name = "txtCustoBebida8";
            this.txtCustoBebida8.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebida8.TabIndex = 387;
            // 
            // txtPrecoBebida7
            // 
            this.txtPrecoBebida7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebida7.Location = new System.Drawing.Point(1089, 202);
            this.txtPrecoBebida7.Name = "txtPrecoBebida7";
            this.txtPrecoBebida7.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebida7.TabIndex = 386;
            // 
            // txtCustoBebida7
            // 
            this.txtCustoBebida7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebida7.Location = new System.Drawing.Point(979, 202);
            this.txtCustoBebida7.Name = "txtCustoBebida7";
            this.txtCustoBebida7.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebida7.TabIndex = 385;
            // 
            // txtPrecoBebida10
            // 
            this.txtPrecoBebida10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebida10.Location = new System.Drawing.Point(1091, 451);
            this.txtPrecoBebida10.Name = "txtPrecoBebida10";
            this.txtPrecoBebida10.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebida10.TabIndex = 384;
            // 
            // txtCustoBebida10
            // 
            this.txtCustoBebida10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebida10.Location = new System.Drawing.Point(981, 451);
            this.txtCustoBebida10.Name = "txtCustoBebida10";
            this.txtCustoBebida10.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebida10.TabIndex = 383;
            // 
            // imgBebida10
            // 
            this.imgBebida10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebida10.Location = new System.Drawing.Point(836, 451);
            this.imgBebida10.Name = "imgBebida10";
            this.imgBebida10.Size = new System.Drawing.Size(114, 77);
            this.imgBebida10.TabIndex = 382;
            this.imgBebida10.TabStop = false;
            // 
            // lblBebida10
            // 
            this.lblBebida10.AutoSize = true;
            this.lblBebida10.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida10.Location = new System.Drawing.Point(613, 451);
            this.lblBebida10.Name = "lblBebida10";
            this.lblBebida10.Size = new System.Drawing.Size(28, 24);
            this.lblBebida10.TabIndex = 381;
            this.lblBebida10.Text = "10";
            // 
            // txtBebida10
            // 
            this.txtBebida10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebida10.Location = new System.Drawing.Point(647, 451);
            this.txtBebida10.Name = "txtBebida10";
            this.txtBebida10.Size = new System.Drawing.Size(168, 30);
            this.txtBebida10.TabIndex = 380;
            // 
            // txtPrecoBebida4
            // 
            this.txtPrecoBebida4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebida4.Location = new System.Drawing.Point(484, 369);
            this.txtPrecoBebida4.Name = "txtPrecoBebida4";
            this.txtPrecoBebida4.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebida4.TabIndex = 379;
            // 
            // txtCustoBebida4
            // 
            this.txtCustoBebida4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebida4.Location = new System.Drawing.Point(374, 369);
            this.txtCustoBebida4.Name = "txtCustoBebida4";
            this.txtCustoBebida4.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebida4.TabIndex = 378;
            // 
            // txtPrecoBebida3
            // 
            this.txtPrecoBebida3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebida3.Location = new System.Drawing.Point(484, 286);
            this.txtPrecoBebida3.Name = "txtPrecoBebida3";
            this.txtPrecoBebida3.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebida3.TabIndex = 377;
            // 
            // txtCustoBebida3
            // 
            this.txtCustoBebida3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebida3.Location = new System.Drawing.Point(374, 286);
            this.txtCustoBebida3.Name = "txtCustoBebida3";
            this.txtCustoBebida3.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebida3.TabIndex = 376;
            // 
            // txtPrecoBebida2
            // 
            this.txtPrecoBebida2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebida2.Location = new System.Drawing.Point(484, 202);
            this.txtPrecoBebida2.Name = "txtPrecoBebida2";
            this.txtPrecoBebida2.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebida2.TabIndex = 375;
            // 
            // txtCustoBebida2
            // 
            this.txtCustoBebida2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebida2.Location = new System.Drawing.Point(374, 202);
            this.txtCustoBebida2.Name = "txtCustoBebida2";
            this.txtCustoBebida2.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebida2.TabIndex = 374;
            // 
            // txtPrecoBebida5
            // 
            this.txtPrecoBebida5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebida5.Location = new System.Drawing.Point(484, 451);
            this.txtPrecoBebida5.Name = "txtPrecoBebida5";
            this.txtPrecoBebida5.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebida5.TabIndex = 373;
            // 
            // txtCustoBebida5
            // 
            this.txtCustoBebida5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebida5.Location = new System.Drawing.Point(374, 451);
            this.txtCustoBebida5.Name = "txtCustoBebida5";
            this.txtCustoBebida5.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebida5.TabIndex = 372;
            // 
            // imgBebida5
            // 
            this.imgBebida5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebida5.Location = new System.Drawing.Point(229, 451);
            this.imgBebida5.Name = "imgBebida5";
            this.imgBebida5.Size = new System.Drawing.Size(114, 77);
            this.imgBebida5.TabIndex = 371;
            this.imgBebida5.TabStop = false;
            // 
            // lblBebida5
            // 
            this.lblBebida5.AutoSize = true;
            this.lblBebida5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida5.Location = new System.Drawing.Point(15, 451);
            this.lblBebida5.Name = "lblBebida5";
            this.lblBebida5.Size = new System.Drawing.Size(19, 24);
            this.lblBebida5.TabIndex = 370;
            this.lblBebida5.Text = "5";
            // 
            // txtBebida5
            // 
            this.txtBebida5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebida5.Location = new System.Drawing.Point(40, 451);
            this.txtBebida5.Name = "txtBebida5";
            this.txtBebida5.Size = new System.Drawing.Size(168, 30);
            this.txtBebida5.TabIndex = 369;
            // 
            // imgBebida9
            // 
            this.imgBebida9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebida9.Location = new System.Drawing.Point(836, 368);
            this.imgBebida9.Name = "imgBebida9";
            this.imgBebida9.Size = new System.Drawing.Size(114, 77);
            this.imgBebida9.TabIndex = 368;
            this.imgBebida9.TabStop = false;
            // 
            // imgBebida8
            // 
            this.imgBebida8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebida8.Location = new System.Drawing.Point(836, 285);
            this.imgBebida8.Name = "imgBebida8";
            this.imgBebida8.Size = new System.Drawing.Size(114, 77);
            this.imgBebida8.TabIndex = 367;
            this.imgBebida8.TabStop = false;
            // 
            // imgBebida7
            // 
            this.imgBebida7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebida7.Location = new System.Drawing.Point(836, 202);
            this.imgBebida7.Name = "imgBebida7";
            this.imgBebida7.Size = new System.Drawing.Size(114, 77);
            this.imgBebida7.TabIndex = 366;
            this.imgBebida7.TabStop = false;
            // 
            // txtPrecoBebida6
            // 
            this.txtPrecoBebida6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebida6.Location = new System.Drawing.Point(1091, 119);
            this.txtPrecoBebida6.Name = "txtPrecoBebida6";
            this.txtPrecoBebida6.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebida6.TabIndex = 365;
            // 
            // txtCustoBebida6
            // 
            this.txtCustoBebida6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebida6.Location = new System.Drawing.Point(981, 119);
            this.txtCustoBebida6.Name = "txtCustoBebida6";
            this.txtCustoBebida6.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebida6.TabIndex = 364;
            // 
            // imgBebida6
            // 
            this.imgBebida6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebida6.Location = new System.Drawing.Point(836, 119);
            this.imgBebida6.Name = "imgBebida6";
            this.imgBebida6.Size = new System.Drawing.Size(114, 77);
            this.imgBebida6.TabIndex = 363;
            this.imgBebida6.TabStop = false;
            // 
            // lblBebidas2
            // 
            this.lblBebidas2.AutoSize = true;
            this.lblBebidas2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidas2.Location = new System.Drawing.Point(698, 79);
            this.lblBebidas2.Name = "lblBebidas2";
            this.lblBebidas2.Size = new System.Drawing.Size(76, 24);
            this.lblBebidas2.TabIndex = 362;
            this.lblBebidas2.Text = "Bebidas";
            // 
            // lblPrecoBebidas2
            // 
            this.lblPrecoBebidas2.AutoSize = true;
            this.lblPrecoBebidas2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoBebidas2.Location = new System.Drawing.Point(1085, 79);
            this.lblPrecoBebidas2.Name = "lblPrecoBebidas2";
            this.lblPrecoBebidas2.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoBebidas2.TabIndex = 361;
            this.lblPrecoBebidas2.Text = "Preço ($)";
            // 
            // lblCustoBebidas2
            // 
            this.lblCustoBebidas2.AutoSize = true;
            this.lblCustoBebidas2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoBebidas2.Location = new System.Drawing.Point(975, 79);
            this.lblCustoBebidas2.Name = "lblCustoBebidas2";
            this.lblCustoBebidas2.Size = new System.Drawing.Size(86, 24);
            this.lblCustoBebidas2.TabIndex = 360;
            this.lblCustoBebidas2.Text = "Custo ($)";
            // 
            // lblImagemBebidas2
            // 
            this.lblImagemBebidas2.AutoSize = true;
            this.lblImagemBebidas2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemBebidas2.Location = new System.Drawing.Point(854, 79);
            this.lblImagemBebidas2.Name = "lblImagemBebidas2";
            this.lblImagemBebidas2.Size = new System.Drawing.Size(77, 24);
            this.lblImagemBebidas2.TabIndex = 359;
            this.lblImagemBebidas2.Text = "Imagem";
            // 
            // imgBebida4
            // 
            this.imgBebida4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebida4.Location = new System.Drawing.Point(229, 368);
            this.imgBebida4.Name = "imgBebida4";
            this.imgBebida4.Size = new System.Drawing.Size(114, 77);
            this.imgBebida4.TabIndex = 358;
            this.imgBebida4.TabStop = false;
            // 
            // imgBebida3
            // 
            this.imgBebida3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebida3.Location = new System.Drawing.Point(229, 285);
            this.imgBebida3.Name = "imgBebida3";
            this.imgBebida3.Size = new System.Drawing.Size(114, 77);
            this.imgBebida3.TabIndex = 357;
            this.imgBebida3.TabStop = false;
            // 
            // imgBebida2
            // 
            this.imgBebida2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebida2.Location = new System.Drawing.Point(229, 202);
            this.imgBebida2.Name = "imgBebida2";
            this.imgBebida2.Size = new System.Drawing.Size(114, 77);
            this.imgBebida2.TabIndex = 356;
            this.imgBebida2.TabStop = false;
            // 
            // lblBebidas1
            // 
            this.lblBebidas1.AutoSize = true;
            this.lblBebidas1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidas1.Location = new System.Drawing.Point(99, 79);
            this.lblBebidas1.Name = "lblBebidas1";
            this.lblBebidas1.Size = new System.Drawing.Size(76, 24);
            this.lblBebidas1.TabIndex = 355;
            this.lblBebidas1.Text = "Bebidas";
            // 
            // lblPrecoBebidas1
            // 
            this.lblPrecoBebidas1.AutoSize = true;
            this.lblPrecoBebidas1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoBebidas1.Location = new System.Drawing.Point(480, 79);
            this.lblPrecoBebidas1.Name = "lblPrecoBebidas1";
            this.lblPrecoBebidas1.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoBebidas1.TabIndex = 354;
            this.lblPrecoBebidas1.Text = "Preço ($)";
            // 
            // txtPrecoBebida1
            // 
            this.txtPrecoBebida1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebida1.Location = new System.Drawing.Point(484, 119);
            this.txtPrecoBebida1.Name = "txtPrecoBebida1";
            this.txtPrecoBebida1.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebida1.TabIndex = 353;
            // 
            // lblCustoBebidas1
            // 
            this.lblCustoBebidas1.AutoSize = true;
            this.lblCustoBebidas1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoBebidas1.Location = new System.Drawing.Point(370, 79);
            this.lblCustoBebidas1.Name = "lblCustoBebidas1";
            this.lblCustoBebidas1.Size = new System.Drawing.Size(86, 24);
            this.lblCustoBebidas1.TabIndex = 352;
            this.lblCustoBebidas1.Text = "Custo ($)";
            // 
            // txtCustoBebida1
            // 
            this.txtCustoBebida1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebida1.Location = new System.Drawing.Point(374, 119);
            this.txtCustoBebida1.Name = "txtCustoBebida1";
            this.txtCustoBebida1.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebida1.TabIndex = 351;
            // 
            // lblImagemBebidas1
            // 
            this.lblImagemBebidas1.AutoSize = true;
            this.lblImagemBebidas1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemBebidas1.Location = new System.Drawing.Point(249, 79);
            this.lblImagemBebidas1.Name = "lblImagemBebidas1";
            this.lblImagemBebidas1.Size = new System.Drawing.Size(77, 24);
            this.lblImagemBebidas1.TabIndex = 350;
            this.lblImagemBebidas1.Text = "Imagem";
            // 
            // imgBebida1
            // 
            this.imgBebida1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebida1.Location = new System.Drawing.Point(229, 119);
            this.imgBebida1.Name = "imgBebida1";
            this.imgBebida1.Size = new System.Drawing.Size(114, 77);
            this.imgBebida1.TabIndex = 349;
            this.imgBebida1.TabStop = false;
            // 
            // lblBebida8
            // 
            this.lblBebida8.AutoSize = true;
            this.lblBebida8.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida8.Location = new System.Drawing.Point(622, 283);
            this.lblBebida8.Name = "lblBebida8";
            this.lblBebida8.Size = new System.Drawing.Size(19, 24);
            this.lblBebida8.TabIndex = 348;
            this.lblBebida8.Text = "8";
            // 
            // txtBebida8
            // 
            this.txtBebida8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebida8.Location = new System.Drawing.Point(647, 283);
            this.txtBebida8.Name = "txtBebida8";
            this.txtBebida8.Size = new System.Drawing.Size(168, 30);
            this.txtBebida8.TabIndex = 347;
            // 
            // lblBebida4
            // 
            this.lblBebida4.AutoSize = true;
            this.lblBebida4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida4.Location = new System.Drawing.Point(15, 368);
            this.lblBebida4.Name = "lblBebida4";
            this.lblBebida4.Size = new System.Drawing.Size(19, 24);
            this.lblBebida4.TabIndex = 346;
            this.lblBebida4.Text = "4";
            // 
            // txtBebida4
            // 
            this.txtBebida4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebida4.Location = new System.Drawing.Point(40, 368);
            this.txtBebida4.Name = "txtBebida4";
            this.txtBebida4.Size = new System.Drawing.Size(168, 30);
            this.txtBebida4.TabIndex = 345;
            // 
            // lblBebida7
            // 
            this.lblBebida7.AutoSize = true;
            this.lblBebida7.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida7.Location = new System.Drawing.Point(622, 206);
            this.lblBebida7.Name = "lblBebida7";
            this.lblBebida7.Size = new System.Drawing.Size(19, 24);
            this.lblBebida7.TabIndex = 344;
            this.lblBebida7.Text = "7";
            // 
            // txtBebida7
            // 
            this.txtBebida7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebida7.Location = new System.Drawing.Point(647, 206);
            this.txtBebida7.Name = "txtBebida7";
            this.txtBebida7.Size = new System.Drawing.Size(168, 30);
            this.txtBebida7.TabIndex = 343;
            // 
            // lblBebida3
            // 
            this.lblBebida3.AutoSize = true;
            this.lblBebida3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida3.Location = new System.Drawing.Point(15, 286);
            this.lblBebida3.Name = "lblBebida3";
            this.lblBebida3.Size = new System.Drawing.Size(19, 24);
            this.lblBebida3.TabIndex = 342;
            this.lblBebida3.Text = "3";
            // 
            // txtBebida3
            // 
            this.txtBebida3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebida3.Location = new System.Drawing.Point(40, 286);
            this.txtBebida3.Name = "txtBebida3";
            this.txtBebida3.Size = new System.Drawing.Size(168, 30);
            this.txtBebida3.TabIndex = 341;
            // 
            // lblBebida6
            // 
            this.lblBebida6.AutoSize = true;
            this.lblBebida6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida6.Location = new System.Drawing.Point(622, 119);
            this.lblBebida6.Name = "lblBebida6";
            this.lblBebida6.Size = new System.Drawing.Size(19, 24);
            this.lblBebida6.TabIndex = 340;
            this.lblBebida6.Text = "6";
            // 
            // txtBebida6
            // 
            this.txtBebida6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebida6.Location = new System.Drawing.Point(647, 119);
            this.txtBebida6.Name = "txtBebida6";
            this.txtBebida6.Size = new System.Drawing.Size(168, 30);
            this.txtBebida6.TabIndex = 339;
            // 
            // lblBebida2
            // 
            this.lblBebida2.AutoSize = true;
            this.lblBebida2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida2.Location = new System.Drawing.Point(15, 202);
            this.lblBebida2.Name = "lblBebida2";
            this.lblBebida2.Size = new System.Drawing.Size(19, 24);
            this.lblBebida2.TabIndex = 338;
            this.lblBebida2.Text = "2";
            // 
            // txtBebida2
            // 
            this.txtBebida2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebida2.Location = new System.Drawing.Point(40, 202);
            this.txtBebida2.Name = "txtBebida2";
            this.txtBebida2.Size = new System.Drawing.Size(168, 30);
            this.txtBebida2.TabIndex = 337;
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
            // lblBebida1
            // 
            this.lblBebida1.AutoSize = true;
            this.lblBebida1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida1.Location = new System.Drawing.Point(15, 119);
            this.lblBebida1.Name = "lblBebida1";
            this.lblBebida1.Size = new System.Drawing.Size(19, 24);
            this.lblBebida1.TabIndex = 335;
            this.lblBebida1.Text = "1";
            // 
            // txtBebida1
            // 
            this.txtBebida1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebida1.Location = new System.Drawing.Point(40, 119);
            this.txtBebida1.Name = "txtBebida1";
            this.txtBebida1.Size = new System.Drawing.Size(168, 30);
            this.txtBebida1.TabIndex = 334;
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
            // CadastrarBebidas
            // 
            this.ClientSize = new System.Drawing.Size(1185, 617);
            this.Controls.Add(this.lblBebida9);
            this.Controls.Add(this.txtBebida9);
            this.Controls.Add(this.txtPrecoBebida9);
            this.Controls.Add(this.txtCustoBebida9);
            this.Controls.Add(this.txtPrecoBebida8);
            this.Controls.Add(this.txtCustoBebida8);
            this.Controls.Add(this.txtPrecoBebida7);
            this.Controls.Add(this.txtCustoBebida7);
            this.Controls.Add(this.txtPrecoBebida10);
            this.Controls.Add(this.txtCustoBebida10);
            this.Controls.Add(this.imgBebida10);
            this.Controls.Add(this.lblBebida10);
            this.Controls.Add(this.txtBebida10);
            this.Controls.Add(this.txtPrecoBebida4);
            this.Controls.Add(this.txtCustoBebida4);
            this.Controls.Add(this.txtPrecoBebida3);
            this.Controls.Add(this.txtCustoBebida3);
            this.Controls.Add(this.txtPrecoBebida2);
            this.Controls.Add(this.txtCustoBebida2);
            this.Controls.Add(this.txtPrecoBebida5);
            this.Controls.Add(this.txtCustoBebida5);
            this.Controls.Add(this.imgBebida5);
            this.Controls.Add(this.lblBebida5);
            this.Controls.Add(this.txtBebida5);
            this.Controls.Add(this.imgBebida9);
            this.Controls.Add(this.imgBebida8);
            this.Controls.Add(this.imgBebida7);
            this.Controls.Add(this.txtPrecoBebida6);
            this.Controls.Add(this.txtCustoBebida6);
            this.Controls.Add(this.imgBebida6);
            this.Controls.Add(this.lblBebidas2);
            this.Controls.Add(this.lblPrecoBebidas2);
            this.Controls.Add(this.lblCustoBebidas2);
            this.Controls.Add(this.lblImagemBebidas2);
            this.Controls.Add(this.imgBebida4);
            this.Controls.Add(this.imgBebida3);
            this.Controls.Add(this.imgBebida2);
            this.Controls.Add(this.lblBebidas1);
            this.Controls.Add(this.lblPrecoBebidas1);
            this.Controls.Add(this.txtPrecoBebida1);
            this.Controls.Add(this.lblCustoBebidas1);
            this.Controls.Add(this.txtCustoBebida1);
            this.Controls.Add(this.lblImagemBebidas1);
            this.Controls.Add(this.imgBebida1);
            this.Controls.Add(this.lblBebida8);
            this.Controls.Add(this.txtBebida8);
            this.Controls.Add(this.lblBebida4);
            this.Controls.Add(this.txtBebida4);
            this.Controls.Add(this.lblBebida7);
            this.Controls.Add(this.txtBebida7);
            this.Controls.Add(this.lblBebida3);
            this.Controls.Add(this.txtBebida3);
            this.Controls.Add(this.lblBebida6);
            this.Controls.Add(this.txtBebida6);
            this.Controls.Add(this.lblBebida2);
            this.Controls.Add(this.txtBebida2);
            this.Controls.Add(this.btnSalvarCadastroBebidas);
            this.Controls.Add(this.lblBebida1);
            this.Controls.Add(this.txtBebida1);
            this.Controls.Add(this.lblTituloCadastroBebidas);
            this.Name = "CadastrarBebidas";
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebida1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
