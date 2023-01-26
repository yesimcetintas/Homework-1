// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
// Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
// Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.


internal class Odev3
{
    public  void thirdHomework()
    {
        Console.Write("Pozitif sayıyı giriniz:");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] arr = new string[n];

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + ". kelimeyi giriniz:");
            arr[i - 1] = Console.ReadLine();
        }

        Array.Reverse(arr);
        foreach (var word in arr)
        {
            Console.WriteLine(word);
        }

    }
}