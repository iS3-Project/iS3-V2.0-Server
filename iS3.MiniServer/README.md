# iS3 MiniServer

This project contains source code for the Mini-Server of [infrastructure Smart Service System (iS3)] (https://github.com/is3-project).

## Features
1. Data services
2. WebAPI
3. Account control

## System requirements
1. This project is targeted for .NET Framework 4.5 (or above), which is included in Windows 8+ and  Windows Server 2012+ by default. 
2. Minimum OS requirement: Windows Vista SP2, Windows 7 SP1, Windows Server 2008 R2 SP1, Windows Server 2008 SP2.
3. Minimum hardware requirement: 1 GHz CPU, 512 MB RAM, 850 MB disk spaces.

## Build instructions
1. This project is built on Microsoft Visual Studio 2017.
2. This project is dependent on a few packages, which could be installed using Nuget. Open Tools->NuGet Package Management->Package Manage Console, and input:
  * PM> Install-Package Microsoft.Owin.Hosting
  * PM> Install-Package Microsoft.Owin.Host.HttpListener
  * PM> Install-Package Microsoft.AspNet.WebApi.OwinSelfHost
  * PM> Install-Package EntityFramework.SqlServerCompact
  * PM> Install-Package Microsoft.AspNet.Identity.EntityFramework
  * PM> Install-Package Microsoft.AspNet.Identity.Owin

## Issus

## Contributing
Anyone and everyone is welcome to [contribute](CONTRIBUTING.md).

## Licensing
Copyright 2015 Tongji University iS3 Team.

This source is free software; you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation; either version 3 of the License, or (at your option) any later version.

This source is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details.

Extensions and plugins developed for this source, are allowed to remain closed source and can be distributed under any license.

A copy of the license is available in the repository's license.txt file.