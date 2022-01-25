-- Nama: Daniel Morantha

CREATE TABLE Admin
(
    ID_Admin INT NOT NULL PRIMARY KEY,
    Nama VARCHAR(50) NOT NULL,
    Kata_Sandi VARCHAR(50) NOT NULL
);


CREATE TABLE Produk
(
    ID_Produk INT NOT NULL PRIMARY KEY,
    Nama VARCHAR(50) NOT NULL,
    Harga INT NOT NULL ,
    Kategori_Produk VARCHAR(50) NOT NULL
);


INSERT INTO admin
( 
 ID_Admin, Nama, Kata_Sandi	
)
VALUES
( 
 1 , "daniel", "d12345"
);