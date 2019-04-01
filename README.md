<img src="https://github.com/relay-dev/core/raw/master/resources/icon.png?raw=true" alt="Core" style="max-width:100%; float: left; padding-right: 50px; margin: 20px 0;" height="200" width="200">

# Core

[![Build status](https://ci.appveyor.com/api/projects/status/uy3l50i1p1gxu1pe/branch/master?svg=true)](https://ci.appveyor.com/project/sfergusonATX/core/branch/master)
[![NuGet Release](https://img.shields.io/nuget/v/relay.core.svg)](https://www.nuget.org/packages/Relay.Core/)
[![MyGet Release](https://img.shields.io/myget/relay-dev/v/Relay.Core.svg)](https://www.myget.org/feed/relay-dev/package/nuget/Relay.Core)
[![License](https://img.shields.io/github/license/relay-dev/core.svg)](https://github.com/relay-dev/core/blob/master/LICENSE)

A bare-bones, plugin model application framework for .NET Core

<sup>Core is a base class library written on .NET Core. It consists only of abstractions, contracts and interfaces. Core is meant to be a stable code base which defines common APIs which are shared across consuming applications. Implementations of Core come in the form of "Plugins", which can be found here (github: [core-plugins](https://github.com/relay-dev/core-plugins) // nuget: [Relay.Core.Plugins](https://www.nuget.org/packages/Relay.Core.Plugins/))</sup>

<sup>All APIs are fully documented in a .chm file located [here](https://github.com/relay-dev/core/raw/master/docs/Core%20API%20Documentation.zip). A formal arcitectural diagram and documention coming soon.</sup>

<center><img src="https://github.com/relay-dev/core/raw/master/resources/break.jpg?raw=true"></center>


## Installation

Here's how you can install the Relay.Core [NuGet Package](https://www.nuget.org/packages/Relay.Core):

#### *.NET Core CLI*

```
dotnet add package Relay.Core
```

#### *Package Manager Console*

```
Install-Package Relay.Core
```


## Folder structure
<sup>(https://gist.github.com/davidfowl/ed7564297c61fe9ab814)</sup>

```
$/
  artifacts/
  build/
  docs/
  lib/
  packages/
  resources/
  samples/
  src/
  tests/
  .editorconfig
  .gitignore
  .gitattributes
  build.cmd
  build.sh
  LICENSE
  NuGet.Config
  README.md
  {solution}.sln
```


- `src` - Main projects (the product code)
- `tests` - Test projects
- `docs` - Documentation stuff, markdown files, help files etc.
- `samples` (optional) - Sample projects
- `lib` - Libraries that your application depends on, which you cannot obtian by way of NuGet
- `artifacts` - Build outputs go here. Doing a build.cmd/build.sh generates artifacts here (nupkgs, dlls, pdbs, etc.)
- `packages` - NuGet packages
- `resources` - Misc. files referenced by the application (NuGet package image, etc.)
- `build` - Build customizations (custom msbuild files/psake/fake/albacore/etc) scripts
- `build.cmd` - Bootstrap the build for windows
- `build.sh` - Bootstrap the build for *nix
- `global.json` - ASP.NET vNext only
