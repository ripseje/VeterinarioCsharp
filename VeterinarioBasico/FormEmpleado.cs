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

namespace VeterinarioBasico
{
    public partial class FormEmpleado : Form
    {

        Conexion miConexion = new Conexion();
        public DataTable datosEmpleado = new DataTable();
        public LoginEmpleados login = new LoginEmpleados();
        public String devolucion = "";

        public FormEmpleado()
        {
            InitializeComponent();
            perfil();
            
        }

        public void perfil()
        {
            /*devolucion = login.funciona();
            MessageBox.Show(devolucion);
            datosEmpleado = miConexion.getData(devolucion);
            label2.Text = datosEmpleado.Rows[0]["nombre"].ToString();
            label4.Text = datosEmpleado.Rows[0]["apellido"].ToString();
            user.Text = datosEmpleado.Rows[0]["usuario"].ToString();
            idEmpleado.Text = datosEmpleado.Rows[0]["id_empleado"].ToString();
            //imagenEmpleado.Image = convierteBlobAImagen((byte[])datosEmpleado.Rows[0]["img_perfil"]);
        }
        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));*/
        }
    }
}
