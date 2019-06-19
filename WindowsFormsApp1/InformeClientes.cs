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
    public partial class InformeClientes : Form
    {
        public InformeClientes()
        {
            InitializeComponent();
        }

        private void InformeClientes_Load(object sender, EventArgs e)
        {
            
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
        /// Handles the Click event of the generador control. El textbox nos permite filtrar por id de cliente
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void generador_Click(object sender, EventArgs e)
        {
            int cli = Convert.ToInt32(selector.Text);
            // TODO: esta línea de código carga datos en la tabla 'DataSet3.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSet3.DataTable1, cli);

            this.reportViewer1.RefreshReport();
        }

        private void selector_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
