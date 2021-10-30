USE [EventManagementSystem]
GO
/****** Object:  StoredProcedure [dbo].[CreateEvent]    Script Date: 25-10-2021 17:48:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CreateEvent](

@User_Id int,
@EventType_Id int,
@Title varchar(100),
@Description varchar(500),
@Address varchar(250),
@City varchar(100),
@Owner varchar(150),
@StartDateTime datetime,
@EndDateTime datetime

)
AS

BEGIN TRY

	Insert into Event(User_Id,EventType_Id,Title,Description,Address,City,Owner,StartDateTime,EndDateTime)
	values(@User_Id,@EventType_Id,@Title,@Description,@Address,@City,@Owner,@StartDateTime,@EndDateTime)

END TRY

BEGIN CATCH

DECLARE @Message varchar(MAX) = ERROR_MESSAGE(),
@Severity int = ERROR_SEVERITY(),
@State smallint = ERROR_STATE()

RAISERROR (@Message, @Severity, @State)

END CATCH;
GO

EXECUTE [CreateEvent] @User_Id = 5,@EventType_Id = 2,@Title = 'xyz',@Description = 'nothing to say',
@Address = 'kuruku sandhu',@City = 'dubai',@Owner = 'Vadivel',@StartDateTime = '2021-10-10',@EndDateTime = '2021-11-11';


/****** Object:  StoredProcedure [dbo].[DeleteEvent]    Script Date: 25-10-2021 17:48:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[DeleteEvent]
@Id int 

As
Begin Try

Delete from Event
where Id = @Id

End Try
BEGIN CATCH

DECLARE @Message varchar(MAX) = ERROR_MESSAGE(),
@Severity int = ERROR_SEVERITY(),
@State smallint = ERROR_STATE()

RAISERROR (@Message, @Severity, @State)

END CATCH;
GO


EXECUTE [DeleteEvent] @Id = 3;



/****** Object:  StoredProcedure [dbo].[EditEvent]    Script Date: 25-10-2021 17:48:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Proc [dbo].[EditEvent]

@Id int,
@User_Id int,
@EventType_Id int,
@Title varchar(100),
@Description varchar(500),
@Address varchar(250),
@City varchar(100),
@Owner varchar(150),
@StartDateTime datetime,
@EndDateTime datetime

As

Begin Try

Update Event set
User_Id = @User_Id, 
EventType_Id = @EventType_Id, 
Title = @Title, 
Description = @Description,
Address = @Address,
City = @City,
Owner = @Owner,
StartDateTime = @StartDateTime,
EndDateTime = @EndDateTime
where Id = @Id;

End Try
BEGIN CATCH

DECLARE @Message varchar(MAX) = ERROR_MESSAGE(),
@Severity int = ERROR_SEVERITY(),
@State smallint = ERROR_STATE()

RAISERROR (@Message, @Severity, @State)

END CATCH;
GO

EXECUTE [EditEvent] @Id = 4,@User_Id = 5,@EventType_Id = 2,@Title = 'xyz',@Description = 'nothing to say',@Address = 'kuruku sandhu',@City = 'dubai',@Owner = 'Vadivel',@StartDateTime = '2021-10-10',@EndDateTime = '2021-11-11';


/****** Object:  StoredProcedure [dbo].[GetAllEvents]    Script Date: 25-10-2021 17:48:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[GetAllEvents]

as
Begin Try

SELECT  E.Id,Title,Description,Address,City,Owner,Et.Name,StartDateTime,EndDateTime
FROM Event E
join EventType Et on E.EventType_Id = Et.Id;

End Try

Begin Catch
SELECT ERROR_NUMBER() AS ERRORNO,ERROR_LINE() AS ERRORLINE,ERROR_MESSAGE() AS ERRORMSG,
ERROR_PROCEDURE() AS ERRORPROCEDURE,ERROR_SEVERITY() AS ERRORSEVERITY
END CATCH;

GO

EXECUTE [GetAllEvents];





/****** Object:  StoredProcedure [dbo].[GetEventById]    Script Date: 25-10-2021 17:48:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[GetEventById]
@Id int

As
Begin Try

SELECT Title,Description,Address,City,Owner,Et.Name,StartDateTime,EndDateTime
FROM Event E
join EventType Et on E.EventType_Id = Et.Id
where E.Id = @Id;

End try

Begin Catch
SELECT ERROR_NUMBER() AS ERRORNO,ERROR_LINE() AS ERRORLINE,ERROR_MESSAGE() AS ERRORMSG,
ERROR_PROCEDURE() AS ERRORPROCEDURE,ERROR_SEVERITY() AS ERRORSEVERITY
END CATCH;


GO

EXECUTE [GetEventById] @Id = 1;