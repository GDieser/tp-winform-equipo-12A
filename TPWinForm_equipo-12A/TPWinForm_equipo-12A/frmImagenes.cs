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
    public partial class frmImagenes : Form
    {
        private ImagenNegocio imagenNegocio; 
        public List<Imagen> imagenes;
        private Imagen imagenSel;
        public frmImagenes(int idArt)
        {
            InitializeComponent();
            imagenNegocio = new ImagenNegocio();
            imagenes = imagenNegocio.getImagenesIdArticulo(idArt);
            if (imagenes.Count > 0)
            {
                imagenSel = imagenes[0];
            }
            mostrarImagen();
            cargarListaIm();
        }

        private void cargarListaIm()
        {
            dgvImagenes.DataSource = null;
            dgvImagenes.DataSource = imagenes;
            dgvImagenes.Columns["idArticulo"].Visible = false;
            dgvImagenes.Columns["idImagen"].Visible = false;
        }


        private void dgvImagenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvImagenes.CurrentRow != null)
            {
                imagenSel = dgvImagenes.CurrentRow.DataBoundItem as Imagen;
                mostrarImagen();
            }
        }

        private void mostrarImagen()
        {

            if (imagenSel != null && !string.IsNullOrWhiteSpace(imagenSel.ImagenUrl))
            {
                try
                {
                    pbImagenes.Load(imagenSel.ImagenUrl);
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

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Imagen im = new Imagen();
            im.ImagenUrl = txtUrl.Text;
            im.IdArticulo = imagenSel.IdArticulo;
            try
            {
                imagenNegocio.agregarImagen(im);
                imagenes.Add(im);
                MessageBox.Show("Imagen agregada correctamente");
                cargarListaIm();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar la imagen");
            }

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            try
            {
                imagenSel = dgvImagenes.CurrentRow.DataBoundItem as Imagen;

                if (imagenSel != null)
                {
                    imagenNegocio.borrarImagen(imagenSel.IdImagen);
                    imagenes.Remove(imagenSel);
                    MessageBox.Show("Imagen borrada correctamente");
                    cargarListaIm();
                }else
                {
                    MessageBox.Show("Sin seleccion");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al borrar la imagen");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                imagenSel = dgvImagenes.CurrentRow.DataBoundItem as Imagen;

                if (imagenSel != null)
                {
                    imagenSel.ImagenUrl = txtUrl.Text;
                    imagenNegocio.editarImagen(imagenSel);
                    mostrarImagen();
                    MessageBox.Show("Imagen editada correctamente");
                    
                }
                cargarListaIm();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar la imagen");
            }
        }
    }


}
