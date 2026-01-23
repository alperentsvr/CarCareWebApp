# --- Stage 1: Frontend Build ---
FROM node:20-alpine AS frontend-build
WORKDIR /app
COPY frontend/package*.json ./
RUN npm install --legacy-peer-deps
COPY frontend/ ./
RUN npm run build

# --- Stage 2: Backend Build ---
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS backend-build
WORKDIR /src
COPY backend/CarCare.Domain/CarCare.Domain.csproj CarCare.Domain/
COPY backend/CarCare.Application/CarCare.Application.csproj CarCare.Application/
COPY backend/CarCare.Persistence/CarCare.Persistence.csproj CarCare.Persistence/
COPY backend/CarCare.WebApi/CarCare.WebApi.csproj CarCare.WebApi/
RUN dotnet restore "CarCare.WebApi/CarCare.WebApi.csproj"

COPY backend/ ./
RUN dotnet publish "CarCare.WebApi/CarCare.WebApi.csproj" -c Release -o /app/publish

# --- Stage 3: Final Image ---
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# Copy Backend
COPY --from=backend-build /app/publish .

# Copy Frontend to wwwroot
COPY --from=frontend-build /app/dist ./wwwroot

ENTRYPOINT ["dotnet", "CarCare.WebApi.dll"]
