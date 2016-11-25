# String Calculator Kata

## Mission

This Kata helps you:
* Exercise [TDD][tdd].
* Exercise [Refactoring](https://en.wikipedia.org/wiki/Code_refactoring).

## Description

Create simple String Calculator.

## Exercise(s)

1. Create a simple String calculator with a method:
    ```cs 
    int Add(string numbers){}; 
    ``` 
    The method can take 0, 1 or 2 arguments and will return their sum. For an empty `string` it wil return 0. Delimiter is `','`.
    
    Example(s): 

    ```cs
    Add("") //returns 0
    Add("1") //returns 1
    Add("1,2") //returns 3
    ```

2. Allow the `Add` method to handle an unknown amount of numbers.

    Example(s): 

    ```cs
    Add("") //returns 0
    Add("1") //returns 1
    Add("1,2,2,5") //returns 10 
    ```

3. Allow the `Add` method to handle new lines between numbers.

    Example(s): 

    ```cs
     Add("1\n2,3") //returns 6
     Add("1\n") //is invalid
    ```

4. Allow the `Add` method to support different delimiters. To change a delimiter, the beginning of the string will contain a separate line.

    Example(s): 
    ```cs
    Add("//;\n1;2") //definite ';' as a delimiter and returns 3
    ```
     Definition of delimiter is  _optional_. Default delimiter is `','`. All previous scenarios should be still supported.

5. Calling the `Add` method with a negative number(s) will throw a `NegativeNumbersNotSupportedException`. 
All provided negative numbers should be shown in  ```Exception``` message.

6. Numbers bigger than 1000 should be ignored.

    Example(s):
    ```cs
    Add("1,500\n1000") //returns 501
    Add("1,1001") //returns 1
    ```

7. Delimiters can be of any length.

    Example(s):
    
    ```cs
    Add("//[;]\n1;2") //returns 3
    Add("//[***]\n1***2***3") //returns 6
    Add("//[***]\n1***2***") //is invalid
    Add("//[***]\n5**2") //is invalid
    ```

8. Allow multiple delimiters.

    Example(s):
    
    ```cs
    Add("//[*][%]\n1*2%3") //returns 6
    Add("//[*][%%]\n1*2%%3") //returns 6
    Add("//[*][%%]\n1%%2*6") //returns 9
    ```

## Credits

[Roy Osherove](http://osherove.com/)

[game-of-life]: https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life
[tdd]: https://en.wikipedia.org/wiki/Test-driven_development