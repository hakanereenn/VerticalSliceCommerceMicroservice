FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Services/Discount/Discount.Gprc/Discount.Gprc.csproj", "Services/Discount/Discount.Gprc/"]
RUN dotnet restore "Services/Discount/Discount.Gprc/Discount.Gprc.csproj"
COPY . .
WORKDIR "/src/Services/Discount/Discount.Gprc"
RUN dotnet build "Discount.Gprc.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Discount.Gprc.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Discount.Gprc.dll"]
