using System;
using static System.Console;

class RatNumber
{
    public RatNumber()
    {
        Numerator = 0;
        Denominator = 1;
    }

    public RatNumber(int n, uint d)
    {
        Numerator = n;
        Denominator = d;
    }

    public int Numerator { get; set; }
    public uint Denominator { get; set; }
    public float Delenie { get => (float)Numerator / Denominator; }

    public static int NOD(int a, int b)
    {
        while (b != 0)
            b = a % (a = b);
        return a;
    }

    public void WriteNumDen()
    {
        int n;
        uint d;
        for (;;)
        {
            Write("  Ввелите числитель ");
            if (int.TryParse(ReadLine(), out n))
            {
                break;
            }
            WriteLine("Неправильный ввод.");
        }
        for (;;)
        {
            Write("  Введите знаменатель ");
            if (uint.TryParse(ReadLine(), out d) && d != 0)
            {
                break;
            }
            WriteLine("Неправильный ввод.");
        }
        Numerator = n;
        Denominator = d;
    }

    public static void WriteNum(ref RatNumber a)
    {
        try
        {
            if (!(a is RatNumber))
                return;
            WriteLine("Введите число");
            string abc = ReadLine();
            for (int i = 0; i < abc.Length; ++i)
            {
                if (abc[i] == ',')
                {
                    if (!float.TryParse(abc, out float z))
                        return;
                    a = z;
                    return;
                }
                if (abc[i] >= '0' || abc[i] <= '9')
                    continue;
                else
                {
                    WriteLine("Неверный ввод");
                    return;
                }
            }
            if (!int.TryParse(abc, out int zz))
                return;
            a = zz;
        }

        catch(Exception ex)
        {
            WriteLine(ex.Message);
        }
    }

    public void NumOut()
    {
        WriteLine(string.Format("{0}/{1}, 0x{0:X}/0x{1:X}, {2:f2}, {2:E}, {2:G},", Numerator, Denominator, Delenie));
    }

    public bool Equals(RatNumber obj)
    {
        if (obj == null)
            return false;
        if (Delenie == obj.Delenie)
            return true;
        return false;
    }

    public override int GetHashCode()
    {
        return Tuple.Create(Numerator, Denominator).GetHashCode();
    }

    public static RatNumber operator + (RatNumber a, RatNumber b)
    {
        int NOK = (int)a.Denominator * (int)b.Denominator / NOD((int)a.Denominator, (int)b.Denominator);
        return new RatNumber(a.Numerator * NOK / (int)a.Denominator + b.Numerator * NOK / (int)b.Denominator, (uint)NOK);
    }

    public static RatNumber operator - (RatNumber a, RatNumber b)
    {
        int NOK = (int)a.Denominator * (int)b.Denominator / NOD((int)a.Denominator, (int)b.Denominator);
        return new RatNumber(a.Numerator * NOK / (int)a.Denominator - b.Numerator * NOK / (int)b.Denominator, (uint)NOK);
    }

    public static RatNumber operator * (RatNumber a, RatNumber b) => new RatNumber(a.Numerator * b.Numerator, a.Denominator * b.Denominator);

    public static RatNumber operator / (RatNumber a, RatNumber b) => new RatNumber(a.Numerator * (int)b.Denominator, a.Denominator * (uint)b.Numerator);

    public static bool operator > (RatNumber a, RatNumber b)
    {
        if (a.Delenie > b.Delenie)
            return true;
        return false;
    }

    public static bool operator >= (RatNumber a, RatNumber b)
    {
        if (a.Delenie >= b.Delenie)
            return true;
        return false;
    }

    public static bool operator < (RatNumber a, RatNumber b)
    {
        if (a.Delenie < b.Delenie)
            return true;
        return false;
    }
    public static bool operator <= (RatNumber a, RatNumber b)
    {
        if (a.Delenie <= b.Delenie)
            return true;
        return false;
    }

    public static implicit operator RatNumber(int i)
    {
        return new RatNumber(i,1) ;
    }

    public static implicit operator RatNumber(float d)
    {
        if (d - (int)d == 0)
            return new RatNumber((int)d, 1);
        string hot = d.ToString();
        char[] aaa = hot.ToCharArray();
        for (int g = 0; g < 25; ++g)
        {
            if (aaa[g] == ',')
                break;
            aaa[g] = '0';
        }
        hot = new string(aaa);
        float z = float.Parse(hot);
        int i = 0;
        while ( z - (int)z != 0 )
        {
            z *= 10;
            ++i;
        }
        int num1 = (int)(d * 10 * i);
        int st = 10 * i;
        while( num1 % 2 == 0 && st % 2 == 0 )
        {
            num1 /= 2;
            st /= 2;
        }
        while (num1 % 5 == 0 && st % 5 == 0)
        {
            num1 /= 5;
            st /= 5;
        }

        return new RatNumber(num1, (uint)st);
    }

    public static explicit operator int(RatNumber a)
    {
        return (int)a.Delenie;
    }

    public static explicit operator float(RatNumber a)
    {
        return a.Delenie;
    }
}
