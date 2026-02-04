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

            List<Marca> marcas= DataMarca.ListarMarcas();
            //Agrego el index cero para seleccionar toda la lista.
            marcas.Insert(0,new Marca { id=0,descripcion="Todos"});
            CbxMarca.DataSource = marcas;
            CbxMarca.SelectedIndex= 0;
            CategoriaSql DataCategoria = new CategoriaSql();
            List<Categoria> categorias = DataCategoria.ListarCategorias();
            categorias.Insert(0, new Categoria { id = 0, descripcion = "Todos" });
            CbxCategoria.DataSource = categorias;
            CbxCategoria.SelectedIndex = 0;
        }
        //Seleccion en el DGV y cambio de PBX.
        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            //Si hay fila seleccionada no es null, si el dato enlazado es articulo entra en la variable y en el true.
            if(DgvArticulos.CurrentRow?.DataBoundItem is Articulo seleccionado)
            {
                 HelperPresentacion.CargarImagen(PbxArticulos,seleccionado.imagenUrl);
            }       
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
            TbxBusquedaRapida.Clear();
            CbxCategoria.SelectedIndex = 0;
            CbxMarca.SelectedIndex = 0;

        }

        //Metodo de filtros por marca y categorias combinados.
        public void AplicarFiltrosMarcaCategorias()
        {
            //  Capturar input. Uso "as" por si es null.
            Marca marcaselec = CbxMarca.SelectedItem as Marca;
            Categoria categoriaselec=CbxCategoria.SelectedItem as Categoria;
            //Control de null.
            if (marcaselec == null || categoriaselec == null) 
            {
                return;
            }
            try
            {
                //uso de linq para convinar busqueda. uso de IEnumerable<type>: Se usa en linq para encadenar filtros, recorre coleccion. simil foreach.
                IEnumerable<Articulo> filtrados = articulos;
                //Recorrer lista si el index es distinto a cero, "Todos".
                if (marcaselec.id != 0)
                {
                    // "?"Consulta si no es null, si es null no sigue.
                    filtrados = filtrados.Where(a => a.marca?.id == marcaselec.id);
                }
                if (categoriaselec.id != 0)
                {
                    filtrados = filtrados.Where(c => c.categoria?.id == categoriaselec.id);
                }
                //Tolist emite lista filtrada, con filtro cocatenado entre los dos if, marca y categoria.
                DgvArticulos.DataSource = filtrados.ToList();
                HelperPresentacion.OcultarColumna(DgvArticulos, "ImagenUrl");
                HelperPresentacion.OcultarColumna(DgvArticulos, "Id");
            }
            catch (Exception )
            {

                MessageBox.Show("Error en filtros combinados");
            }

        }
        
        private void CbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltrosMarcaCategorias();    
        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltrosMarcaCategorias();
        }

        //Busqueda rapida, con findall(lamda)
        private void TbxBusquedaRapida_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrorapido;
            //Capturar imput.
            string filtrorapido = TbxBusquedaRapida.Text;

            if (filtrorapido.Length >= 2)
            {
                listafiltrorapido = articulos.FindAll(a => a.codigo.ToUpper().Contains(filtrorapido.ToUpper()) || a.nombre.ToUpper().Contains(filtrorapido.ToUpper()) || a.descripcion.ToUpper().Contains(filtrorapido.ToUpper()));
            }
            else
            {
                listafiltrorapido = articulos;
            }
            //Limpiart tabla.
            DgvArticulos.DataSource = null;
            DgvArticulos.DataSource = listafiltrorapido;
            HelperPresentacion.OcultarColumna(DgvArticulos, "ImagenUrl");
            HelperPresentacion.OcultarColumna(DgvArticulos, "Id");
        }

    }
}
