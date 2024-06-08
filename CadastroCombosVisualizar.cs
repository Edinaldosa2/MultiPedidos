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
    public partial class CadastroCombosVisualizar : Form
    {
        private CheckedListBox clItensCombo10;
        private CheckedListBox clItensCombo5;
        private CheckedListBox clItensCombo9;
        private CheckedListBox clItensCombo8;
        private CheckedListBox clItensCombo7;
        private CheckedListBox clItensCombo6;
        private CheckedListBox clItensCombo4;
        private CheckedListBox clItensCombo3;
        private CheckedListBox clItensCombo2;
        private Label lblComboVisualizar9;
        private PictureBox imgCombo10;
        private Label lblComboVisualizar10;
        private PictureBox imgCombo5;
        private Label lblComboVisualizar5;
        private PictureBox imgCombo9;
        private PictureBox imgCombo8;
        private PictureBox imgCombo7;
        private PictureBox imgCombo6;
        private Label lblCombosVisualizar2;
        private Label lblPrecoCombosVisualizar2;
        private Label lblCustoCombosVisualizar2;
        private Label lblImagemCombosVisualizar2;
        private PictureBox imgCombo4;
        private PictureBox imgCombo3;
        private PictureBox imgCombo2;
        private Label lblCombosVisualizar1;
        private Label lblPrecoCombosVisualizar1;
        private Label lblCustoCombosVisualizar1;
        private Label lblImagemCombosVisualizar1;
        private PictureBox imgCombo1;
        private Label lblComboVisualizar8;
        private Label lblComboVisualizar4;
        private Label lblComboVisualizar7;
        private Label lblComboVisualizar3;
        private Label lblComboVisualizar6;
        private Label lblComboVisualizar2;
        private Label lblComboVisualizar1;
        private Label lblComboVisualizarPreenchido1;
        private CheckedListBox clItensComboVisualizar1;
        private Label lblComboVisualizarPreenchido2;
        private Label lblComboVisualizarPreenchido3;
        private Label lblComboVisualizarPreenchido4;
        private Label lblComboVisualizarPreenchido5;
        private Label lblComboVisualizarPreenchido10;
        private Label lblComboVisualizarPreenchido9;
        private Label lblComboVisualizarPreenchido8;
        private Label lblComboVisualizarPreenchido7;
        private Label lblComboVisualizarPreenchido6;
        private Label lblCustoComboVisualizarPreenchido5;
        private Label lblCustoComboVisualizarPreenchido4;
        private Label lblCustoComboVisualizarPreenchido3;
        private Label lblCustoComboVisualizarPreenchido2;
        private Label lblCustoComboVisualizarPreenchido1;
        private Label lblPrecoComboVisualizarPreenchido5;
        private Label lblPrecoComboVisualizarPreenchido4;
        private Label lblPrecoComboVisualizarPreenchido3;
        private Label lblPrecoComboVisualizarPreenchido2;
        private Label lblPrecoComboVisualizarPreenchido1;
        private Label lblPrecoComboVisualizarPreenchido10;
        private Label lblPrecoComboVisualizarPreenchido9;
        private Label lblPrecoComboVisualizarPreenchido8;
        private Label lblPrecoComboVisualizarPreenchido7;
        private Label lblPrecoComboVisualizarPreenchido6;
        private Label lblCustoComboVisualizarPreenchido10;
        private Label lblCustoComboVisualizarPreenchido9;
        private Label lblCustoComboVisualizarPreenchido8;
        private Label lblCustoComboVisualizarPreenchido7;
        private Label lblCustoComboVisualizarPreenchido6;
        private Button buttonDeletarCadastroPorcoesVisualizar;
        private Button buttonEditarCadastroPorcoesVisualizar;
        private Label lblTituloCadastroCombos;

        public CadastroCombosVisualizar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.clItensCombo10 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo5 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo9 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo8 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo7 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo6 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo4 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo3 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo2 = new System.Windows.Forms.CheckedListBox();
            this.lblComboVisualizar9 = new System.Windows.Forms.Label();
            this.imgCombo10 = new System.Windows.Forms.PictureBox();
            this.lblComboVisualizar10 = new System.Windows.Forms.Label();
            this.imgCombo5 = new System.Windows.Forms.PictureBox();
            this.lblComboVisualizar5 = new System.Windows.Forms.Label();
            this.imgCombo9 = new System.Windows.Forms.PictureBox();
            this.imgCombo8 = new System.Windows.Forms.PictureBox();
            this.imgCombo7 = new System.Windows.Forms.PictureBox();
            this.imgCombo6 = new System.Windows.Forms.PictureBox();
            this.lblCombosVisualizar2 = new System.Windows.Forms.Label();
            this.lblPrecoCombosVisualizar2 = new System.Windows.Forms.Label();
            this.lblCustoCombosVisualizar2 = new System.Windows.Forms.Label();
            this.lblImagemCombosVisualizar2 = new System.Windows.Forms.Label();
            this.imgCombo4 = new System.Windows.Forms.PictureBox();
            this.imgCombo3 = new System.Windows.Forms.PictureBox();
            this.imgCombo2 = new System.Windows.Forms.PictureBox();
            this.lblCombosVisualizar1 = new System.Windows.Forms.Label();
            this.lblPrecoCombosVisualizar1 = new System.Windows.Forms.Label();
            this.lblCustoCombosVisualizar1 = new System.Windows.Forms.Label();
            this.lblImagemCombosVisualizar1 = new System.Windows.Forms.Label();
            this.imgCombo1 = new System.Windows.Forms.PictureBox();
            this.lblComboVisualizar8 = new System.Windows.Forms.Label();
            this.lblComboVisualizar4 = new System.Windows.Forms.Label();
            this.lblComboVisualizar7 = new System.Windows.Forms.Label();
            this.lblComboVisualizar3 = new System.Windows.Forms.Label();
            this.lblComboVisualizar6 = new System.Windows.Forms.Label();
            this.lblComboVisualizar2 = new System.Windows.Forms.Label();
            this.lblComboVisualizar1 = new System.Windows.Forms.Label();
            this.lblTituloCadastroCombos = new System.Windows.Forms.Label();
            this.lblComboVisualizarPreenchido1 = new System.Windows.Forms.Label();
            this.clItensComboVisualizar1 = new System.Windows.Forms.CheckedListBox();
            this.lblComboVisualizarPreenchido2 = new System.Windows.Forms.Label();
            this.lblComboVisualizarPreenchido3 = new System.Windows.Forms.Label();
            this.lblComboVisualizarPreenchido4 = new System.Windows.Forms.Label();
            this.lblComboVisualizarPreenchido5 = new System.Windows.Forms.Label();
            this.lblComboVisualizarPreenchido10 = new System.Windows.Forms.Label();
            this.lblComboVisualizarPreenchido9 = new System.Windows.Forms.Label();
            this.lblComboVisualizarPreenchido8 = new System.Windows.Forms.Label();
            this.lblComboVisualizarPreenchido7 = new System.Windows.Forms.Label();
            this.lblComboVisualizarPreenchido6 = new System.Windows.Forms.Label();
            this.lblCustoComboVisualizarPreenchido5 = new System.Windows.Forms.Label();
            this.lblCustoComboVisualizarPreenchido4 = new System.Windows.Forms.Label();
            this.lblCustoComboVisualizarPreenchido3 = new System.Windows.Forms.Label();
            this.lblCustoComboVisualizarPreenchido2 = new System.Windows.Forms.Label();
            this.lblCustoComboVisualizarPreenchido1 = new System.Windows.Forms.Label();
            this.lblPrecoComboVisualizarPreenchido5 = new System.Windows.Forms.Label();
            this.lblPrecoComboVisualizarPreenchido4 = new System.Windows.Forms.Label();
            this.lblPrecoComboVisualizarPreenchido3 = new System.Windows.Forms.Label();
            this.lblPrecoComboVisualizarPreenchido2 = new System.Windows.Forms.Label();
            this.lblPrecoComboVisualizarPreenchido1 = new System.Windows.Forms.Label();
            this.lblPrecoComboVisualizarPreenchido10 = new System.Windows.Forms.Label();
            this.lblPrecoComboVisualizarPreenchido9 = new System.Windows.Forms.Label();
            this.lblPrecoComboVisualizarPreenchido8 = new System.Windows.Forms.Label();
            this.lblPrecoComboVisualizarPreenchido7 = new System.Windows.Forms.Label();
            this.lblPrecoComboVisualizarPreenchido6 = new System.Windows.Forms.Label();
            this.lblCustoComboVisualizarPreenchido10 = new System.Windows.Forms.Label();
            this.lblCustoComboVisualizarPreenchido9 = new System.Windows.Forms.Label();
            this.lblCustoComboVisualizarPreenchido8 = new System.Windows.Forms.Label();
            this.lblCustoComboVisualizarPreenchido7 = new System.Windows.Forms.Label();
            this.lblCustoComboVisualizarPreenchido6 = new System.Windows.Forms.Label();
            this.buttonDeletarCadastroPorcoesVisualizar = new System.Windows.Forms.Button();
            this.buttonEditarCadastroPorcoesVisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo1)).BeginInit();
            this.SuspendLayout();
            // 
            // clItensCombo10
            // 
            this.clItensCombo10.FormattingEnabled = true;
            this.clItensCombo10.Location = new System.Drawing.Point(652, 479);
            this.clItensCombo10.Name = "clItensCombo10";
            this.clItensCombo10.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo10.TabIndex = 533;
            // 
            // clItensCombo5
            // 
            this.clItensCombo5.FormattingEnabled = true;
            this.clItensCombo5.Location = new System.Drawing.Point(45, 479);
            this.clItensCombo5.Name = "clItensCombo5";
            this.clItensCombo5.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo5.TabIndex = 532;
            // 
            // clItensCombo9
            // 
            this.clItensCombo9.FormattingEnabled = true;
            this.clItensCombo9.Location = new System.Drawing.Point(652, 396);
            this.clItensCombo9.Name = "clItensCombo9";
            this.clItensCombo9.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo9.TabIndex = 531;
            // 
            // clItensCombo8
            // 
            this.clItensCombo8.FormattingEnabled = true;
            this.clItensCombo8.Location = new System.Drawing.Point(652, 313);
            this.clItensCombo8.Name = "clItensCombo8";
            this.clItensCombo8.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo8.TabIndex = 530;
            // 
            // clItensCombo7
            // 
            this.clItensCombo7.FormattingEnabled = true;
            this.clItensCombo7.Location = new System.Drawing.Point(652, 234);
            this.clItensCombo7.Name = "clItensCombo7";
            this.clItensCombo7.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo7.TabIndex = 529;
            // 
            // clItensCombo6
            // 
            this.clItensCombo6.FormattingEnabled = true;
            this.clItensCombo6.Location = new System.Drawing.Point(652, 147);
            this.clItensCombo6.Name = "clItensCombo6";
            this.clItensCombo6.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo6.TabIndex = 528;
            // 
            // clItensCombo4
            // 
            this.clItensCombo4.FormattingEnabled = true;
            this.clItensCombo4.Location = new System.Drawing.Point(45, 396);
            this.clItensCombo4.Name = "clItensCombo4";
            this.clItensCombo4.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo4.TabIndex = 527;
            // 
            // clItensCombo3
            // 
            this.clItensCombo3.FormattingEnabled = true;
            this.clItensCombo3.Location = new System.Drawing.Point(45, 313);
            this.clItensCombo3.Name = "clItensCombo3";
            this.clItensCombo3.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo3.TabIndex = 526;
            // 
            // clItensCombo2
            // 
            this.clItensCombo2.FormattingEnabled = true;
            this.clItensCombo2.Location = new System.Drawing.Point(45, 230);
            this.clItensCombo2.Name = "clItensCombo2";
            this.clItensCombo2.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo2.TabIndex = 525;
            // 
            // lblComboVisualizar9
            // 
            this.lblComboVisualizar9.AutoSize = true;
            this.lblComboVisualizar9.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizar9.Location = new System.Drawing.Point(627, 367);
            this.lblComboVisualizar9.Name = "lblComboVisualizar9";
            this.lblComboVisualizar9.Size = new System.Drawing.Size(19, 24);
            this.lblComboVisualizar9.TabIndex = 523;
            this.lblComboVisualizar9.Text = "9";
            // 
            // imgCombo10
            // 
            this.imgCombo10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo10.Location = new System.Drawing.Point(841, 452);
            this.imgCombo10.Name = "imgCombo10";
            this.imgCombo10.Size = new System.Drawing.Size(114, 77);
            this.imgCombo10.TabIndex = 513;
            this.imgCombo10.TabStop = false;
            // 
            // lblComboVisualizar10
            // 
            this.lblComboVisualizar10.AutoSize = true;
            this.lblComboVisualizar10.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizar10.Location = new System.Drawing.Point(618, 452);
            this.lblComboVisualizar10.Name = "lblComboVisualizar10";
            this.lblComboVisualizar10.Size = new System.Drawing.Size(28, 24);
            this.lblComboVisualizar10.TabIndex = 512;
            this.lblComboVisualizar10.Text = "10";
            // 
            // imgCombo5
            // 
            this.imgCombo5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo5.Location = new System.Drawing.Point(234, 452);
            this.imgCombo5.Name = "imgCombo5";
            this.imgCombo5.Size = new System.Drawing.Size(114, 77);
            this.imgCombo5.TabIndex = 502;
            this.imgCombo5.TabStop = false;
            // 
            // lblComboVisualizar5
            // 
            this.lblComboVisualizar5.AutoSize = true;
            this.lblComboVisualizar5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizar5.Location = new System.Drawing.Point(20, 452);
            this.lblComboVisualizar5.Name = "lblComboVisualizar5";
            this.lblComboVisualizar5.Size = new System.Drawing.Size(19, 24);
            this.lblComboVisualizar5.TabIndex = 501;
            this.lblComboVisualizar5.Text = "5";
            // 
            // imgCombo9
            // 
            this.imgCombo9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo9.Location = new System.Drawing.Point(841, 369);
            this.imgCombo9.Name = "imgCombo9";
            this.imgCombo9.Size = new System.Drawing.Size(114, 77);
            this.imgCombo9.TabIndex = 499;
            this.imgCombo9.TabStop = false;
            // 
            // imgCombo8
            // 
            this.imgCombo8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo8.Location = new System.Drawing.Point(841, 286);
            this.imgCombo8.Name = "imgCombo8";
            this.imgCombo8.Size = new System.Drawing.Size(114, 77);
            this.imgCombo8.TabIndex = 498;
            this.imgCombo8.TabStop = false;
            // 
            // imgCombo7
            // 
            this.imgCombo7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo7.Location = new System.Drawing.Point(841, 203);
            this.imgCombo7.Name = "imgCombo7";
            this.imgCombo7.Size = new System.Drawing.Size(114, 77);
            this.imgCombo7.TabIndex = 497;
            this.imgCombo7.TabStop = false;
            // 
            // imgCombo6
            // 
            this.imgCombo6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo6.Location = new System.Drawing.Point(841, 120);
            this.imgCombo6.Name = "imgCombo6";
            this.imgCombo6.Size = new System.Drawing.Size(114, 77);
            this.imgCombo6.TabIndex = 494;
            this.imgCombo6.TabStop = false;
            // 
            // lblCombosVisualizar2
            // 
            this.lblCombosVisualizar2.AutoSize = true;
            this.lblCombosVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombosVisualizar2.Location = new System.Drawing.Point(703, 80);
            this.lblCombosVisualizar2.Name = "lblCombosVisualizar2";
            this.lblCombosVisualizar2.Size = new System.Drawing.Size(78, 24);
            this.lblCombosVisualizar2.TabIndex = 493;
            this.lblCombosVisualizar2.Text = "Combos";
            // 
            // lblPrecoCombosVisualizar2
            // 
            this.lblPrecoCombosVisualizar2.AutoSize = true;
            this.lblPrecoCombosVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCombosVisualizar2.Location = new System.Drawing.Point(1090, 80);
            this.lblPrecoCombosVisualizar2.Name = "lblPrecoCombosVisualizar2";
            this.lblPrecoCombosVisualizar2.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoCombosVisualizar2.TabIndex = 492;
            this.lblPrecoCombosVisualizar2.Text = "Preço ($)";
            // 
            // lblCustoCombosVisualizar2
            // 
            this.lblCustoCombosVisualizar2.AutoSize = true;
            this.lblCustoCombosVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoCombosVisualizar2.Location = new System.Drawing.Point(980, 80);
            this.lblCustoCombosVisualizar2.Name = "lblCustoCombosVisualizar2";
            this.lblCustoCombosVisualizar2.Size = new System.Drawing.Size(86, 24);
            this.lblCustoCombosVisualizar2.TabIndex = 491;
            this.lblCustoCombosVisualizar2.Text = "Custo ($)";
            // 
            // lblImagemCombosVisualizar2
            // 
            this.lblImagemCombosVisualizar2.AutoSize = true;
            this.lblImagemCombosVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemCombosVisualizar2.Location = new System.Drawing.Point(859, 80);
            this.lblImagemCombosVisualizar2.Name = "lblImagemCombosVisualizar2";
            this.lblImagemCombosVisualizar2.Size = new System.Drawing.Size(77, 24);
            this.lblImagemCombosVisualizar2.TabIndex = 490;
            this.lblImagemCombosVisualizar2.Text = "Imagem";
            // 
            // imgCombo4
            // 
            this.imgCombo4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo4.Location = new System.Drawing.Point(234, 369);
            this.imgCombo4.Name = "imgCombo4";
            this.imgCombo4.Size = new System.Drawing.Size(114, 77);
            this.imgCombo4.TabIndex = 489;
            this.imgCombo4.TabStop = false;
            // 
            // imgCombo3
            // 
            this.imgCombo3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo3.Location = new System.Drawing.Point(234, 286);
            this.imgCombo3.Name = "imgCombo3";
            this.imgCombo3.Size = new System.Drawing.Size(114, 77);
            this.imgCombo3.TabIndex = 488;
            this.imgCombo3.TabStop = false;
            // 
            // imgCombo2
            // 
            this.imgCombo2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo2.Location = new System.Drawing.Point(234, 203);
            this.imgCombo2.Name = "imgCombo2";
            this.imgCombo2.Size = new System.Drawing.Size(114, 77);
            this.imgCombo2.TabIndex = 487;
            this.imgCombo2.TabStop = false;
            // 
            // lblCombosVisualizar1
            // 
            this.lblCombosVisualizar1.AutoSize = true;
            this.lblCombosVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombosVisualizar1.Location = new System.Drawing.Point(104, 80);
            this.lblCombosVisualizar1.Name = "lblCombosVisualizar1";
            this.lblCombosVisualizar1.Size = new System.Drawing.Size(78, 24);
            this.lblCombosVisualizar1.TabIndex = 486;
            this.lblCombosVisualizar1.Text = "Combos";
            // 
            // lblPrecoCombosVisualizar1
            // 
            this.lblPrecoCombosVisualizar1.AutoSize = true;
            this.lblPrecoCombosVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCombosVisualizar1.Location = new System.Drawing.Point(485, 80);
            this.lblPrecoCombosVisualizar1.Name = "lblPrecoCombosVisualizar1";
            this.lblPrecoCombosVisualizar1.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoCombosVisualizar1.TabIndex = 485;
            this.lblPrecoCombosVisualizar1.Text = "Preço ($)";
            // 
            // lblCustoCombosVisualizar1
            // 
            this.lblCustoCombosVisualizar1.AutoSize = true;
            this.lblCustoCombosVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoCombosVisualizar1.Location = new System.Drawing.Point(375, 80);
            this.lblCustoCombosVisualizar1.Name = "lblCustoCombosVisualizar1";
            this.lblCustoCombosVisualizar1.Size = new System.Drawing.Size(86, 24);
            this.lblCustoCombosVisualizar1.TabIndex = 483;
            this.lblCustoCombosVisualizar1.Text = "Custo ($)";
            // 
            // lblImagemCombosVisualizar1
            // 
            this.lblImagemCombosVisualizar1.AutoSize = true;
            this.lblImagemCombosVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemCombosVisualizar1.Location = new System.Drawing.Point(254, 80);
            this.lblImagemCombosVisualizar1.Name = "lblImagemCombosVisualizar1";
            this.lblImagemCombosVisualizar1.Size = new System.Drawing.Size(77, 24);
            this.lblImagemCombosVisualizar1.TabIndex = 481;
            this.lblImagemCombosVisualizar1.Text = "Imagem";
            // 
            // imgCombo1
            // 
            this.imgCombo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo1.Location = new System.Drawing.Point(234, 120);
            this.imgCombo1.Name = "imgCombo1";
            this.imgCombo1.Size = new System.Drawing.Size(114, 77);
            this.imgCombo1.TabIndex = 480;
            this.imgCombo1.TabStop = false;
            // 
            // lblComboVisualizar8
            // 
            this.lblComboVisualizar8.AutoSize = true;
            this.lblComboVisualizar8.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizar8.Location = new System.Drawing.Point(627, 284);
            this.lblComboVisualizar8.Name = "lblComboVisualizar8";
            this.lblComboVisualizar8.Size = new System.Drawing.Size(19, 24);
            this.lblComboVisualizar8.TabIndex = 479;
            this.lblComboVisualizar8.Text = "8";
            // 
            // lblComboVisualizar4
            // 
            this.lblComboVisualizar4.AutoSize = true;
            this.lblComboVisualizar4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizar4.Location = new System.Drawing.Point(20, 369);
            this.lblComboVisualizar4.Name = "lblComboVisualizar4";
            this.lblComboVisualizar4.Size = new System.Drawing.Size(19, 24);
            this.lblComboVisualizar4.TabIndex = 477;
            this.lblComboVisualizar4.Text = "4";
            // 
            // lblComboVisualizar7
            // 
            this.lblComboVisualizar7.AutoSize = true;
            this.lblComboVisualizar7.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizar7.Location = new System.Drawing.Point(627, 207);
            this.lblComboVisualizar7.Name = "lblComboVisualizar7";
            this.lblComboVisualizar7.Size = new System.Drawing.Size(19, 24);
            this.lblComboVisualizar7.TabIndex = 475;
            this.lblComboVisualizar7.Text = "7";
            // 
            // lblComboVisualizar3
            // 
            this.lblComboVisualizar3.AutoSize = true;
            this.lblComboVisualizar3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizar3.Location = new System.Drawing.Point(20, 287);
            this.lblComboVisualizar3.Name = "lblComboVisualizar3";
            this.lblComboVisualizar3.Size = new System.Drawing.Size(19, 24);
            this.lblComboVisualizar3.TabIndex = 473;
            this.lblComboVisualizar3.Text = "3";
            // 
            // lblComboVisualizar6
            // 
            this.lblComboVisualizar6.AutoSize = true;
            this.lblComboVisualizar6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizar6.Location = new System.Drawing.Point(627, 120);
            this.lblComboVisualizar6.Name = "lblComboVisualizar6";
            this.lblComboVisualizar6.Size = new System.Drawing.Size(19, 24);
            this.lblComboVisualizar6.TabIndex = 471;
            this.lblComboVisualizar6.Text = "6";
            // 
            // lblComboVisualizar2
            // 
            this.lblComboVisualizar2.AutoSize = true;
            this.lblComboVisualizar2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizar2.Location = new System.Drawing.Point(20, 203);
            this.lblComboVisualizar2.Name = "lblComboVisualizar2";
            this.lblComboVisualizar2.Size = new System.Drawing.Size(19, 24);
            this.lblComboVisualizar2.TabIndex = 469;
            this.lblComboVisualizar2.Text = "2";
            // 
            // lblComboVisualizar1
            // 
            this.lblComboVisualizar1.AutoSize = true;
            this.lblComboVisualizar1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizar1.Location = new System.Drawing.Point(20, 120);
            this.lblComboVisualizar1.Name = "lblComboVisualizar1";
            this.lblComboVisualizar1.Size = new System.Drawing.Size(19, 24);
            this.lblComboVisualizar1.TabIndex = 466;
            this.lblComboVisualizar1.Text = "1";
            // 
            // lblTituloCadastroCombos
            // 
            this.lblTituloCadastroCombos.AutoSize = true;
            this.lblTituloCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroCombos.Location = new System.Drawing.Point(544, 25);
            this.lblTituloCadastroCombos.Name = "lblTituloCadastroCombos";
            this.lblTituloCadastroCombos.Size = new System.Drawing.Size(102, 31);
            this.lblTituloCadastroCombos.TabIndex = 464;
            this.lblTituloCadastroCombos.Text = "Combos";
            // 
            // lblComboVisualizarPreenchido1
            // 
            this.lblComboVisualizarPreenchido1.AutoSize = true;
            this.lblComboVisualizarPreenchido1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizarPreenchido1.Location = new System.Drawing.Point(56, 120);
            this.lblComboVisualizarPreenchido1.Name = "lblComboVisualizarPreenchido1";
            this.lblComboVisualizarPreenchido1.Size = new System.Drawing.Size(73, 23);
            this.lblComboVisualizarPreenchido1.TabIndex = 534;
            this.lblComboVisualizarPreenchido1.Text = "Combos";
            // 
            // clItensComboVisualizar1
            // 
            this.clItensComboVisualizar1.FormattingEnabled = true;
            this.clItensComboVisualizar1.Location = new System.Drawing.Point(45, 146);
            this.clItensComboVisualizar1.Name = "clItensComboVisualizar1";
            this.clItensComboVisualizar1.Size = new System.Drawing.Size(168, 38);
            this.clItensComboVisualizar1.TabIndex = 535;
            // 
            // lblComboVisualizarPreenchido2
            // 
            this.lblComboVisualizarPreenchido2.AutoSize = true;
            this.lblComboVisualizarPreenchido2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizarPreenchido2.Location = new System.Drawing.Point(56, 203);
            this.lblComboVisualizarPreenchido2.Name = "lblComboVisualizarPreenchido2";
            this.lblComboVisualizarPreenchido2.Size = new System.Drawing.Size(73, 23);
            this.lblComboVisualizarPreenchido2.TabIndex = 536;
            this.lblComboVisualizarPreenchido2.Text = "Combos";
            // 
            // lblComboVisualizarPreenchido3
            // 
            this.lblComboVisualizarPreenchido3.AutoSize = true;
            this.lblComboVisualizarPreenchido3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizarPreenchido3.Location = new System.Drawing.Point(56, 290);
            this.lblComboVisualizarPreenchido3.Name = "lblComboVisualizarPreenchido3";
            this.lblComboVisualizarPreenchido3.Size = new System.Drawing.Size(73, 23);
            this.lblComboVisualizarPreenchido3.TabIndex = 537;
            this.lblComboVisualizarPreenchido3.Text = "Combos";
            // 
            // lblComboVisualizarPreenchido4
            // 
            this.lblComboVisualizarPreenchido4.AutoSize = true;
            this.lblComboVisualizarPreenchido4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizarPreenchido4.Location = new System.Drawing.Point(56, 373);
            this.lblComboVisualizarPreenchido4.Name = "lblComboVisualizarPreenchido4";
            this.lblComboVisualizarPreenchido4.Size = new System.Drawing.Size(73, 23);
            this.lblComboVisualizarPreenchido4.TabIndex = 538;
            this.lblComboVisualizarPreenchido4.Text = "Combos";
            // 
            // lblComboVisualizarPreenchido5
            // 
            this.lblComboVisualizarPreenchido5.AutoSize = true;
            this.lblComboVisualizarPreenchido5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizarPreenchido5.Location = new System.Drawing.Point(56, 455);
            this.lblComboVisualizarPreenchido5.Name = "lblComboVisualizarPreenchido5";
            this.lblComboVisualizarPreenchido5.Size = new System.Drawing.Size(73, 23);
            this.lblComboVisualizarPreenchido5.TabIndex = 539;
            this.lblComboVisualizarPreenchido5.Text = "Combos";
            // 
            // lblComboVisualizarPreenchido10
            // 
            this.lblComboVisualizarPreenchido10.AutoSize = true;
            this.lblComboVisualizarPreenchido10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizarPreenchido10.Location = new System.Drawing.Point(664, 455);
            this.lblComboVisualizarPreenchido10.Name = "lblComboVisualizarPreenchido10";
            this.lblComboVisualizarPreenchido10.Size = new System.Drawing.Size(73, 23);
            this.lblComboVisualizarPreenchido10.TabIndex = 544;
            this.lblComboVisualizarPreenchido10.Text = "Combos";
            // 
            // lblComboVisualizarPreenchido9
            // 
            this.lblComboVisualizarPreenchido9.AutoSize = true;
            this.lblComboVisualizarPreenchido9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizarPreenchido9.Location = new System.Drawing.Point(664, 373);
            this.lblComboVisualizarPreenchido9.Name = "lblComboVisualizarPreenchido9";
            this.lblComboVisualizarPreenchido9.Size = new System.Drawing.Size(73, 23);
            this.lblComboVisualizarPreenchido9.TabIndex = 543;
            this.lblComboVisualizarPreenchido9.Text = "Combos";
            // 
            // lblComboVisualizarPreenchido8
            // 
            this.lblComboVisualizarPreenchido8.AutoSize = true;
            this.lblComboVisualizarPreenchido8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizarPreenchido8.Location = new System.Drawing.Point(664, 290);
            this.lblComboVisualizarPreenchido8.Name = "lblComboVisualizarPreenchido8";
            this.lblComboVisualizarPreenchido8.Size = new System.Drawing.Size(73, 23);
            this.lblComboVisualizarPreenchido8.TabIndex = 542;
            this.lblComboVisualizarPreenchido8.Text = "Combos";
            // 
            // lblComboVisualizarPreenchido7
            // 
            this.lblComboVisualizarPreenchido7.AutoSize = true;
            this.lblComboVisualizarPreenchido7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizarPreenchido7.Location = new System.Drawing.Point(664, 203);
            this.lblComboVisualizarPreenchido7.Name = "lblComboVisualizarPreenchido7";
            this.lblComboVisualizarPreenchido7.Size = new System.Drawing.Size(73, 23);
            this.lblComboVisualizarPreenchido7.TabIndex = 541;
            this.lblComboVisualizarPreenchido7.Text = "Combos";
            // 
            // lblComboVisualizarPreenchido6
            // 
            this.lblComboVisualizarPreenchido6.AutoSize = true;
            this.lblComboVisualizarPreenchido6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboVisualizarPreenchido6.Location = new System.Drawing.Point(664, 120);
            this.lblComboVisualizarPreenchido6.Name = "lblComboVisualizarPreenchido6";
            this.lblComboVisualizarPreenchido6.Size = new System.Drawing.Size(73, 23);
            this.lblComboVisualizarPreenchido6.TabIndex = 540;
            this.lblComboVisualizarPreenchido6.Text = "Combos";
            // 
            // lblCustoComboVisualizarPreenchido5
            // 
            this.lblCustoComboVisualizarPreenchido5.AutoSize = true;
            this.lblCustoComboVisualizarPreenchido5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoComboVisualizarPreenchido5.Location = new System.Drawing.Point(375, 458);
            this.lblCustoComboVisualizarPreenchido5.Name = "lblCustoComboVisualizarPreenchido5";
            this.lblCustoComboVisualizarPreenchido5.Size = new System.Drawing.Size(73, 23);
            this.lblCustoComboVisualizarPreenchido5.TabIndex = 549;
            this.lblCustoComboVisualizarPreenchido5.Text = "Combos";
            // 
            // lblCustoComboVisualizarPreenchido4
            // 
            this.lblCustoComboVisualizarPreenchido4.AutoSize = true;
            this.lblCustoComboVisualizarPreenchido4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoComboVisualizarPreenchido4.Location = new System.Drawing.Point(375, 376);
            this.lblCustoComboVisualizarPreenchido4.Name = "lblCustoComboVisualizarPreenchido4";
            this.lblCustoComboVisualizarPreenchido4.Size = new System.Drawing.Size(73, 23);
            this.lblCustoComboVisualizarPreenchido4.TabIndex = 548;
            this.lblCustoComboVisualizarPreenchido4.Text = "Combos";
            // 
            // lblCustoComboVisualizarPreenchido3
            // 
            this.lblCustoComboVisualizarPreenchido3.AutoSize = true;
            this.lblCustoComboVisualizarPreenchido3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoComboVisualizarPreenchido3.Location = new System.Drawing.Point(375, 293);
            this.lblCustoComboVisualizarPreenchido3.Name = "lblCustoComboVisualizarPreenchido3";
            this.lblCustoComboVisualizarPreenchido3.Size = new System.Drawing.Size(73, 23);
            this.lblCustoComboVisualizarPreenchido3.TabIndex = 547;
            this.lblCustoComboVisualizarPreenchido3.Text = "Combos";
            // 
            // lblCustoComboVisualizarPreenchido2
            // 
            this.lblCustoComboVisualizarPreenchido2.AutoSize = true;
            this.lblCustoComboVisualizarPreenchido2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoComboVisualizarPreenchido2.Location = new System.Drawing.Point(375, 206);
            this.lblCustoComboVisualizarPreenchido2.Name = "lblCustoComboVisualizarPreenchido2";
            this.lblCustoComboVisualizarPreenchido2.Size = new System.Drawing.Size(73, 23);
            this.lblCustoComboVisualizarPreenchido2.TabIndex = 546;
            this.lblCustoComboVisualizarPreenchido2.Text = "Combos";
            // 
            // lblCustoComboVisualizarPreenchido1
            // 
            this.lblCustoComboVisualizarPreenchido1.AutoSize = true;
            this.lblCustoComboVisualizarPreenchido1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoComboVisualizarPreenchido1.Location = new System.Drawing.Point(375, 123);
            this.lblCustoComboVisualizarPreenchido1.Name = "lblCustoComboVisualizarPreenchido1";
            this.lblCustoComboVisualizarPreenchido1.Size = new System.Drawing.Size(73, 23);
            this.lblCustoComboVisualizarPreenchido1.TabIndex = 545;
            this.lblCustoComboVisualizarPreenchido1.Text = "Combos";
            // 
            // lblPrecoComboVisualizarPreenchido5
            // 
            this.lblPrecoComboVisualizarPreenchido5.AutoSize = true;
            this.lblPrecoComboVisualizarPreenchido5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoComboVisualizarPreenchido5.Location = new System.Drawing.Point(485, 458);
            this.lblPrecoComboVisualizarPreenchido5.Name = "lblPrecoComboVisualizarPreenchido5";
            this.lblPrecoComboVisualizarPreenchido5.Size = new System.Drawing.Size(73, 23);
            this.lblPrecoComboVisualizarPreenchido5.TabIndex = 554;
            this.lblPrecoComboVisualizarPreenchido5.Text = "Combos";
            // 
            // lblPrecoComboVisualizarPreenchido4
            // 
            this.lblPrecoComboVisualizarPreenchido4.AutoSize = true;
            this.lblPrecoComboVisualizarPreenchido4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoComboVisualizarPreenchido4.Location = new System.Drawing.Point(485, 376);
            this.lblPrecoComboVisualizarPreenchido4.Name = "lblPrecoComboVisualizarPreenchido4";
            this.lblPrecoComboVisualizarPreenchido4.Size = new System.Drawing.Size(73, 23);
            this.lblPrecoComboVisualizarPreenchido4.TabIndex = 553;
            this.lblPrecoComboVisualizarPreenchido4.Text = "Combos";
            // 
            // lblPrecoComboVisualizarPreenchido3
            // 
            this.lblPrecoComboVisualizarPreenchido3.AutoSize = true;
            this.lblPrecoComboVisualizarPreenchido3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoComboVisualizarPreenchido3.Location = new System.Drawing.Point(485, 293);
            this.lblPrecoComboVisualizarPreenchido3.Name = "lblPrecoComboVisualizarPreenchido3";
            this.lblPrecoComboVisualizarPreenchido3.Size = new System.Drawing.Size(73, 23);
            this.lblPrecoComboVisualizarPreenchido3.TabIndex = 552;
            this.lblPrecoComboVisualizarPreenchido3.Text = "Combos";
            // 
            // lblPrecoComboVisualizarPreenchido2
            // 
            this.lblPrecoComboVisualizarPreenchido2.AutoSize = true;
            this.lblPrecoComboVisualizarPreenchido2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoComboVisualizarPreenchido2.Location = new System.Drawing.Point(485, 206);
            this.lblPrecoComboVisualizarPreenchido2.Name = "lblPrecoComboVisualizarPreenchido2";
            this.lblPrecoComboVisualizarPreenchido2.Size = new System.Drawing.Size(73, 23);
            this.lblPrecoComboVisualizarPreenchido2.TabIndex = 551;
            this.lblPrecoComboVisualizarPreenchido2.Text = "Combos";
            // 
            // lblPrecoComboVisualizarPreenchido1
            // 
            this.lblPrecoComboVisualizarPreenchido1.AutoSize = true;
            this.lblPrecoComboVisualizarPreenchido1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoComboVisualizarPreenchido1.Location = new System.Drawing.Point(485, 123);
            this.lblPrecoComboVisualizarPreenchido1.Name = "lblPrecoComboVisualizarPreenchido1";
            this.lblPrecoComboVisualizarPreenchido1.Size = new System.Drawing.Size(73, 23);
            this.lblPrecoComboVisualizarPreenchido1.TabIndex = 550;
            this.lblPrecoComboVisualizarPreenchido1.Text = "Combos";
            // 
            // lblPrecoComboVisualizarPreenchido10
            // 
            this.lblPrecoComboVisualizarPreenchido10.AutoSize = true;
            this.lblPrecoComboVisualizarPreenchido10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoComboVisualizarPreenchido10.Location = new System.Drawing.Point(1090, 470);
            this.lblPrecoComboVisualizarPreenchido10.Name = "lblPrecoComboVisualizarPreenchido10";
            this.lblPrecoComboVisualizarPreenchido10.Size = new System.Drawing.Size(73, 23);
            this.lblPrecoComboVisualizarPreenchido10.TabIndex = 564;
            this.lblPrecoComboVisualizarPreenchido10.Text = "Combos";
            // 
            // lblPrecoComboVisualizarPreenchido9
            // 
            this.lblPrecoComboVisualizarPreenchido9.AutoSize = true;
            this.lblPrecoComboVisualizarPreenchido9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoComboVisualizarPreenchido9.Location = new System.Drawing.Point(1090, 388);
            this.lblPrecoComboVisualizarPreenchido9.Name = "lblPrecoComboVisualizarPreenchido9";
            this.lblPrecoComboVisualizarPreenchido9.Size = new System.Drawing.Size(73, 23);
            this.lblPrecoComboVisualizarPreenchido9.TabIndex = 563;
            this.lblPrecoComboVisualizarPreenchido9.Text = "Combos";
            // 
            // lblPrecoComboVisualizarPreenchido8
            // 
            this.lblPrecoComboVisualizarPreenchido8.AutoSize = true;
            this.lblPrecoComboVisualizarPreenchido8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoComboVisualizarPreenchido8.Location = new System.Drawing.Point(1090, 305);
            this.lblPrecoComboVisualizarPreenchido8.Name = "lblPrecoComboVisualizarPreenchido8";
            this.lblPrecoComboVisualizarPreenchido8.Size = new System.Drawing.Size(73, 23);
            this.lblPrecoComboVisualizarPreenchido8.TabIndex = 562;
            this.lblPrecoComboVisualizarPreenchido8.Text = "Combos";
            // 
            // lblPrecoComboVisualizarPreenchido7
            // 
            this.lblPrecoComboVisualizarPreenchido7.AutoSize = true;
            this.lblPrecoComboVisualizarPreenchido7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoComboVisualizarPreenchido7.Location = new System.Drawing.Point(1090, 218);
            this.lblPrecoComboVisualizarPreenchido7.Name = "lblPrecoComboVisualizarPreenchido7";
            this.lblPrecoComboVisualizarPreenchido7.Size = new System.Drawing.Size(73, 23);
            this.lblPrecoComboVisualizarPreenchido7.TabIndex = 561;
            this.lblPrecoComboVisualizarPreenchido7.Text = "Combos";
            // 
            // lblPrecoComboVisualizarPreenchido6
            // 
            this.lblPrecoComboVisualizarPreenchido6.AutoSize = true;
            this.lblPrecoComboVisualizarPreenchido6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoComboVisualizarPreenchido6.Location = new System.Drawing.Point(1090, 135);
            this.lblPrecoComboVisualizarPreenchido6.Name = "lblPrecoComboVisualizarPreenchido6";
            this.lblPrecoComboVisualizarPreenchido6.Size = new System.Drawing.Size(73, 23);
            this.lblPrecoComboVisualizarPreenchido6.TabIndex = 560;
            this.lblPrecoComboVisualizarPreenchido6.Text = "Combos";
            // 
            // lblCustoComboVisualizarPreenchido10
            // 
            this.lblCustoComboVisualizarPreenchido10.AutoSize = true;
            this.lblCustoComboVisualizarPreenchido10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoComboVisualizarPreenchido10.Location = new System.Drawing.Point(980, 470);
            this.lblCustoComboVisualizarPreenchido10.Name = "lblCustoComboVisualizarPreenchido10";
            this.lblCustoComboVisualizarPreenchido10.Size = new System.Drawing.Size(73, 23);
            this.lblCustoComboVisualizarPreenchido10.TabIndex = 559;
            this.lblCustoComboVisualizarPreenchido10.Text = "Combos";
            // 
            // lblCustoComboVisualizarPreenchido9
            // 
            this.lblCustoComboVisualizarPreenchido9.AutoSize = true;
            this.lblCustoComboVisualizarPreenchido9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoComboVisualizarPreenchido9.Location = new System.Drawing.Point(980, 388);
            this.lblCustoComboVisualizarPreenchido9.Name = "lblCustoComboVisualizarPreenchido9";
            this.lblCustoComboVisualizarPreenchido9.Size = new System.Drawing.Size(73, 23);
            this.lblCustoComboVisualizarPreenchido9.TabIndex = 558;
            this.lblCustoComboVisualizarPreenchido9.Text = "Combos";
            // 
            // lblCustoComboVisualizarPreenchido8
            // 
            this.lblCustoComboVisualizarPreenchido8.AutoSize = true;
            this.lblCustoComboVisualizarPreenchido8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoComboVisualizarPreenchido8.Location = new System.Drawing.Point(980, 305);
            this.lblCustoComboVisualizarPreenchido8.Name = "lblCustoComboVisualizarPreenchido8";
            this.lblCustoComboVisualizarPreenchido8.Size = new System.Drawing.Size(73, 23);
            this.lblCustoComboVisualizarPreenchido8.TabIndex = 557;
            this.lblCustoComboVisualizarPreenchido8.Text = "Combos";
            // 
            // lblCustoComboVisualizarPreenchido7
            // 
            this.lblCustoComboVisualizarPreenchido7.AutoSize = true;
            this.lblCustoComboVisualizarPreenchido7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoComboVisualizarPreenchido7.Location = new System.Drawing.Point(980, 218);
            this.lblCustoComboVisualizarPreenchido7.Name = "lblCustoComboVisualizarPreenchido7";
            this.lblCustoComboVisualizarPreenchido7.Size = new System.Drawing.Size(73, 23);
            this.lblCustoComboVisualizarPreenchido7.TabIndex = 556;
            this.lblCustoComboVisualizarPreenchido7.Text = "Combos";
            // 
            // lblCustoComboVisualizarPreenchido6
            // 
            this.lblCustoComboVisualizarPreenchido6.AutoSize = true;
            this.lblCustoComboVisualizarPreenchido6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoComboVisualizarPreenchido6.Location = new System.Drawing.Point(980, 135);
            this.lblCustoComboVisualizarPreenchido6.Name = "lblCustoComboVisualizarPreenchido6";
            this.lblCustoComboVisualizarPreenchido6.Size = new System.Drawing.Size(73, 23);
            this.lblCustoComboVisualizarPreenchido6.TabIndex = 555;
            this.lblCustoComboVisualizarPreenchido6.Text = "Combos";
            // 
            // buttonDeletarCadastroPorcoesVisualizar
            // 
            this.buttonDeletarCadastroPorcoesVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeletarCadastroPorcoesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletarCadastroPorcoesVisualizar.ForeColor = System.Drawing.Color.Red;
            this.buttonDeletarCadastroPorcoesVisualizar.Location = new System.Drawing.Point(1005, 557);
            this.buttonDeletarCadastroPorcoesVisualizar.Name = "buttonDeletarCadastroPorcoesVisualizar";
            this.buttonDeletarCadastroPorcoesVisualizar.Size = new System.Drawing.Size(167, 55);
            this.buttonDeletarCadastroPorcoesVisualizar.TabIndex = 566;
            this.buttonDeletarCadastroPorcoesVisualizar.Text = "Deletar";
            this.buttonDeletarCadastroPorcoesVisualizar.UseVisualStyleBackColor = false;
            // 
            // buttonEditarCadastroPorcoesVisualizar
            // 
            this.buttonEditarCadastroPorcoesVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditarCadastroPorcoesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCadastroPorcoesVisualizar.ForeColor = System.Drawing.Color.Gold;
            this.buttonEditarCadastroPorcoesVisualizar.Location = new System.Drawing.Point(819, 557);
            this.buttonEditarCadastroPorcoesVisualizar.Name = "buttonEditarCadastroPorcoesVisualizar";
            this.buttonEditarCadastroPorcoesVisualizar.Size = new System.Drawing.Size(167, 55);
            this.buttonEditarCadastroPorcoesVisualizar.TabIndex = 565;
            this.buttonEditarCadastroPorcoesVisualizar.Text = "Editar";
            this.buttonEditarCadastroPorcoesVisualizar.UseVisualStyleBackColor = false;
            // 
            // CadastroCombosVisualizar
            // 
            this.ClientSize = new System.Drawing.Size(1185, 624);
            this.Controls.Add(this.buttonDeletarCadastroPorcoesVisualizar);
            this.Controls.Add(this.buttonEditarCadastroPorcoesVisualizar);
            this.Controls.Add(this.lblPrecoComboVisualizarPreenchido10);
            this.Controls.Add(this.lblPrecoComboVisualizarPreenchido9);
            this.Controls.Add(this.lblPrecoComboVisualizarPreenchido8);
            this.Controls.Add(this.lblPrecoComboVisualizarPreenchido7);
            this.Controls.Add(this.lblPrecoComboVisualizarPreenchido6);
            this.Controls.Add(this.lblCustoComboVisualizarPreenchido10);
            this.Controls.Add(this.lblCustoComboVisualizarPreenchido9);
            this.Controls.Add(this.lblCustoComboVisualizarPreenchido8);
            this.Controls.Add(this.lblCustoComboVisualizarPreenchido7);
            this.Controls.Add(this.lblCustoComboVisualizarPreenchido6);
            this.Controls.Add(this.lblPrecoComboVisualizarPreenchido5);
            this.Controls.Add(this.lblPrecoComboVisualizarPreenchido4);
            this.Controls.Add(this.lblPrecoComboVisualizarPreenchido3);
            this.Controls.Add(this.lblPrecoComboVisualizarPreenchido2);
            this.Controls.Add(this.lblPrecoComboVisualizarPreenchido1);
            this.Controls.Add(this.lblCustoComboVisualizarPreenchido5);
            this.Controls.Add(this.lblCustoComboVisualizarPreenchido4);
            this.Controls.Add(this.lblCustoComboVisualizarPreenchido3);
            this.Controls.Add(this.lblCustoComboVisualizarPreenchido2);
            this.Controls.Add(this.lblCustoComboVisualizarPreenchido1);
            this.Controls.Add(this.lblComboVisualizarPreenchido10);
            this.Controls.Add(this.lblComboVisualizarPreenchido9);
            this.Controls.Add(this.lblComboVisualizarPreenchido8);
            this.Controls.Add(this.lblComboVisualizarPreenchido7);
            this.Controls.Add(this.lblComboVisualizarPreenchido6);
            this.Controls.Add(this.lblComboVisualizarPreenchido5);
            this.Controls.Add(this.lblComboVisualizarPreenchido4);
            this.Controls.Add(this.lblComboVisualizarPreenchido3);
            this.Controls.Add(this.lblComboVisualizarPreenchido2);
            this.Controls.Add(this.clItensComboVisualizar1);
            this.Controls.Add(this.lblComboVisualizarPreenchido1);
            this.Controls.Add(this.clItensCombo10);
            this.Controls.Add(this.clItensCombo5);
            this.Controls.Add(this.clItensCombo9);
            this.Controls.Add(this.clItensCombo8);
            this.Controls.Add(this.clItensCombo7);
            this.Controls.Add(this.clItensCombo6);
            this.Controls.Add(this.clItensCombo4);
            this.Controls.Add(this.clItensCombo3);
            this.Controls.Add(this.clItensCombo2);
            this.Controls.Add(this.lblComboVisualizar9);
            this.Controls.Add(this.imgCombo10);
            this.Controls.Add(this.lblComboVisualizar10);
            this.Controls.Add(this.imgCombo5);
            this.Controls.Add(this.lblComboVisualizar5);
            this.Controls.Add(this.imgCombo9);
            this.Controls.Add(this.imgCombo8);
            this.Controls.Add(this.imgCombo7);
            this.Controls.Add(this.imgCombo6);
            this.Controls.Add(this.lblCombosVisualizar2);
            this.Controls.Add(this.lblPrecoCombosVisualizar2);
            this.Controls.Add(this.lblCustoCombosVisualizar2);
            this.Controls.Add(this.lblImagemCombosVisualizar2);
            this.Controls.Add(this.imgCombo4);
            this.Controls.Add(this.imgCombo3);
            this.Controls.Add(this.imgCombo2);
            this.Controls.Add(this.lblCombosVisualizar1);
            this.Controls.Add(this.lblPrecoCombosVisualizar1);
            this.Controls.Add(this.lblCustoCombosVisualizar1);
            this.Controls.Add(this.lblImagemCombosVisualizar1);
            this.Controls.Add(this.imgCombo1);
            this.Controls.Add(this.lblComboVisualizar8);
            this.Controls.Add(this.lblComboVisualizar4);
            this.Controls.Add(this.lblComboVisualizar7);
            this.Controls.Add(this.lblComboVisualizar3);
            this.Controls.Add(this.lblComboVisualizar6);
            this.Controls.Add(this.lblComboVisualizar2);
            this.Controls.Add(this.lblComboVisualizar1);
            this.Controls.Add(this.lblTituloCadastroCombos);
            this.Name = "CadastroCombosVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCombo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
    }
}
