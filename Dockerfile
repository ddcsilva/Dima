# Etapa 1: Build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copia os arquivos da solução inteira
COPY . .

# Restaura as dependências
RUN dotnet restore

# Publica apenas a API
RUN dotnet publish Dima.Api/Dima.Api.csproj -c Release -o out

# Etapa 2: Criar a imagem final com a API já compilada
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

# Copia os arquivos da API já compilados
COPY --from=build /app/out .

# Expõe a porta da API
EXPOSE 80

# Comando que será executado ao rodar o container
CMD ["dotnet", "Dima.Api.dll"]
