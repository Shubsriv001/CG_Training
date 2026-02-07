-- Question 1 – Normalization (Foundation)

-- You are given the following table used by a legacy application:

-- EmployeeSalesRaw
-- ----------------------------------------------------
-- EmpId
-- EmpName
-- Department
-- Email
-- SaleMonth
-- SaleYear
-- SaleAmount


-- Tasks:

-- Identify normalization issues in the above table.

-- Normalize the structure up to 3NF.

-- Create appropriate tables with:

-- Primary keys

-- Foreign key relationships

-- Tables should at least include: Employee, Department, Sales.

-- Question 2 – ALTER TABLE (Business Change Request)

-- After reviewing Question 1, the business says:

-- “We want to track employee performance points.”

-- Tasks:

-- Use ALTER TABLE to add a column called BonusPoints to the Employee table.

-- Set default value as 0.

-- ⚠️ This question depends on Question 1.

-- Question 3 – CHECK Constraint (Mid-Requirement Change)

-- Business rule update:

-- “Bonus points must always be between 0 and 100.”

-- Tasks:

-- Add a CHECK constraint on BonusPoints.

-- Ensure invalid values cannot be inserted or updated.

-- Question 4 – INNER JOIN (Mandatory)

-- Write a query to display:

-- Employee Name

-- Department Name

-- Sale Month

-- Sale Year

-- Sale Amount

-- Only include employees who have made at least one sale.

-- Use INNER JOIN only.

-- Question 5 – Date Function (Mandatory)

-- Write a query to calculate total sales for each employee for the current year.

-- Requirements:

-- Use SQL Server date functions

-- Do not hardcode the year

-- Question 6 – SUBSTRING and LEFT (Mandatory)

-- The business wants username suggestions.

-- Rule:

-- First 3 characters of employee name

-- First 2 characters of department name

-- Append employee ID

-- Example:

-- Marimuthu + IT + 101 → MarIT101


-- Tasks:

-- Generate the username using SUBSTRING and LEFT.

-- Display Employee Name and Generated Username.

-- Question 7 – Subquery (Mandatory)

-- Write a query to find employees whose total sales amount is greater than the average sales amount of all employees.

-- Rules:

-- Use a subquery

-- No joins in the outer query for calculation

-- Question 8 – UNION (Mandatory)

-- The business wants a consolidated report:

-- Employees who made sales above ₹50,000

-- Employees who made sales below ₹10,000

-- Tasks:

-- Write two separate SELECT queries.

-- Combine them using UNION.

-- Display: Employee Name, Sale Amount, Category (High / Low)

-- Question 9 – Trigger (Mandatory, Real-World Logic)

-- Business rule:

-- “Whenever a sale is inserted, automatically update BonusPoints.”

-- Rule:

-- If SaleAmount ≥ 50,000 → add 10 points

-- If SaleAmount ≥ 20,000 → add 5 points

-- Else → no bonus

-- Tasks:

-- Create an AFTER INSERT trigger on Sales table.

-- Ensure BonusPoints updates automatically.

-- Question 10 – Integrated Validation Query (Final)

-- Write a single query that shows:

-- Employee Name

-- Department

-- Total Sales

-- BonusPoints

-- Performance Grade

-- A → BonusPoints ≥ 50

-- B → BonusPoints between 20 and 49

-- C → Below 20

-- This question validates whether:

-- Normalization is correct

-- Trigger worked

-- Aggregations are correct



use college
---------------------------Emoployee Table-------------------------------------------------
create table EmployeeTable(Empid int primary key, EmpName nvarchar(30),Department nvarchar(10),Email nvarchar(30));

insert into EmployeeTable VALUES
(101, 'Amit Sharma',   'Sales', 'amit.sharma@company.com'),
(102, 'Neha Verma',    'Sales', 'neha.verma@company.com'),
(103, 'Rahul Mehta',   'Marketing', 'rahul.mehta@company.com'),
(104, 'Priya Singh',   'HR', 'priya.singh@company.com'),
(105, 'Karan Patel',   'Sales', 'karan.patel@company.com');


select * from EmployeeTable

----------------------Sale Table---------------------------------------------

create table SaleTable(EmpID int ,SaleMonth int, SaleYear int, Amount decimal(10,2)
foreign key(EmpId) references EmployeeTable(Empid));

insert into SaleTable (EmpID, SaleMonth, SaleYear, Amount) values
(101, 1, 2026, 45000.00),
(102, 1, 2025, 52000.00),
(103, 1, 2026, 38000.00),
(101, 2, 2026, 47000.00),
(102, 2, 2026, 56000.00),
(104, 2, 2026, 30000.00),
(103, 3, 2026, 41000.00),
(101, 3, 2026, 60000.00),
(105, 3, 2026, 49000.00);


select * from SaleTable

---------------------------------------------
--2nd Question

Alter table EmployeeTable add BonusPoints int default 0

select * from EmployeeTable

update EmployeeTable set BonusPoints = 0 where BonusPoints IS NULL;

--------------------------------------------------
--3rd Question

alter table EmployeeTable add constraint CheckBonusPoints check (BonusPoints BETWEEN 0 AND 100);

-------------------------------------------------
--4th question
select EmpName, Department from EmployeeTable inner join SaleTable on EmployeeTable.Empid=SaleTable.EmpID where SaleMonth>=1;

-------------------------------------------------
--5th Question
select EmployeeTable.Empid, EmployeeTable.EmpName, sum(SaleTable.Amount) as Totalsales
from EmployeeTable 
inner join SaleTable on EmployeeTable.Empid = SaleTable.EmpID
where SaleTable.SaleYear = year(getdate())
group by EmployeeTable.Empid, EmployeeTable.EmpName;

----------------------------------------------------------
--6th Question
select EmpName, substring(EmpName, 1, 3) + substring(Department, 1, 2) + cast(Empid as varchar(10)) as username from EmployeeTable;

------------------------------------------------

--7th Question
select EmpName from EmployeeTable where (select Avg(Amount) from SaleTable)< (select sum(Amount) from SaleTable);

--8th Question
select EmployeeTable.EmpName, SaleTable.Amount AS SaleAmount,
case 
when SaleTable.Amount > 50000 THEN 'High'
WHEN SaleTable.Amount < 10000 THEN 'Low'
END AS Category

from EmployeeTable inner join SaleTable on EmployeeTable.EmpId = SaleTable.EmpID;

-----------------------------------------------------------

--9th Question

create trigger trg_after_insert_sale
on Saletable
after insert
as
begin
update EmployeeTable
set BonusPoints = BonusPoints +
case
when i.Amount >= 50000 then 10
when i.Amount >= 20000 then 5
else 0
end

from EmployeeTable  inner join inserted i on EmployeeTable.Empid = i.empid;
end;

----------------------------------------------------------------
--10th Question

select EmployeeTable.EmpName, EmployeeTable.Department, sum(SaleTable.Amount) as Totalsales, EmployeeTable.BonusPoints,
case
when EmployeeTable.BonusPoints >= 50 then 'A'
when EmployeeTable.BonusPoints >= 20 then 'B'
else 'C'
end as Grade
from EmployeeTable inner join SaleTable on EmployeeTable.Empid = SaleTable.EmpID
group by
EmployeeTable.EmpName,
EmployeeTable.Department,
EmployeeTable.BonusPoints;

------------------------------------------------------------