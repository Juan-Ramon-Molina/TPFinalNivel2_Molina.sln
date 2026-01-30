using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_SQL_
{
    public class HelperSql
    {
        //Metodo static para convertir DBnull.
        //Generico para distintos tipos.
        //Si es dbnull devuelve el equivalente a su tipo. Null,vacio,0.
        //Si no convierte el valor que se lee en el type equivvalente.
        //Uso en columnas que aceptan Null, no asi en las NotNull (Id).

        public static T ConvertirDbNull <T>(SqlDataReader lector,string columna)
        {
            if (lector[columna] is DBNull)
            {
                return default;
            }
            else
            {
                return (T)Convert.ChangeType(lector[columna], typeof(T));
            }
        }
    }
}
