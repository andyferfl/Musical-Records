USE master
DROP DATABASE music
GO

CREATE DATABASE music ON
(Name= Music, 
FileName='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ Music.mdf'
) 
LOG ON  
(Name= Music_log, 
FileName='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ Music_log.ldf'
) 
Go

USE music

CREATE TABLE Role
(role_id int IDENTITY(1,1) PRIMARY KEY,
role varchar(64) NOT NULL UNIQUE)

CREATE TABLE [User]
(user_id int IDENTITY(1,1) PRIMARY KEY,
login varchar(64) NOT NULL UNIQUE,
password varchar(128) NOT NULL,
role_id int FOREIGN KEY REFERENCES Role
ON DELETE SET NULL
ON UPDATE CASCADE)

CREATE TABLE Customer
(customer_id int IDENTITY(1,1) PRIMARY KEY,
name varchar(64) NOT NULL,
last_name varchar(64) NOT NULL,
phone_number varchar(15) NOT NULL UNIQUE,
user_id int UNIQUE FOREIGN KEY REFERENCES [User]
ON DELETE SET NULL
ON UPDATE CASCADE)

CREATE TABLE Employee
(employee_id int IDENTITY(1,1) PRIMARY KEY,
name varchar(64) NOT NULL,
last_name varchar(64) NOT NULL,
phone_number varchar(15) NOT NULL UNIQUE,
address varchar(256) NOT NULL,
passport_number varchar(32) NOT NULL UNIQUE,
user_id int UNIQUE FOREIGN KEY REFERENCES [User]
ON DELETE SET NULL
ON UPDATE CASCADE)

CREATE TABLE Status
(status_id int IDENTITY(1,1) PRIMARY KEY,
status varchar(32) NOT NULL UNIQUE)

CREATE TABLE [Order]
(order_id int IDENTITY(1,1) PRIMARY KEY,
datetime datetime DEFAULT GETDATE() NOT NULL,
user_id int FOREIGN KEY REFERENCES [User]
ON DELETE SET NULL
ON UPDATE CASCADE,
total_price decimal(8,2) NOT NULL,
is_payed bit DEFAULT 0 NOT NULL,
status_id int FOREIGN KEY REFERENCES Status
ON DELETE SET NULL
ON UPDATE CASCADE)

CREATE TABLE RecordType
(record_type_id int IDENTITY(1,1) PRIMARY KEY,
type varchar(32) NOT NULL UNIQUE)

CREATE TABLE Record
(record_id int IDENTITY(1,1) PRIMARY KEY,
title varchar(128) NOT NULL,
genre varchar(64),
interpreter varchar(128),
year smallint CHECK(year > 1800),
price decimal(8,2),
record_type_id int FOREIGN KEY REFERENCES RecordType
ON DELETE SET NULL
ON UPDATE CASCADE,
cuantity_available int DEFAULT 1 NOT NULL)

CREATE TABLE OrderRecord
(order_record_id int IDENTITY(1,1) PRIMARY KEY,
order_id int FOREIGN KEY REFERENCES [Order]
ON DELETE SET NULL
ON UPDATE CASCADE,
record_id int FOREIGN KEY REFERENCES Record
ON DELETE SET NULL
ON UPDATE CASCADE,
cuantity int DEFAULT 0)

CREATE TABLE Review
(review_id int IDENTITY(1,1) PRIMARY KEY,
order_id int UNIQUE FOREIGN KEY REFERENCES [Order]
ON DELETE SET NULL
ON UPDATE CASCADE,
text_review varchar(256) NOT NULL)
GO


