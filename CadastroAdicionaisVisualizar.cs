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
    public partial class CadastroAdicionaisVisualizar : Form
    {
        private Label lblAdicionaisVisualizar;
        private Label lblPrecoAdicionaisVisualizar;
        private Label lblCustoAdicionaisVisualizar;
        private Label lblImagemAdicionaisVisualizar;
        private PictureBox imgAdicionalVisualizar1;
        private Label lblIdAdicionaisVisualizar;
        private Button buttonDeletarCadastroLanchesVisualizar;
        private Button buttonEditarCadastroLanchesVisualizar;
        private Label lblTituloCadastroAdicionaisVisualizar;

        public CadastroAdicionaisVisualizar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblAdicionaisVisualizar = new System.Windows.Forms.Label();
            this.lblPrecoAdicionaisVisualizar = new System.Windows.Forms.Label();
            this.lblCustoAdicionaisVisualizar = new System.Windows.Forms.Label();
            this.lblImagemAdicionaisVisualizar = new System.Windows.Forms.Label();
            this.imgAdicionalVisualizar1 = new System.Windows.Forms.PictureBox();
            this.lblTituloCadastroAdicionaisVisualizar = new System.Windows.Forms.Label();
            this.lblIdAdicionaisVisualizar = new System.Windows.Forms.Label();
            this.buttonDeletarCadastroLanchesVisualizar = new System.Windows.Forms.Button();
            this.buttonEditarCadastroLanchesVisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicionalVisualizar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdicionaisVisualizar
            // 
            this.lblAdicionaisVisualizar.AutoSize = true;
            this.lblAdicionaisVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionaisVisualizar.Location = new System.Drawing.Point(126, 144);
            this.lblAdicionaisVisualizar.Name = "lblAdicionaisVisualizar";
            this.lblAdicionaisVisualizar.Size = new System.Drawing.Size(60, 24);
            this.lblAdicionaisVisualizar.TabIndex = 295;
            this.lblAdicionaisVisualizar.Text = "Nome";
            // 
            // lblPrecoAdicionaisVisualizar
            // 
            this.lblPrecoAdicionaisVisualizar.AutoSize = true;
            this.lblPrecoAdicionaisVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoAdicionaisVisualizar.Location = new System.Drawing.Point(104, 235);
            this.lblPrecoAdicionaisVisualizar.Name = "lblPrecoAdicionaisVisualizar";
            this.lblPrecoAdicionaisVisualizar.Size = new System.Drawing.Size(82, 24);
            this.lblPrecoAdicionaisVisualizar.TabIndex = 294;
            this.lblPrecoAdicionaisVisualizar.Text = "Preço ($)";
            // 
            // lblCustoAdicionaisVisualizar
            // 
            this.lblCustoAdicionaisVisualizar.AutoSize = true;
            this.lblCustoAdicionaisVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoAdicionaisVisualizar.Location = new System.Drawing.Point(100, 193);
            this.lblCustoAdicionaisVisualizar.Name = "lblCustoAdicionaisVisualizar";
            this.lblCustoAdicionaisVisualizar.Size = new System.Drawing.Size(86, 24);
            this.lblCustoAdicionaisVisualizar.TabIndex = 292;
            this.lblCustoAdicionaisVisualizar.Text = "Custo ($)";
            // 
            // lblImagemAdicionaisVisualizar
            // 
            this.lblImagemAdicionaisVisualizar.AutoSize = true;
            this.lblImagemAdicionaisVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagemAdicionaisVisualizar.Location = new System.Drawing.Point(109, 288);
            this.lblImagemAdicionaisVisualizar.Name = "lblImagemAdicionaisVisualizar";
            this.lblImagemAdicionaisVisualizar.Size = new System.Drawing.Size(77, 24);
            this.lblImagemAdicionaisVisualizar.TabIndex = 290;
            this.lblImagemAdicionaisVisualizar.Text = "Imagem";
            // 
            // imgAdicionalVisualizar1
            // 
            this.imgAdicionalVisualizar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgAdicionalVisualizar1.Location = new System.Drawing.Point(227, 288);
            this.imgAdicionalVisualizar1.Name = "imgAdicionalVisualizar1";
            this.imgAdicionalVisualizar1.Size = new System.Drawing.Size(229, 167);
            this.imgAdicionalVisualizar1.TabIndex = 289;
            this.imgAdicionalVisualizar1.TabStop = false;
            // 
            // lblTituloCadastroAdicionaisVisualizar
            // 
            this.lblTituloCadastroAdicionaisVisualizar.AutoSize = true;
            this.lblTituloCadastroAdicionaisVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastroAdicionaisVisualizar.Location = new System.Drawing.Point(404, 24);
            this.lblTituloCadastroAdicionaisVisualizar.Name = "lblTituloCadastroAdicionaisVisualizar";
            this.lblTituloCadastroAdicionaisVisualizar.Size = new System.Drawing.Size(126, 31);
            this.lblTituloCadastroAdicionaisVisualizar.TabIndex = 273;
            this.lblTituloCadastroAdicionaisVisualizar.Text = "Adicionais";
            // 
            // lblIdAdicionaisVisualizar
            // 
            this.lblIdAdicionaisVisualizar.AutoSize = true;
            this.lblIdAdicionaisVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAdicionaisVisualizar.Location = new System.Drawing.Point(78, 99);
            this.lblIdAdicionaisVisualizar.Name = "lblIdAdicionaisVisualizar";
            this.lblIdAdicionaisVisualizar.Size = new System.Drawing.Size(118, 24);
            this.lblIdAdicionaisVisualizar.TabIndex = 296;
            this.lblIdAdicionaisVisualizar.Text = "ID Adicional";
            // 
            // buttonDeletarCadastroLanchesVisualizar
            // 
            this.buttonDeletarCadastroLanchesVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeletarCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletarCadastroLanchesVisualizar.ForeColor = System.Drawing.Color.Red;
            this.buttonDeletarCadastroLanchesVisualizar.Location = new System.Drawing.Point(737, 400);
            this.buttonDeletarCadastroLanchesVisualizar.Name = "buttonDeletarCadastroLanchesVisualizar";
            this.buttonDeletarCadastroLanchesVisualizar.Size = new System.Drawing.Size(167, 55);
            this.buttonDeletarCadastroLanchesVisualizar.TabIndex = 298;
            this.buttonDeletarCadastroLanchesVisualizar.Text = "Deletar";
            this.buttonDeletarCadastroLanchesVisualizar.UseVisualStyleBackColor = false;
            // 
            // buttonEditarCadastroLanchesVisualizar
            // 
            this.buttonEditarCadastroLanchesVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditarCadastroLanchesVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCadastroLanchesVisualizar.ForeColor = System.Drawing.Color.Gold;
            this.buttonEditarCadastroLanchesVisualizar.Location = new System.Drawing.Point(551, 400);
            this.buttonEditarCadastroLanchesVisualizar.Name = "buttonEditarCadastroLanchesVisualizar";
            this.buttonEditarCadastroLanchesVisualizar.Size = new System.Drawing.Size(167, 55);
            this.buttonEditarCadastroLanchesVisualizar.TabIndex = 297;
            this.buttonEditarCadastroLanchesVisualizar.Text = "Editar";
            this.buttonEditarCadastroLanchesVisualizar.UseVisualStyleBackColor = false;
            // 
            // CadastroAdicionaisVisualizar
            // 
            this.ClientSize = new System.Drawing.Size(929, 513);
            this.Controls.Add(this.buttonDeletarCadastroLanchesVisualizar);
            this.Controls.Add(this.buttonEditarCadastroLanchesVisualizar);
            this.Controls.Add(this.lblIdAdicionaisVisualizar);
            this.Controls.Add(this.lblAdicionaisVisualizar);
            this.Controls.Add(this.lblPrecoAdicionaisVisualizar);
            this.Controls.Add(this.lblCustoAdicionaisVisualizar);
            this.Controls.Add(this.lblImagemAdicionaisVisualizar);
            this.Controls.Add(this.imgAdicionalVisualizar1);
            this.Controls.Add(this.lblTituloCadastroAdicionaisVisualizar);
            this.Name = "CadastroAdicionaisVisualizar";
            ((System.ComponentModel.ISupportInitialize)(this.imgAdicionalVisualizar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
