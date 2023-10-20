GO
CREATE PROCEDURE Sales.CreditCardGetAll
AS
BEGIN
	SELECT c.CreditCardID,c.CardType,c.CardNumber,c.ExpMonth,c.ExpYear
	FROM Sales.CreditCard c
END
GO


GO
/****** Object:  StoredProcedure [Sales].[CreditCardSave]    Script Date: 29/9/2023 18:36:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



create   proc [Sales].[CreditCardSave]

@CreditCardId int,
@CardType varchar(50),
@CardNumber varchar(100),
@ExpMonth int,
@ExpYear	int

as

	begin

		declare @resultado as table
		(
		estado int,
		mensaje varchar(500)
		)

		--insercion o actualizacion
		if ISNULL(@CreditCardId,0)=0
			begin
				insert sales.CreditCard (CardType,CardNumber,ExpMonth,ExpYear,ModifiedDate)
				values (@CardType,@CardNumber,@ExpMonth,@ExpYear,getdate())
			end
		else
			begin
				update sales.CreditCard set CardType=@CardType,CardNumber=@CardNumber,ExpMonth=@ExpMonth,ExpYear=@ExpYear,ModifiedDate=GETDATE() 
				where CreditCardId=@CreditCardId
			end

		insert @resultado values (1,'Saved')

		select * from @resultado
	end
GO

GO
CREATE PROCEDURE Sales.CreditCardDelete

@CREDITCARDID INT

AS
BEGIN
	DELETE FROM [Sales].[CreditCard]
	WHERE CreditCardID=@CREDITCARDID
	SELECT 1 AS ESTADO,'CreditCard Deleted' as MENSAJE

END