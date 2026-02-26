using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;

// README.md를 읽고 코드를 작성하세요.

//FruitPriceList[] list =
//{
//    new FruitPriceList { }, //[0]
//    new FruitPriceList { }  //[1]
//    new FruitPriceList {  }
//};
//list[0].PrintInfo(" ");
//list[1].PrintInfo(" );
//list[2].PrintInfo(" ");// 안됨.

FruitPriceList list = new FruitPriceList(5);

list.Add("사과", 1500);
list.Add("바나나", 3000);
list.Add("딸기", 8000);

Console.WriteLine($"등록된 과일 수: {list.Count}개");

Console.WriteLine($"사과 가격: {list["사과"]}원");
Console.WriteLine($"바나나 가격: {list["바나나"]}원");
Console.WriteLine($"포도 가격: {list["포도"]}원");

for (int i = 0; i < list.Count; i++)
    Console.WriteLine($"{i}번: {list[i]}");

//foreach (var item in list)
//{
//    Console.WriteLine($"{}가격: {}");
//} /사용 가능?
class FruitPriceList
{
    private string[] _names;
    private int[] _prices;
    private int _count = 0;

    public FruitPriceList(int capacity)
    {
        _names = new string[capacity];
        _prices = new int[capacity];
    }

    public int Count
    {
        get { return _count; }
    }
    public void Add(string name, int price)
    {
        _names[_count] = name;
        _prices[_count] = price;
        _count++;
    }

    public int this[string name]
    {
        get
        {
            for (int i = 0; i < _count; i++)
            {
                if (_names[i] == name)
                    return _prices[i];
            }
            return -1;
        }
    }
    public string this[int index]
    {
        get
        {
            return _names[index];
        }
    }

}
