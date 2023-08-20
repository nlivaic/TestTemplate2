#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
# Uncomment if you have other certs this services needs to trust.
#COPY nginx/id-local.crt /usr/local/share/ca-certificates/id-local.crt
#RUN update-ca-certificates
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/TestTemplate2.Api/TestTemplate2.Api.csproj", "src/TestTemplate2.Api/"]
COPY ["src/TestTemplate2.Data/TestTemplate2.Data.csproj", "src/TestTemplate2.Data/"]
COPY ["src/TestTemplate2.Common/TestTemplate2.Common.csproj", "src/TestTemplate2.Common/"]
COPY ["src/TestTemplate2.Core/TestTemplate2.Core.csproj", "src/TestTemplate2.Core/"]
RUN dotnet restore "src/TestTemplate2.Api/TestTemplate2.Api.csproj"
COPY . .
WORKDIR "/src/src/TestTemplate2.Api"
RUN dotnet build "TestTemplate2.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestTemplate2.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestTemplate2.Api.dll"]