CREATE TABLE loan_payments
(
    Payment_ID INT PRIMARY KEY IDENTITY(1,1),

    Loan_ID INT,

    Paid_Amount INT,

    Payment_Date DATETIME,

    Remaining_After_Payment INT,

    Payment_Remarks VARCHAR(200),

    FOREIGN KEY (Loan_ID)
    REFERENCES loans(Loan_ID)
)