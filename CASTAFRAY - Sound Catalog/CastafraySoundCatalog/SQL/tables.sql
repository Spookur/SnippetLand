CREATE TABLE Sounds (
SoundId int IDENTITY (1,1) PRIMARY KEY,
Title varchar(50) NOT NULL,
Artist varchar(50) NOT NULL,
[Description] varchar(200) NULL,
FileSize int NULL,
FilePath nvarchar(MAX) NULL

)

DROP TABLE Sounds