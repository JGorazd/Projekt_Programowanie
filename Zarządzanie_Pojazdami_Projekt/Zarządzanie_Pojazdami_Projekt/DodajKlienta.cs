using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zarzadzanie_Pojazdami
{
    public static class DodajKlienta
    {
        public static void Dodaj()
        {
            Console.Write("Imię: ");
            string imie = Console.ReadLine();
            Console.Write("Nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefon: ");
            string telefon = Console.ReadLine();

            using (var connection = KonfiguracjaBazyDanych.Połączenie())
            {   
                connection.Open();
                string query = "INSERT INTO Klienci (Imie, Nazwisko, Email, Telefon) VALUES (@Imie, @Nazwisko, @Email, @Telefon)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Imie", imie);
                command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Telefon", telefon);

                
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
        }
    }
}
