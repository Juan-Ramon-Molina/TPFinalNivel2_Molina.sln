using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalNivel2_Molina
{
    public class HelperPresentacion
    {
        //metodos statics de soporte.
        public static void OcultarColumna(DataGridView dgv, string columna)
        {
            dgv.Columns[columna].Visible=false;
        }

        //Metodo de cargar imagen en picturebox.
        public static void CargarImagen(PictureBox pbx,string url)
        {
            try
            {
                pbx.Load(url);
            }
            catch (Exception ex)
            //Imagen alternativa.
            {
                pbx.Load("https://greenshop.ar/wp-content/uploads/2024/06/A.2.37-J.500GR.jpg");
            }
        }

        //Metodo bloquear botones si no hay seleccionado.
        public static void BloqueoBtnSinSeleccionado(DataGridView dgv,params Button[] botones) 
        {
            bool hayseleccionado = dgv.CurrentRow?.DataBoundItem != null;
           
            foreach (Button boton in botones)
            {
               boton.Enabled=hayseleccionado;
            }
        }
    }
}
