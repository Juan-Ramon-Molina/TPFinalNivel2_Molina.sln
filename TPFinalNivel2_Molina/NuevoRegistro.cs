using Datos_SQL_;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TPFinalNivel2_Molina
{
    //Modo de pantalla creado, para que la pantalla sirva para tres eventos.
    public enum ModoPantalla
    {
        Alta,
        Modificacion,
        Visualizacion
    }
    public partial class NuevoRegistro : Form
    {
        
        ErrorProvider errorprovider1=new ErrorProvider();
        private ModoPantalla modo= new ModoPantalla();
        private Articulo seleccionado;
        private OpenFileDialog openfile = null;
        
        //Articulo seleccionado viaja por pantalla, caso de ser nuevo(Alta) sera null.
        public NuevoRegistro(ModoPantalla modo, Articulo seleccionado = null)
        {

            InitializeComponent();
                        
            switch (modo)
            {
                case ModoPantalla.Alta:
                    this.modo = modo;
                    Text = "Generar nuevo articulo";
                    errorprovider1.ContainerControl = this;
                    this.seleccionado = seleccionado;
                    break;
                case ModoPantalla.Modificacion:
                    this.modo = modo;
                    Text = "Modificar articulo";
                    errorprovider1.ContainerControl = this;
                    this.seleccionado=seleccionado;
                    break;
                case ModoPantalla.Visualizacion:
                    //En este modo los botones estan bloqueados.
                    this.modo= modo;
                    Text = "Visualizar articulo";
                    errorprovider1.ContainerControl = this;
                    this.seleccionado=seleccionado;
                    BtnCancelar.Enabled = false;
                    BtnCargar.Enabled = false;
                    BtnExaminarImagen.Enabled = false;
                    TbxCodigo.Enabled = false;
                    TbxDescripcion.Enabled = false;
                    TbxPrecio.Enabled = false;
                    TbxImagen.Enabled = false;
                    TbxNombre.Enabled = false;
                    CbxCategoria.Enabled = false;
                    CbxMarca.Enabled = false;
                    break;
            }

        }

        private void NuevoRegistro_Load(object sender, EventArgs e)
        {
            CategoriaSql datacategoria= new CategoriaSql();
            MarcaSql datamarca= new MarcaSql();
            try
            {
                CbxMarca.DataSource = datamarca.ListarMarcas();
                CbxMarca.ValueMember = "Id";
                CbxMarca.DisplayMember = "Descripcion";
                CbxCategoria.DataSource = datacategoria.ListarCategorias();
                CbxCategoria.ValueMember = "Id";
                CbxCategoria.DisplayMember = "Descripcion";

                if (seleccionado != null)
                {
                    TbxCodigo.Text = seleccionado.codigo;
                    TbxNombre.Text= seleccionado.nombre;
                    TbxDescripcion.Text = seleccionado.descripcion;
                    TbxImagen.Text=seleccionado.imagenUrl;
                    HelperPresentacion.CargarImagen(PbxNuevo, TbxImagen.Text);
                    TbxPrecio.Text = seleccionado.precio.ToString();
                    CbxCategoria.SelectedValue = seleccionado.categoria.id;
                    CbxMarca.SelectedValue= seleccionado.marca.id;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Cargar imagen una vez se haya sacado de foco el tbx.
        private void TbxImagen_Leave(object sender, EventArgs e)
        {
            HelperPresentacion.CargarImagen(PbxNuevo, TbxImagen.Text);
        }
        //Examinar pc en busca de imagen.
        private void BtnExaminarImagen_Click(object sender, EventArgs e)
        {
            openfile = new OpenFileDialog();
            openfile.Filter = "jpg|*.jpg";
            if(DialogResult.OK == openfile.ShowDialog())
            {
                TbxImagen.Text = openfile.FileName;
                HelperPresentacion.CargarImagen(PbxNuevo,TbxImagen.Text);
            }
        }
        //Metodo para guardar imagen del openfile.
        public void GuardarImagenOpenFile()
        {
            if (openfile != null && !(TbxImagen.Text.StartsWith("http", StringComparison.OrdinalIgnoreCase)))
            {
                //Newguide origina direcccion unica, tostring tansforma y get extension le agrega la extencion adecuada.
                string nombre =Guid.NewGuid().ToString() + Path.GetExtension(openfile.FileName);
                //Conbina de manera adecuada la ruta de destino.
                string destino = Path.Combine(ConfigurationManager.AppSettings["CarpetaTP.C#2"],nombre);
                File.Copy(openfile.FileName, destino);
            }
            
        }
        //Boton cancelar: Cierra ventana.
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado=MessageBox.Show("¿Desea salir?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(resultado == DialogResult.OK)
            {
                Close();
            } 
        }
        //Proceso de carga. Diferenciaremos los precesos a traves de modo pantalla. 
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            ArticuloSql DataArticulo = new ArticuloSql();
            //Si seleccionado es null significa que es un nuevo registro. Se genera la instancia.
            if (seleccionado == null)
            {
                seleccionado = new Articulo();
            }
            try
            {
                seleccionado.codigo = TbxCodigo.Text;
                seleccionado.nombre = TbxNombre.Text;
                seleccionado.descripcion = TbxDescripcion.Text;
                seleccionado.imagenUrl = TbxImagen.Text;
                seleccionado.precio = decimal.Parse(TbxPrecio.Text);
                seleccionado.categoria=(Categoria)CbxCategoria.SelectedItem;
                seleccionado.marca=(Marca)CbxMarca.SelectedItem;

                switch (modo)
                {
                    case ModoPantalla.Alta:
                        DataArticulo.CrearArticulo(seleccionado);
                        GuardarImagenOpenFile();
                        MessageBox.Show("Articulo generado");
                        Close();
                        break;
                    case ModoPantalla.Modificacion:
                        DataArticulo.ModificarArticulo(seleccionado);
                        GuardarImagenOpenFile();
                        MessageBox.Show("Articulo modificado");
                        Close();
                        break;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
    }
}
