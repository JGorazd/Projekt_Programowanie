using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zarzadzanie_Pojazdami
{
    public static class WyswietlKlientow
    {
        public static void Wyswietl()
        {
            using (var connection = KonfiguracjaBazyDanych.Połączenie())
            {
                string query = "SELECT KlientID, Imie, Nazwisko, Email, Telefon FROM Klienci";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("\nLista klientów:");

                    while (reader.Read())
                    {
                        
                        int klientID = reader.GetInt32(0);         
                        string imie = reader.GetString(1);         
                        string nazwisko = reader.GetString(2);     
                        string email = reader.GetString(3); 
                        string telefon = reader.GetString(4); 

                        
                        Console.WriteLine($"ID: {klientID}, Imię: {imie}, Nazwisko: {nazwisko}, Email: {email}, Telefon: {telefon}");
                    }
                }
            }
        }
    }
}
