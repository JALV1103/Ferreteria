namespace Ferreteria
{
    partial class Empleado
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
            btnExportar = new Button();
            lblEmpleado1 = new Label();
            lblEmpleado2 = new Label();
            saveDialog = new SaveFileDialog();
            lblEmpleado3 = new Label();
            lblEmpleado4 = new Label();
            lblEmpleado5 = new Label();
            lblEmpleado6 = new Label();
            SuspendLayout();
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(430, 30);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 29);
            btnExportar.TabIndex = 0;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click_1;
            // 
            // lblEmpleado1
            // 
            lblEmpleado1.AutoSize = true;
            lblEmpleado1.Location = new Point(36, 30);
            lblEmpleado1.Name = "lblEmpleado1";
            lblEmpleado1.Size = new Size(50, 20);
            lblEmpleado1.TabIndex = 1;
            lblEmpleado1.Text = "label1";
            // 
            // lblEmpleado2
            // 
            lblEmpleado2.AutoSize = true;
            lblEmpleado2.Location = new Point(36, 75);
            lblEmpleado2.Name = "lblEmpleado2";
            lblEmpleado2.Size = new Size(89, 20);
            lblEmpleado2.TabIndex = 2;
            lblEmpleado2.Text = "Empleado 2";
            // 
            // saveDialog
            // 
            saveDialog.DefaultExt = "xlsx";
            saveDialog.FileName = "planillaExcel";
            saveDialog.Filter = "Archivo de Excel 2007+ |*.xlsx";
            // 
            // lblEmpleado3
            // 
            lblEmpleado3.AutoSize = true;
            lblEmpleado3.Location = new Point(36, 120);
            lblEmpleado3.Name = "lblEmpleado3";
            lblEmpleado3.Size = new Size(89, 20);
            lblEmpleado3.TabIndex = 3;
            lblEmpleado3.Text = "Empleado 3";
            // 
            // lblEmpleado4
            // 
            lblEmpleado4.AutoSize = true;
            lblEmpleado4.Location = new Point(36, 157);
            lblEmpleado4.Name = "lblEmpleado4";
            lblEmpleado4.Size = new Size(89, 20);
            lblEmpleado4.TabIndex = 4;
            lblEmpleado4.Text = "Empleado 4";
            // 
            // lblEmpleado5
            // 
            lblEmpleado5.AutoSize = true;
            lblEmpleado5.Location = new Point(36, 195);
            lblEmpleado5.Name = "lblEmpleado5";
            lblEmpleado5.Size = new Size(89, 20);
            lblEmpleado5.TabIndex = 5;
            lblEmpleado5.Text = "Empleado 5";
            // 
            // lblEmpleado6
            // 
            lblEmpleado6.AutoSize = true;
            lblEmpleado6.Location = new Point(36, 232);
            lblEmpleado6.Name = "lblEmpleado6";
            lblEmpleado6.Size = new Size(89, 20);
            lblEmpleado6.TabIndex = 6;
            lblEmpleado6.Text = "Empleado 6";
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 365);
            Controls.Add(lblEmpleado6);
            Controls.Add(lblEmpleado5);
            Controls.Add(lblEmpleado4);
            Controls.Add(lblEmpleado3);
            Controls.Add(lblEmpleado2);
            Controls.Add(lblEmpleado1);
            Controls.Add(btnExportar);
            Name = "Empleado";
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExportar;
        private Label lblEmpleado1;
        private Label lblEmpleado2;
        private SaveFileDialog saveDialog;
        private Label lblEmpleado3;
        private Label lblEmpleado4;
        private Label lblEmpleado5;
        private Label lblEmpleado6;
    }
}