create database if not exists sales;

create table if not exists materials (
	Id int(11) unsigned auto_increment primary key,
	Description longtext
);