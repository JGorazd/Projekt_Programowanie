using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zarzadzanie_Pojazdami
{
    public static class ZmienDaneKlienta
    {
        public static void Zmien()
        {
            Console.Write("Podaj ID klienta do zmiany: ");
            if (!int.TryParse(Console.ReadLine(), out int klientID))
            {
                Console.WriteLine("Podano nieprawidłowy ID klienta.");
                return;
            }

            Console.Write("Nowe imię : ");
            string noweImie = Console.ReadLine();
            Console.Write("Nowe nazwisko : ");
            string noweNazwisko = Console.ReadLine();
            Console.Write("Nowy email : ");
            string nowyEmail = Console.ReadLine();
            Console.Write("Nowy telefon : ");
            string nowyTelefon = Console.ReadLine();

            using (var connection = KonfiguracjaBazyDanych.Połączenie())
            {
                string query = @"
        UPDATE Klienci SET Imie = @NoweImie,Nazwisko = @NoweNazwisko,Email = @NowyEmail,Telefon = @NowyTelefon WHERE KlientID = @KlientID";

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NoweImie",noweImie);
                command.Parameters.AddWithValue("@NoweNazwisko",noweNazwisko);
                command.Parameters.AddWithValue("@NowyEmail",nowyEmail);
                command.Parameters.AddWithValue("@NowyTelefon",nowyTelefon);
                command.Parameters.AddWithValue("@KlientID", klientID);

                
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) updated.");
            }
        }
    }
}
