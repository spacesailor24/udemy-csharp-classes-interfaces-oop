# C# Intermediate: Class, Interface, and OOP

[**Udemy Course Link**](https://www.udemy.com/csharp-intermediate-classes-interfaces-and-oop/learn/v4/content) - https://www.udemy.com/csharp-intermediate-classes-interfaces-and-oop/learn/v4/content

## Table of Contents

Lecture Topic | Link
--- | ---
General Notes | [General Notes](#general-notes)
**SECTION 2** | [**Section 2**](#section-2)
Introduction to Classes | [Lecture 6](#section-2-lecture-6)

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