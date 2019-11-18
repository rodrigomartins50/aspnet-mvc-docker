FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
LABEL version="1.0"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "aspnet-mvc-docker.dll"]