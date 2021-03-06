CREATE DATABASE LibraryManager
GO

USE LibraryManager
GO
--TheLoai--
CREATE TABLE Category
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(100) NOT NULL
)
GO
--Sach--
CREATE TABLE Book
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(100) NOT NULL,
	Author nvarchar (100) NOT NULL,
	Publisher  nvarchar (100) NOT NULL,
	IdCategory INT NOT NULL,
	Amount INT NOT NULL,	
	FOREIGN KEY (IdCategory) REFERENCES dbo.Category(Id)
)
ALTER TABLE Book ADD RentPrice BIGINT NOT NULL
GO

--NhanVien--
CREATE TABLE Employee
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(100) NOT NULL,
	Birthday date NOT NULL DEFAULT GETDATE(),
	Gender nvarchar (10) NOT NULL,
	Address nvarchar(300) NOT NULL,
	Phone nvarchar(15) NOT NULL
)
GO
--Account--
CREATE TABLE Account
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	UserName nvarchar(100) NOT NULL,
	Password nvarchar(100) NOT NULL,
	type INT NOT NULL DEFAULT 1,
)
GO
--KhachThue--
CREATE TABLE Customer
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(100) NOT NULL,
	Birthday date NOT NULL DEFAULT N'2000-01-01',
	Gender nvarchar (50) NOT NULL,
	Address nvarchar(300) NOT NULL,
	Phone nvarchar(15) NOT NULL
)
GO
--PhieuMuon--
CREATE TABLE BookRental
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	IdBook INT NOT NULL,
	IdCustomer INT NOT NULL,
	IdEmployee INT NOT NULL,
	RentAmount INT NOT NULL,
	RentDate date NOT NULL DEFAULT GETDATE(),
	TermDate date NOT NULL,
	Deposit BIGINT NOT NULL,
	Price BIGINT NOT NULL,
	Status nvarchar(100) NOT NULL DEFAULT N'Chưa thanh toán',
	
	FOREIGN KEY (IdBook) REFERENCES dbo.Book(Id),
	FOREIGN KEY (IdEmployee) REFERENCES dbo.Customer(Id),
	FOREIGN KEY (IdCustomer) REFERENCES dbo.Employee(Id)
)
GO

--TraSach--
CREATE TABLE BookReturn
(
	Id INT IDENTITY(1,1),
	IdBookRental INT NOT NULL,
	IdBook INT NOT NULL,
	IdCustomer INT NOT NULL,
	ReturnDate date NOT NULL,
	OutDatePrice BIGINT NOT NULL DEFAULT 0,
	DamagePrice BIGINT NOT NULL DEFAULT 0,
	TotalPrice BIGINT NOT NULL,
	
	FOREIGN KEY (IdCustomer) REFERENCES dbo.Customer(Id),
	CONSTRAINT BookRental_pk PRIMARY KEY (Id, IdBookRental),
	FOREIGN KEY (IdBookRental) REFERENCES dbo.BookRental(Id),
	FOREIGN KEY (IdBook) REFERENCES dbo.Book(Id)
)
GO

---------Trigger để trừ số lượng sách khi được mượn---------
CREATE TRIGGER Rent ON dbo.BookRental FOR INSERT AS
	DECLARE @book_amount INT
	DECLARE @rent_amount INT 
	DECLARE @book_id INT 
BEGIN
	SELECT @book_id = IdBook, @rent_amount = RentAmount FROM inserted
	SELECT @book_amount = Amount FROM dbo.Book WHERE dbo.Book.Id = @book_id
	IF @book_amount >= @rent_amount
	BEGIN
		UPDATE dbo.Book	
		SET Amount = Amount - @rent_amount
		WHERE dbo.Book.Id = @book_id
	END
	ELSE
		ROLLBACK TRANSACTION		
END	
GO

---------Trigger cập nhật lại số lượng sách khi trả sách---------
CREATE TRIGGER UpdateRent on dbo.BookRental AFTER UPDATE AS
BEGIN
   UPDATE dbo.Book SET Amount = Amount -
	   (SELECT Amount FROM inserted WHERE IdBook = dbo.Book.Id) +
	   (SELECT Amount FROM deleted WHERE IdBook = dbo.Book.Id)
   FROM dbo.Book
   JOIN deleted ON dbo.Book.Id = deleted.IdBook
END
GO

CREATE TRIGGER DeleteRent ON dbo.BookRental FOR DELETE AS 
BEGIN
	UPDATE dbo.Book
	SET Amount = Amount + (SELECT RentAmount FROM deleted WHERE IdBook = dbo.Book.Id)
	FROM dbo.Book 
	JOIN deleted ON dbo.Book.Id = deleted.IdBook
END
GO

--fix bug login by create proc--
CREATE PROC USP_Login
@username nvarchar(100), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @username AND Password = @password
END
GO

USP_Login @username , @password

CREATE FUNCTION [dbo].[fuConvertToUnsign1]
 ( 
	@strInput NVARCHAR(4000) 
 ) RETURNS NVARCHAR(4000) 
 AS 
 BEGIN 
	IF @strInput IS NULL 
		RETURN @strInput 
	IF @strInput = '' 
		RETURN @strInput 
	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272)+ NCHAR(208)
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 
	WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
				BEGIN 
					IF @COUNTER=1 
						SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
					ELSE 
						SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
					BREAK 
				END 
			SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

--proc sửa tài khoản--
CREATE PROC USP_UpdateAccount
@userName nvarchar(100), @password nvarchar(100), @type INT
AS
BEGIN
	DECLARE @isChangePass INT = 0
	SELECT @isChangePass = COUNT(*) FROM dbo.Account WHERE UserName = @userName
	IF(@isChangePass = 1)
	BEGIN
		IF(@password = NULL OR @password = '')
		BEGIN
			UPDATE dbo.Account SET type = @type WHERE UserName = @userName
		END
		ELSE 
			UPDATE dbo.Account SET type = @type, Password = @password WHERE UserName = @userName
	END
END


----thêm dữ liệu----
insert into dbo.Employee values(N'Lữ Hoàng Liêm', N'1998-09-08', N'Nam', N'Khánh Hòa', N'0335521461')
go
insert into dbo.Employee values(N'Bạch Dự Bân', N'1997-07-13', N'Nữ', N'Chuncheon', N'0929201307')
go

insert into dbo.Customer values(N'Nguyễn Văn A', N'2000-11-02', N'Nam', N'Khánh Hòa', N'03635521461')
go
insert into dbo.Customer values(N'Lê Thị A', N'1999-02-03', N'Nữ', N'Tp. HCM', N'04635521461')
go
insert into dbo.Customer values(N'Trần Thị A', N'1999-01-12', N'Nữ', N'Tp. HCM', N'05635521461')
go

insert into dbo.Category values(N'Giáo trình')
go
insert into dbo.Category values(N'Chính trị – pháp luật')
go
insert into dbo.Category values(N'Văn hóa xã hội – Lịch sử')
go
insert into dbo.Category values(N'Khoa học công nghệ – Kinh tế')
go
insert into dbo.Category values(N'Truyện, tiểu thuyết')
go

insert into dbo.Account values(N'hoangliem98', N'123', 0)
go
insert into dbo.Account values(N'liemluhoang', N'123', 1)
go


insert into dbo.Book values(N'Lập trình hướng đối tượng', N'Tô Oai Hùng', N'Đại học Mở Tp. HCM', 1, 5, 20000)
go
insert into dbo.Book values(N'Xạ điêu tam bộ khúc', N'Kim Dung', N'NXB Văn Học', 5, 5, 20000)
go

insert into dbo.BookRental values(1, 1, 2, 2, N'2018-10-25', N'2018-10-30', 50000, 200000, DEFAULT)
go
insert into dbo.BookRental values(2, 1, 1, 1, N'2018-11-05', N'2018-11-10', 20000, 100000, DEFAULT)
go

insert into dbo.BookReturn values(1, 1, 1, N'2018-10-31', 5000, DEFAULT, 205000)
go

--SELECT * FROM dbo.KhachThue WHERE dbo.fuConvertToUnsign1(Name) LIKE N'%' + dbo.fuConvertToUnsign1(N'Nguyễn Văn A') + '%'
--SELECT * FROM dbo.MuonSach
--SELECT * FROM dbo.TaiKhoan WHERE idNhanVien = 2
--SELECT Id FROM dbo.NhanVien

--UPDATE dbo.TaiKhoan SET UserName = N'nhatnam', Pass = N'456' WHERE IdNhanVien = 2

--UPDATE dbo.NhanVien SET Name = N'Liêm', NgaySinh = N'1998-07-09', GioiTinh = N'nữ', DiaChi = N'Khánh Hòa', SDT = N'0234567891' WHERE Id = 11
--select * from dbo.MuonSach
--delete from dbo.NhanVien where Id = 3
--delete from dbo.MuonSach where Id = 21
--DROP TRIGGER ThueSach
--SELECT * FROM dbo.MuonSach WHERE dbo.MuonSach.IdSach = 2
--SELECT * FROM dbo.Sach INNER JOIN dbo.MuonSach ON dbo.Sach.Id = dbo.MuonSach.IdSach WHERE dbo.MuonSach.IdSach = 5
--SELECT * FROM dbo.KhachThue INNER JOIN dbo.MuonSach ON dbo.KhachThue.Id = dbo.MuonSach.IdKhachThue WHERE dbo.MuonSach.Id = 7
--SELECT * FROM dbo.KhachThue INNER JOIN dbo.MuonSach ON dbo.KhachThue.Id = dbo.MuonSach.IdKhachThue WHERE dbo.MuonSach.IdSach = 2
--SELECT * FROM dbo.MuonSach INNER JOIN dbo.KhachThue ON dbo.KhachThue.Id = dbo.MuonSach.IdKhachThue WHERE dbo.KhachThue.Id = 3
--UPDATE dbo.MuonSach SET dbo.MuonSach.TrangThai = N'Đã thanh toán' FROM dbo.MuonSach INNER JOIN dbo.TraSach ON dbo.MuonSach.Id = dbo.TraSach.IdMuon WHERE dbo.TraSach.IdMuon = 1
--DELETE dbo.TraSach FROM dbo.TraSach INNER JOIN dbo.MuonSach ON dbo.TraSach.IdMuon = dbo.MuonSach.Id WHERE dbo.TraSach.IdMuon = 1
--DELETE FROM dbo.MuonSach WHERE IdSach = 3