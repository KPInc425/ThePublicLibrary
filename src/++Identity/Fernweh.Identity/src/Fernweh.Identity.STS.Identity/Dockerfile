FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 44310

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

#COPY src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.STS.Identity/entrypoint.sh .
#COPY src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.STS.Identity/ngix.conf .

COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.STS.Identity/Fernweh.Identity.STS.Identity.csproj /src/Fernweh.Identity.STS.Identity/Fernweh.Identity.STS.Identity.csproj
COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.Shared/Fernweh.Identity.Shared.csproj /src/Fernweh.Identity.Shared/Fernweh.Identity.Shared.csproj
COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.Admin/Fernweh.Identity.Admin.csproj /src/Fernweh.Identity.Admin/Fernweh.Identity.Admin.csproj
COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.Admin.EntityFramework.Shared/Fernweh.Identity.Admin.EntityFramework.Shared.csproj /src/Fernweh.Identity.Admin.EntityFramework.Shared/Fernweh.Identity.Admin.EntityFramework.Shared.csproj
COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.Admin.EntityFramework.SqlServer/Fernweh.Identity.Admin.EntityFramework.SqlServer.csproj /src/Fernweh.Identity.Admin.EntityFramework.SqlServer/Fernweh.Identity.Admin.EntityFramework.SqlServer.csproj
#COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.Admin.EntityFramework.PostgreSQL/Fernweh.Identity.Admin.EntityFramework.PostgreSQL.csproj /src/Fernweh.Identity.Admin.EntityFramework.PostgreSQL/Fernweh.Identity.Admin.EntityFramework.PostgreSQL.csproj

RUN dotnet restore /src/Fernweh.Identity.STS.Identity/Fernweh.Identity.STS.Identity.csproj
#RUN dotnet restore /src/Fernweh.Identity.Shared/Fernweh.Identity.Shared.csproj
#RUN dotnet restore /src/Fernweh.Identity.Admin/Fernweh.Identity.Admin.csproj
#RUN dotnet restore /src/Fernweh.Identity.Admin.EntityFramework.Shared/Fernweh.Identity.Admin.EntityFramework.Shared.csproj
#RUN dotnet restore /src/Fernweh.Identity.Admin.EntityFramework.SqlServer/Fernweh.Identity.Admin.EntityFramework.SqlServer.csproj
#RUN dotnet restore /src/Fernweh.Identity.Admin.EntityFramework.PostgreSQL/Fernweh.Identity.Admin.EntityFramework.PostgreSQL.csproj

WORKDIR /
COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.STS.Identity/ /src/Fernweh.Identity.STS.Identity/
COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.Shared/ /src/Fernweh.Identity.Shared/
COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.Admin/ /src/Fernweh.Identity.Admin/
COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.Admin.EntityFramework.Shared/ /src/Fernweh.Identity.Admin.EntityFramework.Shared/
COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.Admin.EntityFramework.SqlServer/ /src/Fernweh.Identity.Admin.EntityFramework.SqlServer/
#COPY ./src/++Fernweh.Identity/Fernweh.Identity/src/Fernweh.Identity.Admin.EntityFramework.PostgreSQL/ /src/Fernweh.Identity.Admin.EntityFramework.PostgreSQL/

#RUN dotnet build "/src/Fernweh.Identity.STS.Identity/Fernweh.Identity.STS.Identity.csproj" -c Release

FROM build AS publish
RUN dotnet publish /src/Fernweh.Identity.STS.Identity/Fernweh.Identity.STS.Identity.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "Fernweh.Identity.STS.Identity.dll"]