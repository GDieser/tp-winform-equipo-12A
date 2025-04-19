using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class CategoriaNegocio
    {

        private AccesoDatos datos;


        public List<Categoria> listar()
        {
            List<Categoria> categorias = new List<Categoria>();

            try
            {
                datos = new AccesoDatos();
                datos.setConsulta("Select id, descripcion FROM categorias");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.IdCategoria = (int)datos.Lector["id"];
                    categoria.Descripcion = (string)datos.Lector["descripcion"];

                    categorias.Add(categoria);
                }
                return categorias;
            }

            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

