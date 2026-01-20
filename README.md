# C# Practice
A collection of c# practice tasks and useful notes for learning C#.

Project created for personal use for the journey of learning C#.

---

## Contents
- [Acknowledgements](#acknowledgements)
- [About](#about)
- [Useful sources](#useful-sources)
- [Useful notes for a new learner](#useful-notes)
  - [Naming Conventions](#naming-conventions)
  - [Main](#main)
  - [WriteLine](#writeline)
  - [Write](#write)
  - [Comments](#comments)
  - [Variables and Types](#variables-and-types)
    - [Types](#types)
      - [Type Casting](#type-casting)
  - [Constants](#constants)
  - [C# Identifiers](#c-identifiers)
  - [User Input](#user-input)
  - [Operators](#operators)
  - [Math](#math)
  - [Strings](#strings)
  - [Booleans](#booleans)
  - [If ... Else](#if--else)
  - [Switch](#switch)
  - [While Loop](#while-loop)
  - [For Loop](#for-loop)
  - [Break and Continue](#break-and-continue)
  - [Arrays](#arrays)
  - [Methods](#methods)

---

## Acknowledgements
W3Schools has been used vigoriously during the creation of this project.

AI (Copilot) has also been used vigoriously as a learning tool for creating practice tasks and explaining
terminology, methods, code, etc.

.gitignore:  
https://github.com/github/gitignore/blob/main/VisualStudio.gitignore

---

## About

I decided to split the practice lessons up into two parts:  
Traditional (class, main) and  
Top-Level Statements

To start with I will be focusing on learning traditional, and I am aware that something isn't working  
in Program.cs of "top_level_statements" project - I will get to that.

The practice lessons in the two projects are AI generated, while the notes from the main project README.md (this file)
are read and written based on W3Schools. I decided to not add the practice lessons from W3Schools because they are so
many, and available for free for anyone who wishes to do them.


[🏚️ Back to top](#contents)

---

## Useful sources
Practice tasks and theory:  
[W3 Schools - C#](https://www.w3schools.com/cs/)  

Lots and lots of reading:  
[C# Documentation - Microsoft](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)  

Large repo with many .gitignore templates:  
[Gitignore Templates](https://github.com/github/gitignore/blob/main/VisualStudio.gitignore)


[🏚️ Back to top](#contents)

---

## Useful notes
Coming from Python to C# one of the first things I noticed was the pretty intense increase in
verbosity. There is SO much text!!!  

I will be adding notes and things here that I found useful while trying to navigate this new language 
and understand how it's built.

---

# Naming Conventions
Naming conventions in C#:  

**Variables and parameters:**  
* camelCase
* Clear, meaningful names

Examples:  
* int count;
* string customerName;
* double totalAmount;
* bool isApproved;

**Methods**  
* PascalCase
* Use verbs or phrases that describe the action

Examples:  
* viud CalculateTotal() { }
* string FormatName(string name) { }
* Task SaveChangesAsync() { } // Async methods end with "Async"

**Classes, Structs, Enums, Records, Namespaces**  
* PascalCase

Examples:  
* public class OrderService { }
* public struct Point2D { }
* public enum OrderStatus { Pending, Shipped, Delivered }
* namespace TraditionalTopLevel { }

**Properties**  
* PascalCase, noun/adjectives

Examples:  
* public string Title { get; set; }
* public int Quantity { get; private set; }
* public bool IsActive { get; set; }

**Fields**  
* Private fields: _camelCase (leading underscore)
* Public fields (rare): PascalCase (prefer properties instead)

Examples:  
* private readonly ILogger _logger;
* private int _retryCount;

**Constants and Readonly statics**  
* PascalCase (not ALL_CAPS in .NET)

Examples:  
* public const int DefaultTimeoutSeconds = 30;
* public static readonly string AppName = "GitGetter";

**Interfaces**
* PascalCase with leading I

Examples:
* public interface IOrderRepository { }

**Events and Event Handlers**
* Events: PascalCase (noun or verb phrase) often ending with "Changed", "Completed", etc
* Handlers: On + EventName

Examples:  
* public event EventHandler StatusChanged;
* protected virtual void OnStatusChanged() { raise event }



[🏚️ Back to top](#contents)

---

### Main
Main is the entrypoint that executes your code in traditional C# programming.


[🏚️ Back to top](#contents)

---

### WriteLine()
WriteLine() is a method of the class Console in the System namespace.  
System -> Console -> WriteLine()  
This was useful for me to explicitly read, because it helped me understand what's actually going on
when I use WriteLine. It just didn't occur to me until I read about it.

You can add as many WriteLine() methods as you want. Note that each will write on a new line.  
You can also do calculations using this method:
```csharp
Console.WriteLine(3 + 3);
```

[🏚️ Back to top](#contents)

---

### Write()
Write is also a method belonging to Console and System like WriteLine.  
This method performs the same, but does not add a new line at the end.
Writing something like this:
```csharp
Console.Write("Hello World! ");
Console.Write("I will print on the same line.");
```
will have both outputs on the same line like this:
> Hello World! I will print on the same line.

---

### Comments
One line and multiline.
>// This is a one-line comment.  

>/* This is a   
>multiline comment */

Like in Python, don't overdo it. Comment where it adds value.


[🏚️ Back to top](#contents)

---

### Variables and types
Types must be declared in C#.  

A few types:
* int - integers (whole numbers, no decimals)
* double - floating point numbers (float) with decimals (19.99, -19.99)
* char - single characters ('B', 'b', 'a', 'A') using *SINGLE QUOTES*
* string - stores text ("hello world"), using *DOUBLE QUOTES*
* bool - stores values with two states: true or false

**Syntax**  
```type variableName = value;```

**Example, string**
```csharp
string name = "John";
Console.WriteLine(name);
```
**Example, int**
```csharp
int myNum = 15;
ConsoleWriteLine(myNum);
```
You can also declate a variable without assigning the value, and assign value later:
```csharp
int myNum;
myNum = 15;
Console.WriteLine(myNum);
```

**Other types**
```csharp
int myNum = 15;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello World"
```

[🏚️ Back to top](#contents)

---

### Types
Variable types *must* be declared in C#.  

**Example**
```csharp
int myNum = 5; // Integer (whole number)
double myDoubleNum = 5.99D; // Float (floating point number)
char myLetter = 'D'; // One character, single quotes
bool myBool = true; // Boolean; True or False
string myText = "Hello World"; // String; text
```

The data type specifies the size and type of variable values.

It is important to use the correct data type for the corresponding variable:
- to avoid errors
- save time
- save memory
- maintainable and readable code

**Most common data types and sizes:**

| Data Type | Size                  | Description                                                                                |
|-----------|-----------------------|--------------------------------------------------------------------------------------------|
| int       | 4 bytes               | Stores whole numbers from -2,147,483,648 to 2,147,483,647                                  |
| long      | 8 bytes               | Stores whole numbers               -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
| float     | 4 bytes               | Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits                    |
| double    | 8 bytes               | Stores fractional numbers. Sufficient for storing 15 decimal digits                        |
| bool      | 1 byte                | Stores true or false values                                                                |
| char      | 2 bytes               | Stores a single character/letter, surrounded by single quotes                              |
| string    | 2 bytes per character | Stores a sequence of characters, surrounded by double quotes                               |

**Numbers**  
Numbers are divided into 2 groups:  
* Integer types: stores whole numbers, positive or negative (123, -456) without decimals. Valid types
are ```int``` and ```long```. Which type you use depends on the numeric value.
* Floating point types: represents numbers with fractional parts, one or more decimals. Valid types are 
```float``` and ```double```.

**Integer example:**
```csharp
int myNum = 100000;
Console.WriteLine(myNum);
```
**Long example:**
```csharp
long myNum = 15000000000L;
Console.WriteLine(myNum);
```
**Floating point example:**
```csharp
float myNum = 5.75F;
Console.WriteLine(myNum);
```
**Double example:**
```csharp
double myNum = 19.99D;
Console.WriteLine(myNum);
```

Use ```float``` or ```double```?  
The *precicion* of a floating point value indicates how many digits the value can have after the decimal point.
The precicion of *float* is only six or seven decimal digits, while *double* variables have a precicion
of about 15 digits. Therefore it is safer to use *double* for most calculations.

**Scientific Numbers**  
A floating point number can also be a scientific number with an "e" to indicate the power of 10:  
```csharp
float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);
```

**Booleans**  
Declared with the ```bool``` keyword, can only be *true* or *false*:
```csharp
bool isCSharpFun = true;
bool isFishTasty = false; // I don't agree with this! W3Schools did this!
Console.WriteLine(isCSharpFun); // Outputs True
Console.WriteLine(isFishTasty); // Outputs False
```
Boolean values are mostly used for conditional testing.

**Characters**  
The ```char``` data type is used to store a single character. Must be surrounded by single quotes.  
```csharp
char myGrade = 'A';
Console.WriteLine(myGrade);
```

**Strings**  
Stores sequences:
```csharp
string greeting = "Hello World!";
Console.WriteLine(greeting);
```


[🏚️ Back to top](#contents)


---

### Type Casting
Type casting is when you assign a value of one data type to another type.

In C# there are two types of casting:

* Implicit Casting - Automatic, converting a smaller type to a larger type size
>char -> int -> long -> float -> double

* Explicit Casting - Manual, converting a larger type to a smaller type size
>double -> float -> long -> int -> char


**Implicit Casting**  
Smaller to Larger:
```csharp
int myInt = 9;
double myDouble = myInt; // Auto cast -> int to double

Console.WriteLine(myInt); // Outputs 9
Console.WriteLine(myDouble); // Outputs 9
```

**Explicit Casting**
Larger to Smaller:
```csharp
double myDouble = 9.78D;
int myInt = (int) myDouble; // Manual casting -> double to int

Console.WriteLine(myDouble); // Output 9.78
Console.WriteLine(myInt); // Output 9
```

**Type Conversion Methods**  
It is possible to convert data types explicitly using built-in methods such as:
* Convert.ToBoolean
* Convert.ToDouble
* Convert.ToString
* Convert.ToInt32 (int)
* Convert.ToInt64 (long)

**Example:**
```csharp
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt)); // Convert int to string
Console.WriteLine(Convert.ToDouble(myInt)); // Convert int to double
Console.WriteLine(Convert.ToInt32(myDouble)); // Convert double to int
Console.WriteLine(Convert.ToString(myBool)); // Convert bool to string
```


[🏚️ Back to top](#contents)

---

### Constants
If you don't want others (or yourself) to overwrite existing values, you can add the const 
keyword in front of the variable type.  
This will declare the variable as "constant" which means unchangeable and read-only.
```csharp
const int myNum = 15;
myNum = 20; // Error
```
The above cannot be changed.

**Display Variables**
WriteLine() can be used to display variable values to the console window.  
To combine:
```csharp
string name = "John";
Console.WriteLine("Hello" + name);
```
Add another variable:
```csharp
string firstName = "John";
string lastName = "Doe";
string fullName = firstName + lastName;
Console.WriteLine(fullName);
```
For numeric values:
```csharp
int x = 5;
int y = 6;
Console.WriteLine(x + y); // Print the value of x + y
```

**Several variables of same type**  
You can declare several variables of the same type in one line:
```csharp
int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);
```
Or like this:
```csharp
int x, y, z;
x = y = z = 50;
Console.WriteLine(x + y + z);
```

[🏚️ Back to top](#contents)

---

### C# Identifiers
All C# variables must be identified with unique names.  
Identifiers can be short (x, y) or more descriptive (age, sum, totalVolume).  

*Note:* It is recommended to use descriptive names in order to create understandable and maintainable code.

**Example**
```csharp
// Good
int minutesPerHour = 60;

// OK, but not so easy to understand
int m = 60;
```

**The general rules for naming variables are:**

* Names can contain letters, digits and the underscore character (_)


* Names must begin with a letter or underscore 


* Names should start with a lowercase letter, and cannot contain whitespace 


* Names are case-sensitive ("myVar" and "myvar" are different variables)


* Reserved words (like C# keywords, such as int or double) cannot be used as names


[🏚️ Back to top](#contents)

---

### User Input
To get user input in C#, we use ```Console.ReadLine()```.

This example lets user input their username, stored as variable userName, then we print the value.
```csharp
// Type username and press enter:
Console.WriteLine("Enter username: ");

// Create a string variable and get user input -> store input in variable:
string userName = Console.ReadLine();

// Print the value of the variable (userName);
Console.WriteLine("Username is: " + userName);
```

The ```Console.ReadLine()``` method returns a ```string```. Therefore you cannot get info from another data type,
such as ```int```. The following will cause an *error*:
```csharp
Console.WriteLine("Enter your age: ");
int age = Console.ReadLine();
Console.WriteLine("Your age is: " + age);
```
The error will be something like:
>Cannot implicitly convert type 'string' to 'int'

You can not implicitly convert type *string* to type *int*.  
However, we can use the Convert.To method for this, and explicitly convert:
```csharp
Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);
```

---

### Operators
Operators are used to perform operations on variables and values.

```csharp
int x = 100 + 50;
```
Often used to add together two values.  
Can also be used to add together a variable and a value:
```csharp
int sum1 = 100 + 50; // 150 (100 + 50)
int sum2 = sum1 + 250; // 400 (150 + 250)
int sum3 = sum2 + sum2; // 800 (400 + 400)
```

**Arithmetic Operations**

| **Operator** | **Name**       | **Description**                   | **Example** |
|--------------|----------------|-----------------------------------|-------------|
| +            | Addition       | Adds together two values          | x + y       |
| -            | Subtraction    | Subtracts one value from another  | x - y       |
| *            | Multiplication | Multiplies two values             | x * y       |
| /            | Division       | Divides one value by another      | x / y       |
| %            | Modulus        | Returns the division remainder    | x % y       |
| ++           | Increment      | Increases the value of a var by 1 | x++         |
| --           | Decrement      | Decreases the value of a var by 1 | x--         |

---

**Assignment Operators**  
Used to assign values to variables.

In this example:
```csharp
int x = 10;
```
the *assignment operator* '=' is used to assign the value of 10 to the variable x.

The *addition assignment operator* '+' adds value to a variable.
```csharp
int x = 10;
x += 5;
```

**List of all assignment operators:**

| **Operator** | **Example** | **Same As** |
|--------------|-------------|------------|
| =            | x = 5       | x = 5      |
| +=           | x += 3      | x = x + 3  |
| -=           | x -= 3      | x = x - 3  |
| *=           | x *= 3      | x = x * 3  |
| /=           | x /= 3      | x = x / 3  |
| %=           | x %= 3      | x = x % 3  |
| &=           | x &= 3      | x = x & 3  |
| \|=          | x \|= 3     | x = x \| 3 |
| ^=           | x ^= 3      | x = x ^ 3  |
| >>=          | x >> = 3    | x = x >> 3 |
| <<=          | x << = 3    | x = x << 3 |


---

**Comparison Operators**  
Used to compare two values (or variables).  
This is important in programming because it helps us find answers and make decisions.

The return value of a comparison is either True or False.

**Example**  
Find out if 5 is greater than 3 (I mean, *who* would know such a thing by heart??):
```csharp
int x = 5;
int y = 3;

Console.WriteLine(x > y); // Returns True because 5 is greater than 3
```

**Comparison Operators**

| **Operator** | **Name**                 | **Example** |
|--------------|--------------------------|-------------|
| ==           | Equal to                 | x == y      |
| !=           | Not equal                | x != y      |
| \>           | Greater than             | x > y       |
| <            | Less than                | x < y       |
| >=           | Greater than or equal to | x >= y      |
| <=           | Less than or equal to    | x <= y      |


**Logical Operators**  
Test for True and False using *Logical Operators*.

Logical operators are used to determine the logic between variables or values.

**Logical Operators List**  

| **Operator** | **Name**    | **Description**                                         | **Example**      |
|--------------|-------------|---------------------------------------------------------|------------------|
| &&           | Logical and | Returns True if both statements are true                | x < 5 && x < 10  |
| \|\|         | Logical or  | Returns True if one of the statements is true           | x < 5 \|\| x < 4 |
| !            | Logical not | Reverse the result, returns False if the result is true | !(x < 5 && x < 10 |

---

### Math
Math is a class. It has several methods.  

**Math.Max(x,y)**  
Can be used to find the highest value of x and y.
```csharp
Math.Max(5, 10);
```

**Math.Min(x,y)**  
Find the lowest value of x and y.
```csharp
Math.Min(5, 10);
```

**Math.Sqrt(x)**  
Used to return square root of x.
```csharp
Math.Sqrt(64);
```

**Math.Abs(x)**  
Returns the absolute (positive) value of x.
```csharp
Math.Abs(-4.7);
```

**Math.Round()**  
Rounds a number to the nearest whole number.
```csharp
Math.Round(9.99);
```

---

### Strings
Used for storing text, just like in Python.

A string variable contains a collection of characters surrounded by double quotes "string".

```csharp
string greeting = "Hello!"
```
It can contain many words.

**String Length**  
In C# a string is actually an object, which contain properties and methods that can perform
certain operations on strings. For example, the length of a string can be found using the
```Length``` property.

```csharp
string txt = "ABCDEFGHLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);
```

**Other Methods**  
Many string methods are available, for example ToUpper() and ToLower() which returns a copy of the
string converted to uppercase or lowercase.

```csharp
string txt = "Hello World!";
Console.WriteLine(txt.ToUpper()); // Outputs "HELLO WORLD!"
Console.WriteLine(txt.ToLower()); // Outputs "hello world!"
```

**String Concatenation**  
The + operator can be used between strings to combine them.  
This is called 'concatenation'.

```csharp
string firstName = "John ";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);
```
Note the added whitespace after "John" in order to have space between first and last name.

We can also use the ```string.Concat()``` method to concatenate two strings:
```csharp
string firstName = "John ";
string lastName = "Doe";
string name = string.Concat(firstName, lastName);
Console.WriteLine(name);
```

Warning:  
C# uses the + operator for both addition and concatenation.  
Remember that numbers are added, and strings are concatenated.

Adding numbers will result in a number:
```csharp
int x = 10;
int y = 20;
int z = x + y; // z will be 30 (an integer/number)
```

Adding strings will result in a string concatenation:
```csharp
string x = "10";
string y = "20";
string z = x + y; // Output will be 1020 (string)
```

**String Interpolation**  
Another option for string concatenation (like Python's F-strings) is string interpolation.  
It substitutes values of variables into placeholders in a string. No need to worry about spaces.

```csharp
string firstName = "John";
string lastName = "Doe";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);
```
The dollar sign, '$', must be used when using the string interpolation method.  
String interpolation was introduced in C# version 6.


**Access Strings**  
Access the characters in a string by referring to index using square brackets '[]', just like in Python.

This example prints the *first character* in *myString*:  
```csharp
string myString = "Hello";
Console.WriteLine(myString[0]); // Outputs "H"
```
String indexes start with 0: [0] is the first character. [1] is the second, etc. Just like in Python.

This example prints the *second character*:
```csharp
string myString = "Hello";
Console.WriteLine(myString[1]); // Outputs "e"
```

You can also find the index position of a specific character in a string by using the
IndexOf() method.
```csharp
string myString = "Hello";
Console.WriteLine(myString.IndexOf("e")); // Outputs "1"
```

Another useful method is Substring(), which extracts the characters from a string, starting from the
specified character position/index, and returns a new string. This method is often used together with
IndexOf() to get the specific character position.
```csharp
// Full name:
string name = "John Doe";

// Location of the letter D:
int charPos = name.IndexOf("D");

// Get last name:
string lastName = name.Substring(charPos);

// Print the result:
Console.WriteLine(lastName)
```


**Special Characters**  
Because strings must be written within quotes, C# will misunderstand the following and raise an error:
```csharp
string txt = "We are the "Vikings" of the North!";
```
To avoid this, we use the ```backslash escape character``` -> '\'.  
The backslash escape character turns special characters into string characters:

| **Escape Character** | **Result** | **Description**  |
|----------------------|------------|------------------|
| \\'                  | '          | Single quote     |
| \\"                  | "          | Double quote     |
| \\\                  | \          | Backslash        |

The sequence ```\"``` inserts a double quote in a string.
```csharp
string txt = "We are the \"Vikings\" of the North!";
```

The sequence ```\'``` inserts a single quote in the string.
```csharp
string txt = "It\'s alright.";
```

The sequence ```\\``` inserts a backslash in the string.
```csharp
string txt = "The character \\ is called backslash.";
```

**Other useful escape characters:**

| **Code** | **Result** |
|----------|------------|
| \n       | New Line   |
| \t       | Tab        |
| \b       | Backspace  |



[🏚️ Back to top](#contents)

---

### Booleans
Very often you will need a data type that can only have two values, like:
* YES / NO
* ON / OFF
* TRUE / FALSE

For this, C# has a ```bool``` data type which can take the values *true* and *false*.

**Boolean Values**  
Declared with the ```bool``` keyword, can only be *true* or *false*:
```csharp
bool isCSharpFun = true;
bool isFishTasty = false; // I don't agree with this! W3Schools did this!
Console.WriteLine(isCSharpFun); // Outputs True
Console.WriteLine(isFishTasty); // Outputs False
```
Boolean values are mostly used for conditional testing.

**Characters**  
The ```char``` data type is used to store a single character. Must be surrounded by single quotes.
```csharp
char myGrade = 'A';
Console.WriteLine(myGrade);
```

We can use the *equal to* '==' operator to evaluate an expression:
```csharp
int x = 10;
Console.WriteLine(x == 10); // Returns True because the value of x is equal to 10
```
```csharp
Console.WriteLine(10 == 15); // Returns False because 10 is not equal to 15
```

**Real life example:**  
Find out if a person is old enough to vote:  
We use the '>=' comparison operator to find out:
```csharp
int myAge = 25;
int votingAge = 18;
Console.WriteLine(myAge >= votingAge);
```

Same but different:
```csharp
int myAge = 25;
int votingAge = 18;

if (myAge >= votingAge)
{
    Console.WriteLine("Old enough to vote!")
}
else
{
    Console.WriteLine("Not old enough to vote!")
}
```

The boolean value of an expression is the basis for all C# comparisons and conditions.


[🏚️ Back to top](#contents)

---

### If .. Else
Knowing about comparison conditions from mathematics, you can also use these conditions to 
perform different actions for different decisions.

C# has the following conditional statements:
* Use ```if``` to specifyy a block of code to be executed if a specified condition is true
* Use ```else``` to specify a block of code to be executed if the same condition is false
* Use ```else if``` to specify a new condition test if the first condition is false
* Use ```switch``` to specify many alternative blocks of code to be executed

**The if statement**  
If condition is true.  
Syntax:
```csharp
if (condition)
{
    // block of code to be executed if condition is True
}
```

In the example below, we test two values to find out if 20 is greater than 18.  
If the condition is true, print some text.
```csharp
if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}
```

We can also test variables:
```csharp
int x = 20;
int y = 18;
if (x > y)
{
    Console.WriteLine("x is greater than y.");
}
```

**The else statement**  
Use if condition is false.  
Syntax:
```csharp
if (condition)
{
    // block of code to execute if condition is true
}
else
{
    // block of code to execute if condition is false
}
```
Example:
```csharp
int time = 20;
if (time < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.")
}
// Outputs "Good evening."
```

**The else if statement**  
Use ```else if``` statement to specify a new condition if the first condition is false.  
Syntax:
```csharp
if (condition)
{
    // executed if true
}
else if (condition2)
{
    // executed if condition is false and condition2 is true
}
else
{
    // executed if condition and condition2 are both false
}
```

Example:
```csharp
int time = 22;
if (time < 10)
{
    Console.WriteLine("Good morning");
}
else if (time < 20)
{
    Console.WriteLine("Good day")
}
else
{
    Console.WriteLine("Good evening")
}
// Outputs "Good evening"
```


**Short Hand If ... Else**  
The short hand of if else is known as the *ternary operator*, because it consists of three operands.  
It can be used to replace multiple lines of code with a single line.  
Often used to replace simple if else statements.  

Syntax:
```csharp
variable = (condition) ? expressionTrue : expressionFalse;
```

So instead of the above (if else statement), we can do this:
```csharp
int time = 20;
string result = (time < 18) ? "Good day." : "Good Evening.";
Console.WriteLine(result);
```


[🏚️ Back to top](#contents)

---

### Switch
Use to select one of many code blocks to be executed.  
(Useful for practice task projects where you don't want to run ALL the code every time)

Syntax:
```csharp
switch (expression)
{
    case x:
    // code block
    break;
    case y:
    // code block
    break;
    default:
    // code block
    break;
}
```

This is how it works:
* The ```switch``` expression is evaluated once
* The value is compared with the values of each case
* If there is a match, the associated block of code is executed

The example below uses weekday number to calculate weekday name:
```csharp
int day = 4;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}
// Outputs "Thursday" (day 4)

```

**The break keyword**  
When C# reaches a ```break``` keyword, it breaks out of the switch block.  
This will stop the execution of more code and case testing inside the block.  
When a match is found and the job is done, it's time for a break. No need to test more.

A break can save a lot of execution time because it it ignores the execution of the rest of the code.


**The default keyword**  
The ```default``` keyword is optional and specifies some code to run if there is no match.

Example:
```csharp
int day = 4;
switch (day) 
{
  case 6:
    Console.WriteLine("Today is Saturday.");
    break;
  case 7:
    Console.WriteLine("Today is Sunday.");
    break;
  default:
    Console.WriteLine("Looking forward to the Weekend.");
    break;
}
// Outputs "Looking forward to the Weekend."
```

---

### While Loop
Can execute a block of code as long as a specified condition is reached.  
Loops are handy because they save time, reduce errors and make code more readable.

**While Loop**  
The ```while``` loop loops through a block of code as long as a specified condition is ```True```.

Syntax:
```csharp
while (condition)
{
    // code block to be executed
}
```

In the below example the code will run over and over again as long as variable (i) is less than 5.
```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```
Do not forget to increase the variable used in the condition, otherwise the loop will never end. :P


**The Do/While Loop**  
The ```do/while``` is a variant of the ```while````loop.  
It will execute the block of code once before checking if the condition is true, then it will repeat
the loop as long as the condition is true.

Syntax:
```csharp
do
{
    // block of code to be executed
}
while (condition);
```

Below is an example. The loop will always be executed at least once, even if the condition is false,
because the code block is executed before the condition is tested:
```csharp
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
}
    while (i < 5);
```
Again, don't forget to increase the variable used in the condition, or get an endless loop.


[🏚️ Back to top](#contents)

---

### For Loop
When you know exactly how many times you want to loop through a block of code, use the ```for``` loop
instead of a *while* loop.

Syntax:
```csharp
for (statement1;; statement2; statement3)
{
    // block of code to be executed
}
```
* Statement1 is executed one time before the execution of the code block
* Statement2 defines the condition for executing the block
* Statement3 is executed every time after the block has been executed

Example:
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```
* Statement1 sets a variable before the loop starts (int i = 0)
* Statement2 defines the condition for the loop to run (i must be less than 5). If the condition is true, 
the loop will start over again, if it's false, the loop will end
* Statement3 increases a value (i++) each time the block has been executed

Another example:
```csharp
for (int i = 0; i < 10; i = i + 2)
{
    Console.WriteLine(i);
}
```


**Nested Loops**  
Placing a loop inside another loop.

The inner loop will be executed one time for each iteration of the outer loop.

Example:
```csharp
// outer loop
for (int i = 1; i <= 2; ++i)
{
    Console.WriteLine("Outer: " + i); // executes 2 times
    
    // inner loop
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine("Inner: " + j); // executes 6 time ( 2 * 3 )
    }
}
```


**The foreach loop**  
Used exclusively to loop through elements in an array (or other data sets).

Syntax:
```csharp
foreach (type variableName in arrayName)
{
    // code block to be executed
}
```

Example that outputs every element in cars array using foreach:
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars)
{
    Console.WriteLine(i);
}
```


[🏚️ Back to top](#contents)

---

### Break and Continue

**Break**  
Break can be used to break out of a ```switch``` statement, and to jump out of a loop.

Example: Jumps out of loop when i is equal to 4:
```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}
```

**Continue**  
Continue statement breaks one iteration (in the loop) if a specified condition occurs, and continues
with the next iteration in the loop.

This example skips the value of 4:
```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}
```

**Break and Continue in while loop**  
You can also use break and continue in while loops:

Break example:
```csharp
int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
    if (i == 4)
    {
        break;
    }
}
```

Continue example:
```csharp
int i = 0;
while (i < 10)
{
    if (i == 4)
    {
        i++;
        continue;
    }
    Console.WriteLine(i);
    i++;
}
```


[🏚️ Back to top](#contents)

---

### Arrays
Arrays are often used to store multiple values in one single variable, instead of declaring separate
variables for each value.

To declare an array, define the variable type with *square brackets* '[]'.

```csharp
string[] cars;
```
We have now declared a variable that holds an array of strings.  
To insert values into it, we can use an array literal - place the values in a comma-separated
list, inside curly braces.
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
```

To declare an array of integers, you could write:
```csharp
int[] myNums = {10, 20, 30, 40};
```

**Access Elements of an Array**  
You can do this using index number.  

This example accesses the value of the first element in *cars*:
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);
// Outputs "Volvo".
```
Indexes start at 0, not 1.


**Change an Array Element**  
To change the value of a specific element, refer to index number:
```csharp
cars[0] = "Opel";
```
Example:
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
cars[0] = "Opel";
Console.WriteLine(cars[0]);
// Now outputs Opel instead of Volvo
```


**Array Length**  
To find out how many *elements* an array has, use Length property.

```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars.Length);
// outputs 4
```


**Other ways to create an array**  
Can be created using the keyword ```new```. Size can also be specified.  
In C# there are different ways to create an array:
```csharp
// create an array of four elements, add values later
string[] cars = new string[4];

// create an array of four elements, add values right away
string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// create an array of four elements without specifying size
string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// create an array of four elements, omitting the 'new' keyword, and without specifying size
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
```
Choose what you like, but the last option is faster and easier to read for learning purposes.  
Note: If you declare an array and initialize later, you have to use the 'new' keyword.

```csharp
// declare an array
string[] cars;

// add values, using new
cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// add values without using new (this will cause an error)
cars = {"Volvo", "BMW", "Ford", "Mazda"};
```


**Loop Through Arrays**  
You can loop through arrays using ```for loop``` and ```Length``` property to specify how many
times the loop should run.

Example: output all elements in cars array:
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for (int i = 0; i < cars.Length; i++) 
{
  Console.WriteLine(cars[i]);
}
```


**Arrays and foreach loop**  
The ```foreach``` loop is used exclusively to loop through elements in an array.

Syntax:
```csharp
foreach (type variableName in arrayName)
{
    // code block to be executed
}
```

The following example outputs all elements in the cars array using 'foreach':
```csharp
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars)
{
    Console.WriteLine(i);
}
```
The example above can be read like this:  
"For each string element (i) in cars, print out the value of i."

If you compare the for loop and foreach loop, you will see that the foreach method is 
easier to write. It does not require a counter (using the Length property), and is more readable.


**Sort an Array**  
Many methods available, for example Sort(), which sorts an array alphabetically or in
ascending order.

```csharp
// sort a string
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}

// sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
}
```


**System.Linq Namespace**  
Other useful methods: Min, Max, Sum, can be found in the System.Linq namespace.

Example:
```csharp
using System;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = {5, 1, 8, 9};
            Console.WriteLine(myNumbers.Max()); // returns the largest value
            Console.WriteLine(myNumbers.Min()); // returns the smallest value
            Console.WriteLine(myNumbers.Sum()); // returns the sum of elements
        }
    }
}
```
And one with string interpolation for better readability:
```csharp
using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine($"Largest value: {myNumbers.Max()}");  // largest value
      Console.WriteLine($"Smallest value: {myNumbers.Min()}");  // smallest value
      Console.WriteLine($"Sum of values: {myNumbers.Sum()}");  // sum of myNumbers
    }
  }
}
```


**Multidimensional Arrays**  
Array = single dimension array.  
If you want to store data as a tabular form, like a table with rows and columns, you need to get 
familiar with *multidimensional arrays*.  

A 'ma' is basically an array of arrays (list of lists?)  
Arrays can have a number of dimensions. The most common are two-dimensional arrays (2D).

**Two-Dimensional Arrays**  
To create a 2D array, add each array within its own set of curly braces, and insert a comma inside the square brackets.
```csharp
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
```
Good to know:  
The single comma [,] specifies that the array is two-dimensional.  
A three-dimensional array would have two commas: int[,,]

```numbers``` is now an array with two arrays as its elements. The first array element contains
three elements: 1, 4, 2, while the second array element contains 3, 6, 8.  

To visualize, think of the array as a table with rows and columns:

|       | COLUMN 0 | COLUMN 1 | COLUMN 2 |
|-------|----------|----------|----------|
| ROW 0 | 1        | 4        | 2        |
| ROW 1 | 3        | 6        | 8        |


**Access Elements of a 2D Array**  
To access an element in a 2DA you must specify two indexes: one for thearray, one for the element in the array.  
Or better yet with the table visualization in mind: one for the row, one for the colun.

This example accesses the value of the element in the first row(0) and third column(2):
```csharp
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
Console.WriteLine(numbers[0, 2]); // outputs 2
```
Remember that: Array indexes start with 0: [0] is the first element. [1] is the second element, etc.


**Change Elements of a 2D Array**  
You can also change the value of an element.

Example: Change value of element in first row, first column:
```csharp
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
numbers[0, 0] = 5; // change value to 5
Console.WriteLine(numbers[0, 0]); // outputs 5 instead of 1
```


**Loop Through a 2DA (2D Array)**  
You can easily loop through the elements of a 2DA with a foreach loop.

Example:
```csharp
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

foreach (int i in numbers)
{
    Console.WriteLine(i);
}
```
You can also use a for loop. For multi-dim arrays you need one loop for each of the array's dimensions.

Also note that have to use GetLength() instead of Length to specify how many times the loop should run.

Example:
```csharp
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.WriteLine(numbers[i, j]);
    }
}
```


[🏚️ Back to top](#contents)

---

### Methods
A *method* is a block of code which only runs when it is called (like functions in Python).  
You can pass data, known as parameters, into a method (like functions in Python).  
Methods are used to perform certain actions, and they are also known as *functions*.


**Create a Method**  
A method is defined with the of the method, followed by parentheses. C# provides some pre-defined
methods, such as Main(), but you can create your own.

Example:
```csharp
class Program
{
    static void MyMethod()
    {
        // code to be executed
    }
}
```
Explained:
* ```MyMethod()``` is the name of the method
* ```static``` means that the method belongs to the Program class and not an object of the Program class.
* ```void``` means that this method does not have a return value

Note: In C# it is good practice to start with an uppercase letter when naming methods,  
as it makes code easier to read (PascalCase)


**Call A Method**  
To call (execute) a method, write the method's name followed by () and ;

Example:
```csharp
static void MyMethod() 
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();
}

// Outputs "I just got executed!"
```

A method can be called multiple times.

Example:
```csharp
static void MyMethod() 
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();
  MyMethod();
  MyMethod();
}

// I just got executed!
// I just got executed!
// I just got executed!
```


**Method Parameters**  
