# Console Bakery

Purchase all the bread and pastries you want, complete your order, and see your total order price. Practice with Custom classes, Namespaces, Auto-Implemented Properties, Delegates, Invalid input handling, and Console User Experience.

## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/jamisoncozart/Console-Bakery
    ```
2. Change directories into the project working directory:
    ```
    cd Console-Bakery/Console-Bakery
    ```
2. Compile and Run code:
    ```
    dotnet run
    ```

## Specifications

|Behavior|Input|Output|
|:-:|:-:|:-:|
|Application starts, display welcome message with prices of products.|**start**|"Welcome to Console Bakery! Our current prices are: Bread - $5 each (Buy 2 get 1 Free), Pastry - $2 each (3 for $5) Would you like to: 'buy' or 'quit'|
|User chooses "buy", prompt user with purchase menu.|"buy"|"What would you like to buy? 'bread' or 'pastry'|
|User chooses product to purchase, ask how many.|"bread"|"Please enter the amount you would like to buy: ($5 each (Buy 2 get 1 Free)"|
|User chooses amount to purchase, ask user if they wish to purchase anything else.|"3"|Would you like to: 'complete order' or 'buy more'?|
|User chooses 'buy more', show purchase screen again.|"buy more"|"What would you like to buy? 'bread' or 'pastry'|
|User chooses 'complete order', show total cost of order and items purchased.|"complete order"|"Your total is: $10. Items: Bread - 3. Thank you for your purchase! Would you like to: 'restart' or 'exit'|
|User chooses 'restart', return to welcome message screen|"restart"|"Welcome to Console Bakery! Our current prices are: Bread - $5 each (Buy 2 get 1 Free), Pastry - $2 each (3 for $5) Would you like to: 'buy' or 'quit'|
|User chooses 'quit', end application|"quit"|**Application Ends**|

## Technologies Used

* C#
* .NET Core
* MSTest
* Git

## Author

* **Jamison Cozart** - (https://github.com/jamisoncozart)

## License

Licensed under the MIT license.

&copy; 2020 - Jamison Cozart
