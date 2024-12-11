Create proc userLogin
@id int,
@password varchar(20),
@success bit output,
@type int output
as
begin
if exists(
select ID,password
from PostGradUser
where id=@id and password=@password)
begin
set @success =1
--check user type 0-->Student,1-->Admin,2-->Supervisor ,3-->Examiner, 4-->NonGucianStudent
if exists(select id from GucianStudent where id=@id)
set @type=0
if exists(select id from NonGucianStudent where id=@id)
set @type=4
if exists(select id from Admin where id=@id)
set @type=1
if exists(select id from Supervisor where id=@id)
set @type=2
if exists(select id from Examiner where id=@id)
set @type=3
end
else
set @success=0
end
go