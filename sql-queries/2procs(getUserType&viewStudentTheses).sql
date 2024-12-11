USE [PostGradOffice]
GO
/****** Object:  StoredProcedure [dbo].[viewMyProfile]    Script Date: 12/25/2021 4:53:31 PM ******/
create proc getUserType
@UserId int,
@type varchar(100) output

as
if(exists(
select * from GucianStudent where id = @UserId
))
begin
set @type='GucianStudent'
end
else if(exists(
select * from NonGucianStudent where id = @UserId
))
begin
set @type='NonGucianStudent'
end
else if(exists(
select * from Supervisor where id = @UserId
))
begin
set @type='Supervisor'
end
else if(exists(
select * from Admin where id = @UserId
))
begin
set @type='Admin'
end
else if(exists(
select * from Examiner where id = @UserId
))
begin
set @type='Examiner'
end
else 
begin
set @type='Not Defined'
end
go 

create proc viewStudentTheses

@Id int
as
if(exists(
select * from GUCianStudentRegisterThesis where sid = @Id
))
begin
select t.* from Thesis t inner join GUCianStudentRegisterThesis g on g.serial_no =t.serialNumber
where g.sid = @Id
end
else if(exists(
select * from NonGUCianStudentRegisterThesis where sid = @Id
))
begin
select * from Thesis t inner join NonGUCianStudentRegisterThesis g on g.serial_no =t.serialNumber
where g.sid = @Id
end

go