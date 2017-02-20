using System;
namespace StudySesh
{
	public class Location
	{
		private string aliasField;
		private string detailField;
		private double latitudeField;
		private double longitudeField;

		public string alias
		{
			get
			{
				return aliasField;
			}
			set
			{
				aliasField = value;
			}
		}

		public string detail
		{
			get
			{
				return detailField;
			}
			set
			{
				detailField = value;
			}
		}

		public double latitude
		{
			get
			{
				return latitudeField;
			}
			set
			{
				latitudeField = value;
			}
		}

		public double longitude
		{
			get
			{
				return longitudeField;
			}
			set
			{
				longitudeField = value;
			}
		}

		public Location()
		{
		}
	}
}
