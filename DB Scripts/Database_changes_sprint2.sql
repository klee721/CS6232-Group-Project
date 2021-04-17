delete from labtests;
ALter table Labtests Add visit_id int;
-- labtests
INSERT into  labtests (   patientId,   orderDateTime, performedDateTime, testCode,   results, normal,visit_id) values
(1,'10-APR-2021 14:15:00', null, 'CULTURES', NULL, 'Y',1),
(2,'10-APR-2021 14:15:00', null, 'GLUCOSE', NULL, 'Y',2);