
namespace DataGenerator.Data
{
    public class DecField : IField
    {
        public double Min { get; set; } = 0;
        public double Max { get; set; } = 10;

        public string Generate(Random random, DataSource dataSrc)
		{
            return (Min + (random.NextDouble() * (Max - Min))).ToString();
        }
    }
}
