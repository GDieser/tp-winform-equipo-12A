using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class MarcaNegocio
    {

        private AccesoDatos datos;


        public List<Marca> listar()
        {
            List<Marca> marcas = new List<Marca>();

            try
            {
                datos = new AccesoDatos();
                datos.setConsulta("Select id, descripcion FROM marcas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.IdMarca = (int)datos.Lector["id"];
                    marca.Descripcion = (string)datos.Lector["descripcion"];

                    marcas.Add(marca);
                }
                return marcas;
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
