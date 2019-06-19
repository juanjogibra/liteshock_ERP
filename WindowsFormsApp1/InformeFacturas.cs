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
    public partial class InformeFacturas : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InformeFacturas"/> class.
        /// </summary>
        public InformeFacturas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Load event of the InformeFacturas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void InformeFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet4.DataTable1' Puede moverla o quitarla según sea necesario.
           



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

        private void selector_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the consultar control. El textbox nos permite de filtrar por id de factura
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void consultar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(select.Text);
            this.DataTable1TableAdapter.Fill(this.DataSet4.DataTable1, x);
            this.reportViewer1.RefreshReport();

        }
    }
}
