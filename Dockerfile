FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build-env
WORKDIR /Web

COPY /src/Server/ .
COPY /src/Client/ ../Client

RUN dotnet restore "Web.Server.csproj"
RUN dotnet build "Web.Server.csproj" -c Release -o /build

FROM build-env AS publish
RUN dotnet publish "Web.Server.csproj" -c Release -o /publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html

COPY --from=publish /publish/wwwroot /usr/local/webapp/nginx/html
COPY /src/Server/nginx.conf /etc/nginx/nginx.conf