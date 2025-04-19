using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Servicio;
using Dominio;

namespace TPWinForm_equipo_12A
{
    public partial class frmPrincipal : Form
    {
        private Articulo articuloSeleccionado;
        private int imagenActual = 0;
        private MarcaNegocio neg;

        public frmPrincipal()
        {
            InitializeComponent();
            cargarArticulos();
            dgvArticulos.SelectionChanged += dgvArticulos_SelectionChanged;
            cargarMarcas();
            cargarCategorias();
        }

        private void cargarArticulos()
        {
            ArticuloNegocio art = new ArticuloNegocio();
            List<Articulo> lista = art.listar();

            dgvArticulos.DataSource = lista;

            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;

            dgvArticulos.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvArticulos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvArticulos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            if (dgvArticulos.Rows.Count > 0)
            {
                dgvArticulos.Rows[0].Selected = true; // seleccionar la primera fila
                dgvArticulos_SelectionChanged(null, null); // simular cambio de selección
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            imagenActual = 0;
            if (dgvArticulos.CurrentRow != null)
            {
                articuloSeleccionado = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
                mostrarImagen();
                actualizarBotonesNavegacion();
            }

        }

        private void mostrarImagen()
        {
            if (articuloSeleccionado != null &&
                articuloSeleccionado.Imagenes != null &&
                articuloSeleccionado.Imagenes.Count > 0)
            {
                try
                {
                    string url = articuloSeleccionado.Imagenes[imagenActual].ImagenUrl;
                    pbImagenes.Load(url);
                }
                catch
                {
                    pbImagenes.Image = null;
                }
            }
            else
            {
                pbImagenes.Image = null;
            }
            MessageBox.Show($"Imagen actual: {imagenActual}\nTotal imágenes: {articuloSeleccionado.Imagenes.Count}\nURL: {articuloSeleccionado.Imagenes[imagenActual].ImagenUrl}");

        }

        private void btnImagenPrevia_Click(object sender, EventArgs e)
        {
            if (articuloSeleccionado?.Imagenes != null && articuloSeleccionado.Imagenes.Count > 0)
            {
                imagenActual--;
                if (imagenActual < 0)
                    imagenActual = articuloSeleccionado.Imagenes.Count - 1;

                mostrarImagen();
                actualizarBotonesNavegacion();
            }
        }

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            if (articuloSeleccionado?.Imagenes != null && articuloSeleccionado.Imagenes.Count > 0)
            {
                imagenActual++;
                if (imagenActual >= articuloSeleccionado.Imagenes.Count)
                    imagenActual = 0;

                mostrarImagen();
                actualizarBotonesNavegacion();
            }
        }
        private void cargarMarcas()
        {
            MarcaNegocio neg = new MarcaNegocio();
            List<Marca> marcas = neg.listar();

            // Agregar opción "Todos"
            Marca opcionTodos = new Marca { IdMarca = 0, Descripcion = "Todas" };
            marcas.Insert(0, opcionTodos);

            comboMarca.DataSource = marcas;
            comboMarca.DisplayMember = "Descripcion";
        }

        private void cargarCategorias()
        {
            CategoriaNegocio cat = new CategoriaNegocio();
            List<Categoria> categorias = cat.listar();

            // Agregar opción "Todos"
            Categoria opcionTodos = new Categoria { IdCategoria = 0, Descripcion = "Todas" };
            categorias.Insert(0, opcionTodos);

            comboCat.DataSource = categorias;
            comboCat.DisplayMember = "Descripcion";
        }

        private void actualizarBotonesNavegacion()
        {
            bool habilitar = articuloSeleccionado?.Imagenes != null && articuloSeleccionado.Imagenes.Count > 1;

            btnImagenPrevia.Enabled = habilitar;
            btnImagenSiguiente.Enabled = habilitar;

            btnImagenPrevia.BackColor = habilitar ? SystemColors.Control : SystemColors.ControlLight;
            btnImagenSiguiente.BackColor = habilitar ? SystemColors.Control : SystemColors.ControlLight;
        }
    }
}
