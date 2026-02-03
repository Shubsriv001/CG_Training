use TopBrains


-----------------Customer table--------------------------
CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    PhoneNumber VARCHAR(15),
    City VARCHAR(50),
    CreatedDate DATE
);


-----------------Customer table Data----------------------
INSERT INTO Customers VALUES
(1, 'Ravi Kumar', '9876543210', 'Chennai', '2023-01-10'),
(2, 'Priya Sharma', '9123456789', 'Bangalore', '2023-03-15'),
(3, 'John Peter', '9988776655', 'Hyderabad', '2023-06-20');

Select * from Customers;

----------------Account Table----------------------------
CREATE TABLE Accounts
(
    AccountID INT PRIMARY KEY,
    CustomerID INT,
    AccountNumber VARCHAR(20),
    AccountType VARCHAR(20), -- Savings / Current
    OpeningBalance DECIMAL(12,2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-----------------Account table data----------------------
INSERT INTO Accounts VALUES
(101, 1, 'SB1001', 'Savings', 20000),
(102, 2, 'SB1002', 'Savings', 15000),
(103, 3, 'SB1003', 'Savings', 30000);

Select * from Accounts;

------------------Transaction Table----------------------------

CREATE TABLE Transactions
(
    TransactionID INT PRIMARY KEY,
    AccountID INT,
    TransactionDate DATE,
    TransactionType VARCHAR(10), -- Deposit / Withdraw
    Amount DECIMAL(12,2),
    FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);

--------------Transaction tabel data--------------------

INSERT INTO Transactions VALUES
(1, 101, '2024-01-05', 'Deposit', 30000),
(2, 101, '2024-01-18', 'Withdraw', 5000),
(3, 101, '2024-02-10', 'Deposit', 25000),

(4, 102, '2024-01-07', 'Deposit', 20000),
(5, 102, '2024-01-25', 'Deposit', 35000),
(6, 102, '2024-02-05', 'Withdraw', 10000),

(7, 103, '2024-01-10', 'Deposit', 15000),
(8, 103, '2024-01-20', 'Withdraw', 5000);

Select * from Transactions;
----------------------------Bonus Table----------------

CREATE TABLE Bonus1 (
    BonusID INT IDENTITY(1,1) PRIMARY KEY, 
    AccountID INT,
    BonusMonth INT,
    BonusYear INT,
    BonusAmount DECIMAL(10,2),
    CreatedDate DATE,
    FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);



--------------------------------------------------------------------------------------------------
--1st Answer

create proc usp_displayamount
@startdate date,
@enddate date,
@accountid int
as
begin

create table #totalamount(deposit decimal(18,2),withdrawal decimal(18,2));
insert into #totalamount (deposit, withdrawal)
select sum(case when transactiontype = 'deposit' then amount else 0 end),sum(case when transactiontype = 'withdraw' then amount else 0 end) 
from transactions where accountid = @accountid and transactiondate between @startdate and @enddate;

select * from #totalamount;
end;

exec usp_displayamount
@startdate = '2024-01-05',
@enddate   = '2024-01-18',
@accountid = 101;

---------------------------------------------------------------------------------------------
--2nd Answer

create table #monthdeposit2(id int, name nvarchar(30), totaldeposit decimal(12,2));
insert into #monthdeposit2(id, name, totaldeposit)
select customers.customerid, customers.customername, sum(transactions.amount) 
from customers 
inner join accounts a on a.customerid = customers.customerid
inner join transactions  on transactions.accountid = a.accountid
where transactions.transactiontype = 'deposit' and transactions.transactiondate >= dateadd(month, -1, getdate())
group by customers.customerid, customers.customername;

select * from #monthdeposit2;

insert into Bonus1(AccountID, BonusYear, CreatedDate)
select accounts.accountid,  month(transactions.transactiondate) as BonusMonth, getdate() as CreatedDate
from transactions
inner join accounts on accounts.accountid = transactions.accountid
inner join #monthdeposit2 on #monthdeposit2.id = accounts.customerid 
where transactions.transactiontype = 'deposit';


select * from Bonus1;
-----------------------------------------------------------------------------------------------

--3rd Answer

create proc usp_userInformation1
as
begin
create table #userinfo (customername nvarchar(50), accountnumber nvarchar(50), currentbalance decimal(12,2));
insert into #userinfo (customername, accountnumber, currentbalance)
select customers.customername, accounts.accountnumber,
sum( case when transactions.transactiontype = 'deposit' then transactions.amount when transactions.transactiontype = 'withdraw' then -transactions.amount else 0 end ) as currentbalance

from customers inner join accounts on customers.customerid = accounts.customerid inner join transactions  on transactions.accountid = accounts.accountid
group by customers.customername,accounts.accountnumber;

select * from #userinfo
end

exec usp_userInformation1


