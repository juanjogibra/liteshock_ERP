using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Clientes : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clientes"/> class.
        /// </summary>
        public Clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Manejador del cierre de la ventana actual. Nos devuelve a la ventana anterior.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// Metodos Manejador para las distintas formas de acceder a los elementos de la ventana
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormularioClientes formularioclientes = new FormularioClientes();
            formularioclientes.ShowDialog(this);

            formularioclientes.Location = this.Location;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormularioClientes formularioclientes = new FormularioClientes();
            formularioclientes.ShowDialog(this);

            formularioclientes.Location = this.Location;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            infoClientes info = new infoClientes();
            info.ShowDialog(this);

            info.Location = this.Location;
        }
       

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            infoClientes info = new infoClientes();
            info.ShowDialog(this);

            info.Location = this.Location;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
