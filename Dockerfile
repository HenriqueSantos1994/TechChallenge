FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
EXPOSE 8080
WORKDIR /app

COPY API/API.csproj ./
RUN dotnet restore

COPY ./ /
RUN dotnet publish "/API/API.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "API.dll"]