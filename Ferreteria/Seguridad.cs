using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class Seguridad : Form
    {
        public class Din
        {
            // Se utiliza Din como directorio acumulable
            public string usuario { get; set; }
            public string contra { get; set; }
        }
        public Seguridad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btwIngresar_Click(object sender, EventArgs e)
        {
            Din myDin = new Din();
            myDin.usuario = txtBoxLogin.Text;
            myDin.contra = txtBoxContra.Text;

            // Se procede a condicionar 
            if (myDin.usuario == "Admin" && myDin.contra == "Admin")
            {
                Main main = new Main();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void btwLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxLogin.Text = "";
            txtBoxContra.Text = "";
        }

        private void btwSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
