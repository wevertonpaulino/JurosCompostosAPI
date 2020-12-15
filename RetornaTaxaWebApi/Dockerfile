FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["RetornaTaxaWebApi/RetornaTaxaWebApi.csproj", "RetornaTaxaWebApi/"]
RUN dotnet restore "RetornaTaxaWebApi/RetornaTaxaWebApi.csproj"
COPY . .
WORKDIR "/src/RetornaTaxaWebApi"
RUN dotnet build "RetornaTaxaWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RetornaTaxaWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RetornaTaxaWebApi.dll"]