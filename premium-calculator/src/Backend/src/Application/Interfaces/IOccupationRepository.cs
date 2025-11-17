using Domain;
namespace Application.Interfaces;
public interface IOccupationRepository { Task<Occupation?> GetByNameAsync(string name); }