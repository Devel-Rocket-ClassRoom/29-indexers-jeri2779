using System;
using System.Reflection;

// README.md를 읽고 코드를 작성하세요.

ScoreBoard sb = new ScoreBoard(5);

sb.Register("김민수", 85);
sb.Register("이지영", 92);
sb.Register("박서준", 78);

Console.WriteLine($"등록된 학생 수: {sb.Count}명\n");

for (int i = 0; i < sb.Count; i++)
    Console.WriteLine($"{i}번: {sb[i]}");

Console.WriteLine();
Console.WriteLine($"김민수 점수: {sb["김민수"]}점");
Console.WriteLine($"이지영 점수: {sb["이지영"]}점");
Console.WriteLine($"홍길동 점수: {sb["홍길동"]}점");

Console.WriteLine();
sb["김민수"] = 95;   
Console.WriteLine($"김민수 수정된 점수: {sb["김민수"]}점");

class ScoreBoard
{
    private string[] _names;
    private int[] _score;
    private int _count = 0;

    public ScoreBoard(int capacity)
    {
        _names = new string[capacity];
        _score = new int[capacity];
    }
    public int Count
    {
        get { return _count; }
    }


    public void Register(string name, int score)
    {
        if (_count >= _names.Length)
        {
            Console.WriteLine("성적표가 가득찼습니다");
            return;
        }
        _names[_count] = name;
        _score[_count] = score;
        _count++;
    }
    public string this[int index]
    {
        get
        {
            return _names[index];
        }
    }

    public int this[string name]
    {
        get
        {
            for (int i = 0; i < _count; i++)
            {
                if (_names[i] == name)
                    return _score[i];
            }
            return -1;
        }
        set
        {
            for (int i = 0; i < _count; i++)
            {
                if (_names[i] == name)
                {
                    _score[i] = value;   
                }
            }
        }

    }
}
