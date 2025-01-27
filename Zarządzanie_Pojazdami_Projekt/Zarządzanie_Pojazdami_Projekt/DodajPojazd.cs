using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zarzadzanie_Pojazdami
{
    public static class DodajPojazd
    {
        public static void Dodaj()
        {
            Console.Write("Numer rejestracyjny: ");
            string numerRejestracyjny = Console.ReadLine();
            Console.Write("Marka: ");
            string marka = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Rok produkcji: ");
            int rokProdukcji = int.Parse(Console.ReadLine());
            Console.Write("ID klienta: ");
            int klientID = int.Parse(Console.ReadLine());

            using (var connection = KonfiguracjaBazyDanych.Połączenie())
            {
                connection.Open();
                string query = "INSERT INTO Pojazdy (NumerRejestracyjny, Marka, Model, RokProdukcji, KlientID) VALUES (@NumerRejestracyjny, @Marka, @Model, @RokProdukcji, @KlientID)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumerRejestracyjny", numerRejestracyjny);
                command.Parameters.AddWithValue("@Marka", marka);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@RokProdukcji", rokProdukcji);
                command.Parameters.AddWithValue("@KlientID", klientID);

                
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
        }
    }
}
