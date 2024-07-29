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
            label1.Font = new Font("Sarabun", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 37);
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
            groupBox.Font = new Font("Sarabun", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(28, 56);
            groupBox.Margin = new Padding(3, 2, 3, 2);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 2, 3, 2);
            groupBox.Size = new Size(332, 247);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Ingrese su Usuario y Contraseña";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(221, 199);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 33);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnLimpiar.Location = new Point(34, 199);
            BtnLimpiar.Margin = new Padding(3, 2, 3, 2);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(82, 33);
            BtnLimpiar.TabIndex = 4;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIngresar.BackColor = SystemColors.ControlLightLight;
            btnIngresar.ForeColor = SystemColors.ActiveCaptionText;
            btnIngresar.Location = new Point(122, 199);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(93, 33);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtBoxContra
            // 
            txtBoxContra.Location = new Point(31, 132);
            txtBoxContra.Margin = new Padding(3, 2, 3, 2);
            txtBoxContra.Name = "txtBoxContra";
            txtBoxContra.PasswordChar = '*';
            txtBoxContra.Size = new Size(274, 23);
            txtBoxContra.TabIndex = 2;
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Location = new Point(31, 67);
            txtBoxLogin.Margin = new Padding(3, 2, 3, 2);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(274, 23);
            txtBoxLogin.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 108);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 0;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 43);
            label2.Name = "label2";
            label2.Size = new Size(50, 22);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // Seguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(386, 318);
            Controls.Add(groupBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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