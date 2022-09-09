select * from address_Book

Create procedure SpStoreProcedure
	@FirstName varchar(150),		
	@LastName varchar(150),	
	@Address varchar(150),		
	@City varchar(150),	
	@State varchar(150),	
	@Zip varchar(6),
    @PhoneNumber varchar(50),
	@Email varchar(150),	
	@TypeOf varchar(150)
as begin
	Insert into address_Book values(@FirstName,@LastName,@Address,@City,@State,@Zip,@PhoneNumber,@Email,@TypeOf)
End