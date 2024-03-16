LINQ: Language Integrated Query
-----
-Using LINQ we can write queries on a wide variety of data sources Like Arrays,Collectons,Database Tables
 Datasets,Xml Data.
 
SQL Query: SELECT <ColNames> FROM <TableName> [AS <alias>] [Clauses]

LINQ Query:  FROM <alias> in <col/Arr> [Clauses] SELECT <alias>
 
 EX: int[] arr ={20,34,12,54,65,};
 
  var arr= FROM i in arr SELECT i;
  
  var arr= FROM i in arr WHERE i>40 SELECT i;
           
 
