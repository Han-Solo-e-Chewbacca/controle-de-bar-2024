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
            btnRemover = new Button();
            btnAdicionar = new Button();
            listProdutos = new ListBox();
            cbProdutos = new ComboBox();
            numQTD = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            listBox1 = new ListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            label3 = new Label();
            txtVT = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQTD).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(listProdutos);
            groupBox1.Controls.Add(cbProdutos);
            groupBox1.Controls.Add(numQTD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(728, 338);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(601, 51);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(101, 29);
            btnRemover.TabIndex = 30;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(601, 21);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(101, 29);
            btnAdicionar.TabIndex = 29;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listProdutos
            // 
            listProdutos.FormattingEnabled = true;
            listProdutos.Location = new Point(0, 85);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(728, 244);
            listProdutos.TabIndex = 28;
            // 
            // cbProdutos
            // 
            cbProdutos.FormattingEnabled = true;
            cbProdutos.Location = new Point(136, 22);
            cbProdutos.Name = "cbProdutos";
            cbProdutos.Size = new Size(391, 28);
            cbProdutos.TabIndex = 25;
            // 
            // numQTD
            // 
            numQTD.Location = new Point(136, 51);
            numQTD.Name = "numQTD";
            numQTD.Size = new Size(52, 27);
            numQTD.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 50);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 23;
            label5.Text = "Quantidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 22);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 22;
            label6.Text = "Produto:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(728, 244);
            listBox1.TabIndex = 0;
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
            label3.Location = new Point(546, 351);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 19;
            label3.Text = "Valor Total:";
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
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQTD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label3;
        private TextBox txtVT;
        private ListBox listBox1;
        private ListBox listProdutos;
        private ComboBox cbProdutos;
        private NumericUpDown numQTD;
        private Label label5;
        private Label label6;
        private Button btnRemover;
        private Button btnAdicionar;
    }
}