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
    public partial class FormClientes : Form
    {

        Conexion miConexion = new Conexion();
        public DataTable datosCliente = new DataTable();
        public DataTable mascotasDelCliente = new DataTable();
        public DataTable citas = new DataTable();
        public DataTable empleado = new DataTable();
        public String fechaSeleccionada;

        public FormClientes()
        {
            InitializeComponent();
            citas = miConexion.getCitas();
            empleado = miConexion.getEmpleados();
        }

        //Método para cargar los datos del perfíl del usuario en el panel
        public void perfil(String correo)
        {
            datosCliente = miConexion.getDataCliente(correo);
            nombreCliente.Text = datosCliente.Rows[0]["nombre"].ToString();
            apellidoCliente.Text = datosCliente.Rows[0]["apellido"].ToString();
            correoCliente.Text = datosCliente.Rows[0]["correo"].ToString();
            dniCliente.Text = datosCliente.Rows[0]["id_dni"].ToString();
            try
            {
                pictureBox1.Image = convierteBlobAImagen((byte[])datosCliente.Rows[0]["img_perfil"]);
            }
            catch (Exception e)
            {
                throw e;
            }
            mascotasCliente(datosCliente.Rows[0]["correo"].ToString());
        }

        //Metodo para convertir el blob de la imágen
        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }


        //Método para crear los paneles de las mascotas automáticamente
        public void mascotasCliente(String user)
        {
            mascotasDelCliente = miConexion.getMascotasCliente(user);
            int totalRows = mascotasDelCliente.Rows.Count;
            for (int i = 0; i < totalRows; i++)
            {
                Panel panel = new Panel();
                if (i != 0)
                {
                    panel.BackColor = Color.FromArgb(255, 250, 205);
                    panel.Size = new System.Drawing.Size(540, 176);
                    panelMascotas.Controls.Add(panel);
                    panel.Location = new Point(16, 15 + 186 * i);
                    panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                }
                else
                {

                    panel.BackColor = Color.FromArgb(255, 250, 205);
                    panel.Size = new System.Drawing.Size(540, 176);
                    panelMascotas.Controls.Add(panel);
                    panel.Location = new Point(16, 15);
                    panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                }
                
                //Crear pictureBox de la imagen de la Mascota
                PictureBox imagenMascota = new PictureBox();
                panel.Controls.Add(imagenMascota);
                imagenMascota.Location = new Point(17, 18);
                imagenMascota.Size = new Size(134, 134);
                imagenMascota.SizeMode = PictureBoxSizeMode.StretchImage;
                imagenMascota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                imagenMascota.Image = convierteBlobAImagen((byte[])mascotasDelCliente.Rows[i]["imagenMascota"]);


                //Crea el label de títuo de especie y su respectiva especie
                Label especie = new Label();
                panel.Controls.Add(especie);
                especie.AutoSize = true;
                especie.Location = new Point(167, 18);
                especie.Font = new Font("Serif", 10, FontStyle.Bold);
                especie.Text = "Especie: ";

                Label especieMascota = new Label();
                panel.Controls.Add(especieMascota);
                especieMascota.AutoSize = true;
                especieMascota.Location = new Point(238, 18);
                especieMascota.Font = new Font("Serif", 10, FontStyle.Regular);
                especieMascota.Text = mascotasDelCliente.Rows[i]["especie"].ToString();


                //Crea el label de títuo de peso y su respectivo peso
                Label peso = new Label();
                panel.Controls.Add(peso);
                peso.AutoSize = true;
                peso.Location = new Point(380, 18);
                peso.Font = new Font("Serif", 10, FontStyle.Bold);
                peso.Text = "Peso: ";

                Label pesoMascota = new Label();
                panel.Controls.Add(pesoMascota);
                pesoMascota.AutoSize = true;
                pesoMascota.Location = new Point(432, 18);
                pesoMascota.Font = new Font("Serif", 10, FontStyle.Regular);
                pesoMascota.Text = mascotasDelCliente.Rows[i]["peso"].ToString() + "kg";
                
                //Crea el label de títuo de nombre y su respectivo nombre
                Label nombre = new Label();
                panel.Controls.Add(nombre);
                nombre.AutoSize = true;
                nombre.Location = new Point(167, 71);
                nombre.Font = new Font("Serif", 10, FontStyle.Bold);
                nombre.Text = "Nombre:";

                Label nombreMascota = new Label();
                panel.Controls.Add(nombreMascota);
                nombreMascota.AutoSize = true;
                nombreMascota.Location = new Point(238, 71);
                nombreMascota.Font = new Font("Serif", 10, FontStyle.Regular);
                nombreMascota.Text = mascotasDelCliente.Rows[i]["nombre"].ToString();

                //Crea el label de títuo de altura y su respectiva altura
                Label altura = new Label();
                panel.Controls.Add(altura);
                altura.AutoSize = true;
                altura.Location = new Point(380, 71);
                altura.Font = new Font("Serif", 10, FontStyle.Bold);
                altura.Text = "Altura:";

                Label alturaMascota = new Label();
                panel.Controls.Add(alturaMascota);
                alturaMascota.AutoSize = true;
                alturaMascota.Location = new Point(432, 71);
                alturaMascota.Font = new Font("Serif", 10, FontStyle.Regular);
                alturaMascota.Text = mascotasDelCliente.Rows[i]["altura"].ToString() + "m";

                //Crea el label de títuo de edad y su respectiva edad
                Label edad = new Label();
                panel.Controls.Add(edad);
                edad.AutoSize = true;
                edad.Location = new Point(167, 128);
                edad.Font = new Font("Serif", 10, FontStyle.Bold);
                edad.Text = "Edad:";

                Label edadMascota = new Label();
                panel.Controls.Add(edadMascota);
                edadMascota.AutoSize = true;
                edadMascota.Location = new Point(228, 128);
                edadMascota.Font = new Font("Serif", 10, FontStyle.Regular);
                edadMascota.Text = mascotasDelCliente.Rows[i]["edad"].ToString() + " año/s";

                //Crea el label de títuo de vacunas y si está vacunado
                Label vacunado = new Label();
                panel.Controls.Add(vacunado);
                vacunado.AutoSize = true;
                vacunado.Location = new Point(380, 128);
                vacunado.Font = new Font("Serif", 10, FontStyle.Bold);
                vacunado.Text = "Vacunado:";

                Label vacunadoCiNon = new Label();
                panel.Controls.Add(vacunadoCiNon);
                vacunadoCiNon.AutoSize = true;
                vacunadoCiNon.Location = new Point(472, 128);
                vacunadoCiNon.Font = new Font("Serif", 10, FontStyle.Regular);
                if (mascotasDelCliente.Rows[i]["vacunado"].ToString().Equals("False"))
                {
                    vacunadoCiNon.Text = "No";
                }
                else
                {
                    vacunadoCiNon.Text = "Sí";
                }
            }
        }

        //Hemos trabajado en una pestaña de pedir cita, pero no ha funcionado, y para no tenerla de decoración
        //hemos preferido quitarla. Debajo de este comentario hay algunos métodos que habiamos estado probando
        //que hemos pensado dejar porque no molestan.


       /* private void botonPedirCita(object sender, EventArgs e)
        {

            /*int rows = citas.Rows.Count;
            rows++;
            String codcita = "0" + rows;

            int empl = empleado.Rows.Count;
            Random r = new Random();
            int randi = r.Next(0, empl);
            String idempleado = "" + randi;

            Object selectedItem = comboBox1.SelectedItem;

            String itemSelec = selectedItem.ToString();

            miConexion.nuevaCita(codcita, fechaSeleccionada, itemSelec, idempleado, datosCliente.Rows[0]["id_dni"].ToString(), textBox1.Text);
            miConexion.nuevaCitaBool("06", "2000-10-06", "15:00", "1", datosCliente.Rows[0]["id_dni"].ToString(), "test");
            

        }
        private void calendarioCitas_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            /*fechaSeleccionada = e.Start.ToShortDateString();
            String ay = fechaSeleccionada.SelectionRange.Start
            MessageBox.Show(fechaSeleccionada);
            MessageBox.Show(fechaSeleccionada.Length + "wow");
            MessageBox.Show(fechaVuelta(fechaSeleccionada));
        }

        public String fechaVuelta(String fecha)
        {
            String fecha4p = fecha.Substring(fecha.Length-, fecha.Length);
            String ralla = "-";
            String resultado = fecha4p;
            return resultado;
        }*/
    }
}
