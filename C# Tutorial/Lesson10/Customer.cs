
public class Customer
{
    private int m_id = -1;

    public int GetID()
    {
        return m_id;
    }

    public void SetID(int id)
    {
        m_id = id;
    }

    private string m_name = string.Empty;

    public string GetName()
    {
        return m_name;
    }

    public void SetName(string name)
    {
        m_name = name;
    }
}
