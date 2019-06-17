CREATE DATABASE [repertory]
GO
USE repertory
GO

/*------------------------------------------------------------
-- Table: Users
------------------------------------------------------------*/
CREATE TABLE [Users](
	[idUser]      INT IDENTITY (1,1) NOT NULL ,
	[lastname]    VARCHAR (50) NOT NULL ,
	[firstname]   VARCHAR (50) NOT NULL ,
	[username]    VARCHAR (50) NOT NULL ,
	[mail]        VARCHAR (100) NOT NULL ,
	[password]    VARCHAR (100) NOT NULL  ,
	CONSTRAINT [Users_PK] PRIMARY KEY (idUser)
);


/*------------------------------------------------------------
-- Table: Contacts
------------------------------------------------------------*/
CREATE TABLE [Contacts](
	[idContact]     INT IDENTITY (1,1) NOT NULL ,
	[lastname]      VARCHAR (50) NOT NULL ,
	[firstname]     VARCHAR (50) NOT NULL ,
	[mail]          VARCHAR (100) NOT NULL ,
	[phoneNumber]   VARCHAR (255) NOT NULL ,
	[address]       VARCHAR (255) NOT NULL ,
	[idUser]       INT  NOT NULL  ,
	CONSTRAINT [Contacts_PK] PRIMARY KEY (idContact)

	,CONSTRAINT [Contacts_Users_FK] FOREIGN KEY (idUser) REFERENCES [Users](idUser)
);



