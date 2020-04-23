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
        public String devolucion = "";

        public FormEmpleado()
        {
            InitializeComponent();
            miConexion.getCitas();
            dataGridView.DataSource = miConexion.getCitas();
            miConexion.getMascotas();
            dataGridView1.DataSource = miConexion.getMascotas();
        }

        public void perfil(String nombre)
        {
            /*LoginEmpleados log = new LoginEmpleados();
            MessageBox.Show(log.nombre);*/
            datosEmpleado = miConexion.getData(nombre);
            label2.Text = datosEmpleado.Rows[0]["nombre"].ToString();
            label4.Text = datosEmpleado.Rows[0]["apellido"].ToString();
            user.Text = datosEmpleado.Rows[0]["usuario"].ToString();
            idEmpleado.Text = datosEmpleado.Rows[0]["id_empleado"].ToString();
            try
            {
                imagenEmpleado.Image = convierteBlobAImagen((byte[])datosEmpleado.Rows[0]["img_perfil"]);
            }
            catch (Exception e)
            {

            }
        }
        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ccLabel.Text = dataGridView.Rows[e.RowIndex].Cells["cod_cita"].Value.ToString();
            fhLabel.Text = dataGridView.Rows[e.RowIndex].Cells["fecha"].Value.ToString();
            label12.Text = dataGridView.Rows[e.RowIndex].Cells["hora"].Value.ToString();
            idLabel.Text = dataGridView.Rows[e.RowIndex].Cells["id_empleado"].Value.ToString();
            id_dniLabel.Text = dataGridView.Rows[e.RowIndex].Cells["id_dni"].Value.ToString();
            textoMotivo.Text = dataGridView.Rows[e.RowIndex].Cells["motivo"].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_label.Text = dataGridView1.Rows[e.RowIndex].Cells["id_mascota"].Value.ToString();
            especielabel.Text = dataGridView1.Rows[e.RowIndex].Cells["especie"].Value.ToString();
            nombrelabel.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            edadLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["edad"].Value.ToString();
            pesoLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["peso"].Value.ToString();
            alturaLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["altura"].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells["vacunado"].Value.ToString().Equals("False"))
            {
                vacunadoLabel.Text = "No";
            }
            else
            {
                vacunadoLabel.Text = "Si";
            }
            
            /*try
            {
                fotoMascota.Image = convierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["motivo"].Value);
            }
            catch(Exception o)
            {
                throw o;
            }*/
        }
    }
}
