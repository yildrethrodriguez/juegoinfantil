using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIL_KIDS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //generar una instancia para conectar con el formulario suma
            OperacionesBásicas.frmSuma fs = new OperacionesBásicas.frmSuma();
            fs.MdiParent = this;
            fs.Show();

        }

        private void multipllicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //generar una instancia para conectar con el formulario resta
            OperacionesBásicas.frmResta fs = new OperacionesBásicas.frmResta();
            fs.MdiParent = this;
            fs.Show();
        }
    }
}
