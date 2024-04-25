using System.Text;
using System.Xml.Linq;

namespace DataGenerator.Data
{
    public class DataObject
    {
        public List<DataField> Fields { get; set; } = [];

        public void Generate(StringBuilder builder, Random random, DataSource dataSrc)
		{
            builder.AppendLine("\t{");
            for (int i = 0; i < Fields.Count; i++) 
            {
                Fields[i].Generate(builder, random, dataSrc);
                builder.AppendLine(i == Fields.Count - 1? "":",");
            }
            builder.Append("\t}");
        }
    }
}
