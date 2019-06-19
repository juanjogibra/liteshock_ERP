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
    public partial class InformesTodasFacturas : Form
    {
        public InformesTodasFacturas()
        {
            InitializeComponent();
        }

        private void InformesTodasFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFacturasTotales.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSetFacturasTotales.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
