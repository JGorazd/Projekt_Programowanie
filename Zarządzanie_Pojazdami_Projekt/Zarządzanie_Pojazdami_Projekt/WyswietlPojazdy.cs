using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zarzadzanie_Pojazdami
{
    public static class WyswietlPojazdy
    {
        public static void Wyswietl()
        {
            using (var connection = KonfiguracjaBazyDanych.Połączenie())
            {
                string query = @"
                    SELECT PojazdID, NumerRejestracyjny, Marka, Model, RokProdukcji, Imie, Nazwisko
                    FROM Pojazdy 
                    INNER JOIN Klienci ON Pojazdy.KlientID = Klienci.KlientID";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        int pojazdId = reader.GetInt32(0); 
                        string numerRejestracyjny = reader.GetString(1); 
                        string marka = reader.GetString(2); 
                        string model = reader.GetString(3); 
                        int rokProdukcji = reader.GetInt32(4); 
                        string imie = reader.GetString(5); 
                        string nazwisko = reader.GetString(6); 

                       
                        Console.WriteLine($"ID: {pojazdId}, Numer rejestracyjny: {numerRejestracyjny}, Marka: {marka}, Model: {model}, Rok produkcji: {rokProdukcji}, Właściciel: {imie} {nazwisko}");

                        
                    }
                }
            }
        }
    }
}