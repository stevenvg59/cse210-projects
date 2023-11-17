using System.ComponentModel.DataAnnotations;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() //Constructor with no parameteres
    { 
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top) //Constructor with only numerator (top)
    {
        _top = top;
        _bottom = 1;
    }


    public Fraction(int top, int bottom) //Constructor with both numerator and denominator
    {
        _top = top;
        _bottom = bottom;
    }

    public void Display() //Testing the display for each part of the fraction
    {
        Console.WriteLine("Top: " + _top +" and bottom: " + _bottom );
    }

    //GETTERS
    public int GetTop() 
    {
        return _top;
    }

    public int GetBottom() 
    {
        return _bottom;
    }

    //SETTERS
    public void SetTop(int top) 
    {
        _top = top;
    }

    public void SetBottom(int bottom) 
    {
        _bottom = bottom;
    }

    public string GetFractionString() //Getting the form "3/4" fraction string
    {

        return ($"{_top}/{_bottom}");
    }

    public double GetDecimalValue() //Computing the decimal value using double (decimals)
    {
        double result;
        result = (double)_top/(double)_bottom;
        return result;
    }
}