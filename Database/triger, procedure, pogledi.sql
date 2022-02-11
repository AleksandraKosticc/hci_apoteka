-- ---------------------------
-- --------------------------
-- -----------------------
-- PROCEDURE
-- -----------------------

-- -----------------------
-- dodaj_faktura_stavka
-- -----------------------
delimiter $$
create procedure `dodaj_faktura_stavka`(in pBarkod int, in pKolicina int, in pCijenaStavke decimal(5,2))
begin
    select @last_id_racun := MAX(IdFaktura) from faktura;
	insert into faktura_stavka (IdFaktura, Barkod, Kolicina, CijenaStavke) values ( @last_id_racun, pBarkod, pKolicina, pCijenaStavke);    
end$$
delimiter ;

-- -----------------------
-- dodaj_fakturu
-- -----------------------
delimiter $$
create procedure `dodaj_fakturu`(in pIdProizvodjac int, in pIdKorisnika int)
begin
	insert into faktura (IdFaktura, IdProizvodjac, IdKorisnika) values (null, pIdProizvodjac, pIdKorisnika);
end$$
delimiter ;

-- ------------------------------
-- dodaj_racun_stavka
-- ------------------------------
delimiter $$
create procedure dodaj_racun_stavka(in pBarkod int, in pCijena decimal(5,2), in pKolicina int)
begin

	select @last_id_racun := MAX(IdRacuna) from racun;
	insert into racun_stavka (Barkod, Cijena, Kolicina, IdRacuna) values (pBarkod, pCijena, pKolicina, @last_id_racun);
    
end$$
delimiter ;


-- ------------------------------------------
-- -----------------------
-- TRIGERI
-- -----------------------
-- ------------------------------------------
delimiter $$
create trigger dodaj_faktura_stavka after insert on faktura_stavka
for each row
begin
	declare kolicina int;
    declare iznosCijene decimal(5,2); 
    declare ukupno decimal(8,2);
	select Zaliha from artikal where Barkod = new.Barkod into kolicina;
    select CijenaStavke from faktura_stavka where IdFaktura=new.IdFaktura and Barkod=new.Barkod into iznosCijene;
    select IznosRacuna from faktura where IdFaktura=new.IdFaktura into ukupno;
    
    update artikal set Zaliha = kolicina + new.Kolicina where Barkod = new.Barkod;
    update faktura set IznosRacuna = ukupno + iznosCijene*new.Kolicina where IdFaktura = new.IdFaktura;
end$$
delimiter ;


-- -----------------------
-- dodaj_racun_stavka
-- -----------------------
delimiter $$
create trigger dodaj_racun_stavka after insert on racun_stavka
for each row
begin
	declare kolicina int;
	declare cijenaArtikla decimal(5,2);
	declare ukupno decimal(6,2);
	select Zaliha from artikal where Barkod = new.Barkod into kolicina;
	select Cijena from racun_stavka where IdRacuna = new.IdRacuna and  Barkod = new.Barkod into cijenaArtikla;
    select UkupanIznos from racun where IdRacuna = new.IdRacuna into ukupno;
	if(new.Kolicina <= kolicina) then
		update artikal set Zaliha = kolicina - new.Kolicina where Barkod = new.Barkod;
        update racun set UkupanIznos = ukupno + cijenaArtikla*new.Kolicina where IdRacuna = new.IdRacuna;
	end if;
end$$
delimiter ;
