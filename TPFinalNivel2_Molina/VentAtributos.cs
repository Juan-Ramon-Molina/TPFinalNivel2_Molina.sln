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
    public enum ModoAtributo
    {
        Marcas,
        Categorias
    }
    public partial class VentAtributos : Form
    {
        ModoAtributo modo= new ModoAtributo();
        public VentAtributos(ModoAtributo modo)
        {
            InitializeComponent();
            switch (modo)
            {
                case ModoAtributo.Marcas:
                    Text = "Marcas";
                    this.modo = modo;
                    break;
                case ModoAtributo.Categorias:
                    Text = "Categorias";
                    this.modo = modo;
                    break;
            }
        }
        //Metodo cargar marcas.
        public void CargarDgvMarcas()
        {
            List<Marca> marcas = new List<Marca>();
            MarcaSql datamarca = new MarcaSql();
            marcas = datamarca.ListarMarcas();
            DgvAtributos.DataSource = marcas;
        }
        //Metodo cargar categorias.
        public void CargarDgvCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            CategoriaSql datacategoria = new CategoriaSql();
            categorias = datacategoria.ListarCategorias();
            DgvAtributos.DataSource = categorias;
        }
        private void VentAtributos_Load(object sender, EventArgs e)
        {
            switch (modo)
            {
                case ModoAtributo.Marcas:
                    CargarDgvMarcas();
                    break;
                case ModoAtributo.Categorias:
                    CargarDgvCategorias();
                    break;
            }

        }
        //Boton agregar nombre, genera marca o categoria segun el modo. 
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Desea agregarlo?","Confirmar",MessageBoxButtons.OKCancel);
            if (rta == DialogResult.OK)
            {
                switch (modo)
                {
                    case ModoAtributo.Marcas:
                        try
                        {
                            MarcaSql datamarca = new MarcaSql();
                            Marca nuevamarca = new Marca();
                            nuevamarca.descripcion = TbxAgregar.Text;
                            datamarca.CrearMarca(nuevamarca);
                            MessageBox.Show("Marca creada");
                            CargarDgvMarcas();
                        }
                        catch (Exception ex)
                        {

                            throw ex;
                        }
                        break;
                    case ModoAtributo.Categorias:
                        try
                        {
                            CategoriaSql datacategoria = new CategoriaSql();
                            Categoria nuevacategoria = new Categoria();
                            nuevacategoria.descripcion = TbxAgregar.Text;
                            datacategoria.CrearCategoria(nuevacategoria);
                            MessageBox.Show("Categoria creada");
                            CargarDgvCategorias();
                        }
                        catch (Exception ex)
                        {

                            throw ex;
                        }
                        break;
                }

            }
           
        }
    }
}
