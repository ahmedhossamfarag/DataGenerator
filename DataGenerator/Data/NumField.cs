
namespace DataGenerator.Data
{
    public class NumField : IField
    {
        public int Min { get; set; } = 0;
        public int Max { get; set; } = 10;

        public string Generate(Random random, DataSource dataSrc)
		{
            if(Max <= Min) { return Min.ToString(); }
            return random.NextInt64(Min, Max).ToString();
        }
    }
}
