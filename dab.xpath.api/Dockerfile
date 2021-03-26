FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["dab.xpath.api/dab.xpath.api.csproj", "dab.xpath.api/"]
RUN dotnet restore "dab.xpath.api/dab.xpath.api.csproj"
COPY . .
WORKDIR "/src/dab.xpath.api"
RUN dotnet build "dab.xpath.api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "dab.xpath.api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dab.xpath.api.dll"]