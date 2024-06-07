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
    public partial class CadastroCombos : Form
    {
        private Label lblCombo9;
        private TextBox txtCombo9;
        private TextBox txtPrecoCombo9;
        private TextBox txtCustoCombo9;
        private TextBox txtPrecoCombo8;
        private TextBox txtCustoCombo8;
        private TextBox txtPrecoCombo7;
        private TextBox txtCustoCombo7;
        private TextBox txtPrecoCombo10;
        private TextBox txtCustoCombo10;
        private PictureBox imgCombo10;
        private Label lblCombo10;
        private TextBox txtCombo10;
        private TextBox txtPrecoCombo4;
        private TextBox txtCustoCombo4;
        private TextBox txtPrecoCombo3;
        private TextBox txtCustoCombo3;
        private TextBox txtPrecoCombo2;
        private TextBox txtCustoCombo2;
        private TextBox txtPrecoCombo5;
        private TextBox txtCustoCombo5;
        private PictureBox imgCombo5;
        private Label lblCombo5;
        private TextBox txtCombo5;
        private PictureBox imgCombo9;
        private PictureBox imgCombo8;
        private PictureBox imgCombo7;
        private TextBox txtPrecoCombo6;
        private TextBox txtCustoCombo6;
        private PictureBox imgCombo6;
        private Label lblCombos2;
        private Label lblPrecoCombos2;
        private Label lblCustoCombos2;
        private Label lblImagemCombos2;
        private PictureBox imgCombo4;
        private PictureBox imgCombo3;
        private PictureBox imgCombo2;
        private Label lblCombos1;
        private Label lblPrecoCombos1;
        private TextBox txtPrecoCombo1;
        private Label lblCustoCombos1;
        private TextBox txtCustoCombo1;
        private Label lblImagemCombos1;
        private PictureBox imgCombo1;
        private Label lblCombo8;
        private TextBox txtCombo8;
        private Label lblCombo4;
        private TextBox txtCombo4;
        private Label lblCombo7;
        private TextBox txtCombo7;
        private Label lblCombo3;
        private TextBox txtCombo3;
        private Label lblCombo6;
        private TextBox txtCombo6;
        private Label lblCombo2;
        private TextBox txtCombo2;
        private Button btnSalvarCadastroCombos;
        private Label lblCombo1;
        private TextBox txtCombo1;
        private CheckedListBox clItensCombo1;
        private CheckedListBox clItensCombo2;
        private CheckedListBox clItensCombo3;
        private CheckedListBox clItensCombo4;
        private CheckedListBox clItensCombo6;
        private CheckedListBox clItensCombo7;
        private CheckedListBox clItensCombo8;
        private CheckedListBox clItensCombo9;
        private CheckedListBox clItensCombo5;
        private CheckedListBox clItensCombo10;
        private Label lblTituloCadastroCombos;

        public CadastroCombos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblCombo9 = new System.Windows.Forms.Label();
            this.txtCombo9 = new System.Windows.Forms.TextBox();
            this.txtPrecoCombo9 = new System.Windows.Forms.TextBox();
            this.txtCustoCombo9 = new System.Windows.Forms.TextBox();
            this.txtPrecoCombo8 = new System.Windows.Forms.TextBox();
            this.txtCustoCombo8 = new System.Windows.Forms.TextBox();
            this.txtPrecoCombo7 = new System.Windows.Forms.TextBox();
            this.txtCustoCombo7 = new System.Windows.Forms.TextBox();
            this.txtPrecoCombo10 = new System.Windows.Forms.TextBox();
            this.txtCustoCombo10 = new System.Windows.Forms.TextBox();
            this.imgCombo10 = new System.Windows.Forms.PictureBox();
            this.lblCombo10 = new System.Windows.Forms.Label();
            this.txtCombo10 = new System.Windows.Forms.TextBox();
            this.txtPrecoCombo4 = new System.Windows.Forms.TextBox();
            this.txtCustoCombo4 = new System.Windows.Forms.TextBox();
            this.txtPrecoCombo3 = new System.Windows.Forms.TextBox();
            this.txtCustoCombo3 = new System.Windows.Forms.TextBox();
            this.txtPrecoCombo2 = new System.Windows.Forms.TextBox();
            this.txtCustoCombo2 = new System.Windows.Forms.TextBox();
            this.txtPrecoCombo5 = new System.Windows.Forms.TextBox();
            this.txtCustoCombo5 = new System.Windows.Forms.TextBox();
            this.imgCombo5 = new System.Windows.Forms.PictureBox();
            this.lblCombo5 = new System.Windows.Forms.Label();
            this.txtCombo5 = new System.Windows.Forms.TextBox();
            this.imgCombo9 = new System.Windows.Forms.PictureBox();
            this.imgCombo8 = new System.Windows.Forms.PictureBox();
            this.imgCombo7 = new System.Windows.Forms.PictureBox();
            this.txtPrecoCombo6 = new System.Windows.Forms.TextBox();
            this.txtCustoCombo6 = new System.Windows.Forms.TextBox();
            this.imgCombo6 = new System.Windows.Forms.PictureBox();
            this.lblCombos2 = new System.Windows.Forms.Label();
            this.lblPrecoCombos2 = new System.Windows.Forms.Label();
            this.lblCustoCombos2 = new System.Windows.Forms.Label();
            this.lblImagemCombos2 = new System.Windows.Forms.Label();
            this.imgCombo4 = new System.Windows.Forms.PictureBox();
            this.imgCombo3 = new System.Windows.Forms.PictureBox();
            this.imgCombo2 = new System.Windows.Forms.PictureBox();
            this.lblCombos1 = new System.Windows.Forms.Label();
            this.lblPrecoCombos1 = new System.Windows.Forms.Label();
            this.txtPrecoCombo1 = new System.Windows.Forms.TextBox();
            this.lblCustoCombos1 = new System.Windows.Forms.Label();
            this.txtCustoCombo1 = new System.Windows.Forms.TextBox();
            this.lblImagemCombos1 = new System.Windows.Forms.Label();
            this.imgCombo1 = new System.Windows.Forms.PictureBox();
            this.lblCombo8 = new System.Windows.Forms.Label();
            this.txtCombo8 = new System.Windows.Forms.TextBox();
            this.lblCombo4 = new System.Windows.Forms.Label();
            this.txtCombo4 = new System.Windows.Forms.TextBox();
            this.lblCombo7 = new System.Windows.Forms.Label();
            this.txtCombo7 = new System.Windows.Forms.TextBox();
            this.lblCombo3 = new System.Windows.Forms.Label();
            this.txtCombo3 = new System.Windows.Forms.TextBox();
            this.lblCombo6 = new System.Windows.Forms.Label();
            this.txtCombo6 = new System.Windows.Forms.TextBox();
            this.lblCombo2 = new System.Windows.Forms.Label();
            this.txtCombo2 = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroCombos = new System.Windows.Forms.Button();
            this.lblCombo1 = new System.Windows.Forms.Label();
            this.txtCombo1 = new System.Windows.Forms.TextBox();
            this.lblTituloCadastroCombos = new System.Windows.Forms.Label();
            this.clItensCombo1 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo2 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo3 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo4 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo6 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo7 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo8 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo9 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo5 = new System.Windows.Forms.CheckedListBox();
            this.clItensCombo10 = new System.Windows.Forms.CheckedListBox();
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
            // lblCombo9
            // 
            this.lblCombo9.AutoSize = true;
            this.lblCombo9.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo9.Location = new System.Drawing.Point(636, 368);
            this.lblCombo9.Name = "lblCombo9";
            this.lblCombo9.Size = new System.Drawing.Size(19, 24);
            this.lblCombo9.TabIndex = 452;
            this.lblCombo9.Text = "9";
            // 
            // txtCombo9
            // 
            this.txtCombo9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo9.Location = new System.Drawing.Point(661, 368);
            this.txtCombo9.Name = "txtCombo9";
            this.txtCombo9.Size = new System.Drawing.Size(168, 30);
            this.txtCombo9.TabIndex = 451;
            // 
            // txtPrecoCombo9
            // 
            this.txtPrecoCombo9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCombo9.Location = new System.Drawing.Point(1103, 371);
            this.txtPrecoCombo9.Name = "txtPrecoCombo9";
            this.txtPrecoCombo9.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoCombo9.TabIndex = 450;
            // 
            // txtCustoCombo9
            // 
            this.txtCustoCombo9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCombo9.Location = new System.Drawing.Point(993, 371);
            this.txtCustoCombo9.Name = "txtCustoCombo9";
            this.txtCustoCombo9.Size = new System.Drawing.Size(82, 30);
            this.txtCustoCombo9.TabIndex = 449;
            // 
            // txtPrecoCombo8
            // 
            this.txtPrecoCombo8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCombo8.Location = new System.Drawing.Point(1103, 288);
            this.txtPrecoCombo8.Name = "txtPrecoCombo8";
            this.txtPrecoCombo8.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoCombo8.TabIndex = 448;
            // 
            // txtCustoCombo8
            // 
            this.txtCustoCombo8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCombo8.Location = new System.Drawing.Point(993, 288);
            this.txtCustoCombo8.Name = "txtCustoCombo8";
            this.txtCustoCombo8.Size = new System.Drawing.Size(82, 30);
            this.txtCustoCombo8.TabIndex = 447;
            // 
            // txtPrecoCombo7
            // 
            this.txtPrecoCombo7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCombo7.Location = new System.Drawing.Point(1103, 204);
            this.txtPrecoCombo7.Name = "txtPrecoCombo7";
            this.txtPrecoCombo7.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoCombo7.TabIndex = 446;
            // 
            // txtCustoCombo7
            // 
            this.txtCustoCombo7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCombo7.Location = new System.Drawing.Point(993, 204);
            this.txtCustoCombo7.Name = "txtCustoCombo7";
            this.txtCustoCombo7.Size = new System.Drawing.Size(82, 30);
            this.txtCustoCombo7.TabIndex = 445;
            // 
            // txtPrecoCombo10
            // 
            this.txtPrecoCombo10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCombo10.Location = new System.Drawing.Point(1105, 453);
            this.txtPrecoCombo10.Name = "txtPrecoCombo10";
            this.txtPrecoCombo10.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoCombo10.TabIndex = 444;
            // 
            // txtCustoCombo10
            // 
            this.txtCustoCombo10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCombo10.Location = new System.Drawing.Point(995, 453);
            this.txtCustoCombo10.Name = "txtCustoCombo10";
            this.txtCustoCombo10.Size = new System.Drawing.Size(82, 30);
            this.txtCustoCombo10.TabIndex = 443;
            // 
            // imgCombo10
            // 
            this.imgCombo10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo10.Location = new System.Drawing.Point(850, 453);
            this.imgCombo10.Name = "imgCombo10";
            this.imgCombo10.Size = new System.Drawing.Size(114, 77);
            this.imgCombo10.TabIndex = 442;
            this.imgCombo10.TabStop = false;
            // 
            // lblCombo10
            // 
            this.lblCombo10.AutoSize = true;
            this.lblCombo10.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo10.Location = new System.Drawing.Point(627, 453);
            this.lblCombo10.Name = "lblCombo10";
            this.lblCombo10.Size = new System.Drawing.Size(28, 24);
            this.lblCombo10.TabIndex = 441;
            this.lblCombo10.Text = "10";
            // 
            // txtCombo10
            // 
            this.txtCombo10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo10.Location = new System.Drawing.Point(661, 453);
            this.txtCombo10.Name = "txtCombo10";
            this.txtCombo10.Size = new System.Drawing.Size(168, 30);
            this.txtCombo10.TabIndex = 440;
            // 
            // txtPrecoCombo4
            // 
            this.txtPrecoCombo4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCombo4.Location = new System.Drawing.Point(498, 371);
            this.txtPrecoCombo4.Name = "txtPrecoCombo4";
            this.txtPrecoCombo4.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoCombo4.TabIndex = 439;
            // 
            // txtCustoCombo4
            // 
            this.txtCustoCombo4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCombo4.Location = new System.Drawing.Point(388, 371);
            this.txtCustoCombo4.Name = "txtCustoCombo4";
            this.txtCustoCombo4.Size = new System.Drawing.Size(82, 30);
            this.txtCustoCombo4.TabIndex = 438;
            // 
            // txtPrecoCombo3
            // 
            this.txtPrecoCombo3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCombo3.Location = new System.Drawing.Point(498, 288);
            this.txtPrecoCombo3.Name = "txtPrecoCombo3";
            this.txtPrecoCombo3.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoCombo3.TabIndex = 437;
            // 
            // txtCustoCombo3
            // 
            this.txtCustoCombo3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCombo3.Location = new System.Drawing.Point(388, 288);
            this.txtCustoCombo3.Name = "txtCustoCombo3";
            this.txtCustoCombo3.Size = new System.Drawing.Size(82, 30);
            this.txtCustoCombo3.TabIndex = 436;
            // 
            // txtPrecoCombo2
            // 
            this.txtPrecoCombo2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCombo2.Location = new System.Drawing.Point(498, 204);
            this.txtPrecoCombo2.Name = "txtPrecoCombo2";
            this.txtPrecoCombo2.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoCombo2.TabIndex = 435;
            // 
            // txtCustoCombo2
            // 
            this.txtCustoCombo2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCombo2.Location = new System.Drawing.Point(388, 204);
            this.txtCustoCombo2.Name = "txtCustoCombo2";
            this.txtCustoCombo2.Size = new System.Drawing.Size(82, 30);
            this.txtCustoCombo2.TabIndex = 434;
            // 
            // txtPrecoCombo5
            // 
            this.txtPrecoCombo5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCombo5.Location = new System.Drawing.Point(498, 453);
            this.txtPrecoCombo5.Name = "txtPrecoCombo5";
            this.txtPrecoCombo5.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoCombo5.TabIndex = 433;
            // 
            // txtCustoCombo5
            // 
            this.txtCustoCombo5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCombo5.Location = new System.Drawing.Point(388, 453);
            this.txtCustoCombo5.Name = "txtCustoCombo5";
            this.txtCustoCombo5.Size = new System.Drawing.Size(82, 30);
            this.txtCustoCombo5.TabIndex = 432;
            // 
            // imgCombo5
            // 
            this.imgCombo5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo5.Location = new System.Drawing.Point(243, 453);
            this.imgCombo5.Name = "imgCombo5";
            this.imgCombo5.Size = new System.Drawing.Size(114, 77);
            this.imgCombo5.TabIndex = 431;
            this.imgCombo5.TabStop = false;
            // 
            // lblCombo5
            // 
            this.lblCombo5.AutoSize = true;
            this.lblCombo5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo5.Location = new System.Drawing.Point(29, 453);
            this.lblCombo5.Name = "lblCombo5";
            this.lblCombo5.Size = new System.Drawing.Size(19, 24);
            this.lblCombo5.TabIndex = 430;
            this.lblCombo5.Text = "5";
            // 
            // txtCombo5
            // 
            this.txtCombo5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo5.Location = new System.Drawing.Point(54, 453);
            this.txtCombo5.Name = "txtCombo5";
            this.txtCombo5.Size = new System.Drawing.Size(168, 30);
            this.txtCombo5.TabIndex = 429;
            // 
            // imgCombo9
            // 
            this.imgCombo9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo9.Location = new System.Drawing.Point(850, 370);
            this.imgCombo9.Name = "imgCombo9";
            this.imgCombo9.Size = new System.Drawing.Size(114, 77);
            this.imgCombo9.TabIndex = 428;
            this.imgCombo9.TabStop = false;
            // 
            // imgCombo8
            // 
            this.imgCombo8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo8.Location = new System.Drawing.Point(850, 287);
            this.imgCombo8.Name = "imgCombo8";
            this.imgCombo8.Size = new System.Drawing.Size(114, 77);
            this.imgCombo8.TabIndex = 427;
            this.imgCombo8.TabStop = false;
            // 
            // imgCombo7
            // 
            this.imgCombo7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo7.Location = new System.Drawing.Point(850, 204);
            this.imgCombo7.Name = "imgCombo7";
            this.imgCombo7.Size = new System.Drawing.Size(114, 77);
            this.imgCombo7.TabIndex = 426;
            this.imgCombo7.TabStop = false;
            // 
            // txtPrecoCombo6
            // 
            this.txtPrecoCombo6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCombo6.Location = new System.Drawing.Point(1105, 121);
            this.txtPrecoCombo6.Name = "txtPrecoCombo6";
            this.txtPrecoCombo6.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoCombo6.TabIndex = 425;
            // 
            // txtCustoCombo6
            // 
            this.txtCustoCombo6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCombo6.Location = new System.Drawing.Point(995, 121);
            this.txtCustoCombo6.Name = "txtCustoCombo6";
            this.txtCustoCombo6.Size = new System.Drawing.Size(82, 30);
            this.txtCustoCombo6.TabIndex = 424;
            // 
            // imgCombo6
            // 
            this.imgCombo6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo6.Location = new System.Drawing.Point(850, 121);
            this.imgCombo6.Name = "imgCombo6";
            this.imgCombo6.Size = new System.Drawing.Size(114, 77);
            this.imgCombo6.TabIndex = 423;
            this.imgCombo6.TabStop = false;
            // 
            // lblCombos2
            // 
            this.lblCombos2.AutoSize = true;
            this.lblCombos2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombos2.Location = new System.Drawing.Point(712, 81);
            this.lblCombos2.Name = "lblCombos2";
            this.lblCombos2.Size = new System.Drawing.Size(78, 24);
            this.lblCombos2.TabIndex = 422;
            this.lblCombos2.Text = "Combos";
            // 
            // lblPrecoCombos2
            // 
            this.lblPrecoCombos2.AutoSize = true;
            this.lblPrecoCombos2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCombos2.Location = new System.Drawing.Point(1099, 81);
            this.lblPrecoCombos2.Name = "lblPrecoCombos2";
            this.lblPrecoCombos2.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoCombos2.TabIndex = 421;
            this.lblPrecoCombos2.Text = "Preço ($)";
            // 
            // lblCustoCombos2
            // 
            this.lblCustoCombos2.AutoSize = true;
            this.lblCustoCombos2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoCombos2.Location = new System.Drawing.Point(989, 81);
            this.lblCustoCombos2.Name = "lblCustoCombos2";
            this.lblCustoCombos2.Size = new System.Drawing.Size(86, 24);
            this.lblCustoCombos2.TabIndex = 420;
            this.lblCustoCombos2.Text = "Custo ($)";
            // 
            // lblImagemCombos2
            // 
            this.lblImagemCombos2.AutoSize = true;
            this.lblImagemCombos2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemCombos2.Location = new System.Drawing.Point(868, 81);
            this.lblImagemCombos2.Name = "lblImagemCombos2";
            this.lblImagemCombos2.Size = new System.Drawing.Size(77, 24);
            this.lblImagemCombos2.TabIndex = 419;
            this.lblImagemCombos2.Text = "Imagem";
            // 
            // imgCombo4
            // 
            this.imgCombo4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo4.Location = new System.Drawing.Point(243, 370);
            this.imgCombo4.Name = "imgCombo4";
            this.imgCombo4.Size = new System.Drawing.Size(114, 77);
            this.imgCombo4.TabIndex = 418;
            this.imgCombo4.TabStop = false;
            // 
            // imgCombo3
            // 
            this.imgCombo3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo3.Location = new System.Drawing.Point(243, 287);
            this.imgCombo3.Name = "imgCombo3";
            this.imgCombo3.Size = new System.Drawing.Size(114, 77);
            this.imgCombo3.TabIndex = 417;
            this.imgCombo3.TabStop = false;
            // 
            // imgCombo2
            // 
            this.imgCombo2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo2.Location = new System.Drawing.Point(243, 204);
            this.imgCombo2.Name = "imgCombo2";
            this.imgCombo2.Size = new System.Drawing.Size(114, 77);
            this.imgCombo2.TabIndex = 416;
            this.imgCombo2.TabStop = false;
            // 
            // lblCombos1
            // 
            this.lblCombos1.AutoSize = true;
            this.lblCombos1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombos1.Location = new System.Drawing.Point(113, 81);
            this.lblCombos1.Name = "lblCombos1";
            this.lblCombos1.Size = new System.Drawing.Size(78, 24);
            this.lblCombos1.TabIndex = 415;
            this.lblCombos1.Text = "Combos";
            // 
            // lblPrecoCombos1
            // 
            this.lblPrecoCombos1.AutoSize = true;
            this.lblPrecoCombos1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCombos1.Location = new System.Drawing.Point(494, 81);
            this.lblPrecoCombos1.Name = "lblPrecoCombos1";
            this.lblPrecoCombos1.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoCombos1.TabIndex = 414;
            this.lblPrecoCombos1.Text = "Preço ($)";
            // 
            // txtPrecoCombo1
            // 
            this.txtPrecoCombo1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCombo1.Location = new System.Drawing.Point(498, 121);
            this.txtPrecoCombo1.Name = "txtPrecoCombo1";
            this.txtPrecoCombo1.Size = new System.Drawing.Size(78, 30);
            this.txtPrecoCombo1.TabIndex = 413;
            // 
            // lblCustoCombos1
            // 
            this.lblCustoCombos1.AutoSize = true;
            this.lblCustoCombos1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoCombos1.Location = new System.Drawing.Point(384, 81);
            this.lblCustoCombos1.Name = "lblCustoCombos1";
            this.lblCustoCombos1.Size = new System.Drawing.Size(86, 24);
            this.lblCustoCombos1.TabIndex = 412;
            this.lblCustoCombos1.Text = "Custo ($)";
            // 
            // txtCustoCombo1
            // 
            this.txtCustoCombo1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoCombo1.Location = new System.Drawing.Point(388, 121);
            this.txtCustoCombo1.Name = "txtCustoCombo1";
            this.txtCustoCombo1.Size = new System.Drawing.Size(82, 30);
            this.txtCustoCombo1.TabIndex = 411;
            // 
            // lblImagemCombos1
            // 
            this.lblImagemCombos1.AutoSize = true;
            this.lblImagemCombos1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemCombos1.Location = new System.Drawing.Point(263, 81);
            this.lblImagemCombos1.Name = "lblImagemCombos1";
            this.lblImagemCombos1.Size = new System.Drawing.Size(77, 24);
            this.lblImagemCombos1.TabIndex = 410;
            this.lblImagemCombos1.Text = "Imagem";
            // 
            // imgCombo1
            // 
            this.imgCombo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCombo1.Location = new System.Drawing.Point(243, 121);
            this.imgCombo1.Name = "imgCombo1";
            this.imgCombo1.Size = new System.Drawing.Size(114, 77);
            this.imgCombo1.TabIndex = 409;
            this.imgCombo1.TabStop = false;
            // 
            // lblCombo8
            // 
            this.lblCombo8.AutoSize = true;
            this.lblCombo8.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo8.Location = new System.Drawing.Point(636, 285);
            this.lblCombo8.Name = "lblCombo8";
            this.lblCombo8.Size = new System.Drawing.Size(19, 24);
            this.lblCombo8.TabIndex = 408;
            this.lblCombo8.Text = "8";
            // 
            // txtCombo8
            // 
            this.txtCombo8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo8.Location = new System.Drawing.Point(661, 285);
            this.txtCombo8.Name = "txtCombo8";
            this.txtCombo8.Size = new System.Drawing.Size(168, 30);
            this.txtCombo8.TabIndex = 407;
            // 
            // lblCombo4
            // 
            this.lblCombo4.AutoSize = true;
            this.lblCombo4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo4.Location = new System.Drawing.Point(29, 370);
            this.lblCombo4.Name = "lblCombo4";
            this.lblCombo4.Size = new System.Drawing.Size(19, 24);
            this.lblCombo4.TabIndex = 406;
            this.lblCombo4.Text = "4";
            // 
            // txtCombo4
            // 
            this.txtCombo4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo4.Location = new System.Drawing.Point(54, 370);
            this.txtCombo4.Name = "txtCombo4";
            this.txtCombo4.Size = new System.Drawing.Size(168, 30);
            this.txtCombo4.TabIndex = 405;
            // 
            // lblCombo7
            // 
            this.lblCombo7.AutoSize = true;
            this.lblCombo7.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo7.Location = new System.Drawing.Point(636, 208);
            this.lblCombo7.Name = "lblCombo7";
            this.lblCombo7.Size = new System.Drawing.Size(19, 24);
            this.lblCombo7.TabIndex = 404;
            this.lblCombo7.Text = "7";
            // 
            // txtCombo7
            // 
            this.txtCombo7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo7.Location = new System.Drawing.Point(661, 208);
            this.txtCombo7.Name = "txtCombo7";
            this.txtCombo7.Size = new System.Drawing.Size(168, 30);
            this.txtCombo7.TabIndex = 403;
            // 
            // lblCombo3
            // 
            this.lblCombo3.AutoSize = true;
            this.lblCombo3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo3.Location = new System.Drawing.Point(29, 288);
            this.lblCombo3.Name = "lblCombo3";
            this.lblCombo3.Size = new System.Drawing.Size(19, 24);
            this.lblCombo3.TabIndex = 402;
            this.lblCombo3.Text = "3";
            // 
            // txtCombo3
            // 
            this.txtCombo3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo3.Location = new System.Drawing.Point(54, 288);
            this.txtCombo3.Name = "txtCombo3";
            this.txtCombo3.Size = new System.Drawing.Size(168, 30);
            this.txtCombo3.TabIndex = 401;
            // 
            // lblCombo6
            // 
            this.lblCombo6.AutoSize = true;
            this.lblCombo6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo6.Location = new System.Drawing.Point(636, 121);
            this.lblCombo6.Name = "lblCombo6";
            this.lblCombo6.Size = new System.Drawing.Size(19, 24);
            this.lblCombo6.TabIndex = 400;
            this.lblCombo6.Text = "6";
            // 
            // txtCombo6
            // 
            this.txtCombo6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo6.Location = new System.Drawing.Point(661, 121);
            this.txtCombo6.Name = "txtCombo6";
            this.txtCombo6.Size = new System.Drawing.Size(168, 30);
            this.txtCombo6.TabIndex = 399;
            // 
            // lblCombo2
            // 
            this.lblCombo2.AutoSize = true;
            this.lblCombo2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo2.Location = new System.Drawing.Point(29, 204);
            this.lblCombo2.Name = "lblCombo2";
            this.lblCombo2.Size = new System.Drawing.Size(19, 24);
            this.lblCombo2.TabIndex = 398;
            this.lblCombo2.Text = "2";
            // 
            // txtCombo2
            // 
            this.txtCombo2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo2.Location = new System.Drawing.Point(54, 204);
            this.txtCombo2.Name = "txtCombo2";
            this.txtCombo2.Size = new System.Drawing.Size(168, 30);
            this.txtCombo2.TabIndex = 397;
            // 
            // btnSalvarCadastroCombos
            // 
            this.btnSalvarCadastroCombos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroCombos.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSalvarCadastroCombos.Location = new System.Drawing.Point(993, 549);
            this.btnSalvarCadastroCombos.Name = "btnSalvarCadastroCombos";
            this.btnSalvarCadastroCombos.Size = new System.Drawing.Size(167, 55);
            this.btnSalvarCadastroCombos.TabIndex = 396;
            this.btnSalvarCadastroCombos.Text = "Salvar";
            this.btnSalvarCadastroCombos.UseVisualStyleBackColor = false;
            // 
            // lblCombo1
            // 
            this.lblCombo1.AutoSize = true;
            this.lblCombo1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo1.Location = new System.Drawing.Point(29, 121);
            this.lblCombo1.Name = "lblCombo1";
            this.lblCombo1.Size = new System.Drawing.Size(19, 24);
            this.lblCombo1.TabIndex = 395;
            this.lblCombo1.Text = "1";
            // 
            // txtCombo1
            // 
            this.txtCombo1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo1.Location = new System.Drawing.Point(54, 121);
            this.txtCombo1.Name = "txtCombo1";
            this.txtCombo1.Size = new System.Drawing.Size(168, 30);
            this.txtCombo1.TabIndex = 394;
            // 
            // lblTituloCadastroCombos
            // 
            this.lblTituloCadastroCombos.AutoSize = true;
            this.lblTituloCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroCombos.Location = new System.Drawing.Point(492, 23);
            this.lblTituloCadastroCombos.Name = "lblTituloCadastroCombos";
            this.lblTituloCadastroCombos.Size = new System.Drawing.Size(235, 31);
            this.lblTituloCadastroCombos.TabIndex = 393;
            this.lblTituloCadastroCombos.Text = "Cadastro de Combos";
            // 
            // clItensCombo1
            // 
            this.clItensCombo1.FormattingEnabled = true;
            this.clItensCombo1.Location = new System.Drawing.Point(54, 148);
            this.clItensCombo1.Name = "clItensCombo1";
            this.clItensCombo1.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo1.TabIndex = 454;
            // 
            // clItensCombo2
            // 
            this.clItensCombo2.FormattingEnabled = true;
            this.clItensCombo2.Location = new System.Drawing.Point(54, 231);
            this.clItensCombo2.Name = "clItensCombo2";
            this.clItensCombo2.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo2.TabIndex = 455;
            // 
            // clItensCombo3
            // 
            this.clItensCombo3.FormattingEnabled = true;
            this.clItensCombo3.Location = new System.Drawing.Point(54, 314);
            this.clItensCombo3.Name = "clItensCombo3";
            this.clItensCombo3.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo3.TabIndex = 456;
            // 
            // clItensCombo4
            // 
            this.clItensCombo4.FormattingEnabled = true;
            this.clItensCombo4.Location = new System.Drawing.Point(54, 397);
            this.clItensCombo4.Name = "clItensCombo4";
            this.clItensCombo4.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo4.TabIndex = 457;
            // 
            // clItensCombo6
            // 
            this.clItensCombo6.FormattingEnabled = true;
            this.clItensCombo6.Location = new System.Drawing.Point(661, 148);
            this.clItensCombo6.Name = "clItensCombo6";
            this.clItensCombo6.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo6.TabIndex = 458;
            // 
            // clItensCombo7
            // 
            this.clItensCombo7.FormattingEnabled = true;
            this.clItensCombo7.Location = new System.Drawing.Point(661, 235);
            this.clItensCombo7.Name = "clItensCombo7";
            this.clItensCombo7.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo7.TabIndex = 459;
            // 
            // clItensCombo8
            // 
            this.clItensCombo8.FormattingEnabled = true;
            this.clItensCombo8.Location = new System.Drawing.Point(661, 314);
            this.clItensCombo8.Name = "clItensCombo8";
            this.clItensCombo8.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo8.TabIndex = 460;
            // 
            // clItensCombo9
            // 
            this.clItensCombo9.FormattingEnabled = true;
            this.clItensCombo9.Location = new System.Drawing.Point(661, 397);
            this.clItensCombo9.Name = "clItensCombo9";
            this.clItensCombo9.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo9.TabIndex = 461;
            // 
            // clItensCombo5
            // 
            this.clItensCombo5.FormattingEnabled = true;
            this.clItensCombo5.Location = new System.Drawing.Point(54, 480);
            this.clItensCombo5.Name = "clItensCombo5";
            this.clItensCombo5.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo5.TabIndex = 462;
            // 
            // clItensCombo10
            // 
            this.clItensCombo10.FormattingEnabled = true;
            this.clItensCombo10.Location = new System.Drawing.Point(661, 480);
            this.clItensCombo10.Name = "clItensCombo10";
            this.clItensCombo10.Size = new System.Drawing.Size(168, 38);
            this.clItensCombo10.TabIndex = 463;
            // 
            // CadastroCombos
            // 
            this.ClientSize = new System.Drawing.Size(1215, 618);
            this.Controls.Add(this.clItensCombo10);
            this.Controls.Add(this.clItensCombo5);
            this.Controls.Add(this.clItensCombo9);
            this.Controls.Add(this.clItensCombo8);
            this.Controls.Add(this.clItensCombo7);
            this.Controls.Add(this.clItensCombo6);
            this.Controls.Add(this.clItensCombo4);
            this.Controls.Add(this.clItensCombo3);
            this.Controls.Add(this.clItensCombo2);
            this.Controls.Add(this.clItensCombo1);
            this.Controls.Add(this.lblCombo9);
            this.Controls.Add(this.txtCombo9);
            this.Controls.Add(this.txtPrecoCombo9);
            this.Controls.Add(this.txtCustoCombo9);
            this.Controls.Add(this.txtPrecoCombo8);
            this.Controls.Add(this.txtCustoCombo8);
            this.Controls.Add(this.txtPrecoCombo7);
            this.Controls.Add(this.txtCustoCombo7);
            this.Controls.Add(this.txtPrecoCombo10);
            this.Controls.Add(this.txtCustoCombo10);
            this.Controls.Add(this.imgCombo10);
            this.Controls.Add(this.lblCombo10);
            this.Controls.Add(this.txtCombo10);
            this.Controls.Add(this.txtPrecoCombo4);
            this.Controls.Add(this.txtCustoCombo4);
            this.Controls.Add(this.txtPrecoCombo3);
            this.Controls.Add(this.txtCustoCombo3);
            this.Controls.Add(this.txtPrecoCombo2);
            this.Controls.Add(this.txtCustoCombo2);
            this.Controls.Add(this.txtPrecoCombo5);
            this.Controls.Add(this.txtCustoCombo5);
            this.Controls.Add(this.imgCombo5);
            this.Controls.Add(this.lblCombo5);
            this.Controls.Add(this.txtCombo5);
            this.Controls.Add(this.imgCombo9);
            this.Controls.Add(this.imgCombo8);
            this.Controls.Add(this.imgCombo7);
            this.Controls.Add(this.txtPrecoCombo6);
            this.Controls.Add(this.txtCustoCombo6);
            this.Controls.Add(this.imgCombo6);
            this.Controls.Add(this.lblCombos2);
            this.Controls.Add(this.lblPrecoCombos2);
            this.Controls.Add(this.lblCustoCombos2);
            this.Controls.Add(this.lblImagemCombos2);
            this.Controls.Add(this.imgCombo4);
            this.Controls.Add(this.imgCombo3);
            this.Controls.Add(this.imgCombo2);
            this.Controls.Add(this.lblCombos1);
            this.Controls.Add(this.lblPrecoCombos1);
            this.Controls.Add(this.txtPrecoCombo1);
            this.Controls.Add(this.lblCustoCombos1);
            this.Controls.Add(this.txtCustoCombo1);
            this.Controls.Add(this.lblImagemCombos1);
            this.Controls.Add(this.imgCombo1);
            this.Controls.Add(this.lblCombo8);
            this.Controls.Add(this.txtCombo8);
            this.Controls.Add(this.lblCombo4);
            this.Controls.Add(this.txtCombo4);
            this.Controls.Add(this.lblCombo7);
            this.Controls.Add(this.txtCombo7);
            this.Controls.Add(this.lblCombo3);
            this.Controls.Add(this.txtCombo3);
            this.Controls.Add(this.lblCombo6);
            this.Controls.Add(this.txtCombo6);
            this.Controls.Add(this.lblCombo2);
            this.Controls.Add(this.txtCombo2);
            this.Controls.Add(this.btnSalvarCadastroCombos);
            this.Controls.Add(this.lblCombo1);
            this.Controls.Add(this.txtCombo1);
            this.Controls.Add(this.lblTituloCadastroCombos);
            this.Name = "CadastroCombos";
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
