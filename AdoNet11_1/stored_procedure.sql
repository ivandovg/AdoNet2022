create procedure DeleteAuthor 
	@id int
as
begin
	delete from Authors where Id = @id
end;

create proc GetAuthorBook
as
begin
SET QUOTED_IDENTIFIER OFF

SELECT  
	A.Firstname + ' ' + A.Lastname as 'Author'
    ,B.[Name] as 'Book'
      ,B.[Pages]
      ,B.[Pubdate]
  FROM [Books] as B
	join Authors as A on A.Id = B.AuthorId
	order by 'Author', 'Book'
end;