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
    public partial class LoginEmpleados : Form
    {
        Conexion conexion = new Conexion();
        public string dev = "";
        public LoginEmpleados()
        {
            InitializeComponent();
            loginPass.PasswordChar = '*';
        }

        //Cambia al form del empleado
        public void buttonLogin_Click(object sender, EventArgs e)
        {
            if (conexion.loginEmpleado(loginUsuario.Text, loginPass.Text) != "error de usuario/contraseña")
            {
                dev = loginUsuario.Text;
                MessageBox.Show("Bienvenido al sistema " + dev + "!");
                FormEmpleado v = new FormEmpleado();
                v.perfil(dev);
                v.Show();
                this.Hide();
            }
            else
            {
                String Resultado = conexion.loginVeterinario(loginUsuario.Text, loginPass.Text);
                MessageBox.Show(Resultado);
            }
        }

        //Cambia a ventana login del cliente
        private void button1_Click(object sender, EventArgs e)
        {
            VentanaLogin v = new VentanaLogin();
            v.Show();
            this.Hide();
        }
    }
}
