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
Properties | [Lecture 12](#section-2-lecture-12)
Indexers | [Lecture 13](#section-2-lecture-13)
Class Coupling | [Lecture 16](#section-3-lecture-16)
Inheritance | [Lecture 17](#section-3-lecture-17)
Composition | [Lecture 18](#section-3-lecture-18)
Favor Composition over Inheritance | [Lecture 19](#section-3-lecture-19)

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

### Section 2 Lecture 12

#### Properties

[**Code Example 1**](Properties/Program.cs)
[**Code Example 2**](Properties/Person.cs)

- Properties are a `class member` that encapsulates a `getter`/`setter` for accessing a `field`
- Allows for creating a `getter`/`setter` with less code

```csharp
public class Person
{
    private DateTime _birthdate;

    public DateTime Birthdate
    {
        get { return _birthdate; }
        set { _birthdate = value; }
    }
}
```

#### Auto-implemented Properties

```csharp
public class Person
{
    public DateTime Birthdate { get; set; }
}
```

### Section 2 Lecture 13

#### Indexers

[**Code Example 1**](Indexers/Program.cs)
[**Code Example 2**](Indexers/HttpCookie.cs)

- An Indexer is a way to access `element`s in a `class` that represents a `list` of values

```csharp
var array = new int[5];
array[0] = 1;

var list = new List<int>();
list[0] = 1;
```

```csharp
var cookie = new HttpCookie();
cookie.Expire = DateTime.Today.AddDays(5);

cookies["name"] = "Wyatt"; // Method 1
cookie.SetItem("name", "Wyatt"); // Method 2

var name = cookie.["name"]; // Method 1
var name2 = cookie.GetItem("name"); // Method 2
```

#### Creating an Indexer (it's nothing more than a property!)

```csharp
public class HttpCookie
{
    public string this[string key]
    {
        get {...}
        set {...}
    }
}
```

<!-- ################################################################################################################ -->
<!--                                                     SECTION 3                                                    -->
<!-- ################################################################################################################ -->

## SECTION 3

### Section 3 Lecture 16

#### Class Coupling

- Class coupling is a measure of how interconected `class`es and subsystems are

#### Tightly Coupled Design

This is a bad design, because there is a higher chance to break code down stream by updating code

![Tightly Coupled Design](img/tightly_coupled_design_example.png?raw=true "Tightly Coupled Design")

#### Loosely Coupled Design

This is a better design, because it allows for code to be changed without affecting the rest of the application

![Loosely Coupled Design](img/loosely_coupled_design_example.png?raw=true "Loosely Coupled Design")

Loosely Coupled Design utilizes:

- Encapsulation
- The relationship between `class`es
- `interfaces`

#### Types of Relationships

- Inheritance
- Composition

### Section 3 Lecture 17

#### Inheritance

#### What is Inheritance

- A kind of relationship between two `class`es that allows one to `inherit` code from the other
- **Is-A** relationship
- Ex: A Car **is a** Vehicle

Benefits of using **Inhertiance**:

- Code re-use
- Poloymorphic behaviour

Using **Inheritance** allows the **encapsulation** of code to be used in multiple places

If you were to design an application like PowerPoint, you could utilize **inhertiance** when creating the code for the different object you put onto a slide. For example, Text, Table, Image can all **inherit** from a `PresentationObject`

![UML Inheritance](img/uml_inheritance.png?raw=true "UML Inheritance")

The `PresentationObject` would be known as the **Parent/Base class** or **Super class**
And the `Text`, `Table`, and `Image` classes would be known as **Child/Derived class** or **Sub class**

```csharp
public class PresentationObject
{
    // Common shared code
}

public class Text : PresentationObject
{
    // Code specific to Text
}
```

### Section 3 Lecture 18

#### Composition

#### What is Composition

- Composition is a kind or relationship between two `class`es that allows one to contain the other
- `Has-A` relationship
- Example: Car `has an` Engine

#### Benefits

- Code re-use
- Flexibility
- A means to obtaining loose-coupling

![UML Composition](img/uml_composition_example.png?raw=true "UML Composition")

```csharp
public class Installer
{
    private Logger _logger;

    public Installer(Logger logger)
    {
        _logger = logger;
    }
}
```

### Section 3 Lecture 19

#### Favor Composition over Inheritance

#### Problems with Inheritance

- Easily abused
- Large hierarchies
- Fragility
- Tighlty coupling

Here is an example of Inheritance:

![UML Inheritance Bad Example 1](img/uml_inheritance_bad_example1.png?raw=true "UML Inheritance Bad Example 1")

Now there is a problem if we decide to create `class Goldfish`:

![UML Inheritance Bad Example 2](img/uml_inheritance_bad_example2.png?raw=true "UML Inheritance Bad Example 2")

Since a `Goldfish` cannot walk, we are forced to create `class Mamal` that `Person` and `Dog` can inherit from.

Alternatively, you can recreate the above by using **Composition**:

![UML Composition Good Example 1](img/uml_composition_good_example.png?raw=true "UML Composition Good Example 2")

Now if we needed to implement a new action for walking that both `Person` and `Dog` were going to utilize, we could create a new `class Walkable`:

![UML Composition Good Example 2](img/uml_composition_good_example2.png?raw=true "UML Composition Good Example 2")

And if we added the `class Goldfish` we could without having to refactor the logic assocaited with the `class Walkable`:

![UML Composition Good Example 3](img/uml_composition_good_example3.png?raw=true "UML Composition Good Example 3")

Lastly, if we needed to add swim logic to the `class Goldfish` we could do so by creating `class Swimmable`:

![UML Compositon Good Example 4](img/uml_composition_good_example4.png?raw=true "UML Composition Good Example 4")