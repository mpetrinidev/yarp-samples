FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["YarpSamples.ReverseProxy.csproj", "./"]
RUN dotnet restore "./YarpSamples.ReverseProxy.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "YarpSamples.ReverseProxy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "YarpSamples.ReverseProxy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YarpSamples.ReverseProxy.dll"]