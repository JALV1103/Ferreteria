namespace Ferreteria
{
    partial class Seguridad
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
            groupBox1 = new GroupBox();
            btwSalir = new Button();
            btwIngresar = new Button();
            btwLimpiar = new Button();
            txtBoxContra = new TextBox();
            txtBoxLogin = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Sarabun", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(167, 26);
            label1.Name = "label1";
            label1.Size = new Size(109, 45);
            label1.TabIndex = 0;
            label1.Text = "ACCESO";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btwSalir);
            groupBox1.Controls.Add(btwIngresar);
            groupBox1.Controls.Add(btwLimpiar);
            groupBox1.Controls.Add(txtBoxContra);
            groupBox1.Controls.Add(txtBoxLogin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sarabun", 10F, FontStyle.Italic);
            groupBox1.Location = new Point(30, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 286);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese su usuario y contraseña";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btwSalir
            // 
            btwSalir.BackColor = SystemColors.ActiveCaption;
            btwSalir.Cursor = Cursors.Hand;
            btwSalir.FlatStyle = FlatStyle.System;
            btwSalir.Font = new Font("Sarabun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btwSalir.ForeColor = SystemColors.ActiveCaption;
            btwSalir.Location = new Point(287, 223);
            btwSalir.Name = "btwSalir";
            btwSalir.Size = new Size(68, 32);
            btwSalir.TabIndex = 6;
            btwSalir.Text = "Salir";
            btwSalir.UseVisualStyleBackColor = false;
            btwSalir.Click += btwSalir_Click;
            // 
            // btwIngresar
            // 
            btwIngresar.BackColor = SystemColors.ActiveCaption;
            btwIngresar.Cursor = Cursors.Hand;
            btwIngresar.FlatStyle = FlatStyle.System;
            btwIngresar.Font = new Font("Sarabun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btwIngresar.ForeColor = SystemColors.ActiveCaption;
            btwIngresar.Location = new Point(138, 223);
            btwIngresar.Name = "btwIngresar";
            btwIngresar.Size = new Size(118, 32);
            btwIngresar.TabIndex = 5;
            btwIngresar.Text = "Ingresar";
            btwIngresar.UseVisualStyleBackColor = false;
            btwIngresar.Click += btwIngresar_Click;
            // 
            // btwLimpiar
            // 
            btwLimpiar.BackColor = SystemColors.ActiveCaption;
            btwLimpiar.Cursor = Cursors.Hand;
            btwLimpiar.FlatStyle = FlatStyle.System;
            btwLimpiar.Font = new Font("Sarabun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btwLimpiar.ForeColor = SystemColors.ActiveCaption;
            btwLimpiar.Location = new Point(38, 223);
            btwLimpiar.Name = "btwLimpiar";
            btwLimpiar.Size = new Size(68, 32);
            btwLimpiar.TabIndex = 4;
            btwLimpiar.Text = "Limpiar";
            btwLimpiar.UseVisualStyleBackColor = false;
            btwLimpiar.Click += btwLimpiar_Click;
            // 
            // txtBoxContra
            // 
            txtBoxContra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxContra.ForeColor = SystemColors.WindowFrame;
            txtBoxContra.Location = new Point(38, 163);
            txtBoxContra.Name = "txtBoxContra";
            txtBoxContra.PasswordChar = '*';
            txtBoxContra.Size = new Size(317, 25);
            txtBoxContra.TabIndex = 3;
            txtBoxContra.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxLogin.ForeColor = SystemColors.WindowFrame;
            txtBoxLogin.Location = new Point(38, 84);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(317, 25);
            txtBoxLogin.TabIndex = 2;
            txtBoxLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Sarabun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(145, 130);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 1;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Sarabun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(159, 51);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // Seguridad
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(447, 429);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Seguridad";
            Text = "Seguridad Login y Password";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button btwLimpiar;
        private TextBox txtBoxContra;
        private TextBox txtBoxLogin;
        private Button btwSalir;
        private Button btwIngresar;
    }
}