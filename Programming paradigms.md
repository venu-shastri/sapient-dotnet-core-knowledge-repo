## Programming paradigms

- Paradigm – Approach to programming

- Based on a set of principles or theory 

- Different Paradigms – Different ways of Thinking

- Idioms – Patterns for using language features

- Types of Paradigms
  - Imperative : How to Solve (Procedural , Object Oriented)
  - Declarative : What to Solve ( Functional , Logic )



## Functional Programming

- based on  Lambda -calculus
- program: function application
- same inputs should produce same output (“pure”)
- function modifies context!side effect
- avoid mutation
- higher-order functions
- Function Closure
- Function Curry
- Monads

> What is this thing called functional programming?
>
> - Functions as first-class values
>
>   > In a language where functions are first-class values, you can use them as inputs or outputs of other functions, you can assign them to variables, and you can store them in collections
>
> - Avoiding state mutation
>
>   > If we follow the functional paradigm, we should refrain from state mutation altogether: once created, an object never changes, and variables should never be reassigned. The term mutation indicates that a value is changed in-place—updating a value stored somewhere in memory.

> Functional programming is a style of programming that enables you:
> - Re-use code (via function composition)
> - Eliminate bugs (via immutability)

> In Computer Science , functional programming is a programming paradigm , a style of building the structure and elements of computer programs, that  treats computation as the evaluation of mathematical **function**s and **avoids** changing state and **mutable data**. it is a **declarative** programming paradigm , which means programming is done with **expressions**



### Why Functional

---

- Expressiveness allows Programmers to write less code

- Code brevity and readability (Subjective)

- Concurrency and Synchronization
  
  - Parallelizing programs written with pure functions is trivial, because those functions don’t mutate anything
  
- Performance

  

### Immutability

---

#### Change vs Mutation

> - Values Change over time, such as an inventory going up or down
> - Mutation means data is update in place, the previous value is lost In FP we represent change without mutation
> - Create new instances that represent the data with the desired changes

#### Example

Suppose you’re making a text editor, and you’re storing the text the user has written in a variable. The user clicks the Save button and continues typing. The program saves the text by writing one character at a time to storage (this is a bit oversimplified, but
bear with me). What happens if the user changes part of the text while the program is saving it? Will the program save the text as it was when the user clicked Save, or save the current version, or do something else?



![image-20210223152217043](E:\tcq-knowledge\image-20210223152217043.png)



### Purity

---

##### Pure Functions

- Output depends entirely on the input arguments
- Cause no side effects
- Hold no state and do not mutate global state directly
- Avoid mutating arguments



#### # Comparison



| Pure Functions                                     | Impure Functions                                         |
| -------------------------------------------------- | -------------------------------------------------------- |
| The output depends entirely on the input arguments | Factors other than input arguments may affect the output |
| Cause no side effects.                             | May cause side effects                                   |

#### # what a side effect is.

- Mutates global state—“Global” here means any state that’s visible outside of the function’s scope. For example, a private instance field is considered global because it’s visible from all methods within the class.
-  Mutates its input arguments
- Throws exceptions
- Performs any I/O operation—This includes any interaction between the program and
  the external world, including reading from or writing to the console, the filesystem,
  or a database, and interacting with any process outside the application’s boundary

#### # Benefits of Pure Function

- Easy to test and reason about

  > The fact that outputs only depend on inputs means that the order of evaluation isn’t important. Whether you evaluate the result of a function now or later, the result will not change

- Can be Parallelized

  > Different threads carry out tasks in parallel

- , Lazily evaluated 

  > Only evaluate values as needed

- Cached/Memorized

  > Cache the result of a function so it’s only computed once

- Easier to refactor and maintain

#### # Strategies for managing side effects

- ISOLATE I/O EFFECTS
- AVOID MUTATING ARGUMENTS



#### # CheckPoint - Purity and concurrency

```C#
Imagine you want to format a list of strings as a numbered list; the casing should be standardized, and each item should be preceded with a counter.

var shoppingList = new List<string> { "BOSCH", "india" , "limited"};
new ListFormatter().Format(shoppingList);

//Output
// 1. Bosch
// 2. India
// 3. Limited

static class StringExt
{
public static string ToSentenceCase(this string s)
{
  return s.ToUpper()[0] + s.ToLower().Substring(1);  
} 
public static IEnumerable<string> Select(this IEnumerable<string> sourceList,Func<string,string> transform){
    
    List<string> temp=new List<string>();
    foreach(string item in sourceList){
        
        temp.add(transform(item));
    }
  return temp;
}    
}

class ListFormatter
{
int counter;
string PrependCounter(string s) { return  $"{++counter}. {s}"; }
public List<string> Format(List<string> list)
{
return  list.Select(StringExt.ToSentenceCase).AsParallel().Select(PrependCounter).ToList();
}

    
}
    
    
```



#### # Checkpoint - Purity and testability

----

####  # Why testing impure functions is hard



#### High Order Function

----

> HOFs are functions that take other functions as inputs or return a function as output, or both



```
//Imperative Program
function  gcd(x, y){
r = 0
while y > 0:
r = x % y
x = y
y = r
return x
}

//Functional Program
function gcd(x, y){
if y == 0:
return x
else:
return gcd(y, x % y)

}


```

```C++
//Calculating the number of lines the imperative way
std::vector<int>
count_lines_in_files(const std::vector<std::string>& files)
{
std::vector<int> results;
char c = 0;
for (const auto& file : files) {
int line_count = 0;
std::ifstream in(file);
while (in.get(c)) {
if (c == '\n') {
line_count++;
}
}
results.push_back(line_count);
}
return results;
}

//Calculating the Number of Lines using Declaration Way
int count_lines(const std::string& filename)
{
std::ifstream in(filename);
return std::count(
std::istreambuf_iterator<char>(in),
std::istreambuf_iterator<char>(),
'\n');
}

std::vector<int>
count_lines_in_files(const std::vector<std::string>& files)
{
return files | transform(open_file)| transform(count_lines);
}
```



#### Expressing function signatures with arrow notation

----

| Function signature  | C#                              | Java                  | C++  | Python | C    |
| ------------------- | ------------------------------- | --------------------- | ---- | ------ | ---- |
| int  -> String      | (int i)=> i.ToString()          | (int i)->i.ToString() |      |        |      |
| (int,int,int)-> int | (int i , int j , int k)=> i+j+k |                       |      |        |      |
|                     |                                 |                       |      |        |      |



### Multiple Paradigms

---

- functional languages with object-oriented features
  - Ocaml, F#, Scala
- imperative languages with functional features
  - Python, Ruby, C#, Java
- what makes a language functional or imperative?
  - Pure functions
  - higher-order functions
  - immutable data structures
  - recommended idioms in functional style

