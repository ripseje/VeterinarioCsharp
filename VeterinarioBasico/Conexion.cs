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

        //Login del cliente
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


        //Login del empleado
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


        //Método para obtener los datos del empleado según su usuario
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

        //Método para obtener los datos del cliente según su correo
        public DataTable getDataCliente(String id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM cliente WHERE correo ='" + id + "'", conexion);
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

        //Método para obtener todos los datos de citas
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

        //Método para obtener los datos de las mascotas
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

        //Método para obtenber los datos de los clientes
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

        //Método para obtener los datos de las mascotas por su id_mascota
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

        //Método para obtener un cliente por su dni
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

        //Métodos para obtener una cita por su código
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
        //Confusión, dos métodos para lo mismo xd
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
        //Metodo para comprobar mascotas por su id(momento confusión 2)
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
        //Método para obtener datos de una citas por el empleado(para el panel /los panels de su perfíl)
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
        //Método para obtener las mascotas de un cliente por su correo(para el panel / los panels de su perfíl)
        public DataTable getMascotasCliente(String correo)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT especie, nombre, edad, altura, peso, vacunado, imagenMascota, id_mascota FROM mascota WHERE id_dniDueno = (SELECT id_dni FROM cliente WHERE correo ='" + correo + "')", conexion);
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
        //Intento de pedir cita
        public String nuevaCita(String cod, String fecha, String hora, String id_empleado, String id_dni, String motivo)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO usuarios (cod_cita, fecha, hora, id_empleado, id_dni, motivo) VALUES ('" + cod + "', '" + fecha + "', '" + hora + "', '" + id_empleado + "', '" + id_dni + "', '" + motivo + "')", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable empleaux = new DataTable();
                empleaux.Load(resultado);
                conexion.Close();
                return "yes";
            }
            catch (MySqlException e)
            {
                return "no";
                throw e;
            }
        }
        //Método usado para pedir cita y randomizar el empleado que lo iba a tratar en la cita
        public DataTable getEmpleados()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM empleado", conexion);
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
        //Otro intento de pedir cita
        public bool nuevaCitaBool(String cod, String fecha, String hora, String id_empleado, String id_dni, String motivo)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                        new MySqlCommand("INSERT INTO usuarios (cod_cita, fecha, hora, id_empleado, id_dni, motivo) VALUES ('" + cod + "', '" + fecha + "', '" + hora + "', '" + id_empleado + "', '" + id_dni + "', '" + motivo + "')", conexion);
                consulta.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
                throw e;
            }
        }

    }
}
