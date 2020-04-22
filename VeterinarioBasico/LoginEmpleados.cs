﻿using System;
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
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (conexion.loginEmpleado(loginUsuario.Text, loginPass.Text) != "error de usuario/contraseña")
            {
                FormEmpleado v = new FormEmpleado();
                MessageBox.Show(loginUsuario.Text);
                v.Show();
            }
            else
            {
                String Resultado = conexion.loginVeterinario(loginUsuario.Text, loginPass.Text);
                MessageBox.Show(Resultado);
            }
        }
    }
}
