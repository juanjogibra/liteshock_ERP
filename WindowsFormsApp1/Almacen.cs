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
    public partial class Almacen : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Almacen"/> class.
        /// </summary>
        public Almacen()
        {

            InitializeComponent();
        }
        /// <summary>
        /// /// Manejador del cierre de la ventana actual. Nos devuelve a la ventana anterior.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        ///Manejador que nos abre el formulario de pedidos. Tenemos un metodo para la imagen y otro para el texto
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label4_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.ShowDialog(this);

            pedidos.Location = this.Location;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.ShowDialog(this);

            pedidos.Location = this.Location;
        }
    }
}
