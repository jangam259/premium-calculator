# Simplified Premium Calculator (Clean Architecture without MediatR)

This repository contains a simplified Clean Architecture implementation:
- Backend: ASP.NET Core (single solution) with Repository + Service + Controller (no MediatR).
- Frontend: React + TypeScript (Vite).

Run backend:
1. cd backend/src
2. dotnet run

Run frontend:
1. cd frontend/client
2. npm install
3. npm run dev

Backend exposes:
GET /api/premium/occupations
POST /api/premium/calculate  { name, age, dateOfBirth, occupation, sumInsured }

Premium formula:
  Death Premium = (SumInsured * OccupationFactor * Age) / 1000 * 12
