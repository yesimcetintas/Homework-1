internal class Odev1 
{
    public void firstHomework()
    {
        Console.Write("Pozitif sayı giriniz:");
        int positiveNumber = Convert.ToInt32(Console.ReadLine());

        if (positiveNumber < 0)
        {
            Console.WriteLine("Pozitif bir sayı girmelisiniz");
            return;
        }

        int[] arr = new int[positiveNumber];

        for (int i = 1; i <= positiveNumber; i++)
        {
            Console.Write(i + ". sayıyı giriniz:");
            arr[i - 1] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (var item in arr)
        {
            if (item % 2 == 0)
            {
                Console.WriteLine(item);
            }
        }
    }
}