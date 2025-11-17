using Application.Interfaces;using Domain;using MediatR;
namespace Application.Premiums;
public class CalculatePremiumHandler:IRequestHandler<CalculatePremiumCommand,double>{
 private readonly IOccupationRepository repo;
 public CalculatePremiumHandler(IOccupationRepository r)=>repo=r;
 public async Task<double> Handle(CalculatePremiumCommand r,CancellationToken ct){
  var occ=await repo.GetByNameAsync(r.Occupation);
  var factor=OccupationRating.RatingFactors[occ.Rating];
  return Math.Round((r.SumInsured*factor*r.Age)/1000*12,2);
 }}