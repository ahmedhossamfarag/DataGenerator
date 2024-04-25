using DataGenerator.Components.Pages;
using System.Text;

namespace DataGenerator.Data
{
    public class DataField
    {
        public FieldType Type { get; set; } = FieldType.Text;

        public string Name { get; set; } = string.Empty;

        public IField Field { get; set; } = new TextField();


        public void Generate(StringBuilder builder, Random random, DataSource dataSrc)
		{
            builder.Append($"\t\t\"{(Name.Any() ? Name : Type)}\": ");
            builder.Append(Field?.Generate(random, dataSrc));
        }
    }
}
