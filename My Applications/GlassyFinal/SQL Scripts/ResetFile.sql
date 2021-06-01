

EXEC GlassyDbReset



	SET IDENTITY_INSERT Glass ON;

	INSERT INTO Glass(GlassId, Title, Details, Price)
	VALUES(1, 'Grandpappy', 'The oldest water pipe with a modern twist.', '149.99'),
	(2, 'Delta White', 'OHHHHHH F*CK YEAH!', '229.99'),
	(3, 'Freaky Deeky', 'Get blazed on Halloween.', '179.99'),
	(4, 'Mighty Pipe', 'Mighty Pipe. That is all.', '89.99')
	
	SET IDENTITY_INSERT Glass OFF;

	SET IDENTITY_INSERT Coffee ON;

	INSERT INTO Coffee(CoffeeId, Title, Details, Price)
	VALUES(1, 'Ethiopian Wheat', 'Fresh out of Ethiopia.', '19.99'),
	(2, 'Crystal Waters', 'The best light blend of beans.', '21.99'),
	(3, 'Berto Black Beans', 'The best dark blend of beans.', '22.99')

	SET IDENTITY_INSERT Coffee OFF;

	SET IDENTITY_INSERT Paper ON;

	INSERT INTO Paper(PaperId, Title, Details, Price)
	VALUES(1, 'Not Raws', 'These papers are NOT raw.', '3.99'),
	(2, 'Jilly Jilly Joints', 'Papers brought to you by Jilly.', '4.99')
	
	
	SET IDENTITY_INSERT Paper OFF;


	