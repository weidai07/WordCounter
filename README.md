# Word Counter 
##### By Wei Dai
###### Created 20 December, 2019

## Description 

This project is a demostration of my week two knowledge from the C# course.  
 
## Links:

Github - https://github.com/weidai07/WordCounter

## Setup/Installation Requirements:

1. Open https://github.com/weidai07/WordCounter
2. Clone repository to local machine 
3. Build and Run project

  - $ dotnet restore - when you are ready to restore the dependencies of the project
  - $ dotnet build - when you are ready to build the project
  - $ dotnet run - to run the project 
  - $ dotnet test - for testing the project
  

### Specification

This program is designed to check and see if a sentence includes the word a user inputs and counts how many time the word is included inside of the sentence.

For example:

| Function | Sentence | Input | Output |
| :-------------     | :------------- | :------------- | :------------- |
| The program will check for word matches | "Hello World" | "world" | true |
| The program will check for and exclude partial word matches | "water waterford" | "water" | 1 |
| The program will check for multiple word matches | "Hello hello" | "hello" | 2 |
| The program will check for punctuational word matches | "Hello! Hello" | "Hello" | 1 |
| The program will check for capitalization word matches | "hi HI Hi hI" | "hi" | 4 |
| The program will check for zero word matches | "blue skyline" | "ocean" | 0 |


## Known Bugs

* _None at this time_

## Technologies Used:

* C#
* .NET
* Microsoft(MS) Test

### License:

Copyright (c) 2019 Wei Dai

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.