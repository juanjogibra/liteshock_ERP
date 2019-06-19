using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
namespace WindowsFormsApp1
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {

        /// <summary>
        /// Gets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public static object Current { get; internal set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            
            InitializeComponent();   
            
        }
        /// <summary>
        /// Handles the TextChanged event of the textBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Determine whether the key entered is the F1 key. Display help if it is.
            if (e.KeyCode == Keys.F1)
            {
                // Display a pop-up help topic to assist the user.
                FormAyuda ayuda = new FormAyuda();
                ayuda.Location = this.Location;
                ayuda.ShowDialog(this);
            }
        }
        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }/// <summary>
        /// El metodo formClosing nos permite asegurar que nuestra aplicación cierre totalmente a la hora de pulsar sobre el boton de control de cierre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que quieres salir?\nLos cambios no seran guardados","Salir", MessageBoxButtons.YesNo);

            if(dialogo == DialogResult.Yes)
            {
               
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the alphaBlendTextBox2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void alphaBlendTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// A partir de este punto tenemos los metodos que se ocupan de administrar los clic de raton sobre la interfaz de la aplicacion. Si pulsamos sobre un elemento, nos abrirá las distintas ventanas de nuestro programa.
        /// </summary>

        private void label4_Click(object sender, EventArgs e)
        {

            Form2 ventas = new Form2();
            ventas.ShowDialog(this);
            
            ventas.Location = this.Location;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            FormUtiles utilidades = new FormUtiles();
            utilidades.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }
        private void label2_Click(object sender, EventArgs e)
        {
            Clientes client = new Clientes();
            client.ShowDialog(this);
            client.Location = this.Location;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the pictureBox3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Clientes client = new Clientes();
            client.ShowDialog(this);
            client.Location = this.Location;

        }
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            Form2 ventas = new Form2();

            // Show the settings form
            ventas.ShowDialog(this);
            ventas.Location = this.Location;
            
        }
        
        private void label6_Click(object sender, EventArgs e)
        {
           Almacen almacen = new Almacen();
           almacen.ShowDialog(this);

           almacen.Location = this.Location;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Almacen almacen = new Almacen();
            almacen.ShowDialog(this);

            almacen.Location = this.Location;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Login usuario = new Login();
            usuario.ShowDialog(this);

            usuario.Location = this.Location;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FormUtiles utilidades = new FormUtiles();
            utilidades.ShowDialog(this);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Informescs informes = new Informescs();
            informes.ShowDialog(this);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Informescs informes = new Informescs();
            informes.ShowDialog(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FormAyuda ayuda = new FormAyuda();
            ayuda.Location = this.Location;
            ayuda.ShowDialog(this);

            



        }
    }
}
