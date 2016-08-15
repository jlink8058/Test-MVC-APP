CREATE TABLE [dbo].[Pet](
	[Id] [UniqueIdentifier] NOT NULL,
	[Name] [varchar](75) NOT NULL,
	[Birthday] [date] NOT NULL,
	[Color] [varchar](20) NOT NULL	 
)

CREATE TABLE [dbo].[Dog](
	[DogId] [UniqueIdentifier] NOT NULL,
	[PetId] [UniqueIdentifier] NOT NULL,
	[BreedId] [UniqueIdentifier] NOT NULL
)

CREATE TABLE [dbo].[Cat] (
	[CatId] [UniqueIdentifier] NOT NULL,
	[PetId] [UniqueIdentifier] NOT NULL,
	[BreedId] [UniqueIdentifier] NOT NULL,
)

CREATE TABLE [dbo].[DogBreed] (
	[DogBreedId] [UniqueIdentifier] NOT NULL,
	[DogBreedName] [varchar](50) NOT NULL
)

CREATE TABLE [dbo].[CatBreed] (
	[CatBreedId] [UniqueIdentifier] NOT NULL,
	[CatBreedName] [varchar](50) NOT NULL
)
