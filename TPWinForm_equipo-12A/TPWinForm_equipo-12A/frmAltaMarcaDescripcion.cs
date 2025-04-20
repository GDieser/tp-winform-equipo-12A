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
    public partial class frmAltaMarcaDescripcion : Form
    {
        public frmAltaMarcaDescripcion(bool categoria = false)
        {
            InitializeComponent();
            if (categoria)
            {
                Text = "Alta categoria";
                lblTitulo.Text = "Agregar Categoría";
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                if(lblTitulo.Text == "Agregar Categoría")
                {
                    Categoria auxCat = new Categoria();
                    auxCat.Descripcion = txtDescripcion.Text;
                    categoria.agregarCategoria(auxCat);
                    MessageBox.Show("Categoria agregada.");
                }
                else
                {
                    Marca auxMarca = new Marca();
                    auxMarca.Descripcion = txtDescripcion.Text;
                    marca.agregarMarca(auxMarca);
                    MessageBox.Show("Marca agregada.");
                }


                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
