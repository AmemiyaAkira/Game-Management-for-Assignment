--创建用户表--
CREATE TABLE [dbo].[user]
(
	[uid] int not null primary key identity(1,1),
	uname varchar(16) not null check((len(uname)>=8 and len(uname)<=16) and (uname='_' or (uname>='0'and uname<='9') or (uname>='a'and uname<='z') or(uname>='A'and uname<='Z'))),
	upw varchar(16) not null check((len(upw)>=8 and len(upw)<=16) and ((upw>='0'and upw<='9' or (upw>='a' and upw<='z')or (upw>='A' and upw<='Z')))),
	uban tinyint not null default 0,
	uphone varchar(20) not null check(uphone>='0' and uphone<='9'),
	uemail varchar(30),
	uredate date not null);

--创建管理员表--
	CREATE TABLE [dbo].[admin]
(
	aid int not null primary key identity(1,1),
	aname varchar(16) not null check((len(aname)>=8 and len(aname)<=16) and (aname='_' or (aname>='0'and aname<='9') or (aname>='a'and aname<='z') or(aname>='A'and aname<='Z'))),
	apw varchar(16) not null check((len(apw)>=8 and len(apw)<=16) and ((apw>='0'and apw<='9' or (apw>='a' and apw<='z')or (apw>='A' and apw<='Z')))),
	apstn tinyint not null default 0);

--创建游戏表--
	CREATE TABLE [dbo].[game]
(
	gid int not null primary key identity(1,1),
	gname nvarchar(30) not null);

--创建激活游戏表--
	CREATE TABLE [dbo].[active]
(
	actid int not null primary key identity(1,1),
	gid int not null,
	[uid] int not null, 
    CONSTRAINT [FK_active_togame] FOREIGN KEY (gid) REFERENCES game(gid),
	CONSTRAINT [FK_active_touser] FOREIGN KEY ([uid]) REFERENCES [user]([uid]));

--测试数据--
INSERT INTO [admin] VALUES('admin0001','00000000',0)
GO
INSERT INTO [admin] VALUES('admin0002','00000000',1)
GO
INSERT INTO [user] VALUES('user0001','11111111',0,'11111111','11111111@qq.com','2020-01-01')
GO
INSERT INTO [user] VALUES('user0002','11111111',1,'2222222',null,'2020-02-02')
GO
INSERT INTO game VALUES('Tetris')
GO
INSERT INTO game VALUES('黄金矿工')
GO
INSERT INTO active VALUES(1,2)
GO
INSERT INTO active VALUES(2,1)
GO