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
    public partial class CadastroBebidasVisualizar : Form
    {
        private Label lblBebidaVisualizar9;
        private TextBox txtBebidaVisualizar9;
        private TextBox txtPrecoBebidaVisualizar9;
        private TextBox txtCustoBebidaVisualizar9;
        private TextBox txtPrecoBebidaVisualizar8;
        private TextBox txtCustoBebidaVisualizar8;
        private TextBox txtPrecoBebidaVisualizar7;
        private TextBox txtCustoBebidaVisualizar7;
        private TextBox txtPrecoBebidaVisualizar10;
        private TextBox txtCustoBebidaVisualizar10;
        private PictureBox imgBebidaVisualizar10;
        private Label lblBebidaVisualizar10;
        private TextBox txtBebidaVisualizar10;
        private TextBox txtPrecoBebidaVisualizar4;
        private TextBox txtCustoBebidaVisualizar4;
        private TextBox txtPrecoBebidaVisualizar3;
        private TextBox txtCustoBebidaVisualizar3;
        private TextBox txtPrecoBebidaVisualizar2;
        private TextBox txtCustoBebidaVisualizar2;
        private TextBox txtPrecoBebidaVisualizar5;
        private TextBox txtCustoBebidaVisualizar5;
        private PictureBox imgBebidaVisualizar5;
        private Label lblBebidaVisualizar5;
        private TextBox txtBebidaVisualizar5;
        private PictureBox imgBebidaVisualizar9;
        private PictureBox imgBebidaVisualizar8;
        private PictureBox imgBebidaVisualizar7;
        private TextBox txtPrecoBebidaVisualizar6;
        private TextBox txtCustoBebidaVisualizar6;
        private PictureBox imgBebidaVisualizar6;
        private Label lblBebidasVisualizar2;
        private Label lblPrecoBebidasVisualizar2;
        private Label lblCustoBebidasVisualizar2;
        private Label lblImagemBebidasVisualizar2;
        private PictureBox imgBebidaVisualizar4;
        private PictureBox imgBebidaVisualizar3;
        private PictureBox imgBebidaVisualizar2;
        private Label lblBebidasVisualizar1;
        private Label lblPrecoBebidasVisualizar1;
        private TextBox txtPrecoBebidaVisualizar1;
        private Label lblCustoBebidasVisualizar1;
        private TextBox txtCustoBebidaVisualizar1;
        private Label lblImagemBebidasVisualizar1;
        private PictureBox imgBebidaVisualizar1;
        private Label lblBebidaVisualizar8;
        private TextBox txtBebidaVisualizar8;
        private Label lblBebidaVisualizar4;
        private TextBox txtBebidaVisualizar4;
        private Label lblBebidaVisualizar7;
        private TextBox txtBebidaVisualizar7;
        private Label lblBebidaVisualizar3;
        private TextBox txtBebidaVisualizar3;
        private Label lblBebidaVisualizar6;
        private TextBox txtBebidaVisualizar6;
        private Label lblBebidaVisualizar2;
        private TextBox txtBebidaVisualizar2;
        private Button btnSalvarCadastroBebidasVisualizar;
        private Label lblBebidaVisualizar1;
        private TextBox txtBebidaVisualizar1;
        private Label lblTituloCadastroBebidasVisualizar;

        public CadastroBebidasVisualizar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblBebidaVisualizar9 = new System.Windows.Forms.Label();
            this.txtBebidaVisualizar9 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebidaVisualizar9 = new System.Windows.Forms.TextBox();
            this.txtCustoBebidaVisualizar9 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebidaVisualizar8 = new System.Windows.Forms.TextBox();
            this.txtCustoBebidaVisualizar8 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebidaVisualizar7 = new System.Windows.Forms.TextBox();
            this.txtCustoBebidaVisualizar7 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebidaVisualizar10 = new System.Windows.Forms.TextBox();
            this.txtCustoBebidaVisualizar10 = new System.Windows.Forms.TextBox();
            this.imgBebidaVisualizar10 = new System.Windows.Forms.PictureBox();
            this.lblBebidaVisualizar10 = new System.Windows.Forms.Label();
            this.txtBebidaVisualizar10 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebidaVisualizar4 = new System.Windows.Forms.TextBox();
            this.txtCustoBebidaVisualizar4 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebidaVisualizar3 = new System.Windows.Forms.TextBox();
            this.txtCustoBebidaVisualizar3 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebidaVisualizar2 = new System.Windows.Forms.TextBox();
            this.txtCustoBebidaVisualizar2 = new System.Windows.Forms.TextBox();
            this.txtPrecoBebidaVisualizar5 = new System.Windows.Forms.TextBox();
            this.txtCustoBebidaVisualizar5 = new System.Windows.Forms.TextBox();
            this.imgBebidaVisualizar5 = new System.Windows.Forms.PictureBox();
            this.lblBebidaVisualizar5 = new System.Windows.Forms.Label();
            this.txtBebidaVisualizar5 = new System.Windows.Forms.TextBox();
            this.imgBebidaVisualizar9 = new System.Windows.Forms.PictureBox();
            this.imgBebidaVisualizar8 = new System.Windows.Forms.PictureBox();
            this.imgBebidaVisualizar7 = new System.Windows.Forms.PictureBox();
            this.txtPrecoBebidaVisualizar6 = new System.Windows.Forms.TextBox();
            this.txtCustoBebidaVisualizar6 = new System.Windows.Forms.TextBox();
            this.imgBebidaVisualizar6 = new System.Windows.Forms.PictureBox();
            this.lblBebidasVisualizar2 = new System.Windows.Forms.Label();
            this.lblPrecoBebidasVisualizar2 = new System.Windows.Forms.Label();
            this.lblCustoBebidasVisualizar2 = new System.Windows.Forms.Label();
            this.lblImagemBebidasVisualizar2 = new System.Windows.Forms.Label();
            this.imgBebidaVisualizar4 = new System.Windows.Forms.PictureBox();
            this.imgBebidaVisualizar3 = new System.Windows.Forms.PictureBox();
            this.imgBebidaVisualizar2 = new System.Windows.Forms.PictureBox();
            this.lblBebidasVisualizar1 = new System.Windows.Forms.Label();
            this.lblPrecoBebidasVisualizar1 = new System.Windows.Forms.Label();
            this.txtPrecoBebidaVisualizar1 = new System.Windows.Forms.TextBox();
            this.lblCustoBebidasVisualizar1 = new System.Windows.Forms.Label();
            this.txtCustoBebidaVisualizar1 = new System.Windows.Forms.TextBox();
            this.lblImagemBebidasVisualizar1 = new System.Windows.Forms.Label();
            this.imgBebidaVisualizar1 = new System.Windows.Forms.PictureBox();
            this.lblBebidaVisualizar8 = new System.Windows.Forms.Label();
            this.txtBebidaVisualizar8 = new System.Windows.Forms.TextBox();
            this.lblBebidaVisualizar4 = new System.Windows.Forms.Label();
            this.txtBebidaVisualizar4 = new System.Windows.Forms.TextBox();
            this.lblBebidaVisualizar7 = new System.Windows.Forms.Label();
            this.txtBebidaVisualizar7 = new System.Windows.Forms.TextBox();
            this.lblBebidaVisualizar3 = new System.Windows.Forms.Label();
            this.txtBebidaVisualizar3 = new System.Windows.Forms.TextBox();
            this.lblBebidaVisualizar6 = new System.Windows.Forms.Label();
            this.txtBebidaVisualizar6 = new System.Windows.Forms.TextBox();
            this.lblBebidaVisualizar2 = new System.Windows.Forms.Label();
            this.txtBebidaVisualizar2 = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroBebidasVisualizar = new System.Windows.Forms.Button();
            this.lblBebidaVisualizar1 = new System.Windows.Forms.Label();
            this.txtBebidaVisualizar1 = new System.Windows.Forms.TextBox();
            this.lblTituloCadastroBebidasVisualizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBebidaVisualizar9
            // 
            this.lblBebidaVisualizar9.AutoSize = true;
            this.lblBebidaVisualizar9.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaVisualizar9.Location = new System.Drawing.Point(638, 369);
            this.lblBebidaVisualizar9.Name = "lblBebidaVisualizar9";
            this.lblBebidaVisualizar9.Size = new System.Drawing.Size(19, 24);
            this.lblBebidaVisualizar9.TabIndex = 452;
            this.lblBebidaVisualizar9.Text = "9";
            // 
            // txtBebidaVisualizar9
            // 
            this.txtBebidaVisualizar9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebidaVisualizar9.Location = new System.Drawing.Point(663, 369);
            this.txtBebidaVisualizar9.Name = "txtBebidaVisualizar9";
            this.txtBebidaVisualizar9.Size = new System.Drawing.Size(168, 30);
            this.txtBebidaVisualizar9.TabIndex = 451;
            // 
            // txtPrecoBebidaVisualizar9
            // 
            this.txtPrecoBebidaVisualizar9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebidaVisualizar9.Location = new System.Drawing.Point(1105, 372);
            this.txtPrecoBebidaVisualizar9.Name = "txtPrecoBebidaVisualizar9";
            this.txtPrecoBebidaVisualizar9.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebidaVisualizar9.TabIndex = 450;
            // 
            // txtCustoBebidaVisualizar9
            // 
            this.txtCustoBebidaVisualizar9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebidaVisualizar9.Location = new System.Drawing.Point(995, 372);
            this.txtCustoBebidaVisualizar9.Name = "txtCustoBebidaVisualizar9";
            this.txtCustoBebidaVisualizar9.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebidaVisualizar9.TabIndex = 449;
            // 
            // txtPrecoBebidaVisualizar8
            // 
            this.txtPrecoBebidaVisualizar8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebidaVisualizar8.Location = new System.Drawing.Point(1105, 289);
            this.txtPrecoBebidaVisualizar8.Name = "txtPrecoBebidaVisualizar8";
            this.txtPrecoBebidaVisualizar8.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebidaVisualizar8.TabIndex = 448;
            // 
            // txtCustoBebidaVisualizar8
            // 
            this.txtCustoBebidaVisualizar8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebidaVisualizar8.Location = new System.Drawing.Point(995, 289);
            this.txtCustoBebidaVisualizar8.Name = "txtCustoBebidaVisualizar8";
            this.txtCustoBebidaVisualizar8.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebidaVisualizar8.TabIndex = 447;
            // 
            // txtPrecoBebidaVisualizar7
            // 
            this.txtPrecoBebidaVisualizar7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebidaVisualizar7.Location = new System.Drawing.Point(1105, 205);
            this.txtPrecoBebidaVisualizar7.Name = "txtPrecoBebidaVisualizar7";
            this.txtPrecoBebidaVisualizar7.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebidaVisualizar7.TabIndex = 446;
            // 
            // txtCustoBebidaVisualizar7
            // 
            this.txtCustoBebidaVisualizar7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebidaVisualizar7.Location = new System.Drawing.Point(995, 205);
            this.txtCustoBebidaVisualizar7.Name = "txtCustoBebidaVisualizar7";
            this.txtCustoBebidaVisualizar7.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebidaVisualizar7.TabIndex = 445;
            // 
            // txtPrecoBebidaVisualizar10
            // 
            this.txtPrecoBebidaVisualizar10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebidaVisualizar10.Location = new System.Drawing.Point(1107, 454);
            this.txtPrecoBebidaVisualizar10.Name = "txtPrecoBebidaVisualizar10";
            this.txtPrecoBebidaVisualizar10.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebidaVisualizar10.TabIndex = 444;
            // 
            // txtCustoBebidaVisualizar10
            // 
            this.txtCustoBebidaVisualizar10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebidaVisualizar10.Location = new System.Drawing.Point(997, 454);
            this.txtCustoBebidaVisualizar10.Name = "txtCustoBebidaVisualizar10";
            this.txtCustoBebidaVisualizar10.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebidaVisualizar10.TabIndex = 443;
            // 
            // imgBebidaVisualizar10
            // 
            this.imgBebidaVisualizar10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebidaVisualizar10.Location = new System.Drawing.Point(852, 454);
            this.imgBebidaVisualizar10.Name = "imgBebidaVisualizar10";
            this.imgBebidaVisualizar10.Size = new System.Drawing.Size(114, 77);
            this.imgBebidaVisualizar10.TabIndex = 442;
            this.imgBebidaVisualizar10.TabStop = false;
            // 
            // lblBebidaVisualizar10
            // 
            this.lblBebidaVisualizar10.AutoSize = true;
            this.lblBebidaVisualizar10.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaVisualizar10.Location = new System.Drawing.Point(629, 454);
            this.lblBebidaVisualizar10.Name = "lblBebidaVisualizar10";
            this.lblBebidaVisualizar10.Size = new System.Drawing.Size(28, 24);
            this.lblBebidaVisualizar10.TabIndex = 441;
            this.lblBebidaVisualizar10.Text = "10";
            // 
            // txtBebidaVisualizar10
            // 
            this.txtBebidaVisualizar10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebidaVisualizar10.Location = new System.Drawing.Point(663, 454);
            this.txtBebidaVisualizar10.Name = "txtBebidaVisualizar10";
            this.txtBebidaVisualizar10.Size = new System.Drawing.Size(168, 30);
            this.txtBebidaVisualizar10.TabIndex = 440;
            // 
            // txtPrecoBebidaVisualizar4
            // 
            this.txtPrecoBebidaVisualizar4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebidaVisualizar4.Location = new System.Drawing.Point(500, 372);
            this.txtPrecoBebidaVisualizar4.Name = "txtPrecoBebidaVisualizar4";
            this.txtPrecoBebidaVisualizar4.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebidaVisualizar4.TabIndex = 439;
            // 
            // txtCustoBebidaVisualizar4
            // 
            this.txtCustoBebidaVisualizar4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebidaVisualizar4.Location = new System.Drawing.Point(390, 372);
            this.txtCustoBebidaVisualizar4.Name = "txtCustoBebidaVisualizar4";
            this.txtCustoBebidaVisualizar4.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebidaVisualizar4.TabIndex = 438;
            // 
            // txtPrecoBebidaVisualizar3
            // 
            this.txtPrecoBebidaVisualizar3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebidaVisualizar3.Location = new System.Drawing.Point(500, 289);
            this.txtPrecoBebidaVisualizar3.Name = "txtPrecoBebidaVisualizar3";
            this.txtPrecoBebidaVisualizar3.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebidaVisualizar3.TabIndex = 437;
            // 
            // txtCustoBebidaVisualizar3
            // 
            this.txtCustoBebidaVisualizar3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebidaVisualizar3.Location = new System.Drawing.Point(390, 289);
            this.txtCustoBebidaVisualizar3.Name = "txtCustoBebidaVisualizar3";
            this.txtCustoBebidaVisualizar3.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebidaVisualizar3.TabIndex = 436;
            // 
            // txtPrecoBebidaVisualizar2
            // 
            this.txtPrecoBebidaVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebidaVisualizar2.Location = new System.Drawing.Point(500, 205);
            this.txtPrecoBebidaVisualizar2.Name = "txtPrecoBebidaVisualizar2";
            this.txtPrecoBebidaVisualizar2.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebidaVisualizar2.TabIndex = 435;
            // 
            // txtCustoBebidaVisualizar2
            // 
            this.txtCustoBebidaVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebidaVisualizar2.Location = new System.Drawing.Point(390, 205);
            this.txtCustoBebidaVisualizar2.Name = "txtCustoBebidaVisualizar2";
            this.txtCustoBebidaVisualizar2.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebidaVisualizar2.TabIndex = 434;
            // 
            // txtPrecoBebidaVisualizar5
            // 
            this.txtPrecoBebidaVisualizar5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebidaVisualizar5.Location = new System.Drawing.Point(500, 454);
            this.txtPrecoBebidaVisualizar5.Name = "txtPrecoBebidaVisualizar5";
            this.txtPrecoBebidaVisualizar5.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebidaVisualizar5.TabIndex = 433;
            // 
            // txtCustoBebidaVisualizar5
            // 
            this.txtCustoBebidaVisualizar5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebidaVisualizar5.Location = new System.Drawing.Point(390, 454);
            this.txtCustoBebidaVisualizar5.Name = "txtCustoBebidaVisualizar5";
            this.txtCustoBebidaVisualizar5.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebidaVisualizar5.TabIndex = 432;
            // 
            // imgBebidaVisualizar5
            // 
            this.imgBebidaVisualizar5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebidaVisualizar5.Location = new System.Drawing.Point(245, 454);
            this.imgBebidaVisualizar5.Name = "imgBebidaVisualizar5";
            this.imgBebidaVisualizar5.Size = new System.Drawing.Size(114, 77);
            this.imgBebidaVisualizar5.TabIndex = 431;
            this.imgBebidaVisualizar5.TabStop = false;
            // 
            // lblBebidaVisualizar5
            // 
            this.lblBebidaVisualizar5.AutoSize = true;
            this.lblBebidaVisualizar5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaVisualizar5.Location = new System.Drawing.Point(31, 454);
            this.lblBebidaVisualizar5.Name = "lblBebidaVisualizar5";
            this.lblBebidaVisualizar5.Size = new System.Drawing.Size(19, 24);
            this.lblBebidaVisualizar5.TabIndex = 430;
            this.lblBebidaVisualizar5.Text = "5";
            // 
            // txtBebidaVisualizar5
            // 
            this.txtBebidaVisualizar5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebidaVisualizar5.Location = new System.Drawing.Point(56, 454);
            this.txtBebidaVisualizar5.Name = "txtBebidaVisualizar5";
            this.txtBebidaVisualizar5.Size = new System.Drawing.Size(168, 30);
            this.txtBebidaVisualizar5.TabIndex = 429;
            // 
            // imgBebidaVisualizar9
            // 
            this.imgBebidaVisualizar9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebidaVisualizar9.Location = new System.Drawing.Point(852, 371);
            this.imgBebidaVisualizar9.Name = "imgBebidaVisualizar9";
            this.imgBebidaVisualizar9.Size = new System.Drawing.Size(114, 77);
            this.imgBebidaVisualizar9.TabIndex = 428;
            this.imgBebidaVisualizar9.TabStop = false;
            // 
            // imgBebidaVisualizar8
            // 
            this.imgBebidaVisualizar8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebidaVisualizar8.Location = new System.Drawing.Point(852, 288);
            this.imgBebidaVisualizar8.Name = "imgBebidaVisualizar8";
            this.imgBebidaVisualizar8.Size = new System.Drawing.Size(114, 77);
            this.imgBebidaVisualizar8.TabIndex = 427;
            this.imgBebidaVisualizar8.TabStop = false;
            // 
            // imgBebidaVisualizar7
            // 
            this.imgBebidaVisualizar7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebidaVisualizar7.Location = new System.Drawing.Point(852, 205);
            this.imgBebidaVisualizar7.Name = "imgBebidaVisualizar7";
            this.imgBebidaVisualizar7.Size = new System.Drawing.Size(114, 77);
            this.imgBebidaVisualizar7.TabIndex = 426;
            this.imgBebidaVisualizar7.TabStop = false;
            // 
            // txtPrecoBebidaVisualizar6
            // 
            this.txtPrecoBebidaVisualizar6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebidaVisualizar6.Location = new System.Drawing.Point(1107, 122);
            this.txtPrecoBebidaVisualizar6.Name = "txtPrecoBebidaVisualizar6";
            this.txtPrecoBebidaVisualizar6.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebidaVisualizar6.TabIndex = 425;
            // 
            // txtCustoBebidaVisualizar6
            // 
            this.txtCustoBebidaVisualizar6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebidaVisualizar6.Location = new System.Drawing.Point(997, 122);
            this.txtCustoBebidaVisualizar6.Name = "txtCustoBebidaVisualizar6";
            this.txtCustoBebidaVisualizar6.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebidaVisualizar6.TabIndex = 424;
            // 
            // imgBebidaVisualizar6
            // 
            this.imgBebidaVisualizar6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebidaVisualizar6.Location = new System.Drawing.Point(852, 122);
            this.imgBebidaVisualizar6.Name = "imgBebidaVisualizar6";
            this.imgBebidaVisualizar6.Size = new System.Drawing.Size(114, 77);
            this.imgBebidaVisualizar6.TabIndex = 423;
            this.imgBebidaVisualizar6.TabStop = false;
            // 
            // lblBebidasVisualizar2
            // 
            this.lblBebidasVisualizar2.AutoSize = true;
            this.lblBebidasVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidasVisualizar2.Location = new System.Drawing.Point(714, 82);
            this.lblBebidasVisualizar2.Name = "lblBebidasVisualizar2";
            this.lblBebidasVisualizar2.Size = new System.Drawing.Size(76, 24);
            this.lblBebidasVisualizar2.TabIndex = 422;
            this.lblBebidasVisualizar2.Text = "Bebidas";
            // 
            // lblPrecoBebidasVisualizar2
            // 
            this.lblPrecoBebidasVisualizar2.AutoSize = true;
            this.lblPrecoBebidasVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoBebidasVisualizar2.Location = new System.Drawing.Point(1101, 82);
            this.lblPrecoBebidasVisualizar2.Name = "lblPrecoBebidasVisualizar2";
            this.lblPrecoBebidasVisualizar2.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoBebidasVisualizar2.TabIndex = 421;
            this.lblPrecoBebidasVisualizar2.Text = "Preço ($)";
            // 
            // lblCustoBebidasVisualizar2
            // 
            this.lblCustoBebidasVisualizar2.AutoSize = true;
            this.lblCustoBebidasVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoBebidasVisualizar2.Location = new System.Drawing.Point(991, 82);
            this.lblCustoBebidasVisualizar2.Name = "lblCustoBebidasVisualizar2";
            this.lblCustoBebidasVisualizar2.Size = new System.Drawing.Size(86, 24);
            this.lblCustoBebidasVisualizar2.TabIndex = 420;
            this.lblCustoBebidasVisualizar2.Text = "Custo ($)";
            // 
            // lblImagemBebidasVisualizar2
            // 
            this.lblImagemBebidasVisualizar2.AutoSize = true;
            this.lblImagemBebidasVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemBebidasVisualizar2.Location = new System.Drawing.Point(870, 82);
            this.lblImagemBebidasVisualizar2.Name = "lblImagemBebidasVisualizar2";
            this.lblImagemBebidasVisualizar2.Size = new System.Drawing.Size(77, 24);
            this.lblImagemBebidasVisualizar2.TabIndex = 419;
            this.lblImagemBebidasVisualizar2.Text = "Imagem";
            // 
            // imgBebidaVisualizar4
            // 
            this.imgBebidaVisualizar4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebidaVisualizar4.Location = new System.Drawing.Point(245, 371);
            this.imgBebidaVisualizar4.Name = "imgBebidaVisualizar4";
            this.imgBebidaVisualizar4.Size = new System.Drawing.Size(114, 77);
            this.imgBebidaVisualizar4.TabIndex = 418;
            this.imgBebidaVisualizar4.TabStop = false;
            // 
            // imgBebidaVisualizar3
            // 
            this.imgBebidaVisualizar3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebidaVisualizar3.Location = new System.Drawing.Point(245, 288);
            this.imgBebidaVisualizar3.Name = "imgBebidaVisualizar3";
            this.imgBebidaVisualizar3.Size = new System.Drawing.Size(114, 77);
            this.imgBebidaVisualizar3.TabIndex = 417;
            this.imgBebidaVisualizar3.TabStop = false;
            // 
            // imgBebidaVisualizar2
            // 
            this.imgBebidaVisualizar2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebidaVisualizar2.Location = new System.Drawing.Point(245, 205);
            this.imgBebidaVisualizar2.Name = "imgBebidaVisualizar2";
            this.imgBebidaVisualizar2.Size = new System.Drawing.Size(114, 77);
            this.imgBebidaVisualizar2.TabIndex = 416;
            this.imgBebidaVisualizar2.TabStop = false;
            // 
            // lblBebidasVisualizar1
            // 
            this.lblBebidasVisualizar1.AutoSize = true;
            this.lblBebidasVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidasVisualizar1.Location = new System.Drawing.Point(115, 82);
            this.lblBebidasVisualizar1.Name = "lblBebidasVisualizar1";
            this.lblBebidasVisualizar1.Size = new System.Drawing.Size(76, 24);
            this.lblBebidasVisualizar1.TabIndex = 415;
            this.lblBebidasVisualizar1.Text = "Bebidas";
            // 
            // lblPrecoBebidasVisualizar1
            // 
            this.lblPrecoBebidasVisualizar1.AutoSize = true;
            this.lblPrecoBebidasVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoBebidasVisualizar1.Location = new System.Drawing.Point(496, 82);
            this.lblPrecoBebidasVisualizar1.Name = "lblPrecoBebidasVisualizar1";
            this.lblPrecoBebidasVisualizar1.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoBebidasVisualizar1.TabIndex = 414;
            this.lblPrecoBebidasVisualizar1.Text = "Preço ($)";
            // 
            // txtPrecoBebidaVisualizar1
            // 
            this.txtPrecoBebidaVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoBebidaVisualizar1.Location = new System.Drawing.Point(500, 122);
            this.txtPrecoBebidaVisualizar1.Name = "txtPrecoBebidaVisualizar1";
            this.txtPrecoBebidaVisualizar1.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoBebidaVisualizar1.TabIndex = 413;
            // 
            // lblCustoBebidasVisualizar1
            // 
            this.lblCustoBebidasVisualizar1.AutoSize = true;
            this.lblCustoBebidasVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoBebidasVisualizar1.Location = new System.Drawing.Point(386, 82);
            this.lblCustoBebidasVisualizar1.Name = "lblCustoBebidasVisualizar1";
            this.lblCustoBebidasVisualizar1.Size = new System.Drawing.Size(86, 24);
            this.lblCustoBebidasVisualizar1.TabIndex = 412;
            this.lblCustoBebidasVisualizar1.Text = "Custo ($)";
            // 
            // txtCustoBebidaVisualizar1
            // 
            this.txtCustoBebidaVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoBebidaVisualizar1.Location = new System.Drawing.Point(390, 122);
            this.txtCustoBebidaVisualizar1.Name = "txtCustoBebidaVisualizar1";
            this.txtCustoBebidaVisualizar1.Size = new System.Drawing.Size(82, 30);
            this.txtCustoBebidaVisualizar1.TabIndex = 411;
            // 
            // lblImagemBebidasVisualizar1
            // 
            this.lblImagemBebidasVisualizar1.AutoSize = true;
            this.lblImagemBebidasVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemBebidasVisualizar1.Location = new System.Drawing.Point(265, 82);
            this.lblImagemBebidasVisualizar1.Name = "lblImagemBebidasVisualizar1";
            this.lblImagemBebidasVisualizar1.Size = new System.Drawing.Size(77, 24);
            this.lblImagemBebidasVisualizar1.TabIndex = 410;
            this.lblImagemBebidasVisualizar1.Text = "Imagem";
            // 
            // imgBebidaVisualizar1
            // 
            this.imgBebidaVisualizar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgBebidaVisualizar1.Location = new System.Drawing.Point(245, 122);
            this.imgBebidaVisualizar1.Name = "imgBebidaVisualizar1";
            this.imgBebidaVisualizar1.Size = new System.Drawing.Size(114, 77);
            this.imgBebidaVisualizar1.TabIndex = 409;
            this.imgBebidaVisualizar1.TabStop = false;
            // 
            // lblBebidaVisualizar8
            // 
            this.lblBebidaVisualizar8.AutoSize = true;
            this.lblBebidaVisualizar8.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaVisualizar8.Location = new System.Drawing.Point(638, 286);
            this.lblBebidaVisualizar8.Name = "lblBebidaVisualizar8";
            this.lblBebidaVisualizar8.Size = new System.Drawing.Size(19, 24);
            this.lblBebidaVisualizar8.TabIndex = 408;
            this.lblBebidaVisualizar8.Text = "8";
            // 
            // txtBebidaVisualizar8
            // 
            this.txtBebidaVisualizar8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebidaVisualizar8.Location = new System.Drawing.Point(663, 286);
            this.txtBebidaVisualizar8.Name = "txtBebidaVisualizar8";
            this.txtBebidaVisualizar8.Size = new System.Drawing.Size(168, 30);
            this.txtBebidaVisualizar8.TabIndex = 407;
            // 
            // lblBebidaVisualizar4
            // 
            this.lblBebidaVisualizar4.AutoSize = true;
            this.lblBebidaVisualizar4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaVisualizar4.Location = new System.Drawing.Point(31, 371);
            this.lblBebidaVisualizar4.Name = "lblBebidaVisualizar4";
            this.lblBebidaVisualizar4.Size = new System.Drawing.Size(19, 24);
            this.lblBebidaVisualizar4.TabIndex = 406;
            this.lblBebidaVisualizar4.Text = "4";
            // 
            // txtBebidaVisualizar4
            // 
            this.txtBebidaVisualizar4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebidaVisualizar4.Location = new System.Drawing.Point(56, 371);
            this.txtBebidaVisualizar4.Name = "txtBebidaVisualizar4";
            this.txtBebidaVisualizar4.Size = new System.Drawing.Size(168, 30);
            this.txtBebidaVisualizar4.TabIndex = 405;
            // 
            // lblBebidaVisualizar7
            // 
            this.lblBebidaVisualizar7.AutoSize = true;
            this.lblBebidaVisualizar7.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaVisualizar7.Location = new System.Drawing.Point(638, 209);
            this.lblBebidaVisualizar7.Name = "lblBebidaVisualizar7";
            this.lblBebidaVisualizar7.Size = new System.Drawing.Size(19, 24);
            this.lblBebidaVisualizar7.TabIndex = 404;
            this.lblBebidaVisualizar7.Text = "7";
            // 
            // txtBebidaVisualizar7
            // 
            this.txtBebidaVisualizar7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebidaVisualizar7.Location = new System.Drawing.Point(663, 209);
            this.txtBebidaVisualizar7.Name = "txtBebidaVisualizar7";
            this.txtBebidaVisualizar7.Size = new System.Drawing.Size(168, 30);
            this.txtBebidaVisualizar7.TabIndex = 403;
            // 
            // lblBebidaVisualizar3
            // 
            this.lblBebidaVisualizar3.AutoSize = true;
            this.lblBebidaVisualizar3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaVisualizar3.Location = new System.Drawing.Point(31, 289);
            this.lblBebidaVisualizar3.Name = "lblBebidaVisualizar3";
            this.lblBebidaVisualizar3.Size = new System.Drawing.Size(19, 24);
            this.lblBebidaVisualizar3.TabIndex = 402;
            this.lblBebidaVisualizar3.Text = "3";
            // 
            // txtBebidaVisualizar3
            // 
            this.txtBebidaVisualizar3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebidaVisualizar3.Location = new System.Drawing.Point(56, 289);
            this.txtBebidaVisualizar3.Name = "txtBebidaVisualizar3";
            this.txtBebidaVisualizar3.Size = new System.Drawing.Size(168, 30);
            this.txtBebidaVisualizar3.TabIndex = 401;
            // 
            // lblBebidaVisualizar6
            // 
            this.lblBebidaVisualizar6.AutoSize = true;
            this.lblBebidaVisualizar6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaVisualizar6.Location = new System.Drawing.Point(638, 122);
            this.lblBebidaVisualizar6.Name = "lblBebidaVisualizar6";
            this.lblBebidaVisualizar6.Size = new System.Drawing.Size(19, 24);
            this.lblBebidaVisualizar6.TabIndex = 400;
            this.lblBebidaVisualizar6.Text = "6";
            // 
            // txtBebidaVisualizar6
            // 
            this.txtBebidaVisualizar6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebidaVisualizar6.Location = new System.Drawing.Point(663, 122);
            this.txtBebidaVisualizar6.Name = "txtBebidaVisualizar6";
            this.txtBebidaVisualizar6.Size = new System.Drawing.Size(168, 30);
            this.txtBebidaVisualizar6.TabIndex = 399;
            // 
            // lblBebidaVisualizar2
            // 
            this.lblBebidaVisualizar2.AutoSize = true;
            this.lblBebidaVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaVisualizar2.Location = new System.Drawing.Point(31, 205);
            this.lblBebidaVisualizar2.Name = "lblBebidaVisualizar2";
            this.lblBebidaVisualizar2.Size = new System.Drawing.Size(19, 24);
            this.lblBebidaVisualizar2.TabIndex = 398;
            this.lblBebidaVisualizar2.Text = "2";
            // 
            // txtBebidaVisualizar2
            // 
            this.txtBebidaVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebidaVisualizar2.Location = new System.Drawing.Point(56, 205);
            this.txtBebidaVisualizar2.Name = "txtBebidaVisualizar2";
            this.txtBebidaVisualizar2.Size = new System.Drawing.Size(168, 30);
            this.txtBebidaVisualizar2.TabIndex = 397;
            // 
            // btnSalvarCadastroBebidasVisualizar
            // 
            this.btnSalvarCadastroBebidasVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarCadastroBebidasVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroBebidasVisualizar.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSalvarCadastroBebidasVisualizar.Location = new System.Drawing.Point(995, 550);
            this.btnSalvarCadastroBebidasVisualizar.Name = "btnSalvarCadastroBebidasVisualizar";
            this.btnSalvarCadastroBebidasVisualizar.Size = new System.Drawing.Size(167, 55);
            this.btnSalvarCadastroBebidasVisualizar.TabIndex = 396;
            this.btnSalvarCadastroBebidasVisualizar.Text = "Salvar";
            this.btnSalvarCadastroBebidasVisualizar.UseVisualStyleBackColor = false;
            // 
            // lblBebidaVisualizar1
            // 
            this.lblBebidaVisualizar1.AutoSize = true;
            this.lblBebidaVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidaVisualizar1.Location = new System.Drawing.Point(31, 122);
            this.lblBebidaVisualizar1.Name = "lblBebidaVisualizar1";
            this.lblBebidaVisualizar1.Size = new System.Drawing.Size(19, 24);
            this.lblBebidaVisualizar1.TabIndex = 395;
            this.lblBebidaVisualizar1.Text = "1";
            // 
            // txtBebidaVisualizar1
            // 
            this.txtBebidaVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBebidaVisualizar1.Location = new System.Drawing.Point(56, 122);
            this.txtBebidaVisualizar1.Name = "txtBebidaVisualizar1";
            this.txtBebidaVisualizar1.Size = new System.Drawing.Size(168, 30);
            this.txtBebidaVisualizar1.TabIndex = 394;
            // 
            // lblTituloCadastroBebidasVisualizar
            // 
            this.lblTituloCadastroBebidasVisualizar.AutoSize = true;
            this.lblTituloCadastroBebidasVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroBebidasVisualizar.Location = new System.Drawing.Point(559, 20);
            this.lblTituloCadastroBebidasVisualizar.Name = "lblTituloCadastroBebidasVisualizar";
            this.lblTituloCadastroBebidasVisualizar.Size = new System.Drawing.Size(98, 31);
            this.lblTituloCadastroBebidasVisualizar.TabIndex = 393;
            this.lblTituloCadastroBebidasVisualizar.Text = "Bebidas";
            // 
            // CadastroBebidasVisualizar
            // 
            this.ClientSize = new System.Drawing.Size(1217, 629);
            this.Controls.Add(this.lblBebidaVisualizar9);
            this.Controls.Add(this.txtBebidaVisualizar9);
            this.Controls.Add(this.txtPrecoBebidaVisualizar9);
            this.Controls.Add(this.txtCustoBebidaVisualizar9);
            this.Controls.Add(this.txtPrecoBebidaVisualizar8);
            this.Controls.Add(this.txtCustoBebidaVisualizar8);
            this.Controls.Add(this.txtPrecoBebidaVisualizar7);
            this.Controls.Add(this.txtCustoBebidaVisualizar7);
            this.Controls.Add(this.txtPrecoBebidaVisualizar10);
            this.Controls.Add(this.txtCustoBebidaVisualizar10);
            this.Controls.Add(this.imgBebidaVisualizar10);
            this.Controls.Add(this.lblBebidaVisualizar10);
            this.Controls.Add(this.txtBebidaVisualizar10);
            this.Controls.Add(this.txtPrecoBebidaVisualizar4);
            this.Controls.Add(this.txtCustoBebidaVisualizar4);
            this.Controls.Add(this.txtPrecoBebidaVisualizar3);
            this.Controls.Add(this.txtCustoBebidaVisualizar3);
            this.Controls.Add(this.txtPrecoBebidaVisualizar2);
            this.Controls.Add(this.txtCustoBebidaVisualizar2);
            this.Controls.Add(this.txtPrecoBebidaVisualizar5);
            this.Controls.Add(this.txtCustoBebidaVisualizar5);
            this.Controls.Add(this.imgBebidaVisualizar5);
            this.Controls.Add(this.lblBebidaVisualizar5);
            this.Controls.Add(this.txtBebidaVisualizar5);
            this.Controls.Add(this.imgBebidaVisualizar9);
            this.Controls.Add(this.imgBebidaVisualizar8);
            this.Controls.Add(this.imgBebidaVisualizar7);
            this.Controls.Add(this.txtPrecoBebidaVisualizar6);
            this.Controls.Add(this.txtCustoBebidaVisualizar6);
            this.Controls.Add(this.imgBebidaVisualizar6);
            this.Controls.Add(this.lblBebidasVisualizar2);
            this.Controls.Add(this.lblPrecoBebidasVisualizar2);
            this.Controls.Add(this.lblCustoBebidasVisualizar2);
            this.Controls.Add(this.lblImagemBebidasVisualizar2);
            this.Controls.Add(this.imgBebidaVisualizar4);
            this.Controls.Add(this.imgBebidaVisualizar3);
            this.Controls.Add(this.imgBebidaVisualizar2);
            this.Controls.Add(this.lblBebidasVisualizar1);
            this.Controls.Add(this.lblPrecoBebidasVisualizar1);
            this.Controls.Add(this.txtPrecoBebidaVisualizar1);
            this.Controls.Add(this.lblCustoBebidasVisualizar1);
            this.Controls.Add(this.txtCustoBebidaVisualizar1);
            this.Controls.Add(this.lblImagemBebidasVisualizar1);
            this.Controls.Add(this.imgBebidaVisualizar1);
            this.Controls.Add(this.lblBebidaVisualizar8);
            this.Controls.Add(this.txtBebidaVisualizar8);
            this.Controls.Add(this.lblBebidaVisualizar4);
            this.Controls.Add(this.txtBebidaVisualizar4);
            this.Controls.Add(this.lblBebidaVisualizar7);
            this.Controls.Add(this.txtBebidaVisualizar7);
            this.Controls.Add(this.lblBebidaVisualizar3);
            this.Controls.Add(this.txtBebidaVisualizar3);
            this.Controls.Add(this.lblBebidaVisualizar6);
            this.Controls.Add(this.txtBebidaVisualizar6);
            this.Controls.Add(this.lblBebidaVisualizar2);
            this.Controls.Add(this.txtBebidaVisualizar2);
            this.Controls.Add(this.btnSalvarCadastroBebidasVisualizar);
            this.Controls.Add(this.lblBebidaVisualizar1);
            this.Controls.Add(this.txtBebidaVisualizar1);
            this.Controls.Add(this.lblTituloCadastroBebidasVisualizar);
            this.Name = "CadastroBebidasVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBebidaVisualizar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      

        }
    }
}
