class Car
{
    private string[] _names;

    public Car(int length)
    {
        _names = new string [length];

    }
    public int Length
    {
        get { return _names.Length; }
    }
    public string this[int index]
    {
        get { return _names[index]; }
        set { _names[index] = value; }
    }

}