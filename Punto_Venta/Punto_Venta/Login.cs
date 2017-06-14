using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Punto_Venta
{
    class Login
    {

        public void iniciar(String usuario, String contra) {

            Console.WriteLine(usuario);
            Console.WriteLine(contra);

            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=pos; Uid=root; pwd=marces85;");

            conectar.Open();
        }
    }


}
