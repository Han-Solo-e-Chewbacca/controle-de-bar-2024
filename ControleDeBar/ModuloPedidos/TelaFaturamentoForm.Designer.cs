namespace ControleDeBar.ModuloProduto
{
    partial class TelaFaturamentoForm
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
            label3 = new Label();
            button1 = new Button();
            txtMes = new TextBox();
            txtSemana = new TextBox();
            txtDia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 35);
            label1.Name = "label1";
            label1.Size = new Size(219, 28);
            label1.TabIndex = 0;
            label1.Text = "Faturamento neste Mês:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 74);
            label2.Name = "label2";
            label2.Size = new Size(290, 28);
            label2.TabIndex = 1;
            label2.Text = "Faturamento dos ultimos 7 dias:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 115);
            label3.Name = "label3";
            label3.Size = new Size(188, 28);
            label3.TabIndex = 2;
            label3.Text = "Faturamento do dia:";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(293, 176);
            button1.Name = "button1";
            button1.Size = new Size(141, 41);
            button1.TabIndex = 3;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtMes
            // 
            txtMes.Enabled = false;
            txtMes.Location = new Point(309, 39);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(125, 27);
            txtMes.TabIndex = 4;
            txtMes.Text = "0";
            // 
            // txtSemana
            // 
            txtSemana.Enabled = false;
            txtSemana.Location = new Point(309, 78);
            txtSemana.Name = "txtSemana";
            txtSemana.Size = new Size(125, 27);
            txtSemana.TabIndex = 5;
            txtSemana.Text = "0";
            // 
            // txtDia
            // 
            txtDia.Enabled = false;
            txtDia.Location = new Point(309, 116);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(125, 27);
            txtDia.TabIndex = 6;
            txtDia.Text = "0";
            // 
            // TelaFaturamentoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 234);
            Controls.Add(txtDia);
            Controls.Add(txtSemana);
            Controls.Add(txtMes);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFaturamentoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Visualização de Faturamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtMes;
        private TextBox txtSemana;
        private TextBox txtDia;
    }
}