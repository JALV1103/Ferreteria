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
            lblTexto = new Label();
            lblEmpleado2 = new Label();
            saveDialog = new SaveFileDialog();
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
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(36, 30);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(50, 20);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "label1";
            // 
            // lblEmpleado2
            // 
            lblEmpleado2.AutoSize = true;
            lblEmpleado2.Location = new Point(42, 84);
            lblEmpleado2.Name = "lblEmpleado2";
            lblEmpleado2.Size = new Size(50, 20);
            lblEmpleado2.TabIndex = 2;
            lblEmpleado2.Text = "label1";
            // 
            // saveDialog
            // 
            saveDialog.DefaultExt = "xlsx";
            saveDialog.FileName = "planillaExcel";
            saveDialog.Filter = "Archivo de Excel 2007+ |*.xlsx";
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 215);
            Controls.Add(lblEmpleado2);
            Controls.Add(lblTexto);
            Controls.Add(btnExportar);
            Name = "Empleado";
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExportar;
        private Label lblTexto;
        private Label lblEmpleado2;
        private SaveFileDialog saveDialog;
    }
}