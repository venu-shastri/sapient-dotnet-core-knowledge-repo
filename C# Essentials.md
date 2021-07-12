

- C# - Dotnet Core -> Platform independent
- C# Compilers
  - **Dotnet Fx - Compiler**
  - Dotnet Core - Roslyn Compiler from Dotnet Foundation

### C# Role - Dotnet Framework / Dotnet Core

---

- C# Compiler generates MSIL Code

  - MSIL Code Generator
  - Macro Processor

  

```C#
// CSharp Code
public class A
{
	public static void Main()
	{
		
	}
}


```

```C#


Microsoft (R) .NET Framework IL Disassembler.  Version 4.0.30319.33440
//  Copyright (c) Microsoft Corporation.  All rights reserved.


// 



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly r0pzzpax
{
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module r0pzzpax.dll
// MVID: {1AB44607-E0AC-451F-9586-A13B41E7700D}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x01050000


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit A
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Main() cil managed
  {
    // 
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method A::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // 
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method A::.ctor

} // end of class A


// =============================================================

// 
// 

```



### C# Learning Curve

---

- Given C# Code - What is the equivalent MSIL Code Generated
- Object Oriented Programming using C# Constructs

### C# Program Structure

---



```c#
// Test.cs
namespace <NameSapceName>{
    //User Defined DataTypes
    class <ClassName>{
        //Members
    }
    struct <StructName>{
        //members
    }
    interface <InterfaceName>{
        //members
    }
    enum <EnumName>{
        //members
    }
}
```

#### Object Oriented Paradigm

----

> Paradigm ? - Its a **Style** or **way** of programming.
>
> *A paradigm is a way of* **doing** **something (like programming), not a concrete thing (like a language).**
>
> A given Language can support multiple paradigms
>
> What about C# ?
>
> - Object Oriented
> - Event-Based / driven
> - AOP 

#### Object Oriented Paradigm

---

Programming by defining objects that send messages to each other. Objects have their own internal (encapsulated) state and public interfaces.





## Object

- SPACE

  - How much Space? 

- Analogy 

  - House  - Objects (Object - Space)
    - Window  - (ventilation)
      - Height , Width , Thickness , Color , Partitions
      - Open , Close ,Slide
  - Program  - Objects

- Object -> "Certain Role"

  - "Responsibilities"
    - "State/DataMember/Properties" and "Behavior/methods"

  

  > Current Software Project - Management  - List out Objects - Roles and Responsibilities
>
  > 1. Developer - Coding , Review , Document , Requirement Analysis,Unit Testing , Bug Fixing
> 2. Product Owner :- Requirement Engineering ,
  > 3. Devops Engineer : 



### Object Oriented Design

----

1. Identify Valid Objects - "Define Role and Assign Responsibilities" - "**Encapsulation**"  - "Classification/Description of Object state and Behavior"

   > How to define/express encapsulation  in Programming Language : "User Defined Data Types"
   >
   > What is DataType ?
   >
   > Define "Domain Of Value"  : "State and Behavior"
   >
   > S/w Program = Algorithm + Data , Data Represents Value 
   >
   > DataType Classification  : 
   >
   > - Built-in/Primitive/Basic DataTypes (Domain of Value  is Predefined by Language Author or Domain of Value well understood by Compiler ) . Borrowed from Mathematics (number,char ,alphanumeric, whole number, real number)
   >
   >   - Ex:- 
   >
   >     ```c#
   >     int x; // x resresents value from Number , Size and Range , convert,parse
   >     char c; // c represents value from Charcters 
   >     student std;//Domain Unkonwn
   >     ```
   >
   >     
   >
   > - User Defined Datatype :  Programmer Defined Datatype 
   >
   >   - ex:- Add 10 and 20 
   >   - Add Customer
   >     - Banking Domain
   >     - Retail Domain
   >   - ex: Add new student to C# Training course
   >     - data : student  {id,name,photo,}
   >     - Describe Domain Of Student based on Philips Learning and Development Team inputs 
   >
   > - Encapsulating Object  using C# Constructs
   >
   >   - User Defined Datatype
   >     - "**Class**"
   >     - "**Struct**"



### Object and Memory

---

- Object State occupy memory
- Data Structures
  - Stack 
    - short lived  (Method Execution)
    - Auto Clean up
    - Thread Safe
  - Heap 
    - Lifetime Dynamic (program Algorithm)
    - Explicit Memory Management
    - Not Thread safe 
      - explicit Thread Synchronization Mechanism
  - Static area
    - Application Lifetime

#### Class v/s Struct



| Class                     | struct                                                       |
| ------------------------- | ------------------------------------------------------------ |
| Object -> Heap            | Object -> stack,heap,static                                  |
| MSIL -> ReferenceType     | MSIL - > Value Type                                          |
|                           | C# Built-in Types are struct  (int,float,char, double....) <br /> int x; //   Int x=new Int(); |
| Pass By Reference Default | Pass By Value  (Default)                                     |



### Class -  user defined type

----

> "class" C# keywod generates "ReferenceType" in MSIL

```C#
//Encapsulation 
<AccessModifier> class <RoleName>{

    //Responsibilities
    /*
    Fields
    Properties
    Initializers
    Indexers
    events
    Nested Types
    */

}

Ex:-
    //RoleName :- Noun
class Student{
    
    
}    
    
```



### Assignment

| Object              | Role                     | Responsibilities                                         | State(Data Members)                                  | Behavior(Operations) | Events |
| ------------------- | ------------------------ | -------------------------------------------------------- | ---------------------------------------------------- | -------------------- | ------ |
| TDSDataModel        | Information Holder       | Classify/Describe TDS Data                               | Trade ID, Date, Current trade value, Counterparty ID | Nill                 |        |
| RDSDataModel        | Information holder       | Classify/Describe RDS Daat                               | CounterPartyId,<br />Name                            | Nill                 |        |
| RiskCalculator      | Business Logic Processor | Calculate Risk                                           |                                                      | Calculate()          |        |
| RiskInputDataMerger | Data Mapper              | Combine RDS and TDS Data and Generates RiskInpuDataModel |                                                      | Merge()              |        |
| RiskInputDataModel  | Information Holder       | Classify/Descibe Risk Calculator input Data              |                                                      |                      |        |

Model Design Decisions Using Modeling Language - UML (class Diagram , Object Diagram ,Sequence Diagram,Relationships (Inheritance,Association, Aggregation , Composition))

### Development 

____

- IDE :- Integrated Development Environment

  - Visual Studio

- Framework

  

| IDE Version | Framework Support |
| ----------- | ----------------- |
| 2003        | 1.1               |
| 2005        | 2.0               |
| 2008        | 3.0               |
| 2010        | 3.0/3.5           |
| 2013        | 4.0               |
| 2015        | 4.5               |
| 2017        | 4.6               |
| 2019        |                   |

### Framework Installation Location

> C:\Windows\Microsoft.NET\Framework(64)

### Dotnet Application BuildingBlocks

---

- Components -> Assemblies (executable/Library Image)
  - .exe
  - .dll 
- Solution
  - Project...1
    - Build Output
      - Component/Assembly (.exe/.dll)
  - Project...2
    - Build Outpue
      - Component/Assembly (.exe/dll)
  - Project...3
    - Component/Assembly (.exe/dll)
  - Project....n
    - Component/Assembly (.exe/dll)
- exe vs dll
  - Components - Windows Operating System
  - exe -> outprocess Components
  - dll -> InProcess Components
- .exe - ConsoleApplication template
- .dll - ClassLibrary template



### Assembly

---

- Basic unit of  execution - CLR(Virtual Machine)

- Assembly Contains Module

- Module Contains MSIL, Metadata , Manifest

- Assembly - Identity

  - "String" -   "NameOfTheAssembly,Version=Major.Minor.Build.Revision,PublicKey=Null /160 Bytes,Culture=language-region (Netural - default from OS )"

  - Metadata or Manifest holds - Assembly Identity

    

```
//From Metadata - FinancialRiskCalculatorApp.exe
Assembly
-------------------------------------------------------
	Token: 0x20000001
	Name : FinancialRiskCalculatorApp
	Public Key    :
	Hash Algorithm : 0x00008004
	Version: 1.0.0.0
	Major Version: 0x00000001
	Minor Version: 0x00000000
	Build Number: 0x00000000
	Revision Number: 0x00000000
	Locale: <null> //Culture - OS Culture

```

> By Default Assembly Identity token -  Public key value is null
>
> "Digital Signed Assembly will have public key"
>
> "Strong Name" :- Assembly Identity -with pubic key value
>
> "Digital Signed Assembly will have strong name identity"



#### .Net Application Deployment

----

- Target Machine -  .Net fx must be installed

- Dependency Location

- | Strong Name based Dependency                                 | Dependency Without Strong Name                               |
  | ------------------------------------------------------------ | ------------------------------------------------------------ |
  | Location - GAC (Global Assembly Cache) / Application Folder  | Location - Application Folder                                |
  | Public Assembly Deployment                                   | Private Assembly Deployment                                  |
  | Assembly visibility -> System                                | Assemblies Visibility restricted to folder                   |
  | GAC Location : "C:\Windows\Microsoft.NET\assembly"<br />gacutil.exe | Ex:- RisckCalculator.dll is now known as private assembly  of - FinancilaRiskCalculator.exe |
  | One Instance of Deployment ,Side By Side Installation Support,Strict Version Check, Single point/location upgradation(easy redirection from one version to another) | Private Assembly Advantages : Simple Deployment , Each Application Will have its own copy dependency. |
  | Deployment Challenge : GAC expects strong name based assembly, Requires admin rights. | Deployment Challenges : No Strict Version Checking (No Backward compatibility). No Side By Side Installation Support by Default (Private probing Path), Upgradation Issues ex:- if multiple apps using same library and deployed using different folder structure , then each app will have its own private copy of lib. if Existing apps like to redirect from old version of lib to new version of Lib ...? cost of upgradation |

  

#### why GAC need StrongName?

----

GAC Folder Structure

- ```
  D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\1.0.0.0>gacutil -i RiskCalculatorLib.dll
  Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
  Copyright (c) Microsoft Corporation.  All rights reserved.
  
  Failure adding assembly to the cache: Attempt to install an assembly without a strong name
  ```

- After Signing

- ```
  D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\1.0.0.0>gacutil -i RiskCalculatorLib.dll
  Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
  Copyright (c) Microsoft Corporation.  All rights reserved.
  
  
  Assembly successfully added to the cache
  
  GAC Folder
  	Folder < using Assembly Name From The Strong Name>
  	   Folder <using Version and Hash(Public Key)= PublicKeyToken (8 Bytes)>
  	      DLL File
  	      
  "C:\Windows\Microsoft.NET\assembly\GAC_MSIL\RiskCalculatorLib\v4.0_1.0.0.0__43ba8707d0c5610b\RiskCalculatorLib.dll"
  
  eX: GAC_MSIL
  		RiskCalculatorLib
  		   1.0.0.0_43ba8707d0c5610b
  		       RiskCalculatorLib.dll
  		       
  D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\2.0.0.0>gacutil -i RiskCalculatorLib.dll
  
  "C:\Windows\Microsoft.NET\assembly\GAC_MSIL\RiskCalculatorLib\v4.0_2.0.0.0__43ba8707d0c5610b\RiskCalculatorLib.dll"
  GAC_MSIL
  		RiskCalculatorLib
  		   1.0.0.0_43ba8707d0c5610b
  		       RiskCalculatorLib.dll
  		   2.0.0.0_43ba8707d0c5610b
  		   	   RiskCalculatorLib.dll
  		      
  ```

  

#### Assembly Signing

---

1. Key Pair (public key (Big Prime Number- 160 Bytes of Data) and Private Key)

   1. use test key pair .....generated from sn.exe
   2. generated key pair can be stored in - .snk files

2. Hash (Assembly Contents) -> Message Digest

3. Encrypt (Message Digest) using Private Key => Signature

4. Save Signature + Public Key in  Assembly [ Public Key Used to verify Signature and part of assembly identity]

   > Go to project Properties -> enable signing option > choose key pair file- > Rebuild

```
//Use SN.exe tool to verify Assembly Strong Name
D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\1.0.0.0>sn -v RiskCalculatorLib.dll

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

RiskCalculatorLib.dll does not represent a strongly named assembly
```

> ```
> //Use Dumpbin.exe tool to dup CLRHEADER
> 
> D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\1.0.0.0>dumpbin /CLRHEADER RiskCalculatorLib.dll
> Microsoft (R) COFF/PE Dumper Version 14.27.29111.0
> Copyright (C) Microsoft Corporation.  All rights reserved.
> 
> 
> Dump of file RiskCalculatorLib.dll
> 
> File Type: DLL
> 
>   clr Header:
> 
>               48 cb
>             2.05 runtime version
>             206C [     600] RVA [size] of MetaData Directory
>                1 flags
>                    IL Only
>                0 entry point token
>                0 [       0] RVA [size] of Resources Directory
>                0 [       0] RVA [size] of StrongNameSignature Directory
>                0 [       0] RVA [size] of CodeManagerTable Directory
>                0 [       0] RVA [size] of VTableFixups Directory
>                0 [       0] RVA [size] of ExportAddressTableJumps Directory
>                0 [       0] RVA [size] of ManagedNativeHeader Directory
> ```



#### Post Signing

---



```
D:\knowledge\csharp-knowledge\Samples\RiskCalculatorLib\bin\Debug\1.0.0.0>ildasm RiskCalculatorLib.dll

Assembly
-------------------------------------------------------
	Token: 0x20000001
	Name : RiskCalculatorLib
	Public Key    : 00 24 00 00 04 80 00 00  94 00 00 00 06 02 00 00  00 24 00 00 52 53 41 31 
                      : 00 04 00 00 01 00 01 00  b5 5e 2f 0d 2c 8a 06 2d  86 11 6c 9e ca a5 0a c4 
                      : 69 17 3c 7d 3e 5a a1 fe  01 f6 58 db b5 51 b5 82  dd 2b 2c b2 ac 6b 09 12 
                      : f8 b8 31 59 f8 92 c3 5d  63 a5 ff 57 51 e8 a6 05  01 3b 03 82 13 02 c9 9e 
                      : 85 12 7c 09 64 8d 6c b8  4d 6e 53 6b 71 cf 67 f8  2d e9 55 cf 2d 06 f8 b3 
                      : 65 ec 30 cb 3d 9b 00 23  88 43 cb 30 f6 b8 b7 72  23 52 56 70 1d bf d8 02 
                      : 73 eb a0 1a c8 4c eb 23  0a 99 ca 86 96 11 0a bb 
	Hash Algorithm : 0x00008004
	Version: 1.0.0.0
	Major Version: 0x00000001
	Minor Version: 0x00000000
	Build Number: 0x00000000
	Revision Number: 0x00000000
	Locale: <null>

```

### Object Oriented Programming Using  C#

----

### Access Modifiers / Visibility Setters

- private - (local to type (class,struct))
- protected - (type and family)
- internal - (local to assembly )
- protected internal (protected or internal)
- public (Unrestricted)

### Keywords

----

> class , struct , interface , enum, static , cost , readonly , ref , out , params , is , as , delegate , event , var , private, public , internal, protected , public , virtual, abstract , override , sealed 



##### static

-----

- data Member
- functions 

```c#
//ReferenceType
public class A{
    public static int x; //static data Member
    public int y;//Non static Data Member
    public B obj_b=new B(); // heap allocation
    public static void Fun(){ /* Member Function */
       B newobj_b=new B();//Stack Allocation
        
    }
}
//ValueType - stack
public struct B{
    public static int xx; //static data Member
    public int yy;//Non static Data Member
   public static void Foo(){ /* Member Function */
    
    
}

public class MainClass{
    //Thread - Execution Path , Function Centric
    public static void Main(){
        
        A obj=new A();//TypeLoad
        obj.y=30;
        A obj2=new A();
        obj.y=50;
        A obj3=new A();
        obj.y=100;
        
        A.x=10;
        A.x-20;
        A.x=30;
        
        B bObj=new B();//stack allocation
        bObj.xx=100;

        
    }
}
    /* In the above example obj,obj2,obj3 will be allocated on Heap because "type A is a reference type" . "bObj" will be allocated on current thread stack because "B is a value type"
    
    
    class BankAccount{
    static string IFSCCode 
    string accountNumber;
    string accountType;
    double balance;
    double minBalance;
    
    }
    // N number of BankAccount Objects
    BankAccount instance1=new BankAccount();
        BankAccount instance2=new BankAccount();
            BankAccount instance3=new BankAccount();
                BankAccount instance4=new BankAccount();  
                BankAccount instance5=new BankAccount();
    
  public class A{
  int x=10;
  //compiler - public void Fun(readonly A this){}
  public void Fun(){
  
  //require access -> member x

  
  }
  //public void Foo(int x, string y, readonly A this)
  public void Foo(int x,string y){}
  
  }
  
  public static  void DoWork(){
  
  }
  class B{
  
  static void Main(){
  
  A obj=new A();
  obj.Fun();
  
  }
  
  
```

|                        | Static Data Member             | Non Static Data member                      |
| ---------------------- | ------------------------------ | ------------------------------------------- |
| Life Time              | Process                        | Object Lifetime                             |
| Memory Allocation Time | **Class/Type Load              | Instantiate                                 |
| Allocation frequency   | Once                           | per object                                  |
| Reference              | TypeName.StaticDataMemeberName | objectReference.MemberName                  |
| Memory Location        | Static Area (Pinned table)     | ReferenceType = Heap<br />ValueType = Stack |

> **Class/Type Load  :-  First ever interaction between thread and datatype



##### static functions/behaviors



|                       | Static Function          | Non Static Function                |
| --------------------- | ------------------------ | ---------------------------------- |
| has "this" argument   | N.A                      | yes                                |
| Data Members - Access | Static Data Members Only | Static and Non Static Data members |
| Invocation            | ClassName.MethodName()   | ObjectReference.MethodName()       |
|                       |                          |                                    |



#### Initializers / Constructors

---

- Special function 

  - function name same as class/struct name

  

- Initialize Data members of the class , when the object created and before it is in use 

- Use Constructor to initialize data members of   Immutable Object

- Data Members

  - static data members
    - static initializer / Constructor
  - Non Static Data members 
    - Non Static initializer / Constructor

- Classification Of Initializers

|                     | Static Initializer              | Non Static Initializer |
| ------------------- | ------------------------------- | ---------------------- |
| has "this"          | N.A                             | yes                    |
| Explicit Call       | implicit Call                   | Explicit Call          |
| Execution Time      | Type/Class Load                 | Instantiation          |
| Visibility          | Private (default)               | Set by Programmer      |
| Overloading         | Not Supported ...zero arguments | Overloaded             |
| Member Access       | Static Members                  | Static/Non Static      |
| Execution Frequency | Only Once                       | Per Instantiation      |

```C#
public class Patient{

    string mrn,name,email;
    string contactNumber;
    public static void SayHello(){
        
        System.Console.WriteLine('Hi from Static SayHello');
    }
	//default Constructor , explicit Call 
	private Patient(){
		System.Console.WriteLine("Default Constructor");
        this.mrn=Patient.GetAutoGenreratedMrn();
	} 
    //overload Constructor
    public Patient(string name):this(){
        this.name=name;

    }
    public Patient(string name,string email):this(name){
        this.email=email;
    }
    public Patient(string name,string contactNumber):this(name)
    {
        this.contactNumber=contactNumber;
        
    }
    public Patient(string name,string contactNumber,string email):this(name){
        this.contactNumber=contactNumber;
        this.email=email;
    }
	 // static initializer , implicit Call
	static Patient(){
	System.Console.WriteLine("Static  Constructor");
	}
    static string GetAutoGenreratedMrn(){
        System.Random _random=new System.Random();
       int number= _random.Next();
        string _newMrnValue="MRN"+number;
        return _newMrnValue;
    }
}
public class A
{
	public static void Main()
	{

        Patient.SayHello();
		Patient obj=new Patient("tom");//Overloaded Constructor Call
		Patient newObj=new Patient("hary");//Overloaded Constructor Call
	}
}



```

> Explore Singleton instance pattern

```C#
public class ICU{

	private static ICU instance=null;
	static ICU(){
        instance=new ICU();
	
	}
    private ICU(){} //private constructor
    
    public static  ICU GetInstance(){
        return ICU.instance;
    }
    
}

Main(){
    
    //ICU obj=new ICU();//Error- InAccessible due to protection level
    ICU obj=ICU.GetInstance();//Typeload - Static Initializer Invoked + ICU instantiated 								+ Returns instance reference,
    ICU obj2=ICU.GetInstance();//returns existing instance reference;
    
}

 
```



### const and readonly

> const : An identifier whose value never change , compile time initialized identifier



```C#
public class Account{
 //const int MINBALANCE; Error , const variables must be intiatilezed @compile time
public const int MINBALANCE=5000; // MSIL "static literal int MINBALANCE=5000";

}

Main(){
    
    Account.MINBALANCE=5000;//error - const cannot be initialized @ runtime
}
```



> How to define const , where value can be set @runtime

```C#
public class Account{
 //const int MINBALANCE; Error , const variables must be intiatilezed @compile time
public const int MINBALANCE=5000; // MSIL "static literal int MINBALANCE=5000";
int balance;
readonly string panNumber; //readonly members must be initialized in constructor only!
public Account(string pan){
    
    this.panNumber="";
    this.panNumber=pan;
    
}
public void Change(string value)
{
    this.panNumber=value;//error - readonly members cannot be initialized outside constructor
}
    

}

Main(){
    
    Account.MINBALANCE=5000;//error - const cannot be initialized @ runtime
    Account _one=new Account("ADYPV0026G");
    Account _two=new Account("ASDVG00568");
}
```

#### static readonly

> static readonly members must be initialized using static initializer

---

```C#
public class ICU{

	private static readonly  ICU instance=null;
	static ICU(){
        instance=new ICU();
	
	}
    private ICU(){} //private constructor
    
    public static  ICU GetInstance(){
        ICU.instance=null;// error : static readonly fields cannot be initialized outside other than static intializer (constructor)
        return ICU.instance;
    }
    
}

Main(){
    
    //ICU obj=new ICU();//Error- InAccessible due to protection level
    ICU obj=ICU.GetInstance();//Typeload - Static Initializer Invoked + ICU instantiated 								+ Returns instance reference,
    ICU obj2=ICU.GetInstance();//returns existing instance reference;
    
}
```



### Checkpoint

----

```C#
class A{

    int x; //instance variable
    static int y; // type variable
    readonly int z;// instance variable- constructor initialization 
    static readonly int p;//static constructor initialization only 
    const int q=100; //compiletime initialization only

}
```



#### ref ,out and params

---

> Function Arguments
>
> Pass by Value : For value type
>
> Pass By Reference : For Reference type



> pass by reference :
>
> 1. ref :- callee expects intial value for ref arguments  from caller
>
> 2. out : caller expects value for out arguments from callee

```C#

public class Compute{
public static  void Sum(ref int x,int y){

    	x=x+y;
}
}

static void Main(){
 
    int x=10; // ....local variables must be intilaized
    int y=20;
    Compute.Sum(ref x,y); //  x adress , y copy  given to Sum ...ref arguments sholud be initialized by caller
    
    string data="1234";
    int value; // Not-initialized by Main(Caller) method ...because "value" is passed as out valriable and out valriables are expected to be initialized by callee method .
    if(Converter,ConvertToInt(data,out value)){
        
    }
    
    
}

//out keyword usage 
public class Converter{
    
    public static bool ConvertToInt(string data,out int convertedValue){
        
        // all the out variables must be initialized before control leave the method
        convertedValue=0;
        //write convert logic here
        return true;
    }
}

```



### Array

---

> Data structure  - list of simile data  items  (each item/data belongs to same type)
>
> In Dotnet :- instance of reference type - "System.Array"
>
> Syntax :  



```C#
//Single Diemension Array
<DataTypeOfEachItem>[] referenceName=new <DataTypeOfEachItem>[size];

int[] numbersRef=new int[100];//Declaration

numberfRef[0]=10;
numbersRef[1]=20;
numbersRef[2]=30;
.
.
.
.
numbesRef[99]=999;

//print
for(int i=0;i<numbersRef.Length;i++){
    
    System.Console.WriteLine(numbersRef[i]);
}


int[] numbersRef=new int[] {1,2,3,4,5,7};// Declarartion and Initialization
int[] numbersRef={1,2,3,4,5}//Array Literal Syntax

//How to address elements in array
//use - index  and "indexer"
//Array index value start from 0

//First Element 
numbersRef[0]=10;
int value=numbersRef[0];

string[] names=new string[10];
double[] currencyList=new double[10];

```

### Checkpoint

```C#
public class Patient{}

void Main(){

Patient[] patientListRef=new Patient[10];
Patient obj=new Patient();
patientListRef[0]=obj;
    
}

//Thread - Execution Trace 
//Main Method Call
OS Thread Id: 0x4708 (18184)
ESP EIP
002dedb4 005e00a9 Test.Program.Main(System.String[])
PARAMETERS:
args = 0x02722ef0
LOCALS:
0x002dedc0 = 0x00000000
0x002dedbc = 0x00000000

002df020 59551b8c [GCFrame: 002df020]

============================================
OS Thread Id: 0x4708 (18184)
ESP EIP
002dedb4 005e00dd Test.Program.Main(System.String[])
PARAMETERS:
args = 0x02722ef0
LOCALS:
0x002dedc0 = 0x02722f00 //Patient[] patientListRef=new Patient[10];
0x002dedbc = 0x02722f24 // Patient obj=new Patient();

002df020 59551b8c [GCFrame: 002df020]

===============================

!dumparray 0x02722f00
Name: Test.Patient[]
MethodTable: 58b96290
EEClass: 5897daf4
Size: 36(0x24) bytes
Array: Rank 1, Number of elements 5, Type CLASS
Element Methodtable: 003130a0
[0] null
[1] null
[2] null
[3] null
[4] null

=======================================

!do 0x02722f24
Name: Test.Patient
MethodTable: 003130a0
EEClass: 00311334
Size: 12(0xc) bytes
(C:\Users\ing07471\Documents\Visual Studio 2010\Projects\Test\Test\bin\Debug\Test.exe)
Fields:
None

=======================================

!dumparray 0x02722f00
Name: Test.Patient[]
MethodTable: 58b96290
EEClass: 5897daf4
Size: 36(0x24) bytes
Array: Rank 1, Number of elements 5, Type CLASS
Element Methodtable: 003130a0
[0] 02722f24 // patientListRef[0]=obj;
[1] null
[2] null
[3] null
[4] null
```

#### Multi Dimensional Array



```
Syntax: Matrix 2*2

<DataTypeOfEachElement>[,] matrixRef=new <DataTypeOfEachElement>[rowSize,columnSize];

ex:

int[,] matrix=new int[2,2];
matrix[0,0]=10;

int[,] matrix=new int[,] { {1,2}, {2,3}  }

//Matrix reference
int[0,0]=10; // first Cell {row=0,column=0}
int[1,0]=20;// second row , first column
int value=int[1,1]; // second row,second column


```

#### Jagged Array

---

> Array with-in Array
>
> How to define multidimensional array  ? Each row can have variable column size.
>
> In jagged Array ...number of rows will be fixed at the declaration time. we can vary the number of columns for each row.

```
<dataTypeOfEachElement>[][] referenceName=new <dataTypeOfEachElement>[rowSize][];

int[][] jaggedArray=new int[3][];

jaggedArray[0]=new int[]{1,2};
jaggedArray[1]=new int[]{1,2,3};
jaggedArray[2]=new int[]{11,22,33,44};

int value=jaggedArray[0][1];//2 
value=jaggedArray[2][2];//33

//iterate Jagged Array

for(int i=0;i<jaggedArray.Length;i++){
	//Columns 
	for(int j=0;j<jaggedArray[i].Length;j++){
	
		System.Console.WriteLine(jaggedArray[i][j]);
	
	}

}



```

#### params

----

> 1. Params parameter must be single dimensional array
> 2. Params parameter must be the last argument in the formal parameter list

```C#
pubic int Sum(params int[] numbers){
	int result=default(int);
	for(int i=0;<numbers.Length;i++){
		result+=numbers[i];
	}
}

void Main(){
    
    int[] items={1,2,3};
    Sum(items);
    items={2,3,4,55,8};
    Sum(items);
    //Grammer
    Sum(1,2);//Compiler -  int[] temp={1,2};
    Sum(1,2,3);// int[] temp={1,2,3}
    Sum(1,2,3,4,5);//int[] temp={1,2,3,4,5} 
    
}

class Socket{
    
}

void Listen(params Socket[] endpoints){
    
}

Listen(new Soket(),new Socket(),new Socket());
```



#### Parametric Polymorphism

> It enables the creation of generic functions and class or struct  that operate on values, regardless of data type
>
> C#- Generics



```C#
void Swap(int x,int y){
    int temp=x;
    x=y;
    y=temp;
}
//Any Limitation ?
int s=10;
int r=20;
Swap(s,r)


//T is known as TypeParameter (placeholder for DataType)
void Swap<T>(T x,T y)
{
    
}
//Value for T will be instantiated when Swap function is called
Swap<int>(10,20);
Swap<string>("Ten","twenty");

class IntegerStack{
    
    int[] items;
}
class StringStack{
    string[] items;
}
Stack obj1=new Stack();
Stack obj2=new Stack();

class Stack<T>{
    
    T[] items;//T value will be determined , when Stack object instantiated
}

Stack<int> _integerStack=new Stack<int>();
Stack<string> _stringStack=new Stack<string>();
```



```c#
public class DynamicArray{

    //private Data Fields
    private int[] buffer;
    private int itemCount;
    //Constructor
    public DynamicArray(int capacity){
        buffer=new int[capacity];
    }
    //Property
    public int Capacity
	{	
		get
		{
		return buffer.Length;
		}
	}
    //Property
    public int ItemCount
	{
		get
		{
		return itemCount;	
	}
 }
    //indexer Support
    public int this[int index]
	{
		set
			{
				counter++;
				if (index >= capacity){
				Array.Resize(ref buffer, index + 5);
                }
                buffer[index] = value;
			}
	   get
			{
				return buffer[index];
			}
	}
}

public class Program{
    static void Main(){
        DynamicArray _dynamicArray=new DynamicArray(5);
        _dynamicArray[0]=100;// _dynamicArray.set_Item(0,100);
        _dynamicArray[1]=200;
        _dynamicArray[2]=300;
        _dynamicArray[3]=400;
        _dynamicArray[4]=500;
        _dynamicArray[5]=500;
        int value=_dynamicArray[5];//_dynamicArray.get_Item(5);
        
        System.Console.WriteLine("Number Of Elements in DynamicArray" + _dynamicArray.ItemCount);
         System.Console.WriteLine("DynamicArray Capacity" + _dynamicArray.Capacity);
        
        int[] numbers=new int[100];// System.Array numbers=new System.Array(100);
        numbers[0]=100;
    }
}
```

### Dynamic Array Using "Object" datatype

```C#
public class DynamicArray{

    //private Data Fields
    private object[] buffer;
    private int itemCount;
    //Constructor
    public DynamicArray(int capacity){
        buffer=new object[capacity];
    }
    //Property
    public int Capacity
	{	
		get
		{
		return buffer.Length;
		}
	}
    //Property
    public int ItemCount
	{
		get
		{
		return itemCount;	
	}
 }
    //indexer Support
    public object this[int index]
	{
		set
			{
				counter++;
				if (index >= capacity){
				Array.Resize(ref buffer, index + 5);
                }
                buffer[index] = value;
			}
	   get
			{
				return buffer[index];
			}
	}
}

public class Program{
    static void Main(){
        DynamicArray _dynamicArray=new DynamicArray(5);
        _dynamicArray[0]=100;// _dynamicArray.set_Item(0,100);
        _dynamicArray[1]="200";
        _dynamicArray[2]=300;
        _dynamicArray[3]=400;
        _dynamicArray[4]=500;
        _dynamicArray[5]="Six hundred";
       int value=(int)_dynamicArray[5];//_dynamicArray.get_Item(5);
        
        System.Console.WriteLine("Number Of Elements in DynamicArray" + _dynamicArray.ItemCount);
         System.Console.WriteLine("DynamicArray Capacity" + _dynamicArray.Capacity);
        
        int[] numbers=new int[100];// System.Array numbers=new System.Array(100);
        numbers[0]=100;
    }
}
```

#### Dynamic Array using Generics

```C#
public class DynamicArray<T>{

    //private Data Fields
    private T[] buffer;
    private int itemCount;
    //Constructor
    public DynamicArray(int capacity){
        buffer=new T[capacity];
    }
    //Property
    public int Capacity
	{	
		get
		{
		return buffer.Length;
		}
	}
    //Property
    public int ItemCount
	{
		get
		{
		return itemCount;	
	}
 }
    //indexer Support
    public T this[int index]
	{
		set
			{
				counter++;
				if (index >= capacity){
				Array.Resize(ref buffer, index + 5);
                }
                buffer[index] = value;
			}
	   get
			{
				return buffer[index];
			}
	}
}

public class Program{
    static void Main(){
        DynamicArray<int> _dynamicArray=new DynamicArray<int>(5);
        _dynamicArray[0]=100;// _dynamicArray.set_Item(0,100);
        _dynamicArray[1]=200;
        _dynamicArray[2]=300;
        _dynamicArray[3]=400;
        _dynamicArray[4]=500;
        _dynamicArray[5]=600;
       int value=_dynamicArray[5];//_dynamicArray.get_Item(5);
        
        DynamicArray<string> _stringArray=new DynamicArray<string>();
        
        System.Console.WriteLine("Number Of Elements in DynamicArray" + _dynamicArray.ItemCount);
         System.Console.WriteLine("DynamicArray Capacity" + _dynamicArray.Capacity);
        
        int[] numbers=new int[100];// System.Array numbers=new System.Array(100);
        numbers[0]=100;
    }
}
```



#### Checkpoint

```C#
class List{
 int[] buffer;
}

class List{
    
    object[] buffer;
}

class List<T>{
    
    T[] buffer;
}


```



#### Collections

----

> Built in Collections (Data Structure)
>
> - indexed Base Collection (List)
> - Key Based Collection (Dictionary , HashTable)
> - Ordered Based Collection (Stack,Queue)
>
> Object Based Collection (Boxing and UnBoxing Issues)
>
> System.Collection Namesapce
>
> Generic Based Collection (Parametric Polymorphism)
>
> System.Collection.Generic



### CheckPoint

```c#
public class TradeProcessor
{
    public void ProcessTrades(System.IO.Stream stream)
    {
        // read rows
        var lines = new List<string>();
        using(var reader = new System.IO.StreamReader(stream))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        var trades = new List<TradeRecord>();

        var lineCount = 1;
        foreach(var line in lines)
        {
            var fields = line.Split(new char[] { ',' });

            if(fields.Length != 3)
            {
                Console.WriteLine("WARN: Line {0} malformed. Only {1} field(s) found.",
  lineCount, fields.Length);
                continue;
            }

            if(fields[0].Length != 6)
            {
                Console.WriteLine("WARN: Trade currencies on line {0} malformed: '{1}'",
  lineCount, fields[0]);
                continue;
            }

            int tradeAmount;
            if(!int.TryParse(fields[1], out tradeAmount))
            {
                Console.WriteLine("WARN: Trade amount on line {0} not a valid integer:
  '{1}'", lineCount, fields[1]);
            }

            decimal tradePrice;
            if (!decimal.TryParse(fields[2], out tradePrice))
            {
                Console.WriteLine("WARN: Trade price on line {0} not a valid decimal:
  '{1}'", lineCount, fields[2]);
            }

            var sourceCurrencyCode = fields[0].Substring(0, 3);
            var destinationCurrencyCode = fields[0].Substring(3, 3);

            // calculate values
            var trade = new TradeRecord
            {
                SourceCurrency = sourceCurrencyCode,
                DestinationCurrency = destinationCurrencyCode,
                Lots = tradeAmount / LotSize,
                Price = tradePrice
            };

            trades.Add(trade);

            lineCount++;
        }

        using (var connection = new System.Data.SqlClient.SqlConnection("Data
  Source=(local);Initial Catalog=TradeDatabase;Integrated Security=True"))
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                foreach(var trade in trades)
                {
                    var command = connection.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "dbo.insert_trade";
                    command.Parameters.AddWithValue("@sourceCurrency", trade.
  SourceCurrency);
                    command.Parameters.AddWithValue("@destinationCurrency", trade.
  DestinationCurrency);
                    command.Parameters.AddWithValue("@lots", trade.Lots);
                    command.Parameters.AddWithValue("@price", trade.Price);

                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            connection.Close();
        }

        Console.WriteLine("INFO: {0} trades processed", trades.Count);
    }

    private static float LotSize = 100000f;
}




class TradeRecord
    {
        public string SourceCurrency { get; set; }

        public string DestinationCurrency { get; set; }

        public float Lots { get; set; }

        public decimal Price { get; set; }
    }

```



#### Reusability (OOP)

----

1. Completed Code Reuse
2. Object Reuse

##### Complete Code reuse

----

> Inheritance
>
> Semantic Rules need to be satisfied
>
> - family 
>
> - Separate Commonality and Variation 
>
>   - let variation can reuse commonality code
>
> - Express Generalization and Specialization 
>
>   - let specialization can reuse Generalization code
>
> - "is-a" relationship, parent-child relationship
>
> - Protected Members (private + private for family)
>
> - ```C#
>   public class A{
>   	private int x;
>       protected int y;
>       public int z;
>      }
>   public class B:A{
>       
>       public void Task(){
>           
>           this.x=10;//error
>           this.y=20;//yes
>           this.z=100;//yes
>           
>       }
>   }
>   
>   static void Main(){
>       B obj=new B();
>       obj.x;//error
>       obj.y;//error
>       obj.z;//Allowed
>       obj.Task();
>   }
>   ```
>
>   
>
> Inheritance Types
>
> - Single 
>
> - ```C#
>   class A{
>   
>   }
>   
>   class B:A{
>   
>   }
>   ```
>
>   
>
> - Multiple
>
> - ```C#
>   class A{
>   
>   }
>   class B{
>   
>   }
>   //Error
>   class C:A,B{
>   
>   }
>   ```
>
>   
>
> - Multilevel
>
> - ```C#
>   class A{
>   
>   }
>   class B:A{
>   
>   }
>   
>   class C:B{
>   
>   }
>   ```
>
>   
>
> - Hierarchy
>
> - ```C#
>   class A{
>   
>   }
>   class B:A{
>   
>   }
>   class C:A{
>   
>   }
>   ```
>
>   
>
> - Hybrid
>
> - ```C#
>   //Not Supported in C#
>   class A{}
>   class B:A{}
>   class C:A{}
>   class D:B,C{}
>   
>   ```
>
>   
>
> - C#:- Single,Multilevel,Hierarchy
>
> - Order of Constructor Execution
>
>   - Parent -> Children
>   - Be Default Child(Derived) class Constructor can invoke Base Class /Parent class Default Constructor
>   - Child Class Constructor can explicitly Call Base Class Constructor
>
> - ```C#
>   class A{
>   public A(){
>   Console.WriteLine("A")
>   }
>   public A(int x){
>       Console.WriteLine("A.A(x)");
>   }
>   }
>   class B:A{
>       public B(){
>           //Complier generated MSIL - A.A()
>           Console.WriteLine("B");
>       }
>       //Explicit Base Class Constructor Call
>       public B(int x):base(x){
>           //Complier generated MSIL - A.A(x)
>            Console.WriteLine("B.B(x)");
>           
>       }
>       
>   }
>   
>   B obj=new B();
>   B newObj=new B(100);
>   ```
>
>   



```C#
    public class Control
    {
        public int Height { get; set; }
        public int Width { get; set; }

    }
	
    public class Button:Control
    {
        
        //Auto Property
        public string Caption { get; set; }

    }
    public class TextBox:Control
    {
     
        public string Text { get; set; }
        public string Color { get; set; }
        public string FontSize { get; set; }
    }

    public class ComboBox:Control
    {
      
        public string Caption { get; set; }

        public List<object> Items { get; set; }
    }

 Control _control=new Control();
```



#### Checkpoint



```C#
class List
{
    public void Add(){}
    public void Remove(){}
    public void InsertAt(int index){}
    public void RemoveAt(int index){}
    public void Clear(){}

}

class Stack:List{

    public void Push(){}
    public void Pop(){}
    
}

class Rectangle{
    
}

//Not Valid
class Square:Rectangle{
    
}
```



### Object Reuse

----

> has-a relationship - uses , Dependency 

```
class ToyotaCar{

//has-a
VTTEngine _engineRef=new VTTEngine();

}

classs VTTEngine{

}
```

##### Abstract , Virtual , Sealed , Override

### abstract -class

----

> How to restrict instantiation  of commonality or Generalized information or base class - because class holds reusable code(not concrete) for family - members(derived) ?
>
> solution : "Mark base class constructor **protected** " or Let Compiler generate protected constructor

```C#
abstract class A{

    //Compiler Generate Protected Constructor in MSIL -> protected A(){}
}
class B:A{
 public B(){
//MSIL A.A()
 }
}

A obj=new A();//Error
B obj=new B();//Valid - instance of Concrete Class
```

### abstract method

----

> template method :- implementation vary from one family member to another



##### Example - 1

```C#
  public abstract  class Control
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public abstarct void Draw();

    }
	
    public class Button:Control
    {
        
        //Auto Property
        public string Caption { get; set; }
        public override void Draw(){
            //implementation
        }

    }
    public class TextBox:Control
    {
     
        public string Text { get; set; }
        public string Color { get; set; }
        public string FontSize { get; set; }
         public override void Draw(){
            //implementation
        }
    }

	//Error: Draw method is not overriden
    public class ComboBox:Control
    {
      
        public string Caption { get; set; }

        public List<object> Items { get; set; }
    }
```



##### Example - 2

```C#
public abstract class Vehicle{

    public int torque;
    public ing bhp;
    public string Model;
    public void Start(){}
    public void Stop(){}
    public abstract  void DriveTransmission();
}

public class MaruthiHatchBackCar:Vehicle{
    
        public override  void DriveTransmission(){ FWD }
}
   
 public class MahindraScorpioSUV:Vehicle{
    
        public override  void DriveTransmission(){ RWD }
}
    
       
 public class MahindraTharSUV:Vehicle{
    
        public override  void DriveTransmission(){ AWD }
}
    
public class Truck:Vehicale{
            public override  void DriveTransmission(){ //RWD } 
}

  

```



#### virtual methods

----

> concrete methods - method has implementation - 
>
>  "Open" methods(Can be overridden ) - "Closed Methods (cannot be overridden in derived classes)"

```C#
public abstract class Vehicle{

    public int torque;
    public ing bhp;
    public string Model;
    //concrete - open methods
    public virtual void Start(){ //Key based Start }
    //concrete - closed methods
    public void Stop(){//Key based Stop }
    public abstract  void DriveTransmission();
}

public class Car:Vehicle{
    
        public override  void DriveTransmission(){ //AWD,RWD, FWD }
        public override void Start(){ // Button Start }
     
}
public class Truck:Vehicle{
            public override  void DriveTransmission(){ //RWD } 
}
    
Car obj=new Car();
obj.Start();
```



```C#
class Stream{
public virtual void Read() { //Byte by Byte}
public virtual void Write(){ //Byte }
}

class BufferedStream:Stream{

public override void Read(){  //Block Read }
public override void Write(){  //Block Write }
}


```



#### Shadowing

----

```C#
public class A{
pubic void M(){ //Impl }
public virtual Q(){ //Imp }
}

public class B:A{
    public void N(){}
    public new void Q(){}
}
    
public class C:A{
    
    public void P(){}
    public new  void M(){ base.M(); // + New Implementation }
    public override void Q(){}
                         	
                         
}
    
void ClientOne(B obj){
    
    obj.M();
    obj.N();
}
    
void ClientTwo(C obj){
    
    obj.M();
    obj.P();
}
```



#### Checkpoint

```C#
public class A{
public virtual void M(){}
}

public class B{
    
    //Should override or shadow the base class method M() ?
}
```



#### Sealed 

> context based keyword
>
> 1. class : restricts inheritance
> 2. method :- " sealed override"  - restricts inheritance of virtual property of method

```C#
public sealed class A{

}

//Error: Sealed classes cannot be inherited
public class B:A
{

}
```



```C#
public class A{

    public virtual M(){}
}
public class B:A{
    // override - virtual
    public override void M(){}
}
public class C:B{
    //restrics Children of "c" from overriding M()
    public sealed override void M(){
        
    }
}
public class D:C{
    //Error : - base class resticted virtual property of Method M()
    public override void M(){}
    public void N(){
        base.M();
    }
    //Shadowing Allowed
    public new virtual   void M(){
        
    }
}
public class E:D{
    
    public override void M(){}
}
```



#### Abstraction 

----

> has-a relationship 
>
> Dependency
>
> One object uses another object
>
> Dependency Management
>
> - unit test (Behavioral testing - mock , stub)
> - Loosely coupled (Change)
>
> Abstraction : Essential for Communication
>
> ​						public view of an object = interface
>
> ​	

### Abstraction Violation 

---

```C#

public class FileLogger{
	string  filePath="D:\logs\log.txt"
	public void Write(string msg){
		//File
	}
	
}

//ApiLogger implements ILogger
public class ApiLogger:ILogger{
    string netWorkAddress="http://www.pic.com/logs";
     void Connect(){}
     void Disconnect(){}
    public void Write(string msg){
        
    }
}

class FakeLogger:ILogger{
    public void Write(string msg){
        //
    }
}

public class Calculator{
    FileLogger _logger;
    public Calculator(){
        this._logger=new FileLogger();
    }
    public int   Add(int x,int y){
        
        this._logger.Write("Add Method Called "");
        return x+y;
    }
}
                           //Unit Test Code - Machine "Y" ->"Drive C,E"
                           
                           
 class TestClass{
    
    public void Given_10_and_20_When_Add_Called_Then_Expected_30(){

        Calculator _objUnderTest=new Calculator();
       int  actualValue= _objUnderTest.Add(10,20);
        Assert.AreEquals(actualValue,30);
    }
}

//Dev Enviornment
                           
  ILogger _logger=new FileLogger();
  Calculator obj=new Calculator(_logger);
                           
//production Environment
 ILogger _logger=new APILogger();
 Calculator obj=new Calculator(_logger);       
                           
                           
//Test Environment
 ILogger _logger=new FakeLogger();
 Calculator obj=new Calculator(_logger);
                           
```



```C#
//contract 
public interface ILogger{
    void Write(string msg); // By default interface methods are public,abstract
}

//FileLogger implements ILogger
public class FileLogger:ILogger{
	string  filePath="D:\logs\log.txt"
	public void Write(string msg){
		//File
	}
	
}
//ApiLogger implements ILogger
public class ApiLogger:ILogger{
    string netWorkAddress="http://www.pic.com/logs";
     void Connect(){}
     void Disconnect(){}
    public void Write(string msg){
        
    }
}

//FakeLogger implements ILogger                           
class FakeLogger:ILogger{
    public void Write(string msg){
        //
    }
}
public class Calculator{
    // Depends on Interface of Loggers
    ILogger _logger;
    //Constructor Dependency Injection
    public Calculator(ILogger logger){
        this._logger=logger;
    }
    public int   Add(int x,int y){
        
        this._logger.Write("Add Method Called "");
        return x+y;
    }
}
                           //Unit Test Code - Machine "Y" ->"Drive C,E"

class TestClass{
    
    public void Given_10_and_20_When_Add_Called_Then_Expected_30(){
        ILogger _stub=new FakeLogger();
        Calculator _objUnderTest=new Calculator(_stub);
       int  actualValue= _objUnderTest.Add(10,20);
        Assert.AreEquals(actualValue,30);
    }
}

//Dev Enviornment
                           
  ILogger _logger=new FileLogger();
  Calculator obj=new Calculator(_logger);
                           
//production Environment
 ILogger _logger=new APILogger();
 Calculator obj=new Calculator(_logger);       
                           
                           
//Test Environment
 ILogger _logger=new FakeLogger();
 Calculator obj=new Calculator(_logger);
                           
                           
                           
                           
```



### interface

---

- public view of an object
- By convention, interface names begin with a capital `I`.
- Any class or struct that implements the interface must contain a definition for all the  methods that matches the signature that the interface specifies.
- A class or struct can implement multiple interfaces, but a class can only inherit from a single class.
- An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.
- An interface define contract (Vocabulary to be used in the dialog b/w two objects )
- An interface can contain non implemented methods, properties and events

### Abstraction Assignment

---





```C#
public class TATACar{
    DiCorEngine _diCor;
    public TataCar(){
        
        _diCor=new DiCorEngine();
    }
    
    public void Drive(){
        
        _diCor.Start();
    }
    public void Halt(){
        
        _diCor.Stop();
    }
    

}

public class DiCorEngine{
    
    public void Start(){}
    public void Stop(){}
}

public class VeriCorEngine{
    
}

public class MultiJetEngine{
    
}
public class RevorTron{ }

//BS IV 

//BS VI

TataCar _harrier=new TataCar();
TataCar _nexon=new TataCar();
TataCar _hexa=new TataCar(); 



```



### TradeProcessor Assignment



```C#
public class CSVTradeDataReader{
    
}
public class CSVTradeDataLineValidator{}

public class ConoleLogger{}

public class TradeDataSqlPersister{}


public class TradeProcessor
{
    public void ProcessTrades(System.IO.Stream stream)
    {
        // read rows
        var lines = new List<string>();
        using(var reader = new System.IO.StreamReader(stream))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        var trades = new List<TradeRecord>();

        var lineCount = 1;
        foreach(var line in lines)
        {
            var fields = line.Split(new char[] { ',' });

            if(fields.Length != 3)
            {
                Console.WriteLine("WARN: Line {0} malformed. Only {1} field(s) found.",
  lineCount, fields.Length);
                continue;
            }

            if(fields[0].Length != 6)
            {
                Console.WriteLine("WARN: Trade currencies on line {0} malformed: '{1}'",
  lineCount, fields[0]);
                continue;
            }

            int tradeAmount;
            if(!int.TryParse(fields[1], out tradeAmount))
            {
                Console.WriteLine("WARN: Trade amount on line {0} not a valid integer:
  '{1}'", lineCount, fields[1]);
            }

            decimal tradePrice;
            if (!decimal.TryParse(fields[2], out tradePrice))
            {
                Console.WriteLine("WARN: Trade price on line {0} not a valid decimal:
  '{1}'", lineCount, fields[2]);
            }

            var sourceCurrencyCode = fields[0].Substring(0, 3);
            var destinationCurrencyCode = fields[0].Substring(3, 3);

            // calculate values
            var trade = new TradeRecord
            {
                SourceCurrency = sourceCurrencyCode,
                DestinationCurrency = destinationCurrencyCode,
                Lots = tradeAmount / LotSize,
                Price = tradePrice
            };

            trades.Add(trade);

            lineCount++;
        }

        using (var connection = new System.Data.SqlClient.SqlConnection("Data
  Source=(local);Initial Catalog=TradeDatabase;Integrated Security=True"))
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                foreach(var trade in trades)
                {
                    var command = connection.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "dbo.insert_trade";
                    command.Parameters.AddWithValue("@sourceCurrency", trade.
  SourceCurrency);
                    command.Parameters.AddWithValue("@destinationCurrency", trade.
  DestinationCurrency);
                    command.Parameters.AddWithValue("@lots", trade.Lots);
                    command.Parameters.AddWithValue("@price", trade.Price);

                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            connection.Close();
        }

        Console.WriteLine("INFO: {0} trades processed", trades.Count);
    }

    private static float LotSize = 100000f;
}




class TradeRecord
    {
        public string SourceCurrency { get; set; }

        public string DestinationCurrency { get; set; }

        public float Lots { get; set; }

        public decimal Price { get; set; }
    }

```



### Exception Handling

---

> exception :- runtime error, instance of class -> describes runtime error
>
> Who instantiate : runtime or program
>
> Describes ?
>
> - Thread Identity
> - Message
> - Method 
> - Class Name
> - Stack Trace
>
> Handling ? 
>
> - set pointer/reference to an instance of exception
>
> unhandled Exception :- Thread Execution unable to refer instance of Exception

C# Support Exception Handling

> - Structured Exception Handling
> - Exception class derived from "System.Exception"
> - Clauses : try, catch, throw and finally

```C#
public class Calculator{
    public int Div(int x,int y){
        int result=default(0);
        try{
        result=x/y;
        }
        //Set Reference/pointer -> exception object
        catch(DivideByZeroException obj)
        {
           //Handling Code
            //Log
            throw new InvalidArgumentException ("y argumet cannot be Zero");
        }
        return result;
    }
}

static void Main(){
    
    Calculator obj=new Calculator();
    try{
		   int result= obj.Div(10,2);
    }
    catch(InvalidArgumentException ex){
        
    }
    result=obj.Div(10,0);
}
```



```C#
try{
	statement 1.
	statement 2//Exception
	statement 3.
	.
	.
	.
	.statement n
}
catch(FileNotFoundException obj){}
catch(SecurityException obj){}
catch(DBException obj){}
catch(System.Exception obj){} //Last in the exception catch block list
```

```
try{
	statement 1.
	statement 2//Exception in - Go to Catch Block
	statement 3.
	.
	.
	.
	.statement n
}
catch(FileNotFoundException obj){}
catch(SecurityException obj){}
catch(DBException obj){}
catch(System.Exception obj){} //Last in the exception catch block list

statement n+1.....
```

```C#
try{
	statement 1.
	try{
	statement 2//Exception
	}
	catch(Exception obj)
	{
	
	}
	statement 3.
	.
	.
	.
	.statement n
}
catch(FileNotFoundException obj){}
catch(SecurityException obj){}
catch(DBException obj){}
catch(System.Exception obj){} //Last in the exception catch block list
```

##### finally

---

> Guaranteed code - executed before control leaves try block (exception or not )
>
> Usage : Resource Cleanup , Closing File Handle , Dispose Objects , DB Connection release
>
> 
>
>  

```C#
public void ProcessFile(string path){

		//open file
		//read file
		//write file
		//close file
		try{
		File.Open(path);
		//read
		//write ->Exception -> Control -> Catch Block
		}
		catch(FileNotFoundException ex){
		
		}
		catch(PermissionDeniedException ex){
		
		}
		finally{
		File.Close(path);
		}
}
```

#### Checkpoint

---

```C#
public class A
{
	public static void Main()
	{
		Div(10,2);
        Div(10,0);
	}

	static void Div(int x,int y)
	{
		try{
			int result=x/y;
			System.Console.WriteLine("Statement 1");
			
		}
		catch(System.DivideByZeroException ex){
			System.Console.WriteLine("Statement in catch Block");
		}
		finally{
			System.Console.WriteLine("Statement in Finally");
		}
		System.Console.WriteLine("Statement N");
	}
}
```





#### Delegate

---

> Function Pointer :- "Pass Function as an Argument" , An alternative to Runtime polymorphism to achieve abstraction. 
>
> Why "Function as an Argument"
>
> - Thread -  depends on function pointer to get to know "execution start point "
> - Asynchronous Programming - "How to pass address of callback function"
> - Event Driven programming - "How to pass address of function as a EventHandler"
>
> Function Pointer equivalence  - C#
>
> "Command + Composite Command Pattern" 
>
> C# Compiler help - keyword "delegate" 
>
> - Generates Command Class 

### pointers(holds memory address)

---

> every pointer associated with "target"
>
> - pointer to variable - target "DataType"
> - Pointer to function - target "Method Signature"

```
int *p;// p is a pointer  , which can store memory address of integer data

//Function pointer Declaration
void (*fp)(int x); // fp is a function pointer , which can store address of any method ,provided method signature should be void(int x)
```



What is Delegate

----

A [delegate](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types) keyword generate  command class (Compiler Generated ) that represents references to methods with a particular parameter list and return type. When you instantiate a command class , you can associate its instance with any method with a compatible signature and return type. You can invoke (or call) the method through the command instance. Delegates are used to pass methods as arguments to other methods

```C#
public delegate <TargetMethodReturnType> <CommandClassName>(TargetMethod Argumnet List);

ex:
public delegate int PerformCalculation(int x, int y);
/*
MSIL
public class PerformCalculation{

public int Invoke(int x, int y){

}
}

*/

public class Calculator{
    
    public int Add(int x,int y){
        return x+y;
    }
    public double Add(double x, double y){
        return x+y;
    }
}

public class Computer{
    
    public void Compute(PerformCalculation obj){
        
      int result  =obj.Invoke(10,20);
    }
}

class Program {
    
    static void Main(){
        
        Calculator _calcObj=new Calculator();
        PerformCalculation _funObject=new  PerformCalculation(_calcObj.Add);
        Computer _comp=new Computer();
        _comp.Compute(_funObject);
        
    }
}


```



#### CheckPoint

- Multicast Delegate Instances

  - One to Many....

  - Composite Pattern

    

- "event" keyword

- Syntax :  public event <delegateType>  <EventName>; 

  - ```C#
    public class Subject{
    
       public event  Action StateChanged;
    }
     public  class ObserverOne
        {
            public void Update()
            {
                
            } 
    
        }
    public class ObserverTwo
        {
            public void Notify()
            {
                
            }
        }
    public class Program
    {
    	public static void Main()
    	{
    		ObserverOne _observerOne=new ObserverOne();
    		ObserverTwo _observerTwo=new ObserverTwo();
    		
    		Action _observerMethodAddressOne=new Action(_observerOne.Update);
    		Action _observerMethodAddressTwo=new Action(_observerTwo.Notify);
    		
    		Subject _subject=new  Subject();
    		_subject.StateChanged+=_observerMethodAddressOne;
    		_subject.StateChanged+=_observerMethodAddressTwo;
    		
    	}
    }
    
    //MSIL
    .class public auto ansi beforefieldinit Subject
           extends [mscorlib]System.Object
    {
      .field private class [mscorlib]System.Action StateChanged
      .method public hidebysig specialname instance void 
              add_StateChanged(class [mscorlib]System.Action 'value') cil managed
      {
          	//Implementation
      }
      .method public hidebysig specialname instance void 
              remove_StateChanged(class [mscorlib]System.Action 'value') cil managed
      {
          //Implementation
      }
      .event [mscorlib]System.Action StateChanged
      {
        .addon instance void Subject::add_StateChanged(class [mscorlib]System.Action)
        .removeon instance void Subject::remove_StateChanged(class [mscorlib]System.Action)
      } // end of event Subject::StateChanged
    }
     
    
    .method public hidebysig static void  Main() cil managed
      {
        // 
        .maxstack  2
        .locals init (class ObserverOne V_0,
                 class ObserverTwo V_1,
                 class [mscorlib]System.Action V_2,
                 class [mscorlib]System.Action V_3,
                 class Subject V_4)
        IL_0000:  nop
        IL_0001:  newobj     instance void ObserverOne::.ctor()
        IL_0006:  stloc.0
        IL_0007:  newobj     instance void ObserverTwo::.ctor()
        IL_000c:  stloc.1
        IL_000d:  ldloc.0
        IL_000e:  ldftn      instance void ObserverOne::Update()
        IL_0014:  newobj     instance void [mscorlib]System.Action::.ctor(object,
                                                                          native int)
        IL_0019:  stloc.2
        IL_001a:  ldloc.1
        IL_001b:  ldftn      instance void ObserverTwo::Notify()
        IL_0021:  newobj     instance void [mscorlib]System.Action::.ctor(object,
                                                                          native int)
        IL_0026:  stloc.3
        IL_0027:  newobj     instance void Subject::.ctor()
        IL_002c:  stloc.s    V_4
        IL_002e:  ldloc.s    V_4
        IL_0030:  ldloc.2
        IL_0031:  callvirt   instance void Subject::add_StateChanged(class [mscorlib]System.Action)
        IL_0036:  nop
        IL_0037:  ldloc.s    V_4
        IL_0039:  ldloc.3
        IL_003a:  callvirt   instance void Subject::add_StateChanged(class [mscorlib]System.Action)
        IL_003f:  nop
        IL_0040:  ret
      } // end of method Program::Main
    
        
    ```

    

  - encapsulate Delegate Instance

    - "private"
    - Generates Event Mutators(functions) ... add_EventName ....remove_EventName in MSIL
    - Generate Public Event Property

- Generic Delegates

- Two Built-in delegates 
  - Func
  
    - Built -in delegate represents   function with return value and up to 16 parameters
  
      
  
  - Action
  
    - Built in delegates represents void function up to 16 parameters
  
- Lamda 



#### Book references

----

- C# in Depth
- Object Oriented Thought Process
- Programming Language Pragmatics
- Art of unit testing

My Contact Details

---

Venugopal Shastri

venu.shastri@gmail.com

+91 9880455636



Thanks!!!!!

