namespace Domain;
public static class OccupationRating {
 public static readonly Dictionary<string,double> RatingFactors = new() {
  {"Professional",1.5},{"White Collar",2.25},{"Light Manual",11.50},{"Heavy Manual",31.75}
 };
}