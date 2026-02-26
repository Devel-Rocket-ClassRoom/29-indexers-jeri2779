using System.Collections;

class MultiIndexer
{
    private Hashtable _data = new Hashtable();

    public string this[int index]
    {
        get { return (string)_data[index]; }
        set { _data[index] = value; }
    }
    public string this[string key]
    {
        get { return (string)_data[key]; }
        set { _data[key] = value; }
    }
}


