create database if not exists sales;

use sales;

create table if not exists materials (
	Id int(11) unsigned auto_increment primary key,
	Description longtext
);

# retrieve table schemas.
describe materials;
describe items;
describe orderline;
describe orders;
describe clients;

# populating clients tables.
insert into clients (FirstName, LastName) values ('John', 'Doe');
insert into clients (FirstName, LastName) values ('John', 'Smith');
insert into clients (FirstName, LastName) values ('Marry', 'Jane');
insert into clients (FirstName, LastName) values ('Iker', 'Robertson');

select * from clients;

# populating materials tables.
insert into materials (Description) values ('aluminium');
insert into materials (Description) values ('copper');
insert into materials (Description) values ('steel');

select * from materials;

# populating stock items tables.
insert into items (Description) values ('table frame');

select * from items;

# dropping the tables.
drop table orderline;
drop table items;
drop table materials;
drop table orders;
drop table clients;