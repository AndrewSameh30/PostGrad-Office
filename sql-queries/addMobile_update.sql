create proc addMobile
@ID varchar(20),
@mobile_number varchar(20)
as
begin
if @ID is not null and @mobile_number is not null
begin
--check Gucian student or not
if(exists(select * from GucianStudent where id=@ID))
if(not exists(select * from  GUCStudentPhoneNumber where id=@ID and phone=@mobile_number))
insert into GUCStudentPhoneNumber values(@mobile_number,@ID)
if(exists(select * from NonGucianStudent where id=@ID))
if(not exists(select * from  NonGUCStudentPhoneNumber where id=@ID and phone=@mobile_number))
insert into NonGUCStudentPhoneNumber values(@mobile_number,@ID)
end
end