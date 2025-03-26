# Diamond Generator

![Example GIF](https://i.imgur.com/5HkbobJ.gif)

## Summary
A simple console-based program that generates diamonds based on a user-provided number.

## Features
- **User Input Validation**: Ensures that the provided input is valid before proceeding.
- **Diamond Generation**: Creates a diamond pattern based on the user's input number.
- **Diamond Display**: Renders the generated diamond directly in the console.
- **Unlimited Generation**: Users can generate and display as many diamonds as they wish, until they choose to exit.

## Installation & Running
Clone this repository or download the source files:

```sh
git clone https://github.com/otaviobrignoni/diamond-generator.git
```

Navigate to the project directory:

```sh
cd diamond-generator
```

Restore dependencies:

```sh
dotnet restore
```

Build the solution in Release mode:

```sh
dotnet build --configuration Release
```

Run the project:

```sh
dotnet run --project DiamondGenerator.ConsoleApp
```

Alternatively, run the compiled executable:

1. Navigate to:
   ```sh
   ./DiamondGenerator.ConsoleApp/bin/Release/net8.0/
   ```
2. Open:
   ```sh
   DiamondGenerator.ConsoleApp.exe
   ```

## Requirements
- .NET SDK (Recommended: .NET 8.0 or later) for compiling and running the project.

