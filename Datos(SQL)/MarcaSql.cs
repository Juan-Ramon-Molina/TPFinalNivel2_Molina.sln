using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_SQL_
{
    public class MarcaSql
    {
        public List<Marca> ListarMarcas()
        {
            List<Marca> marcas = new List<Marca>();
            AccesoDB data= new AccesoDB();

            try
            {
                data.SetearComando("select id, Descripcion from MARCAS");
                data.EjecutarLectura();
                while (data.Lector.Read())
                {
                    Marca aux= new Marca();
                    aux.id = (int)data.Lector["id"];
                    aux.descripcion = HelperSql.ConvertirDbNull<string>(data.Lector, "Descripcion");
                    marcas.Add(aux);
                }
                return marcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { data.CerrarConexion(); }

        }
    }
}
