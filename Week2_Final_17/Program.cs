static string UpperCase(string sentence)
{
    return sentence.ToUpper();
}

static string LowerCase(string sentence)
{
    return sentence.ToLower();
}

Console.WriteLine("Bir cumle giriniz:");
string sentence = Console.ReadLine();

string upperCase = UpperCase(sentence);
string lowerCase = LowerCase(sentence);

Console.WriteLine($"Girdiginiz cumlenin buyuk harflerle yazilisi: {upperCase}\nve kucuk harflerle yazilisi: {lowerCase}");