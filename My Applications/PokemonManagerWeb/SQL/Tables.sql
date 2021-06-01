USE PokemonDB
GO

CREATE TABLE Pokemon(
PokemonID int primary key NOT NULL IDENTITY(1,1),
PokemonName varchar(MAX),
PokemonType varchar(20),
Rarity varchar(20),
IMGFilePath NVARCHAR(MAX) NOT NULL



)