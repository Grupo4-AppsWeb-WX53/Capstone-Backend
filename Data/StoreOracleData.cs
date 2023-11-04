namespace Data;

public class StoreOracleData : IStoreData
{
    public string GetById(int id)
    {
        return "return " + id.ToString() + " Oracle";
    }

    public string[] GetAll()
    {
        throw new NotImplementedException();
    }
}