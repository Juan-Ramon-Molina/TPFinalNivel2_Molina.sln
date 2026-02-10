using Datos_SQL_;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalNivel2_Molina
{
    public partial class VentInactivos : Form
    {
        private ErrorProvider ErrorPro1=new ErrorProvider();
        private List<Articulo> Inactivos;
        public VentInactivos()
        {
            InitializeComponent();
            ErrorPro1.ContainerControl = this;
        }
        public void CargarDgv()
        {
            ArticuloSql data = new ArticuloSql();
            try
            {
                Inactivos = data.ListarInactivos();
                DgvInactivos.DataSource = Inactivos;
                HelperPresentacion.OcultarColumna(DgvInactivos,"Id");
                HelperPresentacion.OcultarColumna(DgvInactivos,"ImagenUrl");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar la tabla.");
            }
        }
        public void SinseleccionBloquearBotones()
        {
            HelperPresentacion.BloqueoBtnSinSeleccionado(DgvInactivos, BtnEliminar, BtnRecuperar, BtnVisualizar);
        }
        //Ventana recien cargada. Los botones nacen apagados para no romper.
        //1- enabled falso en el load. 
        //2-En changed u en otro proceso usar el metodo de bloqueo si no hay seleccion.
        //Se activaran al haber un elemento seleccionado. Incluso si la tabla nace con un solo elemento.

        private void VentInactivos_Load(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnRecuperar.Enabled = false;
            BtnVisualizar.Enabled = false;
            CargarDgv();
            if (DgvInactivos.CurrentRow?.DataBoundItem is Articulo ArtCero)
            {
                HelperPresentacion.CargarImagen(PbxInactivos, ArtCero.imagenUrl);   
            }
        }

        private void DgvInactivos_SelectionChanged(object sender, EventArgs e)
        {
            if(DgvInactivos.CurrentRow?.DataBoundItem is Articulo seleccionado)
            {
                HelperPresentacion.CargarImagen(PbxInactivos, seleccionado.imagenUrl);
            }

            SinseleccionBloquearBotones();
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            //Reutiliza la ventana nuevoregistro.visualizacion.
            Articulo seleccionado = (Articulo)DgvInactivos.CurrentRow.DataBoundItem;
            NuevoRegistro ver=new NuevoRegistro(ModoPantalla.Visualizacion,seleccionado);
            ver.ShowDialog();
        }

        private void BtnRecuperar_Click(object sender, EventArgs e)
        {
            //Modifica el codigo, volviendo el articulo activo.
            ArticuloSql data = new ArticuloSql();
            try
            {
                Articulo seleccionado = (Articulo)DgvInactivos.CurrentRow.DataBoundItem;
                data.RecuperarAriculo(seleccionado.id);
                MessageBox.Show("Atriculo activo");
                CargarDgv();
                SinseleccionBloquearBotones();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al recuperar el registro.");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Elimina de la base de datos.
            DialogResult rta = MessageBox.Show("¿Desea ELIMINAR el articulo?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rta == DialogResult.OK)
            {
                try
                {
                    ArticuloSql data = new ArticuloSql();
                    Articulo seleccionado = (Articulo)DgvInactivos.CurrentRow.DataBoundItem;
                    data.EliminarArticulo(seleccionado.id);
                    MessageBox.Show("Atriculo eliminado");
                    CargarDgv();
                    SinseleccionBloquearBotones();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al eliminar articulo");
                }
            }
              
        }
    }
}
