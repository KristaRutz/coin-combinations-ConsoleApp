# Coin Sorter (C# Console Application)

#### A An console-based application to simulate a cash register where the user can generate the exact coinage due, hosted on [GitHub](https://github.com/KristaRutz/coin-combinations-ConsoleApp). _Last Updated 03.06.2020._

#### By _**Krista Rutz**_

## Description

This application lets the user input total owed and total paid, calculates the total change owed in return, and lists the amount of each denomination that the checker should give back to the customer.
It is hosted on [GitHub](https://github.com/KristaRutz/coin-combinations-ConsoleApp). It does so using objects within objects, exception throwing, and type casting between ints and doubles.

## Installation / Set-up

Download or clone the repository to run this program locally! _This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._

- Download or clone this repo.
  - **To Download ZIP:**
    - Select "Download" on the [GitHub Repository](https://github.com/KristaRutz/coin-combinations-ConsoleApp) site
    - Once downloaded, open the ZIP and extract files. The new folder will be created as 'coin-combinations-ConsoleApp'.
  - **To Clone:**
    - Clone from command line into your Desktop: `$ git clone https://github.com/KristaRutz/coin-combinations-ConsoleApp`
    - The new directory will be created as 'Desktop/coin-combinations-ConsoleApp'.
- Once you have stored the files locally, execute the following commands.
  - Navigate to the application directory: `$ cd coin-combinations-ConsoleApp/CoinCombinations`
  - `dotnet build`
  - `dotnet run`
- Upon success, the program will begin running in your console.

## Technologies Used

- C#
- .NET Core 2.2

## Specs

- Spec: The program calculates the difference between paid and owed and then prints how many of each type of coin or bill to make up that change.
  - Input:
    - Customer owes: [example formats: '$0.71' or '$12.01' or '$2']
    - \$72
    - Customer paid:
    - \$400.78
  - Output:
    - Change due: \$328.78
    - hundreds: 3
    - twenties: 1
    - fives: 1
    - ones: 3
    - quarters: 3
    - pennies: 3

<details>
  <summary>Expand user stories for this project</summary>

| As a _User-Type_,  | I want...                                                      | so that...                                                                |
| :----------------- | :------------------------------------------------------------- | :------------------------------------------------------------------------ |
| As a cashier       | I want a quick and accurate way to calculate change            | so that I can focus on customer service instead of math!                  |
| As a store manager | I want my cashiers to know the number of each coin to give     | so that they give perfect, error-free change every time                   |
| As a store manager | I want to determine perfect change                             | so that my customers never complain about inaccuracies                    |
| As a customer      | I want to know exactly how many of each coin I should get back | so that I can have the least number of coins to carry around as possible. |

</details>

## Known Bugs

- No known bugs

## Support and contact details

Please contact me if you run into any issues or have questions, ideas or concerns. I can be contacted at <krista.rutz@pomona.edu>. Feel free to create a pull request for updates - _contributions to the code are encouraged!_

### License

Copyright (c) 2020 **_Krista Rutz_**

_This software is licensed under the MIT license._

<details>
  <summary>View license details</summary>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

</details>
