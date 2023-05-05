USE master

USE BD_GasStation

CREATE TABLE supplierdir
(
	sup_id int IDENTITY(1,1) NOT NULL,
	sup_name char(50),
	PRIMARY KEY(sup_id)
)
CREATE TABLE fuel
(
	fuel_id int IDENTITY(1,1) NOT NULL,
	fuel_name char(50),
	price DECIMAL(10,2),
	sup_id INT NOT NULL,
	FOREIGN KEY (sup_id) REFERENCES supplierdir(sup_id),
	PRIMARY KEY(fuel_id)
)
CREATE TABLE remains
(
	remain_id int IDENTITY(1,1) NOT NULL,
	fuel_id INT NOT NULL,
	FOREIGN KEY (fuel_id) REFERENCES fuel(fuel_id),
	remain_date date,
	vol_init DECIMAL(10,2),
	vol_sold DECIMAL(10,2),
	PRIMARY KEY(remain_id)
)

INSERT INTO supplierdir(sup_name) VALUES
('������'),
('��������'),
('�������')

INSERT INTO fuel(fuel_name,price,sup_id) VALUES
('95',39.95,2),
('������',42.90,1),
('92',49.20,2),
('98',61.5,3)

INSERT INTO remains(fuel_id,remain_date,vol_init,vol_sold) VALUES
(1,'16-09-2016',50000,20000),
(2,'05-01-2017',45000,15000),
(3,'21-04-2049',60000,30000),
(4,'09-03-2077',20000,5000),
(2,'01-01-2001',30000,12000)
