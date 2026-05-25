CREATE DATABASE BankDB;
GO

USE BankDB;
GO

-- Customers Table
CREATE TABLE customers (
customer_id INT PRIMARY KEY IDENTITY(1,1),
customer_name VARCHAR(100),
phone VARCHAR(20),
email VARCHAR(100),
address VARCHAR(200)
);

-- Employees Table
CREATE TABLE employees (
EID INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(100),
Position VARCHAR(50),
Salary DECIMAL(10,2)
);

-- Accounts Table
CREATE TABLE accounts (
Account_ID INT PRIMARY KEY IDENTITY(1,1),
Account_Type VARCHAR(50),
Balance DECIMAL(10,2),
Date_Opened DATE,
Customer_ID INT,
FOREIGN KEY (Customer_ID) REFERENCES customers(customer_id)
);

-- Loans Table
CREATE TABLE loans (
Loan_ID INT PRIMARY KEY IDENTITY(1,1),
Loan_Type VARCHAR(50),
Amount DECIMAL(10,2),
Interest_Rate DECIMAL(5,2),
Loan_Date DATE,
Customer_ID INT,
FOREIGN KEY (Customer_ID) REFERENCES customers(customer_id)
);

-- Transactions Table
CREATE TABLE transactions (
TID INT PRIMARY KEY IDENTITY(1,1),
Transaction_Type VARCHAR(50),
Amount DECIMAL(10,2),
Transaction_Date DATETIME,
Account_Id INT,
FOREIGN KEY (Account_Id) REFERENCES accounts(Account_ID)
);

-- Login Table
CREATE TABLE logintab (
id INT PRIMARY KEY IDENTITY(1,1),
username VARCHAR(50),
password VARCHAR(50)
);

-- Sample Login Data
INSERT INTO logintab (username, password)
VALUES ('admin', 'admin123');
