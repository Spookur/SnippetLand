USE CMSDB
GO

CREATE TABLE CaseMaster(
CaseId int PRIMARY KEY,
FilingDate DATE NOT NULL,
Agency varchar(100)

)

CREATE TABLE CaseDetails(
DefendantName varchar(100),
DefendantAddress varchar(200)
)

CREATE TABLE CaseCharge(
Charge varchar(300),

)

CREATE TABLE Cases(
CaseId int primary key NOT NULL IDENTITY(1,1),
Details varchar(400) not null,
FilingDate date not null,
Agency varchar(50) null,
DefendantName varchar(50) null,
DefendantAddress varchar(100) null,
Charges varchar(400) null

)