using System;

//access modifier, class, name of this class
public class Fraction
{
    //member variables
    //access modifier, data type, _name of the variable
    private int _top;
    private int _bottom;

    //Constructors
    //access modifier, name(same name with class), (could be no argument)
    public Fraction()
    {
        //at the beginning they should have 1/1
        _top = 1;
        _bottom = 1;
    }

    //in this constructor, it has a new parameter so we need data type 
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    //in this constructor, it has two new parameters so we need data type as well
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    
    //create Getter and Setter for both _top and _bottom
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    //Get the variable from Getter and Setter and return the result
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}