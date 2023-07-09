FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 44302
EXPOSE 44303
EXPOSE 44310


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Fernweh.Identity.Admin/Fernweh.Identity.Admin.csproj", "src/Fernweh.Identity.Admin/"]
COPY ["src/Fernweh.Identity.Admin.EntityFramework.Shared/Fernweh.Identity.Admin.EntityFramework.Shared.csproj", "src/Fernweh.Identity.Admin.EntityFramework.Shared/"]
COPY ["src/Fernweh.Identity.Admin.EntityFramework.SqlServer/Fernweh.Identity.Admin.EntityFramework.SqlServer.csproj", "src/Fernweh.Identity.Admin.EntityFramework.SqlServer/"]
COPY ["src/Fernweh.Identity.Shared/Fernweh.Identity.Shared.csproj", "src/Fernweh.Identity.Shared/"]
COPY ["src/Fernweh.Identity.Admin.EntityFramework.PostgreSQL/Fernweh.Identity.Admin.EntityFramework.PostgreSQL.csproj", "src/Fernweh.Identity.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/Fernweh.Identity.Admin.EntityFramework.MySql/Fernweh.Identity.Admin.EntityFramework.MySql.csproj", "src/Fernweh.Identity.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/Fernweh.Identity.Admin/Fernweh.Identity.Admin.csproj"
COPY . .
WORKDIR "/src/src/Fernweh.Identity.Admin"
RUN dotnet build "Fernweh.Identity.Admin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fernweh.Identity.Admin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "Fernweh.Identity.Admin.dll"]