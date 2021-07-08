
  CREATE OR REPLACE PROCEDURE "SCOTT"."INVOICES" 
( idd OUT NUMBER

, costt OUT NUMBER
, Customer_IDD IN NUMBER
)
AS
BEGIN
  select invID,inv_cost INTO idd, costt
  FROM invoice WHERE cust= customer_idd;
  
  dbms_output.put_line(idd||' '||' '|| costt) ;
  
END INVOICES;

/
 