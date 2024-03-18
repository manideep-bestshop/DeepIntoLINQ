LINQ: Language Integrated Query
-----
-Using LINQ we can write queries on a wide variety of data sources Like Arrays,Collectons,Database Tables
 Datasets,Xml Data.
 
SQL Query: SELECT <ColNames> FROM <TableName> [AS <alias>] [Clauses]

LINQ Query:  FROM <alias> in <col/Arr> [Clauses] SELECT <alias>
 
 EX: int[] arr ={20,34,12,54,65,};
 
  var arr= FROM i in arr SELECT i;
  
  var arr= FROM i in arr WHERE i>40 SELECT i;

  LINQ to SQL:
 ------------
 -Its a query language and working with relational database i.e. Sql Server
 -its not only quering the data it is also allow us to perform CRUD operations
 
Note:  We can call stored procedures also using LINQ to Sql 

SQL=>Sql Server

1. Run-time exceptions
2.not type safe
3.Intellisence not available


LINQ=>SQL Server

1.Compile time exceptions
2.type safe
3.Intellisence available
          
 
