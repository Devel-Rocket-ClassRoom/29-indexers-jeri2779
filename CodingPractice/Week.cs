class Week
{
    private string[] _weekDays;

    public Week()
    {
        Length = 7;
        _weekDays = new string[Length];
    }
    public Week(int length)
    {
        Length = length;
        _weekDays = new string[Length];
         
    }

    public int Length { get; }

    public string this[int index]
    {
        get {  return _weekDays[index]; }
        set { _weekDays[index] = value; }
    }
}

