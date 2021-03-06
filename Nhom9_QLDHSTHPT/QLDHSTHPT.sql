CREATE DATABASE QLDHSTHPT
GO 
USE QLDHSTHPT


CREATE TABLE LOP(
	MaLop CHAR(10) PRIMARY KEY,
	TenLop NVARCHAR(20),
	SiSo INT,
	MaGV CHAR(10),
)

CREATE TABLE MONHOC(
	MaMH CHAR(10) PRIMARY KEY,
	TenMH NVARCHAR(20),
)
--DROP TABLE MONHOC
 CREATE TABLE HOCSINH(
	MaHS CHAR(10) PRIMARY KEY,
	TenHS NVARCHAR(30) ,
	GioiTinh BIT,
	NgaySinh DATETIME,
	DiaChi NVARCHAR(50),
	Sdt INT,
	MaLop CHAR(10) FOREIGN KEY REFERENCES LOP(MaLop)
)

CREATE TABLE GIAOVIEN(
	MaGV CHAR(10) PRIMARY KEY,
	TenGV NVARCHAR(30),
	GioiTinh BIT,
	NgaySinh DATETIME,
	DiaChi NVARCHAR(50),
	Sdt CHAR(10),
	MaMH CHAR(10) FOREIGN KEY REFERENCES MONHOC(MaMH)
)

CREATE TABLE HOCKY(
	MaHK CHAR(10) PRIMARY KEY,
	TenHK CHAR(20)
)

CREATE TABLE NAMHOC(
	MaNH CHAR(10)PRIMARY KEY,
	TenNH CHAR(10)
)
CREATE TABLE DANGNHAP(
	UserID int not null identity(1,1) PRIMARY KEY,
	Username CHAR(10),
	MatKhau VARCHAR(50),
	Status Bit NOT NULL
)


CREATE TABLE LOAIDIEM(
	MaLoaiDiem CHAR(10) PRIMARY KEY,
	TenLoaiDiem NVARCHAR(20),
	HeSo INT
)

CREATE TABLE DIEMMONHOC(
	MaHS CHAR(10) ,
	MaMH CHAR(10) ,
	MaHK CHAR(10) ,
	MaNH CHAR(10) ,
	MaLoaiDiem CHAR(10) ,
	Diem FLOAT, CHECK(Diem>=0 AND Diem <=10),

	CONSTRAINT P_DMH PRIMARY KEY(MaHS, MaMH, MaHK, MaNH, MaLoaiDiem),
	CONSTRAINT F_DMH_HS FOREIGN KEY(MaHS)	REFERENCES HOCSINH(MaHS),
	CONSTRAINT F_DMH_MH FOREIGN KEY(MaMH)	REFERENCES MONHOC(MaMH),
	CONSTRAINT F_DMH_HK FOREIGN KEY(MaHK)	REFERENCES HOCKY(MaHK),
	CONSTRAINT F_DMH_NH FOREIGN KEY(MaNH)	REFERENCES NAMHOC(MaNH),
	CONSTRAINT F_DMH_LD FOREIGN KEY(MaLoaiDiem)	REFERENCES LOAIDIEM(MaLoaiDiem)
)


CREATE TABLE HANHKIEM(
	MaHanhKiem CHAR(10),
	TenHanhKiem CHAR(10),
	MaNH CHAR(10),
	MaHK CHAR(10),
	MaHS CHAR(10),
	CONSTRAINT PK PRIMARY KEY(MaHS, MaHK, MaNH, MaHanhKiem ),
	CONSTRAINT HS FOREIGN KEY(MaHS)	REFERENCES HOCSINH(MaHS),
	CONSTRAINT NH FOREIGN KEY(MaNH)	REFERENCES NAMHOC(MaNH),
	CONSTRAINT HK FOREIGN KEY(MaHK)	REFERENCES HOCKY(MaHK),

)

CREATE TABLE HOCLUC(
	MaHL CHAR(10) PRIMARY KEY,
	TenHL CHAR(10)
)
--INSERT MONHOC
INSERT INTO MONHOC(MaMH, TenMH)
VALUES
	('MH01',N'Toán'),
	('MH02',N'Ngữ Văn'),
	('MH03',N'Tiếng Anh'),
	('MH04',N'Vật Lý'),
	('MH05',N'Địa Lý'),
	('MH06',N'Lịch Sử'),
	('MH07',N'Hóa học'),
	('MH08',N'GDCD'),
	('MH09',N'Sinh học'),
	('MH10',N'Công nghệ'),
	('MH11',N'GDQPAN'),
	('MH12',N'Tin học')
SELECT * FROM MONHOC
 
--INSERT GIAOVIEN
INSERT INTO GIAOVIEN(MaGV,TenGV, GioiTinh, NgaySinh, DiaChi, Sdt, MaMH) 
VALUES
	('GV01',N'Trần Minh Hạnh',1,'1982-09-09','Thái Nguyên','0123456789','MH01'),
	('GV02',N'Trần Minh Anh',1,'1972-09-09','Thái Nguyên','0123456889','MH01'),
	('GV03',N'Trần Văn Nam',0,'1987-09-09','Ninh Bình','0234567890','MH03'),
	('GV04',N'Nguyễn Minh Thủy',0,'1982-09-09','Thái Nguyên','0123756781','MH02'),
	('GV05',N'Triệu Thị Linh',1,'1982-01-09','Thái Nguyên','0123056781','MH12')
SELECT * FROM GIAOVIEN

--INSERT LOP
INSERT INTO LOP(MaLop, TenLop,SiSo, MaGV)
VALUES
	('L001','10A1',40,'GV01'),
	('L002','10A2',40,'GV02'),
	('L003','10A3',40,'GV03')
SELECT * FROM LOP
--INSERT HOCSINH

INSERT INTO HOCSINH(MaHS, TenHS, GioiTinh, NgaySinh, DiaChi, Sdt, MaLop)
VALUES
	('HS01',N'Nguyễn Thị Hải',1,'2001-08-01','Thái Nguyên','0321111111','L001'),
	('HS02',N'Nguyễn Thị Lan',1,'2001-08-11','Thái Nguyên','0372111111','L001'),
	('HS03',N'Nguyễn Văn An',0,'2001-02-03','Thái Nguyên','0392111111','L002'),
	('HS04',N'Mai Thị Hải',1,'2001-02-03','Thái Nguyên','0941111111','L002'),
	('HS05',N'Nguyễn Minh Anh',0,'2001-01-01','Thái Nguyên','0339111111','L003'),
	('HS06',N'Nguyễn Hương Giang',1,'2001-09-01','Thái Nguyên','0330911111','L003')
SELECT * FROM HOCSINH 
--INSERT HOCKY
INSERT INTO HOCKY(MaHK, TenHK)
VALUES
	('HK01',N'Học kỳ 1'),
	('HK02',N'Học kỳ 2')	
SELECT* FROM HOCKY
--INSERT INTO DANGNHAP
INSERT INTO DANGNHAP(Username, MatKhau, Status)
VALUES
	('HS01','HS01123',0),
	('HS02','HS02123',0),
	('HS03','HS03123',0),
	('HS04','HS04123',0),
	('HS05','HS05123',0),
	('HS06','HS06123',0),
	('GV01','GV01123',1),
	('GV02','GV02123',1)
SELECT * FROM DANGNHAP
--INSERT NAMHOC
INSERT INTO NAMHOC(MaNH, TenNH)
VALUES
	('NH01','2019-2020'),
	('NH02','2020-2021')
SELECT * FROM NAMHOC
--INSERT LOAIDIEM
INSERT INTO LOAIDIEM(MaLoaiDiem, TenLoaiDiem, HeSo)
VALUES 
	('LD01',N'Điểm miệng',1),
	('LD02',N'Điểm 15p',1),
	('LD03',N'Điểm 45p',2),
	('LD04',N'Điểm thi',3)
SELECT * FROM LOAIDIEM
--INSERT DIEMMONHOC NAM HOC NH01
	---Diem hoc ky 1 HS1
INSERT INTO DIEMMONHOC(MaHS, MaMH,MaHK, MaNH, MaLoaiDiem, Diem)
VALUES
	('HS01','MH01','HK01','NH01','LD01',10),
	('HS01','MH01','HK01','NH01','LD02',9),
	('HS01','MH01','HK01','NH01','LD03',9),
	('HS01','MH01','HK01','NH01','LD04',9.5),

	('HS01','MH02','HK01','NH01','LD01',9),
	('HS01','MH02','HK01','NH01','LD02',10),
	('HS01','MH02','HK01','NH01','LD03',9),
	('HS01','MH02','HK01','NH01','LD04',9.5),

	('HS01','MH03','HK01','NH01','LD01',10),
	('HS01','MH03','HK01','NH01','LD02',9),
	('HS01','MH03','HK01','NH01','LD03',9),
	('HS01','MH03','HK01','NH01','LD04',9),

	('HS01','MH04','HK01','NH01','LD01',9),
	('HS01','MH04','HK01','NH01','LD02',8.5),
	('HS01','MH04','HK01','NH01','LD03',9),
	('HS01','MH04','HK01','NH01','LD04',8),

	('HS01','MH05','HK01','NH01','LD01',10),
	('HS01','MH05','HK01','NH01','LD02',9),
	('HS01','MH05','HK01','NH01','LD03',9),
	('HS01','MH05','HK01','NH01','LD04',8),

	('HS01','MH06','HK01','NH01','LD01',8),
	('HS01','MH06','HK01','NH01','LD02',9),
	('HS01','MH06','HK01','NH01','LD03',8),
	('HS01','MH06','HK01','NH01','LD04',9.5),

	('HS01','MH07','HK01','NH01','LD01',10),
	('HS01','MH07','HK01','NH01','LD02',10),
	('HS01','MH07','HK01','NH01','LD03',9),
	('HS01','MH07','HK01','NH01','LD04',8.5),
	
	('HS01','MH08','HK01','NH01','LD01',9),
	('HS01','MH08','HK01','NH01','LD02',9),
	('HS01','MH08','HK01','NH01','LD03',8.5),
	('HS01','MH08','HK01','NH01','LD04',8),

	('HS01','MH09','HK01','NH01','LD01',10),
	('HS01','MH09','HK01','NH01','LD02',9),
	('HS01','MH09','HK01','NH01','LD03',8.5),
	('HS01','MH09','HK01','NH01','LD04',9),

	('HS01','MH10','HK01','NH01','LD01',9),
	('HS01','MH10','HK01','NH01','LD02',9),
	('HS01','MH10','HK01','NH01','LD03',9),
	('HS01','MH10','HK01','NH01','LD04',10),

	('HS01','MH11','HK01','NH01','LD01',10),
	('HS01','MH11','HK01','NH01','LD02',9),
	('HS01','MH11','HK01','NH01','LD03',8),
	('HS01','MH11','HK01','NH01','LD04',9),

	('HS01','MH12','HK01','NH01','LD01',9),
	('HS01','MH12','HK01','NH01','LD02',9),
	('HS01','MH12','HK01','NH01','LD03',9),
	('HS01','MH12','HK01','NH01','LD04',9)

INSERT INTO DIEMMONHOC VALUES('HS01', 'MH01','HK01','NH02', 'LD01',7)
DELETE FROM DIEMMONHOC WHERE MaHS='HS01'AND MaMH='MH01'AND MaHK= 'HK01'AND MaNH='NH02'AND MaLoaiDiem='LD01'
SELECT * FROM DIEMMONHOC
	--Diem Hoc ky 2 HS1
INSERT INTO DIEMMONHOC(MaHS, MaMH,MaHK, MaNH, MaLoaiDiem, Diem)
VALUES
	('HS01','MH01','HK02','NH01','LD01',9),
	('HS01','MH01','HK02','NH01','LD02',10),
	('HS01','MH01','HK02','NH01','LD03',9),
	('HS01','MH01','HK02','NH01','LD04',9),

	('HS01','MH02','HK02','NH01','LD01',10),
	('HS01','MH02','HK02','NH01','LD02',10),
	('HS01','MH02','HK02','NH01','LD03',9),
	('HS01','MH02','HK02','NH01','LD04',9),

	('HS01','MH03','HK02','NH01','LD01',10),
	('HS01','MH03','HK02','NH01','LD02',10),
	('HS01','MH03','HK02','NH01','LD03',9),
	('HS01','MH03','HK02','NH01','LD04',8),

	('HS01','MH04','HK02','NH01','LD01',10),
	('HS01','MH04','HK02','NH01','LD02',9),
	('HS01','MH04','HK02','NH01','LD03',9),
	('HS01','MH04','HK02','NH01','LD04',8.5),

	('HS01','MH05','HK02','NH01','LD01',9),
	('HS01','MH05','HK02','NH01','LD02',9),
	('HS01','MH05','HK02','NH01','LD03',9),
	('HS01','MH05','HK02','NH01','LD04',10),

	('HS01','MH06','HK02','NH01','LD01',10),
	('HS01','MH06','HK02','NH01','LD02',9),
	('HS01','MH06','HK02','NH01','LD03',8),
	('HS01','MH06','HK02','NH01','LD04',9.5),

	('HS01','MH07','HK02','NH01','LD01',10),
	('HS01','MH07','HK02','NH01','LD02',10),
	('HS01','MH07','HK02','NH01','LD03',9),
	('HS01','MH07','HK02','NH01','LD04',9),

	('HS01','MH08','HK02','NH01','LD01',10),
	('HS01','MH08','HK02','NH01','LD02',9),
	('HS01','MH08','HK02','NH01','LD03',9),
	('HS01','MH08','HK02','NH01','LD04',9),

	('HS01','MH09','HK02','NH01','LD01',9),
	('HS01','MH09','HK02','NH01','LD02',9),
	('HS01','MH09','HK02','NH01','LD03',10),
	('HS01','MH09','HK02','NH01','LD04',10),

	('HS01','MH10','HK02','NH01','LD01',10),
	('HS01','MH10','HK02','NH01','LD02',8),
	('HS01','MH10','HK02','NH01','LD03',9),
	('HS01','MH10','HK02','NH01','LD04',9),

	('HS01','MH11','HK02','NH01','LD01',7),
	('HS01','MH11','HK02','NH01','LD02',8),
	('HS01','MH11','HK02','NH01','LD03',8),
	('HS01','MH11','HK02','NH01','LD04',8),

	('HS01','MH12','HK02','NH01','LD01',9),
	('HS01','MH12','HK02','NH01','LD02',9),
	('HS01','MH12','HK02','NH01','LD03',9.5),
	('HS01','MH12','HK02','NH01','LD04',9)

	--Diem hoc ky 1 HS2
INSERT INTO DIEMMONHOC(MaHS, MaMH,MaHK, MaNH, MaLoaiDiem, Diem)
VALUES
	('HS02','MH01','HK01','NH01','LD01',7),
	('HS02','MH01','HK01','NH01','LD02',8),
	('HS02','MH01','HK01','NH01','LD03',9),
	('HS02','MH01','HK01','NH01','LD04',6.5),

	('HS02','MH02','HK01','NH01','LD01',8),
	('HS02','MH02','HK01','NH01','LD02',6),
	('HS02','MH02','HK01','NH01','LD03',9),
	('HS02','MH02','HK01','NH01','LD04',8.5),

	('HS02','MH03','HK01','NH01','LD01',7),
	('HS02','MH03','HK01','NH01','LD02',7.5),
	('HS02','MH03','HK01','NH01','LD03',9),
	('HS02','MH03','HK01','NH01','LD04',8),

	('HS02','MH04','HK01','NH01','LD01',7),
	('HS02','MH04','HK01','NH01','LD02',8.5),
	('HS02','MH04','HK01','NH01','LD03',9),
	('HS02','MH04','HK01','NH01','LD04',8.5),

	('HS02','MH05','HK01','NH01','LD01',6),
	('HS02','MH05','HK01','NH01','LD02',7.5),
	('HS02','MH05','HK01','NH01','LD03',9),
	('HS02','MH05','HK01','NH01','LD04',5),

	('HS02','MH06','HK01','NH01','LD01',8),
	('HS02','MH06','HK01','NH01','LD02',6),
	('HS02','MH06','HK01','NH01','LD03',7),
	('HS02','MH06','HK01','NH01','LD04',5),

	('HS02','MH07','HK01','NH01','LD01',7),
	('HS02','MH07','HK01','NH01','LD02',6.5),
	('HS02','MH07','HK01','NH01','LD03',5.5),
	('HS02','MH07','HK01','NH01','LD04',6),

	('HS02','MH08','HK01','NH01','LD01',8),
	('HS02','MH08','HK01','NH01','LD02',5),
	('HS02','MH08','HK01','NH01','LD03',5),
	('HS02','MH08','HK01','NH01','LD04',6),

	('HS02','MH09','HK01','NH01','LD01',4),
	('HS02','MH09','HK01','NH01','LD02',7.5),
	('HS02','MH09','HK01','NH01','LD03',5),
	('HS02','MH09','HK01','NH01','LD04',5),

	('HS02','MH10','HK01','NH01','LD01',7),
	('HS02','MH10','HK01','NH01','LD02',5),
	('HS02','MH10','HK01','NH01','LD03',5),
	('HS02','MH10','HK01','NH01','LD04',7),

	('HS02','MH11','HK01','NH01','LD01',7),
	('HS02','MH11','HK01','NH01','LD02',7.5),
	('HS02','MH11','HK01','NH01','LD03',7),
	('HS02','MH11','HK01','NH01','LD04',5),

	('HS02','MH12','HK01','NH01','LD01',7),
	('HS02','MH12','HK01','NH01','LD02',7.5),
	('HS02','MH12','HK01','NH01','LD03',5),
	('HS02','MH12','HK01','NH01','LD04',7)

	--Diem Hoc ky 2 HS2
INSERT INTO DIEMMONHOC(MaHS, MaMH,MaHK, MaNH, MaLoaiDiem, Diem)
VALUES
	('HS02','MH01','HK02','NH01','LD01',5),
	('HS02','MH01','HK02','NH01','LD02',8),
	('HS02','MH01','HK02','NH01','LD03',7),
	('HS02','MH01','HK02','NH01','LD04',6),

	('HS02','MH02','HK02','NH01','LD01',7),
	('HS02','MH02','HK02','NH01','LD02',7),
	('HS02','MH02','HK02','NH01','LD03',9),
	('HS02','MH02','HK02','NH01','LD04',5),

	('HS02','MH03','HK02','NH01','LD01',7),
	('HS02','MH03','HK02','NH01','LD02',7.5),
	('HS02','MH03','HK02','NH01','LD03',5),
	('HS02','MH03','HK02','NH01','LD04',8),

	('HS02','MH04','HK02','NH01','LD01',7),
	('HS02','MH04','HK02','NH01','LD02',8.5),
	('HS02','MH04','HK02','NH01','LD03',9),
	('HS02','MH04','HK02','NH01','LD04',5),

	('HS02','MH05','HK02','NH01','LD01',6),
	('HS02','MH05','HK02','NH01','LD02',8),
	('HS02','MH05','HK02','NH01','LD03',9),
	('HS02','MH05','HK02','NH01','LD04',8),

	('HS02','MH06','HK02','NH01','LD01',8),
	('HS02','MH06','HK02','NH01','LD02',9),
	('HS02','MH06','HK02','NH01','LD03',8),
	('HS02','MH06','HK02','NH01','LD04',9.5),

	('HS02','MH07','HK02','NH01','LD01',7),
	('HS02','MH07','HK02','NH01','LD02',6.5),
	('HS02','MH07','HK02','NH01','LD03',8),
	('HS02','MH07','HK02','NH01','LD04',8),

	('HS02','MH08','HK02','NH01','LD01',8),
	('HS02','MH08','HK02','NH01','LD02',7.5),
	('HS02','MH08','HK02','NH01','LD03',5),
	('HS02','MH08','HK02','NH01','LD04',8.5),

	('HS02','MH09','HK02','NH01','LD01',8),
	('HS02','MH09','HK02','NH01','LD02',7.5),
	('HS02','MH09','HK02','NH01','LD03',5),
	('HS02','MH09','HK02','NH01','LD04',6),

	('HS02','MH10','HK02','NH01','LD01',7),
	('HS02','MH10','HK02','NH01','LD02',7.5),
	('HS02','MH10','HK02','NH01','LD03',5),
	('HS02','MH10','HK02','NH01','LD04',8),

	('HS02','MH11','HK02','NH01','LD01',7),
	('HS02','MH11','HK02','NH01','LD02',7.5),
	('HS02','MH11','HK02','NH01','LD03',7),
	('HS02','MH11','HK02','NH01','LD04',6),

	('HS02','MH12','HK02','NH01','LD01',7),
	('HS02','MH12','HK02','NH01','LD02',7.5),
	('HS02','MH12','HK02','NH01','LD03',5),
	('HS02','MH12','HK02','NH01','LD04',5)
--HS 3
INSERT INTO DIEMMONHOC(MaHS, MaMH,MaHK, MaNH, MaLoaiDiem, Diem)
VALUES
	('HS03','MH01','HK01','NH01','LD01',10),
	('HS03','MH01','HK01','NH01','LD02',9),
	('HS03','MH01','HK01','NH01','LD03',9),
	('HS03','MH01','HK01','NH01','LD04',10),

	('HS03','MH02','HK01','NH01','LD01',9),
	('HS03','MH02','HK01','NH01','LD02',9),
	('HS03','MH02','HK01','NH01','LD03',9),
	('HS03','MH02','HK01','NH01','LD04',9),

	('HS03','MH03','HK01','NH01','LD01',10),
	('HS03','MH03','HK01','NH01','LD02',10),
	('HS03','MH03','HK01','NH01','LD03',9),
	('HS03','MH03','HK01','NH01','LD04',9.5),

	('HS03','MH04','HK01','NH01','LD01',9),
	('HS03','MH04','HK01','NH01','LD02',8.5),
	('HS03','MH04','HK01','NH01','LD03',9),
	('HS03','MH04','HK01','NH01','LD04',8.5),

	('HS03','MH05','HK01','NH01','LD01',10),
	('HS03','MH05','HK01','NH01','LD02',9),
	('HS03','MH05','HK01','NH01','LD03',9),
	('HS03','MH05','HK01','NH01','LD04',9.5),

	('HS03','MH06','HK01','NH01','LD01',10),
	('HS03','MH06','HK01','NH01','LD02',9),
	('HS03','MH06','HK01','NH01','LD03',9),
	('HS03','MH06','HK01','NH01','LD04',10),

	('HS03','MH07','HK01','NH01','LD01',10),
	('HS03','MH07','HK01','NH01','LD02',9),
	('HS03','MH07','HK01','NH01','LD03',8.5),
	('HS03','MH07','HK01','NH01','LD04',8),

	('HS03','MH08','HK01','NH01','LD01',9),
	('HS03','MH08','HK01','NH01','LD02',10),
	('HS03','MH08','HK01','NH01','LD03',9),
	('HS03','MH08','HK01','NH01','LD04',9),

	('HS03','MH09','HK01','NH01','LD01',10),
	('HS03','MH09','HK01','NH01','LD02',9),
	('HS03','MH09','HK01','NH01','LD03',10),
	('HS03','MH09','HK01','NH01','LD04',10),

	('HS03','MH10','HK01','NH01','LD01',9),
	('HS03','MH10','HK01','NH01','LD02',9),
	('HS03','MH10','HK01','NH01','LD03',9),
	('HS03','MH10','HK01','NH01','LD04',9),

	('HS03','MH11','HK01','NH01','LD01',9),
	('HS03','MH11','HK01','NH01','LD02',10),
	('HS03','MH11','HK01','NH01','LD03',7.5),
	('HS03','MH11','HK01','NH01','LD04',9),

	('HS03','MH12','HK01','NH01','LD01',9),
	('HS03','MH12','HK01','NH01','LD02',9.5),
	('HS03','MH12','HK01','NH01','LD03',9),
	('HS03','MH12','HK01','NH01','LD04',10),
--HK2 HS 3
	('HS03','MH01','HK02','NH01','LD01',10),
	('HS03','MH01','HK02','NH01','LD02',8),
	('HS03','MH01','HK02','NH01','LD03',7),
	('HS03','MH01','HK02','NH01','LD04',9),

	('HS03','MH02','HK02','NH01','LD01',9),
	('HS03','MH02','HK02','NH01','LD02',7),
	('HS03','MH02','HK02','NH01','LD03',9),
	('HS03','MH02','HK02','NH01','LD04',9),

	('HS03','MH03','HK02','NH01','LD01',9),
	('HS03','MH03','HK02','NH01','LD02',8),
	('HS03','MH03','HK02','NH01','LD03',8),
	('HS03','MH03','HK02','NH01','LD04',8),

	('HS03','MH04','HK02','NH01','LD01',8),
	('HS03','MH04','HK02','NH01','LD02',8),
	('HS03','MH04','HK02','NH01','LD03',9),
	('HS03','MH04','HK02','NH01','LD04',9),

	('HS03','MH05','HK02','NH01','LD01',10),
	('HS03','MH05','HK02','NH01','LD02',8),
	('HS03','MH05','HK02','NH01','LD03',9),
	('HS03','MH05','HK02','NH01','LD04',8),

	('HS03','MH06','HK02','NH01','LD01',8),
	('HS03','MH06','HK02','NH01','LD02',9),
	('HS03','MH06','HK02','NH01','LD03',8),
	('HS03','MH06','HK02','NH01','LD04',9),

	('HS03','MH07','HK02','NH01','LD01',9),
	('HS03','MH07','HK02','NH01','LD02',9.5),
	('HS03','MH07','HK02','NH01','LD03',8),
	('HS03','MH07','HK02','NH01','LD04',9),

	('HS03','MH08','HK02','NH01','LD01',8),
	('HS03','MH08','HK02','NH01','LD02',7.5),
	('HS03','MH08','HK02','NH01','LD03',8),
	('HS03','MH08','HK02','NH01','LD04',10),

	('HS03','MH09','HK02','NH01','LD01',8),
	('HS03','MH09','HK02','NH01','LD02',7.5),
	('HS03','MH09','HK02','NH01','LD03',8),
	('HS03','MH09','HK02','NH01','LD04',9),

	('HS03','MH10','HK02','NH01','LD01',9),
	('HS03','MH10','HK02','NH01','LD02',7.5),
	('HS03','MH10','HK02','NH01','LD03',9),
	('HS03','MH10','HK02','NH01','LD04',9),

	('HS03','MH11','HK02','NH01','LD01',7),
	('HS03','MH11','HK02','NH01','LD02',7.5),
	('HS03','MH11','HK02','NH01','LD03',7),
	('HS03','MH11','HK02','NH01','LD04',10),

	('HS03','MH12','HK02','NH01','LD01',9),
	('HS03','MH12','HK02','NH01','LD02',8),
	('HS03','MH12','HK02','NH01','LD03',10),
	('HS03','MH12','HK02','NH01','LD04',9)

--HS 4
INSERT INTO DIEMMONHOC(MaHS, MaMH,MaHK, MaNH, MaLoaiDiem, Diem)
VALUES
	('HS04','MH01','HK01','NH01','LD01',9),
	('HS04','MH01','HK01','NH01','LD02',8),
	('HS04','MH01','HK01','NH01','LD03',9),
	('HS04','MH01','HK01','NH01','LD04',10),

	('HS04','MH02','HK01','NH01','LD01',7),
	('HS04','MH02','HK01','NH01','LD02',6),
	('HS04','MH02','HK01','NH01','LD03',9),
	('HS04','MH02','HK01','NH01','LD04',8.5),

	('HS04','MH03','HK01','NH01','LD01',8),
	('HS04','MH03','HK01','NH01','LD02',7.5),
	('HS04','MH03','HK01','NH01','LD03',9),
	('HS04','MH03','HK01','NH01','LD04',9),

	('HS04','MH04','HK01','NH01','LD01',7),
	('HS04','MH04','HK01','NH01','LD02',8.5),
	('HS04','MH04','HK01','NH01','LD03',9),
	('HS04','MH04','HK01','NH01','LD04',9.5),

	('HS04','MH05','HK01','NH01','LD01',6),
	('HS04','MH05','HK01','NH01','LD02',7.5),
	('HS04','MH05','HK01','NH01','LD03',9),
	('HS04','MH05','HK01','NH01','LD04',8),

	('HS04','MH06','HK01','NH01','LD01',8),
	('HS04','MH06','HK01','NH01','LD02',6),
	('HS04','MH06','HK01','NH01','LD03',7),
	('HS04','MH06','HK01','NH01','LD04',8.5),

	('HS04','MH07','HK01','NH01','LD01',7.5),
	('HS04','MH07','HK01','NH01','LD02',6.5),
	('HS04','MH07','HK01','NH01','LD03',5.5),
	('HS04','MH07','HK01','NH01','LD04',8),

	('HS04','MH08','HK01','NH01','LD01',8),
	('HS04','MH08','HK01','NH01','LD02',5),
	('HS04','MH08','HK01','NH01','LD03',5),
	('HS04','MH08','HK01','NH01','LD04',6),

	('HS04','MH09','HK01','NH01','LD01',4),
	('HS04','MH09','HK01','NH01','LD02',7.5),
	('HS04','MH09','HK01','NH01','LD03',5),
	('HS04','MH09','HK01','NH01','LD04',5),

	('HS04','MH10','HK01','NH01','LD01',7),
	('HS04','MH10','HK01','NH01','LD02',5),
	('HS04','MH10','HK01','NH01','LD03',5),
	('HS04','MH10','HK01','NH01','LD04',4),

	('HS04','MH11','HK01','NH01','LD01',7.5),
	('HS04','MH11','HK01','NH01','LD02',7.5),
	('HS04','MH11','HK01','NH01','LD03',7),
	('HS04','MH11','HK01','NH01','LD04',6),

	('HS04','MH12','HK01','NH01','LD01',8),
	('HS04','MH12','HK01','NH01','LD02',7.5),
	('HS04','MH12','HK01','NH01','LD03',5),
	('HS04','MH12','HK01','NH01','LD04',5),
--HK2 HS 4
	('HS04','MH01','HK02','NH01','LD01',8),
	('HS04','MH01','HK02','NH01','LD02',7),
	('HS04','MH01','HK02','NH01','LD03',7),
	('HS04','MH01','HK02','NH01','LD04',10),

	('HS04','MH02','HK02','NH01','LD01',10),
	('HS04','MH02','HK02','NH01','LD02',9),
	('HS04','MH02','HK02','NH01','LD03',9),
	('HS04','MH02','HK02','NH01','LD04',10),

	('HS04','MH03','HK02','NH01','LD01',10),
	('HS04','MH03','HK02','NH01','LD02',7.5),
	('HS04','MH03','HK02','NH01','LD03',5),
	('HS04','MH03','HK02','NH01','LD04',8),

	('HS04','MH04','HK02','NH01','LD01',9),
	('HS04','MH04','HK02','NH01','LD02',8.5),
	('HS04','MH04','HK02','NH01','LD03',9),
	('HS04','MH04','HK02','NH01','LD04',5),

	('HS04','MH05','HK02','NH01','LD01',6.5),
	('HS04','MH05','HK02','NH01','LD02',8),
	('HS04','MH05','HK02','NH01','LD03',9),
	('HS04','MH05','HK02','NH01','LD04',8),

	('HS04','MH06','HK02','NH01','LD01',10),
	('HS04','MH06','HK02','NH01','LD02',9),
	('HS04','MH06','HK02','NH01','LD03',8),
	('HS04','MH06','HK02','NH01','LD04',5),

	('HS04','MH07','HK02','NH01','LD01',10),
	('HS04','MH07','HK02','NH01','LD02',6.5),
	('HS04','MH07','HK02','NH01','LD03',8),
	('HS04','MH07','HK02','NH01','LD04',3),

	('HS04','MH08','HK02','NH01','LD01',7),
	('HS04','MH08','HK02','NH01','LD02',7.5),
	('HS04','MH08','HK02','NH01','LD03',5),
	('HS04','MH08','HK02','NH01','LD04',5),

	('HS04','MH09','HK02','NH01','LD01',8),
	('HS04','MH09','HK02','NH01','LD02',7.5),
	('HS04','MH09','HK02','NH01','LD03',5),
	('HS04','MH09','HK02','NH01','LD04',9),

	('HS04','MH10','HK02','NH01','LD01',7),
	('HS04','MH10','HK02','NH01','LD02',7.5),
	('HS04','MH10','HK02','NH01','LD03',5),
	('HS04','MH10','HK02','NH01','LD04',10),

	('HS04','MH11','HK02','NH01','LD01',7),
	('HS04','MH11','HK02','NH01','LD02',7.5),
	('HS04','MH11','HK02','NH01','LD03',7),
	('HS04','MH11','HK02','NH01','LD04',10),

	('HS04','MH12','HK02','NH01','LD01',7),
	('HS04','MH12','HK02','NH01','LD02',7.5),
	('HS04','MH12','HK02','NH01','LD03',5),
	('HS04','MH12','HK02','NH01','LD04',9)
--HS 5
INSERT INTO DIEMMONHOC(MaHS, MaMH,MaHK, MaNH, MaLoaiDiem, Diem)
VALUES
	('HS05','MH01','HK01','NH01','LD01',10),
	('HS05','MH01','HK01','NH01','LD02',8),
	('HS05','MH01','HK01','NH01','LD03',9),
	('HS05','MH01','HK01','NH01','LD04',10),

	('HS05','MH02','HK01','NH01','LD01',7),
	('HS05','MH02','HK01','NH01','LD02',8),
	('HS05','MH02','HK01','NH01','LD03',6),
	('HS05','MH02','HK01','NH01','LD04',8.5),

	('HS05','MH03','HK01','NH01','LD01',6),
	('HS05','MH03','HK01','NH01','LD02',7),
	('HS05','MH03','HK01','NH01','LD03',8),
	('HS05','MH03','HK01','NH01','LD04',9),

	('HS05','MH04','HK01','NH01','LD01',8),
	('HS05','MH04','HK01','NH01','LD02',8),
	('HS05','MH04','HK01','NH01','LD03',9),
	('HS05','MH04','HK01','NH01','LD04',9.5),

	('HS05','MH05','HK01','NH01','LD01',6),
	('HS05','MH05','HK01','NH01','LD02',7.5),
	('HS05','MH05','HK01','NH01','LD03',9),
	('HS05','MH05','HK01','NH01','LD04',6),

	('HS05','MH06','HK01','NH01','LD01',8),
	('HS05','MH06','HK01','NH01','LD02',6),
	('HS05','MH06','HK01','NH01','LD03',7),
	('HS05','MH06','HK01','NH01','LD04',8.5),

	('HS05','MH07','HK01','NH01','LD01',7.5),
	('HS05','MH07','HK01','NH01','LD02',7.5),
	('HS05','MH07','HK01','NH01','LD03',6.5),
	('HS05','MH07','HK01','NH01','LD04',9),

	('HS05','MH08','HK01','NH01','LD01',8.5),
	('HS05','MH08','HK01','NH01','LD02',5),
	('HS05','MH08','HK01','NH01','LD03',7),
	('HS05','MH08','HK01','NH01','LD04',5),

	('HS05','MH09','HK01','NH01','LD01',6),
	('HS05','MH09','HK01','NH01','LD02',8.5),
	('HS05','MH09','HK01','NH01','LD03',7),
	('HS05','MH09','HK01','NH01','LD04',5),

	('HS05','MH10','HK01','NH01','LD01',6),
	('HS05','MH10','HK01','NH01','LD02',5),
	('HS05','MH10','HK01','NH01','LD03',5),
	('HS05','MH10','HK01','NH01','LD04',4),

	('HS05','MH11','HK01','NH01','LD01',7.5),
	('HS05','MH11','HK01','NH01','LD02',7.5),
	('HS05','MH11','HK01','NH01','LD03',7),
	('HS05','MH11','HK01','NH01','LD04',6),

	('HS05','MH12','HK01','NH01','LD01',8),
	('HS05','MH12','HK01','NH01','LD02',7.5),
	('HS05','MH12','HK01','NH01','LD03',5),
	('HS05','MH12','HK01','NH01','LD04',5),
--HK2 HS 5
	('HS05','MH01','HK02','NH01','LD01',8.5),
	('HS05','MH01','HK02','NH01','LD02',7),
	('HS05','MH01','HK02','NH01','LD03',4),
	('HS05','MH01','HK02','NH01','LD04',10),

	('HS05','MH02','HK02','NH01','LD01',4),
	('HS05','MH02','HK02','NH01','LD02',4),
	('HS05','MH02','HK02','NH01','LD03',6),
	('HS05','MH02','HK02','NH01','LD04',10),

	('HS05','MH03','HK02','NH01','LD01',7),
	('HS05','MH03','HK02','NH01','LD02',8),
	('HS05','MH03','HK02','NH01','LD03',9),
	('HS05','MH03','HK02','NH01','LD04',6),

	('HS05','MH04','HK02','NH01','LD01',9),
	('HS05','MH04','HK02','NH01','LD02',8.5),
	('HS05','MH04','HK02','NH01','LD03',9),
	('HS05','MH04','HK02','NH01','LD04',5),

	('HS05','MH05','HK02','NH01','LD01',6.5),
	('HS05','MH05','HK02','NH01','LD02',8),
	('HS05','MH05','HK02','NH01','LD03',9),
	('HS05','MH05','HK02','NH01','LD04',8),

	('HS05','MH06','HK02','NH01','LD01',10),
	('HS05','MH06','HK02','NH01','LD02',9),
	('HS05','MH06','HK02','NH01','LD03',8),
	('HS05','MH06','HK02','NH01','LD04',5),

	('HS05','MH07','HK02','NH01','LD01',10),
	('HS05','MH07','HK02','NH01','LD02',5),
	('HS05','MH07','HK02','NH01','LD03',8.5),
	('HS05','MH07','HK02','NH01','LD04',7),
	
	('HS05','MH08','HK02','NH01','LD01',8),
	('HS05','MH08','HK02','NH01','LD02',7.5),
	('HS05','MH08','HK02','NH01','LD03',6),
	('HS05','MH08','HK02','NH01','LD04',5),

	('HS05','MH09','HK02','NH01','LD01',3),
	('HS05','MH09','HK02','NH01','LD02',3.5),
	('HS05','MH09','HK02','NH01','LD03',5),
	('HS05','MH09','HK02','NH01','LD04',9),

	('HS05','MH10','HK02','NH01','LD01',5),
	('HS05','MH10','HK02','NH01','LD02',7.5),
	('HS05','MH10','HK02','NH01','LD03',4),
	('HS05','MH10','HK02','NH01','LD04',6),

	('HS05','MH11','HK02','NH01','LD01',7),
	('HS05','MH11','HK02','NH01','LD02',7.5),
	('HS05','MH11','HK02','NH01','LD03',7),
	('HS05','MH11','HK02','NH01','LD04',10),

	('HS05','MH12','HK02','NH01','LD01',7.5),
	('HS05','MH12','HK02','NH01','LD02',7.5),
	('HS05','MH12','HK02','NH01','LD03',5.5),
	('HS05','MH12','HK02','NH01','LD04',9)

--HS 6
INSERT INTO DIEMMONHOC(MaHS, MaMH,MaHK, MaNH, MaLoaiDiem, Diem)
VALUES
	('HS06','MH01','HK01','NH01','LD01',8),
	('HS06','MH01','HK01','NH01','LD02',7),
	('HS06','MH01','HK01','NH01','LD03',6),
	('HS06','MH01','HK01','NH01','LD04',10),

	('HS06','MH02','HK01','NH01','LD01',9),
	('HS06','MH02','HK01','NH01','LD02',8),
	('HS06','MH02','HK01','NH01','LD03',7),
	('HS06','MH02','HK01','NH01','LD04',6),

	('HS06','MH03','HK01','NH01','LD01',4),
	('HS06','MH03','HK01','NH01','LD02',8),
	('HS06','MH03','HK01','NH01','LD03',6),
	('HS06','MH03','HK01','NH01','LD04',5),

	('HS06','MH04','HK01','NH01','LD01',9),
	('HS06','MH04','HK01','NH01','LD02',7),
	('HS06','MH04','HK01','NH01','LD03',6),
	('HS06','MH04','HK01','NH01','LD04',5),

	('HS06','MH05','HK01','NH01','LD01',8),
	('HS06','MH05','HK01','NH01','LD02',7),
	('HS06','MH05','HK01','NH01','LD03',6),
	('HS06','MH05','HK01','NH01','LD04',6),

	('HS06','MH06','HK01','NH01','LD01',7),
	('HS06','MH06','HK01','NH01','LD02',6),
	('HS06','MH06','HK01','NH01','LD03',7),
	('HS06','MH06','HK01','NH01','LD04',8.5),

	('HS06','MH07','HK01','NH01','LD01',5.5),
	('HS06','MH07','HK01','NH01','LD02',7.5),
	('HS06','MH07','HK01','NH01','LD03',6.5),
	('HS06','MH07','HK01','NH01','LD04',9),

	('HS06','MH08','HK01','NH01','LD01',8.5),
	('HS06','MH08','HK01','NH01','LD02',4),
	('HS06','MH08','HK01','NH01','LD03',7),
	('HS06','MH08','HK01','NH01','LD04',5),

	('HS06','MH09','HK01','NH01','LD01',6),
	('HS06','MH09','HK01','NH01','LD02',8.5),
	('HS06','MH09','HK01','NH01','LD03',7),
	('HS06','MH09','HK01','NH01','LD04',5),

	('HS06','MH10','HK01','NH01','LD01',6),
	('HS06','MH10','HK01','NH01','LD02',5),
	('HS06','MH10','HK01','NH01','LD03',5),
	('HS06','MH10','HK01','NH01','LD04',4),

	('HS06','MH11','HK01','NH01','LD01',7.5),
	('HS06','MH11','HK01','NH01','LD02',7.5),
	('HS06','MH11','HK01','NH01','LD03',7),
	('HS06','MH11','HK01','NH01','LD04',6),

	('HS06','MH12','HK01','NH01','LD01',8),
	('HS06','MH12','HK01','NH01','LD02',7.5),
	('HS06','MH12','HK01','NH01','LD03',5),
	('HS06','MH12','HK01','NH01','LD04',5),
--HK2 HS 6
	('HS06','MH01','HK02','NH01','LD01',7.5),
	('HS06','MH01','HK02','NH01','LD02',8),
	('HS06','MH01','HK02','NH01','LD03',9),
	('HS06','MH01','HK02','NH01','LD04',10),

	('HS06','MH02','HK02','NH01','LD01',5),
	('HS06','MH02','HK02','NH01','LD02',6),
	('HS06','MH02','HK02','NH01','LD03',7),
	('HS06','MH02','HK02','NH01','LD04',8),

	('HS06','MH03','HK02','NH01','LD01',7),
	('HS06','MH03','HK02','NH01','LD02',7),
	('HS06','MH03','HK02','NH01','LD03',7),
	('HS06','MH03','HK02','NH01','LD04',7),

	('HS06','MH04','HK02','NH01','LD01',8),
	('HS06','MH04','HK02','NH01','LD02',8.5),
	('HS06','MH04','HK02','NH01','LD03',8),
	('HS06','MH04','HK02','NH01','LD04',8),

	('HS06','MH05','HK02','NH01','LD01',8.5),
	('HS06','MH05','HK02','NH01','LD02',7),
	('HS06','MH05','HK02','NH01','LD03',6),
	('HS06','MH05','HK02','NH01','LD04',6),

	('HS06','MH06','HK02','NH01','LD01',10),
	('HS06','MH06','HK02','NH01','LD02',9),
	('HS06','MH06','HK02','NH01','LD03',8),
	('HS06','MH06','HK02','NH01','LD04',5),

	('HS06','MH07','HK02','NH01','LD01',8),
	('HS06','MH07','HK02','NH01','LD02',7),
	('HS06','MH07','HK02','NH01','LD03',6.5),
	('HS06','MH07','HK02','NH01','LD04',6),

	('HS06','MH08','HK02','NH01','LD01',8),
	('HS06','MH08','HK02','NH01','LD02',7.5),
	('HS06','MH08','HK02','NH01','LD03',9),
	('HS06','MH08','HK02','NH01','LD04',8),

	('HS06','MH09','HK02','NH01','LD01',7),
	('HS06','MH09','HK02','NH01','LD02',6.5),
	('HS06','MH09','HK02','NH01','LD03',6),
	('HS06','MH09','HK02','NH01','LD04',5),

	('HS06','MH10','HK02','NH01','LD01',9),
	('HS06','MH10','HK02','NH01','LD02',9.5),
	('HS06','MH10','HK02','NH01','LD03',8),
	('HS06','MH10','HK02','NH01','LD04',7),

	('HS06','MH11','HK02','NH01','LD01',9),
	('HS06','MH11','HK02','NH01','LD02',8),
	('HS06','MH11','HK02','NH01','LD03',7),
	('HS06','MH11','HK02','NH01','LD04',6),

	('HS06','MH12','HK02','NH01','LD01',7.5),
	('HS06','MH12','HK02','NH01','LD02',7.5),
	('HS06','MH12','HK02','NH01','LD03',5.5),
	('HS06','MH12','HK02','NH01','LD04',9)


--delete DIEMMONHOC
--delete HANHKIEM 
insert into HANHKIEM(MaHanhKiem, TenHanhKiem, MaNH, MaHK, MaHS)
 VALUES 
	('HK01',N'Tốt','NH01', 'HK01', 'HS01'),
	('HK02',N'Tốt','NH01', 'HK02', 'HS01'),
	('HK03',N'Trung Bình','NH01', 'HK01', 'HS02'),
	('HK04',N'Yếu','NH01', 'HK02', 'HS02'),
	('HK05',N'Tốt','NH01', 'HK01', 'HS03'),
	('HK06',N'Tốt','NH01', 'HK02', 'HS03'),
	('HK07',N'Tốt','NH01', 'HK01', 'HS04'),
	('HK08',N'Khá','NH01', 'HK02', 'HS04'),
	('HK09',N'Tốt','NH01', 'HK01', 'HS05'),
	('HK10',N'Tốt','NH01', 'HK02', 'HS05'),
	('HK11',N'Tốt','NH01', 'HK01', 'HS06'),
	('HK12',N'Khá','NH01', 'HK02', 'HS06')
DELETE HANHKIEM 
select * from HANHKIEM
---Tạo view tính điểm trung bình các môn học
CREATE VIEW Diem_Hoc_Sinh AS 
	SELECT hs.MaHS AS Ma_Hoc_Sinh, hs.TenHS AS Ten_Hoc_Sinh,mh.TenMH AS Ten_Mon_Hoc,ROUND(SUM(dmh.Diem*ld.HeSo)/7,2) as DTB,hk.TenHK AS Hoc_Ky, nh.TenNH AS Nam_Hoc FROM dbo.DIEMMONHOC dmh
	JOIN NAMHOC nh ON nh.MaNH = dmh.MaNH
	JOIN HOCSINH hs ON hs.MaHS = dmh.MaHS
	JOIN MONHOC mh ON mh.MaMH = dmh.MaMH
	JOIN HOCKY hk ON hk.MaHK = dmh.MaHK
	JOIN LOAIDIEM ld ON ld.MaLoaiDiem = dmh.MaLoaiDiem
	GROUP BY hs.MaHS, hk.TenHK,hs.TenHS,mh.TenMH, nh.TenNH

DROP VIEW Diem_Hoc_Sinh

SELECT * FROM Diem_Hoc_Sinh	where Ma_Hoc_Sinh='HS01' and  Hoc_Ky='Học kỳ 2' and Nam_Hoc ='2019-2020'

-- tạo Procedure tìm kiếm điểm HS 
GO;
ALTER PROC SP_TIMKIEM_TKDHS
	@TenNH char(10),
	@TenHK char(20),
	@MaHS char(10),
	@TenMH nvarchar(20)
AS
BEGIN 
	SELECT * FROM Diem_Hoc_Sinh
	WHERE (Nam_Hoc = @TenNH OR @TenNH = '')
	AND (Hoc_Ky= @TenHK OR @TenHK = '')
	AND (Ma_Hoc_Sinh = @MaHS OR @MaHS = '')
	AND (Ten_Mon_Hoc=@TenMH OR @TenMH = '')
	
END;
GO;
EXEC SP_TIMKIEM_TKDHS '', '', '', N'Toán';
---Tạo view tính điểm trung bình môn học kỳ 1
CREATE VIEW Diem_Hoc_Sinh_HK1 AS 
SELECT hs.MaHS AS  Ma_Hoc_Sinh, hs.TenHS AS Ten_Hoc_Sinh ,mh.TenMH AS Mon_Hoc ,ROUND(SUM(dmh.Diem*ld.HeSo)/7,1) AS DTBM_HK1, nh.TenNH AS Nam_Hoc FROM DIEMMONHOC dmh
	JOIN NAMHOC nh ON nh.MaNH = dmh.MaNH
	JOIN HOCSINH hs ON hs.MaHS = dmh.MaHS
	JOIN MONHOC mh ON mh.MaMH = dmh.MaMH
	JOIN HOCKY hk ON hk.MaHK = dmh.MaHK
	JOIN LOAIDIEM ld ON ld.MaLoaiDiem = dmh.MaLoaiDiem
	WHERE hk.MaHK='HK01'
GROUP BY hk.TenHK,hs.MaHS, hs.TenHS,mh.TenMH, nh.TenNH

SELECT * FROM Diem_Hoc_Sinh_HK1 where Ma_Hoc_Sinh='HS01'
DROP VIEW Diem_Hoc_Sinh_HK1
GO

---Tạo view tính điểm trung bình học kỳ 1
CREATE VIEW Diem_TBHK1 AS
SELECT Ma_Hoc_Sinh, Ten_Hoc_Sinh ,Nam_Hoc, ROUND(SUM(DTBM_HK1)/12,1) AS Diem_Trung_Binh_Hoc_Ky1 FROM Diem_Hoc_Sinh_HK1
GROUP BY Ma_Hoc_Sinh, Ten_Hoc_Sinh, Nam_Hoc
GO
SELECT * FROM Diem_TBHK1
DROP VIEW Diem_TBHK1 

---Tạo function tính DTB học kỳ 1
CREATE FUNCTION FC_DTBHK1
(
	@mahs varchar(10)
)
RETURNS FLOAT
AS
BEGIN
	DECLARE @dtbhk1 FLOAT

	SELECT @dtbhk1 = Diem_Trung_Binh_Hoc_Ky1 FROM Diem_TBHK1
	WHERE Ma_Hoc_Sinh = @mahs

	RETURN @dtbhk1
END
GO
SELECT dbo.FC_DTBHK1 ('HS01')
---Tạo function xét học lực học sinh học kỳ 1
CREATE FUNCTION fc_xethlhk1
	(@mahs VARCHAR(10))
	RETURNS NVARCHAR(20)
AS
	BEGIN
	DECLARE @dtbhk1 FLOAT
	DECLARE @hocluc NVARCHAR(20)
	SET @dtbhk1= (SELECT dbo.FC_DTBHK1(@mahs))
	
	IF (@dtbhk1>=8.0)
		SET @hocluc= N'Giỏi'
	ELSE
	--begin
	IF (6.5<=@dtbhk1)
		SET @hocluc= N'Khá'
	ELSE
	IF (@dtbhk1>=5.0)
		SET @hocluc= 'TB'
	ELSE 
	IF (@dtbhk1>=3.5)
		SET @hocluc= N'Yếu'
	ELSE 
		SET @hocluc= N'Kém'	
	RETURN @hocluc
	END

SELECT dbo.fc_xethlhk1 ('HS04')

-----tạo view form báo cáo/thống kê theo học kỳ 1
CREATE VIEW bc_hk1 as
SELECT
	HOCSINH.MaHS AS Ma_Hoc_Sinh,
	HOCSINH.TenHS AS Ten_Hoc_Sinh,
	dbo.FC_DTBHK1(HOCSINH.MaHS) AS Diem_Trung_Binh,
	dbo.fc_xethlhk1(HOCSINH.MaHS) AS Hoc_Luc,
	HANHKIEM.TenHanhKiem AS Hanh_Kiem,
	NAMHOC.TenNH AS Nam_Hoc
	FROM HOCSINH, HANHKIEM, NAMHOC
	WHERE HOCSINH.MaHS=HANHKIEM.MaHS AND NAMHOC.MaNH=HANHKIEM.MaNH AND HANHKIEM.MaHK='HK01'
	GO
SELECT * FROM bc_hk1
DROP VIEW bc_hk1	
----Tạo Procedure tìm kiếm trong form báo cáo/thống kê theo học kỳ 1
CREATE PROC SP_BCHK1
	@TenNH char(10),
	@MaHS char(10)
AS
BEGIN 
	SELECT * FROM bc_hk1
	WHERE (Nam_Hoc = @TenNH OR @TenNH = '')
	AND (Ma_Hoc_Sinh = @MaHS OR @MaHS = '')	
END;
GO;
EXEC SP_BCHK1 '2019-2020','HS02';


---Tạo view tính điểm trung bình môn học học kỳ 2
CREATE VIEW Diem_Hoc_Sinh_HK2 AS 
SELECT hs.MaHS AS Ma_Hoc_Sinh, hs.TenHS AS Ten_Hoc_Sinh,mh.TenMH AS Ten_Mon_Hoc, nh.TenNH AS Nam_Hoc, ROUND(SUM(dmh.Diem*ld.HeSo)/7,1) AS DTBM_HK2 FROM  DIEMMONHOC dmh
	JOIN NAMHOC nh ON nh.MaNH = dmh.MaNH
	JOIN HOCSINH hs ON hs.MaHS = dmh.MaHS
	JOIN MONHOC mh ON mh.MaMH = dmh.MaMH
	JOIN HOCKY hk ON hk.MaHK = dmh.MaHK
	JOIN LOAIDIEM ld ON ld.MaLoaiDiem = dmh.MaLoaiDiem
	WHERE hk.MaHK='HK02'
GROUP BY hk.TenHK,hs.MaHS, hs.TenHS,mh.TenMH, nh.TenNH
GO

SELECT * FROM Diem_Hoc_Sinh_HK2 where Ma_Hoc_Sinh='HS01'

DROP VIEW Diem_Hoc_Sinh_HK2

---Tạo view tính điểm trung bình học kỳ 2
CREATE VIEW Diem_TBHK2 AS
SELECT Ma_Hoc_Sinh, Ten_Hoc_Sinh , Nam_Hoc, ROUND(SUM(DTBM_HK2)/12,1) AS Diem_Trung_Binh_Hoc_Ky2 FROM Diem_Hoc_Sinh_HK2
GROUP BY Ma_Hoc_Sinh, Ten_Hoc_Sinh, Nam_Hoc
GO

SELECT * FROM Diem_TBHK2 

DROP VIEW Diem_TBHK2
---Tạo function tính DTB học kỳ 2
CREATE FUNCTION FC_DTBHK2
(
	@mahs VARCHAR(10)
)
RETURNS FLOAT
AS
BEGIN
	DECLARE @dtbhk2 FLOAT

	SELECT @dtbhk2 = Diem_Trung_Binh_Hoc_Ky2 FROM Diem_TBHK2
	WHERE Ma_Hoc_Sinh = @mahs

	RETURN @dtbhk2
END
GO

SELECT dbo.FC_DTBHK2 ('HS01')

--------Tạo function xét học lực học sinh học kỳ 2
CREATE FUNCTION fc_xethlhk2
	(@mahs VARCHAR(10))
	RETURNS NVARCHAR(20)
AS
	BEGIN
	DECLARE @dtbhk2 FLOAT
	DECLARE @hocluc NVARCHAR(20)
	SET @dtbhk2= (SELECT dbo.FC_DTBHK1(@mahs))
	
	IF(@dtbhk2>=8.0)
		SET @hocluc= N'Giỏi'
	ELSE 
	--begin
	IF (6.5<=@dtbhk2)
		SET @hocluc= N'Khá'
	ELSE
	IF (@dtbhk2>=5.0)
		SET @hocluc= 'TB'
	ELSE 
	IF (@dtbhk2>=3.5)
		SET @hocluc= N'Yếu'
	ELSE 
		SET @hocluc= N'Kém'	
	RETURN @hocluc
	END

SELECT dbo.fc_xethlhk2 ('HS04')

-----tạo view form báo cáo/thống kê điểm HS theo học kỳ 2
CREATE VIEW bc_hk2 AS
SELECT
	HOCSINH.MaHS AS Ma_Hoc_Sinh,
	HOCSINH.TenHS AS Ten_Hoc_Sinh,
	dbo.FC_DTBHK2(HOCSINH.MaHS) AS Diem_Trung_Binh,
	dbo.fc_xethlhk2(HOCSINH.MaHS) AS Hoc_Luc,
	HANHKIEM.TenHanhKiem AS Hanh_Kiem,
	NAMHOC.TenNH AS Nam_Hoc
	FROM HOCSINH, HANHKIEM, NAMHOC
	WHERE HOCSINH.MaHS=HANHKIEM.MaHS AND NAMHOC.MaNH=HANHKIEM.MaNH AND HANHKIEM.MaHK='HK02'
	GO
SELECT * FROM bc_hk2
DROP VIEW bc_hk2	
----Tạo Procedure tìm kiếm trong form báo cáo/thống kê điểm HS theo học kỳ 2
CREATE PROC SP_BCHK2
	@TenNH VARCHAR(10),
	@MaHS VARCHAR(10)
AS
BEGIN 
	SELECT * FROM bc_hk2
	WHERE (Nam_Hoc = @TenNH OR @TenNH = '')
	AND (Ma_Hoc_Sinh = @MaHS OR @MaHS = '')	
END;
GO;
EXEC SP_BCHK2 '2019-2020','';

---Tạo view tính điểm trung bình cả năm 
CREATE VIEW DTB AS
SELECT tb1.Ma_Hoc_Sinh, tb1.Ten_Hoc_Sinh, tb1.Nam_Hoc, ROUND((Diem_Trung_Binh_Hoc_Ky2*2+Diem_Trung_Binh_Hoc_Ky1)/3,1) AS Diem_Trung_Binh_Ca_Nam 
FROM Diem_TBHK2 tb2 
JOIN Diem_TBHK1 tb1 ON tb1.Ma_Hoc_Sinh=tb2.Ma_Hoc_Sinh

DROP VIEW DTB
SELECT * FROM DTB
---Tạo view xét hạnh kiểm cả năm
CREATE VIEW Hanh_kiem_Hoc_Sinh AS 
	SELECT hs.MaHS AS Ma_Hoc_Sinh, hs.TenHS AS Ten_Hoc_Sinh, nh.TenNH AS Nam_Hoc, hk.TenHanhKiem as Hanh_Kiem FROM dbo.HANHKIEM hk
	JOIN dbo.NAMHOC nh ON nh.MaNH = hk.MaNH
	JOIN dbo.HOCSINH hs ON hs.MaHS = hk.MaHS
	where hk.MaHK='HK02'

DROP VIEW Hanh_kiem_Hoc_Sinh

SELECT * FROM Hanh_kiem_Hoc_Sinh
---Tạo Function Xet hanh kiem cả năm
CREATE FUNCTION FC_HKCANAM
(
	@mahs VARCHAR(10)
)
RETURNS VARCHAR(20)
AS
BEGIN
	DECLARE @hk VARCHAR(20)
	SELECT @hk = Hanh_Kiem FROM Hanh_kiem_Hoc_Sinh
	WHERE Ma_Hoc_Sinh = @mahs
	RETURN @hk
END
GO

SELECT dbo.FC_HKCANAM('HS01')
----tạo function tính DTB cả năm
CREATE FUNCTION FC_DTBCANAM
(
	@mahs VARCHAR(10)
)
RETURNS FLOAT
AS
BEGIN
	DECLARE @dtb FLOAT
	SELECT @dtb = Diem_Trung_Binh_Ca_Nam FROM DTB
	WHERE Ma_Hoc_Sinh = @mahs
	RETURN @dtb
END
GO

SELECT dbo.FC_DTBCANAM('HS01')

--------Tạo function xét học lực cả năm 
CREATE FUNCTION fc_xethlcanam
	(@mahs VARCHAR(10))
	RETURNS VARCHAR(20)
AS
	BEGIN
	DECLARE @dtb FLOAT
	DECLARE @hocluc VARCHAR(20)
	SET @dtb= (SELECT dbo.FC_DTBCANAM(@mahs))
	
	IF (@dtb>=8.0)
		SET @hocluc= N'Giỏi'
	ELSE 
	--begin
	IF (6.5<=@dtb)
		SET @hocluc= N'Khá'
	ELSE
	IF (@dtb>=5.0)
		SET @hocluc= 'TB'
	ELSE 
	IF (@dtb>=3.5)
		SET @hocluc= N'Yếu'
	ELSE 
		SET @hocluc= N'Kém'	
	RETURN @hocluc
	END

SELECT dbo.fc_xethlcanam ('HS04')

-----tạo view form báo cáo cả năm
CREATE VIEW bc_canam AS
SELECT DISTINCT 
	HOCSINH.MaHS AS Ma_Hoc_Sinh,
	HOCSINH.TenHS AS Ten_Hoc_Sinh,
	NAMHOC.TenNH AS Nam_Hoc,
	dbo.FC_DTBHK1(HOCSINH.MaHS) AS Ky_1,
	dbo.FC_DTBHK2(HOCSINH.MaHS) AS Ky_2,
	dbo.FC_DTBCANAM(HOCSINH.MaHS) AS Ca_Nam,
	dbo.fc_xethlcanam(HOCSINH.MaHS) AS Hoc_Luc,
	dbo.FC_HKCANAM(HOCSINH.MaHS) AS Hanh_Kiem
	FROM HOCSINH,HANHKIEM, NAMHOC
	WHERE HOCSINH.MaHS=HANHKIEM.MaHS  AND NAMHOC.MaNH=HANHKIEM.MaNH 
	GO
SELECT * FROM bc_canam where Ma_Hoc_Sinh='HS01'
DROP VIEW bc_canam	

----Tạo Procedure tìm kiếm trong form báo cáo cả năm
CREATE PROC SP_BCCANAM 
	@TenNH char(10),
	@MaHS char(10)
AS
BEGIN 
	SELECT * FROM bc_canam
	WHERE (Nam_Hoc = @TenNH OR @TenNH = '')
	AND (Ma_Hoc_Sinh = @MaHS OR @MaHS = '')	
END;
GO
EXEC SP_BCCANAM '2019-2020','HS01';
---

-------------------------form HS xem điểm-------------------------------
---tạo view cho form học sinh xem điểm theo học kỳ 1 hoặc 2
CREATE VIEW XemdiemHS AS
SELECT HOCSINH.MaHS AS Ma_Hoc_Sinh, HOCSINH.TenHS , NAMHOC.TenNH AS Nam_Hoc, 
		HOCKY.TenHK AS Hoc_Ky,MONHOC.TenMH AS Ten_Mon_Hoc, LOAIDIEM.TenLoaiDiem, DIEMMONHOC.Diem

	
FROM DIEMMONHOC, HOCSINH, NAMHOC, HOCKY, MONHOC, LOAIDIEM
WHERE HOCSINH.MaHS=DIEMMONHOC.MaHS 
	AND DIEMMONHOC.MaNH=NAMHOC.MaNH
	AND DIEMMONHOC.MaHK=HOCKY.MaHK
	AND DIEMMONHOC.MaMH=MONHOC.MaMH
	AND DIEMMONHOC.MaLoaiDiem=LOAIDIEM.MaLoaiDiem
select * from XemdiemHS
drop view XemdiemHS

SELECT * FROM 	XemdiemHS WHERE Ma_Hoc_Sinh='HS01' AND Hoc_Ky='Học kỳ 2'

-- tạo Procedure cho form học sinh xem điểm
GO;
CREATE PROC SP_TIMKIEM_CHITIET
	@TenNH char(10),
	@TenHK char(20),
	@MaHS char(10),
	@TenMH nvarchar(20)
AS
BEGIN 
	SELECT * FROM XemdiemHS
	WHERE (Nam_Hoc = @TenNH OR @TenNH = '')
	AND (Hoc_Ky= @TenHK OR @TenHK = '')
	AND (Ma_Hoc_Sinh = @MaHS OR @MaHS = '')
	AND (Ten_Mon_Hoc=@TenMH OR @TenMH = '')
	
END;
GO;

---tính điểm trung bình các môn cả năm
create view vm_tinhdiem as
select tb1.Ma_Hoc_Sinh, tb1.Ten_Hoc_Sinh, tb1.Mon_Hoc, tb1.Nam_Hoc, ROUND((tb2.DTBM_HK2*2+tb1.DTBM_HK1)/3,1) as diem
from Diem_Hoc_Sinh_HK1 tb1
join Diem_Hoc_Sinh_HK2 tb2 on tb1.Ma_Hoc_Sinh=tb2.Ma_Hoc_Sinh and tb1.Mon_Hoc=tb2.Ten_Mon_Hoc and tb1.Nam_Hoc=tb2.Nam_Hoc
	
select* from vm_tinhdiem where Ma_Hoc_Sinh='HS01'
drop view vm_tinhdiem