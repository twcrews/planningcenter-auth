# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a .NET 9.0 library called `Crews.PlanningCenter.Auth` for OAuth 2 authentication with Planning Center. The project includes OAuth client implementation, token management, and Planning Center API integration capabilities.

## Project Structure

- `Crews.PlanningCenter.Auth/` - Main library project containing the OAuth authentication implementation
  - `Configuration/` - Client configuration classes
    - `PlanningCenterAuthClientOptions.cs` - OAuth client configuration options
  - `Models/` - Data models for OAuth and API responses
    - `PlanningCenterOAuthScope.cs` - OAuth scope definitions
    - `PlanningCenterOAuthTokenResponse.cs` - OAuth token response model
    - `PlanningCenterPersonalAccessToken.cs` - Personal access token model
  - `Serialization/` - JSON serialization converters
    - `SecondsToTimeSpanConverter.cs` - Converts seconds to TimeSpan
    - `UnixTimestampToDateTimeOffsetConverter.cs` - Converts Unix timestamps to DateTimeOffset
  - `IOAuthClient.cs` - OAuth client interface
  - `PlanningCenterAuthClient.cs` - Main OAuth client implementation
- `Crews.PlanningCenter.Auth.Tests/` - Test project using xUnit testing framework
- `Crews.PlanningCenter.Auth.sln` - Visual Studio solution file
- `CHANGELOG.md` - Project changelog following Keep a Changelog format
- `README.md` - Project description and documentation
- `LICENSE` - GNU General Public License v3.0

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
- **Crews.Extensions.Primitives** - Extension library for primitive type operations
- **Entity Framework Core (SQL Server)** - Database access and ORM

## Project Configuration

The main library project (`Crews.PlanningCenter.Auth.csproj`) is configured with:
- Target Framework: .NET 9.0
- Nullable reference types enabled
- Implicit usings enabled
- External dependencies:
  - `Crews.Extensions.Primitives` v1.1.2
  - `Microsoft.EntityFrameworkCore.SqlServer` v9.0.8

The test project includes:
- xUnit testing framework v2.9.2
- Visual Studio test runner v2.8.2
- Microsoft .NET Test SDK v17.12.0
- Coverlet collector v6.0.2 for code coverage
- Reference to main library project (implied by naming convention)

## Notes

- The project includes implemented OAuth client functionality with proper models and serialization
- Uses Entity Framework Core for database operations and data persistence
- Includes custom JSON converters for handling Planning Center API data formats
- Solution follows standard .NET library structure with separate test project
- Licensed under GNU General Public License v3.0
- Includes proper changelog documentation following Keep a Changelog format