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
        private Button buttonSalvarCadastroCliente;
        private ComboBox ddlTipoMolho;
        private Label lblTipoMolho;
        private Label lblIngrediente1;
        private TextBox txtIngrediente1;
        private Label lblTituloCadastroLanches;
        private Label lblNomeLanche;
        private Label lblIngrediente5;
        private TextBox txtIngrediente5;
        private Label lblIngrediente6;
        private TextBox txtIngrediente6;
        private Label lblIngrediente2;
        private TextBox txtIngrediente2;
        private Label lblIngrediente8;
        private TextBox txtIngrediente8;
        private Label lblIngrediente4;
        private TextBox txtIngrediente4;
        private Label lblIngrediente7;
        private TextBox txtIngrediente7;
        private Label lblIngrediente3;
        private TextBox txtIngrediente3;
        private PictureBox pictureBoxCadastroLanches;
        private Label lblFotoLanche;
        private Label lblPrecoLanche;
        private TextBox textBox1;
        private Label lblCustoLanche;
        private TextBox textBox2;
        private TextBox txtNomeLanche;

        public CadastroLanches()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.buttonSalvarCadastroCliente = new System.Windows.Forms.Button();
            this.ddlTipoMolho = new System.Windows.Forms.ComboBox();
            this.lblTipoMolho = new System.Windows.Forms.Label();
            this.lblIngrediente1 = new System.Windows.Forms.Label();
            this.txtIngrediente1 = new System.Windows.Forms.TextBox();
            this.lblTituloCadastroLanches = new System.Windows.Forms.Label();
            this.lblNomeLanche = new System.Windows.Forms.Label();
            this.txtNomeLanche = new System.Windows.Forms.TextBox();
            this.lblIngrediente5 = new System.Windows.Forms.Label();
            this.txtIngrediente5 = new System.Windows.Forms.TextBox();
            this.lblIngrediente6 = new System.Windows.Forms.Label();
            this.txtIngrediente6 = new System.Windows.Forms.TextBox();
            this.lblIngrediente2 = new System.Windows.Forms.Label();
            this.txtIngrediente2 = new System.Windows.Forms.TextBox();
            this.lblIngrediente8 = new System.Windows.Forms.Label();
            this.txtIngrediente8 = new System.Windows.Forms.TextBox();
            this.lblIngrediente4 = new System.Windows.Forms.Label();
            this.txtIngrediente4 = new System.Windows.Forms.TextBox();
            this.lblIngrediente7 = new System.Windows.Forms.Label();
            this.txtIngrediente7 = new System.Windows.Forms.TextBox();
            this.lblIngrediente3 = new System.Windows.Forms.Label();
            this.txtIngrediente3 = new System.Windows.Forms.TextBox();
            this.pictureBoxCadastroLanches = new System.Windows.Forms.PictureBox();
            this.lblFotoLanche = new System.Windows.Forms.Label();
            this.lblPrecoLanche = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCustoLanche = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroLanches)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvarCadastroCliente
            // 
            this.buttonSalvarCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSalvarCadastroCliente.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarCadastroCliente.ForeColor = System.Drawing.Color.Chartreuse;
            this.buttonSalvarCadastroCliente.Location = new System.Drawing.Point(763, 447);
            this.buttonSalvarCadastroCliente.Name = "buttonSalvarCadastroCliente";
            this.buttonSalvarCadastroCliente.Size = new System.Drawing.Size(167, 55);
            this.buttonSalvarCadastroCliente.TabIndex = 62;
            this.buttonSalvarCadastroCliente.Text = "Salvar";
            this.buttonSalvarCadastroCliente.UseVisualStyleBackColor = false;
            // 
            // ddlTipoMolho
            // 
            this.ddlTipoMolho.FormattingEnabled = true;
            this.ddlTipoMolho.Location = new System.Drawing.Point(225, 299);
            this.ddlTipoMolho.Name = "ddlTipoMolho";
            this.ddlTipoMolho.Size = new System.Drawing.Size(121, 24);
            this.ddlTipoMolho.TabIndex = 41;
            // 
            // lblTipoMolho
            // 
            this.lblTipoMolho.AutoSize = true;
            this.lblTipoMolho.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMolho.Location = new System.Drawing.Point(75, 296);
            this.lblTipoMolho.Name = "lblTipoMolho";
            this.lblTipoMolho.Size = new System.Drawing.Size(135, 24);
            this.lblTipoMolho.TabIndex = 38;
            this.lblTipoMolho.Text = "Tipo de Molho";
            // 
            // lblIngrediente1
            // 
            this.lblIngrediente1.AutoSize = true;
            this.lblIngrediente1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente1.Location = new System.Drawing.Point(86, 148);
            this.lblIngrediente1.Name = "lblIngrediente1";
            this.lblIngrediente1.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente1.TabIndex = 37;
            this.lblIngrediente1.Text = "Ingrediente 1";
            // 
            // txtIngrediente1
            // 
            this.txtIngrediente1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente1.Location = new System.Drawing.Point(225, 146);
            this.txtIngrediente1.Name = "txtIngrediente1";
            this.txtIngrediente1.Size = new System.Drawing.Size(258, 30);
            this.txtIngrediente1.TabIndex = 36;
            // 
            // lblTituloCadastroLanches
            // 
            this.lblTituloCadastroLanches.AutoSize = true;
            this.lblTituloCadastroLanches.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroLanches.Location = new System.Drawing.Point(400, 27);
            this.lblTituloCadastroLanches.Name = "lblTituloCadastroLanches";
            this.lblTituloCadastroLanches.Size = new System.Drawing.Size(233, 31);
            this.lblTituloCadastroLanches.TabIndex = 35;
            this.lblTituloCadastroLanches.Text = "Cadastro de Lanches";
            // 
            // lblNomeLanche
            // 
            this.lblNomeLanche.AutoSize = true;
            this.lblNomeLanche.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLanche.Location = new System.Drawing.Point(58, 116);
            this.lblNomeLanche.Name = "lblNomeLanche";
            this.lblNomeLanche.Size = new System.Drawing.Size(152, 24);
            this.lblNomeLanche.TabIndex = 34;
            this.lblNomeLanche.Text = "Nome do Lanche";
            // 
            // txtNomeLanche
            // 
            this.txtNomeLanche.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLanche.Location = new System.Drawing.Point(225, 110);
            this.txtNomeLanche.Name = "txtNomeLanche";
            this.txtNomeLanche.Size = new System.Drawing.Size(705, 30);
            this.txtNomeLanche.TabIndex = 33;
            // 
            // lblIngrediente5
            // 
            this.lblIngrediente5.AutoSize = true;
            this.lblIngrediente5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente5.Location = new System.Drawing.Point(533, 150);
            this.lblIngrediente5.Name = "lblIngrediente5";
            this.lblIngrediente5.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente5.TabIndex = 66;
            this.lblIngrediente5.Text = "Ingrediente 5";
            // 
            // txtIngrediente5
            // 
            this.txtIngrediente5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente5.Location = new System.Drawing.Point(672, 148);
            this.txtIngrediente5.Name = "txtIngrediente5";
            this.txtIngrediente5.Size = new System.Drawing.Size(258, 30);
            this.txtIngrediente5.TabIndex = 65;
            // 
            // lblIngrediente6
            // 
            this.lblIngrediente6.AutoSize = true;
            this.lblIngrediente6.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente6.Location = new System.Drawing.Point(533, 186);
            this.lblIngrediente6.Name = "lblIngrediente6";
            this.lblIngrediente6.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente6.TabIndex = 70;
            this.lblIngrediente6.Text = "Ingrediente 6";
            // 
            // txtIngrediente6
            // 
            this.txtIngrediente6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente6.Location = new System.Drawing.Point(672, 184);
            this.txtIngrediente6.Name = "txtIngrediente6";
            this.txtIngrediente6.Size = new System.Drawing.Size(258, 30);
            this.txtIngrediente6.TabIndex = 69;
            // 
            // lblIngrediente2
            // 
            this.lblIngrediente2.AutoSize = true;
            this.lblIngrediente2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente2.Location = new System.Drawing.Point(86, 184);
            this.lblIngrediente2.Name = "lblIngrediente2";
            this.lblIngrediente2.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente2.TabIndex = 68;
            this.lblIngrediente2.Text = "Ingrediente 2";
            // 
            // txtIngrediente2
            // 
            this.txtIngrediente2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente2.Location = new System.Drawing.Point(225, 182);
            this.txtIngrediente2.Name = "txtIngrediente2";
            this.txtIngrediente2.Size = new System.Drawing.Size(258, 30);
            this.txtIngrediente2.TabIndex = 67;
            // 
            // lblIngrediente8
            // 
            this.lblIngrediente8.AutoSize = true;
            this.lblIngrediente8.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente8.Location = new System.Drawing.Point(533, 258);
            this.lblIngrediente8.Name = "lblIngrediente8";
            this.lblIngrediente8.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente8.TabIndex = 78;
            this.lblIngrediente8.Text = "Ingrediente 8";
            // 
            // txtIngrediente8
            // 
            this.txtIngrediente8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente8.Location = new System.Drawing.Point(672, 256);
            this.txtIngrediente8.Name = "txtIngrediente8";
            this.txtIngrediente8.Size = new System.Drawing.Size(258, 30);
            this.txtIngrediente8.TabIndex = 77;
            // 
            // lblIngrediente4
            // 
            this.lblIngrediente4.AutoSize = true;
            this.lblIngrediente4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente4.Location = new System.Drawing.Point(86, 256);
            this.lblIngrediente4.Name = "lblIngrediente4";
            this.lblIngrediente4.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente4.TabIndex = 76;
            this.lblIngrediente4.Text = "Ingrediente 4";
            // 
            // txtIngrediente4
            // 
            this.txtIngrediente4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente4.Location = new System.Drawing.Point(225, 254);
            this.txtIngrediente4.Name = "txtIngrediente4";
            this.txtIngrediente4.Size = new System.Drawing.Size(258, 30);
            this.txtIngrediente4.TabIndex = 75;
            // 
            // lblIngrediente7
            // 
            this.lblIngrediente7.AutoSize = true;
            this.lblIngrediente7.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente7.Location = new System.Drawing.Point(533, 222);
            this.lblIngrediente7.Name = "lblIngrediente7";
            this.lblIngrediente7.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente7.TabIndex = 74;
            this.lblIngrediente7.Text = "Ingrediente 7";
            // 
            // txtIngrediente7
            // 
            this.txtIngrediente7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente7.Location = new System.Drawing.Point(672, 220);
            this.txtIngrediente7.Name = "txtIngrediente7";
            this.txtIngrediente7.Size = new System.Drawing.Size(258, 30);
            this.txtIngrediente7.TabIndex = 73;
            // 
            // lblIngrediente3
            // 
            this.lblIngrediente3.AutoSize = true;
            this.lblIngrediente3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente3.Location = new System.Drawing.Point(86, 220);
            this.lblIngrediente3.Name = "lblIngrediente3";
            this.lblIngrediente3.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente3.TabIndex = 72;
            this.lblIngrediente3.Text = "Ingrediente 3";
            // 
            // txtIngrediente3
            // 
            this.txtIngrediente3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente3.Location = new System.Drawing.Point(225, 218);
            this.txtIngrediente3.Name = "txtIngrediente3";
            this.txtIngrediente3.Size = new System.Drawing.Size(258, 30);
            this.txtIngrediente3.TabIndex = 71;
            // 
            // pictureBoxCadastroLanches
            // 
            this.pictureBoxCadastroLanches.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxCadastroLanches.Location = new System.Drawing.Point(225, 341);
            this.pictureBoxCadastroLanches.Name = "pictureBoxCadastroLanches";
            this.pictureBoxCadastroLanches.Size = new System.Drawing.Size(258, 122);
            this.pictureBoxCadastroLanches.TabIndex = 79;
            this.pictureBoxCadastroLanches.TabStop = false;
            // 
            // lblFotoLanche
            // 
            this.lblFotoLanche.AutoSize = true;
            this.lblFotoLanche.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoLanche.Location = new System.Drawing.Point(133, 341);
            this.lblFotoLanche.Name = "lblFotoLanche";
            this.lblFotoLanche.Size = new System.Drawing.Size(77, 24);
            this.lblFotoLanche.TabIndex = 80;
            this.lblFotoLanche.Text = "Imagem";
            // 
            // lblPrecoLanche
            // 
            this.lblPrecoLanche.AutoSize = true;
            this.lblPrecoLanche.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoLanche.Location = new System.Drawing.Point(575, 380);
            this.lblPrecoLanche.Name = "lblPrecoLanche";
            this.lblPrecoLanche.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoLanche.TabIndex = 84;
            this.lblPrecoLanche.Text = "Preço ($)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(672, 378);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 30);
            this.textBox1.TabIndex = 83;
            // 
            // lblCustoLanche
            // 
            this.lblCustoLanche.AutoSize = true;
            this.lblCustoLanche.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoLanche.Location = new System.Drawing.Point(575, 344);
            this.lblCustoLanche.Name = "lblCustoLanche";
            this.lblCustoLanche.Size = new System.Drawing.Size(86, 24);
            this.lblCustoLanche.TabIndex = 82;
            this.lblCustoLanche.Text = "Custo ($)";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(672, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 30);
            this.textBox2.TabIndex = 81;
            // 
            // CadastroLanches
            // 
            this.ClientSize = new System.Drawing.Size(1024, 545);
            this.Controls.Add(this.lblPrecoLanche);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCustoLanche);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblFotoLanche);
            this.Controls.Add(this.pictureBoxCadastroLanches);
            this.Controls.Add(this.lblIngrediente8);
            this.Controls.Add(this.txtIngrediente8);
            this.Controls.Add(this.lblIngrediente4);
            this.Controls.Add(this.txtIngrediente4);
            this.Controls.Add(this.lblIngrediente7);
            this.Controls.Add(this.txtIngrediente7);
            this.Controls.Add(this.lblIngrediente3);
            this.Controls.Add(this.txtIngrediente3);
            this.Controls.Add(this.lblIngrediente6);
            this.Controls.Add(this.txtIngrediente6);
            this.Controls.Add(this.lblIngrediente2);
            this.Controls.Add(this.txtIngrediente2);
            this.Controls.Add(this.lblIngrediente5);
            this.Controls.Add(this.txtIngrediente5);
            this.Controls.Add(this.buttonSalvarCadastroCliente);
            this.Controls.Add(this.ddlTipoMolho);
            this.Controls.Add(this.lblTipoMolho);
            this.Controls.Add(this.lblIngrediente1);
            this.Controls.Add(this.txtIngrediente1);
            this.Controls.Add(this.lblTituloCadastroLanches);
            this.Controls.Add(this.lblNomeLanche);
            this.Controls.Add(this.txtNomeLanche);
            this.Name = "CadastroLanches";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroLanches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
