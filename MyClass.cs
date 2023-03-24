public class MyClass
{
    string _str1;
    string _str2;
    public MyClass(string str1, string str2)
    {
        _str1 = str1;
        _str2 = str2;
    }
    public string Summ()
    {
        return _str1 + " " + _str2;
    }
}