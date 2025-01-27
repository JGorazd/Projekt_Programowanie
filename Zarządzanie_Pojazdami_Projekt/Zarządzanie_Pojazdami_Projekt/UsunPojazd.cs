using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zarzadzanie_Pojazdami
{
    public static class UsunPojazd
    {
        public static void Usun()
        {
            Console.Write("Podaj ID pojazdu do usunięcia: ");
            int pojazdID = int.Parse(Console.ReadLine());

            using (var connection = KonfiguracjaBazyDanych.Połączenie())
            {   
                connection.Open();
                string query = "DELETE FROM Pojazdy WHERE PojazdID = @PojazdID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PojazdID", pojazdID);

                
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) deleted.");
            }
        }
    }
}
