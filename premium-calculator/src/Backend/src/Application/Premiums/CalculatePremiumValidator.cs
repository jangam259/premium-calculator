using FluentValidation;
namespace Application.Premiums;
public class CalculatePremiumValidator:AbstractValidator<CalculatePremiumCommand>{
 public CalculatePremiumValidator(){
  RuleFor(x=>x.Name).NotEmpty();
  RuleFor(x=>x.Age).GreaterThan(0);
  RuleFor(x=>x.SumInsured).GreaterThan(0);
  RuleFor(x=>x.Occupation).NotEmpty();
 }}