# SimpleGuidGenerator

## Prerequisites
- Install the .Net CLI by installing the latest [.Net SDK](https://learn.microsoft.com/en-us/dotnet/core/sdk)

## Linux
- [xsel](https://github.com/kfish/xsel) is required to access the system clipboard
- Run `sudo apt install xsel` to install on Debian distros

## Installation
- Run the following command in your terminal `dotnet tool install -g SimpleGuidGenerator` to install the tool from nuget.org

## Local Installation
- Download the latest nuget package from [releases](https://github.com/Ridewarior/GuidGenerator/releases)
- Run `dotnet tool install -g --add-source <PATH-TO-YOUR-DIRECTORY> SimpleGuidGenerator`

## Usage
- Run command `genguid` anywhere in a terminal to generate a new GUID that will be copied to your clipboard

![genguid-demo](https://github.com/user-attachments/assets/a0d9ee83-34fc-48ab-b2f3-77acefd244f3)

## Uninstall
- `dotnet tool uninstall SimpleGuidGenerator -g`