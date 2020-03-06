# _WordCounter_

#### _C# console application project for Epicodus_, _6 March 2020_

#### By _**Patrick Kille**_

## Description

_This console application will take in a sentence and a word from the user and return the number of instances of the word in the sentence._

## Specifications:

| Specification | Example Input | Example Output |
|:-:|:-:|:-:|
| Application should take in a single word (This is a quick standard error check so "word" seemed a propros) | "word" | Continue |
|| "is word" | Throw exception |
| Should take in a sentence and break it into an array at " " (Did not need a long sentence, but enough to make sure the array would be returned correctly.) | "This has a word."| {This} {has} {a} {word.}|
| Should normalize strings in sentence array (This was the only word in the previous array to be capitalized)| This | this |
| Should remove all punctuation from strings in sentence array (This was the only word with punctuation)| word. | word |
| Should compare InputWord to strings in array | "word" and "this" | False |
|| "word" and "word" | True |
| Increment counter when words are the same | "word" and "word is word" | Return 2 |


## Setup/Installation Requirements

### Prerequisites

1. .NET Framework
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation
2. Text Editor (Visual Studio Code)

1. Cloning
  * _First, clone this repository to your desktop by opening your terminal and entering the prompt "cd desktop" followed by pressing the enter(return) key. Then type "git clone https://github.com/PRKille/WordCounter.git" and press enter(return) again._

2. Download
  * _In a web browswer navigate [here](https://github.com/PRKille/WordCounter.git) to find the GitHub repository._
  * _Click the green "Clone or download" button and selct "Download ZIP"_.

### Running Progam

1. Navigate to the WordCounter directory inside WordCounter.Solutions your terminal.

2. Compile and Run code with the "dotnet run" command.


## Technologies Used

_Git, C#, .NET Core_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **Patrick Kille**