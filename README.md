# dotnet-unit-test
> dotnet console and unit test project


    ├── console-app
    │   ├── console-app.csproj
    │   ├── console-app.sln
    │   ├── Program.cs             
    ├── unit-test
    │   ├── Program.cs 
    │   ├── unit-test.csproj
    │   ├── unit-test.sln
    ├── .gitignore
    ├── README.md

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
## Installation
```bash
 git clone https://github.com/preedaratCh/dotnet-unit-test.git
```
## Install dependencies
```bash
 cd console-app
 dotnet restore
 cd ../unit-test
 dotnet restore
 dotnet add reference ../console-app/console-app.csproj
 cd ../console-app
```
## Usage
```bash
dotnet run
# OR
dotnet test
```

