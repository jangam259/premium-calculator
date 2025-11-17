using Application.Premiums;using Domain;using Application.Interfaces;using Moq;
public class PremiumTests{
 [Fact]public async Task Calc(){
  var r=new Mock<IOccupationRepository>();
  r.Setup(x=>x.GetByNameAsync("Cleaner")).ReturnsAsync(new Occupation{Name="Cleaner",Rating="Light Manual"});
  var h=new CalculatePremiumHandler(r.Object);
  var res=await h.Handle(new CalculatePremiumCommand("A",30,new DateOnly(1995,1,1),"Cleaner",500000),default);
  Assert.True(res>0);
 }}