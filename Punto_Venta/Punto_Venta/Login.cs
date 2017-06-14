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

            List<string> nombre = new List<string>();
            List<string> pass = new List<string>(); ;

            string conexion = "server=localhost; database=pos; Uid=root; pwd=marces85;";
            MySqlConnection conn = new MySqlConnection(conexion);
            conn.Open();
            
            string query = "select * from pos.usuarios";

            MySqlCommand mycomand = new MySqlCommand(query, conn);
            MySqlDataReader myreader = mycomand.ExecuteReader();
            

            while (myreader.Read()){
                
                nombre.Add(myreader["nombre"].ToString());
                pass.Add(myreader["contra"].ToString());
            }
            conn.Close();

            //nombre.ForEach(Console.WriteLine);
            //pass.ForEach(Console.WriteLine);

            for (int i = 0; i < nombre.Count; i++) {

                if (usuario.Equals(nombre[i]) && contra.Equals(pass[i]))
                {
                    Console.WriteLine("correcto");
                    System.Windows.MessageBox.Show("Bienvenido");
                }
                else {
                    if(i < nombre.Count-1) {

                        System.Windows.MessageBox.Show("Usuario y/o Contraseña " +
                        "Inválidos");
                    }
                }
            }
        }
    }


}
