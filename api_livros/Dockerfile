# Estágio de compilação (Build)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia apenas o arquivo de projeto para aproveitar o cache de camadas do Docker
COPY *.csproj ./
RUN dotnet restore

# Copia o restante do código e compila a aplicação
COPY . ./
RUN dotnet publish -c Release -o /app/out

# Estágio de execução (Runtime)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Configura a aplicação para escutar na porta 8080 (padrão do .NET 8)
ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "LivrosApi.dll"]
