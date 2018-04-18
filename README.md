# C# Intermediate: Class, Interface, and OOP

[**Udemy Course Link**](https://www.udemy.com/csharp-intermediate-classes-interfaces-and-oop/learn/v4/content) - https://www.udemy.com/csharp-intermediate-classes-interfaces-and-oop/learn/v4/content

## Table of Contents

Lecture Topic | Link
--- | ---
General Notes | [General Notes](#general-notes)
**SECTION 2** | [**Section 2**](#section-2)
Introduction to Classes | [Lecture 6](#section-2-lecture-6)
Constructors | [Lecture 7](#section-2-lecture-7)
Object Initializers | [Lecture 8](#section-2-lecture-8)
Methods | [Lecture 9](#section-2-lecture-9)
Fields | [Lecture 10](#section-2-lecture-10)
Access Modifiers | [Lecture 11](#section-2-lecture-11)

## General Notes

<!-- ################################################################################################################ -->
<!--                                                     SECTION 2                                                    -->
<!-- ################################################################################################################ -->

## SECTION 2

### Section 2 Lecture 6

#### Introduction to Classes

[**Code Example**](Classes/Program.cs)

- A `class` is a building block for an application

#### Anatomy of a Class

- Data (represented by fields)
- Behaviour (represented by methods/functions)

#### UML - Unified Modeling Language e.g.

![Unified Modeling Language Example](img/uml_class_example.png?raw=true "Unified Modeling Language Example")

In the above example,

- `Name`
- `Age`
- `Height`
- `Weight`

are **fields** defined for the `Person` class, while

- `Walk()`
- `Talk()`
- `Eat()`
- `Sleep()`

are **methods** defined for the `Person` class.

- An `Object` is an instance of a `class`

![UML Class and Object](img/uml_class_object_example.png?raw=true "UML Class and Object")

- Declaring a `class`:

```csharp
public class Person
{
    public string Name;

    public void Introduce()
    {
        Console.WriteLine("Hi, my name is " + Name);
    }
}
```

#### Naming Conventions

- PascalCase: used for naming `class`es and `method`s in C# e.g.

```csharp
public class ThisIsMyClass
{
    // ...
}
```

- camel Case: used for name `parameter`s passed to `method`s

```csharp
ThisIsMyClass(thisIsMyParameter);
```

Creating Objects

```csharp
Person person = new Person();

// OR

var person = new Person();
```

#### Using Objects

```csharp
var person = new Person();

person.Name = "Anon";
person.Introduce();
```

#### Class Members

- Instance: accessible from an `object`

```csharp
var person = new Person();

person.Introduce();
```

- Static: accessible from the `class`

```csharp
Console.WriteLink();
```

#### Why use Static members?

- Used to represent concepts that are **singleton** i.e. things that should **only have ONE** instance of in memory e.g.:

```csharp
Datetime.Now(); // There should only be one DateTime instance

Console.WriteLine(); // There should only be one Console
```

#### Defining Static Members

```csharp
public class Person
{
    public static int PeopleCount = 0;
}
```

### Section 2 Lecture 7

#### Constructors

[**Code Example 1**](Constructors/Program.cs)
[**Code Example 2**](Constructors/Customer.cs)
[**Code Example 3**](Constructors/Order.cs)

- A `constructor` is a `method` that is called when an instance of a `class` is created

#### Why?

- To put an `object` in an early state (i.e. to intialize some of the `field`s in a `class`)

```csharp
public class Customer
{
    public Customer() // This is a constructor, and it MUST have the same name as the class it's constructing
    {
        // ...
    }
}
```

```csharp
public class Customer
{
    public string Name;

    public Customer(string name)
    {
        this.Name = name; // this in this.Name references the current object
    }
}

// The above can be used like so: var customer = new Customer("John");
```

#### Constructor Overloading

- Have a `method` with the same name, but with different `parameter`s

```csharp
public class Customer
{
    public Customer() {...}

    public Customer(string name) {...}

    public Customer(int id, string name) {...}
}
```

### Section 2 Lecture 8

#### Object Initializers

- A syntax for quickly initializing an `object` without the need to call one of its `constructor`s
- This avoids needing to create multiple `constructor`s

```csharp
var person = new Person
            {
                FirstName = "Greatest",
                LastName = "Ever"
            };
```

### Section 2 Lecture 9

#### Methods

[**Code Example 1**](Methods/Program.cs)
[**Code Example 2**](Methods/Calculator.cs)
[**Code Example 3**](Methods/Point.cs)

#### Signature of a Method

- Name
- Number and Type of parameters

```csharp
public class Point
{
    public void Move(int x, int y) {} // Move, int x, int y are the signatures of this method
}
```

#### The Params Modifier

```csharp
public class Calculator
{
    public int Add(params int[] numbers) {...}
}

var result = calculator.Add(new int[]{1, 2, 3, 4}); // This is the standard way of doing it
var result2 = calculator.Add(1, 2, 3, 4) // This is what params modifer lets us do
```

#### The Ref Modifier

```csharp
public class MyClass
{
    public void MyMethod(ref int a)
    {
        a += 2;
    }
}

var a = 1;
MyClass.MyMethod(ref a);
// Because the red modifier is used in MyMethod, the reference to var a will be passed, and when
// a += 2 happens the value of var a will actualy be updated - This is NOT standard behvaiour, without the ref modifier,
// parameter a in MyMethod will just be a local version of the passed parameter var a.
```

#### The Out Modifier

- The `out` modifier will return the value of the `parameter` back to the caller of the method

```csharp
public class MyClass
{
    public void MyMethod(out int result)
    {
        result = 1;
    }
}

int a;
MyClass.MyMethod(out a);

Console.WriteLine(a); // Will output 1
```

### Section 2 Lecture 10

#### Fields

[**Code Example 1**](Fields/Program.cs)
[**Code Example 2**](Fields/Customer.cs)

#### Initialization

```csharp
public class Customer
{
    List<Order> Orders = new List<Orders>();
}
```

#### Read-only Fields

- Allow a `field` for a `class` to be initialized only **once**

```csharp
public class Customer
{
    readonly List<Order> Orders = new List<Order>();
}
```

### Section 2 Lecture 11

#### Access Modifiers

[**Code Example**](AccessModifiers/Program.cs)

An Access Modifier is a way to control access to a `class` and/or its `member`s

C# has five:

- Public
- Private
- Protected
- Internal
- Protected Internal

They are used to create safety in programs e.g.

```csharp
public class Customer
{
    private string Name;
}

var john = new Customer();

john.Name; // won't compile, because Name cannot be accessed outside of the Customer class
```

#### Encapsulation (in practice)

- Define `field`s as `private`
- Provide `getter`/`setter` `method`s as `public`

```csharp
public class Person
{
    private string _name; // private fields should start with an _ and use camelCase

    public void SetName(string name)
    {
        if (!String.IsNullOrEmpty(name))
            this._name = name;
    }

    public string GetName()
    {
        return _name;
    }
}
```