create database if not exists sales;

use sales;

create table if not exists materials (
	Id int(11) unsigned auto_increment primary key,
	Description longtext
);

# retrieve table schemas.
describe materials;
describe items;
describe orderlines;
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
insert into items (Description, MaterialId) values ('table frame', 1);

select * from items;

# populating orders table.
insert into orders (Id, ClientId) values ('e8cf122b-7feb-4bb7-8035-f9b253d8649a', 1);

select * from orders;

# populating ordelines.
insert into orderlines (Id, ItemId, OrderId, Quantity) values (
	'97add193-495a-4cb5-a588-2ba3607f0729',
    1,
    'e8cf122b-7feb-4bb7-8035-f9b253d8649a',
    2
);

select * from orderlines;

# dropping the tables.
drop table orderlines;
drop table items;
drop table materials;
drop table orders;
drop table clients;