using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBManager;
using dominio;

namespace winform_app
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
            CBcampo.Items.Add("Precio");
            CBcampo.Items.Add("Marca");
            CBcampo.Items.Add("Categoria");
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();            
            
        }

        private void dgbArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo) dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagenes[0].ImagenUrl);
            }
                   
        }

        private void cargar()
        {
            ArticuloManager articuloManager = new ArticuloManager();
            try
            {
                listaArticulos = articuloManager.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["id"].Visible = false;
                pbArticulo.Load(listaArticulos[0].Imagenes[0].ImagenUrl);
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
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbArticulo.Load("https://louisville.edu/history/images/noimage.jpg/");
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta =new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void Tbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Articulo> listaArticulosBuscados;
            string filtro = Tbusqueda.Text;
            if(filtro != "")
            {
                listaArticulosBuscados = listaArticulos.FindAll(i => i.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaArticulosBuscados = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaArticulosBuscados;
        }

        private void CbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string OpcionCampo = CBcampo.SelectedItem.ToString();
            if (OpcionCampo == "Precio")
            {
                CbCriterio.Items.Clear();
                CbCriterio.Items.Add("Mayor a");
                CbCriterio.Items.Add("Menor a");
            }
        }
    }
}
