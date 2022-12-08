using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_Financiero
{
    internal class conectarbd
    {
        string cadena = "Data Source = DESKTOP-IL89A7G\\SQLEXPRESS;Initial Catalog = sistemaFinanciero; Integrated Security = True ";
        public SqlConnection conectarbbd = new SqlConnection();

        public conectarbd()
        {
            
             conectarbbd.ConnectionString = cadena;           

        }


        public void abrir ()
        {
            try
            {
                conectarbbd.Open ();
                Console.WriteLine("Conexion Abierta! :D");
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar D: : " + ex.Message);
            }

            Console.ReadLine();

        }




        public void cerrar ()
        {
            conectarbbd.Close ();

            Console.ReadLine();

        }



       
    }
}
