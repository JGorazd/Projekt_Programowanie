
INSERT INTO Klienci (Imie, Nazwisko, Email, Telefon) VALUES
('Jan', 'Kowalski', 'jan.kowalski@example.com', '123456789'),
('Anna', 'Nowak', 'anna.nowak@example.com', '987654321'),
('Piotr', 'Wisniewski', 'piotr.wisniewski@example.com', '456789123'),
('Maria', 'Zielinska', 'maria.zielinska@example.com', '789123456'),
('Krzysztof', 'Kaminski', 'krzysztof.kaminski@example.com', '321654987');

INSERT INTO Pojazdy (NumerRejestracyjny, Marka, Model, RokProdukcji, KlientID) VALUES
('WX12345', 'Toyota', 'Corolla', 2015, 1),
('KR67890', 'Ford', 'Focus', 2018, 2),
('GD54321', 'Honda', 'Civic', 2017, 3),
('PO98765', 'Volkswagen', 'Golf', 2016, 4),
('WA11223', 'BMW', 'X5', 2020, 5);

INSERT INTO PrzegladyTechniczne (DataPrzegladu, WaznoscDo, PojazdID) VALUES
('2023-01-15', '2024-01-15', 1),
('2023-02-20', '2024-02-20', 2),
('2023-03-10', '2024-03-10', 3),
('2023-04-05', '2024-04-05', 4),
('2023-05-25', '2024-05-25', 5);

INSERT INTO Serwisy (Nazwa, Adres, Telefon) VALUES
('AutoSerwis Kowalski', 'Warszawa, ul. Glowna 10', '222333444'),
('Naprawy Nowak', 'Krakow, ul. Zielona 5', '333444555'),
('Warsztat Wisniewski', 'Gdansk, ul. Morze 15', '444555666'),
('Serwis Zielinska', 'Poznan, ul. Parkowa 20', '555666777'),
('Naprawy Kaminski', 'Wroclaw, ul. Sloneczna 30', '666777888');

INSERT INTO ZgloszeniaNapraw (DataZgloszenia, OpisProblemu, PojazdID, SerwisID) VALUES
('2023-06-01', 'Wymiana oleju', 1, 1),
('2023-06-10', 'Naprawa hamulcow', 2, 2),
('2023-06-15', 'Wymiana opon', 3, 3),
('2023-06-20', 'Naprawa silnika', 4, 4),
('2023-06-25', 'Wymiana akumulatora', 5, 5);

INSERT INTO Czesci (NazwaCzesci, Cena, Ilosc) VALUES
('Filtr oleju', 50.00, 100),
('Klocki hamulcowe', 120.00, 50),
('Opony letnie', 300.00, 20),
('Swiece zaplonowe', 40.00, 200),
('Akumulator', 400.00, 30);

INSERT INTO Naprawy (DataNaprawy, KosztNaprawy, OpisNaprawy, PojazdID, CzescID) VALUES
('2023-06-02', 100.00, 'Wymiana oleju', 1, 1),
('2023-06-11', 240.00, 'Naprawa hamulcow', 2, 2),
('2023-06-16', 1200.00, 'Wymiana opon', 3, 3),
('2023-06-21', 80.00, 'Wymiana swiec zaplonowych', 4, 4),
('2023-06-26', 400.00, 'Wymiana akumulatora', 5, 5);

