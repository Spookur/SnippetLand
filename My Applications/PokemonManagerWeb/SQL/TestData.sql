USE PokemonDB
GO

SET IDENTITY_INSERT Pokemon ON;

INSERT INTO Pokemon(PokemonID, PokemonName, PokemonType, Rarity, IMGFilePath)
	VALUES(1, 'Bulbasaur', 'Grass', 'Uncommon', '/Images/bulbasaur.jpg')

SET IDENTITY_INSERT Pokemon OFF;