# BankingApp
This is a simple banking application developed as part of a take-home assignment for DataCan Services Corp. The application allows users to check their account balance and make deposits or withdrawls in multiple currencies with the applicable exchange rates.

## Table of Contents

- [Features](#Features)
- [Technologies Used](#technologies-used)
- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Design](#design)
    - [Relevant Files](#relevant-files)
    - [UML Class Diagram](#uml-class-diagram)

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

## Design

### Relevant Files

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

### UML Class Diagram
![UML Diagram](./assets/uml.png)