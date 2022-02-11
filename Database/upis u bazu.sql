use hci_apoteka;

-- -----------------------
-- KORISNIK_VRSTA
-- -----------------------
insert into korisnik_vrsta (IdKorisnikVrsta, NazivKorisnikVrsta, Opis) values (1, 'administrator', null);
insert into korisnik_vrsta (IdKorisnikVrsta, NazivKorisnikVrsta, Opis) values (2, 'magistar farmacije', 'Broj licence 1234-56/15, rok važenja 01.01.2022.');
insert into korisnik_vrsta (IdKorisnikVrsta, NazivKorisnikVrsta, Opis) values (3, 'farmaceutski tehničar', null);
insert into korisnik_vrsta (IdKorisnikVrsta, NazivKorisnikVrsta, Opis) values (4, 'deaktiviran', null);


-- -----------------------
-- KORISNIK
-- -----------------------
insert into korisnik (IdKorisnika, KorisnickoIme, Lozinka, Ime, Prezime, JMBG, Email, AdresaStanovanja, IdKorisnikVrsta, Slika) values
(1, 'root', 'root', 'root', 'root', '0101980100007', 'root@gmail.com', 'Petre br. 5', '1', null);
insert into korisnik (IdKorisnika, KorisnickoIme, Lozinka, Ime, Prezime, JMBG, Email, AdresaStanovanja, IdKorisnikVrsta, Slika) values
(2, 'student', 'student', 'Aleksandra', 'Kostić', '0308983126116', 'aleksandrak@gmail.com', 'Stepe Stepanovica 64', '2', null);

-- -----------------------
-- PROIZVODJAC
-- -----------------------
insert into proizvodjac (IdProizvodjac, Naziv, Adresa, Telefon) values (1,'Hemofarm','Novakovići бб','051/331‐650');
insert into proizvodjac (IdProizvodjac, Naziv, Adresa, Telefon) values (2,'Bosnalijek','Jukićeva б3','033/254-400');
insert into proizvodjac (IdProizvodjac, Naziv, Adresa, Telefon) values (3, 'Krka','Radnička cesta 48, 10000 Zagreb','+ 385 1 631 21 01');
insert into proizvodjac (IdProizvodjac, Naziv, Adresa, Telefon) values (4, 'Nobel','Hasiba Brankovića 9','033/770-633');
insert into proizvodjac (IdProizvodjac, Naziv, Adresa, Telefon) values (5, 'Bayer','51368 Leverkusen, Njemačka','+49 214 30-1');
insert into proizvodjac (IdProizvodjac, Naziv, Adresa, Telefon) values (6, 'Alkaloid','Aleksandar Makedonski 12, 1000 Skoplje','+ 389 2 310 40 00');

- -----------------------
-- ARTIKLI
-- -----------------------
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1111', 'Aspirin',  2000, '500 mg', 'obložena tableta',2.85, 3, '1', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1112', 'Midol', 1000, '100 mg', 'film tablete', 4, 5.34, '1', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1113', 'Aspirin', 500, '500 mg', 'obložena tableta', 2.23, 3.25, '5', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1114', 'Cafetin Cold', 200, '400 mg', 'film tablete', 1.56, 2.20, '6', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1115', 'Septolete', 1500, '400 mg', 'film tablete', 1.23, 2.35, '3', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1116', 'Paracetamol', 1000, '500 mg', 'obložena tableta', 0.83, 1.58, '2', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1117', 'Vizarsin', 1000, '50 mg', 'obložena tableta', 0.90, 1.78, '3', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1118', 'Aksef', 1000, '500 mg', 'film tablete', 0.90, 1.78, '4', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1119', 'Anzibel pastile - ehinaceje', 500, '5 mg', 'obložena tableta', 4.23, 5.78, '4', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1120', 'Anzibel pastile - med i limun', 500, '5 mg', 'obložena tableta', 4.23, 5.78, '4', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1121', 'Anzibel pastile -mentol', 500, '5 mg', 'obložena tableta', 4.23, 5.78, '4', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1122', 'Azax', 700, '500 mg', 'film tablete', 3.23, 4.58, '4', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1123', 'Magnezijum+B kompleks', 700, '400 mg', 'obložena tableta', 1.23, 2.58, '6', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1124', 'Siprobel', 700, '500 mg', 'film tablete', 2.23, 3.58, '4', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1125', 'Pressing', 900, '10 mg', 'film tablete', 1.23, 2.50, '1', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1126', 'AleriX', 900, '120 mg', 'film tablete', 2.23, 3.50, '2', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1127', 'Imunocink za djecu', 1100, '120 mg', 'tablete za zvakanje', 10.00, 12.40, '1', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1128', 'Imunocink za odrasle', 1100, '120 mg', 'tablete za zvakanje', 11.00, 15.40, '1', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1129', 'Febricet', 800, '500 mg', 'obložena tableta', 2.23, 3.50, '1', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1130', 'Deksalgin', 1000, '25 mg', 'film tablete', 2.58, 3.20, '4', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1131', 'Esram', 1000, '10 mg', 'film tablete', 2.20, 2.80, '4', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1132', 'Hernovir', 1000, '200 mg', 'film tablete', 4.20, 5.80, '4', null);
insert into artikal(Barkod, NazivArtikla, Zaliha, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) values
('1133', 'Rhinostop HOT', 1000, '500 mg', 'vrećica', 6.20, 8.10, '2', null);
-- ------------------------
-- FAKTURA
-- ------------------------
insert into faktura(IdFaktura, DatumIzdavanja, IznosRacuna, IdProizvodjac, IdKorisnika) values
(1,'2021-02-01 22:07:21', 100.00, 1, 2);
insert into faktura(IdFaktura, DatumIzdavanja, IznosRacuna, IdProizvodjac, IdKorisnika) values
(2, '2021-02-01 22:07:36', 200.00, 2, 2);
