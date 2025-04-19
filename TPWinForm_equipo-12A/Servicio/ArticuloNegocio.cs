using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class ArticuloNegocio
    {

        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            ImagenNegocio im = new ImagenNegocio();

            try
            {
                datos.setConsulta("select a.id, a.Codigo, a.Descripcion, a.Nombre, a.Precio, m.Id as \"IdMarca\", m.Descripcion as \"marca\", c.Id as \"IdCategoria\", c.Descripcion as \"categoria\" from ARTICULOS a left join MARCAS m ON m.Id = a.IdMarca left join CATEGORIAS c ON c.Id = a.IdCategoria;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();
                    Categoria cat = new Categoria();
                    Marca marca = new Marca();
                    List<Imagen> imagenes = new List<Imagen>();

                    art.IdArticulo = (int)datos.Lector["Id"];
                    art.Codigo = (string)datos.Lector["Codigo"];
                    art.Nombre = (string)datos.Lector["Nombre"];
                    art.Descripcion = (string)datos.Lector["Descripcion"];
                    art.Precio = (decimal)datos.Lector["Precio"];

                    art.Categoria = new Categoria();
                    if (!(datos.Lector["IdCategoria"] is DBNull))
                    {
                        art.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                        art.Categoria.Descripcion = (string)datos.Lector["categoria"];
                    }
                    else
                    {
                        //art.Marca.IdMarca = 0;
                        //art.Marca.Descripcion = "Sin categoria";
                        art.Categoria.IdCategoria = 0;
                        art.Categoria.Descripcion = "Sin categoría";
                    }

                    art.Marca = new Marca();
                    if (!(datos.Lector["IdMarca"] is DBNull))
                    {
                        art.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                        art.Marca.Descripcion = (string)datos.Lector["marca"];
                    }
                    else
                    {
                        art.Marca.IdMarca = 0;
                        art.Marca.Descripcion = "Sin marca";
                    }

                    art.Imagenes = im.getImagenesIdArticulo(art.IdArticulo);


                    articulos.Add(art);
                }



                return articulos;



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(Articulo nuevoArt)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio) values ('" + nuevoArt.Codigo + "', '" + nuevoArt.Nombre + "', '" + nuevoArt.Descripcion + "',  " + nuevoArt.Precio + ") ");

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            //string consulta = "UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio WHERE Id = @id";
            string consulta = "UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, Precio = @precio WHERE Id = @id";

            try
            {
                datos.setConsulta(consulta);
                datos.setParametro("@codigo", articulo.Codigo);
                datos.setParametro("@nombre", articulo.Nombre);
                datos.setParametro("@descripcion", articulo.Descripcion);
                //datos.setParametro("@idMarca", articulo.Marca.IdMarca);
                //datos.setParametro("@idCategoria", articulo.Categoria.IdCategoria);
                datos.setParametro("@precio", articulo.Precio);
                datos.setParametro("@id", articulo.IdArticulo);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
