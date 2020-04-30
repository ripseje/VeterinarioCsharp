using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace VeterinarioBasico
{
   
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd=; Port = 3306");
        }

        public String loginVeterinario(String correo, String pass_client)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM cliente WHERE correo = @correo AND pass_client = @pass_client", conexion);
                consulta.Parameters.AddWithValue("@correo", correo);
                consulta.Parameters.AddWithValue("@pass_client", pass_client);

                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    return resultado.GetString(0);
                }

                conexion.Close();
                return "error de usuario/contraseña";
            }
            catch (MySqlException e)
            {
                return "error de try";
            }
        }

        public String loginEmpleado(String usuario, String passwd)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM empleado WHERE usuario = @usuario AND passwd = @passwd", conexion);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                consulta.Parameters.AddWithValue("@passwd", passwd);

                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    return resultado.GetString(0);
                    
                }

                conexion.Close();
                return "error de usuario/contraseña";
            }
            catch (MySqlException e)
            {
                return "error de try";
            }
        }

        public DataTable getData(String id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM empleado WHERE usuario ='" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return empleaux;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getCitas()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM citas ", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return empleaux;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getMascotas()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM mascota ", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return empleaux;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getCliente()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM cliente ", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return empleaux;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getImagenMascota(String id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM mascota WHERE id_mascota ='" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return empleaux;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getClienteBusqueda(String id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM cliente WHERE id_dni ='" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return empleaux;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getCitaPorBusqueda(String id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM citas WHERE cod_cita ='" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return empleaux;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public bool compruebaCita(String id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM citas WHERE cod_cita ='" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
                throw e;
            }
        }

        public bool compruebaMascota(String id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM mascota WHERE id_mascota ='" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
                throw e;
            }
        }

        public DataTable getCitasDelEmpleado(String empleado)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT cod_cita, fecha, hora, motivo, id_dni, id_mascota FROM citas, mascota WHERE id_empleado ='" + empleado + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return empleaux;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

    }
}
