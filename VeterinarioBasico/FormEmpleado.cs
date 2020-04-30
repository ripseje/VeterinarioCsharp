using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
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
        public DataTable imagenMascota = new DataTable();
        public DataTable cita = new DataTable();
        public DataTable cliente = new DataTable();
        public DataTable citasEmpleado = new DataTable();
        public String devolucion = "";

        public FormEmpleado()
        {
            InitializeComponent();
            miConexion.getCitas();
            dataGridView.DataSource = miConexion.getCitas();
            miConexion.getMascotas();
            dataGridView1.DataSource = miConexion.getMascotas();
            miConexion.getCliente();
            dataGridView2.DataSource = miConexion.getCliente();
            monthCalendar1.TitleBackColor = System.Drawing.Color.Blue;
            monthCalendar1.TrailingForeColor = System.Drawing.Color.Red;
            monthCalendar1.TitleForeColor = System.Drawing.Color.Yellow;
            
        }

        public void perfil(String nombre)
        {
            
            datosEmpleado = miConexion.getData(nombre);
            label15.Text = datosEmpleado.Rows[0]["nombre"].ToString();
            label14.Text = datosEmpleado.Rows[0]["apellido"].ToString();
            user.Text = datosEmpleado.Rows[0]["usuario"].ToString();
            idEmpleado.Text = datosEmpleado.Rows[0]["id_empleado"].ToString();
            try
            {
                imagenEmpleado.Image = convierteBlobAImagen((byte[])datosEmpleado.Rows[0]["img_perfil"]);
            }
            catch (Exception e)
            {
                throw e;
            }
            pruebaCitasEmpleado(datosEmpleado.Rows[0]["id_empleado"].ToString());
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
            imagenMascota = miConexion.getImagenMascota(id_label.Text);
            fotoMascota.Image = convierteBlobAImagen((byte[])imagenMascota.Rows[0]["imagenMascota"]);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dniCliente.Text = dataGridView2.Rows[e.RowIndex].Cells["id_dni"].Value.ToString();
            nombreCliente.Text = dataGridView2.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            apellidosCliente.Text = dataGridView2.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
            correoCliente.Text = dataGridView2.Rows[e.RowIndex].Cells["correo"].Value.ToString();
            telCliente.Text = dataGridView2.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            cliente = miConexion.getClienteBusqueda(dniCliente.Text);
            if (cliente.Rows[0]["img_perfil"] != null)
            {
                imagenCliente.Image = convierteBlobAImagen((byte[])cliente.Rows[0]["img_perfil"]);
            }
        }

        private void busquedaMascotaButton(object sender, EventArgs e)
        {
            if (miConexion.compruebaMascota(busquedaMascotas.Text))
            {
                imagenMascota = miConexion.getImagenMascota(busquedaMascotas.Text);
                id_label.Text = imagenMascota.Rows[0]["id_mascota"].ToString();
                especielabel.Text = imagenMascota.Rows[0]["especie"].ToString();
                nombrelabel.Text = imagenMascota.Rows[0]["nombre"].ToString();
                edadLabel.Text = imagenMascota.Rows[0]["edad"].ToString();
                pesoLabel.Text = imagenMascota.Rows[0]["peso"].ToString();
                alturaLabel.Text = imagenMascota.Rows[0]["altura"].ToString();
                if (imagenMascota.Rows[0]["vacunado"].Equals(0))
                {
                    vacunadoLabel.Text = "No";
                }
                else
                {
                    vacunadoLabel.Text = "Si";
                }
                fotoMascota.Image = convierteBlobAImagen((byte[])imagenMascota.Rows[0]["imagenMascota"]);
            }
            else
            {
                MessageBox.Show("La mascota buscada no existe");
            }

        }

        private void busquedaCita(object sender, EventArgs e)
        {
            if (miConexion.compruebaCita(busquedaCitaTextBox.Text))
            {
                cita = miConexion.getCitaPorBusqueda(busquedaCitaTextBox.Text);
                ccLabel.Text = cita.Rows[0]["cod_cita"].ToString();
                fhLabel.Text = cita.Rows[0]["fecha"].ToString();
                label12.Text = cita.Rows[0]["hora"].ToString();
                idLabel.Text = cita.Rows[0]["id_empleado"].ToString();
                id_dniLabel.Text = cita.Rows[0]["id_dni"].ToString();
                textoMotivo.Text = cita.Rows[0]["motivo"].ToString();
            }
            else
            {
                MessageBox.Show("La cita buscada no existe");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente = miConexion.getClienteBusqueda(buscadorClienteTextBox.Text);
            dniCliente.Text = cliente.Rows[0]["id_dni"].ToString();
            nombreCliente.Text = cliente.Rows[0]["nombre"].ToString();
            apellidosCliente.Text = cliente.Rows[0]["apellido"].ToString();
            correoCliente.Text = cliente.Rows[0]["correo"].ToString();
            telCliente.Text = cliente.Rows[0]["telefono"].ToString();

            if (cliente.Rows[0]["img_perfil"] != null)
            {
                imagenCliente.Image = convierteBlobAImagen((byte[])cliente.Rows[0]["img_perfil"]);
            }
        }


        public void pruebaCitasEmpleado(String user)
        {
            citasEmpleado = miConexion.getCitasDelEmpleado(user);
            int totalRows = citasEmpleado.Rows.Count;
            for (int i = 0; i < totalRows; i++)
            {
                Panel panel = new Panel();
                if (i != 0)
                {
                    panel.BackColor = Color.FromArgb(153, 180, 209);
                    panel.Size = new System.Drawing.Size(494, 175);
                    panelCitas.Controls.Add(panel);
                    panel.Location = new Point(3, 3+185*i);
                    panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                } else
                {
                    
                    panel.BackColor = Color.FromArgb(153, 180, 209);
                    panel.Size = new System.Drawing.Size(494, 175);
                    panelCitas.Controls.Add(panel);
                    panel.Location = new Point(3, 3);
                    panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                }
                //Crear Label de titulo fecha y fecha de la cita dentro del panel
                Label fecha = new Label();
                panel.Controls.Add(fecha);
                fecha.AutoSize = true;
                fecha.Location = new Point(16, 13);
                fecha.Font = new Font("Serif", 12, FontStyle.Bold);
                fecha.Text = "Fecha: ";
                
                Label fechaCita = new Label();
                panel.Controls.Add(fechaCita);
                fechaCita.AutoSize = true;
                fechaCita.Location = new Point(91, 13);
                fechaCita.Font = new Font("Serif", 12, FontStyle.Regular);
                fechaCita.Text = citasEmpleado.Rows[i]["fecha"].ToString().Substring(0, 10);
                fechaCita.BackColor = Color.White;

                //Crear Label de titulo cliente dentro del panel
                Label cliente = new Label();
                panel.Controls.Add(cliente);
                cliente.AutoSize = true;
                cliente.Location = new Point(16, 53);
                cliente.Font = new Font("Serif", 12, FontStyle.Bold);
                cliente.Text = "Cliente: ";

                Label clienteCita = new Label();
                panel.Controls.Add(clienteCita);
                clienteCita.AutoSize = true;
                clienteCita.Location = new Point(97, 53);
                clienteCita.Font = new Font("Serif", 12, FontStyle.Regular);
                clienteCita.Text = citasEmpleado.Rows[i]["id_dni"].ToString();
                clienteCita.BackColor = Color.White;

                //Crear Label de titulo cliente dentro del panel
                Label hora = new Label();
                panel.Controls.Add(hora);
                hora.AutoSize = true;
                hora.Location = new Point(224, 13);
                hora.Font = new Font("Serif", 12, FontStyle.Bold);
                hora.Text = "Hora: ";

                Label horaCita = new Label();
                panel.Controls.Add(horaCita);
                horaCita.AutoSize = true;
                horaCita.Location = new Point(288, 13);
                horaCita.Font = new Font("Serif", 12, FontStyle.Regular);
                horaCita.Text = citasEmpleado.Rows[i]["hora"].ToString();
                horaCita.BackColor = Color.White;

                //Crear Label de titulo cliente dentro del panel
                Label mascota = new Label();
                panel.Controls.Add(mascota);
                mascota.AutoSize = true;
                mascota.Location = new Point(224, 53);
                mascota.Font = new Font("Serif", 12, FontStyle.Bold);
                mascota.Text = "Mascota: ";

                Label mascotaCita = new Label();
                panel.Controls.Add(mascotaCita);
                mascotaCita.AutoSize = true;
                mascotaCita.Location = new Point(317, 53);
                mascotaCita.Font = new Font("Serif", 12, FontStyle.Regular);
                mascotaCita.Text = citasEmpleado.Rows[i]["id_mascota"].ToString();
                mascotaCita.BackColor = Color.White;

                //Crear Label de titulo cliente dentro del panel
                TextBox motivo = new TextBox();
                panel.Controls.Add(motivo);
                motivo.AutoSize = false;
                motivo.Size = new Size(458, 69);
                motivo.Location = new Point(16, 95);
                motivo.Font = new Font("Serif", 12, FontStyle.Regular);
                motivo.Text = citasEmpleado.Rows[i]["motivo"].ToString();
                motivo.BackColor = Color.White;
                motivo.ScrollBars = ScrollBars.Vertical;
                motivo.WordWrap = true;
                motivo.Multiline = true;

            }
        }



    }
}
