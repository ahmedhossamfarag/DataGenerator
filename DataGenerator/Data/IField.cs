namespace DataGenerator.Data
{
    public interface IField
    {
        string Generate(Random random, DataSource dataSrc);
    }
}
