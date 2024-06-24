CREATE TABLE Tedarikci(
TedarikciID INT PRIMARY KEY IDENTITY,
TedarikciAd VARCHAR(255),
Iletisim VARCHAR(255)
);

Create TABLE Urun(
UrunID INT PRIMARY KEY IDENTITY,
UrunAd VARCHAR(255),
StokMiktar INT,
BirimFiyat MONEY, 
TedarikciID INT,
FOREIGN KEY  (TedarikciID) REFERENCES Tedarikci(TedarikciID)
);

CREATE TABLE Musteri(
MusteriID INT PRIMARY KEY IDENTITY,
MusteriAd VARCHAR(255),
Iletisim VARCHAR(255),
Adres VARCHAR(255)
);

CREATE TABLE Siparis(
SiparisID INT PRIMARY KEY IDENTITY,
MusteriID INT,
SiparisTarih DATE,
ToplamTutar MONEY,
SiparisDurum VARCHAR(255),
FOREIGN KEY  (MusteriID) REFERENCES Musteri(MusteriID)
);

CREATE TABLE SiparisDetay(
SiparisID INT,
UrunID INT,
BirimFiyat MONEY,
Adet INT,
FOREIGN KEY  (SiparisID) REFERENCES Siparis(SiparisID),
FOREIGN KEY  (UrunID) REFERENCES Urun(UrunID),
PRIMARY KEY (SiparisID, UrunID)
);

CREATE TABLE Kullanici(
KullaniciID INT PRIMARY KEY IDENTITY,
KullaniciAd VARCHAR(255),
Sifre VARCHAR(50),
Rol VARCHAR(50)
);