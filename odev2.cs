// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
// Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

internal class Odev2
{
    public void secondHomework()
    {
        Console.WriteLine("pozitif 2 sayı girmeniz istenmektedir.");

        Console.Write("1. sayıyı giriniz:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Pozitif bir sayı girmelisiniz");
            return;
        }

        Console.Write("2. sayıyı giriniz:");
        int m = Convert.ToInt32(Console.ReadLine());

        if (m < 0)
        {
            Console.WriteLine("Pozitif bir sayı girmelisiniz");
            return;
        }

        int[] tempArr = new int[n];

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + ". pozitif sayıyı giriniz:");
            tempArr[i - 1] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (var number in tempArr)
        {
            if (number % m == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}