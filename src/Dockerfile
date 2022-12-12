#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

# FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
# WORKDIR /app
# EXPOSE 80
# EXPOSE 443

# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# WORKDIR /src
# COPY ["IconApp/IconApp.csproj", "IconApp/"]
# RUN dotnet restore "IconApp/IconApp.csproj"
# COPY . .
# WORKDIR "/src/IconApp"
# RUN dotnet build "IconApp.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "IconApp.csproj" -c Release -o /app/publish

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "IconApp.dll"]


# https://hub.docker.com/_/microsoft-dotnet


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# copy csproj and restore as distinct layers
COPY IconApp/*.csproj .
RUN dotnet restore --use-current-runtime  

# copy everything else and build app
COPY IconApp/. .
RUN dotnet publish -c Release -o /app --use-current-runtime --self-contained false --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "IconApp.dll"]
