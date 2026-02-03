using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_SQL_
{
    public class CategoriaSql
    {
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            AccesoDB data = new AccesoDB();

            try
            {
                data.SetearComando("select id, Descripcion from CATEGORIAS");
                data.EjecutarLectura();
                while (data.Lector.Read())
                {
                    Categoria aux= new Categoria();
                    aux.id = (int)data.Lector["id"];
                    aux.descripcion = HelperSql.ConvertirDbNull<string>(data.Lector,"Descripcion");
                    categorias.Add(aux);
                }
                return categorias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { data.CerrarConexion(); }
        }
        public void CrearCategoria(Categoria nueva)
        {
            AccesoDB data = new AccesoDB();
            try
            {
                data.SetearComando("insert into CATEGORIAS (Descripcion) values (@descripcion)");
                data.SetearParametros("@descripcion", nueva.descripcion);
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { data.CerrarConexion(); }
        }
    } 
}
