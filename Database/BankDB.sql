CREATE DATABASE BankDB;
GO

USE BankDB;
GO

-- Customers Table
CREATE TABLE customers (
customer_id INT PRIMARY KEY IDENTITY(1,1),
customer_name VARCHAR(100) NOT NULL,
phone VARCHAR(20) NOT NULL,
email VARCHAR(100) NOT NULL,
address VARCHAR(200) NOT NULL,
Status VARCHAR(20) DEFAULT 'Active'
);

-- Employees Table
CREATE TABLE employees (
EID INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(100),
Position VARCHAR(50),
Salary INT
);

-- Accounts Table
CREATE TABLE accounts (
Account_ID INT PRIMARY KEY IDENTITY(100,1),
Account_Type VARCHAR(50),
Balance INT,
Date_Opened DATETIME,
Customer_ID INT,
Account_Status VARCHAR(20) DEFAULT 'Active',
CONSTRAINT FK_accounts_customers
FOREIGN KEY (Customer_ID)
REFERENCES customers(customer_id)
);

-- Loans Table
CREATE TABLE loans (
Loan_ID INT PRIMARY KEY IDENTITY(1,1),
Loan_Type VARCHAR(50),
Amount INT,
Interest_Rate VARCHAR(20),
Loan_Date DATETIME,
Customer_ID INT,
Loan_Status VARCHAR(20) DEFAULT 'Active',
Remaining_Amount INT,
EMI INT,
Loan_Years INT,
Total_Payable INT,
CONSTRAINT FK_loans_customers
FOREIGN KEY (Customer_ID)
REFERENCES customers(customer_id)
);

-- Loan Payments Table
CREATE TABLE loan_payments (
Payment_ID INT PRIMARY KEY IDENTITY(1,1),
Loan_ID INT,
Paid_Amount INT,
Payment_Date DATETIME,
Remaining_After_Payment INT,
Payment_Remarks VARCHAR(200),
FOREIGN KEY (Loan_ID)
REFERENCES loans(Loan_ID)
);

-- Transactions Table
CREATE TABLE transactions (
TID INT PRIMARY KEY IDENTITY(1,1),
Transaction_Type VARCHAR(50) NOT NULL,
Amount INT NOT NULL,
Transaction_Date DATETIME NOT NULL,
Account_ID INT NOT NULL,
Balance_After_Transaction INT,
Transaction_Status VARCHAR(20) DEFAULT 'Success',
Remarks VARCHAR(200),
CONSTRAINT FK_transactions_accounts
FOREIGN KEY (Account_ID)
REFERENCES accounts(Account_ID)
);

-- Login Table
CREATE TABLE logintab (
id INT PRIMARY KEY IDENTITY(1,1),
username NCHAR(10),
password NCHAR(10)
);

-- Default Admin Login
INSERT INTO logintab (username, password)
VALUES ('admin', 'admin123');
