using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usuarios);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarios.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.usuarios.empleados);

        }

        private void validar_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=E:\SQL developer\MSSQL14.MSSQLSERVER\MSSQL\JUANJOESCRITORI;Initial Catalog=STUDENT;Integrated Security=True";
       */ }
    }
}
