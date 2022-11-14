using System;

class Program
{

    static int zer_bit(uint x1)
    {
        int counter = 0;
        for (int i = 0; i < 32; i++)
        {
            if ((x1 & 1) == 0)counter++;
        }
        return counter;

        
    }
    static void bin_no_zer(int x2)
    {
        
        int mask = 0x8000;
        while ((x2 & mask) == 0)
        {
            mask >>= 1;
        }
        while (mask > 0){
            if ((x2 & mask) != 0) Console.Write("1");
            else Console.Write("0");
            mask >>= 1;
        }
    }
    static void cyclic_shift(int b, uint n) {
        int mask = 0x8000;
        
        for (int i = 0; i < n; i++) {
            Console.Write($"{(b >> (int)n -i-1) & 1}");   
        }
        for (int i = 0; i <= 31 - n; i++) {
            Console.Write($"{(b >> 31 -  i ) & 1}");
        }

    }
    

    
    public static void Main()
    {
        
        uint x1 = uint.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine($"В числе {x1} {zer_bit(x1)} нулевых битов");
        Console.Write($"Двоичный код числа {x2} без ведущих нулей: ");
        bin_no_zer(x2);
        Console.Write($"Результат цикличного сдвига числа {x2} на {n} разрядов в право: ");
        cyclic_shift(x2, n);
    }
}
