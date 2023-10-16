using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Fraction
{
    private int  _top;
    
    private int  _Bottom;

    //constructors
    public Fraction() {
        _top = 1;
        _Bottom = 1;
    }
    public Fraction(int Numerator) {
        _top = Numerator;
        _Bottom = 1;
    }

    public Fraction (int Numerator,  int Denominator) {
        _top = Numerator;
        _Bottom = Denominator;
    }
    public void Set_Top(int top) { 
        _top = top;
    }
    public int  GetTop(){ 
    return _top;
    }


    public int GetBottom() {
        return  _Bottom;
    }

    public void Set_Bottom(int Bottom) {
        _Bottom = Bottom;
    }

     public string GetFractionString() {
        return $"{_top}/{_Bottom}";
     }

     public string  GetDecimalValue() {
        float dec = _top/_Bottom;
        return $"{dec}";
     }
}
  

    
