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

        }
        //Seleccion en el DGV y cambio de PBX.
        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            HelperPresentacion.CargarImagen(PbxArticulos,seleccionado.imagenUrl);
            //Cargar ComboBox de marcas y categorias.
            MarcaSql DataMarca= new MarcaSql();
            CbxMarca.DataSource=DataMarca.ListarMarcas();
            CategoriaSql DataCategoria= new CategoriaSql();
            CbxCategoria.DataSource = DataCategoria.ListarCategorias();
        }

        private void BtnAgregarNuevo_Click(object sender, EventArgs e)
        {
            NuevoRegistro nuevoarticulo= new NuevoRegistro();
            nuevoarticulo.ShowDialog();
            CargarDgv();
        }
        //
    }
}
