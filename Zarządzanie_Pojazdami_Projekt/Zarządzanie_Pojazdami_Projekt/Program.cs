using System;

namespace Zarzadzanie_Pojazdami { 
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Dodaj klienta");
                Console.WriteLine("2. Wyświetl klientów");
                Console.WriteLine("3. Usuń klienta");
                Console.WriteLine("4. Dodaj pojazd");
                Console.WriteLine("5. Wyświetl pojazdy");
                Console.WriteLine("6. Usuń pojazd");
                Console.WriteLine("7. Zmień dane klienta"); 
                Console.WriteLine("8. Wyjście");
                Console.Write("Wybierz opcję: ");
                int opcja = int.Parse(Console.ReadLine());

                switch (opcja)
                {
                    case 1:
                        DodajKlienta.Dodaj();
                        break;
                    case 2:
                        WyswietlKlientow.Wyswietl();
                        break;
                    case 3:
                        UsunKlienta.Usun();
                        break;
                    case 4:
                        DodajPojazd.Dodaj();
                        break;
                    case 5:
                        WyswietlPojazdy.Wyswietl();
                        break;
                    case 6:
                        UsunPojazd.Usun();
                        break;
                    case 7:
                        ZmienDaneKlienta.Zmien(); 
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }
            }
        }
    }
}
