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
    public partial class CadastroLanchesVisualizar : Form
    {
        private Label lblPrecoLancheVisualizar;
        private Label lblCustoLancheVisualizar;
        private Label lblFotoLancheVizualizar;
        private Label lblIngrediente8Vizualizar;
        private Label lblIngrediente4Vizualizar;
        private Label lblIngrediente7Vizualizar;
        private Label lblIngrediente3Vizualizar;
        private Label lblIngrediente6Vizualizar;
        private Label lblIngrediente2Vizualizar;
        private Label lblIngrediente5Vizualizar;
        private Label lblTipoMolhoVizualizar;
        private Label lblIngrediente1Vizualizar;
        private Label lblTituloVisualizarLanches;
        private Label lblNomeLancheVisualizarPreenchido;
        private Label lblIngrediente1VizualizarPreenchido;
        private Label lblIngrediente2VizualizarPreenchido;
        private Label lblIngrediente3VizualizarPreenchido;
        private Label lblIngrediente4VizualizarPreenchido;
        private Label lblTipoMolhoVizualizarPreenchido;
        private Label lblIngrediente5VizualizarPreenchido;
        private Label lblIngrediente6VizualizarPreenchido;
        private Label lblIngrediente7VizualizarPreenchido;
        private Label lblIngrediente8VizualizarPreenchido;
        private Label lblCustoLancheVisualizarPreenchido;
        private Label lblPrecoLancheVisualizarPreenchido;
        private Label lblFotoLancheVizualizarPreechido;
        private Button buttonDeletarCadastroLanchesVisualizar;
        private Button buttonEditarCadastroLanchesVisualizar;
        private Label lblNomeLancheVisualizar;

        public CadastroLanchesVisualizar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblPrecoLancheVisualizar = new System.Windows.Forms.Label();
            this.lblCustoLancheVisualizar = new System.Windows.Forms.Label();
            this.lblFotoLancheVizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente8Vizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente4Vizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente7Vizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente3Vizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente6Vizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente2Vizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente5Vizualizar = new System.Windows.Forms.Label();
            this.lblTipoMolhoVizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente1Vizualizar = new System.Windows.Forms.Label();
            this.lblTituloVisualizarLanches = new System.Windows.Forms.Label();
            this.lblNomeLancheVisualizar = new System.Windows.Forms.Label();
            this.lblNomeLancheVisualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente1VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente2VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente3VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente4VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblTipoMolhoVizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente5VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente6VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente7VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente8VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblCustoLancheVisualizarPreenchido = new System.Windows.Forms.Label();
            this.lblPrecoLancheVisualizarPreenchido = new System.Windows.Forms.Label();
            this.lblFotoLancheVizualizarPreechido = new System.Windows.Forms.Label();
            this.buttonDeletarCadastroLanchesVisualizar = new System.Windows.Forms.Button();
            this.buttonEditarCadastroLanchesVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrecoLancheVisualizar
            // 
            this.lblPrecoLancheVisualizar.AutoSize = true;
            this.lblPrecoLancheVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoLancheVisualizar.Location = new System.Drawing.Point(559, 385);
            this.lblPrecoLancheVisualizar.Name = "lblPrecoLancheVisualizar";
            this.lblPrecoLancheVisualizar.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoLancheVisualizar.TabIndex = 112;
            this.lblPrecoLancheVisualizar.Text = "Preço ($)";
            // 
            // lblCustoLancheVisualizar
            // 
            this.lblCustoLancheVisualizar.AutoSize = true;
            this.lblCustoLancheVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoLancheVisualizar.Location = new System.Drawing.Point(559, 349);
            this.lblCustoLancheVisualizar.Name = "lblCustoLancheVisualizar";
            this.lblCustoLancheVisualizar.Size = new System.Drawing.Size(86, 24);
            this.lblCustoLancheVisualizar.TabIndex = 110;
            this.lblCustoLancheVisualizar.Text = "Custo ($)";
            // 
            // lblFotoLancheVizualizar
            // 
            this.lblFotoLancheVizualizar.AutoSize = true;
            this.lblFotoLancheVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoLancheVizualizar.Location = new System.Drawing.Point(117, 346);
            this.lblFotoLancheVizualizar.Name = "lblFotoLancheVizualizar";
            this.lblFotoLancheVizualizar.Size = new System.Drawing.Size(77, 24);
            this.lblFotoLancheVizualizar.TabIndex = 108;
            this.lblFotoLancheVizualizar.Text = "Imagem";
            // 
            // lblIngrediente8Vizualizar
            // 
            this.lblIngrediente8Vizualizar.AutoSize = true;
            this.lblIngrediente8Vizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente8Vizualizar.Location = new System.Drawing.Point(517, 263);
            this.lblIngrediente8Vizualizar.Name = "lblIngrediente8Vizualizar";
            this.lblIngrediente8Vizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente8Vizualizar.TabIndex = 106;
            this.lblIngrediente8Vizualizar.Text = "Ingrediente 8";
            // 
            // lblIngrediente4Vizualizar
            // 
            this.lblIngrediente4Vizualizar.AutoSize = true;
            this.lblIngrediente4Vizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente4Vizualizar.Location = new System.Drawing.Point(70, 261);
            this.lblIngrediente4Vizualizar.Name = "lblIngrediente4Vizualizar";
            this.lblIngrediente4Vizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente4Vizualizar.TabIndex = 104;
            this.lblIngrediente4Vizualizar.Text = "Ingrediente 4";
            // 
            // lblIngrediente7Vizualizar
            // 
            this.lblIngrediente7Vizualizar.AutoSize = true;
            this.lblIngrediente7Vizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente7Vizualizar.Location = new System.Drawing.Point(517, 227);
            this.lblIngrediente7Vizualizar.Name = "lblIngrediente7Vizualizar";
            this.lblIngrediente7Vizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente7Vizualizar.TabIndex = 102;
            this.lblIngrediente7Vizualizar.Text = "Ingrediente 7";
            // 
            // lblIngrediente3Vizualizar
            // 
            this.lblIngrediente3Vizualizar.AutoSize = true;
            this.lblIngrediente3Vizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente3Vizualizar.Location = new System.Drawing.Point(70, 225);
            this.lblIngrediente3Vizualizar.Name = "lblIngrediente3Vizualizar";
            this.lblIngrediente3Vizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente3Vizualizar.TabIndex = 100;
            this.lblIngrediente3Vizualizar.Text = "Ingrediente 3";
            // 
            // lblIngrediente6Vizualizar
            // 
            this.lblIngrediente6Vizualizar.AutoSize = true;
            this.lblIngrediente6Vizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente6Vizualizar.Location = new System.Drawing.Point(517, 191);
            this.lblIngrediente6Vizualizar.Name = "lblIngrediente6Vizualizar";
            this.lblIngrediente6Vizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente6Vizualizar.TabIndex = 98;
            this.lblIngrediente6Vizualizar.Text = "Ingrediente 6";
            // 
            // lblIngrediente2Vizualizar
            // 
            this.lblIngrediente2Vizualizar.AutoSize = true;
            this.lblIngrediente2Vizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente2Vizualizar.Location = new System.Drawing.Point(70, 189);
            this.lblIngrediente2Vizualizar.Name = "lblIngrediente2Vizualizar";
            this.lblIngrediente2Vizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente2Vizualizar.TabIndex = 96;
            this.lblIngrediente2Vizualizar.Text = "Ingrediente 2";
            // 
            // lblIngrediente5Vizualizar
            // 
            this.lblIngrediente5Vizualizar.AutoSize = true;
            this.lblIngrediente5Vizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente5Vizualizar.Location = new System.Drawing.Point(517, 155);
            this.lblIngrediente5Vizualizar.Name = "lblIngrediente5Vizualizar";
            this.lblIngrediente5Vizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente5Vizualizar.TabIndex = 94;
            this.lblIngrediente5Vizualizar.Text = "Ingrediente 5";
            // 
            // lblTipoMolhoVizualizar
            // 
            this.lblTipoMolhoVizualizar.AutoSize = true;
            this.lblTipoMolhoVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMolhoVizualizar.Location = new System.Drawing.Point(59, 301);
            this.lblTipoMolhoVizualizar.Name = "lblTipoMolhoVizualizar";
            this.lblTipoMolhoVizualizar.Size = new System.Drawing.Size(135, 24);
            this.lblTipoMolhoVizualizar.TabIndex = 90;
            this.lblTipoMolhoVizualizar.Text = "Tipo de Molho";
            // 
            // lblIngrediente1Vizualizar
            // 
            this.lblIngrediente1Vizualizar.AutoSize = true;
            this.lblIngrediente1Vizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente1Vizualizar.Location = new System.Drawing.Point(70, 153);
            this.lblIngrediente1Vizualizar.Name = "lblIngrediente1Vizualizar";
            this.lblIngrediente1Vizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente1Vizualizar.TabIndex = 89;
            this.lblIngrediente1Vizualizar.Text = "Ingrediente 1";
            // 
            // lblTituloVisualizarLanches
            // 
            this.lblTituloVisualizarLanches.AutoSize = true;
            this.lblTituloVisualizarLanches.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVisualizarLanches.Location = new System.Drawing.Point(415, 30);
            this.lblTituloVisualizarLanches.Name = "lblTituloVisualizarLanches";
            this.lblTituloVisualizarLanches.Size = new System.Drawing.Size(100, 31);
            this.lblTituloVisualizarLanches.TabIndex = 87;
            this.lblTituloVisualizarLanches.Text = "Lanches";
            // 
            // lblNomeLancheVisualizar
            // 
            this.lblNomeLancheVisualizar.AutoSize = true;
            this.lblNomeLancheVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLancheVisualizar.Location = new System.Drawing.Point(42, 121);
            this.lblNomeLancheVisualizar.Name = "lblNomeLancheVisualizar";
            this.lblNomeLancheVisualizar.Size = new System.Drawing.Size(152, 24);
            this.lblNomeLancheVisualizar.TabIndex = 86;
            this.lblNomeLancheVisualizar.Text = "Nome do Lanche";
            // 
            // lblNomeLancheVisualizarPreenchido
            // 
            this.lblNomeLancheVisualizarPreenchido.AutoSize = true;
            this.lblNomeLancheVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLancheVisualizarPreenchido.Location = new System.Drawing.Point(205, 121);
            this.lblNomeLancheVisualizarPreenchido.Name = "lblNomeLancheVisualizarPreenchido";
            this.lblNomeLancheVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblNomeLancheVisualizarPreenchido.TabIndex = 113;
            // 
            // lblIngrediente1VizualizarPreenchido
            // 
            this.lblIngrediente1VizualizarPreenchido.AutoSize = true;
            this.lblIngrediente1VizualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente1VizualizarPreenchido.Location = new System.Drawing.Point(205, 153);
            this.lblIngrediente1VizualizarPreenchido.Name = "lblIngrediente1VizualizarPreenchido";
            this.lblIngrediente1VizualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente1VizualizarPreenchido.TabIndex = 114;
            // 
            // lblIngrediente2VizualizarPreenchido
            // 
            this.lblIngrediente2VizualizarPreenchido.AutoSize = true;
            this.lblIngrediente2VizualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente2VizualizarPreenchido.Location = new System.Drawing.Point(205, 189);
            this.lblIngrediente2VizualizarPreenchido.Name = "lblIngrediente2VizualizarPreenchido";
            this.lblIngrediente2VizualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente2VizualizarPreenchido.TabIndex = 115;
            // 
            // lblIngrediente3VizualizarPreenchido
            // 
            this.lblIngrediente3VizualizarPreenchido.AutoSize = true;
            this.lblIngrediente3VizualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente3VizualizarPreenchido.Location = new System.Drawing.Point(205, 228);
            this.lblIngrediente3VizualizarPreenchido.Name = "lblIngrediente3VizualizarPreenchido";
            this.lblIngrediente3VizualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente3VizualizarPreenchido.TabIndex = 116;
            // 
            // lblIngrediente4VizualizarPreenchido
            // 
            this.lblIngrediente4VizualizarPreenchido.AutoSize = true;
            this.lblIngrediente4VizualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente4VizualizarPreenchido.Location = new System.Drawing.Point(205, 262);
            this.lblIngrediente4VizualizarPreenchido.Name = "lblIngrediente4VizualizarPreenchido";
            this.lblIngrediente4VizualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente4VizualizarPreenchido.TabIndex = 117;
            // 
            // lblTipoMolhoVizualizarPreenchido
            // 
            this.lblTipoMolhoVizualizarPreenchido.AutoSize = true;
            this.lblTipoMolhoVizualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMolhoVizualizarPreenchido.Location = new System.Drawing.Point(205, 301);
            this.lblTipoMolhoVizualizarPreenchido.Name = "lblTipoMolhoVizualizarPreenchido";
            this.lblTipoMolhoVizualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblTipoMolhoVizualizarPreenchido.TabIndex = 118;
            // 
            // lblIngrediente5VizualizarPreenchido
            // 
            this.lblIngrediente5VizualizarPreenchido.AutoSize = true;
            this.lblIngrediente5VizualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente5VizualizarPreenchido.Location = new System.Drawing.Point(652, 155);
            this.lblIngrediente5VizualizarPreenchido.Name = "lblIngrediente5VizualizarPreenchido";
            this.lblIngrediente5VizualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente5VizualizarPreenchido.TabIndex = 119;
            // 
            // lblIngrediente6VizualizarPreenchido
            // 
            this.lblIngrediente6VizualizarPreenchido.AutoSize = true;
            this.lblIngrediente6VizualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente6VizualizarPreenchido.Location = new System.Drawing.Point(652, 189);
            this.lblIngrediente6VizualizarPreenchido.Name = "lblIngrediente6VizualizarPreenchido";
            this.lblIngrediente6VizualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente6VizualizarPreenchido.TabIndex = 120;
            // 
            // lblIngrediente7VizualizarPreenchido
            // 
            this.lblIngrediente7VizualizarPreenchido.AutoSize = true;
            this.lblIngrediente7VizualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente7VizualizarPreenchido.Location = new System.Drawing.Point(652, 228);
            this.lblIngrediente7VizualizarPreenchido.Name = "lblIngrediente7VizualizarPreenchido";
            this.lblIngrediente7VizualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente7VizualizarPreenchido.TabIndex = 121;
            // 
            // lblIngrediente8VizualizarPreenchido
            // 
            this.lblIngrediente8VizualizarPreenchido.AutoSize = true;
            this.lblIngrediente8VizualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente8VizualizarPreenchido.Location = new System.Drawing.Point(652, 263);
            this.lblIngrediente8VizualizarPreenchido.Name = "lblIngrediente8VizualizarPreenchido";
            this.lblIngrediente8VizualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente8VizualizarPreenchido.TabIndex = 122;
            // 
            // lblCustoLancheVisualizarPreenchido
            // 
            this.lblCustoLancheVisualizarPreenchido.AutoSize = true;
            this.lblCustoLancheVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoLancheVisualizarPreenchido.Location = new System.Drawing.Point(652, 350);
            this.lblCustoLancheVisualizarPreenchido.Name = "lblCustoLancheVisualizarPreenchido";
            this.lblCustoLancheVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblCustoLancheVisualizarPreenchido.TabIndex = 123;
            // 
            // lblPrecoLancheVisualizarPreenchido
            // 
            this.lblPrecoLancheVisualizarPreenchido.AutoSize = true;
            this.lblPrecoLancheVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoLancheVisualizarPreenchido.Location = new System.Drawing.Point(652, 385);
            this.lblPrecoLancheVisualizarPreenchido.Name = "lblPrecoLancheVisualizarPreenchido";
            this.lblPrecoLancheVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoLancheVisualizarPreenchido.TabIndex = 124;
            // 
            // lblFotoLancheVizualizarPreechido
            // 
            this.lblFotoLancheVizualizarPreechido.AutoSize = true;
            this.lblFotoLancheVizualizarPreechido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoLancheVizualizarPreechido.Location = new System.Drawing.Point(205, 350);
            this.lblFotoLancheVizualizarPreechido.Name = "lblFotoLancheVizualizarPreechido";
            this.lblFotoLancheVizualizarPreechido.Size = new System.Drawing.Size(0, 23);
            this.lblFotoLancheVizualizarPreechido.TabIndex = 125;
            // 
            // buttonDeletarCadastroLanchesVisualizar
            // 
            this.buttonDeletarCadastroLanchesVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeletarCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletarCadastroLanchesVisualizar.ForeColor = System.Drawing.Color.Red;
            this.buttonDeletarCadastroLanchesVisualizar.Location = new System.Drawing.Point(796, 446);
            this.buttonDeletarCadastroLanchesVisualizar.Name = "buttonDeletarCadastroLanchesVisualizar";
            this.buttonDeletarCadastroLanchesVisualizar.Size = new System.Drawing.Size(167, 55);
            this.buttonDeletarCadastroLanchesVisualizar.TabIndex = 127;
            this.buttonDeletarCadastroLanchesVisualizar.Text = "Deletar";
            this.buttonDeletarCadastroLanchesVisualizar.UseVisualStyleBackColor = false;
            // 
            // buttonEditarCadastroLanchesVisualizar
            // 
            this.buttonEditarCadastroLanchesVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditarCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCadastroLanchesVisualizar.ForeColor = System.Drawing.Color.Gold;
            this.buttonEditarCadastroLanchesVisualizar.Location = new System.Drawing.Point(610, 446);
            this.buttonEditarCadastroLanchesVisualizar.Name = "buttonEditarCadastroLanchesVisualizar";
            this.buttonEditarCadastroLanchesVisualizar.Size = new System.Drawing.Size(167, 55);
            this.buttonEditarCadastroLanchesVisualizar.TabIndex = 126;
            this.buttonEditarCadastroLanchesVisualizar.Text = "Editar";
            this.buttonEditarCadastroLanchesVisualizar.UseVisualStyleBackColor = false;
            // 
            // CadastroLanchesVisualizar
            // 
            this.ClientSize = new System.Drawing.Size(988, 548);
            this.Controls.Add(this.buttonDeletarCadastroLanchesVisualizar);
            this.Controls.Add(this.buttonEditarCadastroLanchesVisualizar);
            this.Controls.Add(this.lblFotoLancheVizualizarPreechido);
            this.Controls.Add(this.lblPrecoLancheVisualizarPreenchido);
            this.Controls.Add(this.lblCustoLancheVisualizarPreenchido);
            this.Controls.Add(this.lblIngrediente8VizualizarPreenchido);
            this.Controls.Add(this.lblIngrediente7VizualizarPreenchido);
            this.Controls.Add(this.lblIngrediente6VizualizarPreenchido);
            this.Controls.Add(this.lblIngrediente5VizualizarPreenchido);
            this.Controls.Add(this.lblTipoMolhoVizualizarPreenchido);
            this.Controls.Add(this.lblIngrediente4VizualizarPreenchido);
            this.Controls.Add(this.lblIngrediente3VizualizarPreenchido);
            this.Controls.Add(this.lblIngrediente2VizualizarPreenchido);
            this.Controls.Add(this.lblIngrediente1VizualizarPreenchido);
            this.Controls.Add(this.lblNomeLancheVisualizarPreenchido);
            this.Controls.Add(this.lblPrecoLancheVisualizar);
            this.Controls.Add(this.lblCustoLancheVisualizar);
            this.Controls.Add(this.lblFotoLancheVizualizar);
            this.Controls.Add(this.lblIngrediente8Vizualizar);
            this.Controls.Add(this.lblIngrediente4Vizualizar);
            this.Controls.Add(this.lblIngrediente7Vizualizar);
            this.Controls.Add(this.lblIngrediente3Vizualizar);
            this.Controls.Add(this.lblIngrediente6Vizualizar);
            this.Controls.Add(this.lblIngrediente2Vizualizar);
            this.Controls.Add(this.lblIngrediente5Vizualizar);
            this.Controls.Add(this.lblTipoMolhoVizualizar);
            this.Controls.Add(this.lblIngrediente1Vizualizar);
            this.Controls.Add(this.lblTituloVisualizarLanches);
            this.Controls.Add(this.lblNomeLancheVisualizar);
            this.Name = "CadastroLanchesVisualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
