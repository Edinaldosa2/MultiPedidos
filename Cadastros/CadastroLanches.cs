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
    public partial class CadastroLanches : Form
    {
        private Button buttonSalvarCadastroLanches;
        private ComboBox ddlTipoMolhoCadastroLanches;
        private Label lblTipoMolhoCadastroLanches;
        private Label lblItem1CadastroLanches;
        private Label lblTituloCadastroLanches;
        private Label lblNomeCadastroLanches;
        private Label lblItem5CadastroLanches;
        private Label lblItem6CadastroLanches;
        private Label lblItem2CadastroLanches;
        private Label lblItem8CadastroLanches;
        private Label lblItem4CadastroLanches;
        private Label lblItem7CadastroLanches;
        private Label lblItem3CadastroLanches;
        private Label lblImagemCadastroLanches;
        private Label lblPrecoCadastroLanches;
        private TextBox textPrecoCadastroLanches;
        private Label lblCustoCadastroLanches;
        private TextBox textCustoCadastroLanches;
        private Label lblObsCadastroLanches;
        private OpenFileDialog openFileDialogCadastroLanches;
        private Button btnUploadImagemCadastroLanches;
        private TextBox txtObsCadastroLanches;
        private Label lblItem10CadastroLanches;
        private Label lblItem9CadastroLanches;
        private ComboBox ddlItem5CadastroLanches;
        private ComboBox ddlItem4CadastroLanches;
        private ComboBox ddlItem3CadastroLanches;
        private ComboBox ddlItem2CadastroLanches;
        private ComboBox ddlItem1CadastroLanches;
        private ComboBox ddlItem10CadastroLanches;
        private ComboBox ddlItem9CadastroLanches;
        private ComboBox ddlItem8CadastroLanches;
        private ComboBox ddlItem7CadastroLanches;
        private ComboBox ddlItem6CadastroLanches;
        private TextBox txtNomeCadastroLanches;

        public CadastroLanches()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.buttonSalvarCadastroLanches = new System.Windows.Forms.Button();
            this.ddlTipoMolhoCadastroLanches = new System.Windows.Forms.ComboBox();
            this.lblTipoMolhoCadastroLanches = new System.Windows.Forms.Label();
            this.lblItem1CadastroLanches = new System.Windows.Forms.Label();
            this.lblTituloCadastroLanches = new System.Windows.Forms.Label();
            this.lblNomeCadastroLanches = new System.Windows.Forms.Label();
            this.txtNomeCadastroLanches = new System.Windows.Forms.TextBox();
            this.lblItem5CadastroLanches = new System.Windows.Forms.Label();
            this.lblItem6CadastroLanches = new System.Windows.Forms.Label();
            this.lblItem2CadastroLanches = new System.Windows.Forms.Label();
            this.lblItem8CadastroLanches = new System.Windows.Forms.Label();
            this.lblItem4CadastroLanches = new System.Windows.Forms.Label();
            this.lblItem7CadastroLanches = new System.Windows.Forms.Label();
            this.lblItem3CadastroLanches = new System.Windows.Forms.Label();
            this.lblImagemCadastroLanches = new System.Windows.Forms.Label();
            this.lblPrecoCadastroLanches = new System.Windows.Forms.Label();
            this.textPrecoCadastroLanches = new System.Windows.Forms.TextBox();
            this.lblCustoCadastroLanches = new System.Windows.Forms.Label();
            this.textCustoCadastroLanches = new System.Windows.Forms.TextBox();
            this.lblObsCadastroLanches = new System.Windows.Forms.Label();
            this.openFileDialogCadastroLanches = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadImagemCadastroLanches = new System.Windows.Forms.Button();
            this.txtObsCadastroLanches = new System.Windows.Forms.TextBox();
            this.lblItem10CadastroLanches = new System.Windows.Forms.Label();
            this.lblItem9CadastroLanches = new System.Windows.Forms.Label();
            this.ddlItem5CadastroLanches = new System.Windows.Forms.ComboBox();
            this.ddlItem4CadastroLanches = new System.Windows.Forms.ComboBox();
            this.ddlItem3CadastroLanches = new System.Windows.Forms.ComboBox();
            this.ddlItem2CadastroLanches = new System.Windows.Forms.ComboBox();
            this.ddlItem1CadastroLanches = new System.Windows.Forms.ComboBox();
            this.ddlItem10CadastroLanches = new System.Windows.Forms.ComboBox();
            this.ddlItem9CadastroLanches = new System.Windows.Forms.ComboBox();
            this.ddlItem8CadastroLanches = new System.Windows.Forms.ComboBox();
            this.ddlItem7CadastroLanches = new System.Windows.Forms.ComboBox();
            this.ddlItem6CadastroLanches = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSalvarCadastroLanches
            // 
            this.buttonSalvarCadastroLanches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSalvarCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroLanches.ForeColor = System.Drawing.Color.Chartreuse;
            this.buttonSalvarCadastroLanches.Location = new System.Drawing.Point(697, 512);
            this.buttonSalvarCadastroLanches.Name = "buttonSalvarCadastroLanches";
            this.buttonSalvarCadastroLanches.Size = new System.Drawing.Size(167, 55);
            this.buttonSalvarCadastroLanches.TabIndex = 62;
            this.buttonSalvarCadastroLanches.Text = "Salvar";
            this.buttonSalvarCadastroLanches.UseVisualStyleBackColor = false;
            // 
            // ddlTipoMolhoCadastroLanches
            // 
            this.ddlTipoMolhoCadastroLanches.FormattingEnabled = true;
            this.ddlTipoMolhoCadastroLanches.Location = new System.Drawing.Point(159, 329);
            this.ddlTipoMolhoCadastroLanches.Name = "ddlTipoMolhoCadastroLanches";
            this.ddlTipoMolhoCadastroLanches.Size = new System.Drawing.Size(121, 24);
            this.ddlTipoMolhoCadastroLanches.TabIndex = 41;
            // 
            // lblTipoMolhoCadastroLanches
            // 
            this.lblTipoMolhoCadastroLanches.AutoSize = true;
            this.lblTipoMolhoCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMolhoCadastroLanches.Location = new System.Drawing.Point(9, 326);
            this.lblTipoMolhoCadastroLanches.Name = "lblTipoMolhoCadastroLanches";
            this.lblTipoMolhoCadastroLanches.Size = new System.Drawing.Size(135, 24);
            this.lblTipoMolhoCadastroLanches.TabIndex = 38;
            this.lblTipoMolhoCadastroLanches.Text = "Tipo de Molho";
            // 
            // lblItem1CadastroLanches
            // 
            this.lblItem1CadastroLanches.AutoSize = true;
            this.lblItem1CadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem1CadastroLanches.Location = new System.Drawing.Point(20, 142);
            this.lblItem1CadastroLanches.Name = "lblItem1CadastroLanches";
            this.lblItem1CadastroLanches.Size = new System.Drawing.Size(124, 24);
            this.lblItem1CadastroLanches.TabIndex = 37;
            this.lblItem1CadastroLanches.Text = "Ingrediente 1";
            // 
            // lblTituloCadastroLanches
            // 
            this.lblTituloCadastroLanches.AutoSize = true;
            this.lblTituloCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroLanches.Location = new System.Drawing.Point(345, 22);
            this.lblTituloCadastroLanches.Name = "lblTituloCadastroLanches";
            this.lblTituloCadastroLanches.Size = new System.Drawing.Size(233, 31);
            this.lblTituloCadastroLanches.TabIndex = 35;
            this.lblTituloCadastroLanches.Text = "Cadastro de Lanches";
            // 
            // lblNomeCadastroLanches
            // 
            this.lblNomeCadastroLanches.AutoSize = true;
            this.lblNomeCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadastroLanches.Location = new System.Drawing.Point(84, 104);
            this.lblNomeCadastroLanches.Name = "lblNomeCadastroLanches";
            this.lblNomeCadastroLanches.Size = new System.Drawing.Size(60, 24);
            this.lblNomeCadastroLanches.TabIndex = 34;
            this.lblNomeCadastroLanches.Text = "Nome";
            // 
            // txtNomeCadastroLanches
            // 
            this.txtNomeCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCadastroLanches.Location = new System.Drawing.Point(159, 104);
            this.txtNomeCadastroLanches.Name = "txtNomeCadastroLanches";
            this.txtNomeCadastroLanches.Size = new System.Drawing.Size(705, 30);
            this.txtNomeCadastroLanches.TabIndex = 33;
            // 
            // lblItem5CadastroLanches
            // 
            this.lblItem5CadastroLanches.AutoSize = true;
            this.lblItem5CadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem5CadastroLanches.Location = new System.Drawing.Point(20, 286);
            this.lblItem5CadastroLanches.Name = "lblItem5CadastroLanches";
            this.lblItem5CadastroLanches.Size = new System.Drawing.Size(124, 24);
            this.lblItem5CadastroLanches.TabIndex = 66;
            this.lblItem5CadastroLanches.Text = "Ingrediente 5";
            // 
            // lblItem6CadastroLanches
            // 
            this.lblItem6CadastroLanches.AutoSize = true;
            this.lblItem6CadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem6CadastroLanches.Location = new System.Drawing.Point(488, 146);
            this.lblItem6CadastroLanches.Name = "lblItem6CadastroLanches";
            this.lblItem6CadastroLanches.Size = new System.Drawing.Size(124, 24);
            this.lblItem6CadastroLanches.TabIndex = 70;
            this.lblItem6CadastroLanches.Text = "Ingrediente 6";
            // 
            // lblItem2CadastroLanches
            // 
            this.lblItem2CadastroLanches.AutoSize = true;
            this.lblItem2CadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem2CadastroLanches.Location = new System.Drawing.Point(20, 178);
            this.lblItem2CadastroLanches.Name = "lblItem2CadastroLanches";
            this.lblItem2CadastroLanches.Size = new System.Drawing.Size(124, 24);
            this.lblItem2CadastroLanches.TabIndex = 68;
            this.lblItem2CadastroLanches.Text = "Ingrediente 2";
            // 
            // lblItem8CadastroLanches
            // 
            this.lblItem8CadastroLanches.AutoSize = true;
            this.lblItem8CadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem8CadastroLanches.Location = new System.Drawing.Point(488, 218);
            this.lblItem8CadastroLanches.Name = "lblItem8CadastroLanches";
            this.lblItem8CadastroLanches.Size = new System.Drawing.Size(124, 24);
            this.lblItem8CadastroLanches.TabIndex = 78;
            this.lblItem8CadastroLanches.Text = "Ingrediente 8";
            // 
            // lblItem4CadastroLanches
            // 
            this.lblItem4CadastroLanches.AutoSize = true;
            this.lblItem4CadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem4CadastroLanches.Location = new System.Drawing.Point(20, 250);
            this.lblItem4CadastroLanches.Name = "lblItem4CadastroLanches";
            this.lblItem4CadastroLanches.Size = new System.Drawing.Size(124, 24);
            this.lblItem4CadastroLanches.TabIndex = 76;
            this.lblItem4CadastroLanches.Text = "Ingrediente 4";
            // 
            // lblItem7CadastroLanches
            // 
            this.lblItem7CadastroLanches.AutoSize = true;
            this.lblItem7CadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem7CadastroLanches.Location = new System.Drawing.Point(488, 182);
            this.lblItem7CadastroLanches.Name = "lblItem7CadastroLanches";
            this.lblItem7CadastroLanches.Size = new System.Drawing.Size(124, 24);
            this.lblItem7CadastroLanches.TabIndex = 74;
            this.lblItem7CadastroLanches.Text = "Ingrediente 7";
            // 
            // lblItem3CadastroLanches
            // 
            this.lblItem3CadastroLanches.AutoSize = true;
            this.lblItem3CadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem3CadastroLanches.Location = new System.Drawing.Point(20, 214);
            this.lblItem3CadastroLanches.Name = "lblItem3CadastroLanches";
            this.lblItem3CadastroLanches.Size = new System.Drawing.Size(124, 24);
            this.lblItem3CadastroLanches.TabIndex = 72;
            this.lblItem3CadastroLanches.Text = "Ingrediente 3";
            // 
            // lblImagemCadastroLanches
            // 
            this.lblImagemCadastroLanches.AutoSize = true;
            this.lblImagemCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemCadastroLanches.Location = new System.Drawing.Point(67, 441);
            this.lblImagemCadastroLanches.Name = "lblImagemCadastroLanches";
            this.lblImagemCadastroLanches.Size = new System.Drawing.Size(77, 24);
            this.lblImagemCadastroLanches.TabIndex = 80;
            this.lblImagemCadastroLanches.Text = "Imagem";
            // 
            // lblPrecoCadastroLanches
            // 
            this.lblPrecoCadastroLanches.AutoSize = true;
            this.lblPrecoCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCadastroLanches.Location = new System.Drawing.Point(645, 437);
            this.lblPrecoCadastroLanches.Name = "lblPrecoCadastroLanches";
            this.lblPrecoCadastroLanches.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoCadastroLanches.TabIndex = 84;
            this.lblPrecoCadastroLanches.Text = "Preço ($)";
            // 
            // textPrecoCadastroLanches
            // 
            this.textPrecoCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecoCadastroLanches.Location = new System.Drawing.Point(744, 432);
            this.textPrecoCadastroLanches.Name = "textPrecoCadastroLanches";
            this.textPrecoCadastroLanches.Size = new System.Drawing.Size(120, 30);
            this.textPrecoCadastroLanches.TabIndex = 83;
            // 
            // lblCustoCadastroLanches
            // 
            this.lblCustoCadastroLanches.AutoSize = true;
            this.lblCustoCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoCadastroLanches.Location = new System.Drawing.Point(363, 437);
            this.lblCustoCadastroLanches.Name = "lblCustoCadastroLanches";
            this.lblCustoCadastroLanches.Size = new System.Drawing.Size(86, 24);
            this.lblCustoCadastroLanches.TabIndex = 82;
            this.lblCustoCadastroLanches.Text = "Custo ($)";
            // 
            // textCustoCadastroLanches
            // 
            this.textCustoCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCustoCadastroLanches.Location = new System.Drawing.Point(460, 435);
            this.textCustoCadastroLanches.Name = "textCustoCadastroLanches";
            this.textCustoCadastroLanches.Size = new System.Drawing.Size(118, 30);
            this.textCustoCadastroLanches.TabIndex = 81;
            // 
            // lblObsCadastroLanches
            // 
            this.lblObsCadastroLanches.AutoSize = true;
            this.lblObsCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsCadastroLanches.Location = new System.Drawing.Point(96, 374);
            this.lblObsCadastroLanches.Name = "lblObsCadastroLanches";
            this.lblObsCadastroLanches.Size = new System.Drawing.Size(48, 24);
            this.lblObsCadastroLanches.TabIndex = 85;
            this.lblObsCadastroLanches.Text = "OBS";
            // 
            // openFileDialogCadastroLanches
            // 
            this.openFileDialogCadastroLanches.FileName = "openFileDialogCadastroLanches";
            // 
            // btnUploadImagemCadastroLanches
            // 
            this.btnUploadImagemCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImagemCadastroLanches.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUploadImagemCadastroLanches.Location = new System.Drawing.Point(159, 438);
            this.btnUploadImagemCadastroLanches.Name = "btnUploadImagemCadastroLanches";
            this.btnUploadImagemCadastroLanches.Size = new System.Drawing.Size(127, 30);
            this.btnUploadImagemCadastroLanches.TabIndex = 334;
            this.btnUploadImagemCadastroLanches.Text = "Upload";
            this.btnUploadImagemCadastroLanches.UseVisualStyleBackColor = true;
            this.btnUploadImagemCadastroLanches.Click += new System.EventHandler(this.btnUploadImagemCadastroLanches_Click);
            // 
            // txtObsCadastroLanches
            // 
            this.txtObsCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsCadastroLanches.Location = new System.Drawing.Point(159, 372);
            this.txtObsCadastroLanches.Name = "txtObsCadastroLanches";
            this.txtObsCadastroLanches.Size = new System.Drawing.Size(705, 30);
            this.txtObsCadastroLanches.TabIndex = 335;
            // 
            // lblItem10CadastroLanches
            // 
            this.lblItem10CadastroLanches.AutoSize = true;
            this.lblItem10CadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem10CadastroLanches.Location = new System.Drawing.Point(488, 292);
            this.lblItem10CadastroLanches.Name = "lblItem10CadastroLanches";
            this.lblItem10CadastroLanches.Size = new System.Drawing.Size(133, 24);
            this.lblItem10CadastroLanches.TabIndex = 339;
            this.lblItem10CadastroLanches.Text = "Ingrediente 10";
            // 
            // lblItem9CadastroLanches
            // 
            this.lblItem9CadastroLanches.AutoSize = true;
            this.lblItem9CadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem9CadastroLanches.Location = new System.Drawing.Point(488, 256);
            this.lblItem9CadastroLanches.Name = "lblItem9CadastroLanches";
            this.lblItem9CadastroLanches.Size = new System.Drawing.Size(124, 24);
            this.lblItem9CadastroLanches.TabIndex = 337;
            this.lblItem9CadastroLanches.Text = "Ingrediente 9";
            // 
            // ddlItem5CadastroLanches
            // 
            this.ddlItem5CadastroLanches.FormattingEnabled = true;
            this.ddlItem5CadastroLanches.Location = new System.Drawing.Point(159, 289);
            this.ddlItem5CadastroLanches.Name = "ddlItem5CadastroLanches";
            this.ddlItem5CadastroLanches.Size = new System.Drawing.Size(225, 24);
            this.ddlItem5CadastroLanches.TabIndex = 383;
            // 
            // ddlItem4CadastroLanches
            // 
            this.ddlItem4CadastroLanches.FormattingEnabled = true;
            this.ddlItem4CadastroLanches.Location = new System.Drawing.Point(159, 250);
            this.ddlItem4CadastroLanches.Name = "ddlItem4CadastroLanches";
            this.ddlItem4CadastroLanches.Size = new System.Drawing.Size(225, 24);
            this.ddlItem4CadastroLanches.TabIndex = 382;
            // 
            // ddlItem3CadastroLanches
            // 
            this.ddlItem3CadastroLanches.FormattingEnabled = true;
            this.ddlItem3CadastroLanches.Location = new System.Drawing.Point(159, 214);
            this.ddlItem3CadastroLanches.Name = "ddlItem3CadastroLanches";
            this.ddlItem3CadastroLanches.Size = new System.Drawing.Size(225, 24);
            this.ddlItem3CadastroLanches.TabIndex = 381;
            // 
            // ddlItem2CadastroLanches
            // 
            this.ddlItem2CadastroLanches.FormattingEnabled = true;
            this.ddlItem2CadastroLanches.Location = new System.Drawing.Point(159, 178);
            this.ddlItem2CadastroLanches.Name = "ddlItem2CadastroLanches";
            this.ddlItem2CadastroLanches.Size = new System.Drawing.Size(225, 24);
            this.ddlItem2CadastroLanches.TabIndex = 380;
            // 
            // ddlItem1CadastroLanches
            // 
            this.ddlItem1CadastroLanches.FormattingEnabled = true;
            this.ddlItem1CadastroLanches.Location = new System.Drawing.Point(159, 142);
            this.ddlItem1CadastroLanches.Name = "ddlItem1CadastroLanches";
            this.ddlItem1CadastroLanches.Size = new System.Drawing.Size(225, 24);
            this.ddlItem1CadastroLanches.TabIndex = 379;
            // 
            // ddlItem10CadastroLanches
            // 
            this.ddlItem10CadastroLanches.FormattingEnabled = true;
            this.ddlItem10CadastroLanches.Location = new System.Drawing.Point(639, 292);
            this.ddlItem10CadastroLanches.Name = "ddlItem10CadastroLanches";
            this.ddlItem10CadastroLanches.Size = new System.Drawing.Size(225, 24);
            this.ddlItem10CadastroLanches.TabIndex = 388;
            // 
            // ddlItem9CadastroLanches
            // 
            this.ddlItem9CadastroLanches.FormattingEnabled = true;
            this.ddlItem9CadastroLanches.Location = new System.Drawing.Point(639, 253);
            this.ddlItem9CadastroLanches.Name = "ddlItem9CadastroLanches";
            this.ddlItem9CadastroLanches.Size = new System.Drawing.Size(225, 24);
            this.ddlItem9CadastroLanches.TabIndex = 387;
            // 
            // ddlItem8CadastroLanches
            // 
            this.ddlItem8CadastroLanches.FormattingEnabled = true;
            this.ddlItem8CadastroLanches.Location = new System.Drawing.Point(639, 217);
            this.ddlItem8CadastroLanches.Name = "ddlItem8CadastroLanches";
            this.ddlItem8CadastroLanches.Size = new System.Drawing.Size(225, 24);
            this.ddlItem8CadastroLanches.TabIndex = 386;
            // 
            // ddlItem7CadastroLanches
            // 
            this.ddlItem7CadastroLanches.FormattingEnabled = true;
            this.ddlItem7CadastroLanches.Location = new System.Drawing.Point(639, 181);
            this.ddlItem7CadastroLanches.Name = "ddlItem7CadastroLanches";
            this.ddlItem7CadastroLanches.Size = new System.Drawing.Size(225, 24);
            this.ddlItem7CadastroLanches.TabIndex = 385;
            // 
            // ddlItem6CadastroLanches
            // 
            this.ddlItem6CadastroLanches.FormattingEnabled = true;
            this.ddlItem6CadastroLanches.Location = new System.Drawing.Point(639, 145);
            this.ddlItem6CadastroLanches.Name = "ddlItem6CadastroLanches";
            this.ddlItem6CadastroLanches.Size = new System.Drawing.Size(225, 24);
            this.ddlItem6CadastroLanches.TabIndex = 384;
            // 
            // CadastroLanches
            // 
            this.ClientSize = new System.Drawing.Size(905, 595);
            this.Controls.Add(this.ddlItem10CadastroLanches);
            this.Controls.Add(this.ddlItem9CadastroLanches);
            this.Controls.Add(this.ddlItem8CadastroLanches);
            this.Controls.Add(this.ddlItem7CadastroLanches);
            this.Controls.Add(this.ddlItem6CadastroLanches);
            this.Controls.Add(this.ddlItem5CadastroLanches);
            this.Controls.Add(this.ddlItem4CadastroLanches);
            this.Controls.Add(this.ddlItem3CadastroLanches);
            this.Controls.Add(this.ddlItem2CadastroLanches);
            this.Controls.Add(this.ddlItem1CadastroLanches);
            this.Controls.Add(this.lblItem10CadastroLanches);
            this.Controls.Add(this.lblItem9CadastroLanches);
            this.Controls.Add(this.txtObsCadastroLanches);
            this.Controls.Add(this.btnUploadImagemCadastroLanches);
            this.Controls.Add(this.lblObsCadastroLanches);
            this.Controls.Add(this.lblPrecoCadastroLanches);
            this.Controls.Add(this.textPrecoCadastroLanches);
            this.Controls.Add(this.lblCustoCadastroLanches);
            this.Controls.Add(this.textCustoCadastroLanches);
            this.Controls.Add(this.lblImagemCadastroLanches);
            this.Controls.Add(this.lblItem8CadastroLanches);
            this.Controls.Add(this.lblItem4CadastroLanches);
            this.Controls.Add(this.lblItem7CadastroLanches);
            this.Controls.Add(this.lblItem3CadastroLanches);
            this.Controls.Add(this.lblItem6CadastroLanches);
            this.Controls.Add(this.lblItem2CadastroLanches);
            this.Controls.Add(this.lblItem5CadastroLanches);
            this.Controls.Add(this.buttonSalvarCadastroLanches);
            this.Controls.Add(this.ddlTipoMolhoCadastroLanches);
            this.Controls.Add(this.lblTipoMolhoCadastroLanches);
            this.Controls.Add(this.lblItem1CadastroLanches);
            this.Controls.Add(this.lblTituloCadastroLanches);
            this.Controls.Add(this.lblNomeCadastroLanches);
            this.Controls.Add(this.txtNomeCadastroLanches);
            this.Name = "CadastroLanches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnUploadImagemCadastroLanches_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog properties
            openFileDialogCadastroLanches.InitialDirectory = "c:\\";
            openFileDialogCadastroLanches.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            openFileDialogCadastroLanches.FilterIndex = 1;
            openFileDialogCadastroLanches.RestoreDirectory = true;

            // Show the OpenFileDialog and process the selected file
            if (openFileDialogCadastroLanches.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileDialogCadastroLanches.FileName;

                // Do something with the file
                MessageBox.Show("File selected: " + filePath);

            }
        }

        
    }
}
