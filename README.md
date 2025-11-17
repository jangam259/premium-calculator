# Simplified Premium Calculator (Clean Architecture without MediatR)

This repository contains a simplified Clean Architecture implementation:
- Backend: ASP.NET Core (single solution) with Repository + Service + Controller.
- Frontend: React + TypeScript (Vite).

Backend exposes:
GET /api/premium/occupations
POST /api/premium/calculate  { name, age, dateOfBirth, occupation, sumInsured }

Premium formula:
  Death Premium = (SumInsured * OccupationFactor * Age) / 1000 * 12

  Please find the project structure

  backend/
  src/
    Domain/
      Occupation.cs
    Application/
      Interfaces/
        IOccupationRepository.cs
      Services/
        PremiumService.cs
    Infrastructure/
        AppDbContext.cs
        OccupationRepository.cs
    API/
      Controllers/
        PremiumController.cs
      Program.cs
    simplified-premium.csproj
  tests/
    PremiumCalculator.Tests/
      PremiumCalculator.Tests.csproj
      PremiumServiceTests.cs

frontend/
  client/
    package.json
    tsconfig.json
    vite.config.ts
    index.html
    src/
      main.tsx
      App.tsx
      api/
        premiumApi.ts
      components/
        PremiumForm.tsx
      styles.css
