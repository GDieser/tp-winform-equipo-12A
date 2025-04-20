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
            cargarMarcas();
            cargarCategorias();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (cbxCampo.Items.Count == 0)
            {
                cbxCampo.Items.Add("Nombre");
                cbxCampo.Items.Add("Marca");
                cbxCampo.Items.Add("Código");
            }
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
                    pbImagenes.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRDSS5FeaLtelZwa1H2RbgdzrnuUt_oJEP0XA&s");
                }
            }
            else
            {
                pbImagenes.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRDSS5FeaLtelZwa1H2RbgdzrnuUt_oJEP0XA&s");
            }
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

            Marca opcionTodos = new Marca { IdMarca = 0, Descripcion = "Todas" };
            marcas.Insert(0, opcionTodos);

            comboMarca.DataSource = marcas;
            comboMarca.DisplayMember = "Descripcion";
        }

        private void cargarCategorias()
        {
            CategoriaNegocio cat = new CategoriaNegocio();
            List<Categoria> categorias = cat.listar();

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

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Articulo articulo = dgvArticulos.Rows[e.RowIndex].DataBoundItem as Articulo;

                abrirFormularioDetalle();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargarArticulos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesata = MessageBox.Show("¿Confirmar acción?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesata == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    negocio.eliminarArticulo(seleccionado.IdArticulo);

                    MessageBox.Show("Eliminación exitosa");
                    cargarArticulos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void abrirFormularioDetalle()
        {
            if (articuloSeleccionado != null) 
            { 
                frmDetalleArticulo modificar = new frmDetalleArticulo(articuloSeleccionado);
                modificar.ShowDialog();
///                cargarArticulos();
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                imagenActual = 0; // reinicia el contador de imágenes
                mostrarImagen();
                actualizarBotonesNavegacion();
            }
        }

        private void detalleTS_Click(object sender, EventArgs e)
        {
            abrirFormularioDetalle();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarArticulos();
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                //Validar
                int marca = ((Marca)comboMarca.SelectedItem).IdMarca;
                int categoria = ((Categoria)comboCat.SelectedItem).IdCategoria;

                if (marca != 0 || categoria != 0)
                {
                    dgvArticulos.DataSource = negocio.filtrarMarca(marca, categoria);
                }
                else
                {
                    cargarArticulos();
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            abrirFormularioDetalle();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnAgregar_Click(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnModificar_Click(sender, e);
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnEliminar_Click(sender, e);
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaMarcaDescripcion nuevo = new frmAltaMarcaDescripcion(true);
            nuevo.ShowDialog();
            cargarArticulos();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAltaMarcaDescripcion nuevo = new frmAltaMarcaDescripcion();
            nuevo.ShowDialog();
            cargarArticulos();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCriterio.Items.Clear();
            string opcion = cbxCampo.SelectedItem.ToString();

            if(opcion != "Código")
            {
                cbxCriterio.Items.Add("Empieza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
            else
            {
                cbxCriterio.Items.Add("Contiene");
            }
        }

        private bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Campos requeridos.");
                return true;
            }
            if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Campos requeridos.");
                return true;
            }

            return false;
        }

        private void btnAgregarAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltro())
                {
                    return;
                }

                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtBoxBuscar.Text;

                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tsmModificarCategoria_Click(object sender, EventArgs e)
        {
            frmAdmiMarcaDescripcion categoria = new frmAdmiMarcaDescripcion(false);
            categoria.ShowDialog();

        }

        private void tsmModificarMarca_Click(object sender, EventArgs e)
        {
            frmAdmiMarcaDescripcion marca = new frmAdmiMarcaDescripcion();
            marca.ShowDialog();
        }
    }
}
