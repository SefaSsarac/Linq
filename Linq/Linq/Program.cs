using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Rastgele sayı üretmek için Random sınıfını kullanıyoruz.
        Random rnd = new Random();
        List<int> numbers = new List<int>();

        // 10 adet rastgele sayı üretip listeye ekliyoruz. Negatif sayılar için -50 ile 50 arasında oluşturuyoruz.
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(rnd.Next(-50, 51)); // -50 ile 50 arasında rastgele sayılar.
        }

        // Listeyi yazdırıyoruz.
        Console.WriteLine("Oluşturulan Liste:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // 1. Çift olan sayılar
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Çift sayılar:");
        foreach (var number in evenNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // 2. Tek olan sayılar
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Tek sayılar:");
        foreach (var number in oddNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // 3. Negatif sayılar
        var negativeNumbers = numbers.Where(n => n < 0);
        Console.WriteLine("Negatif sayılar:");
        foreach (var number in negativeNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // 4. Pozitif sayılar
        var positiveNumbers = numbers.Where(n => n > 0);
        Console.WriteLine("Pozitif sayılar:");
        foreach (var number in positiveNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // 5. 15'ten büyük ve 22'den küçük sayılar
        var rangeNumbers = numbers.Where(n => n > 15 && n < 22);
        Console.WriteLine("15'ten büyük ve 22'den küçük sayılar:");
        foreach (var number in rangeNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // 6. Listedeki her bir sayının karesi (Yeni bir liste oluşturup yazdırıyoruz.)
        var squaredNumbers = numbers.Select(n => n * n);
        Console.WriteLine("Her bir sayının karesi:");
        foreach (var number in squaredNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
