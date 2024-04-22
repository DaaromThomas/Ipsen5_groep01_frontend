FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Ipsen5_groep01_frontend/Ipsen5_groep01_frontend.csproj", "Ipsen5_groep01_frontend/"]
RUN dotnet restore "Ipsen5_groep01_frontend/Ipsen5_groep01_frontend.csproj"
COPY . .
WORKDIR "/src/Ipsen5_groep01_frontend"
RUN dotnet build "Ipsen5_groep01_frontend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ipsen5_groep01_frontend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ipsen5_groep01_frontend.dll"]
