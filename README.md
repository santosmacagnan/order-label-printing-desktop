# 📦 Order Label Printing System

![.NET](https://img.shields.io/badge/.NET-8-512BD4?style=flat&logo=dotnet&logoColor=white)
![C%23](https://img.shields.io/badge/C%23-12-239120?style=flat&logo=csharp&logoColor=white)
![WinForms](https://img.shields.io/badge/UI-WinForms-0078D6?style=flat&logo=windows&logoColor=white)
![Oracle](https://img.shields.io/badge/Database-Oracle-F80000?style=flat&logo=oracle&logoColor=white)

🌐 [Leia em Português](README.pt-BR.md)

## Project Overview

Desktop application developed to optimize the logistics process of order label printing, integrating an Oracle database with industrial label printers. The system automates open order retrieval, item grouping, and label generation, reducing manual errors and improving operational reliability.

## Highlights

- Layered architecture separating UI, data access, configuration, and hardware integration
- Direct Oracle database integration via `Oracle.ManagedDataAccess.Client`
- Hardware integration with the Brother bpac SDK for real label printing
- Background timer-based refresh mechanism for live order updates
- Drag-and-drop grouping UX for building multi-item, multi-volume labels

## Screenshots

<!-- TODO: add screenshots from the /ScreenShots folder, e.g.: -->
<!-- ![Main window](ScreenShots/main-window.png) -->

## Features

- Automatic retrieval of open orders
- Automatic refresh every 30 minutes
- Drag-and-drop item grouping per label
- Multi-volume label generation
- Real-time database connection monitoring
- Printing via `.lbx` templates
- Dedicated tab for loose items

## Architecture

The application follows a layered structure to improve organization and maintainability:

- **Presentation Layer** – WinForms UI
- **Data Access Layer** – Oracle integration
- **Configuration Layer** – External JSON configuration
- **Hardware Integration** – Brother bpac SDK

Applied practices:

- Separation of concerns
- Externalized configuration
- Modularized grouping logic
- Timed background refresh mechanism

## Built With

- .NET 8
- C# 12
- Windows Forms
- Oracle Database
- Oracle.ManagedDataAccess.Client
- Brother bpac SDK
- Visual Studio

## Prerequisites

- .NET 8 SDK installed
- Access to an Oracle database
- Brother printer driver installed
- A valid `.lbx` label template

## Configuration

Create an `appconfig.json` file in the executable directory:

```json
{
  "ConnectionStrings": {
    "OracleDb": "User Id=<username>;Password=<password>;Data Source=//HOST:1521/XE"
  },
  "Printers": {
    "DefaultPrinter": "QL-700"
  }
}
```

## Running the Application

1. Clone the repository
2. Configure `appconfig.json`
3. Install the printer driver
4. Run via Visual Studio or terminal

## Implemented Improvements

- Refactored label grouping logic
- Replaced manual search with interactive order selection
- Implemented automatic order refresh mechanism
- Improved multi-label generation workflow
- Added keyboard shortcut for deletion
- Implemented real-time database connection monitoring
- Replaced the Samples tab with a Loose Items tab, allowing system-grouped items and manually added items in the same label group
- Updated open orders refresh to trigger on every search
- Added customer name field for loose label generation

## Contact

- GitHub: [@santosmacagnan](https://github.com/santosmacagnan)
- LinkedIn: `<add your link>`
- Portfolio: `<add your link, if any>`
