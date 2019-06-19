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
    public partial class infoClientes : Form
    {
        public infoClientes()
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
        /// Handles the Click event of the clientesBindingNavigatorSaveItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.erpDataSetFeb);

        }
        /// <summary>
        /// Handles the Load event of the infoClientes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void infoClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'erpDataSetFeb.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.erpDataSetFeb.clientes);

        }
    }
}
