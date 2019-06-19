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
    public partial class PdfView : Form
    {
        public PdfView()
        {
            InitializeComponent();
            //webBrowser1.Navigate ("C:/Users/Juanjo/source/repos/WindowsFormsApp1/doc/manual.pdf");
            webBrowser1.Navigate(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"/pdf/Manual.pdf");
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void axPDFViewer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
