USE PokemonDB
GO

CREATE PROC PokemonAddOrEdit
@PokemonID int,
@PokemonName varchar(MAX),
@PokemonType varchar(20),
@Rarity varchar(20),
@IMGFilePath NVARCHAR(MAX)
AS

	IF @PokemonID=0
		INSERT INTO Pokemon(PokemonName, PokemonType, Rarity, IMGFilePath)
		VALUES (@PokemonName, @PokemonType, @Rarity, @IMGFilePath)
	ELSE
		UPDATE Pokemon
		SET
		PokemonName=@PokemonName,
		PokemonType=@PokemonType,
		Rarity=@Rarity,
		IMGFilePath=@IMGFilePath
		WHERE PokemonID=@PokemonID
GO

CREATE PROC PokemonViewAll
AS
	SELECT * FROM Pokemon
GO

CREATE PROC PokemonViewByID
@PokemonID int
AS

	SELECT * 
	FROM Pokemon
	WHERE PokemonID = @PokemonID
GO


CREATE PROC PokemonDeleteByID
@PokemonID int
AS
	DELETE FROM Pokemon
	WHERE PokemonID=@PokemonID