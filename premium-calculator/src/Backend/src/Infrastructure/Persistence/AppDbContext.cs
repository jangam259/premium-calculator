using Domain;using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Persistence;
public class AppDbContext:DbContext{
 public DbSet<Occupation> Occupations=>Set<Occupation>();
 public AppDbContext(DbContextOptions<AppDbContext>o):base(o){}
 protected override void OnModelCreating(ModelBuilder b){
  b.Entity<Occupation>().HasData(
   new Occupation{Id=1,Name="Cleaner",Rating="Light Manual"},
   new Occupation{Id=2,Name="Doctor",Rating="Professional"});
 }}