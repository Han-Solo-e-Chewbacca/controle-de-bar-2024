namespace ControleDeBar
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            garçomToolStripMenuItem = new ToolStripMenuItem();
            produtos = new ToolStripMenuItem();
            pedidosToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnConfirmar = new ToolStripButton();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1402, 36);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { garçomToolStripMenuItem, produtos, pedidosToolStripMenuItem1 });
            menuToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(76, 32);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // garçomToolStripMenuItem
            // 
            garçomToolStripMenuItem.Name = "garçomToolStripMenuItem";
            garçomToolStripMenuItem.Size = new Size(224, 32);
            garçomToolStripMenuItem.Text = "Garçom";
            garçomToolStripMenuItem.Click += garçomToolStripMenuItem_Click;
            // 
            // produtos
            // 
            produtos.Name = "produtos";
            produtos.Size = new Size(224, 32);
            produtos.Text = "Produtos";
            produtos.Click += produtos_Click;
            // 
            // pedidosToolStripMenuItem1
            // 
            pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            pedidosToolStripMenuItem1.Size = new Size(224, 32);
            pedidosToolStripMenuItem1.Text = "Pedidos";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 675);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1402, 34);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(75, 28);
            statusLabelPrincipal.Text = "rodapé";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, btnConfirmar, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 36);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1402, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(29, 24);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(29, 24);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(29, 24);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConfirmar.Image = Properties.Resources.btnAdicionarItens;
            btnConfirmar.ImageTransparentColor = Color.Magenta;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(29, 24);
            btnConfirmar.Text = "Confirmar Entrega";
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(0, 24);
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 63);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(1402, 612);
            pnlRegistros.TabIndex = 4;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 709);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Bar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem garçomToolStripMenuItem;
        private ToolStripMenuItem produtos;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripButton btnConfirmar;
        private Panel pnlRegistros;
        private ToolStripMenuItem pedidosToolStripMenuItem1;
        private ToolStripLabel lblTipoCadastro;
    }
}
