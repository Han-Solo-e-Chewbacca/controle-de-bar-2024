namespace ControleDeBar.ModuloMesa
{
    partial class TelaMesaForm
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
            txtMesa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            Cancelar = new Button();
            btnGravar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(99, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(59, 27);
            txtId.TabIndex = 0;
            txtId.Text = "0";
            // 
            // txtMesa
            // 
            txtMesa.Enabled = false;
            txtMesa.Location = new Point(99, 70);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(103, 27);
            txtMesa.TabIndex = 1;
            txtMesa.Text = "Mesa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 23);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 3;
            label2.Text = "Número:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(208, 72);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // Cancelar
            // 
            Cancelar.DialogResult = DialogResult.Cancel;
            Cancelar.Location = new Point(324, 103);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(110, 46);
            Cancelar.TabIndex = 7;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(208, 103);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(110, 46);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaMesaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 161);
            Controls.Add(Cancelar);
            Controls.Add(btnGravar);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMesa);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMesaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Mesa";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtMesa;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button Cancelar;
        private Button btnGravar;
    }
}