dotnet new classlib --name Layered.Domain

dotnet sln LayeredAPI.sln add Layered.DAL/Layered.DAL.csproj

dotnet add Calculator\Calculator.csproj reference MathOperations\MathOperations.csproj

dotnet new webapi —name Layered.API

dotnet build

dotnet run

dotnet add Layered.DAL package Microsoft.EntityFrameworkCore 

dotnet add Layered.DAL package Microsoft.EntityFrameworkCore.SqlServer 

dotnet add Layered.DAL package Microsoft.EntityFrameworkCore.Tools

dotnet add Layered.DAL/Layered.DAL.csproj reference Layered.Domain/Layered.Domain.csproj

dotnet add Layered.API/Layered.API.csproj reference Layered.DAL/Layered.DAL.csproj

dotnet tool install --global dotnet-ef

dotnet add LAyered.API package Microsoft.EntityFrameworkCore.Design

dotnet ef --startup-project ../Layered.API/ migrations add "Initial"

dotnet ef --startup-project ../Layered.API/ database update 