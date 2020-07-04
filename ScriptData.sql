CREATE DATABASE QuanLyCLB
GO

USE QuanLyCLB
GO



CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Admin',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'K9' , -- UserName - nvarchar(100)
          N'RongK9' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'staff' , -- UserName - nvarchar(100)
          N'staff' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )
GO

CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'k9' -- nvarchar(100)

GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

CREATE TABLE VoSinh
(
	STT NVARCHAR (100) PRIMARY KEY,	
	TenVoSinh NVARCHAR(100) ,
	Truong NVARCHAR(1000),
	SinhNhat NVARCHAR(20),
	CapBac NVARCHAR(20),
	NgayThamGia NVARCHAR(20),
	
)
GO

INSERT 
INTO  dbo.VoSinh(STT,TenVoSinh,Truong,SinhNhat,CapBac,NgayThamGia) 
 VALUES ('1', 'Thanh', 'UIT', 'Haiphong', 'trắng','26/8'); 
 GO

 CREATE PROC Get_Infor
@STT VARCHAR (100), @TenVoSinh nvarchar(100),  @Truong nvarchar(1000),  @SinhNhat nvarchar(100),  @CapBac nvarchar(20),  @NgayThamGia nvarchar(20)
AS
BEGIN
	SELECT * FROM dbo.VoSinh WHERE TenVoSinh = @TenVoSinh AND CapBac = @CapBac
END
GO

SELECT * FROM dbo.Information WHERE STT = '2' AND TenVoSinh = 'Thanh'