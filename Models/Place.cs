using System.ComponentModel.DataAnnotations;


namespace places_webapi.Models;

public class Place
{
	public uint PlaceId { get; set; }

	[MaxLength(128)]
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public decimal Latitude { get; set; }
	public decimal Longitude { get; set; }
}