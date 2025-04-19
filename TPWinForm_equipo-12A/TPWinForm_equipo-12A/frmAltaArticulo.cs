using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Servicio;

namespace TPWinForm_equipo_12A
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulo nuevoArt   = new Articulo();

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;  


                //Aca deberiamos agregar imagen y consultar si es modificacion

                if(articulo.IdArticulo != 0)
                {
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Articulo modificado.");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                }                
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                //Acá los deplegables
                cbxMarca.DataSource = marca.listar();
                cbxCategoria.DataSource = categoria.listar();

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();

                    //Aca deberian ir cat, marca y url
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                //Para el pb de imagenes
                pboxAltaArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                //Carga por defecto
                pboxAltaArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRDSS5FeaLtelZwa1H2RbgdzrnuUt_oJEP0XA&s");
            }

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
    }
}
