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
        private TextBox txtObsCadastroCombos;
        private Button btnUploadImagemCadastroCombos;
        private Label lblObsCadastroCombos;
        private Label lblPrecoCadastroCombos;
        private TextBox textPrecoCadastroCombos;
        private Label lblCustoCadastroCombos;
        private TextBox textCustoCadastroCombos;
        private Label lblImagemCadastroCombos;
        private Label lblItem8CadastroCombos;
        private Label lblItem4CadastroCombos;
        private Label lblItem7CadastroCombos;
        private Label lblItem3CadastroCombos;
        private Label lblItem6CadastroCombos;
        private Label lblItem2CadastroCombos;
        private Label lblItem5CadastroCombos;
        private Button buttonSalvarCadastroCombos;
        private Label lblItem1CadastroCombos;
        private Label lblTituloCadastroCombos;
        private Label lblNomeCadastroCombos;
        private ComboBox ddlItem1CadastroCombos;
        private ComboBox ddlItem2CadastroCombos;
        private ComboBox ddlItem3CadastroCombos;
        private ComboBox ddlItem4CadastroCombos;
        private Label lblQtdeItem1CadastroCombos;
        private ComboBox ddlQtdeItem1CadastroCombos;
        private ComboBox ddlQtdeItem2CadastroCombos;
        private Label lblQtdeItem2CadastroCombos;
        private ComboBox ddlQtdeItem3CadastroCombos;
        private Label lblQtdeItem3CadastroCombos;
        private ComboBox ddlQtdeItem4CadastroCombos;
        private Label lblQtdeItem4CadastroCombos;
        private ComboBox ddlItem8CadastroCombos;
        private ComboBox ddlItem7CadastroCombos;
        private ComboBox ddlItem6CadastroCombos;
        private ComboBox ddlItem5CadastroCombos;
        private ComboBox ddlQtdeItem8CadastroCombos;
        private Label lblQtdeItem8CadastroCombos;
        private ComboBox ddlQtdeItem7CadastroCombos;
        private Label lblQtdeItem7CadastroCombos;
        private ComboBox ddlQtdeItem6CadastroCombos;
        private Label lblQtdeItem6CadastroCombos;
        private ComboBox ddlQtdeItem5CadastroCombos;
        private Label lblQtdeItem5CadastroCombos;
        private OpenFileDialog openFileCadastroCombos;
        private ComboBox ddlQtdeItem9CadastroCombos;
        private Label lblQtdeItem9CadastroCombos;
        private ComboBox ddlItem9CadastroCombos;
        private Label lblItem9CadastroCombos;
        private ComboBox ddlQtdeItem10CadastroCombos;
        private Label lblQtdeItem10CadastroCombos;
        private ComboBox ddlItem10CadastroCombos;
        private Label lblItem10CadastroCombos;
        private TextBox txtNomeCadastroLanches;

        public CadastroCombos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtObsCadastroCombos = new System.Windows.Forms.TextBox();
            this.btnUploadImagemCadastroCombos = new System.Windows.Forms.Button();
            this.lblObsCadastroCombos = new System.Windows.Forms.Label();
            this.lblPrecoCadastroCombos = new System.Windows.Forms.Label();
            this.textPrecoCadastroCombos = new System.Windows.Forms.TextBox();
            this.lblCustoCadastroCombos = new System.Windows.Forms.Label();
            this.textCustoCadastroCombos = new System.Windows.Forms.TextBox();
            this.lblImagemCadastroCombos = new System.Windows.Forms.Label();
            this.lblItem8CadastroCombos = new System.Windows.Forms.Label();
            this.lblItem4CadastroCombos = new System.Windows.Forms.Label();
            this.lblItem7CadastroCombos = new System.Windows.Forms.Label();
            this.lblItem3CadastroCombos = new System.Windows.Forms.Label();
            this.lblItem6CadastroCombos = new System.Windows.Forms.Label();
            this.lblItem2CadastroCombos = new System.Windows.Forms.Label();
            this.lblItem5CadastroCombos = new System.Windows.Forms.Label();
            this.buttonSalvarCadastroCombos = new System.Windows.Forms.Button();
            this.lblItem1CadastroCombos = new System.Windows.Forms.Label();
            this.lblTituloCadastroCombos = new System.Windows.Forms.Label();
            this.lblNomeCadastroCombos = new System.Windows.Forms.Label();
            this.txtNomeCadastroLanches = new System.Windows.Forms.TextBox();
            this.ddlItem1CadastroCombos = new System.Windows.Forms.ComboBox();
            this.ddlItem2CadastroCombos = new System.Windows.Forms.ComboBox();
            this.ddlItem3CadastroCombos = new System.Windows.Forms.ComboBox();
            this.ddlItem4CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblQtdeItem1CadastroCombos = new System.Windows.Forms.Label();
            this.ddlQtdeItem1CadastroCombos = new System.Windows.Forms.ComboBox();
            this.ddlQtdeItem2CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblQtdeItem2CadastroCombos = new System.Windows.Forms.Label();
            this.ddlQtdeItem3CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblQtdeItem3CadastroCombos = new System.Windows.Forms.Label();
            this.ddlQtdeItem4CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblQtdeItem4CadastroCombos = new System.Windows.Forms.Label();
            this.ddlItem8CadastroCombos = new System.Windows.Forms.ComboBox();
            this.ddlItem7CadastroCombos = new System.Windows.Forms.ComboBox();
            this.ddlItem6CadastroCombos = new System.Windows.Forms.ComboBox();
            this.ddlItem5CadastroCombos = new System.Windows.Forms.ComboBox();
            this.ddlQtdeItem8CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblQtdeItem8CadastroCombos = new System.Windows.Forms.Label();
            this.ddlQtdeItem7CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblQtdeItem7CadastroCombos = new System.Windows.Forms.Label();
            this.ddlQtdeItem6CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblQtdeItem6CadastroCombos = new System.Windows.Forms.Label();
            this.ddlQtdeItem5CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblQtdeItem5CadastroCombos = new System.Windows.Forms.Label();
            this.openFileCadastroCombos = new System.Windows.Forms.OpenFileDialog();
            this.ddlQtdeItem9CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblQtdeItem9CadastroCombos = new System.Windows.Forms.Label();
            this.ddlItem9CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblItem9CadastroCombos = new System.Windows.Forms.Label();
            this.ddlQtdeItem10CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblQtdeItem10CadastroCombos = new System.Windows.Forms.Label();
            this.ddlItem10CadastroCombos = new System.Windows.Forms.ComboBox();
            this.lblItem10CadastroCombos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtObsCadastroCombos
            // 
            this.txtObsCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsCadastroCombos.Location = new System.Drawing.Point(83, 313);
            this.txtObsCadastroCombos.Name = "txtObsCadastroCombos";
            this.txtObsCadastroCombos.Size = new System.Drawing.Size(960, 30);
            this.txtObsCadastroCombos.TabIndex = 365;
            // 
            // btnUploadImagemCadastroCombos
            // 
            this.btnUploadImagemCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroCombos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroCombos.Location = new System.Drawing.Point(256, 373);
            this.btnUploadImagemCadastroCombos.Name = "btnUploadImagemCadastroCombos";
            this.btnUploadImagemCadastroCombos.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroCombos.TabIndex = 364;
            this.btnUploadImagemCadastroCombos.Text = "Upload";
            this.btnUploadImagemCadastroCombos.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroCombos.Click += new System.EventHandler(this.btnUploadImagemCadastroCombos_Click);
            // 
            // lblObsCadastroCombos
            // 
            this.lblObsCadastroCombos.AutoSize = true;
            this.lblObsCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsCadastroCombos.Location = new System.Drawing.Point(28, 315);
            this.lblObsCadastroCombos.Name = "lblObsCadastroCombos";
            this.lblObsCadastroCombos.Size = new System.Drawing.Size(48, 24);
            this.lblObsCadastroCombos.TabIndex = 363;
            this.lblObsCadastroCombos.Text = "OBS";
            // 
            // lblPrecoCadastroCombos
            // 
            this.lblPrecoCadastroCombos.AutoSize = true;
            this.lblPrecoCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCadastroCombos.Location = new System.Drawing.Point(662, 379);
            this.lblPrecoCadastroCombos.Name = "lblPrecoCadastroCombos";
            this.lblPrecoCadastroCombos.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoCadastroCombos.TabIndex = 362;
            this.lblPrecoCadastroCombos.Text = "Preço ($)";
            // 
            // textPrecoCadastroCombos
            // 
            this.textPrecoCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecoCadastroCombos.Location = new System.Drawing.Point(760, 377);
            this.textPrecoCadastroCombos.Name = "textPrecoCadastroCombos";
            this.textPrecoCadastroCombos.Size = new System.Drawing.Size(121, 30);
            this.textPrecoCadastroCombos.TabIndex = 361;
            // 
            // lblCustoCadastroCombos
            // 
            this.lblCustoCadastroCombos.AutoSize = true;
            this.lblCustoCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoCadastroCombos.Location = new System.Drawing.Point(414, 379);
            this.lblCustoCadastroCombos.Name = "lblCustoCadastroCombos";
            this.lblCustoCadastroCombos.Size = new System.Drawing.Size(86, 24);
            this.lblCustoCadastroCombos.TabIndex = 360;
            this.lblCustoCadastroCombos.Text = "Custo ($)";
            // 
            // textCustoCadastroCombos
            // 
            this.textCustoCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCustoCadastroCombos.Location = new System.Drawing.Point(516, 377);
            this.textCustoCadastroCombos.Name = "textCustoCadastroCombos";
            this.textCustoCadastroCombos.Size = new System.Drawing.Size(121, 30);
            this.textCustoCadastroCombos.TabIndex = 359;
            // 
            // lblImagemCadastroCombos
            // 
            this.lblImagemCadastroCombos.AutoSize = true;
            this.lblImagemCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemCadastroCombos.Location = new System.Drawing.Point(164, 376);
            this.lblImagemCadastroCombos.Name = "lblImagemCadastroCombos";
            this.lblImagemCadastroCombos.Size = new System.Drawing.Size(77, 24);
            this.lblImagemCadastroCombos.TabIndex = 358;
            this.lblImagemCadastroCombos.Text = "Imagem";
            // 
            // lblItem8CadastroCombos
            // 
            this.lblItem8CadastroCombos.AutoSize = true;
            this.lblItem8CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem8CadastroCombos.Location = new System.Drawing.Point(548, 189);
            this.lblItem8CadastroCombos.Name = "lblItem8CadastroCombos";
            this.lblItem8CadastroCombos.Size = new System.Drawing.Size(63, 24);
            this.lblItem8CadastroCombos.TabIndex = 357;
            this.lblItem8CadastroCombos.Text = "Item 8";
            // 
            // lblItem4CadastroCombos
            // 
            this.lblItem4CadastroCombos.AutoSize = true;
            this.lblItem4CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem4CadastroCombos.Location = new System.Drawing.Point(13, 222);
            this.lblItem4CadastroCombos.Name = "lblItem4CadastroCombos";
            this.lblItem4CadastroCombos.Size = new System.Drawing.Size(63, 24);
            this.lblItem4CadastroCombos.TabIndex = 355;
            this.lblItem4CadastroCombos.Text = "Item 4";
            // 
            // lblItem7CadastroCombos
            // 
            this.lblItem7CadastroCombos.AutoSize = true;
            this.lblItem7CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem7CadastroCombos.Location = new System.Drawing.Point(548, 153);
            this.lblItem7CadastroCombos.Name = "lblItem7CadastroCombos";
            this.lblItem7CadastroCombos.Size = new System.Drawing.Size(63, 24);
            this.lblItem7CadastroCombos.TabIndex = 353;
            this.lblItem7CadastroCombos.Text = "Item 7";
            // 
            // lblItem3CadastroCombos
            // 
            this.lblItem3CadastroCombos.AutoSize = true;
            this.lblItem3CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem3CadastroCombos.Location = new System.Drawing.Point(13, 186);
            this.lblItem3CadastroCombos.Name = "lblItem3CadastroCombos";
            this.lblItem3CadastroCombos.Size = new System.Drawing.Size(63, 24);
            this.lblItem3CadastroCombos.TabIndex = 351;
            this.lblItem3CadastroCombos.Text = "Item 3";
            // 
            // lblItem6CadastroCombos
            // 
            this.lblItem6CadastroCombos.AutoSize = true;
            this.lblItem6CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem6CadastroCombos.Location = new System.Drawing.Point(548, 117);
            this.lblItem6CadastroCombos.Name = "lblItem6CadastroCombos";
            this.lblItem6CadastroCombos.Size = new System.Drawing.Size(63, 24);
            this.lblItem6CadastroCombos.TabIndex = 349;
            this.lblItem6CadastroCombos.Text = "Item 6";
            // 
            // lblItem2CadastroCombos
            // 
            this.lblItem2CadastroCombos.AutoSize = true;
            this.lblItem2CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem2CadastroCombos.Location = new System.Drawing.Point(13, 150);
            this.lblItem2CadastroCombos.Name = "lblItem2CadastroCombos";
            this.lblItem2CadastroCombos.Size = new System.Drawing.Size(63, 24);
            this.lblItem2CadastroCombos.TabIndex = 347;
            this.lblItem2CadastroCombos.Text = "Item 2";
            // 
            // lblItem5CadastroCombos
            // 
            this.lblItem5CadastroCombos.AutoSize = true;
            this.lblItem5CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem5CadastroCombos.Location = new System.Drawing.Point(13, 261);
            this.lblItem5CadastroCombos.Name = "lblItem5CadastroCombos";
            this.lblItem5CadastroCombos.Size = new System.Drawing.Size(63, 24);
            this.lblItem5CadastroCombos.TabIndex = 345;
            this.lblItem5CadastroCombos.Text = "Item 5";
            // 
            // buttonSalvarCadastroCombos
            // 
            this.buttonSalvarCadastroCombos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSalvarCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroCombos.ForeColor = System.Drawing.Color.Chartreuse;
            this.buttonSalvarCadastroCombos.Location = new System.Drawing.Point(876, 470);
            this.buttonSalvarCadastroCombos.Name = "buttonSalvarCadastroCombos";
            this.buttonSalvarCadastroCombos.Size = new System.Drawing.Size(167, 55);
            this.buttonSalvarCadastroCombos.TabIndex = 343;
            this.buttonSalvarCadastroCombos.Text = "Salvar";
            this.buttonSalvarCadastroCombos.UseVisualStyleBackColor = false;
            // 
            // lblItem1CadastroCombos
            // 
            this.lblItem1CadastroCombos.AutoSize = true;
            this.lblItem1CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem1CadastroCombos.Location = new System.Drawing.Point(13, 114);
            this.lblItem1CadastroCombos.Name = "lblItem1CadastroCombos";
            this.lblItem1CadastroCombos.Size = new System.Drawing.Size(63, 24);
            this.lblItem1CadastroCombos.TabIndex = 340;
            this.lblItem1CadastroCombos.Text = "Item 1";
            // 
            // lblTituloCadastroCombos
            // 
            this.lblTituloCadastroCombos.AutoSize = true;
            this.lblTituloCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroCombos.Location = new System.Drawing.Point(394, 23);
            this.lblTituloCadastroCombos.Name = "lblTituloCadastroCombos";
            this.lblTituloCadastroCombos.Size = new System.Drawing.Size(235, 31);
            this.lblTituloCadastroCombos.TabIndex = 338;
            this.lblTituloCadastroCombos.Text = "Cadastro de Combos";
            // 
            // lblNomeCadastroCombos
            // 
            this.lblNomeCadastroCombos.AutoSize = true;
            this.lblNomeCadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadastroCombos.Location = new System.Drawing.Point(16, 78);
            this.lblNomeCadastroCombos.Name = "lblNomeCadastroCombos";
            this.lblNomeCadastroCombos.Size = new System.Drawing.Size(60, 24);
            this.lblNomeCadastroCombos.TabIndex = 337;
            this.lblNomeCadastroCombos.Text = "Nome";
            // 
            // txtNomeCadastroLanches
            // 
            this.txtNomeCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCadastroLanches.Location = new System.Drawing.Point(91, 78);
            this.txtNomeCadastroLanches.Name = "txtNomeCadastroLanches";
            this.txtNomeCadastroLanches.Size = new System.Drawing.Size(952, 30);
            this.txtNomeCadastroLanches.TabIndex = 336;
            // 
            // ddlItem1CadastroCombos
            // 
            this.ddlItem1CadastroCombos.FormattingEnabled = true;
            this.ddlItem1CadastroCombos.Location = new System.Drawing.Point(91, 117);
            this.ddlItem1CadastroCombos.Name = "ddlItem1CadastroCombos";
            this.ddlItem1CadastroCombos.Size = new System.Drawing.Size(225, 24);
            this.ddlItem1CadastroCombos.TabIndex = 366;
            // 
            // ddlItem2CadastroCombos
            // 
            this.ddlItem2CadastroCombos.FormattingEnabled = true;
            this.ddlItem2CadastroCombos.Location = new System.Drawing.Point(91, 153);
            this.ddlItem2CadastroCombos.Name = "ddlItem2CadastroCombos";
            this.ddlItem2CadastroCombos.Size = new System.Drawing.Size(225, 24);
            this.ddlItem2CadastroCombos.TabIndex = 367;
            // 
            // ddlItem3CadastroCombos
            // 
            this.ddlItem3CadastroCombos.FormattingEnabled = true;
            this.ddlItem3CadastroCombos.Location = new System.Drawing.Point(91, 189);
            this.ddlItem3CadastroCombos.Name = "ddlItem3CadastroCombos";
            this.ddlItem3CadastroCombos.Size = new System.Drawing.Size(225, 24);
            this.ddlItem3CadastroCombos.TabIndex = 368;
            // 
            // ddlItem4CadastroCombos
            // 
            this.ddlItem4CadastroCombos.FormattingEnabled = true;
            this.ddlItem4CadastroCombos.Location = new System.Drawing.Point(91, 225);
            this.ddlItem4CadastroCombos.Name = "ddlItem4CadastroCombos";
            this.ddlItem4CadastroCombos.Size = new System.Drawing.Size(225, 24);
            this.ddlItem4CadastroCombos.TabIndex = 369;
            // 
            // lblQtdeItem1CadastroCombos
            // 
            this.lblQtdeItem1CadastroCombos.AutoSize = true;
            this.lblQtdeItem1CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem1CadastroCombos.Location = new System.Drawing.Point(331, 117);
            this.lblQtdeItem1CadastroCombos.Name = "lblQtdeItem1CadastroCombos";
            this.lblQtdeItem1CadastroCombos.Size = new System.Drawing.Size(52, 24);
            this.lblQtdeItem1CadastroCombos.TabIndex = 370;
            this.lblQtdeItem1CadastroCombos.Text = "Qtde";
            // 
            // ddlQtdeItem1CadastroCombos
            // 
            this.ddlQtdeItem1CadastroCombos.FormattingEnabled = true;
            this.ddlQtdeItem1CadastroCombos.Location = new System.Drawing.Point(389, 117);
            this.ddlQtdeItem1CadastroCombos.Name = "ddlQtdeItem1CadastroCombos";
            this.ddlQtdeItem1CadastroCombos.Size = new System.Drawing.Size(121, 24);
            this.ddlQtdeItem1CadastroCombos.TabIndex = 371;
            // 
            // ddlQtdeItem2CadastroCombos
            // 
            this.ddlQtdeItem2CadastroCombos.FormattingEnabled = true;
            this.ddlQtdeItem2CadastroCombos.Location = new System.Drawing.Point(389, 153);
            this.ddlQtdeItem2CadastroCombos.Name = "ddlQtdeItem2CadastroCombos";
            this.ddlQtdeItem2CadastroCombos.Size = new System.Drawing.Size(121, 24);
            this.ddlQtdeItem2CadastroCombos.TabIndex = 373;
            // 
            // lblQtdeItem2CadastroCombos
            // 
            this.lblQtdeItem2CadastroCombos.AutoSize = true;
            this.lblQtdeItem2CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem2CadastroCombos.Location = new System.Drawing.Point(331, 153);
            this.lblQtdeItem2CadastroCombos.Name = "lblQtdeItem2CadastroCombos";
            this.lblQtdeItem2CadastroCombos.Size = new System.Drawing.Size(52, 24);
            this.lblQtdeItem2CadastroCombos.TabIndex = 372;
            this.lblQtdeItem2CadastroCombos.Text = "Qtde";
            // 
            // ddlQtdeItem3CadastroCombos
            // 
            this.ddlQtdeItem3CadastroCombos.FormattingEnabled = true;
            this.ddlQtdeItem3CadastroCombos.Location = new System.Drawing.Point(389, 189);
            this.ddlQtdeItem3CadastroCombos.Name = "ddlQtdeItem3CadastroCombos";
            this.ddlQtdeItem3CadastroCombos.Size = new System.Drawing.Size(121, 24);
            this.ddlQtdeItem3CadastroCombos.TabIndex = 375;
            // 
            // lblQtdeItem3CadastroCombos
            // 
            this.lblQtdeItem3CadastroCombos.AutoSize = true;
            this.lblQtdeItem3CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem3CadastroCombos.Location = new System.Drawing.Point(331, 189);
            this.lblQtdeItem3CadastroCombos.Name = "lblQtdeItem3CadastroCombos";
            this.lblQtdeItem3CadastroCombos.Size = new System.Drawing.Size(52, 24);
            this.lblQtdeItem3CadastroCombos.TabIndex = 374;
            this.lblQtdeItem3CadastroCombos.Text = "Qtde";
            // 
            // ddlQtdeItem4CadastroCombos
            // 
            this.ddlQtdeItem4CadastroCombos.FormattingEnabled = true;
            this.ddlQtdeItem4CadastroCombos.Location = new System.Drawing.Point(389, 228);
            this.ddlQtdeItem4CadastroCombos.Name = "ddlQtdeItem4CadastroCombos";
            this.ddlQtdeItem4CadastroCombos.Size = new System.Drawing.Size(121, 24);
            this.ddlQtdeItem4CadastroCombos.TabIndex = 377;
            // 
            // lblQtdeItem4CadastroCombos
            // 
            this.lblQtdeItem4CadastroCombos.AutoSize = true;
            this.lblQtdeItem4CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem4CadastroCombos.Location = new System.Drawing.Point(331, 228);
            this.lblQtdeItem4CadastroCombos.Name = "lblQtdeItem4CadastroCombos";
            this.lblQtdeItem4CadastroCombos.Size = new System.Drawing.Size(52, 24);
            this.lblQtdeItem4CadastroCombos.TabIndex = 376;
            this.lblQtdeItem4CadastroCombos.Text = "Qtde";
            // 
            // ddlItem8CadastroCombos
            // 
            this.ddlItem8CadastroCombos.FormattingEnabled = true;
            this.ddlItem8CadastroCombos.Location = new System.Drawing.Point(626, 192);
            this.ddlItem8CadastroCombos.Name = "ddlItem8CadastroCombos";
            this.ddlItem8CadastroCombos.Size = new System.Drawing.Size(225, 24);
            this.ddlItem8CadastroCombos.TabIndex = 381;
            // 
            // ddlItem7CadastroCombos
            // 
            this.ddlItem7CadastroCombos.FormattingEnabled = true;
            this.ddlItem7CadastroCombos.Location = new System.Drawing.Point(626, 156);
            this.ddlItem7CadastroCombos.Name = "ddlItem7CadastroCombos";
            this.ddlItem7CadastroCombos.Size = new System.Drawing.Size(225, 24);
            this.ddlItem7CadastroCombos.TabIndex = 380;
            // 
            // ddlItem6CadastroCombos
            // 
            this.ddlItem6CadastroCombos.FormattingEnabled = true;
            this.ddlItem6CadastroCombos.Location = new System.Drawing.Point(626, 120);
            this.ddlItem6CadastroCombos.Name = "ddlItem6CadastroCombos";
            this.ddlItem6CadastroCombos.Size = new System.Drawing.Size(225, 24);
            this.ddlItem6CadastroCombos.TabIndex = 379;
            // 
            // ddlItem5CadastroCombos
            // 
            this.ddlItem5CadastroCombos.FormattingEnabled = true;
            this.ddlItem5CadastroCombos.Location = new System.Drawing.Point(91, 264);
            this.ddlItem5CadastroCombos.Name = "ddlItem5CadastroCombos";
            this.ddlItem5CadastroCombos.Size = new System.Drawing.Size(225, 24);
            this.ddlItem5CadastroCombos.TabIndex = 378;
            // 
            // ddlQtdeItem8CadastroCombos
            // 
            this.ddlQtdeItem8CadastroCombos.FormattingEnabled = true;
            this.ddlQtdeItem8CadastroCombos.Location = new System.Drawing.Point(922, 189);
            this.ddlQtdeItem8CadastroCombos.Name = "ddlQtdeItem8CadastroCombos";
            this.ddlQtdeItem8CadastroCombos.Size = new System.Drawing.Size(121, 24);
            this.ddlQtdeItem8CadastroCombos.TabIndex = 389;
            // 
            // lblQtdeItem8CadastroCombos
            // 
            this.lblQtdeItem8CadastroCombos.AutoSize = true;
            this.lblQtdeItem8CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem8CadastroCombos.Location = new System.Drawing.Point(864, 189);
            this.lblQtdeItem8CadastroCombos.Name = "lblQtdeItem8CadastroCombos";
            this.lblQtdeItem8CadastroCombos.Size = new System.Drawing.Size(52, 24);
            this.lblQtdeItem8CadastroCombos.TabIndex = 388;
            this.lblQtdeItem8CadastroCombos.Text = "Qtde";
            // 
            // ddlQtdeItem7CadastroCombos
            // 
            this.ddlQtdeItem7CadastroCombos.FormattingEnabled = true;
            this.ddlQtdeItem7CadastroCombos.Location = new System.Drawing.Point(922, 150);
            this.ddlQtdeItem7CadastroCombos.Name = "ddlQtdeItem7CadastroCombos";
            this.ddlQtdeItem7CadastroCombos.Size = new System.Drawing.Size(121, 24);
            this.ddlQtdeItem7CadastroCombos.TabIndex = 387;
            // 
            // lblQtdeItem7CadastroCombos
            // 
            this.lblQtdeItem7CadastroCombos.AutoSize = true;
            this.lblQtdeItem7CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem7CadastroCombos.Location = new System.Drawing.Point(864, 150);
            this.lblQtdeItem7CadastroCombos.Name = "lblQtdeItem7CadastroCombos";
            this.lblQtdeItem7CadastroCombos.Size = new System.Drawing.Size(52, 24);
            this.lblQtdeItem7CadastroCombos.TabIndex = 386;
            this.lblQtdeItem7CadastroCombos.Text = "Qtde";
            // 
            // ddlQtdeItem6CadastroCombos
            // 
            this.ddlQtdeItem6CadastroCombos.FormattingEnabled = true;
            this.ddlQtdeItem6CadastroCombos.Location = new System.Drawing.Point(922, 114);
            this.ddlQtdeItem6CadastroCombos.Name = "ddlQtdeItem6CadastroCombos";
            this.ddlQtdeItem6CadastroCombos.Size = new System.Drawing.Size(121, 24);
            this.ddlQtdeItem6CadastroCombos.TabIndex = 385;
            // 
            // lblQtdeItem6CadastroCombos
            // 
            this.lblQtdeItem6CadastroCombos.AutoSize = true;
            this.lblQtdeItem6CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem6CadastroCombos.Location = new System.Drawing.Point(864, 114);
            this.lblQtdeItem6CadastroCombos.Name = "lblQtdeItem6CadastroCombos";
            this.lblQtdeItem6CadastroCombos.Size = new System.Drawing.Size(52, 24);
            this.lblQtdeItem6CadastroCombos.TabIndex = 384;
            this.lblQtdeItem6CadastroCombos.Text = "Qtde";
            // 
            // ddlQtdeItem5CadastroCombos
            // 
            this.ddlQtdeItem5CadastroCombos.FormattingEnabled = true;
            this.ddlQtdeItem5CadastroCombos.Location = new System.Drawing.Point(387, 258);
            this.ddlQtdeItem5CadastroCombos.Name = "ddlQtdeItem5CadastroCombos";
            this.ddlQtdeItem5CadastroCombos.Size = new System.Drawing.Size(121, 24);
            this.ddlQtdeItem5CadastroCombos.TabIndex = 383;
            // 
            // lblQtdeItem5CadastroCombos
            // 
            this.lblQtdeItem5CadastroCombos.AutoSize = true;
            this.lblQtdeItem5CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem5CadastroCombos.Location = new System.Drawing.Point(329, 258);
            this.lblQtdeItem5CadastroCombos.Name = "lblQtdeItem5CadastroCombos";
            this.lblQtdeItem5CadastroCombos.Size = new System.Drawing.Size(52, 24);
            this.lblQtdeItem5CadastroCombos.TabIndex = 382;
            this.lblQtdeItem5CadastroCombos.Text = "Qtde";
            // 
            // openFileCadastroCombos
            // 
            this.openFileCadastroCombos.FileName = "openFileCadastroCombos";
            // 
            // ddlQtdeItem9CadastroCombos
            // 
            this.ddlQtdeItem9CadastroCombos.FormattingEnabled = true;
            this.ddlQtdeItem9CadastroCombos.Location = new System.Drawing.Point(922, 225);
            this.ddlQtdeItem9CadastroCombos.Name = "ddlQtdeItem9CadastroCombos";
            this.ddlQtdeItem9CadastroCombos.Size = new System.Drawing.Size(121, 24);
            this.ddlQtdeItem9CadastroCombos.TabIndex = 393;
            // 
            // lblQtdeItem9CadastroCombos
            // 
            this.lblQtdeItem9CadastroCombos.AutoSize = true;
            this.lblQtdeItem9CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem9CadastroCombos.Location = new System.Drawing.Point(864, 225);
            this.lblQtdeItem9CadastroCombos.Name = "lblQtdeItem9CadastroCombos";
            this.lblQtdeItem9CadastroCombos.Size = new System.Drawing.Size(52, 24);
            this.lblQtdeItem9CadastroCombos.TabIndex = 392;
            this.lblQtdeItem9CadastroCombos.Text = "Qtde";
            // 
            // ddlItem9CadastroCombos
            // 
            this.ddlItem9CadastroCombos.FormattingEnabled = true;
            this.ddlItem9CadastroCombos.Location = new System.Drawing.Point(626, 228);
            this.ddlItem9CadastroCombos.Name = "ddlItem9CadastroCombos";
            this.ddlItem9CadastroCombos.Size = new System.Drawing.Size(225, 24);
            this.ddlItem9CadastroCombos.TabIndex = 391;
            // 
            // lblItem9CadastroCombos
            // 
            this.lblItem9CadastroCombos.AutoSize = true;
            this.lblItem9CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem9CadastroCombos.Location = new System.Drawing.Point(548, 225);
            this.lblItem9CadastroCombos.Name = "lblItem9CadastroCombos";
            this.lblItem9CadastroCombos.Size = new System.Drawing.Size(63, 24);
            this.lblItem9CadastroCombos.TabIndex = 390;
            this.lblItem9CadastroCombos.Text = "Item 9";
            // 
            // ddlQtdeItem10CadastroCombos
            // 
            this.ddlQtdeItem10CadastroCombos.FormattingEnabled = true;
            this.ddlQtdeItem10CadastroCombos.Location = new System.Drawing.Point(922, 261);
            this.ddlQtdeItem10CadastroCombos.Name = "ddlQtdeItem10CadastroCombos";
            this.ddlQtdeItem10CadastroCombos.Size = new System.Drawing.Size(121, 24);
            this.ddlQtdeItem10CadastroCombos.TabIndex = 397;
            // 
            // lblQtdeItem10CadastroCombos
            // 
            this.lblQtdeItem10CadastroCombos.AutoSize = true;
            this.lblQtdeItem10CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItem10CadastroCombos.Location = new System.Drawing.Point(864, 261);
            this.lblQtdeItem10CadastroCombos.Name = "lblQtdeItem10CadastroCombos";
            this.lblQtdeItem10CadastroCombos.Size = new System.Drawing.Size(52, 24);
            this.lblQtdeItem10CadastroCombos.TabIndex = 396;
            this.lblQtdeItem10CadastroCombos.Text = "Qtde";
            // 
            // ddlItem10CadastroCombos
            // 
            this.ddlItem10CadastroCombos.FormattingEnabled = true;
            this.ddlItem10CadastroCombos.Location = new System.Drawing.Point(626, 264);
            this.ddlItem10CadastroCombos.Name = "ddlItem10CadastroCombos";
            this.ddlItem10CadastroCombos.Size = new System.Drawing.Size(225, 24);
            this.ddlItem10CadastroCombos.TabIndex = 395;
            // 
            // lblItem10CadastroCombos
            // 
            this.lblItem10CadastroCombos.AutoSize = true;
            this.lblItem10CadastroCombos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem10CadastroCombos.Location = new System.Drawing.Point(548, 261);
            this.lblItem10CadastroCombos.Name = "lblItem10CadastroCombos";
            this.lblItem10CadastroCombos.Size = new System.Drawing.Size(72, 24);
            this.lblItem10CadastroCombos.TabIndex = 394;
            this.lblItem10CadastroCombos.Text = "Item 10";
            // 
            // CadastroCombos
            // 
            this.ClientSize = new System.Drawing.Size(1068, 532);
            this.Controls.Add(this.ddlQtdeItem10CadastroCombos);
            this.Controls.Add(this.lblQtdeItem10CadastroCombos);
            this.Controls.Add(this.ddlItem10CadastroCombos);
            this.Controls.Add(this.lblItem10CadastroCombos);
            this.Controls.Add(this.ddlQtdeItem9CadastroCombos);
            this.Controls.Add(this.lblQtdeItem9CadastroCombos);
            this.Controls.Add(this.ddlItem9CadastroCombos);
            this.Controls.Add(this.lblItem9CadastroCombos);
            this.Controls.Add(this.ddlQtdeItem8CadastroCombos);
            this.Controls.Add(this.lblQtdeItem8CadastroCombos);
            this.Controls.Add(this.ddlQtdeItem7CadastroCombos);
            this.Controls.Add(this.lblQtdeItem7CadastroCombos);
            this.Controls.Add(this.ddlQtdeItem6CadastroCombos);
            this.Controls.Add(this.lblQtdeItem6CadastroCombos);
            this.Controls.Add(this.ddlQtdeItem5CadastroCombos);
            this.Controls.Add(this.lblQtdeItem5CadastroCombos);
            this.Controls.Add(this.ddlItem8CadastroCombos);
            this.Controls.Add(this.ddlItem7CadastroCombos);
            this.Controls.Add(this.ddlItem6CadastroCombos);
            this.Controls.Add(this.ddlItem5CadastroCombos);
            this.Controls.Add(this.ddlQtdeItem4CadastroCombos);
            this.Controls.Add(this.lblQtdeItem4CadastroCombos);
            this.Controls.Add(this.ddlQtdeItem3CadastroCombos);
            this.Controls.Add(this.lblQtdeItem3CadastroCombos);
            this.Controls.Add(this.ddlQtdeItem2CadastroCombos);
            this.Controls.Add(this.lblQtdeItem2CadastroCombos);
            this.Controls.Add(this.ddlQtdeItem1CadastroCombos);
            this.Controls.Add(this.lblQtdeItem1CadastroCombos);
            this.Controls.Add(this.ddlItem4CadastroCombos);
            this.Controls.Add(this.ddlItem3CadastroCombos);
            this.Controls.Add(this.ddlItem2CadastroCombos);
            this.Controls.Add(this.ddlItem1CadastroCombos);
            this.Controls.Add(this.txtObsCadastroCombos);
            this.Controls.Add(this.btnUploadImagemCadastroCombos);
            this.Controls.Add(this.lblObsCadastroCombos);
            this.Controls.Add(this.lblPrecoCadastroCombos);
            this.Controls.Add(this.textPrecoCadastroCombos);
            this.Controls.Add(this.lblCustoCadastroCombos);
            this.Controls.Add(this.textCustoCadastroCombos);
            this.Controls.Add(this.lblImagemCadastroCombos);
            this.Controls.Add(this.lblItem8CadastroCombos);
            this.Controls.Add(this.lblItem4CadastroCombos);
            this.Controls.Add(this.lblItem7CadastroCombos);
            this.Controls.Add(this.lblItem3CadastroCombos);
            this.Controls.Add(this.lblItem6CadastroCombos);
            this.Controls.Add(this.lblItem2CadastroCombos);
            this.Controls.Add(this.lblItem5CadastroCombos);
            this.Controls.Add(this.buttonSalvarCadastroCombos);
            this.Controls.Add(this.lblItem1CadastroCombos);
            this.Controls.Add(this.lblTituloCadastroCombos);
            this.Controls.Add(this.lblNomeCadastroCombos);
            this.Controls.Add(this.txtNomeCadastroLanches);
            this.Name = "CadastroCombos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnUploadImagemCadastroCombos_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileCadastroCombos.InitialDirectory = "c:\\";
            openFileCadastroCombos.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileCadastroCombos.FilterIndex = 1;
            openFileCadastroCombos.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileCadastroCombos.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileCadastroCombos.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }
    }
}
