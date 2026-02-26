using System;

// README.md를 읽고 코드를 작성하세요.
class FruitPriceList
{
    private string[] _names;
    private int[] _prices;
    private int _count = 0;

    public FruitPriceList(int capacity)
    {
        _names = new string[capacity];
        _count = 0;
    }

    public int Count
    {
        get { return _names.Length; }
    }
    public void Add(string name, int price)
    {
        _names = new string[name];
        _prices = new int[price];
    }
}
