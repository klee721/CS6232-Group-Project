insert into state (statecode, name) values ('AL','Alabama');
insert into state (statecode, name) values ('AK','Alaska');
insert into state (statecode, name) values ('AZ','Arizona');
insert into state (statecode, name) values ('AR','Arkansas');
insert into state (statecode, name) values ('CA','California');
insert into state (statecode, name) values ('CO','Colorado');
insert into state (statecode, name) values ('CT','Connecticut');
insert into state (statecode, name) values ('DE','Delaware');
insert into state (statecode, name) values ('FL','Florida');
insert into state (statecode, name) values ('GA','Georgia');
insert into state (statecode, name) values ('HI','Hawaii');
insert into state (statecode, name) values ('ID','Idaho');
insert into state (statecode, name) values ('IL','Illinois');
insert into state (statecode, name) values ('IN','Indiana');
insert into state (statecode, name) values ('IA','Iowa');
insert into state (statecode, name) values ('KS','Kansas');
insert into state (statecode, name) values ('KY','Kentucky');
insert into state (statecode, name) values ('LA','Louisiana');
insert into state (statecode, name) values ('ME','Maine');
insert into state (statecode, name) values ('MD','Maryland');
insert into state (statecode, name) values ('MA','Massachusetts');
insert into state (statecode, name) values ('MI','Michigan');
insert into state (statecode, name) values ('MN','Minnesota');
insert into state (statecode, name) values ('MS','Mississippi');
insert into state (statecode, name) values ('MO','Missouri');
insert into state (statecode, name) values ('MT','Montana');
insert into state (statecode, name) values ('NE','Nebraska');
insert into state (statecode, name) values ('NV','Nevada');
insert into state (statecode, name) values ('NH','New Hampshire');
insert into state (statecode, name) values ('NJ','New Jersey');
insert into state (statecode, name) values ('NM','New Mexico');
insert into state (statecode, name) values ('NY','New York');
insert into state (statecode, name) values ('NC','North Carolina');
insert into state (statecode, name) values ('ND','North Dakota');
insert into state (statecode, name) values ('OH','Ohio');
insert into state (statecode, name) values ('OK','Oklahoma');
insert into state (statecode, name) values ('OR','Oregon');
insert into state (statecode, name) values ('PA','Pennsylvania');
insert into state (statecode, name) values ('RI','Rhode Island');
insert into state (statecode, name) values ('SC','South Carolina');
insert into state (statecode, name) values ('SD','South Dakota');
insert into state (statecode, name) values ('TN','Tennessee');
insert into state (statecode, name) values ('TX','Texas');
insert into state (statecode, name) values ('UT','Utah');
insert into state (statecode, name) values ('VT','Vermont');
insert into state (statecode, name) values ('VA','Virginia');
insert into state (statecode, name) values ('WA','Washington');
insert into state (statecode, name) values ('WV','West Virginia');
insert into state (statecode, name) values ('WI','Wisconsin');
insert into state (statecode, name) values ('WY','Wyoming');


-- Persons
insert into persons 
(  firstName,
   lastName,
   dateOfBirth,
   gender,
   SSN,
   Address1,
   Address2,
   city,
   state,
   zipcode,
   phoneNumber) values 
   ('Sam', 'Houston','01-JAN-1967','Male','123456789','1301 michigan st',NULL, 'TROY','MI','48007', '1234567890'),
   ('Michael', 'Jordan','15-AUG-1976','Male','123283229','5400 preston rd',NULL, 'ADDISON','TX','75240', '1232123213'),
   ('David', 'Harley','30-JUN-1982','Male','432443243','123 main rd',NULL, 'NEW York','NY','10001', '4318732434'),
   ('Lauren', 'Singleton','01-AUG-1987','Female','432432241','1234 7th street','APT 1244', 'NEW JERSEY','NY','10006', '1456432412'),
   ('Gary', 'Smith','10-APR-1991','Male','983434683','1801 Mc David st','20323', 'Los Angeles','LA','90001', '4322141225'),
   ('Laura', 'Amber','24-JAN-1967','Female','342482325','818 Carrolton ave',NULL, 'ATLANTA','GA','30301', '3213215423');
   ('Mitchell', 'Iyer','10-OCT-1991','Female','764434659','1000 arlington ave','APT 378', 'Los Angeles','LA','90001', '5424322141'),
   ('Sara', 'Haggins','21-JAN-1984','Female','342321323','123 Main ave',NULL, 'TAMPA','FL','32006', '3214514312');
   
 -- Clinic admins  
  insert into clinicadmins (persons_id) values (1);
  
 -- nurses
 insert into nurses  (status , persons_id) values 
 ('A', 4),
 ('A', 6);
 
 -- patients
 
 insert into patients (persons_id) values 
 (2),
 (5),
 (7);

-- doctors
 insert into doctors (persons_id) values 
 (8),
 (3);

--login

INSERT into login (   userName,   password,   admin_id,   nurse_id,   doctor_id,   patient_id) values
('Sam', 'test1234', 1, null, null, null),    
('Lauren', 'test123', null, 1, null, null),    
('Laura', 'test4321', null, 2, null, null);


-- doctorspecialities
INSERT into doctorspecialities (doctor_id ,   specialityType,   description)
(select id, 'PRIMARY', 'Primary care physician' from doctors);

-- appointments 
INSERT into appointments (patientId,doctor_id,   AppointmentDateTime,   reasons, status)  
(select 1,id, '10-APR-2021 14:00:00', 'regular physicals' ,'A' from doctors where persons_id= 8);

INSERT into appointments (patientId,doctor_id,   AppointmentDateTime,   reasons, status)  
(select 2,id, '10-APR-2021 14:00:00', 'regular physicals' ,'A' from doctors where persons_id= 3);

-- visits
INSERT into  visits (appointment_id,weight,height,bodyTemparature,  pulse,  symptoms,  nurseId,  bloodPressureSystolic,  bloodPressureDiastolic,  initialDiagnose,  finalDiagnose) values
(1, 150.2,160,99,45,'None', 1, 103,68, 'Regular physicals are fine',null),
(2, 160.2,170,98,32,'None', 1, 112,89, 'Lower blood pressure is high',null);

-- tests
INSERT into  tests (testCode,   Name,   description) values 
('CBC', 'Complete Blood Count', 'Blood count'),
('CULTURES', 'Cultures test' ,'Cultures are used to test for diagnosis'),
('GLUCOSE','Glucose test', 'check sugar levels');

-- labtests
INSERT into  labtests (   patientId,   orderDateTime, performedDateTime, testCode,   results, normal) values
(1,'10-APR-2021 14:15:00', null, 'CULTURES', NULL, 'Y'),
(1,'10-APR-2021 14:15:00', null, 'CBC', NULL, 'Y'),
(1,'10-APR-2021 14:15:00', null, 'GLUCOSE', NULL, 'Y'),
(2,'10-APR-2021 14:15:00', null, 'CULTURES', NULL, 'Y'),
(2,'10-APR-2021 14:15:00', null, 'CBC', NULL, 'Y'),
(2,'10-APR-2021 14:15:00', null, 'GLUCOSE', NULL, 'Y');

