namespace Domain;

public interface IStoreDomain
{
    bool create(string name);
    bool update(int id, string name);
    bool delete(int id);
}