# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a .NET 9.0 library called `Crews.PlanningCenter.Auth` for OAuth 2 authentication with Planning Center. The project is currently in its initial stages with basic scaffolding in place.

## Project Structure

- `Crews.PlanningCenter.Auth/` - Main library project containing the OAuth authentication implementation
- `Crews.PlanningCenter.Auth.Tests/` - Test project using xUnit testing framework
- `Crews.PlanningCenter.Auth.sln` - Visual Studio solution file

## Development Commands

### Build
```bash
dotnet build
```

### Run Tests
```bash
dotnet test
```

### Run Specific Test
```bash
dotnet test --filter "FullyQualifiedName=Namespace.ClassName.MethodName"
```

### Clean Build Artifacts
```bash
dotnet clean
```

### Restore NuGet Packages
```bash
dotnet restore
```

## Technology Stack

- **.NET 9.0** - Target framework
- **xUnit** - Testing framework (with Visual Studio runner and coverlet for coverage)
- **C# with nullable reference types enabled**
- **Implicit usings enabled**

## Project Configuration

The main library project (`Crews.PlanningCenter.Auth.csproj`) is configured with:
- Target Framework: .NET 9.0
- Nullable reference types enabled
- Implicit usings enabled

The test project includes:
- xUnit testing framework
- Visual Studio test runner
- Coverlet collector for code coverage
- Reference to main library project (implied by naming convention)

## Notes

- The project is currently in initial development phase with placeholder classes
- No external dependencies beyond standard .NET and testing frameworks
- Solution contains both library and test projects in a standard .NET solution structure