-- Create Banks Table
CREATE TABLE Banks (
    BankId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL
);

-- Create PaymentMethods Table
CREATE TABLE PaymentMethods (
    PaymentId INT PRIMARY KEY IDENTITY(1,1),
    Amount DECIMAL(18, 2) NOT NULL,
    Date DATETIME NOT NULL,
    BankId INT NOT NULL,
    PaymentType NVARCHAR(50) NOT NULL, -- Discriminator column
    CheckNumber NVARCHAR(100) NULL,
    AccountNumber NVARCHAR(100) NULL,
    CONSTRAINT FK_PaymentMethods_Banks FOREIGN KEY (BankId) REFERENCES Banks(BankId)
);


-- Insert a bank
INSERT INTO Banks (Name)
VALUES ('Sample Bank');

-- Insert a check payment
INSERT INTO PaymentMethods (Amount, Date, BankId, PaymentType, CheckNumber)
VALUES (150.00, '2024-08-05', 1, 'Check', 'CHK123456');

-- Insert a bank transfer payment
INSERT INTO PaymentMethods (Amount, Date, BankId, PaymentType, AccountNumber)
VALUES (200.00, '2024-08-05', 1, 'BankTransfer', 'ACC123456789');

