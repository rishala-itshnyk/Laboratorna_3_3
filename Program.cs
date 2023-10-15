using System;

class Program
{
    static void Main()
    {
        double x; // вхідний аргумент
        double R; // вхідний параметр
        double y; // результат обчислення виразу
        Console.Write("R = ");
        R = Convert.ToDouble(Console.ReadLine());
        Console.Write("x = ");
        x = Convert.ToDouble(Console.ReadLine());

        // розгалуження в повній формі
        if (x <= -R)
        {
            y = R;
        }
        else
        {
            if (-R < x && x <= R)
            {
                y = R - Math.Sqrt(R * R - x * x);
            }
            else
            {
                if (R < x && x <= 6)
                {
                    y = R + ((-3 - R) / (6 - R)) * (x - R);
                }
                else
                {
                    y = -3 + ((0 + 3) / (9 - 6)) * (x - 6);
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("y = " + y);
        Console.ReadLine();
    }
}