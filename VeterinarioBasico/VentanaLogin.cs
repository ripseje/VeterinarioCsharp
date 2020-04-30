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
            //cambia los caracteres para que no se vea la contraseña mientras la escribes
            loginPwd.PasswordChar = '*';
        }

        //Inicia las ventanas del cliente
        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion.loginVeterinario(loginCorreo.Text, loginPwd.Text) != "error de usuario/contraseña")
            {
                String correo = loginCorreo.Text;
                this.Hide();
                FormClientes v = new FormClientes();
                v.perfil(correo);
                v.Show();
                
            }
            else
            {
                String Resultado = conexion.loginVeterinario(loginCorreo.Text, loginPwd.Text);
                MessageBox.Show(Resultado);
            }
        }

        //Cambia al login del empleado
        private void button2_Click(object sender, EventArgs e)
        {
            LoginEmpleados v = new LoginEmpleados();
            v.Show();
            this.Hide();
        }
    }
}
