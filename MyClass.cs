public class FibbonacheClass
{
    public double _a;
    public double _b;
    public double _Summ;
    double _fibbonacheSummStepI;
    double _fibbonacheBefore;
    double _fibbonacheAfter;

    public FibbonacheClass()
    {
        _a = 0;
        _b = 1;
        _fibbonacheBefore = _a;
        _fibbonacheAfter = _b;
        _fibbonacheSummStepI = 0;
        _Summ = _a + _b;
    }
    public double fibbonacheNumber()
    {
            _fibbonacheSummStepI = _fibbonacheBefore + _fibbonacheAfter;
            _fibbonacheBefore = _fibbonacheAfter;
            _fibbonacheAfter = _fibbonacheSummStepI;
            _Summ = _Summ + _fibbonacheAfter;
            return _fibbonacheAfter;
    }
}