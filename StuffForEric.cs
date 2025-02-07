using System.Device.Location;

namespace POC_GeoCoordinate
{
	public static class StuffForEric
	{
		public static bool IsValid(double latitude, double longitude) // Make this an API endpoint to validate coordinates
		{
			try { _ = new GeoCoordinate(latitude, longitude); } catch { return false; }
			return true;
		}
	}
}
