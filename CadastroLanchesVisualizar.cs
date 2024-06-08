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
        private Label lblPrecoCadastroLanchesVisualizar;
        private Label lblCustoCadastroLanchesVisualizar;
        private Label lblImagemCadastroLanchesVisualizar;
        private Label lblIngrediente8CadastroLanchesVizualizar;
        private Label lblIngrediente4CadastroLanchesVizualizar;
        private Label lblIngrediente7CadastroLanchesVizualizar;
        private Label lblIngrediente3CadastroLanchesVizualizar;
        private Label lblIngrediente6CadastroLanchesVizualizar;
        private Label lblIngrediente2CadastroLanchesVizualizar;
        private Label lblIngrediente5CadastroLanchesVisualizar;
        private Label lblTipoMolhoCadastroLanchesVizualizar;
        private Label lblIngrediente1CadastroLanchesVizualizar;
        private Label lblTituloCadastroLanchesVisualizar;
        private Label lblNomeCadastroLanchesVisualizarPreenchido;
        private Label lblIngrediente1CadastroLanchesVisualizarPreenchido;
        private Label lblIngrediente2CadastroLanchesVisualizarPreenchido;
        private Label lblIngrediente3CadastroLanchesVisualizarPreenchido;
        private Label lblIngrediente4CadastroLanchesVisualizarPreenchido;
        private Label lblTipoMolhoCadastroLanchesVisualizarPreenchido;
        private Label lblIngrediente5VizualizarPreenchido;
        private Label lblIngrediente6VizualizarPreenchido;
        private Label lblIngrediente7VizualizarPreenchido;
        private Label lblIngrediente8VizualizarPreenchido;
        private Label lblCustoLancheVisualizarPreenchido;
        private Label lblPrecoLancheVisualizarPreenchido;
        private Button buttonDeletarCadastroLanchesVisualizar;
        private Button buttonEditarCadastroLanchesVisualizar;
        private PictureBox imgCadastroLanchesVisualizarPreenchido;
        private Label lblOBSCadastroLanchesVizualizar;
        private Label lblOBSVizualizarPreenchido;
        private Label lblIDCadastroLanchesVisualizar;
        private Label lblIDCadastroLanchesVisualizarPreenchido;
        private Label lblNomeCadastroLanchesVisualizar;

        public CadastroLanchesVisualizar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblPrecoCadastroLanchesVisualizar = new System.Windows.Forms.Label();
            this.lblCustoCadastroLanchesVisualizar = new System.Windows.Forms.Label();
            this.lblImagemCadastroLanchesVisualizar = new System.Windows.Forms.Label();
            this.lblIngrediente8CadastroLanchesVizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente4CadastroLanchesVizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente7CadastroLanchesVizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente3CadastroLanchesVizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente6CadastroLanchesVizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente2CadastroLanchesVizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente5CadastroLanchesVisualizar = new System.Windows.Forms.Label();
            this.lblTipoMolhoCadastroLanchesVizualizar = new System.Windows.Forms.Label();
            this.lblIngrediente1CadastroLanchesVizualizar = new System.Windows.Forms.Label();
            this.lblTituloCadastroLanchesVisualizar = new System.Windows.Forms.Label();
            this.lblNomeCadastroLanchesVisualizar = new System.Windows.Forms.Label();
            this.lblNomeCadastroLanchesVisualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente1CadastroLanchesVisualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente2CadastroLanchesVisualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente3CadastroLanchesVisualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente4CadastroLanchesVisualizarPreenchido = new System.Windows.Forms.Label();
            this.lblTipoMolhoCadastroLanchesVisualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente5VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente6VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente7VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIngrediente8VizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblCustoLancheVisualizarPreenchido = new System.Windows.Forms.Label();
            this.lblPrecoLancheVisualizarPreenchido = new System.Windows.Forms.Label();
            this.buttonDeletarCadastroLanchesVisualizar = new System.Windows.Forms.Button();
            this.buttonEditarCadastroLanchesVisualizar = new System.Windows.Forms.Button();
            this.imgCadastroLanchesVisualizarPreenchido = new System.Windows.Forms.PictureBox();
            this.lblOBSCadastroLanchesVizualizar = new System.Windows.Forms.Label();
            this.lblOBSVizualizarPreenchido = new System.Windows.Forms.Label();
            this.lblIDCadastroLanchesVisualizar = new System.Windows.Forms.Label();
            this.lblIDCadastroLanchesVisualizarPreenchido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadastroLanchesVisualizarPreenchido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecoCadastroLanchesVisualizar
            // 
            this.lblPrecoCadastroLanchesVisualizar.AutoSize = true;
            this.lblPrecoCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCadastroLanchesVisualizar.Location = new System.Drawing.Point(560, 382);
            this.lblPrecoCadastroLanchesVisualizar.Name = "lblPrecoCadastroLanchesVisualizar";
            this.lblPrecoCadastroLanchesVisualizar.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoCadastroLanchesVisualizar.TabIndex = 112;
            this.lblPrecoCadastroLanchesVisualizar.Text = "Preço ($)";
            // 
            // lblCustoCadastroLanchesVisualizar
            // 
            this.lblCustoCadastroLanchesVisualizar.AutoSize = true;
            this.lblCustoCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoCadastroLanchesVisualizar.Location = new System.Drawing.Point(555, 346);
            this.lblCustoCadastroLanchesVisualizar.Name = "lblCustoCadastroLanchesVisualizar";
            this.lblCustoCadastroLanchesVisualizar.Size = new System.Drawing.Size(86, 24);
            this.lblCustoCadastroLanchesVisualizar.TabIndex = 110;
            this.lblCustoCadastroLanchesVisualizar.Text = "Custo ($)";
            // 
            // lblImagemCadastroLanchesVisualizar
            // 
            this.lblImagemCadastroLanchesVisualizar.AutoSize = true;
            this.lblImagemCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemCadastroLanchesVisualizar.Location = new System.Drawing.Point(117, 346);
            this.lblImagemCadastroLanchesVisualizar.Name = "lblImagemCadastroLanchesVisualizar";
            this.lblImagemCadastroLanchesVisualizar.Size = new System.Drawing.Size(77, 24);
            this.lblImagemCadastroLanchesVisualizar.TabIndex = 108;
            this.lblImagemCadastroLanchesVisualizar.Text = "Imagem";
            // 
            // lblIngrediente8CadastroLanchesVizualizar
            // 
            this.lblIngrediente8CadastroLanchesVizualizar.AutoSize = true;
            this.lblIngrediente8CadastroLanchesVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente8CadastroLanchesVizualizar.Location = new System.Drawing.Point(517, 263);
            this.lblIngrediente8CadastroLanchesVizualizar.Name = "lblIngrediente8CadastroLanchesVizualizar";
            this.lblIngrediente8CadastroLanchesVizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente8CadastroLanchesVizualizar.TabIndex = 106;
            this.lblIngrediente8CadastroLanchesVizualizar.Text = "Ingrediente 8";
            // 
            // lblIngrediente4CadastroLanchesVizualizar
            // 
            this.lblIngrediente4CadastroLanchesVizualizar.AutoSize = true;
            this.lblIngrediente4CadastroLanchesVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente4CadastroLanchesVizualizar.Location = new System.Drawing.Point(70, 261);
            this.lblIngrediente4CadastroLanchesVizualizar.Name = "lblIngrediente4CadastroLanchesVizualizar";
            this.lblIngrediente4CadastroLanchesVizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente4CadastroLanchesVizualizar.TabIndex = 104;
            this.lblIngrediente4CadastroLanchesVizualizar.Text = "Ingrediente 4";
            // 
            // lblIngrediente7CadastroLanchesVizualizar
            // 
            this.lblIngrediente7CadastroLanchesVizualizar.AutoSize = true;
            this.lblIngrediente7CadastroLanchesVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente7CadastroLanchesVizualizar.Location = new System.Drawing.Point(517, 227);
            this.lblIngrediente7CadastroLanchesVizualizar.Name = "lblIngrediente7CadastroLanchesVizualizar";
            this.lblIngrediente7CadastroLanchesVizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente7CadastroLanchesVizualizar.TabIndex = 102;
            this.lblIngrediente7CadastroLanchesVizualizar.Text = "Ingrediente 7";
            // 
            // lblIngrediente3CadastroLanchesVizualizar
            // 
            this.lblIngrediente3CadastroLanchesVizualizar.AutoSize = true;
            this.lblIngrediente3CadastroLanchesVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente3CadastroLanchesVizualizar.Location = new System.Drawing.Point(70, 225);
            this.lblIngrediente3CadastroLanchesVizualizar.Name = "lblIngrediente3CadastroLanchesVizualizar";
            this.lblIngrediente3CadastroLanchesVizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente3CadastroLanchesVizualizar.TabIndex = 100;
            this.lblIngrediente3CadastroLanchesVizualizar.Text = "Ingrediente 3";
            // 
            // lblIngrediente6CadastroLanchesVizualizar
            // 
            this.lblIngrediente6CadastroLanchesVizualizar.AutoSize = true;
            this.lblIngrediente6CadastroLanchesVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente6CadastroLanchesVizualizar.Location = new System.Drawing.Point(517, 191);
            this.lblIngrediente6CadastroLanchesVizualizar.Name = "lblIngrediente6CadastroLanchesVizualizar";
            this.lblIngrediente6CadastroLanchesVizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente6CadastroLanchesVizualizar.TabIndex = 98;
            this.lblIngrediente6CadastroLanchesVizualizar.Text = "Ingrediente 6";
            // 
            // lblIngrediente2CadastroLanchesVizualizar
            // 
            this.lblIngrediente2CadastroLanchesVizualizar.AutoSize = true;
            this.lblIngrediente2CadastroLanchesVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente2CadastroLanchesVizualizar.Location = new System.Drawing.Point(70, 189);
            this.lblIngrediente2CadastroLanchesVizualizar.Name = "lblIngrediente2CadastroLanchesVizualizar";
            this.lblIngrediente2CadastroLanchesVizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente2CadastroLanchesVizualizar.TabIndex = 96;
            this.lblIngrediente2CadastroLanchesVizualizar.Text = "Ingrediente 2";
            // 
            // lblIngrediente5CadastroLanchesVisualizar
            // 
            this.lblIngrediente5CadastroLanchesVisualizar.AutoSize = true;
            this.lblIngrediente5CadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente5CadastroLanchesVisualizar.Location = new System.Drawing.Point(517, 155);
            this.lblIngrediente5CadastroLanchesVisualizar.Name = "lblIngrediente5CadastroLanchesVisualizar";
            this.lblIngrediente5CadastroLanchesVisualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente5CadastroLanchesVisualizar.TabIndex = 94;
            this.lblIngrediente5CadastroLanchesVisualizar.Text = "Ingrediente 5";
            // 
            // lblTipoMolhoCadastroLanchesVizualizar
            // 
            this.lblTipoMolhoCadastroLanchesVizualizar.AutoSize = true;
            this.lblTipoMolhoCadastroLanchesVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMolhoCadastroLanchesVizualizar.Location = new System.Drawing.Point(59, 301);
            this.lblTipoMolhoCadastroLanchesVizualizar.Name = "lblTipoMolhoCadastroLanchesVizualizar";
            this.lblTipoMolhoCadastroLanchesVizualizar.Size = new System.Drawing.Size(135, 24);
            this.lblTipoMolhoCadastroLanchesVizualizar.TabIndex = 90;
            this.lblTipoMolhoCadastroLanchesVizualizar.Text = "Tipo de Molho";
            // 
            // lblIngrediente1CadastroLanchesVizualizar
            // 
            this.lblIngrediente1CadastroLanchesVizualizar.AutoSize = true;
            this.lblIngrediente1CadastroLanchesVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente1CadastroLanchesVizualizar.Location = new System.Drawing.Point(70, 153);
            this.lblIngrediente1CadastroLanchesVizualizar.Name = "lblIngrediente1CadastroLanchesVizualizar";
            this.lblIngrediente1CadastroLanchesVizualizar.Size = new System.Drawing.Size(124, 24);
            this.lblIngrediente1CadastroLanchesVizualizar.TabIndex = 89;
            this.lblIngrediente1CadastroLanchesVizualizar.Text = "Ingrediente 1";
            // 
            // lblTituloCadastroLanchesVisualizar
            // 
            this.lblTituloCadastroLanchesVisualizar.AutoSize = true;
            this.lblTituloCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroLanchesVisualizar.Location = new System.Drawing.Point(415, 30);
            this.lblTituloCadastroLanchesVisualizar.Name = "lblTituloCadastroLanchesVisualizar";
            this.lblTituloCadastroLanchesVisualizar.Size = new System.Drawing.Size(100, 31);
            this.lblTituloCadastroLanchesVisualizar.TabIndex = 87;
            this.lblTituloCadastroLanchesVisualizar.Text = "Lanches";
            // 
            // lblNomeCadastroLanchesVisualizar
            // 
            this.lblNomeCadastroLanchesVisualizar.AutoSize = true;
            this.lblNomeCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadastroLanchesVisualizar.Location = new System.Drawing.Point(134, 120);
            this.lblNomeCadastroLanchesVisualizar.Name = "lblNomeCadastroLanchesVisualizar";
            this.lblNomeCadastroLanchesVisualizar.Size = new System.Drawing.Size(60, 24);
            this.lblNomeCadastroLanchesVisualizar.TabIndex = 86;
            this.lblNomeCadastroLanchesVisualizar.Text = "Nome";
            // 
            // lblNomeCadastroLanchesVisualizarPreenchido
            // 
            this.lblNomeCadastroLanchesVisualizarPreenchido.AutoSize = true;
            this.lblNomeCadastroLanchesVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadastroLanchesVisualizarPreenchido.Location = new System.Drawing.Point(205, 121);
            this.lblNomeCadastroLanchesVisualizarPreenchido.Name = "lblNomeCadastroLanchesVisualizarPreenchido";
            this.lblNomeCadastroLanchesVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblNomeCadastroLanchesVisualizarPreenchido.TabIndex = 113;
            // 
            // lblIngrediente1CadastroLanchesVisualizarPreenchido
            // 
            this.lblIngrediente1CadastroLanchesVisualizarPreenchido.AutoSize = true;
            this.lblIngrediente1CadastroLanchesVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente1CadastroLanchesVisualizarPreenchido.Location = new System.Drawing.Point(205, 153);
            this.lblIngrediente1CadastroLanchesVisualizarPreenchido.Name = "lblIngrediente1CadastroLanchesVisualizarPreenchido";
            this.lblIngrediente1CadastroLanchesVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente1CadastroLanchesVisualizarPreenchido.TabIndex = 114;
            // 
            // lblIngrediente2CadastroLanchesVisualizarPreenchido
            // 
            this.lblIngrediente2CadastroLanchesVisualizarPreenchido.AutoSize = true;
            this.lblIngrediente2CadastroLanchesVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente2CadastroLanchesVisualizarPreenchido.Location = new System.Drawing.Point(205, 189);
            this.lblIngrediente2CadastroLanchesVisualizarPreenchido.Name = "lblIngrediente2CadastroLanchesVisualizarPreenchido";
            this.lblIngrediente2CadastroLanchesVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente2CadastroLanchesVisualizarPreenchido.TabIndex = 115;
            // 
            // lblIngrediente3CadastroLanchesVisualizarPreenchido
            // 
            this.lblIngrediente3CadastroLanchesVisualizarPreenchido.AutoSize = true;
            this.lblIngrediente3CadastroLanchesVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente3CadastroLanchesVisualizarPreenchido.Location = new System.Drawing.Point(205, 228);
            this.lblIngrediente3CadastroLanchesVisualizarPreenchido.Name = "lblIngrediente3CadastroLanchesVisualizarPreenchido";
            this.lblIngrediente3CadastroLanchesVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente3CadastroLanchesVisualizarPreenchido.TabIndex = 116;
            // 
            // lblIngrediente4CadastroLanchesVisualizarPreenchido
            // 
            this.lblIngrediente4CadastroLanchesVisualizarPreenchido.AutoSize = true;
            this.lblIngrediente4CadastroLanchesVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente4CadastroLanchesVisualizarPreenchido.Location = new System.Drawing.Point(205, 262);
            this.lblIngrediente4CadastroLanchesVisualizarPreenchido.Name = "lblIngrediente4CadastroLanchesVisualizarPreenchido";
            this.lblIngrediente4CadastroLanchesVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIngrediente4CadastroLanchesVisualizarPreenchido.TabIndex = 117;
            // 
            // lblTipoMolhoCadastroLanchesVisualizarPreenchido
            // 
            this.lblTipoMolhoCadastroLanchesVisualizarPreenchido.AutoSize = true;
            this.lblTipoMolhoCadastroLanchesVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMolhoCadastroLanchesVisualizarPreenchido.Location = new System.Drawing.Point(205, 301);
            this.lblTipoMolhoCadastroLanchesVisualizarPreenchido.Name = "lblTipoMolhoCadastroLanchesVisualizarPreenchido";
            this.lblTipoMolhoCadastroLanchesVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblTipoMolhoCadastroLanchesVisualizarPreenchido.TabIndex = 118;
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
            this.lblCustoLancheVisualizarPreenchido.Location = new System.Drawing.Point(648, 347);
            this.lblCustoLancheVisualizarPreenchido.Name = "lblCustoLancheVisualizarPreenchido";
            this.lblCustoLancheVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblCustoLancheVisualizarPreenchido.TabIndex = 123;
            // 
            // lblPrecoLancheVisualizarPreenchido
            // 
            this.lblPrecoLancheVisualizarPreenchido.AutoSize = true;
            this.lblPrecoLancheVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoLancheVisualizarPreenchido.Location = new System.Drawing.Point(648, 382);
            this.lblPrecoLancheVisualizarPreenchido.Name = "lblPrecoLancheVisualizarPreenchido";
            this.lblPrecoLancheVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblPrecoLancheVisualizarPreenchido.TabIndex = 124;
            // 
            // buttonDeletarCadastroLanchesVisualizar
            // 
            this.buttonDeletarCadastroLanchesVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeletarCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletarCadastroLanchesVisualizar.ForeColor = System.Drawing.Color.Red;
            this.buttonDeletarCadastroLanchesVisualizar.Location = new System.Drawing.Point(796, 461);
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
            this.buttonEditarCadastroLanchesVisualizar.Location = new System.Drawing.Point(610, 461);
            this.buttonEditarCadastroLanchesVisualizar.Name = "buttonEditarCadastroLanchesVisualizar";
            this.buttonEditarCadastroLanchesVisualizar.Size = new System.Drawing.Size(167, 55);
            this.buttonEditarCadastroLanchesVisualizar.TabIndex = 126;
            this.buttonEditarCadastroLanchesVisualizar.Text = "Editar";
            this.buttonEditarCadastroLanchesVisualizar.UseVisualStyleBackColor = false;
            // 
            // imgCadastroLanchesVisualizarPreenchido
            // 
            this.imgCadastroLanchesVisualizarPreenchido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgCadastroLanchesVisualizarPreenchido.Location = new System.Drawing.Point(209, 349);
            this.imgCadastroLanchesVisualizarPreenchido.Name = "imgCadastroLanchesVisualizarPreenchido";
            this.imgCadastroLanchesVisualizarPreenchido.Size = new System.Drawing.Size(229, 167);
            this.imgCadastroLanchesVisualizarPreenchido.TabIndex = 290;
            this.imgCadastroLanchesVisualizarPreenchido.TabStop = false;
            // 
            // lblOBSCadastroLanchesVizualizar
            // 
            this.lblOBSCadastroLanchesVizualizar.AutoSize = true;
            this.lblOBSCadastroLanchesVizualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBSCadastroLanchesVizualizar.Location = new System.Drawing.Point(593, 301);
            this.lblOBSCadastroLanchesVizualizar.Name = "lblOBSCadastroLanchesVizualizar";
            this.lblOBSCadastroLanchesVizualizar.Size = new System.Drawing.Size(48, 24);
            this.lblOBSCadastroLanchesVizualizar.TabIndex = 291;
            this.lblOBSCadastroLanchesVizualizar.Text = "OBS";
            // 
            // lblOBSVizualizarPreenchido
            // 
            this.lblOBSVizualizarPreenchido.AutoSize = true;
            this.lblOBSVizualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBSVizualizarPreenchido.Location = new System.Drawing.Point(652, 302);
            this.lblOBSVizualizarPreenchido.Name = "lblOBSVizualizarPreenchido";
            this.lblOBSVizualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblOBSVizualizarPreenchido.TabIndex = 292;
            // 
            // lblIDCadastroLanchesVisualizar
            // 
            this.lblIDCadastroLanchesVisualizar.AutoSize = true;
            this.lblIDCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCadastroLanchesVisualizar.Location = new System.Drawing.Point(96, 87);
            this.lblIDCadastroLanchesVisualizar.Name = "lblIDCadastroLanchesVisualizar";
            this.lblIDCadastroLanchesVisualizar.Size = new System.Drawing.Size(98, 24);
            this.lblIDCadastroLanchesVisualizar.TabIndex = 293;
            this.lblIDCadastroLanchesVisualizar.Text = "ID Lanche";
            // 
            // lblIDCadastroLanchesVisualizarPreenchido
            // 
            this.lblIDCadastroLanchesVisualizarPreenchido.AutoSize = true;
            this.lblIDCadastroLanchesVisualizarPreenchido.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCadastroLanchesVisualizarPreenchido.Location = new System.Drawing.Point(205, 87);
            this.lblIDCadastroLanchesVisualizarPreenchido.Name = "lblIDCadastroLanchesVisualizarPreenchido";
            this.lblIDCadastroLanchesVisualizarPreenchido.Size = new System.Drawing.Size(0, 23);
            this.lblIDCadastroLanchesVisualizarPreenchido.TabIndex = 294;
            // 
            // CadastroLanchesVisualizar
            // 
            this.ClientSize = new System.Drawing.Size(988, 548);
            this.Controls.Add(this.lblIDCadastroLanchesVisualizarPreenchido);
            this.Controls.Add(this.lblIDCadastroLanchesVisualizar);
            this.Controls.Add(this.lblOBSVizualizarPreenchido);
            this.Controls.Add(this.lblOBSCadastroLanchesVizualizar);
            this.Controls.Add(this.imgCadastroLanchesVisualizarPreenchido);
            this.Controls.Add(this.buttonDeletarCadastroLanchesVisualizar);
            this.Controls.Add(this.buttonEditarCadastroLanchesVisualizar);
            this.Controls.Add(this.lblPrecoLancheVisualizarPreenchido);
            this.Controls.Add(this.lblCustoLancheVisualizarPreenchido);
            this.Controls.Add(this.lblIngrediente8VizualizarPreenchido);
            this.Controls.Add(this.lblIngrediente7VizualizarPreenchido);
            this.Controls.Add(this.lblIngrediente6VizualizarPreenchido);
            this.Controls.Add(this.lblIngrediente5VizualizarPreenchido);
            this.Controls.Add(this.lblTipoMolhoCadastroLanchesVisualizarPreenchido);
            this.Controls.Add(this.lblIngrediente4CadastroLanchesVisualizarPreenchido);
            this.Controls.Add(this.lblIngrediente3CadastroLanchesVisualizarPreenchido);
            this.Controls.Add(this.lblIngrediente2CadastroLanchesVisualizarPreenchido);
            this.Controls.Add(this.lblIngrediente1CadastroLanchesVisualizarPreenchido);
            this.Controls.Add(this.lblNomeCadastroLanchesVisualizarPreenchido);
            this.Controls.Add(this.lblPrecoCadastroLanchesVisualizar);
            this.Controls.Add(this.lblCustoCadastroLanchesVisualizar);
            this.Controls.Add(this.lblImagemCadastroLanchesVisualizar);
            this.Controls.Add(this.lblIngrediente8CadastroLanchesVizualizar);
            this.Controls.Add(this.lblIngrediente4CadastroLanchesVizualizar);
            this.Controls.Add(this.lblIngrediente7CadastroLanchesVizualizar);
            this.Controls.Add(this.lblIngrediente3CadastroLanchesVizualizar);
            this.Controls.Add(this.lblIngrediente6CadastroLanchesVizualizar);
            this.Controls.Add(this.lblIngrediente2CadastroLanchesVizualizar);
            this.Controls.Add(this.lblIngrediente5CadastroLanchesVisualizar);
            this.Controls.Add(this.lblTipoMolhoCadastroLanchesVizualizar);
            this.Controls.Add(this.lblIngrediente1CadastroLanchesVizualizar);
            this.Controls.Add(this.lblTituloCadastroLanchesVisualizar);
            this.Controls.Add(this.lblNomeCadastroLanchesVisualizar);
            this.Name = "CadastroLanchesVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.imgCadastroLanchesVisualizarPreenchido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
