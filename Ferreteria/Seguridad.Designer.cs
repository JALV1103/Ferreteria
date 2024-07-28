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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seguridad));
            label1 = new Label();
            groupBox = new GroupBox();
            btnSalir = new Button();
            BtnLimpiar = new Button();
            btnIngresar = new Button();
            txtBoxContra = new TextBox();
            txtBoxLogin = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(160, 19);
            label1.Name = "label1";
            label1.Size = new Size(105, 35);
            label1.TabIndex = 0;
            label1.Text = "ACCESO";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(btnSalir);
            groupBox.Controls.Add(BtnLimpiar);
            groupBox.Controls.Add(btnIngresar);
            groupBox.Controls.Add(txtBoxContra);
            groupBox.Controls.Add(txtBoxLogin);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Location = new Point(32, 75);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(379, 329);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Ingrese su Usuario y Contraseña";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(253, 280);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnLimpiar.Location = new Point(139, 280);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(94, 29);
            BtnLimpiar.TabIndex = 4;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIngresar.Location = new Point(18, 280);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtBoxContra
            // 
            txtBoxContra.Location = new Point(35, 176);
            txtBoxContra.Name = "txtBoxContra";
            txtBoxContra.PasswordChar = '*';
            txtBoxContra.Size = new Size(312, 27);
            txtBoxContra.TabIndex = 2;
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Location = new Point(35, 89);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(312, 27);
            txtBoxLogin.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 153);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 57);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // Seguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 424);
            Controls.Add(groupBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Seguridad";
            Text = "Seguridad";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox;
        private Label label3;
        private Label label2;
        private TextBox txtBoxLogin;
        private Button btnSalir;
        private Button BtnLimpiar;
        private Button btnIngresar;
        private TextBox txtBoxContra;
    }
}