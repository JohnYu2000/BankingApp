# BankingApp
This is a simple banking application developed as part of a take-home assignment for DataCan Services Corp. The application allows users to check their account balance and make deposits or withdrawls in multiple currencies with the applicable exchange rates.

## Table of Contents

- [Features](#Features)
- [Technologies Used](#technologies-used)
- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [UML Class Diagram](#uml-class-diagram)
- [Relevant Files](#relevant-files)
- [Object-Oriented Design and SOLID Principles](#object-oriented-design-and-solid-principles)

## Features
- Display current account balance (in CAD)
- Make withdrawls and deposits in CAD, USD, MXN, or EURO
- Automatic conversion of foreign currencies to CAD
- Simple web-based user interface

## Technologies Used
- C#
- .NET 8.0 (ASP.NET Core MVC)
- Razor Pages for the user interface
- HTML/CSS for basic styling

## Requirements
- [.NET SDK 8.0 or later](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- A version control system (e.g., [git](https://git-scm.com/downloads))
- A code editor or IDE (e.g., [Visual Studio Code](https://code.visualstudio.com/download))

## Installation

### 1. Clone the Repository

First, clone the repository from GitHub to your local machine.

```bash
git clone https://github.com/JohnYu2000/BankingApp.git
cd BankingApp
```

### 2. Install .NET SDK

Ensure that you have the .NET SDK installed on your machine. You can check your .NET SDK installation by running:

```bash
dotnet --version
```

If the command returns a version number, the SDK is installed. If not, download and install the latest .NET SDK.

### 3. Build the Project

Navigate to the project directory and build the project:

```bash
dotnet build
```

### 4. Run the Application

After building the project, you can run the application with the following command:
```bash
dotnet run
```

The application should start, and you can view it in your browser at `http://localhost:8000`.

## Usage

Once the application is running, you can:

1. **View your account balance**: The balance is displayed in CAD.
2. **Deposit money**: Enter the amount and select the currency, then click the _Deposit_ button.
3. **Withdraw money**: Enter the amount and select the currency, then click the _Withdraw_ button.

## UML Class Diagram
![UML Diagram](./assets/uml.png)

## Relevant Files

Here is a list of the relevant files in the project along with a brief explanation of their purpose:

- **Models**/
    - **BankAccountModel.cs**: This model represents a bank account. It is responsible for storing the account balance and handling deposit and withdrawal operations. This model is visualized in the `Index` view.
    - **CurrencyConverterModel.cs**: This class is used to convert foreign currencies (USD, MXN, EURO) to CAD using predefined exchange rates.
    - **TransactionModel.cs**: This class represents a financial transaction within the application, such as a withdrawal or deposit. It encapulates the details of each transaction.
- **Controllers**/
    - **BankingController.cs**: This is the main controller for the Banking application. It handles user interactions, such as deposits and withdrawals, and updates the view with the current account balance.
- **Views**/**Banking**/
    - **Index.cshtml**: The main view of the application, this file contains the Razor markup that displays the user interface for the banking application. It shows the account balance, and forms for deposits and withdrawals.
- **wwwroot**/**css**/
    - **site.scss**: This SCSS file contains the styling for the main view of the application, allowing you to customize the look and feel of the UI.

## Object-Oriented Design and SOLID Principles

**CurrencyConverterClass**

The `CurrencyConverter` class and its derived classes (`UsdCurrencyConverter`, `MxnCurrencyConverter`, `EuroCurrencyConverter`, `CadCurrencyConverter`) were designed with the following principles in mind:
- **Single Responsibility Principle**:
    - Each `CurrencyConverter` class has a single responsibility: converting a specific currency to CAD.
    - This clear separation of concerns ensures that each class is focused and easier to maintain. This allows changes to one currency's conversion logic without impacting others.
- **Open/Closed Principle**:
    - The `CurrencyConverter` class is an abstract base class that defines a contract for converting any currency to Canadian dollars (CAD).
    - This design allows the system to be extended with new currencies without modifying the existing codebase.

**Transaction Class**

The `Transaction` class, along with its derived classes (`DepositTransaction`, `WithdrawTransaction`), adheres to the following OOP and SOLID principles:
- **Single Responsibility**:
    - The `Transaction` class is an abstract base class that represents a financial transaction, such as a deposit or withdrawal.
    - The derived classes each have a single responsibility: to execute a specific type of transaction on a `BankAccount`. This ensures the code remains clean and focused, making it easier to maintain and extend.
- **Liskov Substitution Principle**:
    - The `Transaction` class ensures that any derived class can be substitued for its base class without altering the correctness of the program.
    - This design allows the `BankingController` to execute transactions polymorphically, treating all transactions uniformly, regardless of their specific type.

**BankingController**

The `BankingController` class adheres to the following OOP and SOLID principles:
- **Dependency Inversion Principle**:
    - The `BankingController` class depends on abstractions (`CurrencyConverter` and `Transaction`) rather than concrete implementations.
    - This design choice allows for greater flexibility and testability, as different implementations of `Transaction` and `CurrencyConverter` can be injected or substituted as needed.