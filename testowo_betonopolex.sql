CREATE TABLE towary(
id_towaru SERIAL PRIMARY KEY,
opis_towaru VARCHAR(85),
cena_towaru DECIMAL(9,2));

CREATE TABLE klienci(
nr_klienta SERIAL PRIMARY KEY,
NIP_klienta VARCHAR(15),
nazwa_klienta VARCHAR(45));

CREATE TABLE faktury(
nr_faktury SERIAL PRIMARY KEY,
data_wystawienia date,
cena_razem_bez_podatku DECIMAL(9,2),
podatek DECIMAL(4,2),
cena_razem DECIMAL(9,2),
klienci_nr_klienta INT);

CREATE TABLE adresy(
id_adresu SERIAL PRIMARY KEY,
ulica VARCHAR(45),
nr_domu VARCHAR(8),
nr_lokalu VARCHAR(6),
kod_pocztowy VARCHAR(6),
miasto VARCHAR(30));

CREATE TABLE faktura_towary(
id_faktury int REFERENCES faktury ON DELETE RESTRICT ON UPDATE CASCADE,
id_towaru INT REFERENCES towary ON DELETE RESTRICT ON UPDATE RESTRICT,
ilosc_towaru INT,
cena_laczna_towaru DECIMAL(9,2));

CREATE TABLE adresy_klientow(
klienci_nr_klienta INT REFERENCES klienci ON UPDATE RESTRICT ON DELETE RESTRICT,
adresy_id_adresu INT REFERENCES adresy ON UPDATE RESTRICT ON DELETE RESTRICT,
status VARCHAR(25));

CREATE FUNCTION oblicz_brutto1() RETURNS TRIGGER AS $oblicz_brutto$ BEGIN UPDATE faktury SET cena_razem =
podatek+cena_razem_bez_podatku; RETURN NEW; END; $oblicz_brutto$ LANGUAGE plpgsql;

CREATE TRIGGER obliczanie_brutto AFTER INSERT ON faktury FOR EACH ROW EXECUTE FUNCTION oblicz_brutto1();

CREATE TRIGGER obliczanie_brutto1 AFTER UPDATE OF cena_razem_bez_podatku, podatek ON faktury FOR EACH ROW EXECUTE FUNCTION oblicz_brutto1();
