/*Use Drop table  when running multiple times to avoid getting error "Table is already created" */
Drop table Customer    cascade constraints;
Drop table Invoice    cascade constraints;
Drop table Employee    cascade constraints;
Drop table Chef    cascade constraints;
Drop table Meal    cascade constraints;
Drop table DeliveryBoy    cascade constraints;
Drop table  Orders    cascade constraints;
Drop table  Reservations    cascade constraints;
Drop table  Feedback    cascade constraints;
Create table Customer
(CustID number(10) primary key,FirstName VARCHAR2(15) NOT NULL ,LastName VARCHAR2(15) NOT NULL ,full_name VARCHAR2(31) /*GENERATED ALWAYS AS
   (FirstName || ' ' || LastName) VIRTUAL*/ ,VisaCard_Num number(30) NOT NULL , Address VARCHAR2(30), phone number(12) ); /*phone is multi valued*/

Create table Invoice
(invID number (10) primary key ,Cust References Customer(CustID),inv_time VARCHAR2(15),inv_cost float(10)) ; /* Cost = ... + ... */

Create table Employee
(empID number(10) primary key,empName VARCHAR2(20) not null,job_name VARCHAR2(20),SSN number (10) not null );

Create table Chef
(chefID number(10) primary key,chefName VARCHAR2(20) not null,salary number(30),phone number (12));/*phone is multi valued*/

Create table Meal
(mealID number(10),price float(20),meal_name VARCHAR2(20) not null,categor VARCHAR2(20) not null );

Create table DeliveryBoy
(boy_phone number (12) primary key, boyName VARCHAR2(20) not null, B_id number (6)) ;

Create table Orders
(Order_ID number(10) primary key,Cust References Customer(CustID),price float(10));

Create table Reservations
(Reservation_ID number(10) primary key,numOfPeople number(20),tableNum number(15), Cust_Name VARCHAR2(31),reserv_time VARCHAR2(15) );
Create table Feedback
(Feedback_ID number(10) primary key,rate float(5), Cust References Customer(CustID));


insert into Customer values 
(123,'john','Wick','john Wick',65654,'Mexico',8973);

insert into Customer values 
(135,'Will','Smith','Will Smith',67754,'Liverpool',8003);

select * from Customer;
/*=================================================================*/
insert into Invoice values 
(158,135,'8:15AM',100);

insert into Invoice values 
(168,123,'8:15PM',200);

select * from Invoice;

/*==========================================*/
insert into Employee values 
(205,'Jack','Manager',111555);

insert into Employee values 
(208,'Edward','Waiter',21555);

select * from Employee;
/*==========================================*/

insert into Chef values  
(750,'Oliver',5000,3214);
insert into Chef values  
(760,'George',6000,4214);

select * from Chef;
/*==========================================*/
insert into Meal values
(14,155,'chicken','Chickens');
insert into Meal values
(24,100,'Pasta Chips',' appetizers');

select * from Meal;
/*==========================================*/
insert into deliveryboy values 
(1256,'keven',11);
insert into deliveryboy values 
(1266,'Lee',12);
select * from deliveryboy;
/*==========================================*/

insert into Orders values 
(157,123,100.5);

insert into Orders values 
(277,135,200.10);
select * from Orders;
/*==========================================*/
insert into Reservations values
(855,11,135,'Hani','8AM');
insert into Reservations values
(922,15,123,'Samy','9AM');

select * from Reservations;
/*==========================================*/
INSERT into Feedback values 
(12,4.5,123) ;
INSERT into Feedback values 
(11,4.5,135) ;

select * from Feedback;

COMMIT;
