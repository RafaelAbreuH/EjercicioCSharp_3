using EjercicioCSharp_3.Ejercicios10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCSharp_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1 ver = new Ejercicio1();
            ver.MdiParent = this;
            ver.Show();
        }
    }
}
