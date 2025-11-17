using MediatR;
namespace Application.Premiums;
public record CalculatePremiumCommand(string Name,int Age,DateOnly DateOfBirth,string Occupation,double SumInsured):IRequest<double>;