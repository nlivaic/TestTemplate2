#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/TestTemplate2.WorkerServices/TestTemplate2.WorkerServices.csproj", "src/TestTemplate2.WorkerServices/"]
COPY ["src/TestTemplate2.Core/TestTemplate2.Core.csproj", "src/TestTemplate2.Core/"]
COPY ["src/TestTemplate2.Common/TestTemplate2.Common.csproj", "src/TestTemplate2.Common/"]
RUN dotnet restore "src/TestTemplate2.WorkerServices/TestTemplate2.WorkerServices.csproj"
COPY . .
WORKDIR "/src/src/TestTemplate2.WorkerServices"
RUN dotnet build "TestTemplate2.WorkerServices.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestTemplate2.WorkerServices.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY ["src/TestTemplate2.WorkerServices/entrypoint.sh", "src/entrypoint.sh"]
COPY ["src/TestTemplate2.WorkerServices/wait-for-it.sh", "src/wait-for-it.sh"]
CMD ["/bin/bash", "src/entrypoint.sh"]
