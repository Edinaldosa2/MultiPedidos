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
    public partial class CadastroPorcoesVisualizar : Form
    {
        private Label lblPorcaoVisualizar9;
        private PictureBox imgPorcao10;
        private Label lblPorcaoVisualizar10;
        private PictureBox imgPorcao5;
        private Label lblPorcaoVisualizar5;
        private PictureBox imgPorcao9;
        private PictureBox imgPorcao8;
        private PictureBox imgPorcao7;
        private PictureBox imgPorcao6;
        private Label lblPorcoesVisualizar2;
        private Label lblPrecoPorcoesVisualizar2;
        private Label lblCustoPorcoesVisualizar2;
        private Label lblImagemPorcoesVisualizar2;
        private PictureBox imgPorcao4;
        private PictureBox imgPorcao3;
        private PictureBox imgPorcao2;
        private Label lblPorcoesVisualizar1;
        private Label lblPrecoPorcoesVisualizar1;
        private Label lblCustoPorcoesVisualizar1;
        private Label lblImagemPorcoesVisualizar1;
        private PictureBox imgPorcao1;
        private Label lblPorcaoVisualizar8;
        private Label lblPorcaoVisualizar4;
        private Label lblPorcaoVisualizar7;
        private Label lblPorcaoVisualizar3;
        private Label lblPorcaoVisualizar6;
        private Label lblPorcaoVisualizar2;
        private Label lblPorcaoVisualizar1;
        private Label lblPorcaoVisualizarPreenchido1;
        private Label lblPorcaoVisualizarPreenchido2;
        private Label lblPorcaoVisualizarPreenchido3;
        private Label lblPorcaoVisualizarPreenchido4;
        private Label lblPorcaoVisualizarPreenchido5;
        private Label lblPorcaoVisualizarPreenchido10;
        private Label lblPorcaoVisualizarPreenchido9;
        private Label lblPorcaoVisualizarPreenchido8;
        private Label lblPorcaoVisualizarPreenchido7;
        private Label lblPorcaoVisualizarPreenchido6;
        private Label lblCustoPorcaoVisualizarPreenchido5;
        private Label lblCustoPorcaoVisualizarPreenchido4;
        private Label lblCustoPorcaoVisualizarPreenchido3;
        private Label lblCustoPorcaoVisualizarPreenchido2;
        private Label lblCustoPorcaoVisualizarPreenchido1;
        private Label lblCustoPorcaoVisualizarPreenchido10;
        private Label lblCustoPorcaoVisualizarPreenchido9;
        private Label lblCustoPorcaoVisualizarPreenchido8;
        private Label lblCustoPorcaoVisualizarPreenchido7;
        private Label lblCustoPorcaoVisualizarPreenchido6;
        private Label lblPrecoPorcaoVisualizarPreenchido5;
        private Label lblPrecoPorcaoVisualizarPreenchido4;
        private Label lblPrecoPorcaoVisualizarPreenchido3;
        private Label lblPrecoPorcaoVisualizarPreenchido2;
        private Label lblPrecoPorcaoVisualizarPreenchido1;
        private Label lblPrecoPorcaoVisualizarPreenchido10;
        private Label lblPrecoPorcaoVisualizarPreenchido9;
        private Label lblPrecoPorcaoVisualizarPreenchido8;
        private Label lblPrecoPorcaoVisualizarPreenchido7;
        private Label lblPrecoPorcaoVisualizarPreenchido6;
        private Button buttonDeletarCadastroPorcoesVisualizar;
        private Button buttonEditarCadastroPorcoesVisualizar;
        private Label lblTituloCadastroPorcoesVisualizar;

        public CadastroPorcoesVisualizar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblPorcaoVisualizar9 = new System.Windows.Forms.Label();
            this.imgPorcao10 = new System.Windows.Forms.PictureBox();
            this.lblPorcaoVisualizar10 = new System.Windows.Forms.Label();
            this.imgPorcao5 = new System.Windows.Forms.PictureBox();
            this.lblPorcaoVisualizar5 = new System.Windows.Forms.Label();
            this.imgPorcao9 = new System.Windows.Forms.PictureBox();
            this.imgPorcao8 = new System.Windows.Forms.PictureBox();
            this.imgPorcao7 = new System.Windows.Forms.PictureBox();
            this.imgPorcao6 = new System.Windows.Forms.PictureBox();
            this.lblPorcoesVisualizar2 = new System.Windows.Forms.Label();
            this.lblPrecoPorcoesVisualizar2 = new System.Windows.Forms.Label();
            this.lblCustoPorcoesVisualizar2 = new System.Windows.Forms.Label();
            this.lblImagemPorcoesVisualizar2 = new System.Windows.Forms.Label();
            this.imgPorcao4 = new System.Windows.Forms.PictureBox();
            this.imgPorcao3 = new System.Windows.Forms.PictureBox();
            this.imgPorcao2 = new System.Windows.Forms.PictureBox();
            this.lblPorcoesVisualizar1 = new System.Windows.Forms.Label();
            this.lblPrecoPorcoesVisualizar1 = new System.Windows.Forms.Label();
            this.lblCustoPorcoesVisualizar1 = new System.Windows.Forms.Label();
            this.lblImagemPorcoesVisualizar1 = new System.Windows.Forms.Label();
            this.imgPorcao1 = new System.Windows.Forms.PictureBox();
            this.lblPorcaoVisualizar8 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizar4 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizar7 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizar3 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizar6 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizar2 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizar1 = new System.Windows.Forms.Label();
            this.lblTituloCadastroPorcoesVisualizar = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizarPreenchido1 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizarPreenchido2 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizarPreenchido3 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizarPreenchido4 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizarPreenchido5 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizarPreenchido10 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizarPreenchido9 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizarPreenchido8 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizarPreenchido7 = new System.Windows.Forms.Label();
            this.lblPorcaoVisualizarPreenchido6 = new System.Windows.Forms.Label();
            this.lblCustoPorcaoVisualizarPreenchido5 = new System.Windows.Forms.Label();
            this.lblCustoPorcaoVisualizarPreenchido4 = new System.Windows.Forms.Label();
            this.lblCustoPorcaoVisualizarPreenchido3 = new System.Windows.Forms.Label();
            this.lblCustoPorcaoVisualizarPreenchido2 = new System.Windows.Forms.Label();
            this.lblCustoPorcaoVisualizarPreenchido1 = new System.Windows.Forms.Label();
            this.lblCustoPorcaoVisualizarPreenchido10 = new System.Windows.Forms.Label();
            this.lblCustoPorcaoVisualizarPreenchido9 = new System.Windows.Forms.Label();
            this.lblCustoPorcaoVisualizarPreenchido8 = new System.Windows.Forms.Label();
            this.lblCustoPorcaoVisualizarPreenchido7 = new System.Windows.Forms.Label();
            this.lblCustoPorcaoVisualizarPreenchido6 = new System.Windows.Forms.Label();
            this.lblPrecoPorcaoVisualizarPreenchido5 = new System.Windows.Forms.Label();
            this.lblPrecoPorcaoVisualizarPreenchido4 = new System.Windows.Forms.Label();
            this.lblPrecoPorcaoVisualizarPreenchido3 = new System.Windows.Forms.Label();
            this.lblPrecoPorcaoVisualizarPreenchido2 = new System.Windows.Forms.Label();
            this.lblPrecoPorcaoVisualizarPreenchido1 = new System.Windows.Forms.Label();
            this.lblPrecoPorcaoVisualizarPreenchido10 = new System.Windows.Forms.Label();
            this.lblPrecoPorcaoVisualizarPreenchido9 = new System.Windows.Forms.Label();
            this.lblPrecoPorcaoVisualizarPreenchido8 = new System.Windows.Forms.Label();
            this.lblPrecoPorcaoVisualizarPreenchido7 = new System.Windows.Forms.Label();
            this.lblPrecoPorcaoVisualizarPreenchido6 = new System.Windows.Forms.Label();
            this.buttonDeletarCadastroPorcoesVisualizar = new System.Windows.Forms.Button();
            this.buttonEditarCadastroPorcoesVisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPorcaoVisualizar9
            // 
            this.lblPorcaoVisualizar9.AutoSize = true;
            this.lblPorcaoVisualizar9.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizar9.Location = new System.Drawing.Point(620, 370);
            this.lblPorcaoVisualizar9.Name = "lblPorcaoVisualizar9";
            this.lblPorcaoVisualizar9.Size = new System.Drawing.Size(19, 24);
            this.lblPorcaoVisualizar9.TabIndex = 392;
            this.lblPorcaoVisualizar9.Text = "9";
            // 
            // imgPorcao10
            // 
            this.imgPorcao10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPorcao10.Location = new System.Drawing.Point(834, 455);
            this.imgPorcao10.Name = "imgPorcao10";
            this.imgPorcao10.Size = new System.Drawing.Size(114, 77);
            this.imgPorcao10.TabIndex = 382;
            this.imgPorcao10.TabStop = false;
            // 
            // lblPorcaoVisualizar10
            // 
            this.lblPorcaoVisualizar10.AutoSize = true;
            this.lblPorcaoVisualizar10.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizar10.Location = new System.Drawing.Point(611, 455);
            this.lblPorcaoVisualizar10.Name = "lblPorcaoVisualizar10";
            this.lblPorcaoVisualizar10.Size = new System.Drawing.Size(28, 24);
            this.lblPorcaoVisualizar10.TabIndex = 381;
            this.lblPorcaoVisualizar10.Text = "10";
            // 
            // imgPorcao5
            // 
            this.imgPorcao5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPorcao5.Location = new System.Drawing.Point(227, 455);
            this.imgPorcao5.Name = "imgPorcao5";
            this.imgPorcao5.Size = new System.Drawing.Size(114, 77);
            this.imgPorcao5.TabIndex = 371;
            this.imgPorcao5.TabStop = false;
            // 
            // lblPorcaoVisualizar5
            // 
            this.lblPorcaoVisualizar5.AutoSize = true;
            this.lblPorcaoVisualizar5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizar5.Location = new System.Drawing.Point(13, 455);
            this.lblPorcaoVisualizar5.Name = "lblPorcaoVisualizar5";
            this.lblPorcaoVisualizar5.Size = new System.Drawing.Size(19, 24);
            this.lblPorcaoVisualizar5.TabIndex = 370;
            this.lblPorcaoVisualizar5.Text = "5";
            // 
            // imgPorcao9
            // 
            this.imgPorcao9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPorcao9.Location = new System.Drawing.Point(834, 372);
            this.imgPorcao9.Name = "imgPorcao9";
            this.imgPorcao9.Size = new System.Drawing.Size(114, 77);
            this.imgPorcao9.TabIndex = 368;
            this.imgPorcao9.TabStop = false;
            // 
            // imgPorcao8
            // 
            this.imgPorcao8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPorcao8.Location = new System.Drawing.Point(834, 289);
            this.imgPorcao8.Name = "imgPorcao8";
            this.imgPorcao8.Size = new System.Drawing.Size(114, 77);
            this.imgPorcao8.TabIndex = 367;
            this.imgPorcao8.TabStop = false;
            // 
            // imgPorcao7
            // 
            this.imgPorcao7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPorcao7.Location = new System.Drawing.Point(834, 206);
            this.imgPorcao7.Name = "imgPorcao7";
            this.imgPorcao7.Size = new System.Drawing.Size(114, 77);
            this.imgPorcao7.TabIndex = 366;
            this.imgPorcao7.TabStop = false;
            // 
            // imgPorcao6
            // 
            this.imgPorcao6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPorcao6.Location = new System.Drawing.Point(834, 123);
            this.imgPorcao6.Name = "imgPorcao6";
            this.imgPorcao6.Size = new System.Drawing.Size(114, 77);
            this.imgPorcao6.TabIndex = 363;
            this.imgPorcao6.TabStop = false;
            // 
            // lblPorcoesVisualizar2
            // 
            this.lblPorcoesVisualizar2.AutoSize = true;
            this.lblPorcoesVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcoesVisualizar2.Location = new System.Drawing.Point(696, 83);
            this.lblPorcoesVisualizar2.Name = "lblPorcoesVisualizar2";
            this.lblPorcoesVisualizar2.Size = new System.Drawing.Size(74, 24);
            this.lblPorcoesVisualizar2.TabIndex = 362;
            this.lblPorcoesVisualizar2.Text = "Porções";
            // 
            // lblPrecoPorcoesVisualizar2
            // 
            this.lblPrecoPorcoesVisualizar2.AutoSize = true;
            this.lblPrecoPorcoesVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcoesVisualizar2.Location = new System.Drawing.Point(1083, 83);
            this.lblPrecoPorcoesVisualizar2.Name = "lblPrecoPorcoesVisualizar2";
            this.lblPrecoPorcoesVisualizar2.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoPorcoesVisualizar2.TabIndex = 361;
            this.lblPrecoPorcoesVisualizar2.Text = "Preço ($)";
            // 
            // lblCustoPorcoesVisualizar2
            // 
            this.lblCustoPorcoesVisualizar2.AutoSize = true;
            this.lblCustoPorcoesVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcoesVisualizar2.Location = new System.Drawing.Point(973, 83);
            this.lblCustoPorcoesVisualizar2.Name = "lblCustoPorcoesVisualizar2";
            this.lblCustoPorcoesVisualizar2.Size = new System.Drawing.Size(86, 24);
            this.lblCustoPorcoesVisualizar2.TabIndex = 360;
            this.lblCustoPorcoesVisualizar2.Text = "Custo ($)";
            // 
            // lblImagemPorcoesVisualizar2
            // 
            this.lblImagemPorcoesVisualizar2.AutoSize = true;
            this.lblImagemPorcoesVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemPorcoesVisualizar2.Location = new System.Drawing.Point(852, 83);
            this.lblImagemPorcoesVisualizar2.Name = "lblImagemPorcoesVisualizar2";
            this.lblImagemPorcoesVisualizar2.Size = new System.Drawing.Size(77, 24);
            this.lblImagemPorcoesVisualizar2.TabIndex = 359;
            this.lblImagemPorcoesVisualizar2.Text = "Imagem";
            // 
            // imgPorcao4
            // 
            this.imgPorcao4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPorcao4.Location = new System.Drawing.Point(227, 372);
            this.imgPorcao4.Name = "imgPorcao4";
            this.imgPorcao4.Size = new System.Drawing.Size(114, 77);
            this.imgPorcao4.TabIndex = 358;
            this.imgPorcao4.TabStop = false;
            // 
            // imgPorcao3
            // 
            this.imgPorcao3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPorcao3.Location = new System.Drawing.Point(227, 289);
            this.imgPorcao3.Name = "imgPorcao3";
            this.imgPorcao3.Size = new System.Drawing.Size(114, 77);
            this.imgPorcao3.TabIndex = 357;
            this.imgPorcao3.TabStop = false;
            // 
            // imgPorcao2
            // 
            this.imgPorcao2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPorcao2.Location = new System.Drawing.Point(227, 206);
            this.imgPorcao2.Name = "imgPorcao2";
            this.imgPorcao2.Size = new System.Drawing.Size(114, 77);
            this.imgPorcao2.TabIndex = 356;
            this.imgPorcao2.TabStop = false;
            // 
            // lblPorcoesVisualizar1
            // 
            this.lblPorcoesVisualizar1.AutoSize = true;
            this.lblPorcoesVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcoesVisualizar1.Location = new System.Drawing.Point(97, 83);
            this.lblPorcoesVisualizar1.Name = "lblPorcoesVisualizar1";
            this.lblPorcoesVisualizar1.Size = new System.Drawing.Size(74, 24);
            this.lblPorcoesVisualizar1.TabIndex = 355;
            this.lblPorcoesVisualizar1.Text = "Porções";
            // 
            // lblPrecoPorcoesVisualizar1
            // 
            this.lblPrecoPorcoesVisualizar1.AutoSize = true;
            this.lblPrecoPorcoesVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcoesVisualizar1.Location = new System.Drawing.Point(478, 83);
            this.lblPrecoPorcoesVisualizar1.Name = "lblPrecoPorcoesVisualizar1";
            this.lblPrecoPorcoesVisualizar1.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoPorcoesVisualizar1.TabIndex = 354;
            this.lblPrecoPorcoesVisualizar1.Text = "Preço ($)";
            // 
            // lblCustoPorcoesVisualizar1
            // 
            this.lblCustoPorcoesVisualizar1.AutoSize = true;
            this.lblCustoPorcoesVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcoesVisualizar1.Location = new System.Drawing.Point(368, 83);
            this.lblCustoPorcoesVisualizar1.Name = "lblCustoPorcoesVisualizar1";
            this.lblCustoPorcoesVisualizar1.Size = new System.Drawing.Size(86, 24);
            this.lblCustoPorcoesVisualizar1.TabIndex = 352;
            this.lblCustoPorcoesVisualizar1.Text = "Custo ($)";
            // 
            // lblImagemPorcoesVisualizar1
            // 
            this.lblImagemPorcoesVisualizar1.AutoSize = true;
            this.lblImagemPorcoesVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemPorcoesVisualizar1.Location = new System.Drawing.Point(247, 83);
            this.lblImagemPorcoesVisualizar1.Name = "lblImagemPorcoesVisualizar1";
            this.lblImagemPorcoesVisualizar1.Size = new System.Drawing.Size(77, 24);
            this.lblImagemPorcoesVisualizar1.TabIndex = 350;
            this.lblImagemPorcoesVisualizar1.Text = "Imagem";
            // 
            // imgPorcao1
            // 
            this.imgPorcao1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgPorcao1.Location = new System.Drawing.Point(227, 123);
            this.imgPorcao1.Name = "imgPorcao1";
            this.imgPorcao1.Size = new System.Drawing.Size(114, 77);
            this.imgPorcao1.TabIndex = 349;
            this.imgPorcao1.TabStop = false;
            // 
            // lblPorcaoVisualizar8
            // 
            this.lblPorcaoVisualizar8.AutoSize = true;
            this.lblPorcaoVisualizar8.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizar8.Location = new System.Drawing.Point(620, 287);
            this.lblPorcaoVisualizar8.Name = "lblPorcaoVisualizar8";
            this.lblPorcaoVisualizar8.Size = new System.Drawing.Size(19, 24);
            this.lblPorcaoVisualizar8.TabIndex = 348;
            this.lblPorcaoVisualizar8.Text = "8";
            // 
            // lblPorcaoVisualizar4
            // 
            this.lblPorcaoVisualizar4.AutoSize = true;
            this.lblPorcaoVisualizar4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizar4.Location = new System.Drawing.Point(13, 372);
            this.lblPorcaoVisualizar4.Name = "lblPorcaoVisualizar4";
            this.lblPorcaoVisualizar4.Size = new System.Drawing.Size(19, 24);
            this.lblPorcaoVisualizar4.TabIndex = 346;
            this.lblPorcaoVisualizar4.Text = "4";
            // 
            // lblPorcaoVisualizar7
            // 
            this.lblPorcaoVisualizar7.AutoSize = true;
            this.lblPorcaoVisualizar7.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizar7.Location = new System.Drawing.Point(620, 210);
            this.lblPorcaoVisualizar7.Name = "lblPorcaoVisualizar7";
            this.lblPorcaoVisualizar7.Size = new System.Drawing.Size(19, 24);
            this.lblPorcaoVisualizar7.TabIndex = 344;
            this.lblPorcaoVisualizar7.Text = "7";
            // 
            // lblPorcaoVisualizar3
            // 
            this.lblPorcaoVisualizar3.AutoSize = true;
            this.lblPorcaoVisualizar3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizar3.Location = new System.Drawing.Point(13, 290);
            this.lblPorcaoVisualizar3.Name = "lblPorcaoVisualizar3";
            this.lblPorcaoVisualizar3.Size = new System.Drawing.Size(19, 24);
            this.lblPorcaoVisualizar3.TabIndex = 342;
            this.lblPorcaoVisualizar3.Text = "3";
            // 
            // lblPorcaoVisualizar6
            // 
            this.lblPorcaoVisualizar6.AutoSize = true;
            this.lblPorcaoVisualizar6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizar6.Location = new System.Drawing.Point(620, 123);
            this.lblPorcaoVisualizar6.Name = "lblPorcaoVisualizar6";
            this.lblPorcaoVisualizar6.Size = new System.Drawing.Size(19, 24);
            this.lblPorcaoVisualizar6.TabIndex = 340;
            this.lblPorcaoVisualizar6.Text = "6";
            // 
            // lblPorcaoVisualizar2
            // 
            this.lblPorcaoVisualizar2.AutoSize = true;
            this.lblPorcaoVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizar2.Location = new System.Drawing.Point(13, 206);
            this.lblPorcaoVisualizar2.Name = "lblPorcaoVisualizar2";
            this.lblPorcaoVisualizar2.Size = new System.Drawing.Size(19, 24);
            this.lblPorcaoVisualizar2.TabIndex = 338;
            this.lblPorcaoVisualizar2.Text = "2";
            // 
            // lblPorcaoVisualizar1
            // 
            this.lblPorcaoVisualizar1.AutoSize = true;
            this.lblPorcaoVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizar1.Location = new System.Drawing.Point(13, 123);
            this.lblPorcaoVisualizar1.Name = "lblPorcaoVisualizar1";
            this.lblPorcaoVisualizar1.Size = new System.Drawing.Size(19, 24);
            this.lblPorcaoVisualizar1.TabIndex = 335;
            this.lblPorcaoVisualizar1.Text = "1";
            // 
            // lblTituloCadastroPorcoesVisualizar
            // 
            this.lblTituloCadastroPorcoesVisualizar.AutoSize = true;
            this.lblTituloCadastroPorcoesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroPorcoesVisualizar.Location = new System.Drawing.Point(544, 20);
            this.lblTituloCadastroPorcoesVisualizar.Name = "lblTituloCadastroPorcoesVisualizar";
            this.lblTituloCadastroPorcoesVisualizar.Size = new System.Drawing.Size(95, 31);
            this.lblTituloCadastroPorcoesVisualizar.TabIndex = 333;
            this.lblTituloCadastroPorcoesVisualizar.Text = "Porções";
            // 
            // lblPorcaoVisualizarPreenchido1
            // 
            this.lblPorcaoVisualizarPreenchido1.AutoSize = true;
            this.lblPorcaoVisualizarPreenchido1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizarPreenchido1.Location = new System.Drawing.Point(97, 124);
            this.lblPorcaoVisualizarPreenchido1.Name = "lblPorcaoVisualizarPreenchido1";
            this.lblPorcaoVisualizarPreenchido1.Size = new System.Drawing.Size(0, 23);
            this.lblPorcaoVisualizarPreenchido1.TabIndex = 393;
            // 
            // lblPorcaoVisualizarPreenchido2
            // 
            this.lblPorcaoVisualizarPreenchido2.AutoSize = true;
            this.lblPorcaoVisualizarPreenchido2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizarPreenchido2.Location = new System.Drawing.Point(97, 211);
            this.lblPorcaoVisualizarPreenchido2.Name = "lblPorcaoVisualizarPreenchido2";
            this.lblPorcaoVisualizarPreenchido2.Size = new System.Drawing.Size(0, 23);
            this.lblPorcaoVisualizarPreenchido2.TabIndex = 394;
            // 
            // lblPorcaoVisualizarPreenchido3
            // 
            this.lblPorcaoVisualizarPreenchido3.AutoSize = true;
            this.lblPorcaoVisualizarPreenchido3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizarPreenchido3.Location = new System.Drawing.Point(97, 291);
            this.lblPorcaoVisualizarPreenchido3.Name = "lblPorcaoVisualizarPreenchido3";
            this.lblPorcaoVisualizarPreenchido3.Size = new System.Drawing.Size(0, 23);
            this.lblPorcaoVisualizarPreenchido3.TabIndex = 395;
            // 
            // lblPorcaoVisualizarPreenchido4
            // 
            this.lblPorcaoVisualizarPreenchido4.AutoSize = true;
            this.lblPorcaoVisualizarPreenchido4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizarPreenchido4.Location = new System.Drawing.Point(97, 374);
            this.lblPorcaoVisualizarPreenchido4.Name = "lblPorcaoVisualizarPreenchido4";
            this.lblPorcaoVisualizarPreenchido4.Size = new System.Drawing.Size(0, 23);
            this.lblPorcaoVisualizarPreenchido4.TabIndex = 396;
            // 
            // lblPorcaoVisualizarPreenchido5
            // 
            this.lblPorcaoVisualizarPreenchido5.AutoSize = true;
            this.lblPorcaoVisualizarPreenchido5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizarPreenchido5.Location = new System.Drawing.Point(97, 456);
            this.lblPorcaoVisualizarPreenchido5.Name = "lblPorcaoVisualizarPreenchido5";
            this.lblPorcaoVisualizarPreenchido5.Size = new System.Drawing.Size(0, 23);
            this.lblPorcaoVisualizarPreenchido5.TabIndex = 397;
            // 
            // lblPorcaoVisualizarPreenchido10
            // 
            this.lblPorcaoVisualizarPreenchido10.AutoSize = true;
            this.lblPorcaoVisualizarPreenchido10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizarPreenchido10.Location = new System.Drawing.Point(696, 456);
            this.lblPorcaoVisualizarPreenchido10.Name = "lblPorcaoVisualizarPreenchido10";
            this.lblPorcaoVisualizarPreenchido10.Size = new System.Drawing.Size(0, 23);
            this.lblPorcaoVisualizarPreenchido10.TabIndex = 402;
            // 
            // lblPorcaoVisualizarPreenchido9
            // 
            this.lblPorcaoVisualizarPreenchido9.AutoSize = true;
            this.lblPorcaoVisualizarPreenchido9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizarPreenchido9.Location = new System.Drawing.Point(696, 374);
            this.lblPorcaoVisualizarPreenchido9.Name = "lblPorcaoVisualizarPreenchido9";
            this.lblPorcaoVisualizarPreenchido9.Size = new System.Drawing.Size(0, 23);
            this.lblPorcaoVisualizarPreenchido9.TabIndex = 401;
            // 
            // lblPorcaoVisualizarPreenchido8
            // 
            this.lblPorcaoVisualizarPreenchido8.AutoSize = true;
            this.lblPorcaoVisualizarPreenchido8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizarPreenchido8.Location = new System.Drawing.Point(696, 291);
            this.lblPorcaoVisualizarPreenchido8.Name = "lblPorcaoVisualizarPreenchido8";
            this.lblPorcaoVisualizarPreenchido8.Size = new System.Drawing.Size(0, 23);
            this.lblPorcaoVisualizarPreenchido8.TabIndex = 400;
            // 
            // lblPorcaoVisualizarPreenchido7
            // 
            this.lblPorcaoVisualizarPreenchido7.AutoSize = true;
            this.lblPorcaoVisualizarPreenchido7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizarPreenchido7.Location = new System.Drawing.Point(696, 211);
            this.lblPorcaoVisualizarPreenchido7.Name = "lblPorcaoVisualizarPreenchido7";
            this.lblPorcaoVisualizarPreenchido7.Size = new System.Drawing.Size(0, 23);
            this.lblPorcaoVisualizarPreenchido7.TabIndex = 399;
            // 
            // lblPorcaoVisualizarPreenchido6
            // 
            this.lblPorcaoVisualizarPreenchido6.AutoSize = true;
            this.lblPorcaoVisualizarPreenchido6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcaoVisualizarPreenchido6.Location = new System.Drawing.Point(696, 124);
            this.lblPorcaoVisualizarPreenchido6.Name = "lblPorcaoVisualizarPreenchido6";
            this.lblPorcaoVisualizarPreenchido6.Size = new System.Drawing.Size(0, 23);
            this.lblPorcaoVisualizarPreenchido6.TabIndex = 398;
            // 
            // lblCustoPorcaoVisualizarPreenchido5
            // 
            this.lblCustoPorcaoVisualizarPreenchido5.AutoSize = true;
            this.lblCustoPorcaoVisualizarPreenchido5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcaoVisualizarPreenchido5.Location = new System.Drawing.Point(368, 458);
            this.lblCustoPorcaoVisualizarPreenchido5.Name = "lblCustoPorcaoVisualizarPreenchido5";
            this.lblCustoPorcaoVisualizarPreenchido5.Size = new System.Drawing.Size(0, 23);
            this.lblCustoPorcaoVisualizarPreenchido5.TabIndex = 407;
            // 
            // lblCustoPorcaoVisualizarPreenchido4
            // 
            this.lblCustoPorcaoVisualizarPreenchido4.AutoSize = true;
            this.lblCustoPorcaoVisualizarPreenchido4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcaoVisualizarPreenchido4.Location = new System.Drawing.Point(368, 376);
            this.lblCustoPorcaoVisualizarPreenchido4.Name = "lblCustoPorcaoVisualizarPreenchido4";
            this.lblCustoPorcaoVisualizarPreenchido4.Size = new System.Drawing.Size(0, 23);
            this.lblCustoPorcaoVisualizarPreenchido4.TabIndex = 406;
            // 
            // lblCustoPorcaoVisualizarPreenchido3
            // 
            this.lblCustoPorcaoVisualizarPreenchido3.AutoSize = true;
            this.lblCustoPorcaoVisualizarPreenchido3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcaoVisualizarPreenchido3.Location = new System.Drawing.Point(368, 293);
            this.lblCustoPorcaoVisualizarPreenchido3.Name = "lblCustoPorcaoVisualizarPreenchido3";
            this.lblCustoPorcaoVisualizarPreenchido3.Size = new System.Drawing.Size(0, 23);
            this.lblCustoPorcaoVisualizarPreenchido3.TabIndex = 405;
            // 
            // lblCustoPorcaoVisualizarPreenchido2
            // 
            this.lblCustoPorcaoVisualizarPreenchido2.AutoSize = true;
            this.lblCustoPorcaoVisualizarPreenchido2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcaoVisualizarPreenchido2.Location = new System.Drawing.Point(368, 213);
            this.lblCustoPorcaoVisualizarPreenchido2.Name = "lblCustoPorcaoVisualizarPreenchido2";
            this.lblCustoPorcaoVisualizarPreenchido2.Size = new System.Drawing.Size(0, 23);
            this.lblCustoPorcaoVisualizarPreenchido2.TabIndex = 404;
            // 
            // lblCustoPorcaoVisualizarPreenchido1
            // 
            this.lblCustoPorcaoVisualizarPreenchido1.AutoSize = true;
            this.lblCustoPorcaoVisualizarPreenchido1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcaoVisualizarPreenchido1.Location = new System.Drawing.Point(368, 126);
            this.lblCustoPorcaoVisualizarPreenchido1.Name = "lblCustoPorcaoVisualizarPreenchido1";
            this.lblCustoPorcaoVisualizarPreenchido1.Size = new System.Drawing.Size(0, 23);
            this.lblCustoPorcaoVisualizarPreenchido1.TabIndex = 403;
            // 
            // lblCustoPorcaoVisualizarPreenchido10
            // 
            this.lblCustoPorcaoVisualizarPreenchido10.AutoSize = true;
            this.lblCustoPorcaoVisualizarPreenchido10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcaoVisualizarPreenchido10.Location = new System.Drawing.Point(990, 458);
            this.lblCustoPorcaoVisualizarPreenchido10.Name = "lblCustoPorcaoVisualizarPreenchido10";
            this.lblCustoPorcaoVisualizarPreenchido10.Size = new System.Drawing.Size(0, 23);
            this.lblCustoPorcaoVisualizarPreenchido10.TabIndex = 412;
            // 
            // lblCustoPorcaoVisualizarPreenchido9
            // 
            this.lblCustoPorcaoVisualizarPreenchido9.AutoSize = true;
            this.lblCustoPorcaoVisualizarPreenchido9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcaoVisualizarPreenchido9.Location = new System.Drawing.Point(990, 376);
            this.lblCustoPorcaoVisualizarPreenchido9.Name = "lblCustoPorcaoVisualizarPreenchido9";
            this.lblCustoPorcaoVisualizarPreenchido9.Size = new System.Drawing.Size(0, 23);
            this.lblCustoPorcaoVisualizarPreenchido9.TabIndex = 411;
            // 
            // lblCustoPorcaoVisualizarPreenchido8
            // 
            this.lblCustoPorcaoVisualizarPreenchido8.AutoSize = true;
            this.lblCustoPorcaoVisualizarPreenchido8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcaoVisualizarPreenchido8.Location = new System.Drawing.Point(990, 293);
            this.lblCustoPorcaoVisualizarPreenchido8.Name = "lblCustoPorcaoVisualizarPreenchido8";
            this.lblCustoPorcaoVisualizarPreenchido8.Size = new System.Drawing.Size(0, 23);
            this.lblCustoPorcaoVisualizarPreenchido8.TabIndex = 410;
            // 
            // lblCustoPorcaoVisualizarPreenchido7
            // 
            this.lblCustoPorcaoVisualizarPreenchido7.AutoSize = true;
            this.lblCustoPorcaoVisualizarPreenchido7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcaoVisualizarPreenchido7.Location = new System.Drawing.Point(990, 213);
            this.lblCustoPorcaoVisualizarPreenchido7.Name = "lblCustoPorcaoVisualizarPreenchido7";
            this.lblCustoPorcaoVisualizarPreenchido7.Size = new System.Drawing.Size(0, 23);
            this.lblCustoPorcaoVisualizarPreenchido7.TabIndex = 409;
            // 
            // lblCustoPorcaoVisualizarPreenchido6
            // 
            this.lblCustoPorcaoVisualizarPreenchido6.AutoSize = true;
            this.lblCustoPorcaoVisualizarPreenchido6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoPorcaoVisualizarPreenchido6.Location = new System.Drawing.Point(990, 126);
            this.lblCustoPorcaoVisualizarPreenchido6.Name = "lblCustoPorcaoVisualizarPreenchido6";
            this.lblCustoPorcaoVisualizarPreenchido6.Size = new System.Drawing.Size(0, 23);
            this.lblCustoPorcaoVisualizarPreenchido6.TabIndex = 408;
            // 
            // lblPrecoPorcaoVisualizarPreenchido5
            // 
            this.lblPrecoPorcaoVisualizarPreenchido5.AutoSize = true;
            this.lblPrecoPorcaoVisualizarPreenchido5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcaoVisualizarPreenchido5.Location = new System.Drawing.Point(478, 458);
            this.lblPrecoPorcaoVisualizarPreenchido5.Name = "lblPrecoPorcaoVisualizarPreenchido5";
            this.lblPrecoPorcaoVisualizarPreenchido5.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoPorcaoVisualizarPreenchido5.TabIndex = 417;
            // 
            // lblPrecoPorcaoVisualizarPreenchido4
            // 
            this.lblPrecoPorcaoVisualizarPreenchido4.AutoSize = true;
            this.lblPrecoPorcaoVisualizarPreenchido4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcaoVisualizarPreenchido4.Location = new System.Drawing.Point(478, 376);
            this.lblPrecoPorcaoVisualizarPreenchido4.Name = "lblPrecoPorcaoVisualizarPreenchido4";
            this.lblPrecoPorcaoVisualizarPreenchido4.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoPorcaoVisualizarPreenchido4.TabIndex = 416;
            // 
            // lblPrecoPorcaoVisualizarPreenchido3
            // 
            this.lblPrecoPorcaoVisualizarPreenchido3.AutoSize = true;
            this.lblPrecoPorcaoVisualizarPreenchido3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcaoVisualizarPreenchido3.Location = new System.Drawing.Point(478, 293);
            this.lblPrecoPorcaoVisualizarPreenchido3.Name = "lblPrecoPorcaoVisualizarPreenchido3";
            this.lblPrecoPorcaoVisualizarPreenchido3.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoPorcaoVisualizarPreenchido3.TabIndex = 415;
            // 
            // lblPrecoPorcaoVisualizarPreenchido2
            // 
            this.lblPrecoPorcaoVisualizarPreenchido2.AutoSize = true;
            this.lblPrecoPorcaoVisualizarPreenchido2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcaoVisualizarPreenchido2.Location = new System.Drawing.Point(478, 213);
            this.lblPrecoPorcaoVisualizarPreenchido2.Name = "lblPrecoPorcaoVisualizarPreenchido2";
            this.lblPrecoPorcaoVisualizarPreenchido2.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoPorcaoVisualizarPreenchido2.TabIndex = 414;
            // 
            // lblPrecoPorcaoVisualizarPreenchido1
            // 
            this.lblPrecoPorcaoVisualizarPreenchido1.AutoSize = true;
            this.lblPrecoPorcaoVisualizarPreenchido1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcaoVisualizarPreenchido1.Location = new System.Drawing.Point(478, 126);
            this.lblPrecoPorcaoVisualizarPreenchido1.Name = "lblPrecoPorcaoVisualizarPreenchido1";
            this.lblPrecoPorcaoVisualizarPreenchido1.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoPorcaoVisualizarPreenchido1.TabIndex = 413;
            // 
            // lblPrecoPorcaoVisualizarPreenchido10
            // 
            this.lblPrecoPorcaoVisualizarPreenchido10.AutoSize = true;
            this.lblPrecoPorcaoVisualizarPreenchido10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcaoVisualizarPreenchido10.Location = new System.Drawing.Point(1083, 458);
            this.lblPrecoPorcaoVisualizarPreenchido10.Name = "lblPrecoPorcaoVisualizarPreenchido10";
            this.lblPrecoPorcaoVisualizarPreenchido10.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoPorcaoVisualizarPreenchido10.TabIndex = 422;
            // 
            // lblPrecoPorcaoVisualizarPreenchido9
            // 
            this.lblPrecoPorcaoVisualizarPreenchido9.AutoSize = true;
            this.lblPrecoPorcaoVisualizarPreenchido9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcaoVisualizarPreenchido9.Location = new System.Drawing.Point(1083, 376);
            this.lblPrecoPorcaoVisualizarPreenchido9.Name = "lblPrecoPorcaoVisualizarPreenchido9";
            this.lblPrecoPorcaoVisualizarPreenchido9.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoPorcaoVisualizarPreenchido9.TabIndex = 421;
            // 
            // lblPrecoPorcaoVisualizarPreenchido8
            // 
            this.lblPrecoPorcaoVisualizarPreenchido8.AutoSize = true;
            this.lblPrecoPorcaoVisualizarPreenchido8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcaoVisualizarPreenchido8.Location = new System.Drawing.Point(1083, 293);
            this.lblPrecoPorcaoVisualizarPreenchido8.Name = "lblPrecoPorcaoVisualizarPreenchido8";
            this.lblPrecoPorcaoVisualizarPreenchido8.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoPorcaoVisualizarPreenchido8.TabIndex = 420;
            // 
            // lblPrecoPorcaoVisualizarPreenchido7
            // 
            this.lblPrecoPorcaoVisualizarPreenchido7.AutoSize = true;
            this.lblPrecoPorcaoVisualizarPreenchido7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcaoVisualizarPreenchido7.Location = new System.Drawing.Point(1083, 213);
            this.lblPrecoPorcaoVisualizarPreenchido7.Name = "lblPrecoPorcaoVisualizarPreenchido7";
            this.lblPrecoPorcaoVisualizarPreenchido7.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoPorcaoVisualizarPreenchido7.TabIndex = 419;
            // 
            // lblPrecoPorcaoVisualizarPreenchido6
            // 
            this.lblPrecoPorcaoVisualizarPreenchido6.AutoSize = true;
            this.lblPrecoPorcaoVisualizarPreenchido6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoPorcaoVisualizarPreenchido6.Location = new System.Drawing.Point(1083, 126);
            this.lblPrecoPorcaoVisualizarPreenchido6.Name = "lblPrecoPorcaoVisualizarPreenchido6";
            this.lblPrecoPorcaoVisualizarPreenchido6.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoPorcaoVisualizarPreenchido6.TabIndex = 418;
            // 
            // buttonDeletarCadastroPorcoesVisualizar
            // 
            this.buttonDeletarCadastroPorcoesVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeletarCadastroPorcoesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletarCadastroPorcoesVisualizar.ForeColor = System.Drawing.Color.Red;
            this.buttonDeletarCadastroPorcoesVisualizar.Location = new System.Drawing.Point(1008, 559);
            this.buttonDeletarCadastroPorcoesVisualizar.Name = "buttonDeletarCadastroPorcoesVisualizar";
            this.buttonDeletarCadastroPorcoesVisualizar.Size = new System.Drawing.Size(167, 55);
            this.buttonDeletarCadastroPorcoesVisualizar.TabIndex = 424;
            this.buttonDeletarCadastroPorcoesVisualizar.Text = "Deletar";
            this.buttonDeletarCadastroPorcoesVisualizar.UseVisualStyleBackColor = false;
            // 
            // buttonEditarCadastroPorcoesVisualizar
            // 
            this.buttonEditarCadastroPorcoesVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditarCadastroPorcoesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCadastroPorcoesVisualizar.ForeColor = System.Drawing.Color.Gold;
            this.buttonEditarCadastroPorcoesVisualizar.Location = new System.Drawing.Point(822, 559);
            this.buttonEditarCadastroPorcoesVisualizar.Name = "buttonEditarCadastroPorcoesVisualizar";
            this.buttonEditarCadastroPorcoesVisualizar.Size = new System.Drawing.Size(167, 55);
            this.buttonEditarCadastroPorcoesVisualizar.TabIndex = 423;
            this.buttonEditarCadastroPorcoesVisualizar.Text = "Editar";
            this.buttonEditarCadastroPorcoesVisualizar.UseVisualStyleBackColor = false;
            // 
            // CadastroPorcoesVisualizar
            // 
            this.ClientSize = new System.Drawing.Size(1187, 626);
            this.Controls.Add(this.buttonDeletarCadastroPorcoesVisualizar);
            this.Controls.Add(this.buttonEditarCadastroPorcoesVisualizar);
            this.Controls.Add(this.lblPrecoPorcaoVisualizarPreenchido10);
            this.Controls.Add(this.lblPrecoPorcaoVisualizarPreenchido9);
            this.Controls.Add(this.lblPrecoPorcaoVisualizarPreenchido8);
            this.Controls.Add(this.lblPrecoPorcaoVisualizarPreenchido7);
            this.Controls.Add(this.lblPrecoPorcaoVisualizarPreenchido6);
            this.Controls.Add(this.lblPrecoPorcaoVisualizarPreenchido5);
            this.Controls.Add(this.lblPrecoPorcaoVisualizarPreenchido4);
            this.Controls.Add(this.lblPrecoPorcaoVisualizarPreenchido3);
            this.Controls.Add(this.lblPrecoPorcaoVisualizarPreenchido2);
            this.Controls.Add(this.lblPrecoPorcaoVisualizarPreenchido1);
            this.Controls.Add(this.lblCustoPorcaoVisualizarPreenchido10);
            this.Controls.Add(this.lblCustoPorcaoVisualizarPreenchido9);
            this.Controls.Add(this.lblCustoPorcaoVisualizarPreenchido8);
            this.Controls.Add(this.lblCustoPorcaoVisualizarPreenchido7);
            this.Controls.Add(this.lblCustoPorcaoVisualizarPreenchido6);
            this.Controls.Add(this.lblCustoPorcaoVisualizarPreenchido5);
            this.Controls.Add(this.lblCustoPorcaoVisualizarPreenchido4);
            this.Controls.Add(this.lblCustoPorcaoVisualizarPreenchido3);
            this.Controls.Add(this.lblCustoPorcaoVisualizarPreenchido2);
            this.Controls.Add(this.lblCustoPorcaoVisualizarPreenchido1);
            this.Controls.Add(this.lblPorcaoVisualizarPreenchido10);
            this.Controls.Add(this.lblPorcaoVisualizarPreenchido9);
            this.Controls.Add(this.lblPorcaoVisualizarPreenchido8);
            this.Controls.Add(this.lblPorcaoVisualizarPreenchido7);
            this.Controls.Add(this.lblPorcaoVisualizarPreenchido6);
            this.Controls.Add(this.lblPorcaoVisualizarPreenchido5);
            this.Controls.Add(this.lblPorcaoVisualizarPreenchido4);
            this.Controls.Add(this.lblPorcaoVisualizarPreenchido3);
            this.Controls.Add(this.lblPorcaoVisualizarPreenchido2);
            this.Controls.Add(this.lblPorcaoVisualizarPreenchido1);
            this.Controls.Add(this.lblPorcaoVisualizar9);
            this.Controls.Add(this.imgPorcao10);
            this.Controls.Add(this.lblPorcaoVisualizar10);
            this.Controls.Add(this.imgPorcao5);
            this.Controls.Add(this.lblPorcaoVisualizar5);
            this.Controls.Add(this.imgPorcao9);
            this.Controls.Add(this.imgPorcao8);
            this.Controls.Add(this.imgPorcao7);
            this.Controls.Add(this.imgPorcao6);
            this.Controls.Add(this.lblPorcoesVisualizar2);
            this.Controls.Add(this.lblPrecoPorcoesVisualizar2);
            this.Controls.Add(this.lblCustoPorcoesVisualizar2);
            this.Controls.Add(this.lblImagemPorcoesVisualizar2);
            this.Controls.Add(this.imgPorcao4);
            this.Controls.Add(this.imgPorcao3);
            this.Controls.Add(this.imgPorcao2);
            this.Controls.Add(this.lblPorcoesVisualizar1);
            this.Controls.Add(this.lblPrecoPorcoesVisualizar1);
            this.Controls.Add(this.lblCustoPorcoesVisualizar1);
            this.Controls.Add(this.lblImagemPorcoesVisualizar1);
            this.Controls.Add(this.imgPorcao1);
            this.Controls.Add(this.lblPorcaoVisualizar8);
            this.Controls.Add(this.lblPorcaoVisualizar4);
            this.Controls.Add(this.lblPorcaoVisualizar7);
            this.Controls.Add(this.lblPorcaoVisualizar3);
            this.Controls.Add(this.lblPorcaoVisualizar6);
            this.Controls.Add(this.lblPorcaoVisualizar2);
            this.Controls.Add(this.lblPorcaoVisualizar1);
            this.Controls.Add(this.lblTituloCadastroPorcoesVisualizar);
            this.Name = "CadastroPorcoesVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorcao1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
