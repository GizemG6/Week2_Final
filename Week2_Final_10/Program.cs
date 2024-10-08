// Kullanıcıdan true/false alıp string dönen metot
static string TrueOrFalse(bool input)
{
    if (input)
    {
        return "True degeri girdiniz";
    }
    else
    {
        return "False degeri girdiniz";
    }
}

bool userInput;
bool isValidInput = false;

// Kullanıcıdan doğru bir true/false değeri alana kadar döngü
while (!isValidInput)
{
    Console.WriteLine("Lütfen true ya da false giriniz:");
    string input = Console.ReadLine();

    // String değeri bool'a çevirmeye çalış
    isValidInput = bool.TryParse(input, out userInput);

    if (!isValidInput)
    {
        Console.WriteLine("Geçersiz giriş. Lütfen sadece true ya da false giriniz.");
    }
    else if (isValidInput)
    {
        string result = TrueOrFalse(userInput);
        Console.WriteLine(result);
    }
}