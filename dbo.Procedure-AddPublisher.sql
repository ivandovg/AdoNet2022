CREATE PROCEDURE [dbo].[AddPublisher]
	@name nvarchar(200),
	@addres nvarchar(400),
	@contacts nvarchar(200),
	@publisherId int output
AS
begin
	begin try
		insert into Publisher values (@name, @addres, @contacts);
		set @publisherId = SCOPE_IDENTITY();
		return 1
	end try
	begin catch
		set @publisherId = -1
		rollback tran
		return 0
	end catch
end