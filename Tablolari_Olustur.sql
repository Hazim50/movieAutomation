--create table IMDB

use IMDB

create table Filmler(
film_id int primary key identity(1,1) not null,
film_adi nvarchar(50) not null,
yonetmen nvarchar(30),
basrol nvarchar(30),
tur nvarchar(20) not null,
yil datetime not null,
imdb_puani float not null,
yildiz float,
sure int,
dil nvarchar(30),
yildiz_sayisi int)

create table Kullanicilar(
kullanici_id int primary key identity(1,1) not null,
ad nvarchar(30) not null,
soyad nvarchar(30) not null,
tel nvarchar(15),
dogum_tarihi datetime not null,
mail nvarchar(50) not null,
kullanici_adi nvarchar(30) not null,
sifre nvarchar(30) not null)

create table Yorumlar(
yorum_id int primary key identity(1,1) not null,
kullanici_adi nvarchar(30),
film_id int not null,
yorum_tarihi datetime not null,
yorum_metni nvarchar(250) not null)


