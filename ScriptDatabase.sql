CREATE DATABASE QuanLyCLB
GO

USE QuanLyCLB
GO

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BienLai') and o.name = 'FK_BIENLAI_RELATIONS_VOSINH')
alter table BienLai
   drop constraint FK_BIENLAI_RELATIONS_VOSINH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KetQuaThi') and o.name = 'FK_KETQUATH_RELATIONS_VOSINH')
alter table KetQuaThi
   drop constraint FK_KETQUATHI_RELATIONS_VOSINH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KetQuaThi') and o.name = 'FK_KETQUATH_RELATIONS_LOAI')
alter table KetQuaThi
   drop constraint FK_KETQUATHI_RELATIONS_LOAI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KetQuaThi') and o.name = 'FK_KETQUATH_RELATIONS_QTV')
alter table KetQuaThi
   drop constraint FK_KETQUATHI_RELATIONS_QTV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PhieuChiTieu') and o.name = 'FK_PHIEUCHI_RELATIONS_QTV')
alter table PhieuChiTieu
   drop constraint FK_PHIEUCHI_RELATIONS_QTV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VoSinh') and o.name = 'FK_VOSINH_RELATIONS_CAPBAC')
alter table VoSinh
   drop constraint FK_VOSINH_RELATIONS_CAPBAC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Account')
            and   type = 'U')
   drop table Account
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BienLai')
            and   name  = 'RELATIONSHIP_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index BienLai.RELATIONSHIP_5_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BienLai')
            and   type = 'U')
   drop table BienLai
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CapBac')
            and   type = 'U')
   drop table CapBac
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KetQuaThi')
            and   name  = 'RELATIONSHIP_6_FK'
            and   indid > 0
            and   indid < 255)
   drop index KetQuaThi.RELATIONSHIP_6_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KetQuaThi')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index KetQuaThi.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KetQuaThi')
            and   name  = 'RELATIONSHIP_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index KetQuaThi.RELATIONSHIP_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KetQuaThi')
            and   type = 'U')
   drop table KetQuaThi
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Loai')
            and   type = 'U')
   drop table Loai
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PhieuChiTieu')
            and   name  = 'RELATIONSHIP_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index PhieuChiTieu.RELATIONSHIP_7_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PhieuChiTieu')
            and   type = 'U')
   drop table PhieuChiTieu
go

if exists (select 1
            from  sysobjects
           where  id = object_id('QTV')
            and   type = 'U')
   drop table QTV
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VoSinh')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index VoSinh.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VoSinh')
            and   type = 'U')
   drop table VoSinh
go

/*==============================================================*/
/* Table: Account                                               */
/*==============================================================*/
create table Account (
   UserName             varchar(100)         not null,
   DisplayName          varchar(100)         not null,
   Password             varchar(100)         not null,
   Type                 int                  not null,
   constraint PK_ACCOUNT primary key nonclustered (UserName)
)
go

/*==============================================================*/
/* Table: BienLai                                               */
/*==============================================================*/
create table BienLai (
   BienLaiId            varchar(10)          not null,
   VoSinhId             varchar(10)          null,
   NgayLap              datetime             not null,
   SoTien               float                not null,
   constraint PK_BIENLAI primary key nonclustered (BienLaiId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_5_FK on BienLai (
VoSinhId ASC
)
go

/*==============================================================*/
/* Table: CapBac                                                */
/*==============================================================*/
create table CapBac (
   CapBacId             varchar(10)          not null,
   TenCapBac            varchar(50)          not null,
   constraint PK_CAPBAC primary key nonclustered (CapBacId)
)
go

/*==============================================================*/
/* Table: KetQuaThi                                             */
/*==============================================================*/
create table KetQuaThi (
   KetQuaThiId          varchar(10)          not null,
   VoSinhId             varchar(10)          null,
   LoaiId               varchar(10)          null,
   QTVId                varchar(10)          null,
   DiemSo               float                not null,
   constraint PK_KETQUATHI primary key nonclustered (KetQuaThiId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_2_FK on KetQuaThi (
VoSinhId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on KetQuaThi (
LoaiId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_6_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_6_FK on KetQuaThi (
QTVId ASC
)
go

/*==============================================================*/
/* Table: Loai                                                  */
/*==============================================================*/
create table Loai (
   LoaiId               varchar(10)          not null,
   MinScore             float                null,
   MaxScore             float                null,
   constraint PK_LOAI primary key nonclustered (LoaiId)
)
go

/*==============================================================*/
/* Table: PhieuChiTieu                                          */
/*==============================================================*/
create table PhieuChiTieu (
   PhieuId              varchar(10)          not null,
   QTVId                varchar(10)          null,
   NgayLap              datetime             not null,
   NoiDungChi           varchar(100)         not null,
   SoTien               float                not null,
   constraint PK_PHIEUCHITIEU primary key nonclustered (PhieuId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_7_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_7_FK on PhieuChiTieu (
QTVId ASC
)
go

/*==============================================================*/
/* Table: QTV                                                   */
/*==============================================================*/
create table QTV (
   QTVId                varchar(10)          not null,
   HoTen                varchar(150)         not null,
   constraint PK_QTV primary key nonclustered (QTVId)
)
go

/*==============================================================*/
/* Table: VoSinh                                                */
/*==============================================================*/
create table VoSinh (
   VoSinhId             varchar(10)          not null,
   Ho                   varchar(50)          null,
   TenDem               varchar(100)         null,
   Ten                  varchar(50)          not null,
   NgaySinh             datetime             null,
   NgayThamGia          datetime             null,
   CapBacId             varchar(10)          null,
   constraint PK_VOSINH primary key nonclustered (VoSinhId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on VoSinh (
CapBacId ASC
)
go

alter table BienLai
   add constraint FK_BIENLAI_RELATIONS_VOSINH foreign key (VoSinhId)
      references VoSinh (VoSinhId)
go

alter table KetQuaThi
   add constraint FK_KETQUATH_RELATIONS_VOSINH foreign key (VoSinhId)
      references VoSinh (VoSinhId)
go

alter table KetQuaThi
   add constraint FK_KETQUATH_RELATIONS_LOAI foreign key (LoaiId)
      references Loai (LoaiId)
go

alter table KetQuaThi
   add constraint FK_KETQUATH_RELATIONS_QTV foreign key (QTVId)
      references QTV (QTVId)
go

alter table PhieuChiTieu
   add constraint FK_PHIEUCHI_RELATIONS_QTV foreign key (QTVId)
      references QTV (QTVId)
go

alter table VoSinh
   add constraint FK_VOSINH_RELATIONS_CAPBAC foreign key (CapBacId)
      references CapBac (CapBacId)
go

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

CREATE PROC VoSinh_Find
@voSinhId nvarchar(100), @ten nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.VoSinh WHERE VoSinhId = @voSinhId AND Ten = @ten
END
GO