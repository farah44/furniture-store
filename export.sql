--------------------------------------------------------
--  File created - Wednesday-April-15-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence ACTID
--------------------------------------------------------

   CREATE SEQUENCE  "ACTID"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence CUSTOMERID
--------------------------------------------------------

   CREATE SEQUENCE  "CUSTOMERID"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence IKEA
--------------------------------------------------------

   CREATE SEQUENCE  "IKEA"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence PRODUCTID
--------------------------------------------------------

   CREATE SEQUENCE  "PRODUCTID"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table ACTORS
--------------------------------------------------------

  CREATE TABLE "ACTORS" 
   (	"ACTORID" NUMBER(10,0), 
	"ACTORNAME" VARCHAR2(20), 
	"GENDER" VARCHAR2(1)
   ) ;
--------------------------------------------------------
--  DDL for Table BONUS
--------------------------------------------------------

  CREATE TABLE "BONUS" 
   (	"ENAME" VARCHAR2(10), 
	"JOB" VARCHAR2(9), 
	"SAL" NUMBER, 
	"COMM" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table CUSTOMER
--------------------------------------------------------

  CREATE TABLE "CUSTOMER" 
   (	"CUSTOMERID" NUMBER(5,0), 
	"SEX" VARCHAR2(1), 
	"BIRTHDATE" DATE, 
	"LASTNAME" VARCHAR2(20), 
	"FIRSTNAME" VARCHAR2(20), 
	"CITY" VARCHAR2(20), 
	"STREET" VARCHAR2(20), 
	"FLAT" NUMBER(5,0), 
	"ORDER_CURRENT_LOC" VARCHAR2(20), 
	"MAKE_CUSTOMERID" NUMBER(5,0), 
	"MAKE_ORDERID" NUMBER(5,0), 
	"TRACK_CUSTOMERID" NUMBER(5,0), 
	"TRACK_ORDERID" NUMBER(5,0)
   ) ;
--------------------------------------------------------
--  DDL for Table C_PHONENUMBER
--------------------------------------------------------

  CREATE TABLE "C_PHONENUMBER" 
   (	"CUSTOMERID" NUMBER(5,0), 
	"CUSTOMERPHONENUMBER" NUMBER(12,0)
   ) ;
--------------------------------------------------------
--  DDL for Table DEPT
--------------------------------------------------------

  CREATE TABLE "DEPT" 
   (	"DEPTNO" NUMBER(2,0), 
	"DNAME" VARCHAR2(14), 
	"LOC" VARCHAR2(13)
   ) ;
--------------------------------------------------------
--  DDL for Table EMP
--------------------------------------------------------

  CREATE TABLE "EMP" 
   (	"EMPNO" NUMBER(4,0), 
	"ENAME" VARCHAR2(10), 
	"JOB" VARCHAR2(9), 
	"MGR" NUMBER(4,0), 
	"HIREDATE" DATE, 
	"SAL" NUMBER(7,2), 
	"COMM" NUMBER(7,2), 
	"DEPTNO" NUMBER(2,0)
   ) ;
--------------------------------------------------------
--  DDL for Table EMPLOYEE
--------------------------------------------------------

  CREATE TABLE "EMPLOYEE" 
   (	"EMPLOYEEID" NUMBER(5,0), 
	"EMPLOYEENAME" VARCHAR2(20), 
	"SUPERVISOR_ID" NUMBER(5,0)
   ) ;
--------------------------------------------------------
--  DDL for Table FILMACTORS
--------------------------------------------------------

  CREATE TABLE "FILMACTORS" 
   (	"FILMID" NUMBER(10,0), 
	"ACTORID" NUMBER(10,0)
   ) ;
--------------------------------------------------------
--  DDL for Table FILMCATEGORY
--------------------------------------------------------

  CREATE TABLE "FILMCATEGORY" 
   (	"CATEGORYID" NUMBER(3,0), 
	"CATEGORYNAME" VARCHAR2(20)
   ) ;
--------------------------------------------------------
--  DDL for Table FILMCOPIES
--------------------------------------------------------

  CREATE TABLE "FILMCOPIES" 
   (	"COPYID" NUMBER(5,0), 
	"FILMID" NUMBER(10,0), 
	"CURRENTLYRENTED" CHAR(1)
   ) ;
--------------------------------------------------------
--  DDL for Table FILMTITLES
--------------------------------------------------------

  CREATE TABLE "FILMTITLES" 
   (	"FILMID" NUMBER(10,0), 
	"FILMTITLE" VARCHAR2(50), 
	"RELEASEDATE" DATE, 
	"FILMDURATION" NUMBER(3,0), 
	"FILMCATEGORYID" NUMBER(3,0)
   ) ;
--------------------------------------------------------
--  DDL for Table GIVEREVIEW
--------------------------------------------------------

  CREATE TABLE "GIVEREVIEW" 
   (	"CUSTOMERID" NUMBER(5,0), 
	"PRODUCTID" NUMBER(5,0), 
	"NUMBEROFSTARS" NUMBER(5,0)
   ) ;
--------------------------------------------------------
--  DDL for Table MANAGEE_C
--------------------------------------------------------

  CREATE TABLE "MANAGEE_C" 
   (	"EMPLOYEEID" NUMBER(5,0), 
	"CUSTOMERID" NUMBER(5,0)
   ) ;
--------------------------------------------------------
--  DDL for Table MANAGEP_C
--------------------------------------------------------

  CREATE TABLE "MANAGEP_C" 
   (	"EMPLOYEEID" NUMBER(5,0), 
	"PRODUCTID" NUMBER(5,0)
   ) ;
--------------------------------------------------------
--  DDL for Table MANAGEP_E
--------------------------------------------------------

  CREATE TABLE "MANAGEP_E" 
   (	"EMPLOYEEID" NUMBER(5,0), 
	"PRODUCTID" NUMBER(5,0)
   ) ;
--------------------------------------------------------
--  DDL for Table MCOLOR
--------------------------------------------------------

  CREATE TABLE "MCOLOR" 
   (	"MODELNUMBER" NUMBER(10,0), 
	"MODELCOLOR" VARCHAR2(30)
   ) ;
--------------------------------------------------------
--  DDL for Table MEMBERS
--------------------------------------------------------

  CREATE TABLE "MEMBERS" 
   (	"MEMBERID" NUMBER(10,0), 
	"MEMNAME" VARCHAR2(20), 
	"JOINDATE" DATE, 
	"DOB" DATE, 
	"PHONE" NUMBER(12,0)
   ) ;
--------------------------------------------------------
--  DDL for Table MODEL
--------------------------------------------------------

  CREATE TABLE "MODEL" 
   (	"MODELNUMBER" NUMBER(10,0), 
	"MATERIAL" VARCHAR2(200), 
	"STYLE" VARCHAR2(100), 
	"TYPE" VARCHAR2(25), 
	"CATEGORY" VARCHAR2(25)
   ) ;
--------------------------------------------------------
--  DDL for Table MODELP
--------------------------------------------------------

  CREATE TABLE "MODELP" 
   (	"MODELNUMBER" NUMBER(10,0), 
	"MATERIAL" VARCHAR2(50), 
	"STYLE" VARCHAR2(50)
   ) ;
--------------------------------------------------------
--  DDL for Table MODEL_P
--------------------------------------------------------

  CREATE TABLE "MODEL_P" 
   (	"MODELNUMBER" NUMBER(5,0), 
	"MATERIAL" VARCHAR2(50), 
	"STYLEE" VARCHAR2(50)
   ) ;
--------------------------------------------------------
--  DDL for Table ORDERR
--------------------------------------------------------

  CREATE TABLE "ORDERR" 
   (	"ORDERID" NUMBER(5,0), 
	"STATUS" VARCHAR2(20), 
	"ORDER_COST" NUMBER(10,0), 
	"CUSTOMERID" NUMBER(5,0)
   ) ;
--------------------------------------------------------
--  DDL for Table PRODUCT
--------------------------------------------------------

  CREATE TABLE "PRODUCT" 
   (	"PRODUCTID" NUMBER(5,0), 
	"PRODUCTNAME" VARCHAR2(60), 
	"MODELNUMBER" NUMBER(10,0), 
	"PRODUCT_COST" NUMBER(10,0)
   ) ;
--------------------------------------------------------
--  DDL for Table RENTALS
--------------------------------------------------------

  CREATE TABLE "RENTALS" 
   (	"RENTID" NUMBER(10,0), 
	"MEMBERID" NUMBER(10,0), 
	"COPYID" NUMBER(5,0), 
	"DATERENTED" DATE, 
	"DATEDUEBACK" DATE, 
	"RENTALCOST" NUMBER(5,0), 
	"OVERDUECOST" NUMBER(5,0), 
	"RETURNEDDATE" DATE
   ) ;
--------------------------------------------------------
--  DDL for Table SALGRADE
--------------------------------------------------------

  CREATE TABLE "SALGRADE" 
   (	"GRADE" NUMBER, 
	"LOSAL" NUMBER, 
	"HISAL" NUMBER
   ) ;
--------------------------------------------------------
--  DDL for Table SUPPLIER
--------------------------------------------------------

  CREATE TABLE "SUPPLIER" 
   (	"SUPPLIERID" NUMBER(5,0), 
	"SUPPLYNAME" VARCHAR2(50)
   ) ;
--------------------------------------------------------
--  DDL for Table SUPPLY
--------------------------------------------------------

  CREATE TABLE "SUPPLY" 
   (	"SUPPLIERID" NUMBER(5,0), 
	"PRODUCTID" NUMBER(5,0), 
	"COST_" NUMBER(10,0)
   ) ;
--------------------------------------------------------
--  DDL for Table VIEWW
--------------------------------------------------------

  CREATE TABLE "VIEWW" 
   (	"CUSTOMERID" NUMBER(5,0), 
	"PRODUCTID" NUMBER(5,0)
   ) ;

---------------------------------------------------
--   DATA FOR TABLE ACTORS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into ACTORS
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (1,'Kristen Stewart','F');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (2,'Robert Pattinson','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (3,'Taylor Lautner','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (4,'Rupert Grint','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (5,'Daniel Radcliffe','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (6,'Ralph Fiennes','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (7,'Hank Azaria','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (8,'Neil Patrick Harris','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (9,'Jayma Mays','F');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (10,'Sofia Vergara','F');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (11,'John Cleese','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (12,'Jim Cummings','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (13,'Bud Luckey','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (14,'Tom Hanks','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (15,'Tim Allen','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (16,'Joan Cusack','F');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (17,'Mike Myers','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (18,'Eddie Murphy','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (19,'Cameron Diaz','F');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (20,'Kevin James','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (21,'Salma Hayek','F');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (22,'Henry Winkler','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (23,'Matthew McConaughey','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (24,'Anne Hathaway','F');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (25,'Jessica Chastain','F');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (26,'Sandra Bullock','F');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (27,'George Clooney','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (28,'Will Smith','M');
Insert into ACTORS (ACTORID,ACTORNAME,GENDER) values (29,'Tommy Lee Jones','M');

---------------------------------------------------
--   END DATA FOR TABLE ACTORS
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE BONUS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into BONUS

---------------------------------------------------
--   END DATA FOR TABLE BONUS
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE CUSTOMER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CUSTOMER
Insert into CUSTOMER (CUSTOMERID,SEX,BIRTHDATE,LASTNAME,FIRSTNAME,CITY,STREET,FLAT,ORDER_CURRENT_LOC,MAKE_CUSTOMERID,MAKE_ORDERID,TRACK_CUSTOMERID,TRACK_ORDERID) values (1,'F',to_timestamp('16-NOV-00 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),'Hany','Farida','Cairo','5th Settlement',10,null,1,8,1,8);
Insert into CUSTOMER (CUSTOMERID,SEX,BIRTHDATE,LASTNAME,FIRSTNAME,CITY,STREET,FLAT,ORDER_CURRENT_LOC,MAKE_CUSTOMERID,MAKE_ORDERID,TRACK_CUSTOMERID,TRACK_ORDERID) values (2,'M',to_timestamp('04-DEC-97 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),'Youssef','Mohammed','Giza','ElHaram',5,null,2,6,2,6);
Insert into CUSTOMER (CUSTOMERID,SEX,BIRTHDATE,LASTNAME,FIRSTNAME,CITY,STREET,FLAT,ORDER_CURRENT_LOC,MAKE_CUSTOMERID,MAKE_ORDERID,TRACK_CUSTOMERID,TRACK_ORDERID) values (3,'F',to_timestamp('01-AUG-99 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),'Tarek','Ayah','Cairo','Nasr City',8,'nasrcity',3,7,3,7);
Insert into CUSTOMER (CUSTOMERID,SEX,BIRTHDATE,LASTNAME,FIRSTNAME,CITY,STREET,FLAT,ORDER_CURRENT_LOC,MAKE_CUSTOMERID,MAKE_ORDERID,TRACK_CUSTOMERID,TRACK_ORDERID) values (4,'F',to_timestamp('04-AUG-98 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),'Hatem','Ashrakat','Cairo','1st settlement',4,'New Cairo',4,10,4,10);
Insert into CUSTOMER (CUSTOMERID,SEX,BIRTHDATE,LASTNAME,FIRSTNAME,CITY,STREET,FLAT,ORDER_CURRENT_LOC,MAKE_CUSTOMERID,MAKE_ORDERID,TRACK_CUSTOMERID,TRACK_ORDERID) values (5,'F',to_timestamp('18-AUG-98 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),'Ayman','Asmaa','Cairo','Elwahaa',7,'new cairo',5,1,5,1);
Insert into CUSTOMER (CUSTOMERID,SEX,BIRTHDATE,LASTNAME,FIRSTNAME,CITY,STREET,FLAT,ORDER_CURRENT_LOC,MAKE_CUSTOMERID,MAKE_ORDERID,TRACK_CUSTOMERID,TRACK_ORDERID) values (6,'F',to_timestamp('14-OCT-99 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),'Mohamed','Farah','Cairo','Nasr City',9,'maadi',6,9,6,9);
Insert into CUSTOMER (CUSTOMERID,SEX,BIRTHDATE,LASTNAME,FIRSTNAME,CITY,STREET,FLAT,ORDER_CURRENT_LOC,MAKE_CUSTOMERID,MAKE_ORDERID,TRACK_CUSTOMERID,TRACK_ORDERID) values (7,'F',to_timestamp('17-NOV-98 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),'Hamed','Nesreen','Cairo','Hegaz',5,'masr l gdeda',7,5,7,5);
Insert into CUSTOMER (CUSTOMERID,SEX,BIRTHDATE,LASTNAME,FIRSTNAME,CITY,STREET,FLAT,ORDER_CURRENT_LOC,MAKE_CUSTOMERID,MAKE_ORDERID,TRACK_CUSTOMERID,TRACK_ORDERID) values (8,'F',to_timestamp('21-OCT-98 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),'Ahmed','Enjy','Cairo','Masr Gdyda',12,null,8,4,8,4);
Insert into CUSTOMER (CUSTOMERID,SEX,BIRTHDATE,LASTNAME,FIRSTNAME,CITY,STREET,FLAT,ORDER_CURRENT_LOC,MAKE_CUSTOMERID,MAKE_ORDERID,TRACK_CUSTOMERID,TRACK_ORDERID) values (9,'M',to_timestamp('23-FEB-01 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),'Ahmed','Adel','Alex','Mahrosa',6,null,9,2,9,2);
Insert into CUSTOMER (CUSTOMERID,SEX,BIRTHDATE,LASTNAME,FIRSTNAME,CITY,STREET,FLAT,ORDER_CURRENT_LOC,MAKE_CUSTOMERID,MAKE_ORDERID,TRACK_CUSTOMERID,TRACK_ORDERID) values (10,'M',to_timestamp('05-JAN-96 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),'Karim','Omar','Cairo','Maadi',77,'mohndseen',10,3,10,3);

---------------------------------------------------
--   END DATA FOR TABLE CUSTOMER
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE C_PHONENUMBER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into C_PHONENUMBER
Insert into C_PHONENUMBER (CUSTOMERID,CUSTOMERPHONENUMBER) values (1,1223898199);
Insert into C_PHONENUMBER (CUSTOMERID,CUSTOMERPHONENUMBER) values (2,1555584803);
Insert into C_PHONENUMBER (CUSTOMERID,CUSTOMERPHONENUMBER) values (3,1009990903);
Insert into C_PHONENUMBER (CUSTOMERID,CUSTOMERPHONENUMBER) values (4,1115599710);
Insert into C_PHONENUMBER (CUSTOMERID,CUSTOMERPHONENUMBER) values (5,1228796300);
Insert into C_PHONENUMBER (CUSTOMERID,CUSTOMERPHONENUMBER) values (6,1060180302);
Insert into C_PHONENUMBER (CUSTOMERID,CUSTOMERPHONENUMBER) values (7,1556829301);
Insert into C_PHONENUMBER (CUSTOMERID,CUSTOMERPHONENUMBER) values (8,1224698710);
Insert into C_PHONENUMBER (CUSTOMERID,CUSTOMERPHONENUMBER) values (9,1122336690);
Insert into C_PHONENUMBER (CUSTOMERID,CUSTOMERPHONENUMBER) values (10,1005478960);

---------------------------------------------------
--   END DATA FOR TABLE C_PHONENUMBER
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE DEPT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into DEPT
Insert into DEPT (DEPTNO,DNAME,LOC) values (10,'ACCOUNTING','NEW YORK');
Insert into DEPT (DEPTNO,DNAME,LOC) values (20,'RESEARCH','DALLAS');
Insert into DEPT (DEPTNO,DNAME,LOC) values (30,'SALES','CHICAGO');
Insert into DEPT (DEPTNO,DNAME,LOC) values (40,'OPERATIONS','BOSTON');

---------------------------------------------------
--   END DATA FOR TABLE DEPT
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE EMP
--   FILTER = none used
---------------------------------------------------
REM INSERTING into EMP
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7369,'SMITH','CLERK',7902,to_timestamp('17-DEC-80 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),800,null,20);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7499,'ALLEN','SALESMAN',7698,to_timestamp('20-FEB-81 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),1600,300,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7521,'WARD','SALESMAN',7698,to_timestamp('22-FEB-81 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),1250,500,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7566,'JONES','MANAGER',7839,to_timestamp('02-APR-81 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),2975,null,20);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7654,'MARTIN','SALESMAN',7698,to_timestamp('28-SEP-81 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),1250,1400,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7698,'BLAKE','MANAGER',7839,to_timestamp('01-MAY-81 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),2850,null,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7782,'CLARK','MANAGER',7839,to_timestamp('09-JUN-81 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),2450,null,10);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7788,'SCOTT','ANALYST',7566,to_timestamp('19-APR-87 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),3000,null,20);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7839,'KING','PRESIDENT',null,to_timestamp('17-NOV-81 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),5000,null,10);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7844,'TURNER','SALESMAN',7698,to_timestamp('08-SEP-81 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),1500,0,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7876,'ADAMS','CLERK',7788,to_timestamp('23-MAY-87 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),1100,null,20);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7900,'JAMES','CLERK',7698,to_timestamp('03-DEC-81 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),950,null,30);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7902,'FORD','ANALYST',7566,to_timestamp('03-DEC-81 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),3000,null,20);
Insert into EMP (EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO) values (7934,'MILLER','CLERK',7782,to_timestamp('23-JAN-82 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),1300,null,10);

---------------------------------------------------
--   END DATA FOR TABLE EMP
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE EMPLOYEE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into EMPLOYEE
Insert into EMPLOYEE (EMPLOYEEID,EMPLOYEENAME,SUPERVISOR_ID) values (1,' Ahmed',5);
Insert into EMPLOYEE (EMPLOYEEID,EMPLOYEENAME,SUPERVISOR_ID) values (2,' Essam Mohamed ',4);
Insert into EMPLOYEE (EMPLOYEEID,EMPLOYEENAME,SUPERVISOR_ID) values (3,' Tarek Ahmed',5);
Insert into EMPLOYEE (EMPLOYEEID,EMPLOYEENAME,SUPERVISOR_ID) values (4,'Youssef ',1);
Insert into EMPLOYEE (EMPLOYEEID,EMPLOYEENAME,SUPERVISOR_ID) values (5,' Amin ',2);

---------------------------------------------------
--   END DATA FOR TABLE EMPLOYEE
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE FILMACTORS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into FILMACTORS
Insert into FILMACTORS (FILMID,ACTORID) values (1,1);
Insert into FILMACTORS (FILMID,ACTORID) values (1,2);
Insert into FILMACTORS (FILMID,ACTORID) values (1,3);
Insert into FILMACTORS (FILMID,ACTORID) values (2,4);
Insert into FILMACTORS (FILMID,ACTORID) values (2,5);
Insert into FILMACTORS (FILMID,ACTORID) values (2,6);
Insert into FILMACTORS (FILMID,ACTORID) values (3,7);
Insert into FILMACTORS (FILMID,ACTORID) values (3,8);
Insert into FILMACTORS (FILMID,ACTORID) values (3,9);
Insert into FILMACTORS (FILMID,ACTORID) values (3,10);
Insert into FILMACTORS (FILMID,ACTORID) values (4,11);
Insert into FILMACTORS (FILMID,ACTORID) values (4,12);
Insert into FILMACTORS (FILMID,ACTORID) values (4,13);
Insert into FILMACTORS (FILMID,ACTORID) values (5,1);
Insert into FILMACTORS (FILMID,ACTORID) values (5,2);
Insert into FILMACTORS (FILMID,ACTORID) values (5,3);
Insert into FILMACTORS (FILMID,ACTORID) values (6,14);
Insert into FILMACTORS (FILMID,ACTORID) values (6,15);
Insert into FILMACTORS (FILMID,ACTORID) values (6,16);
Insert into FILMACTORS (FILMID,ACTORID) values (7,17);
Insert into FILMACTORS (FILMID,ACTORID) values (7,18);
Insert into FILMACTORS (FILMID,ACTORID) values (7,19);
Insert into FILMACTORS (FILMID,ACTORID) values (8,20);
Insert into FILMACTORS (FILMID,ACTORID) values (8,21);
Insert into FILMACTORS (FILMID,ACTORID) values (8,22);
Insert into FILMACTORS (FILMID,ACTORID) values (9,23);
Insert into FILMACTORS (FILMID,ACTORID) values (9,24);
Insert into FILMACTORS (FILMID,ACTORID) values (9,25);
Insert into FILMACTORS (FILMID,ACTORID) values (10,26);
Insert into FILMACTORS (FILMID,ACTORID) values (10,27);
Insert into FILMACTORS (FILMID,ACTORID) values (11,26);
Insert into FILMACTORS (FILMID,ACTORID) values (12,27);
Insert into FILMACTORS (FILMID,ACTORID) values (12,28);

---------------------------------------------------
--   END DATA FOR TABLE FILMACTORS
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE FILMCATEGORY
--   FILTER = none used
---------------------------------------------------
REM INSERTING into FILMCATEGORY
Insert into FILMCATEGORY (CATEGORYID,CATEGORYNAME) values (1,'Adventure');
Insert into FILMCATEGORY (CATEGORYID,CATEGORYNAME) values (2,'Comedy');
Insert into FILMCATEGORY (CATEGORYID,CATEGORYNAME) values (3,'Action');
Insert into FILMCATEGORY (CATEGORYID,CATEGORYNAME) values (4,'Animation');
Insert into FILMCATEGORY (CATEGORYID,CATEGORYNAME) values (5,'Fantasy');
Insert into FILMCATEGORY (CATEGORYID,CATEGORYNAME) values (6,'Sci-Fi');

---------------------------------------------------
--   END DATA FOR TABLE FILMCATEGORY
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE FILMCOPIES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into FILMCOPIES

---------------------------------------------------
--   END DATA FOR TABLE FILMCOPIES
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE FILMTITLES
--   FILTER = none used
---------------------------------------------------
REM INSERTING into FILMTITLES
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (1,'The Twilight Saga Breaking Dawn',to_timestamp('16-NOV-12 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),116,1);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (2,'Harry Potter and the Deathly Hallows',to_timestamp('15-JUL-11 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),130,5);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (3,'The Smurfs',to_timestamp('29-JUL-11 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),103,4);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (4,'Winnie the Pooh',to_timestamp('15-JUL-11 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),63,4);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (5,'The Twilight Saga: Eclipse',to_timestamp('30-JUN-10 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),124,1);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (6,'Toy Story 3',to_timestamp('18-JUN-10 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),103,4);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (7,'Shrek Forever After',to_timestamp('21-MAY-10 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),93,4);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (8,'Here Comes the Boom',to_timestamp('12-OCT-12 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),105,2);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (9,'Interstellar',to_timestamp('07-NOV-14 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),169,6);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (10,'Gravity',to_timestamp('04-OCT-13 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),90,6);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (11,'Miss Congeniality',to_timestamp('22-DEC-02 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),109,2);
Insert into FILMTITLES (FILMID,FILMTITLE,RELEASEDATE,FILMDURATION,FILMCATEGORYID) values (12,'Men in Black 3',to_timestamp('25-MAY-12 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),107,3);

---------------------------------------------------
--   END DATA FOR TABLE FILMTITLES
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE GIVEREVIEW
--   FILTER = none used
---------------------------------------------------
REM INSERTING into GIVEREVIEW
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (1,1,3);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (1,2,4);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (2,3,5);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (2,4,5);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (3,5,2);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (3,6,4);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (4,7,4);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (4,8,3);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (5,9,1);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (5,10,4);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (6,11,4);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (6,12,1);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (7,13,2);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (7,14,4);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (8,15,5);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (8,16,5);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (9,17,3);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (9,18,1);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (10,19,2);
Insert into GIVEREVIEW (CUSTOMERID,PRODUCTID,NUMBEROFSTARS) values (10,20,4);

---------------------------------------------------
--   END DATA FOR TABLE GIVEREVIEW
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE MANAGEE_C
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MANAGEE_C
Insert into MANAGEE_C (EMPLOYEEID,CUSTOMERID) values (1,2);
Insert into MANAGEE_C (EMPLOYEEID,CUSTOMERID) values (1,10);
Insert into MANAGEE_C (EMPLOYEEID,CUSTOMERID) values (2,7);
Insert into MANAGEE_C (EMPLOYEEID,CUSTOMERID) values (2,9);
Insert into MANAGEE_C (EMPLOYEEID,CUSTOMERID) values (3,1);
Insert into MANAGEE_C (EMPLOYEEID,CUSTOMERID) values (3,3);
Insert into MANAGEE_C (EMPLOYEEID,CUSTOMERID) values (4,5);
Insert into MANAGEE_C (EMPLOYEEID,CUSTOMERID) values (4,6);
Insert into MANAGEE_C (EMPLOYEEID,CUSTOMERID) values (5,4);
Insert into MANAGEE_C (EMPLOYEEID,CUSTOMERID) values (5,8);

---------------------------------------------------
--   END DATA FOR TABLE MANAGEE_C
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE MANAGEP_C
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MANAGEP_C

---------------------------------------------------
--   END DATA FOR TABLE MANAGEP_C
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE MANAGEP_E
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MANAGEP_E
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (1,11);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (1,13);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (1,15);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (2,10);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (2,12);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (2,14);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (3,5);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (3,7);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (3,9);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (4,4);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (4,6);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (4,8);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (5,1);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (5,2);
Insert into MANAGEP_E (EMPLOYEEID,PRODUCTID) values (5,3);

---------------------------------------------------
--   END DATA FOR TABLE MANAGEP_E
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE MCOLOR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MCOLOR
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (123,'Hyllie beige');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (234,'Black/beige');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (345,'White');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (456,'Black');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (567,'Silver/White');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (678,'Dark Blue');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (789,'Brown');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (910,'Grey');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (1011,'Multicolored');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (1112,'Dark greyed');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (1213,'White/Rose');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (1314,'Beige');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (1415,'Blue');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (1516,'Dark grey');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (1617,'White/Blue');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (1718,'white stained oak effect');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (1819,'Beige/Dark grey');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (1920,'Light grey');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (2021,'White/grey');
Insert into MCOLOR (MODELNUMBER,MODELCOLOR) values (8910,'Silver');

---------------------------------------------------
--   END DATA FOR TABLE MCOLOR
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE MEMBERS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MEMBERS

---------------------------------------------------
--   END DATA FOR TABLE MEMBERS
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE MODEL
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MODEL
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (123,' Fabric : 100%polyester , Frame : solid wood ',' Corner sofa ','American','Living');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (234,' Fabric : 100%cotton , Frame : solid wood ,Plywood, Polyurethane foam  ',' Wing chair','Classic','Living');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (345,' Bed Frame : Stain, Clear acrylic lacquer, Printed acrylic paint, ABS plastic, Paper ,Bed base: Beech plywood, Birch plywood ','Bed Frame with 2 storage boxes','Modern','Room');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (456,'Cover : Stainless steel ,Base holder: ABS plastic , Shade : Glass  ',' LED wall lamp','American','Toilet');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (567,'Mirror : Glass  , Bracket : Stainless steel, Junction box: ABS plastic , Optical lens: Polycarbonate plastic ',' Mirror with integrated lighting','Classic','Room');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (678,'Kitchen cabinet: Particleboard, Melamine foil, ABS plastic ','medium-size kitchen with a free-standing hob and spacious storage','Modern','Kitchen');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (789,'Wood oil, Linseed oil, Drying agent ',' Wood treatment oil','Pharaonic','Kitchen');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (8910,'Basematerial : Aluminium, Anodized ,Shade/ Base cover : Polypropylene plastic,Cover : ABS plastic ',' LED solar-powered lighting','American','Living');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (910,'Outer fabric : 100% polyester,Inner fabric : Non-woven polypropylene ,Filling : Expanded polystyrene plastic beads ',' Beanbag, in/outdoor','Modern','Garden');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (1011,'User surface : 100% polyester (min. 90% recycled),Backing : Synthetic rubber ','Door mat','Classic','Garden');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (1112,'Bottom panel/ Top panel/ Side panel/ Fixed shelf : Particleboard, Foil,  Leg : Fibreboard, Foil, ABS plastic ','TV bench','Modern','Living');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (1213,'Top panel/ Bottom panel/ Shelf : Particleboard, Acrylic paint, Plastic edging, Acrylic paint,Plinth : Particleboard, Acrylic paint','Open wardrobe','Pharaonic','Room');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (1314,'Basematerial : Particleboard, Foil, Back : Fibreboard, Printed acrylic paint, Glass door frame : Fibreboard, Foil, ABS plastic, Panels : Tempered glass ','Bookcase with glass-doors','Classic','Living');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (1415,'Polyethylene plastic ','Flexi laundary basket','American','Toilet');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (1516,'Basematerial : 100 % polyester (100% recycled), PET plastic , Clip : Polypropylene plastic ','Block-out pleated blind','Modern','Garden');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (1617,'100% polyester ','Mattress protector','Pharaonic','Living');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (1718,'Leg : Particleboard, Fibreboard, Paper foil , Fibreboard, Printed and embossed acrylic paint, Plastic edging','Coffe table','Modern','Living');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (1819,'Parasol base :Polypropylene plastic (20% recycled), Rib/ Base : Steel, Polyester powder coating , End cap: Polypropylene plastic , Fabric :100 % polyester ','Parasol, hanging with base','Classic','Living');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (1920,'Back panel: Fibreboard, Paper foil, Plastic foil, Fibreboard, Paper foil, Plastic edging,Underframe:Solid birch, Clear acrylic lacquer ','Cabinet combination with legs','Pharaonic','Room');
Insert into MODEL (MODELNUMBER,MATERIAL,STYLE,TYPE,CATEGORY) values (2021,'Ticking: 64% polyester, 36% cotton ,Comfort material: Polyester wadding ,Lining: Non-woven polypropylene,Comfort material: Polyurethane foam 28 kg/cu.m. ','Foam mattress','Modern','Living');

---------------------------------------------------
--   END DATA FOR TABLE MODEL
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE MODELP
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MODELP

---------------------------------------------------
--   END DATA FOR TABLE MODELP
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE MODEL_P
--   FILTER = none used
---------------------------------------------------
REM INSERTING into MODEL_P
Insert into MODEL_P (MODELNUMBER,MATERIAL,STYLEE) values (123,' Fabric : polyester , Frame : solid wood',' Corner sofa ');

---------------------------------------------------
--   END DATA FOR TABLE MODEL_P
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE ORDERR
--   FILTER = none used
---------------------------------------------------
REM INSERTING into ORDERR
Insert into ORDERR (ORDERID,STATUS,ORDER_COST,CUSTOMERID) values (1,'Available',400,5);
Insert into ORDERR (ORDERID,STATUS,ORDER_COST,CUSTOMERID) values (2,'Not Available',0,9);
Insert into ORDERR (ORDERID,STATUS,ORDER_COST,CUSTOMERID) values (3,'Available',6000,10);
Insert into ORDERR (ORDERID,STATUS,ORDER_COST,CUSTOMERID) values (4,'Not Available',0,8);
Insert into ORDERR (ORDERID,STATUS,ORDER_COST,CUSTOMERID) values (5,'Available',6000,7);
Insert into ORDERR (ORDERID,STATUS,ORDER_COST,CUSTOMERID) values (6,'Not Available',0,2);
Insert into ORDERR (ORDERID,STATUS,ORDER_COST,CUSTOMERID) values (7,'Available',6900,3);
Insert into ORDERR (ORDERID,STATUS,ORDER_COST,CUSTOMERID) values (8,'Not Available',0,1);
Insert into ORDERR (ORDERID,STATUS,ORDER_COST,CUSTOMERID) values (9,'Available',6570,6);
Insert into ORDERR (ORDERID,STATUS,ORDER_COST,CUSTOMERID) values (10,'Available',500,4);

---------------------------------------------------
--   END DATA FOR TABLE ORDERR
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE PRODUCT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PRODUCT
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (1,'Sofas',123,500);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (2,'Chairs',234,200);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (3,'Beds',345,5000);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (4,'Bathroom Lighting ',456,600);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (5,'Bathroom mirrors ',567,60000);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (6,'Unit Kitchen ',678,9000);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (7,'Kitchen Worktops',789,1000);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (8,'Decorative Lighting ',8910,600);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (9,'Outdoor furniture ',910,4000);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (10,'Mats ',1011,9000);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (11,'Media Furniture',1112,8000);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (12,' Clothes storage',1213,960);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (13,'Book Cases',1314,850);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (14,'Laundary Accesories',1415,7000);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (15,'Blinds',1516,4000);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (16,'Bedding textiles',1617,70);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (17,'Tables',1718,20);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (18,'Garden and balcony ',1819,40);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (19,'Sideboards and buffets',1920,400);
Insert into PRODUCT (PRODUCTID,PRODUCTNAME,MODELNUMBER,PRODUCT_COST) values (20,' Mattresses',2021,6000);

---------------------------------------------------
--   END DATA FOR TABLE PRODUCT
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE RENTALS
--   FILTER = none used
---------------------------------------------------
REM INSERTING into RENTALS

---------------------------------------------------
--   END DATA FOR TABLE RENTALS
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE SALGRADE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into SALGRADE
Insert into SALGRADE (GRADE,LOSAL,HISAL) values (1,700,1200);
Insert into SALGRADE (GRADE,LOSAL,HISAL) values (2,1201,1400);
Insert into SALGRADE (GRADE,LOSAL,HISAL) values (3,1401,2000);
Insert into SALGRADE (GRADE,LOSAL,HISAL) values (4,2001,3000);
Insert into SALGRADE (GRADE,LOSAL,HISAL) values (5,3001,9999);

---------------------------------------------------
--   END DATA FOR TABLE SALGRADE
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE SUPPLIER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into SUPPLIER
Insert into SUPPLIER (SUPPLIERID,SUPPLYNAME) values (1,'Karim');
Insert into SUPPLIER (SUPPLIERID,SUPPLYNAME) values (2,'Khaled');
Insert into SUPPLIER (SUPPLIERID,SUPPLYNAME) values (3,'Ahmed');
Insert into SUPPLIER (SUPPLIERID,SUPPLYNAME) values (4,'Mohamed');
Insert into SUPPLIER (SUPPLIERID,SUPPLYNAME) values (5,'Seif');
Insert into SUPPLIER (SUPPLIERID,SUPPLYNAME) values (6,'Moemen');
Insert into SUPPLIER (SUPPLIERID,SUPPLYNAME) values (7,'Mohamed');
Insert into SUPPLIER (SUPPLIERID,SUPPLYNAME) values (8,'Hazem');
Insert into SUPPLIER (SUPPLIERID,SUPPLYNAME) values (9,'Omar');
Insert into SUPPLIER (SUPPLIERID,SUPPLYNAME) values (10,'Ayman');

---------------------------------------------------
--   END DATA FOR TABLE SUPPLIER
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE SUPPLY
--   FILTER = none used
---------------------------------------------------
REM INSERTING into SUPPLY
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (1,1,13000);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (1,2,6500);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (2,3,7800);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (2,4,1000);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (3,5,2500);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (3,6,11000);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (4,7,599);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (4,8,3200);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (5,9,2599);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (5,10,69);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (6,11,2500);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (6,12,3495);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (7,13,4450);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (7,14,250);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (8,15,249);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (8,16,130);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (9,17,995);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (9,18,1999);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (10,19,3000);
Insert into SUPPLY (SUPPLIERID,PRODUCTID,COST_) values (10,20,2495);

---------------------------------------------------
--   END DATA FOR TABLE SUPPLY
---------------------------------------------------


---------------------------------------------------
--   DATA FOR TABLE VIEWW
--   FILTER = none used
---------------------------------------------------
REM INSERTING into VIEWW
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (1,1);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (1,2);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (2,3);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (2,4);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (3,5);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (3,6);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (4,7);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (4,8);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (5,9);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (5,10);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (6,11);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (6,12);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (7,13);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (7,14);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (8,15);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (8,16);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (9,17);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (9,18);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (10,19);
Insert into VIEWW (CUSTOMERID,PRODUCTID) values (10,20);

---------------------------------------------------
--   END DATA FOR TABLE VIEWW
---------------------------------------------------

--------------------------------------------------------
--  Constraints for Table ACTORS
--------------------------------------------------------

  ALTER TABLE "ACTORS" MODIFY ("ACTORNAME" NOT NULL ENABLE);
 
  ALTER TABLE "ACTORS" ADD PRIMARY KEY ("ACTORID") ENABLE;
--------------------------------------------------------
--  Constraints for Table GIVEREVIEW
--------------------------------------------------------

  ALTER TABLE "GIVEREVIEW" ADD CONSTRAINT "REVIEW_PK" PRIMARY KEY ("CUSTOMERID", "PRODUCTID") ENABLE;
--------------------------------------------------------
--  Constraints for Table FILMTITLES
--------------------------------------------------------

  ALTER TABLE "FILMTITLES" ADD PRIMARY KEY ("FILMID") ENABLE;
--------------------------------------------------------
--  Constraints for Table MCOLOR
--------------------------------------------------------

  ALTER TABLE "MCOLOR" ADD CONSTRAINT "M_C_PK" PRIMARY KEY ("MODELNUMBER", "MODELCOLOR") ENABLE;
--------------------------------------------------------
--  Constraints for Table EMP
--------------------------------------------------------

  ALTER TABLE "EMP" ADD CONSTRAINT "PK_EMP" PRIMARY KEY ("EMPNO") ENABLE;
--------------------------------------------------------
--  Constraints for Table EMPLOYEE
--------------------------------------------------------

  ALTER TABLE "EMPLOYEE" ADD PRIMARY KEY ("EMPLOYEEID") ENABLE;
--------------------------------------------------------
--  Constraints for Table VIEWW
--------------------------------------------------------

  ALTER TABLE "VIEWW" ADD CONSTRAINT "VIEW_PK" PRIMARY KEY ("CUSTOMERID", "PRODUCTID") ENABLE;
--------------------------------------------------------
--  Constraints for Table MANAGEP_E
--------------------------------------------------------

  ALTER TABLE "MANAGEP_E" ADD CONSTRAINT "MANGE_E_PK" PRIMARY KEY ("EMPLOYEEID", "PRODUCTID") ENABLE;
--------------------------------------------------------
--  Constraints for Table MANAGEE_C
--------------------------------------------------------

  ALTER TABLE "MANAGEE_C" ADD CONSTRAINT "MANGE_C_PK" PRIMARY KEY ("EMPLOYEEID", "CUSTOMERID") ENABLE;
--------------------------------------------------------
--  Constraints for Table MODEL
--------------------------------------------------------

  ALTER TABLE "MODEL" ADD PRIMARY KEY ("MODELNUMBER") ENABLE;
--------------------------------------------------------
--  Constraints for Table MEMBERS
--------------------------------------------------------

  ALTER TABLE "MEMBERS" MODIFY ("MEMNAME" NOT NULL ENABLE);
 
  ALTER TABLE "MEMBERS" ADD PRIMARY KEY ("MEMBERID") ENABLE;
--------------------------------------------------------
--  Constraints for Table FILMACTORS
--------------------------------------------------------

  ALTER TABLE "FILMACTORS" ADD CONSTRAINT "FLM_ACT_PK" PRIMARY KEY ("FILMID", "ACTORID") ENABLE;
--------------------------------------------------------
--  Constraints for Table CUSTOMER
--------------------------------------------------------

  ALTER TABLE "CUSTOMER" MODIFY ("LASTNAME" NOT NULL ENABLE);
 
  ALTER TABLE "CUSTOMER" MODIFY ("FIRSTNAME" NOT NULL ENABLE);
 
  ALTER TABLE "CUSTOMER" ADD PRIMARY KEY ("CUSTOMERID") ENABLE;
--------------------------------------------------------
--  Constraints for Table MANAGEP_C
--------------------------------------------------------

  ALTER TABLE "MANAGEP_C" ADD CONSTRAINT "MANAGEP_C_PK" PRIMARY KEY ("EMPLOYEEID", "PRODUCTID") ENABLE;
 
  ALTER TABLE "MANAGEP_C" MODIFY ("EMPLOYEEID" NOT NULL ENABLE);
 
  ALTER TABLE "MANAGEP_C" MODIFY ("PRODUCTID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PRODUCT
--------------------------------------------------------

  ALTER TABLE "PRODUCT" ADD PRIMARY KEY ("PRODUCTID") ENABLE;
--------------------------------------------------------
--  Constraints for Table FILMCOPIES
--------------------------------------------------------

  ALTER TABLE "FILMCOPIES" ADD PRIMARY KEY ("COPYID") ENABLE;
--------------------------------------------------------
--  Constraints for Table SUPPLIER
--------------------------------------------------------

  ALTER TABLE "SUPPLIER" ADD PRIMARY KEY ("SUPPLIERID") ENABLE;
--------------------------------------------------------
--  Constraints for Table MODEL_P
--------------------------------------------------------

  ALTER TABLE "MODEL_P" ADD PRIMARY KEY ("MODELNUMBER") ENABLE;
--------------------------------------------------------
--  Constraints for Table FILMCATEGORY
--------------------------------------------------------

  ALTER TABLE "FILMCATEGORY" ADD PRIMARY KEY ("CATEGORYID") ENABLE;


--------------------------------------------------------
--  Constraints for Table C_PHONENUMBER
--------------------------------------------------------

  ALTER TABLE "C_PHONENUMBER" ADD CONSTRAINT "C_PHONE_PK" PRIMARY KEY ("CUSTOMERID", "CUSTOMERPHONENUMBER") ENABLE;
--------------------------------------------------------
--  Constraints for Table ORDERR
--------------------------------------------------------

  ALTER TABLE "ORDERR" ADD CONSTRAINT "ORDER_PK" PRIMARY KEY ("ORDERID", "CUSTOMERID") ENABLE;
--------------------------------------------------------
--  Constraints for Table MODELP
--------------------------------------------------------

  ALTER TABLE "MODELP" ADD PRIMARY KEY ("MODELNUMBER") ENABLE;
--------------------------------------------------------
--  Constraints for Table RENTALS
--------------------------------------------------------

  ALTER TABLE "RENTALS" ADD PRIMARY KEY ("RENTID") ENABLE;
--------------------------------------------------------
--  Constraints for Table SUPPLY
--------------------------------------------------------

  ALTER TABLE "SUPPLY" ADD CONSTRAINT "SUPPLY_PK" PRIMARY KEY ("SUPPLIERID", "PRODUCTID") ENABLE;
--------------------------------------------------------
--  Constraints for Table DEPT
--------------------------------------------------------

  ALTER TABLE "DEPT" ADD CONSTRAINT "PK_DEPT" PRIMARY KEY ("DEPTNO") ENABLE;
--------------------------------------------------------
--  DDL for Index MANGE_C_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "MANGE_C_PK" ON "MANAGEE_C" ("EMPLOYEEID", "CUSTOMERID") 
  ;
--------------------------------------------------------
--  DDL for Index C_PHONE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "C_PHONE_PK" ON "C_PHONENUMBER" ("CUSTOMERID", "CUSTOMERPHONENUMBER") 
  ;
--------------------------------------------------------
--  DDL for Index PK_DEPT
--------------------------------------------------------

  CREATE UNIQUE INDEX "PK_DEPT" ON "DEPT" ("DEPTNO") 
  ;
--------------------------------------------------------
--  DDL for Index M_C_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "M_C_PK" ON "MCOLOR" ("MODELNUMBER", "MODELCOLOR") 
  ;
--------------------------------------------------------
--  DDL for Index REVIEW_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "REVIEW_PK" ON "GIVEREVIEW" ("CUSTOMERID", "PRODUCTID") 
  ;
--------------------------------------------------------
--  DDL for Index VIEW_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "VIEW_PK" ON "VIEWW" ("CUSTOMERID", "PRODUCTID") 
  ;
--------------------------------------------------------
--  DDL for Index MANAGEP_C_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "MANAGEP_C_PK" ON "MANAGEP_C" ("EMPLOYEEID", "PRODUCTID") 
  ;
--------------------------------------------------------
--  DDL for Index SUPPLY_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "SUPPLY_PK" ON "SUPPLY" ("SUPPLIERID", "PRODUCTID") 
  ;
--------------------------------------------------------
--  DDL for Index MANGE_E_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "MANGE_E_PK" ON "MANAGEP_E" ("EMPLOYEEID", "PRODUCTID") 
  ;
--------------------------------------------------------
--  DDL for Index ORDER_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "ORDER_PK" ON "ORDERR" ("ORDERID", "CUSTOMERID") 
  ;
--------------------------------------------------------
--  DDL for Index PK_EMP
--------------------------------------------------------

  CREATE UNIQUE INDEX "PK_EMP" ON "EMP" ("EMPNO") 
  ;
--------------------------------------------------------
--  DDL for Index FLM_ACT_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "FLM_ACT_PK" ON "FILMACTORS" ("FILMID", "ACTORID") 
  ;


--------------------------------------------------------
--  Ref Constraints for Table CUSTOMER
--------------------------------------------------------

  ALTER TABLE "CUSTOMER" ADD FOREIGN KEY ("MAKE_ORDERID", "MAKE_CUSTOMERID")
	  REFERENCES "ORDERR" ("ORDERID", "CUSTOMERID") ENABLE;
 
  ALTER TABLE "CUSTOMER" ADD FOREIGN KEY ("TRACK_ORDERID", "TRACK_CUSTOMERID")
	  REFERENCES "ORDERR" ("ORDERID", "CUSTOMERID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table C_PHONENUMBER
--------------------------------------------------------

  ALTER TABLE "C_PHONENUMBER" ADD FOREIGN KEY ("CUSTOMERID")
	  REFERENCES "CUSTOMER" ("CUSTOMERID") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table EMP
--------------------------------------------------------

  ALTER TABLE "EMP" ADD CONSTRAINT "FK_DEPTNO" FOREIGN KEY ("DEPTNO")
	  REFERENCES "DEPT" ("DEPTNO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table EMPLOYEE
--------------------------------------------------------

  ALTER TABLE "EMPLOYEE" ADD FOREIGN KEY ("SUPERVISOR_ID")
	  REFERENCES "EMPLOYEE" ("EMPLOYEEID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table FILMACTORS
--------------------------------------------------------

  ALTER TABLE "FILMACTORS" ADD FOREIGN KEY ("FILMID")
	  REFERENCES "FILMTITLES" ("FILMID") ENABLE;
 
  ALTER TABLE "FILMACTORS" ADD FOREIGN KEY ("ACTORID")
	  REFERENCES "ACTORS" ("ACTORID") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table FILMCOPIES
--------------------------------------------------------

  ALTER TABLE "FILMCOPIES" ADD FOREIGN KEY ("FILMID")
	  REFERENCES "FILMTITLES" ("FILMID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table FILMTITLES
--------------------------------------------------------

  ALTER TABLE "FILMTITLES" ADD FOREIGN KEY ("FILMCATEGORYID")
	  REFERENCES "FILMCATEGORY" ("CATEGORYID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table GIVEREVIEW
--------------------------------------------------------

  ALTER TABLE "GIVEREVIEW" ADD FOREIGN KEY ("CUSTOMERID")
	  REFERENCES "CUSTOMER" ("CUSTOMERID") ENABLE;
 
  ALTER TABLE "GIVEREVIEW" ADD FOREIGN KEY ("PRODUCTID")
	  REFERENCES "PRODUCT" ("PRODUCTID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table MANAGEE_C
--------------------------------------------------------

  ALTER TABLE "MANAGEE_C" ADD FOREIGN KEY ("EMPLOYEEID")
	  REFERENCES "EMPLOYEE" ("EMPLOYEEID") ENABLE;
 
  ALTER TABLE "MANAGEE_C" ADD FOREIGN KEY ("CUSTOMERID")
	  REFERENCES "CUSTOMER" ("CUSTOMERID") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table MANAGEP_E
--------------------------------------------------------

  ALTER TABLE "MANAGEP_E" ADD FOREIGN KEY ("EMPLOYEEID")
	  REFERENCES "EMPLOYEE" ("EMPLOYEEID") ENABLE;
 
  ALTER TABLE "MANAGEP_E" ADD FOREIGN KEY ("PRODUCTID")
	  REFERENCES "PRODUCT" ("PRODUCTID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table MCOLOR
--------------------------------------------------------

  ALTER TABLE "MCOLOR" ADD FOREIGN KEY ("MODELNUMBER")
	  REFERENCES "MODEL" ("MODELNUMBER") ENABLE;




--------------------------------------------------------
--  Ref Constraints for Table ORDERR
--------------------------------------------------------

  ALTER TABLE "ORDERR" ADD FOREIGN KEY ("CUSTOMERID")
	  REFERENCES "CUSTOMER" ("CUSTOMERID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table PRODUCT
--------------------------------------------------------

  ALTER TABLE "PRODUCT" ADD FOREIGN KEY ("MODELNUMBER")
	  REFERENCES "MODEL" ("MODELNUMBER") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table RENTALS
--------------------------------------------------------

  ALTER TABLE "RENTALS" ADD FOREIGN KEY ("MEMBERID")
	  REFERENCES "MEMBERS" ("MEMBERID") ENABLE;


--------------------------------------------------------
--  Ref Constraints for Table SUPPLY
--------------------------------------------------------

  ALTER TABLE "SUPPLY" ADD FOREIGN KEY ("SUPPLIERID")
	  REFERENCES "SUPPLIER" ("SUPPLIERID") ENABLE;
 
  ALTER TABLE "SUPPLY" ADD FOREIGN KEY ("PRODUCTID")
	  REFERENCES "PRODUCT" ("PRODUCTID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table VIEWW
--------------------------------------------------------

  ALTER TABLE "VIEWW" ADD FOREIGN KEY ("CUSTOMERID")
	  REFERENCES "CUSTOMER" ("CUSTOMERID") ENABLE;
 
  ALTER TABLE "VIEWW" ADD FOREIGN KEY ("PRODUCTID")
	  REFERENCES "PRODUCT" ("PRODUCTID") ENABLE;
--------------------------------------------------------
--  DDL for Procedure DELETE_ROW
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "DELETE_ROW" 
(idd NUMBER)
as 
begin
DELETE from product
where productid = idd;
end;

/

--------------------------------------------------------
--  DDL for Procedure DISPLAY_PRDOUCT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "DISPLAY_PRDOUCT" 
(id2 in NUMBER , Cidd out sys_refcursor)
as 
begin
open cidd for
select *
from product 
where productid = id2;
end;

/

--------------------------------------------------------
--  DDL for Procedure INSERT_PRODUCT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "INSERT_PRODUCT" 
(PID number, ProName VARCHAR2,Modelnum Number,
 ProductCost  Number)
as
begin
insert  into  product
(productid, productname, modelnumber, product_cost)
Values (PID, ProName, Modelnum, ProductCost) ;
End;

/

--------------------------------------------------------
--  DDL for Procedure MULTIPLE_ROW
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "MULTIPLE_ROW" 
(id1 in NUMBER , Cid out sys_refcursor)
as 
begin
open cid for
select *
from orderr 
where orderid = id1;
end;

/

--------------------------------------------------------
--  DDL for Procedure ONEROW
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "ONEROW" 
(idd out NUMBER  , costt out NUMBER , cid out NUMBER)
as
begin
select ord.orderid, ord.order_cost , ord.customerid 
into idd ,costt , cid
from orderr ord , customer c
where ord.orderid = 1
and ord.customerid = c.customerid ;
COMMIT;
End OneRow;

/

--------------------------------------------------------
--  DDL for Procedure UPDATE_STATUE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "UPDATE_STATUE" 
(idd NUMBER, stat VARCHAR2, cost_ IN OUT  NUMBER,currentLoc IN OUT  VARCHAR2)
is
cusID NUMBER;

begin

select customerid
into cusID
from orderr
where orderid = idd;

UPDATE orderr
set status= stat
where orderid = idd;


if stat = 'Not Available' then
  cost_ := 0;
  currentLoc := NULL;
  UPDATE orderr
  set order_cost = cost_
  where orderid = idd;
  UPDATE customer
  set order_current_loc = currentLoc
  where customerid = cusid;
else
  UPDATE orderr
  set order_cost = cost_
  where orderid = idd;
  UPDATE customer
  set order_current_loc = currentLoc
  where customerid = cusid;
end if;
commit;
end;

/

