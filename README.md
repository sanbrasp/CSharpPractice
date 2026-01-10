# C# Practice
A collection of c# practice tasks.

---

Project created for personal use for the journey of learning C#.

---

.gitignore:  
See .gitignore for source used

---

## Contents
- [About](#about)
- [Useful notes for a new learner](#useful-notes)
  - [Main](#main)
  - [WriteLine](#writeline)
  - [Write](#write)
  - [Comments](#comments)
  - [Variables and Types](#variables-and-types)

---

## Useful sources
[W3 Schools - C#](https://www.w3schools.com/cs/)  
[C# Documentation - Microsoft](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)  
[Gitignore Template](https://github.com/github/gitignore/blob/main/VisualStudio.gitignore)

---

## About

I decided to split the practice lessons up into two parts:  
Traditional (class, main) and  
Top-Level Statements

To start with I will be focusing on learning traditional, and I am aware that something isn't working  
in Program.cs of "top_level_statements" project - I will get to that.

~~I realize I will need most practice figuring out traditional, which is why I decided to focus on that first.~~
It appears I might have fixed this now.

---

## Useful notes
Coming from Python to C# one of the first things I noticed was the pretty intense increase in
verbosity. There is SO much text!!!  

I will be adding notes and things here that I found useful while trying to navigate this new language 
and understand how it's built.

---

### Main
Main is the entrypoint that executes your code in traditional C# programming.

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
