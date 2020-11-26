# <img src="https://i.imgur.com/wlzLkCC.png" alt="Core" style="max-width:100%; float: left; padding-right: 10px; margin: 0;" height="40" width="40"> Core

[![Build status](https://ci.appveyor.com/api/projects/status/uy3l50i1p1gxu1pe/branch/master?svg=true)](https://ci.appveyor.com/project/sfergusonATX/core/branch/master)
[![NuGet Release](https://img.shields.io/nuget/v/relay.core.svg)](https://www.nuget.org/packages/Relay.Core/)
[![MyGet Release](https://img.shields.io/myget/relay-dev/v/Relay.Core.svg)](https://www.myget.org/feed/relay-dev/package/nuget/Relay.Core)
[![License](https://img.shields.io/github/license/relay-dev/core.svg)](https://github.com/relay-dev/core/blob/master/LICENSE)

## Introduction

Core is a set of base class libraries written using .NET Standard. The code base consists of abstractions, contracts, stubs and interfaces only. Core abstractions are implemented by plugins, which can be found on [GitHub](https://github.com/relay-dev/core-plugins) and [NuGet](https://www.nuget.org/packages/Relay.Core.Plugins/).

Core is published to the main public NuGet feed (see section [Installation](#installation)). All APIs are documented in a .chm file located [here](https://github.com/relay-dev/core/raw/master/docs/Core%20API%20Documentation.chm).

*Update: .NET Core/.NET 5 has made the original intention of this project obsolete. Services like ILogger, IConfiguration, IServiceProvider, etc have been making their way out of this codebase. There are other useful abstractions so the package will stay.

## Getting Started

<a name="installation"></a>

### Installation

Follow the instructions below to install this NuGet package into your project:

#### .NET Core CLI

```sh
dotnet add package Relay.Core
```

#### Package Manager Console

```sh
Install-Package Relay.Core
```

### Latest releases

Latest releases and package version history can be found on [NuGet](https://www.nuget.org/packages/Relay.Core/).

## Build and Test

Follow the instructions below to build and test this project:

### Build

#### .NET Core CLI

```sh
dotnet build
```

### Test

#### .NET Core CLI

```sh
dotnet test
```

## Contribute

When contributing to this repository, please first discuss the change you wish to make via issue,
email, or any other method with the owners of this repository before making a change.