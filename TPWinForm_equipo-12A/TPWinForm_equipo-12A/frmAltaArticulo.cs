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
                if (!validarIngresos())
                    return;

                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;


                //Aca deberiamos agregar imagen y consultar si es modificacion
                if (!string.IsNullOrEmpty(txtUrlImagen.Text))
                {
                    if (articulo.Imagenes == null)
                        articulo.Imagenes = new List<Imagen>();

                    Imagen imagen = new Imagen();
                    imagen.ImagenUrl = txtUrlImagen.Text;

                    articulo.Imagenes.Add(imagen);
                }

                if (articulo.IdArticulo != 0)
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
                cbxMarca.ValueMember = "IdMarca";
                cbxMarca.DisplayMember = "Descripcion";

                cbxCategoria.DataSource = categoria.listar();
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();

                    //Aca deberian ir cat, marca y url
                    txtUrlImagen.Text = articulo.UrlImagen;
                    txtUrlImagen.ReadOnly = true;
                    cargarImagen(articulo.UrlImagen);
                    cbxCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                    cbxMarca.SelectedValue = articulo.Marca.IdMarca;

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

        private bool validarIngresos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Codigo es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Nombre es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Descripcion es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Precio es obligatorio.");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("Debe ingresar un precio valido (solo numeros).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUrlImagen.Text))
            {
                MessageBox.Show("Debe ingresar una URL de imagen.");
                return false;
            }

            return true;
        }

        private void btnMasMarca_Click(object sender, EventArgs e)
        {
            frmAltaMarcaDescripcion nuevo = new frmAltaMarcaDescripcion();
            nuevo.ShowDialog();
            MarcaNegocio marca = new MarcaNegocio();
            cbxMarca.DataSource = marca.listar();
        
        }

        private void btnMasCategoria_Click(object sender, EventArgs e)
        {
            frmAltaMarcaDescripcion nuevo = new frmAltaMarcaDescripcion(true);
            nuevo.ShowDialog();
            CategoriaNegocio categoria = new CategoriaNegocio();
            cbxCategoria.DataSource = categoria.listar();

        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
