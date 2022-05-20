select * from [dbo].[vw_UsersAndUserRole]

-- Tạo view cho bảng User và User Role (nhằm xác định Users thuộc User Role nào?)
create view vw_UsersAndUserRole
as
select [Id], [DisplayNameUser], [UserName], [PassWord], [DisplayNameRole]
from [dbo].[Users] users, [dbo].[UserRole] userRole
where users.IdRole = userRole.RoleId


--Tạo view Food / Suplier / Input (nhằm xác định Thời gian nhập hàng của Thực phẩm, và xác định nhà Phân phối)
select * from [dbo].[vw_SuplierFoodInput]

create view vw_SuplierFoodInput
   as 
   select [DisplayName],[Address],[DisplayNameFood],[Quantity],[DateOfManufacture],[ExpirationDate],[IdInput],[CountInput],[InputPrice],[StatusInput],[TotalPrice],[DateInput]
   from 
  [dbo].[Suplier] suplier,
[dbo].[Food] food,
[dbo].[Input] input,
[dbo].[InputInfo] inputinfo
   where suplier.Id=food.IdSuplier and inputinfo.IdFood= food.FoodId and input.InputId = inputinfo.IdInput

 --Tạo view Food / Ouput / Customer (nhằm xác định Thời gian xuất hàng của Thực phẩm, và xác định người Tiêu thụ sản phẩm)
select * from [dbo].[vw_CustomerFoodOuput]

create view vw_CustomerFoodOuput
   as 
   select [DisplayNameCustomer],[Address],[DisplayNameFood],[Quantity],[DateOfManufacture],[ExpirationDate],[IdOutput],[CountOutput],[OutputPrice],[StatusOutput],[TotalPrice],[DateOutput]
   from 
  [dbo].[Customer] customer,
[dbo].[Food] food,
[dbo].[Output] output,
[dbo].[OutputInfo] outputinfo
--[dbo].[InputInfo] inputinfo
	where customer.CustomerId= outputinfo.IdCustomer and outputinfo.IdFood= food.FoodId and output.outputId = outputinfo.IdOutput 
--and inputinfo.IdFood= food.FoodId


--tao procedure add/ update / delete
--User
CREATE PROC PRC_ADD_USER (@DisplayNameUser nvarchar(max),
							@UserName nvarchar(100),
							@PassWord nvarchar(max),@IdRole int)
as
begin
	insert Users values (@DisplayNameUser,@UserName,@PassWord,@IdRole)
end

exec PRC_ADD_USER 'Gia Vinh' ,'vinh123', '123', '1'
Select * from Users

--Update
CREATE PROC PRC_UPDATE_USER(@Id int,
							@DisplayNameUser nvarchar(max),
							@UserName nvarchar(100),
							@PassWord nvarchar(max),@IdRole int)
as
begin
	update Users
	set 
	[DisplayNameUser] = @DisplayNameUser,
	[UserName] = @userName,
	[Password] = @password,
	[IdRole] = @IdRole
	where [Id] = @Id
end
exec PRC_UPDATE_USER '3','Gia Vinh', 'vinh1234', '123', '2'
Select * from Users

--Delete
CREATE PROC PRC_DELETE_USER(@Id int)
as
begin
	delete Users where Id = @Id
end
exec PRC_DELETE_USER '3'

Select * from Users


--tao procedure add/ update / delete
--Nhà cung cấp
CREATE PROC PRC_ADD_SUPLIER (@DisplayName nvarchar(max),
							@Address nvarchar(max),
							@Phone nvarchar(20),@Email nvarchar(200),
							@MoreInfo nvarchar(max),@ContractDate Date)
as
begin
	insert Suplier values (@DisplayName,@Address,@Phone,@Email,@MoreInfo,@ContractDate)
end

exec PRC_ADD_SUPLIER 'Vinamilk' ,'25 Phat Thanh', '02839890800', 'vinamilk@gmail.com' ,'A1' ,'2022/06/20'
Select * from Suplier

--Update
CREATE PROC PRC_UPDATE_SUPLIER(@Id int, @DisplayName nvarchar(max),
							@Address nvarchar(max),
							@Phone nvarchar(20),@Email nvarchar(200),
							@MoreInfo nvarchar(max),@ContractDate Date)
as
begin
	update Suplier
	set 
	[DisplayName] = @DisplayName,
	[Address] = @Address,
	[Phone] = @Phone,
	[Email] = @Email,
	[MoreInfo] = @MoreInfo,
	[ContractDate] = @ContractDate
	where [Id] = @Id
end

exec PRC_UPDATE_SUPLIER '2', 'Vinamilk' ,'38 Đường Nguyễn Oanh', '02839890800', 'vinamilk@gmail.com' ,'A2' ,'2022/06/20'
Select * from Suplier

--Delete
CREATE PROC PRC_DELETE_SUPLIER(@Id int)
as
begin
	delete Suplier where Id = @Id
end

exec PRC_DELETE_SUPLIER '3'
Select * from Suplier



--Khách hàng
CREATE PROC PRC_ADD_CUSTOMER(@DisplayNameCustomer nvarchar(max),
							@Address nvarchar(max),
							@Phone nvarchar(20),@Email nvarchar(200),
							@MoreInfo nvarchar(max),@ContractDate Datetime)
as
begin
	insert Customer values (@DisplayNameCustomer,@Address,@Phone,@Email,@MoreInfo,@ContractDate)
end

exec PRC_ADD_CUSTOMER 'Phong Phu' ,'25 Quang Trung', '123456789', 'phu@gmail.com' ,'C1' ,'2022/06/20'
exec PRC_ADD_CUSTOMER 'Gia Vinh' ,'56 Ly Thuong Kiet', '123456789', 'vinh@gmail.com' ,'C2' ,'2022/06/20'
Select * from Customer

--Update
CREATE PROC PRC_UPDATE_CUSTOMER(@CustomerId int, @DisplayNameCustomer nvarchar(max),
							@Address nvarchar(max),
							@Phone nvarchar(20),@Email nvarchar(200),
							@MoreInfo nvarchar(max),@ContractDate Datetime)
as
begin
	update Customer
	set 
	[DisplayNameCustomer] = @DisplayNameCustomer,
	[Address] = @Address,
	[Phone] = @Phone,
	[Email] = @Email,
	[MoreInfo] = @MoreInfo,
	[ContractDate] = @ContractDate
	where [CustomerId] = @CustomerId
end

exec PRC_UPDATE_CUSTOMER '2', 'Khuong Duy' ,'25 Huy Ich', '123456789', 'duy@gmail.com' ,'C2' ,'2022/06/20'
Select * from Customer

--Delete
CREATE PROC PRC_DELETE_CUSTOMER(@CustomerId int)
as
begin
	delete Customer where CustomerId = @CustomerId
end

exec PRC_DELETE_CUSTOMER '3'
Select * from Customer



--Đối tượng
CREATE PROC PRC_ADD_FOOD(@FoodId nvarchar(128),
							@DisplayNameFood nvarchar(max),
							@Quantity int,
							@Image varchar(max),@IdSuplier int,
							@DateOfManufacture Date,@ExpirationDate Date)
as
begin
	insert Food values (@FoodId,@DisplayNameFood,@Quantity,@IdSuplier,@DateOfManufacture,@ExpirationDate)
end

exec PRC_ADD_FOOD 'S1' ,'Sua chua', '10','1.png','1' ,'2022/05/20','2023/05/20'
exec PRC_ADD_FOOD 'S2' ,'Sua chua', '10','2.png', '1' ,'2022/05/20','2023/05/20'
Select * from Food

--Update
CREATE PROC PRC_UPDATE_FOOD(@FoodId nvarchar(128),
							@DisplayNameFood nvarchar(max),
							@Quantity int,
							@Image varchar(max),@IdSuplier int,
							@DateOfManufacture Date,@ExpirationDate Date)
as
begin
	update Food
	set 
	[FoodId] = @FoodId,
	[DisplayNameFood] = @DisplayNameFood,
	[Quantity] = @Quantity,
	[Image] = @Image,
	[IdSuplier] = @IdSuplier,
	[DateOfManufacture] = @DateOfManufacture,
	[ExpirationDate] = @ExpirationDate
	where [FoodId] = @FoodId
end

exec PRC_UPDATE_FOOD 'S2' ,'Sua Bo', '15','1.png', '2' ,'2022/05/20','2023/05/20'
Select * from Food

--Delete
CREATE PROC PRC_DELETE_FOOD(@FoodId int)
as
begin
	delete Food where FoodId = @FoodId
end

exec PRC_DELETE_FOOD '3'
Select * from Food



--Phiếu nhập
CREATE PROC PRC_ADD_INPUT(@DateInput Datetime,@TotalPrice int,@IdSuplier int)
as
begin
	insert Input values (@DateInput,@TotalPrice,@IdSuplier)
end

exec PRC_ADD_INPUT '2023/05/20','20000','1'
exec PRC_ADD_INPUT '2023/05/20','20000','1'
Select * from Input

--Update
CREATE PROC PRC_UPDATE_INPUT(@InputId int,@DateInput Datetime,@TotalPrice int,@IdSuplier int)
as
begin
	update Input
	set 
	[DateInput] = @DateInput,
	[TotalPrice] = @TotalPrice,
	[IdSuplier] = @IdSuplier
	where [InputId] = @InputId
end

exec PRC_UPDATE_INPUT '2','2022/05/15','30000','2'
Select * from Input

--Delete
CREATE PROC PRC_DELETE_INPUT(@InputId int)
as
begin
	delete Input where InputId = @InputId
end

exec PRC_DELETE_INPUT '3'
Select * from Input


--Thông tin phiếu nhập
CREATE PROC PRC_ADD_INPUTINFO(@IdFood nvarchar(128),
							@IdInput int,@CountInput int,
							@InputPrice float,
							@StatusInput nvarchar(max))
as
begin
	insert InputInfo values (@IdFood,@IdInput,@CountInput,@InputPrice,@StatusInput)
end

exec PRC_ADD_INPUTINFO 'S1', '01', '5' ,'1000','Green'
exec PRC_ADD_INPUTINFO 'S2', '01', '5' ,'2000','Blue'
Select * from InputInfo

--Update
CREATE PROC PRC_UPDATE_INPUTINFO(@Id int,
							@IdFood nvarchar(128),
							@IdInput int,@CountInput int,
							@InputPrice float,
							@StatusInput nvarchar(max))
as
begin
	update InputInfo
	set 
	[IdFood] = @IdFood,
	[IdInput] = @IdInput,
	[CountInput] = @CountInput,
	[InputPrice] = @InputPrice,
	[StatusInput] = @StatusInput
	where [Id] = @Id
end

exec PRC_UPDATE_INPUTINFO '2' ,'S2', '02', '2' ,'2000','Yellow'
Select * from InputInfo

--Delete
CREATE PROC PRC_DELETE_INPUTINFO(@Id int)
as
begin
	delete InputInfo where Id = @Id
end

exec PRC_DELETE_INPUTINFO '3'
Select * from InputInfo



--Phiếu xuất
CREATE PROC PRC_ADD_OUTPUT(@DateOutput Datetime,@TotalPrice int)
as
begin
	insert Output values (@DateOutput,@TotalPrice)
end

exec PRC_ADD_OUTPUT '2023/05/20','30000'
exec PRC_ADD_OUTPUT '2023/05/20','40000'
Select * from Output

--Update
CREATE PROC PRC_UPDATE_OUTPUT(@OutputId int,@DateOutput Datetime,@TotalPrice int)
as
begin
	update Output
	set 
	[DateOutput] = @DateOutput,
	[TotalPrice] = @TotalPrice
	where [OutputId] = @OutputId
end

exec PRC_UPDATE_OUTPUT '2','2022/05/15','40000'
Select * from Output

--Delete
CREATE PROC PRC_DELETE_OUTPUT(@OutputId int)
as
begin
	delete Output where OutputId = @OutputId
end

exec PRC_DELETE_OUTPUT '3'
Select * from Output


--Thông tin phiếu xuất
CREATE PROC PRC_ADD_OUTPUTINFO(@IdFood nvarchar(128),
							@IdOutput int,@IdInputInfo int,
							@IdCustomer int,@CountOutput int,
							@OutputPrice float,@StatusOutput nvarchar(max))
as
begin
	insert OutputInfo values (@IdFood,@IdOutput,@IdInputInfo,@IdCustomer,@CountOutput,@OutputPrice,@StatusOutput)
end

exec PRC_ADD_OUTPUTINFO 'S1', '1', '1' ,'1' ,'5','20000','Green'
exec PRC_ADD_OUTPUTINFO 'S2', '2', '2' ,'1' ,'5','30000','Blue'
Select * from OutputInfo

--Update
CREATE PROC PRC_UPDATE_OUTPUTINFO(@Id int,
							@IdFood nvarchar(128),
							@IdOutput int,@IdInputInfo int,
							@IdCustomer int,@CountOutput int,
							@OutputPrice float,@StatusOutput nvarchar(max))
as
begin
	update OutputInfo
	set 
	[IdFood] = @IdFood,
	[IdOutput] = @IdOutput,
	[IdInputInfo] = @IdInputInfo,
	[IdCustomer] = @IdCustomer,
	[CountOutput] = @CountOutput,
	[OutputPrice] = @OutputPrice,
	[StatusOutput] = @StatusOutput
	where [Id] = @Id
end

exec PRC_UPDATE_OUTPUTINFO '2','S2', '2', '2' ,'1' ,'1','50000','Red'
Select * from OutputInfo

--Delete
CREATE PROC PRC_DELETE_OUTPUTINFO(@Id int)
as
begin
	delete OutputInfo where Id = @Id
end

exec PRC_DELETE_OUTPUTINFO '3'
Select * from OutputInfo