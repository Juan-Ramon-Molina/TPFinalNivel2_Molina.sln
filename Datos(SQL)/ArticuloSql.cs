using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Microsoft.SqlServer.Server;

namespace Datos_SQL_
{
    public class ArticuloSql

    {
       
        public List<Articulo> ListarArticulos()
        {   
            AccesoDB data=new AccesoDB();
            List<Articulo> articulos = new List<Articulo>();
            try
            {
                //En la consulta uso el "where precio != 0" para identificar los articulos activos.
                data.SetearComando("select a.Id, Codigo, nombre, a.Descripcion DescripcionArticulo, ImagenUrl, Precio, IdMarca, m.Descripcion Marca, IdCategoria, c.Descripcion Categoria  from ARTICULOS a inner join MARCAS m on m.Id=a.IdMarca inner join CATEGORIAS c on c.id=a.IdCategoria");
                data.EjecutarLectura();
                //Capturar objetos.
                while (data.Lector.Read()) 
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)data.Lector["Id"];
                    aux.codigo = HelperSql.ConvertirDbNull<string>(data.Lector, "Codigo");
                    aux.nombre = HelperSql.ConvertirDbNull<string>(data.Lector, "Nombre");
                                           
                    aux.descripcion = HelperSql.ConvertirDbNull<string>(data.Lector, "DescripcionArticulo");
                    aux.imagenUrl = HelperSql.ConvertirDbNull<string>(data.Lector, "ImagenUrl");
                    aux.precio = HelperSql.ConvertirDbNull<decimal>(data.Lector, "Precio");
                    aux.marca = new Marca();
                    aux.marca.id = (int)data.Lector["IdMarca"];
                    aux.marca.descripcion = HelperSql.ConvertirDbNull<string>(data.Lector, "Marca");
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)data.Lector["IdCategoria"];
                    aux.categoria.descripcion = HelperSql.ConvertirDbNull<string>(data.Lector, "Categoria");

                    articulos.Add(aux);
                }
                
                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {   
                data.CerrarConexion(); 
            }
        }
    }
}
