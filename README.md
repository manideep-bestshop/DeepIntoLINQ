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
          
 IEnumerableIEnumerator:
-----------------------
                 IEnumerator and IEnumerable are both interfaces, used for working with collections,
 enabling iteration over a sequence of elements. They are fundamental parts of the IEnumerator pattern.
 
1.IEnumerable:
---------------
-IEnumerable is the parent interface that represents a collection of objects that can be enumerated.
-It contains a single method GetEnumerator() that returns an IEnumerator interface.
-When a class implements IEnumerable, it indicates that instances of that class can be enumerated.

2.IEnumerator:
---------------
-IEnumerator provides a way to iterate through a collection of items one at a time.
-It contains methods like MoveNext(), which advances the enumerator to the next element, and Reset(),
  which resets the enumerator to its initial position.
-It also includes a property Current, which returns the current element in the collection.

Threading
-----------
-Every application by default contains one thread to execute the program and that is known as 
 Main Threading,so every program is by default single threaded model.
 
Multi-Threadings:
-----------------

Process: Multi threadings

-Time sharing
-advantage of using maximum of CPU Resources
