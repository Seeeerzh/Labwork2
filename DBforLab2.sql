create table technic(
technicid serial,
technicname varchar(300),
typeoftechnic varchar(300),
dateofcreation date,
usedbymajor boolean
);

insert into technic(technicname, typeoftechnic, dateofcreation, usedbymajor) 
values 
('Galaxy watch', 'smartwatches', '2020-05-01', 'true');



select * from technic;

create table techniccompany(
companyid serial,
companyname varchar(300),
origincountry varchar(300),
openingdate date,
licenseforselling boolean
);
insert into techniccompany(companyname, origincountry, openingdate, licenseforselling) 
values 
('Samsung', 'Korea', '1880-08-21', 'true');
select * from techniccompany;

