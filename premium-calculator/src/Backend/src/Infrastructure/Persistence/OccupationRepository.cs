using Application.Interfaces;using Domain;using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Persistence;
public class OccupationRepository:IOccupationRepository{
 private readonly AppDbContext db;
 public OccupationRepository(AppDbContext d)=>db=d;
 public Task<Occupation?> GetByNameAsync(string name)=>db.Occupations.FirstOrDefaultAsync(x=>x.Name==name);
}