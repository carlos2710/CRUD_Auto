# 🚗 Cars API - Enterprise Backend Service

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET-Core-green)
![EF Core](https://img.shields.io/badge/Entity%20Framework-Core-purple)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red)
![Docker](https://img.shields.io/badge/Docker-ready-blue)
![CI/CD](https://img.shields.io/badge/CI%2FCD-GitHub%20Actions-orange)

---

## 🧭 Arquitectura del sistema

┌──────────────────────┐
│      Cars.Api        │  → Controllers / API REST
├──────────────────────┤
│ Cars.Infrastructure  │  → EF Core / Repositories
├──────────────────────┤
│    Cars.Domain       │  → Entidades de negocio
└──────────────────────┘

---

## ☁️ Arquitectura Cloud (AWS Ready)

Frontend
   ↓
API (Docker / ECS / Lambda)
   ↓
Database (SQL Server / AWS RDS)

---

## ⚙️ Tecnologías

- ASP.NET Core Web API
- .NET 8+
- Entity Framework Core
- SQL Server / LocalDB
- Swagger / OpenAPI
- Docker
- GitHub Actions (CI/CD)
- AWS Ready (ECS / Lambda / RDS)

---

## 🚀 Ejecución local

dotnet restore
dotnet build
dotnet ef database update --project Cars.Infrastructure --startup-project Cars.Api
dotnet run --project Cars.Api

---

## 🌐 Swagger

https://localhost:5145/swagger

---

## 🐳 Docker

docker build -t cars-api .
docker run -p 8080:80 cars-api

---

## 📡 Endpoints

GET /api/cars
GET /api/cars/{id}
POST /api/cars
PUT /api/cars
DELETE /api/cars/{id}

---

## 📦 Modelo de ejemplo

{
  "id": 1,
  "brand": "Toyota",
  "model": "Corolla",
  "year": 2023,
  "vehicleType": "Sedan",
  "seats": 5,
  "color": "Blanco",
  "fuelType": "Gasolina",
  "transmission": "Automática",
  "engineCapacityCc": 1800,
  "price": 25000,
  "isActive": true
}

---

## ⚡ CI/CD - GitHub Actions

name: .NET CI/CD Pipeline

on:
  push:
    branches: [ "main", "develop" ]

jobs:
  build:
    runs-on: ubuntu-latest

    steps:
    - uses: actions/checkout@v4
    - uses: actions/setup-dotnet@v4
      with:
        dotnet-version: '8.0.x'
    - run: dotnet restore
    - run: dotnet build --no-restore --configuration Release
    - run: dotnet test --no-build --configuration Release

---

## ☁️ AWS

- ECS Fargate
- RDS SQL Server
- Lambda (opcional)

---

## 👨‍💻 Autor

Proyecto backend profesional cloud-ready
