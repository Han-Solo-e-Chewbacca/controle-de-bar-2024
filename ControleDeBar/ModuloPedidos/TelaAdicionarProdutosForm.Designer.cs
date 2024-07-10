namespace ControleDeBar.ModuloProduto
{
    partial class TelaAdicionarProdutosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            listProdutos = new CheckedListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            label3 = new Label();
            txtVT = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listProdutos);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(728, 334);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // listProdutos
            // 
            listProdutos.CheckOnClick = true;
            listProdutos.Dock = DockStyle.Fill;
            listProdutos.FormattingEnabled = true;
            listProdutos.Location = new Point(3, 23);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(722, 308);
            listProdutos.TabIndex = 0;
            listProdutos.SelectedIndexChanged += listProdutos_SelectedIndexChanged_3;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(646, 395);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 46);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(546, 395);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 46);
            btnGravar.TabIndex = 15;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 356);
            label3.Name = "label3";
            label3.Size = new Size(297, 28);
            label3.TabIndex = 19;
            label3.Text = "Valor dos Produtos Adicionados:";
            // 
            // txtVT
            // 
            txtVT.Enabled = false;
            txtVT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVT.Location = new Point(669, 346);
            txtVT.Name = "txtVT";
            txtVT.Size = new Size(71, 38);
            txtVT.TabIndex = 18;
            txtVT.Text = "0";
            // 
            // TelaAdicionarProdutosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 450);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtVT);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAdicionarProdutosForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Produtos";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckedListBox listProdutos;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label3;
        private TextBox txtVT;
    }
}