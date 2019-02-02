#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet AS build
WORKDIR /src
COPY ["WebApi.Swagger.QuickStart/WebApi.Swagger.QuickStart.csproj", "WebApi.Swagger.QuickStart/"]
COPY ["WebApi.Swagger.QuickStart.Model/WebApi.Swagger.QuickStart.Model.csproj", "WebApi.Swagger.QuickStart.Model/"]
COPY ["WebApi.Swagger.QuickStart.Services/WebApi.Swagger.QuickStart.Services.csproj", "WebApi.Swagger.QuickStart.Services/"]
COPY ["WebApi.Swagger.QuickStart.DAL/WebApi.Swagger.QuickStart.DAL.csproj", "WebApi.Swagger.QuickStart.DAL/"]
RUN dotnet restore "WebApi.Swagger.QuickStart/WebApi.Swagger.QuickStart.csproj"
COPY . .
WORKDIR "/src/WebApi.Swagger.QuickStart"
RUN dotnet build "WebApi.Swagger.QuickStart.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebApi.Swagger.QuickStart.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebApi.Swagger.QuickStart.dll"]