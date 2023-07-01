# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /
COPY ./src/__KnownAccountsCore/KnownAccounts/+KnownAccountsApi/src/entrypoint.sh .
ADD "https://www.random.org/cgi-bin/randbyte?nbytes=10&format=h" skipcache
COPY src/__KnownAccountsCore/KnownAccounts/+KnownAccountsApi/src/bin/Release/net7.0/publish/ .
RUN chmod +x ./entrypoint.sh

FROM base AS final
EXPOSE 7171/tcp

ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
CMD ["dotnet", "KnownAccountsApi.dll"]
#CMD /bin/bash ./entrypoint.sh