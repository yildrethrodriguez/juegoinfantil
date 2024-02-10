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
    public partial class frmLogin : Form
    {
        private readonly object txtclave;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. declarar nuestras variables
            string usuario, clave;
            //2. Asignarle el valor que ingresamos al cuadro de texto a las variables respectivas
            usuario = txtUsuario.Text;
            clave = txt_clave.Text;
     


            //3. Utilizamos una condición para poder comparar el usuario y la clave para acceder
            if((usuario=="gilkids") && (clave =="2023"))
            {
                //4. Generamos una instancia al formulario dos
                frmPrincipal fp = new frmPrincipal();
                this.Hide();
                fp.ShowDialog();
                this.Show();
                



            }
            else
            {
                MessageBox.Show ("El usuario o contraseña son incorrectos", "Error");
                txtUsuario.Text = "";
                txt_clave.Text = "";
                txtUsuario.Focus();

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
      

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Close();
        }
    }

}
