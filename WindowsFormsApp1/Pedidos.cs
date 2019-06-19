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
    public partial class Pedidos : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pedidos"/> class.
        /// </summary>
        public Pedidos()
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
        /// Handles the Click event of the pedidoBindingNavigatorSaveItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.erpDataSet2);

        }
        /// <summary>
        /// Handles the Load event of the Pedidos control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Pedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'erpDataSet2.pedido' Puede moverla o quitarla según sea necesario.
            this.pedidoTableAdapter.Fill(this.erpDataSet2.pedido);

        }
    }
}
