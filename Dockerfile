FROM mcr.microsoft.com/dotnet/aspnet:8.0
LABEL version="1.0.2" description="Aplicacao ASP .NET Core MVC"
COPY dist /app
WORKDIR /app
EXPOSE 8080/tcp
ENTRYPOINT [ "dotnet","WebMvcDockerTest.dll" ]