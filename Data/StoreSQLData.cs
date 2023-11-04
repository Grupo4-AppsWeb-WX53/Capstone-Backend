namespace Data;

public class StoreSQLData : IStoreData
{
    public string GetById(int id)
    {
        return "return " + id.ToString() + " SQL";
    }

    string[] IStoreData.GetAll()
    {
        throw new NotImplementedException();
    }
}