CREATE ROLE db_Sales AUTHORIZATION db_securityadmin;
GO;
GRANT SELECT ON [dbo].[Orders]
TO [db_Sales];
GRANT SELECT ON [dbo].[customers]
TO [db_Sales];
Use Northwind;
CREATE USER User_Sales 
WITHOUT LOGIN  
GO   
ALTER ROLE db_Sales ADD MEMBER User_Sales;
CREATE LOGIN [User_Sales] WITH PASSWORD = '<User_Sales>';



CREATE ROLE db_CEO AUTHORIZATION db_securityadmin;
GO;
GRANT SELECT ON [dbo].[Orders]
TO [db_CEO];
GRANT SELECT ON [dbo].[customers]
TO [db_CEO];
GRANT SELECT ON [dbo].[employees]
TO [db_CEO];
Use Northwind;
CREATE USER User_CEO 
WITHOUT LOGIN  
GO   
ALTER ROLE db_CEO ADD MEMBER User_CEO;

CREATE LOGIN [User_CEO] WITH PASSWORD = '<User_CEO>';



CREATE ROLE db_HR AUTHORIZATION db_securityadmin;
GO;
GRANT SELECT ON [dbo].[employee]
TO [db_HR];
Use Northwind;
CREATE USER User_HR 
WITHOUT LOGIN  
GO   
ALTER ROLE db_HR ADD MEMBER User_HR;
CREATE LOGIN [User_HR] WITH PASSWORD = '<User_HR>';
