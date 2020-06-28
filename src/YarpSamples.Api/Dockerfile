FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["YarpSamples.Api.csproj", "./"]
RUN dotnet restore "./YarpSamples.Api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "YarpSamples.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "YarpSamples.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YarpSamples.Api.dll"]