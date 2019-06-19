using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAyuda : Form
    {
        public FormAyuda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PdfView pdf = new PdfView();
            pdf.ShowDialog(this);

            pdf.Location = this.Location;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PdfView pdf = new PdfView();
            pdf.ShowDialog(this);

            pdf.Location = this.Location;
        }

        private void label3_Click(object sender, EventArgs e)
        {
          //  System.Windows.Forms.Help.ShowHelp(null, "C:/Users/Juanjo/source/repos/WindowsFormsApp1/doc/Help/Documentation.chm");
            System.Windows.Forms.Help.ShowHelp(null, (Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"/Help/Documentation.chm"));

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // System.Windows.Forms.Help.ShowHelp(null, "C:/Users/Juanjo/source/repos/WindowsFormsApp1/doc/Help/Documentation.chm");
            System.Windows.Forms.Help.ShowHelp(null, (Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"/Help/Documentation.chm"));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("LiteShock ERP Enterprise License V2.1 ©2019\nAuthor: Juan José González - Support: juanjogibra@gmail.com", "Información de la aplicacion", MessageBoxButtons.OK);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("LiteShock ERP Enterprise License V2.1 ©2019\nAuthor: Juan José González - Support: juanjogibra@gmail.com", "Información de la aplicacion", MessageBoxButtons.OK);
        }
    }
}
