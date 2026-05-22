using System;
using System.Data.SqlClient;

namespace PruebaSonar
{
    class Program
    {
        static void Main(string[] args)
        {
            // VULNERABILIDAD 1: Contraseña hardcodeada en el código (Security). //new commit
            string dbPassword = "SuperSecretPassword123!"; 
            
            Console.WriteLine("Introduce el ID del usuario:");
            string userId = Console.ReadLine();

            // VULNERABILIDAD 2: Inyección SQL brutal (Security)
            string query = "SELECT * FROM Users WHERE Id = " + userId;

            string name = "Marcos";
            
            // CODE SMELL: Uso de consola genérica y bloques vacíos
            try 
            {
                SqlConnection conn = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=" + dbPassword + ";");
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            } 
            catch (Exception ex) 
            {
                // VULNERABILIDAD 3: Exponer detalles internos de la excepción
                Console.WriteLine(ex.Message);
            }
            
            // CODE SMELL: Código inútil y repetido
            int a = 5;
            int b = 5;
            if (a == b) {
                Console.WriteLine("Son iguales");
            }
        }
    }
}