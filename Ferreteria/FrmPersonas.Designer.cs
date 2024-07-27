namespace Ferreteria
{
    partial class FrmPersonas
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridPersonas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            bindingSrc = new BindingSource(components);
            btnNuevoContacto = new Button();
            btnEditarContacto = new Button();
            btnEliminarContacto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSrc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 28);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 0;
            label1.Text = "Contacto de los clientes";
            // 
            // dataGridPersonas
            // 
            dataGridPersonas.AllowUserToAddRows = false;
            dataGridPersonas.AllowUserToDeleteRows = false;
            dataGridPersonas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPersonas.AutoGenerateColumns = false;
            dataGridPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPersonas.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Direccion, Telefono });
            dataGridPersonas.DataSource = bindingSrc;
            dataGridPersonas.Location = new Point(27, 71);
            dataGridPersonas.Name = "dataGridPersonas";
            dataGridPersonas.ReadOnly = true;
            dataGridPersonas.RowHeadersWidth = 51;
            dataGridPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPersonas.Size = new Size(799, 446);
            dataGridPersonas.TabIndex = 1;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Name";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // btnNuevoContacto
            // 
            btnNuevoContacto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevoContacto.Location = new Point(532, 523);
            btnNuevoContacto.Name = "btnNuevoContacto";
            btnNuevoContacto.Size = new Size(94, 29);
            btnNuevoContacto.TabIndex = 2;
            btnNuevoContacto.Text = "Nuevo";
            btnNuevoContacto.UseVisualStyleBackColor = true;
            btnNuevoContacto.Click += btnNuevoContacto_Click;
            // 
            // btnEditarContacto
            // 
            btnEditarContacto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditarContacto.Location = new Point(632, 523);
            btnEditarContacto.Name = "btnEditarContacto";
            btnEditarContacto.Size = new Size(94, 29);
            btnEditarContacto.TabIndex = 3;
            btnEditarContacto.Text = "Editar";
            btnEditarContacto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarContacto
            // 
            btnEliminarContacto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminarContacto.Location = new Point(732, 523);
            btnEliminarContacto.Name = "btnEliminarContacto";
            btnEliminarContacto.Size = new Size(94, 29);
            btnEliminarContacto.TabIndex = 4;
            btnEliminarContacto.Text = "Eliminar";
            btnEliminarContacto.UseVisualStyleBackColor = true;
            // 
            // FrmPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 561);
            Controls.Add(btnEliminarContacto);
            Controls.Add(btnEditarContacto);
            Controls.Add(btnNuevoContacto);
            Controls.Add(dataGridPersonas);
            Controls.Add(label1);
            Name = "FrmPersonas";
            Text = "FrmPersonas";
            ((System.ComponentModel.ISupportInitialize)dataGridPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSrc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridPersonas;
        private BindingSource bindingSrc;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private Button btnNuevoContacto;
        private Button btnEditarContacto;
        private Button btnEliminarContacto;
    }
}