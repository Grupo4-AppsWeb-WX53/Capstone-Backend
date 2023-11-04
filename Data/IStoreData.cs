namespace Data;

public interface IStoreData
{
    public string GetById(int id);
    public string[] GetAll();
}