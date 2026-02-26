class Example
{
    private string _name;
    private string[] _items = new string[10];

    public string Name
    {
        get { return _name; } 
        set { _name = value; }
    }

    public string this[int index]
    {
        get { return _items[index]; }
        set { _items[index] = value; }
    }
}

