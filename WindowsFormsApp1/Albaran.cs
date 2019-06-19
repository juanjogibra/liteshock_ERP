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
    public partial class Albaran : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Albaran"/> class.
        /// </summary>
        public Albaran()
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
        /// Handles the Click event of the productosBindingNavigatorSaveItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.erpDataSet1);
            if (!String.IsNullOrEmpty(idTextBox.Text)&& !String.IsNullOrEmpty(nombreTextBox.Text)&& !String.IsNullOrEmpty(categoriaTextBox.Text) && !String.IsNullOrEmpty(descripcionTextBox.Text))
                MessageBox.Show("Datos de albarán creados.");

        }
        /// <summary>
        /// Handles the 1 event of the productosBindingNavigatorSaveItem_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void productosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.erpDataSet1);

        }
        /// <summary>
        /// Handles the Load event of the Albaran control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Albaran_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'erpDataSet1.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.erpDataSet1.productos);

        }
    }
}
