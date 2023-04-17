namespace places_webapi.Models.RandomUsers;

public class Location
{
	public Street Street { get; set; } = new Street();
	public string City { get; set; } = string.Empty;
	public string State { get; set; } = string.Empty;
	public string Country { get; set; } = string.Empty;
	//public string Postcode { get; set; } = string.Empty;
	public Coordinates Coordinates { get; set; } = default!;

}