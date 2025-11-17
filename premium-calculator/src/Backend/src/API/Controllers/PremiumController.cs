using Application.Premiums;using MediatR;using Microsoft.AspNetCore.Mvc;
namespace API.Controllers;
[ApiController][Route("api/premium")]
public class PremiumController:ControllerBase{
 private readonly IMediator med;
 public PremiumController(IMediator m)=>med=m;
 [HttpPost("calculate")]
 public async Task<IActionResult> Calc(CalculatePremiumCommand c)=>Ok(await med.Send(c));
}