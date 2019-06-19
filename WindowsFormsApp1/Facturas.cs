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
    public partial class Facturas : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Facturas"/> class.
        /// </summary>
        public Facturas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Click event of the ventasBindingNavigatorSaveItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          
            this.tableAdapterManager.UpdateAll(this.erpDataSetFeb);

        }
        /// <summary>
        /// Handles the 1 event of the ventasBindingNavigatorSaveItem_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ventasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
           
            this.tableAdapterManager.UpdateAll(this.erpDataSetFeb);

        }
        /// <summary>
        /// Handles the 2 event of the ventasBindingNavigatorSaveItem_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ventasBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
         
            this.tableAdapterManager.UpdateAll(this.erpDataSetFeb);

        }
        /// <summary>
        /// Handles the Load event of the Facturas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Facturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'erpDataSetFeb.lin_facturas' Puede moverla o quitarla según sea necesario.
            this.lin_facturasTableAdapter.Fill(this.erpDataSetFeb.lin_facturas);
            // TODO: esta línea de código carga datos en la tabla 'erpDataSetFeb.facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.erpDataSetFeb.facturas);
            // TODO: esta línea de código carga datos en la tabla 'erpDataSet1.venta' Puede moverla o quitarla según sea necesario.
           

        }
        /// <summary>
        /// Handles the Click event of the ventaBindingNavigatorSaveItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
         
            this.tableAdapterManager.UpdateAll(this.erpDataSetFeb);

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
        /// Handles the Click event of the facturasBindingNavigatorSaveItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void facturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.erpDataSetFeb);

        }
    }
}
