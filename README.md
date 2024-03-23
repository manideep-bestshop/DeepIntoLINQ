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

ImpNotesOnThreading:
-------------------
physical processor
-------------------
      also known as a CPU (Central Processing Unit), refers to the actual hardware
 component within a computer system that performs calculations, executes instructions, and manages data manipulation.
 It's the physical chip that you can see and touch, typically containing multiple cores.
 
logical processor
-----------------
     on the other hand, refers to a virtual processing unit created by the operating system to manage
 tasks and execute instructions. In modern CPUs, each physical core can often handle multiple threads through 
 technologies like hyper-threading. Each thread represents a logical processor, allowing the CPU to execute
 multiple tasks simultaneously or in parallel. 

Process:
--------
     In computing, a process refers to an instance of a computer program that is being executed.
 Processes are managed by the operating system, which allocates resources and schedules their execution on the CPU.
 
Threading:
----------
     Threading is a programming technique used to create concurrent execution paths within a single process. 
 Threads are lightweight processes within a program that can perform tasks independently of each other. 
 
 MultiTasking vs MultiThreading:
 -------------------------------
 -multitasking refers to the ability of an operating system to run multiple processes concurrently, 
 -while multithreading is a programming technique that allows a single process to create and manage multiple threads of execution. 
 -Multitasking operates at the level of the operating system,
 -while multithreading operates within the context of a single process.

Naming Conventions:
-------------------
      In C#, naming conventions are essential for writing clean, readable, and maintainable code. 
Here are some commonly accepted naming conventions in C#:

1.Pascal Case: 
--------------
       Pascal case is used for naming classes, methods, properties, and namespaces. 
 It capitalizes the first letter of each word in the identifier and does not use underscores.
For example:

ClassName
MethodName()
PropertyName
NamespaceName

public class MyClass  // Class Name 
{
    public void MyMethod() // Method namespaces
    {
        // Method implementation
    }

    public string MyProperty { get; set; }  // Property Name
}

2.Camel Case: 
-------------
      Camel case is used for naming parameters, local variables, and fields. It capitalizes the first letter 
of each word except for the first word, and does not use underscores.
For example:

methodName
propertyName
localVariable
fieldName

public class MyClass
{
    public void MyMethod(int myParameter) // parameter
    {
        int localVar = 10;  // local Variable
        string fieldName = "example"; // field name
    }

    private string propertyName; // private property
}

3.Constants: 
------------
  Constants are named using all uppercase letters, with words separated by underscores. 
 For example:
 
CONSTANT_NAME

public class Constants
{
    public const int MAX_VALUE = 100;
    public const string FILE_PATH = "C:\\example.txt";
}

4.Prefixes and Suffixes:
------------------------
 Sometimes prefixes and suffixes are used to indicate the type of the identifier.
 For example:

strVariable for string variables
btnSubmit for button controls
intIndex for integer indices

public class Example
{
    private string strMessage;
    private Button btnSubmit;
    private int intIndex;
}

5.Acronyms and Abbreviations: 
-----------------------------
   Acronyms and abbreviations should be treated as words. 
   For example:

XmlDocument instead of XMLDocument
userId instead of UserID

public class XmlHandler
{
    public XmlDocument LoadXmlDocument(string xmlFilePath)
    {
        // Load and return XmlDocument
    }
}

6.Meaningful Names: 
-------------------
Choose names that are descriptive and indicate the purpose or use of the identifier. Avoid single-letter names except for temporary loop variables.

public class ShoppingCart
{
    private List<Product> productsInCart;

    public void AddProduct(Product product)
    {
        productsInCart.Add(product);
    }
}

7.Namespace Names:
------------------
    Use nouns or noun phrases for namespace names. Avoid abbreviations.
	
namespace CompanyName.ProductName.ModuleName
{
    // Classes and code related to a specific module
}

8.Class Names:
--------------
   Use nouns or noun phrases to name classes. Class names should be singular.	
 
public class Employee
{
    // Class implementation
}

9.Interface Names:
------------------
    Interface names should start with the letter "I" followed by a PascalCase name that describes the functionality it provides.
	
public interface ILogger
{
    void Log(string message);
}

10.Method Names: 
----------------
    Use verbs or verb phrases to name methods. Method names should be descriptive and indicate the action performed by the method.
	
public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}

11.Property Names: 
------------------
   Property names should be nouns or noun phrases that describe the property.
   
 public class Person
{
    public string FullName { get; set; }
    public int Age { get; set; }
}  

12.Event Names: 
---------------
   Event names should be verbs or verb phrases that describe the action that triggers the event.
   
   public class Button
{
    public event EventHandler Clicked;

    protected virtual void OnClicked(EventArgs e)
    {
        Clicked?.Invoke(this, e);
    }
}

13.Boolean Properties and Fields:
---------------------------------
    Boolean properties and fields should be prefixed with "Is", "Has", or another appropriate verb to indicate their meaning. 
	
public class User
{
    public bool IsActive { get; set; }
    private bool hasPermission;
}	
