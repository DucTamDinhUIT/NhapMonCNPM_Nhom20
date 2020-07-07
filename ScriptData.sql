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

/*==============================================================*/
/* Table: VoSinh                                                */
/*==============================================================*/
CREATE TABLE VoSinh
(
	STT INT NOT NULL PRIMARY KEY,	
	TenVoSinh NVARCHAR(200) ,
	Truong NVARCHAR(200),
	SinhNhat NVARCHAR(50),
	CapBac NVARCHAR(50),
	NgayThamGia NVARCHAR(50),
	
)
GO
/*==============================================================*/
/* Table: PhieuThu                                               */
/*==============================================================*/
CREATE TABLE PhieuThu
(
	MaPhieuThu INT NOT NULL PRIMARY KEY,	
	STT INT NOT NULL ,
	SoTienNop float,
	NgayThu NVARCHAR(50),
	GhiChu NVARCHAR(100),
	   FOREIGN KEY (STT)  REFERENCES VoSinh (STT)
)
GO
/*DROP TABLE dbo.PhieuThu*/
/*==============================================================*/
/* Table: PhieuChi                                             */
/*==============================================================*/
CREATE TABLE PhieuChi
(
	MaPhieuChi INT NOT NULL PRIMARY KEY,	
	SoTienChi float,
	NgayChi NVARCHAR(50),
	NoiDung NVARCHAR(100),
)
GO

/*==============================================================*/
/* Table: PhieuChi                                             */
/*==============================================================*/
CREATE TABLE NguoiKiemTra
(
	MaSoID INT NOT NULL PRIMARY KEY,	
	HoTen float,
	MaPhieuChi int,
	FOREIGN KEY (MaPhieuChi)  REFERENCES PhieuChi (MaPhieuChi),
)
GO

/*==============================================================*/
/* Table: DiemThi                                               */
/*==============================================================*/
CREATE TABLE DiemThi
(
	MaDiemThi INT NOT NULL PRIMARY KEY,	
	STT INT NOT NULL ,
	DiemThi float,
	KetQua NVARCHAR(50),
	CapBacKeTiep NVARCHAR(50),
	CapBacHienTai NVARCHAR(50),
	NgayKiemTra NVARCHAR(50),
	NguoiKiemTra NVARCHAR(100),
	GhiChu NVARCHAR(100),
	   FOREIGN KEY (STT)  REFERENCES VoSinh (STT)
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


INSERT 
INTO  dbo.VoSinh(STT,TenVoSinh,Truong,SinhNhat,CapBac,NgayThamGia) 
 VALUES ('0', 'Duc Tam', 'UIT', 'n/a', 'White','n/a'); 
 GO

 CREATE PROC Get_Infor
@TenVoSinh nvarchar(100),  @CapBac nvarchar(20)
AS
BEGIN
	SELECT * FROM dbo.VoSinh WHERE TenVoSinh = @TenVoSinh AND CapBac = @CapBac
END
GO

 CREATE PROC VoSinh_Find
@voSinhId nvarchar(100),  @ten nvarchar(20)
AS
BEGIN
	SELECT * FROM dbo.VoSinh WHERE STT = @voSinhId AND TenVoSinh = @ten
END
GO

SELECT * FROM dbo.VoSinh WHERE STT = '2' AND TenVoSinh = 'Thanh'
GO

 CREATE PROC VoSinh_Insert
@voSinhId nvarchar(100),  @ten nvarchar(20)
AS
BEGIN
	INSERT 
	INTO  dbo.VoSinh(STT,TenVoSinh,Truong,SinhNhat,CapBac,NgayThamGia) 
	 VALUES ('4', 'Thanh', 'UIT', 'Haiphong', 'trắng','26/8'); 
 END
 GO

SELECT TenVoSinh, SoTienNop FROM dbo.VoSinh FULL JOIN dbo.PhieuThu ON dbo.VoSinh.STT = dbo.PhieuThu.STT 
GO

INSERT 
INTO  dbo.PhieuThu(MaPhieuThu, STT, SoTienNop, NgayThu, GhiChu ) 
 VALUES (0, 0, 0, 'n/a', 'n/a'); 
 GO

SELECT MAX (MaPhieuThu) FROM dbo.PhieuThu
GO

SELECT * FROM dbo.PhieuThu
GO

SELECT dbo.VoSinh.STT, dbo.VoSinh.TenVoSinh, dbo.PhieuThu.SoTienNop FROM dbo.VoSinh INNER JOIN dbo.PhieuThu ON dbo.VoSinh.STT = dbo.PhieuThu.STT
GO