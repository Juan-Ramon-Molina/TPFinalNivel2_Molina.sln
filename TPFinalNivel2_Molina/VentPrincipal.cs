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
using Datos_SQL_;


namespace TPFinalNivel2_Molina
{
    public partial class VentPrincipal : Form
    {

        public VentPrincipal()
        {
            InitializeComponent();
        }

        private List<Articulo> articulos;

        //Metodo cargar DGV.
        public void CargarDgv()
        {
            ArticuloSql data = new ArticuloSql();
            articulos = data.ListarArticulos();
            DgvArticulos.DataSource = articulos;
            HelperPresentacion.OcultarColumna(DgvArticulos, "id");
            HelperPresentacion.OcultarColumna(DgvArticulos, "ImagenUrl");
        }

        //LOAD. Inicio de ventana.
        private void VentPrincipal_Load(object sender, EventArgs e)
        {
            CargarDgv();
            HelperPresentacion.CargarImagen(PbxArticulos, articulos[0].imagenUrl);
            //Cargar ComboBox de marcas y categorias.
            MarcaSql DataMarca = new MarcaSql();
            CbxMarca.DataSource = DataMarca.ListarMarcas();
            CategoriaSql DataCategoria = new CategoriaSql();
            CbxCategoria.DataSource = DataCategoria.ListarCategorias();
        }
        //Seleccion en el DGV y cambio de PBX.
        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            HelperPresentacion.CargarImagen(PbxArticulos,seleccionado.imagenUrl);
            
        }

        private void BtnAgregarNuevo_Click(object sender, EventArgs e)
        {
            NuevoRegistro nuevoarticulo= new NuevoRegistro(ModoPantalla.Alta);
            nuevoarticulo.ShowDialog();
            CargarDgv();
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            NuevoRegistro visualizar = new NuevoRegistro(ModoPantalla.Visualizacion, seleccionado);
            visualizar.ShowDialog();
            CargarDgv();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            NuevoRegistro modificar=new NuevoRegistro(ModoPantalla.Modificacion,seleccionado);
            modificar.ShowDialog();
            CargarDgv();
        }
        //Mostrar ventana de inactivos.
        private void BtnInacctivos_Click(object sender, EventArgs e)
        {
            VentInactivos inactivos= new VentInactivos();
            inactivos.ShowDialog();
            CargarDgv();
        }
        //Boton quitar, inactiva el articulo.
        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            ArticuloSql data = new ArticuloSql();
            try
            {
                DialogResult rta = MessageBox.Show("¿Desea quitar el articulo?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rta == DialogResult.OK)
                {
                    Articulo seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
                    data.InactivarArticulo(seleccionado.id);
                    MessageBox.Show("Articulo inactivo");
                    CargarDgv();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        //Ventana categorias.
        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            VentAtributos VentCategorias= new VentAtributos(ModoAtributo.Categorias);
            VentCategorias.ShowDialog();
            CargarDgv();
        }
        //Ventana marcas.5
        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            VentAtributos VentMarcas=new VentAtributos(ModoAtributo.Marcas);
            VentMarcas.ShowDialog();
            CargarDgv();
        }
        //Reestablece la tabla.
        private void BtnResetDgv_Click(object sender, EventArgs e)
        {
            CargarDgv();
        }
    }
}
