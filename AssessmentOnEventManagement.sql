/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[User_Id]
      ,[EventType_Id]
      ,[Title]
      ,[Description]
      ,[Address]
      ,[City]
      ,[Owner]
      ,[StartDateTime]
      ,[EndDateTime]
      ,[Created_At]
  FROM [EventManagementSystem].[dbo].[Event]

  /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
  FROM [EventManagementSystem].[dbo].[EventType]

  /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
  FROM [EventManagementSystem].[dbo].[Role]

  /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[DOB]
      ,[Phone_No]
      ,[City]
      ,[Role_Id]
  FROM [EventManagementSystem].[dbo].[UserTbl]