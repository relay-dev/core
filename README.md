<img src="https://github.com/relay-dev/core/raw/master/resources/icon.png?raw=true" alt="Core" style="max-width:100%; float: left; padding-right: 50px; margin: 20px 0;" height="200" width="200">

# Core

[![Build status](https://ci.appveyor.com/api/projects/status/uy3l50i1p1gxu1pe/branch/master?svg=true)](https://ci.appveyor.com/project/sfergusonATX/core/branch/master)
[![NuGet Release](https://img.shields.io/nuget/v/relay.core.svg)](https://www.nuget.org/packages/Relay.Core/)
[![MyGet Release](https://img.shields.io/myget/relay-dev/v/Relay.Core.svg)](https://www.myget.org/feed/relay-dev/package/nuget/Relay.Core)
[![License](https://img.shields.io/github/license/relay-dev/core.svg)](https://github.com/relay-dev/core/blob/master/LICENSE)

A bare-bones, plugin model application framework for .NET Core

> <sup>Core is a set of base class libraries written using .NET Standard. The code base consists of abstractions, contracts, stubs and interfaces only. Core is intended to be a reliable and stable code base which defines shared APIs, desgined and assemled to distribute them across application consumers.</sup>
> 
> <sup>Consumers get the advantage of depending only on abstractions, ensuring that specific technological implementations can seemlessly evolve in and out of platform applications over time (while conforming to the generic API).</sup>
>
> <sup>Core is delivered to consuming applications by way of the main public NuGet feed (see section [Installation](#installation)). Implementations of the Core stubs come in the form of Core Plugins, which can be found here (github: [core-plugins](https://github.com/relay-dev/core-plugins) // nuget: [Relay.Core.Plugins](https://www.nuget.org/packages/Relay.Core.Plugins/))</sup>
> 
> <sup>All APIs are fully documented in a .chm file located [here](https://github.com/relay-dev/core/raw/master/docs/Core%20API%20Documentation.chm)</sup>

<br />

<img src="https://github.com/relay-dev/core/raw/master/resources/break.jpg?raw=true">

<br />

### Production Deployment

https://www.nuget.org/packages/Relay.Core

<br />

<div id="installation"></div>

### Installation

Here's how you can install the Core NuGet Package:

<br />

> #### *.NET Core CLI*
> 
> ```
> dotnet add package Relay.Core
> ```
>
> #### *Package Manager Console*
> 
> ```
> Install-Package Relay.Core
> ```