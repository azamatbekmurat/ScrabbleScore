# _Scrabble Score project with C#_

#### _C# application for counting score of a word, 04/26/2018_

#### By _**Azamat Bekmuratov**_

## Description
This web application is built with C# Asp Net Core MVC framework. The application where a user can enter a word and gets a score according to letter values.

## Specifications

| Letters | Score for letter |
| :------------- | :------------- |
| A, E, I, O, U, L, N, R, S, T | 1 |
| D, G | 2 |
| B, C, M, P | 3 |
| F, H, V, W, Y | 4 |
| K | 5 |
| J, X | 8 |
| Q, Z | 10 |

| Input | Output |
| :------------- | :------------- |
| Rock | 10 (i.e 1+1+3+5) |
| Paper | 9 (i.e 3+1+3+1+1) |

## Setup/Installation Requirements

* Clone this repository to your desktop.
* Navigate to the cloned directory in a terminal capable of running dotnet commands.
* Run the command >dotnet add package Microsoft.AspNetCore.StaticFiles -v 1.1.3
* Run the command >dotnet restore
* Run the command >dotnet build
* Run the command >dotnet run
* Open http://localhost:5000 link in your browser.

## Known Bugs

_No known bugs at this time_

## Support and contact details

Please feel free to contact at azaege@gmail.com with any suggestions or feedback.

## Technologies Used
* C# .Net Core MVC
* Razor
* HTML

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **Azamat Bekmuratov**
