
namespace DataGenerator.Data
{
	public class CityField : FListField
	{
		public string Country { get; set; } = "All";

		public override string Generate(Random random, DataSource dataSrc)
		{
			if (dataSrc.Countries != null)
			{

				if (Country == "All" && dataSrc.Cities != null)
				{
					Options = dataSrc.Cities;
				}
				else if(dataSrc.Countries.ContainsKey(Country))
				{
						Options = dataSrc.Countries[Country].ToList();
				}
			}
			return base.Generate(random, dataSrc);
		}
	}
}
