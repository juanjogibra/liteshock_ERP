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
    
    public partial class Form2 : Form
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Form2"/> class.
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the FormClosing event of the Form2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.ControlBox = false;


        }
        /// <summary>
        /// Handles the Click event of the label2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label2_Click(object sender, EventArgs e)
        {
            Albaran albaran = new Albaran();
            albaran.ShowDialog(this);

            albaran.Location = this.Location;
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Manejador que abre el formulario de facturas.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label4_Click(object sender, EventArgs e)
        {
            Facturas factura = new Facturas();
            factura.ShowDialog(this);

            factura.Location = this.Location;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Facturas factura = new Facturas();
            factura.ShowDialog(this);

            factura.Location = this.Location;
        }
    }
}
