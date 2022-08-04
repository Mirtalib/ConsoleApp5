namespace ConsolApp5;



class Program
{
    static void Main()
    {
        // Console.WriteLine("Hello, World!");
        // Point x = new Point(12, 11);
        // Console.WriteLine(x);


        Counter counter = new Counter(0,5);

        // counter.Increment();
        // counter.Increment();
        // counter.Increment();
        // counter.Increment();
        // counter.Increment();
        // counter.Increment();
        // 
        // Console.WriteLine(counter);

        // counter.Decremnet();
        // counter.Decremnet();
        // counter.Decremnet();
        // counter.Decremnet();
        // counter.Decremnet();
        // counter.Decremnet();
        // Console.WriteLine(counter);


        Fraction a = new Fraction(6,3);
        Fraction b = new Fraction(4,7);


        Console.WriteLine(a.add(b));
        Console.WriteLine(a.Multiply(b));
        Console.WriteLine(a.minus(b));
        Console.WriteLine(a.Divide(b));

        a.Simplify();
        Console.WriteLine(a);
       

    }
}

struct Point
{
    private int X;
    private int Y;

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"{X} {Y}";
    }
}

  

class Counter
{
    private  int _min;
    private  int _max;
    private  int _value;

    public Counter()
    {
       _min = 0;
        _max = 10;
        _value = _min;
    }

    public Counter(int min , int max)
    {
        _min = min;
        _max = max;
        _value = min;
    }


    public  int Increment()
    {

        if (_value >= _max)
        {
            _value = _min;
            return _value;
        }
        else
        {
            return ++_value;
        }
    }

    public  int Decremnet()
    {

        if (_value <= _min)
        {
            _value = _max;
            return _value;
        }
        else
        {
            return --_value;
        }
    }

    public override string ToString()
    {
        return $"Count=> {_value}";
    }
}




struct Fraction
{

    private int _numerator; // suret
    private int _denominator; // mexrec


    public Fraction()
    {

        _numerator = 1;
        _denominator = 2;

    }
    public Fraction(int num, int don)
    {
        _numerator = num;
        _denominator = don;
    }
    public Fraction Multiply(Fraction  other) {
        Fraction s = new Fraction(_numerator * other._numerator, _denominator * other._denominator);
        return s;
	}

    public Fraction Divide( Fraction other)
    {
    
        Fraction a = new Fraction(_numerator * other._denominator, _denominator * other._numerator);
        return a;
    
    }

    public Fraction minus( Fraction other)
    {
    
        Fraction a = new Fraction(_numerator -other._numerator, _denominator - other._denominator);
        return a;
    }
    public Fraction add( Fraction other)
    {

        Fraction a = new Fraction(_numerator +other._numerator, _denominator + other._denominator);
        return a;
    }


    public void Simplify()
    {
    
        int i = 2;
    
        while (i  <= _denominator)
        {
    
            if (_denominator % i == 0 && _numerator % i == 0)
            {
                _denominator /= i;
                _numerator /= i;
            }
            else i++;
        }
    
    
    } 
    public override string ToString()
    {
        if(_numerator == _denominator)
            return "1";
        else
            return $"{_numerator}/{_denominator}";
        
    }
};
