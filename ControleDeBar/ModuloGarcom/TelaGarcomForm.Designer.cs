namespace ControleDeBar.ModuloGarcom
{
    partial class TelaGarcomForm
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
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            btnGravar = new Button();
            Cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 36);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(104, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(56, 27);
            txtId.TabIndex = 2;
            txtId.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(104, 85);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(502, 27);
            txtNome.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(380, 118);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(110, 46);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // Cancelar
            // 
            Cancelar.DialogResult = DialogResult.Cancel;
            Cancelar.Location = new Point(496, 118);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(110, 46);
            Cancelar.TabIndex = 5;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // TelaGarcomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 174);
            Controls.Add(Cancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaGarcomForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Garçom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNome;
        private Button btnGravar;
        private Button Cancelar;
    }
}