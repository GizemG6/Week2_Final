static string UpperCase(string sentence) // girilen cümlenin tüm harflerini buyuk yazdiran metot
{
    return sentence.ToUpper();
}

static string LowerCase(string sentence) // girilen cümlenin tüm harflerini kucuk yazdiran metot
{
    return sentence.ToLower();
}

Console.WriteLine("Bir cumle giriniz:");
string sentence = Console.ReadLine();

string upperCase = UpperCase(sentence);
string lowerCase = LowerCase(sentence);

Console.WriteLine($"Girdiginiz cumlenin buyuk harflerle yazilisi: {upperCase}\nve kucuk harflerle yazilisi: {lowerCase}");