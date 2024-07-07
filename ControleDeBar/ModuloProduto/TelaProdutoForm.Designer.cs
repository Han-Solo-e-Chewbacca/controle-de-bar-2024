namespace ControleDeBar.ModuloProduto
{
    partial class TelaProdutoForm
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
            txtId = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPreco = new NumericUpDown();
            textBox1 = new TextBox();
            txtNome = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)txtPreco).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(49, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(33, 28);
            txtId.TabIndex = 0;
            txtId.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 80);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 2;
            label1.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.DecimalPlaces = 2;
            txtPreco.Location = new Point(87, 85);
            txtPreco.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(75, 27);
            txtPreco.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(88, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(87, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(484, 27);
            txtNome.TabIndex = 5;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(345, 123);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(110, 46);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(461, 123);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 46);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 181);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtNome);
            Controls.Add(textBox1);
            Controls.Add(txtPreco);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaProdutoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)txtPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtId;
        private Label label2;
        private Label label1;
        private NumericUpDown txtPreco;
        private TextBox textBox1;
        private TextBox txtNome;
        private Button btnGravar;
        private Button btnCancelar;
    }
}