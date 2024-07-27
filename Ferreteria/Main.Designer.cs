﻿namespace Ferreteria
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            ferreteriasToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            personasToolStripMenuItem = new ToolStripMenuItem();
            herramientasToolStripMenuItem = new ToolStripMenuItem();
            aPIToolStripMenuItem = new ToolStripMenuItem();
            ventanasToolStripMenuItem = new ToolStripMenuItem();
            nuevaVentanaToolStripMenuItem = new ToolStripMenuItem();
            cascadaToolStripMenuItem = new ToolStripMenuItem();
            mosaicosVerticalesToolStripMenuItem = new ToolStripMenuItem();
            mosaicosHorizToolStripMenuItem = new ToolStripMenuItem();
            cerrarTodoToolStripMenuItem = new ToolStripMenuItem();
            organizarIconosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, mantenimientosToolStripMenuItem, herramientasToolStripMenuItem, ventanasToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(912, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ferreteriasToolStripMenuItem, empleadosToolStripMenuItem, personasToolStripMenuItem });
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(130, 24);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // ferreteriasToolStripMenuItem
            // 
            ferreteriasToolStripMenuItem.Name = "ferreteriasToolStripMenuItem";
            ferreteriasToolStripMenuItem.Size = new Size(166, 26);
            ferreteriasToolStripMenuItem.Text = "Ferreterias";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(166, 26);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new Size(166, 26);
            personasToolStripMenuItem.Text = "Personas";
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aPIToolStripMenuItem });
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Size = new Size(112, 24);
            herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // aPIToolStripMenuItem
            // 
            aPIToolStripMenuItem.Name = "aPIToolStripMenuItem";
            aPIToolStripMenuItem.Size = new Size(114, 26);
            aPIToolStripMenuItem.Text = "API";
            // 
            // ventanasToolStripMenuItem
            // 
            ventanasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaVentanaToolStripMenuItem, cascadaToolStripMenuItem, mosaicosVerticalesToolStripMenuItem, mosaicosHorizToolStripMenuItem, cerrarTodoToolStripMenuItem, organizarIconosToolStripMenuItem });
            ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            ventanasToolStripMenuItem.Size = new Size(82, 24);
            ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // nuevaVentanaToolStripMenuItem
            // 
            nuevaVentanaToolStripMenuItem.Name = "nuevaVentanaToolStripMenuItem";
            nuevaVentanaToolStripMenuItem.Size = new Size(228, 26);
            nuevaVentanaToolStripMenuItem.Text = "Nueva Ventana";
            nuevaVentanaToolStripMenuItem.Click += nuevaVentanaToolStripMenuItem_Click;
            // 
            // cascadaToolStripMenuItem
            // 
            cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            cascadaToolStripMenuItem.Size = new Size(228, 26);
            cascadaToolStripMenuItem.Text = "Cascada";
            cascadaToolStripMenuItem.Click += cascadaToolStripMenuItem_Click;
            // 
            // mosaicosVerticalesToolStripMenuItem
            // 
            mosaicosVerticalesToolStripMenuItem.Name = "mosaicosVerticalesToolStripMenuItem";
            mosaicosVerticalesToolStripMenuItem.Size = new Size(228, 26);
            mosaicosVerticalesToolStripMenuItem.Text = "Mosaicos Vertical";
            mosaicosVerticalesToolStripMenuItem.Click += mosaicosVerticalesToolStripMenuItem_Click;
            // 
            // mosaicosHorizToolStripMenuItem
            // 
            mosaicosHorizToolStripMenuItem.Name = "mosaicosHorizToolStripMenuItem";
            mosaicosHorizToolStripMenuItem.Size = new Size(228, 26);
            mosaicosHorizToolStripMenuItem.Text = "Mosaicos Horizontal";
            mosaicosHorizToolStripMenuItem.Click += mosaicosHorizToolStripMenuItem_Click;
            // 
            // cerrarTodoToolStripMenuItem
            // 
            cerrarTodoToolStripMenuItem.Name = "cerrarTodoToolStripMenuItem";
            cerrarTodoToolStripMenuItem.Size = new Size(228, 26);
            cerrarTodoToolStripMenuItem.Text = "Cerrar Todo";
            cerrarTodoToolStripMenuItem.Click += cerrarTodoToolStripMenuItem_Click;
            // 
            // organizarIconosToolStripMenuItem
            // 
            organizarIconosToolStripMenuItem.Name = "organizarIconosToolStripMenuItem";
            organizarIconosToolStripMenuItem.Size = new Size(228, 26);
            organizarIconosToolStripMenuItem.Text = "Organizar Iconos";
            organizarIconosToolStripMenuItem.Click += organizarIconosToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 482);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(912, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.Control;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(54, 20);
            toolStripStatusLabel1.Text = "Estado";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(912, 508);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Main";
            Text = "Ferreteria";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem ventanasToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ferreteriasToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem personasToolStripMenuItem;
        private ToolStripMenuItem aPIToolStripMenuItem;
        private ToolStripMenuItem nuevaVentanaToolStripMenuItem;
        private ToolStripMenuItem cascadaToolStripMenuItem;
        private ToolStripMenuItem mosaicosVerticalesToolStripMenuItem;
        private ToolStripMenuItem mosaicosHorizToolStripMenuItem;
        private ToolStripMenuItem cerrarTodoToolStripMenuItem;
        private ToolStripMenuItem organizarIconosToolStripMenuItem;
    }
}