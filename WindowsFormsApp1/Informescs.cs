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
    public partial class Informescs : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Informescs"/> class.
        /// </summary>
        public Informescs()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Manejador del cierre de la ventana actual. Nos devuelve a la ventana anterior.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// Metodos que nos permiten consultar los informes que tenemos en nuestro ERP
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label4_Click(object sender, EventArgs e)
        {
            InformeClientes informeclientes = new InformeClientes();
            informeclientes.ShowDialog(this);

            informeclientes.Location = this.Location;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            InformeClientes informeclientes = new InformeClientes();
            informeclientes.ShowDialog(this);

            informeclientes.Location = this.Location;
        }

        private void label2_Click(object sender, EventArgs e)
        {

            InformeFacturas informefacturas = new InformeFacturas();
            informefacturas.ShowDialog(this);

            informefacturas.Location = this.Location;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            InformeFacturas informefacturas = new InformeFacturas();
            informefacturas.ShowDialog(this);

            informefacturas.Location = this.Location;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            VentasTotales ventastotal = new VentasTotales();
            ventastotal.ShowDialog(this);

            ventastotal.Location = this.Location;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            VentasTotales ventastotal = new VentasTotales();
            ventastotal.ShowDialog(this);

            ventastotal.Location = this.Location;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            InformesTodasFacturas todas = new InformesTodasFacturas();
            todas.ShowDialog(this);

            todas.Location = this.Location;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            InformesTodasFacturas todas = new InformesTodasFacturas();
            todas.ShowDialog(this);

            todas.Location = this.Location;
        }
    }
}
