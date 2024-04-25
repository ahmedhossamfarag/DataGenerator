
using System.Text.RegularExpressions;

namespace DataGenerator.Data
{
    public class TextField : IField
    {
        public int Min { get; set; } = 0;
        public int Max { get; set; } = 10;

        public string Generate(Random random, DataSource dataSrc)
		{
            string text = string.Empty;
            if (Min >= 0 && Max >= Min)
            {
				int max = random.Next(Min, Max + 1);
				for (int i = 0; i < max; i++)
				{
					char c;
					do
					{
						c = (char)random.Next(32, 126);
					} while (c == '\"' || c == '\\');
					text += c;
				}
			}
            return '\"' + text + '\"';
        }
    }
}
