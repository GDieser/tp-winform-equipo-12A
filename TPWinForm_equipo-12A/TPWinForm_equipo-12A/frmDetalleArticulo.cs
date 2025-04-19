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

            cbMarca.Enabled = !cbMarca.Enabled;
            cbCategoria.Enabled = !cbCategoria.Enabled;
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
    }


}
