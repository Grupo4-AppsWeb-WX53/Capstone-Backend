using Data;

namespace Domain;

public class StoreDomain : IStoreDomain
{
    public bool create(string name)
    {
        if ( name == "product" )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool update(int id, string name)
    {
        throw new NotImplementedException();
    }

    public bool delete(int id)
    {
        throw new NotImplementedException();
    }
}