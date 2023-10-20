GO
CREATE PROCEDURE Production.LocationGetAll
AS
BEGIN
	SELECT l.LocationID,l.Name,l.CostRate,l.Availability
	FROM Production.Location l
END
GO


GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



create   proc [Production].[LocationSave]

@LOCATIONID INT,
@NAME NVARCHAR (50),
@COSTRATE SMALLMONEY,
@AVAILABILITY DECIMAL(8,2)

as

	begin

		declare @resultado as table
		(
		estado int,
		mensaje varchar(500)
		)

		--insercion o actualizacion
		if ISNULL(@LOCATIONID,0)=0
			begin
				insert Production.Location(LocationID,Name,CostRate,Availability,ModifiedDate)
				values (@LOCATIONID,@NAME,@COSTRATE,@AVAILABILITY,getdate())
			end
		else
			begin
				update Production.Location set Name=@NAME,CostRate=@COSTRATE,Availability=@AVAILABILITY,ModifiedDate=GETDATE() 
				where LocationID=@LOCATIONID
			end

		insert @resultado values (1,'Saved')

		select * from @resultado
	end
GO

GO
CREATE PROCEDURE Production.LocationDelete

@LOCATIONID INT

AS
BEGIN
	DELETE FROM [Production].[Location]
	WHERE LocationID=@LOCATIONID
	SELECT 1 AS ESTADO,'Location Deleted' as MENSAJE

END