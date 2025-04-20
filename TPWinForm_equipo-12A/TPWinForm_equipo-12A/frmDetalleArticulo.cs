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
    public partial class frmDetalleArticulo : Form
    {
        private Articulo art;
        private int imagenActual = 0;
        public frmDetalleArticulo(Articulo art)
        {
            InitializeComponent();
            this.art = art;
        }


        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            cargaInicial();
            mostrarImagen();
            cambiarEstado();
            btnEditar.Enabled = true;
            if (art.Imagenes.Count > 1)
            {
                btnImagPrevia.Visible = true;
                btnImagSig.Visible = true;
            }
            else
            {
                btnImagPrevia.Visible = false;
                btnImagSig.Visible = false;
            }
        }

        private void cargaInicial()
        {
            tbNombre.Text = art.Nombre;
            tbPrecio.Text = art.Precio.ToString();
            tbCodigo.Text = art.Codigo;
            tbDescripcion.Text = art.Descripcion;
            cargarMarcas();
            cargarCategorias();
            btnAceptar.Enabled = false;
        }

        private void cambiarEstado()
        {
            tbNombre.ReadOnly = !tbNombre.ReadOnly;
            tbDescripcion.ReadOnly = !tbDescripcion.ReadOnly;
            tbCodigo.ReadOnly = !tbCodigo.ReadOnly;
            tbPrecio.ReadOnly = !tbPrecio.ReadOnly;
            btnEditar.Enabled = !btnEditar.Enabled;

            cbMarca.Enabled = !cbMarca.Enabled;
            cbCategoria.Enabled = !cbCategoria.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
        }

        private void cargarMarcas()
        {
            MarcaNegocio neg = new MarcaNegocio();
            List<Marca> marcas = neg.listar();

            cbMarca.DataSource = marcas;
            cbMarca.Text = art.Marca.ToString();
            cbMarca.DisplayMember = "Descripcion";
        }

        private void cargarCategorias()
        {
            CategoriaNegocio cat = new CategoriaNegocio();
            List<Categoria> categorias = cat.listar();

            cbCategoria.DataSource = categorias;
            cbCategoria.Text = art.Categoria.ToString();
            cbCategoria.DisplayMember = "Descripcion";
        }

        private void mostrarImagen()
        {
            if (art != null &&
                art.Imagenes != null &&
                art.Imagenes.Count > 0)
            {
                try
                {
                    string url = art.Imagenes[imagenActual].ImagenUrl;
                    pbImagenes.Load(url);
                }
                catch
                {
                    pbImagenes.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRDSS5FeaLtelZwa1H2RbgdzrnuUt_oJEP0XA&s");
                }
            }
            else
            {
                pbImagenes.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRDSS5FeaLtelZwa1H2RbgdzrnuUt_oJEP0XA&s");
            }
        }

        private void btnImagPrevia_Click(object sender, EventArgs e)
        {
            if (art?.Imagenes != null && art.Imagenes.Count > 0)
            {
                imagenActual--;
                if (imagenActual < 0)
                    imagenActual = art.Imagenes.Count - 1;

                mostrarImagen();
            }
        }

        private void btnImagSig_Click(object sender, EventArgs e)
        {
            if (art?.Imagenes != null && art.Imagenes.Count > 0)
            {
                imagenActual++;
                if (imagenActual >= art.Imagenes.Count)
                    imagenActual = 0;

                mostrarImagen();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (!validar())
            {
                return;
            }
            if (!cambios())
            {
                MessageBox.Show("Sin cambios.", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            
            art.Nombre = tbNombre.Text;
            art.Codigo = tbCodigo.Text;
            art.Descripcion = tbDescripcion.Text;
            art.Precio = decimal.Parse(tbPrecio.Text);
            art.Marca = (Marca)cbMarca.SelectedItem;
            art.Categoria = (Categoria)cbCategoria.SelectedItem;

            negocio.modificarArticulo(art);
            MessageBox.Show("Artículo actualizado", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cambiarEstado();
            btnAceptar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cambiarEstado();
            btnAceptar.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cambiarEstado();
            cargaInicial();
        }

        private void btnImagenes_Click(object sender, EventArgs e)
        {
            frmImagenes frmImagenes = new frmImagenes(art.IdArticulo);
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            frmImagenes.ShowDialog();

            
            art.Imagenes = imagenNegocio.getImagenesIdArticulo(art.IdArticulo);
            imagenActual = 0;
            mostrarImagen();

            btnImagPrevia.Visible = art.Imagenes.Count > 1;
            btnImagSig.Visible = art.Imagenes.Count > 1;
        }

        private bool validar()
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbCodigo.Text) ||
                string.IsNullOrWhiteSpace(tbDescripcion.Text) || string.IsNullOrWhiteSpace(tbPrecio.Text) ||
                cbMarca.SelectedItem == null || cbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(tbPrecio.Text, out _))
            {
                MessageBox.Show("El precio debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool cambios()
        {
            if (art.Nombre != tbNombre.Text)
                return true;
            if (art.Codigo != tbCodigo.Text)
                return true;
            if (art.Descripcion != tbDescripcion.Text)
                return true;
            if (art.Precio != decimal.Parse(tbPrecio.Text))
                return true;

            Marca marcaSeleccionada = (Marca)cbMarca.SelectedItem;
            Categoria categoriaSeleccionada = (Categoria)cbCategoria.SelectedItem;

            if (art.Marca == null || art.Marca.IdMarca != marcaSeleccionada.IdMarca)
                return true;
            if (art.Categoria == null || art.Categoria.IdCategoria != categoriaSeleccionada.IdCategoria)
                return true;

            return false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
