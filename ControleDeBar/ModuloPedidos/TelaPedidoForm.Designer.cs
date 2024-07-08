namespace ControleDeBar.ModuloPedidos
{
    partial class TelaPedidoForm
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
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            cbMesa = new ComboBox();
            cbGarcom = new ComboBox();
            groupBox1 = new GroupBox();
            listProdutos = new CheckedListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(114, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(89, 27);
            txtId.TabIndex = 0;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 25);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 69);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 3;
            label2.Text = "Mesa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 105);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 5;
            label4.Text = "Garçom:";
            // 
            // cbMesa
            // 
            cbMesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMesa.FormattingEnabled = true;
            cbMesa.Location = new Point(114, 73);
            cbMesa.Name = "cbMesa";
            cbMesa.Size = new Size(151, 28);
            cbMesa.TabIndex = 6;
            cbMesa.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbGarcom
            // 
            cbGarcom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGarcom.FormattingEnabled = true;
            cbGarcom.Location = new Point(114, 109);
            cbGarcom.Name = "cbGarcom";
            cbGarcom.Size = new Size(151, 28);
            cbGarcom.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listProdutos);
            groupBox1.Location = new Point(23, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(728, 324);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedidos:";
            // 
            // listProdutos
            // 
            listProdutos.Dock = DockStyle.Fill;
            listProdutos.FormattingEnabled = true;
            listProdutos.Items.AddRange(new object[] { "" });
            listProdutos.Location = new Point(3, 23);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(722, 298);
            listProdutos.TabIndex = 0;
            listProdutos.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(653, 497);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 46);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(537, 497);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(110, 46);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaPedidoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 555);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(cbGarcom);
            Controls.Add(cbMesa);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPedidoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Pedido";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox cbMesa;
        private ComboBox cbGarcom;
        private GroupBox groupBox1;
        private CheckedListBox listProdutos;
        private Button btnCancelar;
        private Button btnGravar;
    }
}