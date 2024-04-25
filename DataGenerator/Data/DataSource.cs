
using System.Text.Json;

namespace DataGenerator.Data
{
	public class DataSource
	{
		private string _namesJson = "wwwroot/names.json";
		private string _countriesJson = "wwwroot/countries.json";

		public List<string> ?Names { get; set; }

		public Dictionary<string, string[]> ?Countries { get; set; }

		public List<string> ?Cities { get; set; }

		public async Task InitializeAsync()
		{
			if (Names == null)
				await InitializeNamesAsync();
			if (Countries == null)
				await InitializeCountriesAsync();
			if (Cities == null)
				InitializeCities();
		}

		private async Task InitializeNamesAsync()
		{
			try
			{
				using (var streamReader = new StreamReader(_namesJson))
				{
					Names = await JsonSerializer.DeserializeAsync<List<string>>(streamReader.BaseStream);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private async Task InitializeCountriesAsync()
		{
			try
			{
				using (var streamReader = new StreamReader(_countriesJson))
				{
					Countries = await JsonSerializer.DeserializeAsync<Dictionary<string, string[]>>(streamReader.BaseStream);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void InitializeCities()
		{
			Cities = new List<string>();
			if(Countries != null)
				foreach (var l in Countries.Values.ToList())
					Cities.AddRange(l);
		}
	}
}
