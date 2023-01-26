// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
//Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

internal class Odev4
{
    public void fourHomework()
    {
        Console.Write("Cümle giriniz:");
        string sentence = Console.ReadLine();

        string[] sentenceArr = sentence.Split(" ");
        Console.WriteLine("Toplam kelime sayısı:"+sentenceArr.Count());

        int wordLength=0;

        foreach (var word in sentenceArr)
        {
            char[] tempWord = word.ToCharArray();
            wordLength=wordLength+tempWord.Count();
        }

        Console.WriteLine("Harf sayısı:"+wordLength);
        
    }
}