delete from labtests;
ALter table Labtests Add visit_id int;
-- labtests
INSERT into  labtests (   patientId,   orderDateTime, performedDateTime, testCode,   results, normal,visit_id) values
(1,'10-APR-2021 14:15:00', null, 'CULTURES', NULL, 'Y',1),
(2,'10-APR-2021 14:15:00', null, 'GLUCOSE', NULL, 'Y',2);

 insert into clinicadmins (persons_id) values (3);
 INSERT into login (   userName,   password,   admin_id,   nurse_id,   doctor_id,   patient_id) select 'doe', 'test1234', id, null, null, null from clinicadmins where persons_id=3;   
 insert into nurses  (status , persons_id) values ('A', 8);
 INSERT into login (   userName,   password,   admin_id,   nurse_id,   doctor_id,   patient_id) select 'jane', 'test1234', null, id, null, null from nurses where persons_id=8;  
 