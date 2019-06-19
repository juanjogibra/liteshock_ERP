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
    public partial class FormularioClientes : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormularioClientes"/> class.
        /// </summary>
        public FormularioClientes()
        {
            InitializeComponent();
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
            if (!String.IsNullOrEmpty(idTextBox.Text) && !String.IsNullOrEmpty(nombreTextBox.Text) && !String.IsNullOrEmpty(apellidosTextBox.Text) && !String.IsNullOrEmpty(dNITextBox.Text) && !String.IsNullOrEmpty(telefonoTextBox.Text) && !String.IsNullOrEmpty(domicilioTextBox.Text) && !String.IsNullOrEmpty(localidadTextBox.Text) && !String.IsNullOrEmpty(correoTextBox.Text) && !String.IsNullOrEmpty(fechaDateTimePicker.Text))
                MessageBox.Show("Cliente creado.");

        }
        /// <summary>
        /// Handles the Load event of the FormularioClientes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'erpDataSetFeb.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.erpDataSetFeb.clientes);
            // TODO: esta línea de código carga datos en la tabla 'erpDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.erpDataSetFeb.clientes);
            // TODO: esta línea de código carga datos en la tabla 'erpDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.erpDataSetFeb.clientes);
            // TODO: esta línea de código carga datos en la tabla 'erpDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.erpDataSetFeb.clientes);

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
        /// Handles the 1 event of the clientesBindingNavigatorSaveItem_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.erpDataSetFeb);

        }
        /// <summary>
        /// Handles the 2 event of the clientesBindingNavigatorSaveItem_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clientesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.erpDataSetFeb);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the 3 event of the clientesBindingNavigatorSaveItem_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clientesBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.erpDataSetFeb);

        }
    }
}
