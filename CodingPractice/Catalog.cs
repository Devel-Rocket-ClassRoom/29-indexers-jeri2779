class Catalog
{
    public string this[int index]
    {
        get
        {
            return (index % 2 == 0) ? $"{index}: 짝수 반환" : $"{index}: 홀수 반환";
        }
    }
}