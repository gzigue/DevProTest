# CodingTest Project

This is a .NET project for managing and logging application activities, developed as part of a Quality Assurance Engineer task. The project includes two main features:
- A logging function to track application events and errors.
- An inventory management function to sort products based on customizable criteria.

## Project Structure

```plaintext
CodingTest/
├── Enums/                       # Contains enums for log levels and sorting order
│   ├── LogLevel.cs              # Enum defining log levels (INFO, WARNING, ERROR, etc.)
│   └── SortOrder.cs             # Enum for sorting order (Ascending, Descending)
├── Models/
│   └── Product.cs               # Product model defining Name, Price, and Stock properties
├── Logger.cs                    # Contains logging functionality
├── InventoryManager.cs          # Contains product sorting functionality
└── README.md                    # Project documentation
```

## Features

### Logger

The `Logger` class provides a simple logging mechanism to track application events. It includes various logging levels like `INFO`, `WARNING`, `ERROR`, `DEBUG`, and `CRITICAL`. Each log entry is written to a specified file with a timestamp.

#### Example Usage

```csharp
Logger.LogMessage("application.log", "User logged in", LogLevel.INFO);
```

#### Log Format

Entries in the log file are formatted as:
```plaintext
[2024-10-25 10:23:11] [INFO] User logged in
```

### Inventory Manager

The `InventoryManager` class allows sorting of a list of products based on specified criteria such as name, price, or stock level, and order (ascending or descending).

#### Example Usage

```csharp
var sortedProducts = InventoryManager.SortProducts(products, "price", SortOrder.Descending);
```

## Setup and Installation

1. **Clone the Repository**:
   ```bash
   git clone <repository-url>
   cd CodingTest
   ```
   
2. **Build the Project**:
   Make sure you’re in the project directory, then run:
   ```bash
   dotnet build
   ```
   
3. **Restore Dependencies**:
   If dependencies aren’t automatically restored, run:
   ```bash
   dotnet restore
   ```
   
## Running the Application

This project is part of a larger application and is designed for integration. However, you can test the main features by running the functions.

### Running the Code

Simply run the command:
```bash
dotnet run
```

## Test Cases

A list of test cases for the Logger function has been created, and can be accessed in the file TEST_CASES, in the root of the project.
