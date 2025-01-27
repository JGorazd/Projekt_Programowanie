using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zarzadzanie_Pojazdami
{
    public static class UsunKlienta
    {
        public static void Usun()
        {
            Console.Write("Podaj ID klienta do usunięcia: ");
            int klientID = int.Parse(Console.ReadLine());

            using (var connection = KonfiguracjaBazyDanych.Połączenie())
            {   
                connection.Open();
                string query = "DELETE FROM Klienci WHERE KlientID = @KlientID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KlientID", klientID);

                
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) deleted.");
            }
        }
    }
}
