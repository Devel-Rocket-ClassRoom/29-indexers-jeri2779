using System;
using System.Reflection;

// README.md를 읽고 코드를 작성하세요.

class ScoreBoard
{
    private string[] _names;
    private int[] _score = new int[10];
    private int _count = 0;

    public ScoreBoard(int capacity)
    {
        _names = new string[capacity]; 
        Count = 0;
    }
    public int Length
    {
        get { return _names.Length; }
    }


    public void Register(string name, int score)
    {
        _names = name.Split(',');
        _score = int[score];
    }
    public string this[int index]
    {
        get { return _names[index]; }
        set { _names[index] = value; }
    }

    public int this[string name]
    {
        get { return _names[name]; }
        set { _names[name] = value; }

    }
