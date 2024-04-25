
namespace DataGenerator.Data
{
    public class FListField : IField
    {
        public List<string> Options { get; set; } = [];

        public virtual string Generate(Random random, DataSource dataSrc)
		{
            return '\"' + (Options.Any() ? Options[random.Next(Options.Count)] : "") + '\"';
        }
    }
}
