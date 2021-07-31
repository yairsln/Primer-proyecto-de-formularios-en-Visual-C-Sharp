using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_proyecto_de_formularios_en_Visual_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclickthis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gerson, Kevin, Genesis, Alejandro, Fernado, Eliseo");
        }
    }
}
