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
    public partial class frmAdmiMarcaDescripcion : Form
    {
        private List<Categoria> listaCategorias;
        private List<Marca> listaMarcas;
        private bool esMarca;

        public frmAdmiMarcaDescripcion(bool marca = true)
        {
            InitializeComponent();
            dgvAdministrar.SelectionChanged += dgvAdministrar_SelectionChanged;
            esMarca = marca;

            if (marca)
            {
                cargarMarcas();
            }
            else
            {
                cargarCategorias();
            }

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void dgvAdministrar_SelectionChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = dgvAdministrar.CurrentRow != null;
            btnEliminar.Enabled = dgvAdministrar.CurrentRow != null;
        }

        private void cargarCategorias()
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            listaCategorias = categoria.listar();
            dgvAdministrar.DataSource = listaCategorias;
        }

        private void cargarMarcas()
        {
            MarcaNegocio marca = new MarcaNegocio();
            listaMarcas = marca.listar();
            dgvAdministrar.DataSource = listaMarcas;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Confirmar acción?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (esMarca)
                    {
                        Marca seleccionada = (Marca)dgvAdministrar.CurrentRow.DataBoundItem;
                        MarcaNegocio negocioMarca = new MarcaNegocio();
                        negocioMarca.eliminarMarca(seleccionada.IdMarca);
                    }
                    else
                    {
                        Categoria seleccionada = (Categoria)dgvAdministrar.CurrentRow.DataBoundItem;
                        CategoriaNegocio negocioCategoria = new CategoriaNegocio();
                        negocioCategoria.eliminarCategoria(seleccionada.IdCategoria);
                    }

                    MessageBox.Show("Eliminación exitosa");

                    // Recargar la grilla
                    if (esMarca)
                        cargarMarcas();
                    else
                        cargarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAdministrar.CurrentRow == null || string.IsNullOrWhiteSpace(txtModificar.Text))
            {
                MessageBox.Show("Debes escribir una nueva descripcion.");
                return;
            }

            string nuevaDescripcion = txtModificar.Text.Trim();

            DialogResult resultado = MessageBox.Show("¿Confirmar acción?", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes)
                return;

            try
            {
                if (esMarca)
                {
                    Marca seleccionada = (Marca)dgvAdministrar.CurrentRow.DataBoundItem;
                    seleccionada.Descripcion = nuevaDescripcion;

                    MarcaNegocio negocio = new MarcaNegocio();
                    negocio.modificarMarca(seleccionada);
                }
                else
                {
                    Categoria seleccionada = (Categoria)dgvAdministrar.CurrentRow.DataBoundItem;
                    seleccionada.Descripcion = nuevaDescripcion;

                    CategoriaNegocio negocio = new CategoriaNegocio();
                    negocio.modificarCategoria(seleccionada);
                }

                MessageBox.Show("Modificación exitosa.");

                
                if (esMarca)
                    cargarMarcas();
                else
                    cargarCategorias();

                txtModificar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
