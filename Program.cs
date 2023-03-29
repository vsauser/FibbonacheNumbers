// See https://aka.ms/new-console-template for more information
int _n;
string _continue = "0";
double _a;
double _b;
double _fibbonacheSumm = 0;

Console.WriteLine("Summator for Fibbonache numbers");
Console.WriteLine();

do
{
    FibbonacheClass fibbonacheClass = new FibbonacheClass();
    Console.Write("Insert numbers for Fibbonache sequence:");

    _n = Convert.ToInt32(Console.ReadLine());
    _a = fibbonacheClass._a;
    _b = fibbonacheClass._b;
    _fibbonacheSumm = _a + _b;

    Console.WriteLine(_a);
    Console.WriteLine(_b);

    for(int i = 1; i < (_n - 1); i++)
    {
        Console.WriteLine(fibbonacheClass.FibbonacheNumber());
    }  

    Console.WriteLine("Sum of Fibbonache sequence = " + fibbonacheClass._Summ);
    Console.WriteLine();
    Console.WriteLine("If you want to continue - press 1, if not - press any key");

    _continue =Console.ReadLine();

}while(_continue == "1");

Console.ReadLine();