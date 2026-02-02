using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos_SQL_
{
    public class AccesoDB
    {
        //Establece atributos de conexion y consulta.
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //Atributo publico para que devuelva los objetos encontrados.
        public SqlDataReader Lector { get { return lector; } }

        //Constructor, nace con la conexion establecida.
        public AccesoDB()
        {
            conexion = new SqlConnection("Server=ABSALOM\\SQLEXPRESS01;Database=CATALOGO_DB;Trusted_Connection=True;");
            comando = new SqlCommand();
        }
        //Metodo que carga la consulta.
        public void SetearComando(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        //Metodo abrir conexion y ejecutar lectura.
        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetearParametros(string columna, object AtributoDelObj)
        {
           comando.Parameters.AddWithValue(columna, AtributoDelObj);
        }
        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
         

        //Metodo cerrar conexion.
        public void CerrarConexion()
        {
            if (lector != null)
            {
               lector.Close();
            }
            conexion.Close();
        }
    }
}
