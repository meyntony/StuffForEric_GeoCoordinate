using GeoCoordinateStuff;
using System.Device.Location;

double latitude;
double longitude; 
bool isValid = true;

do {
	if (!isValid)
	{
		Console.WriteLine("Invalid latitude and longitude. Please try again.");
	}
	Console.WriteLine("Enter latitude:");
	latitude = double.TryParse(Console.ReadLine(), out latitude) ? latitude : -100;
	Console.WriteLine("Enter longitude:");
	longitude =  double.TryParse(Console.ReadLine(), out longitude) ? longitude : -100;
	isValid = StuffForEric.IsValid(latitude, longitude);

} while (!isValid);

var x = new GeoCoordinate(latitude, longitude);

Console.WriteLine($"Latitude: {x.Latitude}, Longitude: {x.Longitude}");

var distance = x.GetDistanceTo(new GeoCoordinate(0, 0));

Console.WriteLine($"Distance to 0,0: {distance} meters");
