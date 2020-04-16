using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarioBasico
{
    public partial class VentanaLogin : Form
    {
        Conexion conexion = new Conexion();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion.loginVeterinario(loginCorreo.Text, loginPwd.Text) != "error de usuario/contraseña")
            {
                Form1 v = new Form1();
                v.Show();
                VentanaLogin v2 = new VentanaLogin();
                v2.Hide();
            }
            else
            {
                String Resultado = conexion.loginVeterinario(loginCorreo.Text, loginPwd.Text);
                MessageBox.Show(Resultado);
            }
        }
    }
}
