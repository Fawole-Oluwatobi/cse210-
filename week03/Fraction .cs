public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor 1: no parameters (defaults to 1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: one parameter (numerator only, denominator = 1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: two parameters (numerator and denominator)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for numerator (top)
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter and Setter for denominator (bottom)
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Return fraction string, e.g., "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return decimal value, e.g., 0.75
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
