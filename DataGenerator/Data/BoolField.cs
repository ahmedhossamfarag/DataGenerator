
namespace DataGenerator.Data
{
    public class BoolField : IField
    {
        public string Generate(Random random, DataSource dataSrc)
		{
            return random.Next(2) == 0 ? "false":"true";
        }
    }
}
