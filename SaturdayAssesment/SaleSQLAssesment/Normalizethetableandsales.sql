use Sales

CREATE TABLE Sales_Raw

(

    OrderID INT,

    OrderDate VARCHAR(20),

    CustomerName VARCHAR(100),

    CustomerPhone VARCHAR(20),

    CustomerCity VARCHAR(50),

    ProductNames VARCHAR(200),   -- Multiple products comma-separated

    Quantities VARCHAR(100),     -- Multiple quantities comma-separated

    UnitPrices VARCHAR(100),     -- Multiple prices comma-separated

    SalesPerson VARCHAR(100)

);

INSERT INTO Sales_Raw VALUES

(101, '2024-01-05', 'Ravi Kumar', '9876543210', 'Chennai',

 'Laptop,Mouse', '1,2', '55000,500', 'Anitha'),

 
(102, '2024-01-06', 'Priya Sharma', '9123456789', 'Bangalore',

 'Keyboard,Mouse', '1,1', '1500,500', 'Anitha'),

(103, '2024-01-10', 'Ravi Kumar', '9876543210', 'Chennai',

 'Laptop', '1', '54000', 'Suresh'),

 (104, '2024-02-01', 'John Peter', '9988776655', 'Hyderabad',

 'Monitor,Mouse', '1,1', '12000,500', 'Anitha'),

 (105, '2024-02-10', 'Priya Sharma', '9123456789', 'Bangalore',

 'Laptop,Keyboard', '1,1', '56000,1500', 'Suresh');

select * from Sales_Raw


--------------------------------- ProductMaster Table-------------------------------------

create table ProductMaster1(Pid int Primary key,Pname nvarchar(50), Price int)

insert into productmaster1 values
(1, 'laptop', 55000),
(2, 'mouse', 500),
(3, 'keyboard', 1500),
(4, 'monitor', 12000);

select * from ProductMaster1;



-------------------------------------CustomerMaster Table------------------------------------------------
create table CustomerMaster3(id int Primary key,Customer_Name nvarchar(50),Phone_Number nvarchar(50), City nvarchar(50));

insert into customermaster3 (id, Customer_Name, Phone_Number, City)
values
(1, 'Ravi kumar', '9876543210', 'Chennai'),
(2, 'Priya sharma', '9845762570', 'Bangalore'),
(3, 'John peter', '1254789640', 'Bangalore');


select * from CustomerMaster3;


--------------------------------- SalesPersonMaster Table--------------------------------------------------------

create table SalePersonMaster(id int Primary key,SalePerson_Name nvarchar(50));

insert into SalePersonMaster values
(1,'Anitha'),
(2,'Suresh');

select * from SalePersonMaster;


----------------------------------------------- Orders Table---------------------------------------------------------

create table orders (orderid int,orderdate date,customerid int,pid int,quantity int,salepersonid int,
foreign key (customerid) references customermaster3(id),
foreign key (pid) references productmaster1(pid),
foreign key (salepersonid) references salepersonmaster(id)
);

insert into orders values
(101, '2024-01-05', 1, 1, 1, 1),
(101, '2024-01-05', 1, 2, 2, 1),
(102, '2024-01-06', 2, 3, 1, 1),
(102, '2024-01-06', 2, 2, 1, 1),
(103, '2024-01-10', 1, 1, 1, 2),
(104, '2024-02-01', 3, 4, 1, 1),
(104, '2024-02-01', 3, 2, 1, 1),
(105, '2024-02-10', 2, 1, 1, 2),
(105, '2024-02-10', 2, 3, 1, 2);

select  * from orders;

---------------------------------------------------------------------------------------------------------

--Question 2

create table #TotalPrice1 (total int);

insert into #TotalPrice1 (total) 
select ProductMaster1.Price * orders.quantity from ProductMaster1 inner join orders on ProductMaster1.Pid = orders.Pid;

select total from #TotalPrice1;

select * from #TotalPrice1 order by total desc
offset 2 rows fetch next 1 row only;

-------------------------------------------------------------------------------------
--Question 3

create table #TotalsaleAmount(salePerson nvarchar(50),Total int)

insert into #TotalSaleAmount (SalePerson, total) select SalePersonMaster.SalePerson_Name as SalePerson, sum(ProductMaster1.Price * orders.quantity) as total

from SalePersonMaster inner join orders on SalePersonMaster.id = orders.salepersonid inner join ProductMaster1 on ProductMaster1.Pid = orders.pid
group by SalePersonMaster.SalePerson_Name;

select * from #TotalSaleAmount;


select salePerson from #TotalsaleAmount where Total>60000;


select salePerson from #TotalsaleAmount order by Total desc
offset 0 rows fetch next 1 row only;

--------------------------------------------------------------------------------------------------------------

--Question 4

create table #mostSpentCustomer2(custName nvarchar(50), totalspent int);

insert into #mostSpentCustomer2(custName, totalspent)
select CustomerMaster3.Customer_Name as custName,sum(ProductMaster1.Price * orders.quantity) as totalspent
from CustomerMaster3 inner join orders on CustomerMaster3.id = orders.customerid inner join ProductMaster1 on ProductMaster1.Pid = orders.pid
group by CustomerMaster3.Customer_Name;


select custName from #mostSpentCustomer2 where totalspent>(select AVG(totalspent) from #mostSpentCustomer2) 

select * from #mostSpentCustomer2;





    