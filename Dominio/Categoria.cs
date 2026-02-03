using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Nombre")]
        public string descripcion { get; set; }

        //Sobre escribir el metodo ToString, para que muestre la descripcion.
        
        public override string ToString()
        {
            return descripcion;
        }
    }
}
