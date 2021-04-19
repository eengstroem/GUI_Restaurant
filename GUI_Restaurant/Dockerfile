#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["GUI_Restaurant/GUI_Restaurant.csproj", "GUI_Restaurant/"]
RUN dotnet restore "GUI_Restaurant/GUI_Restaurant.csproj"
COPY . .
WORKDIR "/src/GUI_Restaurant"
RUN dotnet build "GUI_Restaurant.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GUI_Restaurant.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GUI_Restaurant.dll"]