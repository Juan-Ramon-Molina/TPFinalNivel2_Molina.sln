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
        public List<Articulo> ListarInactivos()
        {
            AccesoDB data = new AccesoDB();
            List<Articulo> inactivos = new List<Articulo>();
            try
            {
                //En la consulta uso el "where codigo like 'INACTIVO-'" para identificar los articulos activos.
                data.SetearComando("select a.Id, Codigo, nombre, a.Descripcion DescripcionArticulo, ImagenUrl, Precio, IdMarca, m.Descripcion Marca, IdCategoria, c.Descripcion Categoria  from ARTICULOS a inner join MARCAS m on m.Id=a.IdMarca inner join CATEGORIAS c on c.id=a.IdCategoria where Codigo like 'INACTIVO-%'");
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

                    inactivos.Add(aux);
                }
                return inactivos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el proceso", ex);
            }
            finally
            {
                data.CerrarConexion();
            }
        }
        public List<Articulo> ListarArticulos()
        {
            AccesoDB data = new AccesoDB();
            List<Articulo> articulos = new List<Articulo>();
            try
            {
                //En la consulta uso el "where codigo not like 'INACTIVO-'" para identificar los articulos activos.
                data.SetearComando("select a.Id, Codigo, nombre, a.Descripcion DescripcionArticulo, ImagenUrl, Precio, IdMarca, m.Descripcion Marca, IdCategoria, c.Descripcion Categoria  from ARTICULOS a inner join MARCAS m on m.Id=a.IdMarca inner join CATEGORIAS c on c.id=a.IdCategoria where Codigo not like 'INACTIVO-%'");
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
                throw new Exception("Error en el proceso", ex);
            }
            finally
            {
                data.CerrarConexion();
            }
        }
        public void CrearArticulo(Articulo Nuevo)
        {
            AccesoDB data = new AccesoDB();
            try
            {
                data.SetearComando("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                data.SetearParametros("@Codigo", Nuevo.codigo);
                data.SetearParametros("@Nombre", Nuevo.nombre);
                data.SetearParametros("@Descripcion", Nuevo.descripcion);
                data.SetearParametros("@IdMarca", Nuevo.marca.id);
                data.SetearParametros("@IdCategoria", Nuevo.categoria.id);
                data.SetearParametros("@ImagenUrl", Nuevo.imagenUrl);
                data.SetearParametros("@Precio", Nuevo.precio);
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw new Exception("Error en el proceso", ex);
            }
            finally { data.CerrarConexion(); }
        }
        public void ModificarArticulo(Articulo Editable)
        {
            AccesoDB data = new AccesoDB();
            try
            {
                data.SetearComando("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
                data.SetearParametros("@Codigo", Editable.codigo);
                data.SetearParametros("@Nombre", Editable.nombre);
                data.SetearParametros("@Descripcion", Editable.descripcion);
                data.SetearParametros("@IdMarca", Editable.marca.id);
                data.SetearParametros("@IdCategoria", Editable.categoria.id);
                data.SetearParametros("@ImagenUrl", Editable.imagenUrl);
                data.SetearParametros("@Precio", Editable.precio);
                data.SetearParametros("@Id", Editable.id);
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw new Exception("Error en el proceso", ex);
            }
            finally { data.CerrarConexion(); }
        }
        public void InactivarArticulo(int id)
        {
            AccesoDB data = new AccesoDB();
            try
            {
                data.SetearComando("update ARTICULOS set Codigo = 'INACTIVO-' + Codigo where Id = @Id");
                data.SetearParametros("@Id", id);
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw new Exception("Error en el proceso", ex);
            }
            finally { data.CerrarConexion(); }
        }
        public void RecuperarAriculo(int id)
        {
            AccesoDB data = new AccesoDB();
            try
            {
                //Substring comando sql que corta el texto. Corta el codigo, desde len('INACTIVO-') + 1. Obteniendo el resto del texto.
                data.SetearComando("update ARTICULOS set Codigo = substring(codigo, len('INACTIVO-') + 1, len(codigo))  where Id = @Id");
                data.SetearParametros("@Id", id);
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw new Exception("Error en el proceso", ex);
            }
            finally { data.CerrarConexion(); }
        }
        public void EliminarArticulo(int id)
        {
            AccesoDB data = new AccesoDB();
            try
            {           
                data.SetearComando("delete from ARTICULOS where Id = @Id");
                data.SetearParametros("@Id", id);
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw new Exception("Error en el proceso", ex);
            }
            finally { data.CerrarConexion(); }
        }
        public List<Articulo> BusquedaAvanzada(string campo,string criterio, string filtro)
        {
            AccesoDB data= new AccesoDB();
            List<Articulo> filtrados = new List<Articulo>();
            try
            {
                string consulta = "select a.Id, Codigo, nombre, a.Descripcion DescripcionArticulo, ImagenUrl, Precio, IdMarca, m.Descripcion Marca, IdCategoria, c.Descripcion Categoria  from ARTICULOS a inner join MARCAS m on m.Id=a.IdMarca inner join CATEGORIAS c on c.id=a.IdCategoria where Codigo not like 'INACTIVO-%' and ";
                //Armar consulta en base a los switch. termina con "and" para concatenar.
                switch (campo)
                {
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayores a :":
                                consulta += "Precio >" + filtro;
                                break;
                            case "Menores a :":
                                consulta += "Precio <" + filtro;
                                break;
                            case "Iguales a :":
                                consulta += "Precio ==" + filtro;
                                break;
                        }
                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Empiezan con :":
                                consulta += "Nombre like '" + filtro + "%'";
                                break;
                            case "Terminan con :":
                                consulta += "Nombre like '%" + filtro + "'";                                
                                break;
                            case "Contienen :":
                                consulta += "Nombre like '%" + filtro + "%'"; 
                                break;
                        }
                        break;

                    case "Descripcion":
                        switch (criterio)
                        {
                            case "Empiezan con :":
                                consulta += "a.Descripcion like '" + filtro + "%'";
                                break;
                            case "Terminan con :":
                                consulta += "a.Descripcion like '%" + filtro + "'";
                                break;
                            case "Contienen :":
                                consulta += "a.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;

                }
                data.SetearComando(consulta);
                data.EjecutarLectura();
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

                    filtrados.Add(aux);
                }
                return filtrados;
            }
            catch (Exception ex)
            {

                throw new Exception("Error en el proceso", ex);
            }
            finally { data.CerrarConexion(); }
        }
    }
}
